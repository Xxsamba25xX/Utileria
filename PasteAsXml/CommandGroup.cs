using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
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
			menuItem.BeforeQueryStatus += MenuItem_BeforeQueryStatus;

		}

		private void MenuItem_BeforeQueryStatus(object sender, EventArgs e)
		{
			
			Debug.WriteLine("asda");
			if (sender is OleMenuCommand)
			{
				(sender as OleMenuCommand).Enabled = !(sender as OleMenuCommand).Enabled;
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

		}

		private void ExecuteConfig(object sender, EventArgs e)
		{

		}
	}
}
