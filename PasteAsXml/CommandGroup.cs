using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using LanguageToObjectLibrary.Parser;
using LanguageToObjectLibrary.Parser.Configuration;
using LanguageToObjectLibrary.Parser.Models;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Settings;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell.Settings;
using PasteAsXml.Utils;
using Prueba_extensiones.App;
using Task = System.Threading.Tasks.Task;

namespace PasteAsXml
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CommandGroup
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int PasterCmdId = 0x0100;
        public const int ConfigCmdId = 0x0200;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("d756f067-ad56-4272-87af-a566f4ea47e5");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandGroup"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private CommandGroup(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, PasterCmdId);
            var menuItem = new OleMenuCommand(this.ExecutePaster, menuCommandID);
            commandService.AddCommand(menuItem);
            menuItem.BeforeQueryStatus += MenuItem_BeforeQueryStatus;


            menuCommandID = new CommandID(CommandSet, ConfigCmdId);
            menuItem = new OleMenuCommand(this.ExecuteConfig, menuCommandID);
            commandService.AddCommand(menuItem);
            menuItem.BeforeQueryStatus += AlwaysOnEvent;
        }

        private void AlwaysOnEvent(object sender, EventArgs e)
        {
            if (sender is OleMenuCommand)
            {
                (sender as OleMenuCommand).Enabled = true;
            }
        }

        private void MenuItem_BeforeQueryStatus(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            if (sender is OleMenuCommand)
            {
                try
                {
                    DTE2 dte = GetDTE();
                    (sender as OleMenuCommand).Enabled = dte.ActiveDocument.FullName.EndsWith(".cs");
                }
                catch (Exception)
                {
                    (sender as OleMenuCommand).Enabled = false;
                }
            }
        }



        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CommandGroup Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in CommandGroup's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new CommandGroup(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void ExecutePaster(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            DTE2 dte = null;
            try
            {
                var configs = LoadConfigurations();

                var xmlParser = new XmlParser(configs.user);

                string classes = xmlParser.GetClasses(Clipboard.GetText());

                dte = GetDTE();

                dte.UndoContext.Open("Paste Text as Comment");
                var selection = (TextSelection)dte.ActiveDocument.Selection;
                if (selection != null)
                {
                    selection.Insert(classes);
                    dte.ActiveDocument.Activate();
                    dte.ExecuteCommand("Edit.FormatDocument");
                }
            }
            finally
            {
                if (dte != null)
                    dte.UndoContext.Close();
            }
        }

        private void ExecuteConfig(object sender, EventArgs e)
        {

            //Obtenemos las configuraciones.
            var configs = LoadConfigurations();

            //Ejecutar el form de la configuración
            var form = new Form1()
            {
                Default = configs.defa,
                Custom = configs.user
            };
            form.ShowDialog();
            if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                configs.user = form.Custom;
            }

            //Salvamos la configuración del usuario
            SaveConfiguration(configs.user);
        }

        private (XmlConfiguration defa, XmlConfiguration user) LoadConfigurations()
        {
            XmlSerializer serializer = new XmlSerializer();
            SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider as Package);
            WritableSettingsStore userSettingsStore = settingsManager.GetWritableSettingsStore(SettingsScope.UserSettings);

            XmlConfiguration defa = GenerateDefault();

            //Obtenemos la Configuración del Usuario
            XmlConfiguration user = GenerateDefault();
            var userString = "";
            try
            {
                userString = userSettingsStore.GetString("External Tools", "UserConfiguration");
                user = serializer.DeserializeObject<XmlConfiguration>(userString);
            }
            catch (Exception) { }

            return (defa, user);
        }

        private void SaveConfiguration(XmlConfiguration config)
        {
            XmlSerializer serializer = new XmlSerializer();
            SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider as Package);
            WritableSettingsStore userSettingsStore = settingsManager.GetWritableSettingsStore(SettingsScope.UserSettings);

            try
            {
                var configString = serializer.SerializeObject(config);
                userSettingsStore.SetString("External Tools", "UserConfiguration", configString);
            }
            catch (Exception) { }
        }


        private XmlConfiguration GenerateDefault()
        {
            return new XmlConfiguration()
            {
                ArrayDecorators = new List<string>(),
                AttributeDecorators = new List<string>(),
                ClassDecorators = new List<string>(),
                PropertyDecorators = new List<string>(),
                RootDecorators = new List<string>(),
                IgnoredAttributes=new List<ElementNameFilter>()
                {
                },
                TreatedAsRoot=new List<ElementNameFilter>()
                {
                },
                IgnoredClasses=new List<ElementNameFilter>()
                {
                },
                ArrayAsList = false,
                HideName = true,
                HideNamespace = true,
                PropertiesAsClasses = true,
                UseFullProperties = true,
                XmlClassIdentifier = XmlClassDefinition.byNamespaceNameAndPath,
                UsedFloatingTypes = FloatingTypeEnumerator.decimalType | FloatingTypeEnumerator.doubleType,
                UsedIntegralTypes = IntegralTypeEnumerator.longType | IntegralTypeEnumerator.intType,
                UsedSpecialTypes = SpecialTypeEnumerator.boolean | SpecialTypeEnumerator.charType,
                maxArrayDepth = 0,
            };
        }

        private DTE2 _dte = null;
        DTE2 GetDTE()
        {
            if (_dte == null)
            {
                _dte = Package.GetGlobalService(typeof(SDTE)) as DTE2;
            }

            return _dte;
        }

        private IVsEditorAdaptersFactoryService _adapterFactoryService = null;
        IVsEditorAdaptersFactoryService GetAdapterFactoryService()
        {
            if (_adapterFactoryService == null)
            {
                IComponentModel componentModel = (IComponentModel)Package.GetGlobalService(typeof(SComponentModel));
                _adapterFactoryService = componentModel.GetService<IVsEditorAdaptersFactoryService>();
            }
            return _adapterFactoryService;
        }
    }
}
