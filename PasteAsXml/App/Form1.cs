using LanguageToObjectLibrary.Parser.Configuration;
using LanguageToObjectLibrary.Parser.Models;
using PasteAsXml.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_extensiones.App
{
	public partial class Form1 : Form
	{
		private XmlConfiguration custom = new XmlConfiguration();

		public XmlConfiguration Default { get; set; } = new XmlConfiguration();
		public XmlConfiguration Custom
		{
			get { return custom; }
			set
			{
				custom = value;
				Current = value;
			}
		}

		XmlConfiguration Current { get; set; } = new XmlConfiguration();

		public Form1()
		{
			InitializeComponent();
			FillFields();
		}

		private void FillFields()
		{
			cmbIdsClase.Items.Add(ComboBoxItem.Create(XmlClassDefinition.byNamespaceAndName, XmlClassDefinition.byNamespaceAndName.ToString()));
			cmbIdsClase.Items.Add(ComboBoxItem.Create(XmlClassDefinition.byNamespaceNameAndPath, XmlClassDefinition.byNamespaceNameAndPath.ToString()));
			cmbIdsClase.SelectedIndex = 0;

			for (int i = 0; i < 20; i++)
			{
				cmbMaxDepth.Items.Add(i);
			}
			cmbMaxDepth.SelectedIndex = 0;
		}

		private void LoadConfiguration(XmlConfiguration configuration)
		{
			LoadUsedTypes(configuration);
			LoadCommonOptions(configuration);
			LoadDecorators(configuration);
			LoadFilters(configuration);
		}
		private void SaveConfiguration()
		{
			ProcessUsedTypes();
			ProcessCommonOptions();
			ProcessDecorators();
			ProcessFilters();
		}

		//Loads And Saves de la configuración.
		private void ProcessUsedTypes()
		{
			Current.UsedIntegralTypes = 0;
			Current.UsedIntegralTypes += (chkByte.Checked ? (int)IntegralTypeEnumerator.byteType : 0);
			chkByte.Checked = Current.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.byteType);
			Current.UsedIntegralTypes += (chkSbyte.Checked ? (int)IntegralTypeEnumerator.sbyteType : 0);
			Current.UsedIntegralTypes += (chkUshort.Checked ? (int)IntegralTypeEnumerator.ushortType : 0);
			Current.UsedIntegralTypes += (chkShort.Checked ? (int)IntegralTypeEnumerator.shortType : 0);
			Current.UsedIntegralTypes += (chkUint.Checked ? (int)IntegralTypeEnumerator.uintType : 0);
			Current.UsedIntegralTypes += (chkInt.Checked ? (int)IntegralTypeEnumerator.intType : 0);
			Current.UsedIntegralTypes += (chkUlong.Checked ? (int)IntegralTypeEnumerator.ulongType : 0);
			Current.UsedIntegralTypes += (chkLong.Checked ? (int)IntegralTypeEnumerator.longType : 0);

			Current.UsedFloatingTypes = 0;
			Current.UsedFloatingTypes += (chkFloat.Checked ? (int)FloatingTypeEnumerator.floatType : 0);
			Current.UsedFloatingTypes += (chkDouble.Checked ? (int)FloatingTypeEnumerator.doubleType : 0);
			Current.UsedFloatingTypes += (chkDecimal.Checked ? (int)FloatingTypeEnumerator.decimalType : 0);

			Current.UsedSpecialTypes = 0;
			Current.UsedSpecialTypes += (chkDateTime.Checked ? (int)SpecialTypeEnumerator.datetime : 0);
			Current.UsedSpecialTypes += (chkBool.Checked ? (int)SpecialTypeEnumerator.boolean : 0);
			Current.UsedSpecialTypes += (chkChar.Checked ? (int)SpecialTypeEnumerator.charType : 0);
		}
		private void LoadUsedTypes(XmlConfiguration configuration)
		{
			chkByte.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.byteType);
			chkSbyte.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.sbyteType);
			chkUshort.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ushortType);
			chkShort.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.shortType);
			chkUint.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.uintType);
			chkInt.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.intType);
			chkUlong.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ulongType);
			chkLong.Checked = configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.longType);

			chkFloat.Checked = configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.floatType);
			chkDouble.Checked = configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.doubleType);
			chkDecimal.Checked = configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.decimalType);

			chkDateTime.Checked = configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.datetime);
			chkBool.Checked = configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.boolean);
			chkChar.Checked = configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.charType);
		}

		private void ProcessCommonOptions()
		{
			Current.XmlClassIdentifier = ((ComboBoxItem<XmlClassDefinition, string>)cmbIdsClase.Items[cmbIdsClase.SelectedIndex]).Key;
			Current.maxArrayDepth = ((int)cmbMaxDepth.Items[cmbMaxDepth.SelectedIndex]);
			Current.UseFullProperties = chkFullProperties.Checked;
			Current.ArrayAsList = chkArrayAsList.Checked;
			Current.PropertiesAsClasses = chkPropertiesAsClasses.Checked;
			Current.HideName = chkHideElementName.Checked;
			Current.HideNamespace = chkHideNamespace.Checked;
		}
		private void LoadCommonOptions(XmlConfiguration configuration)
		{
			cmbIdsClase.SelectedIndex = 0;
			for (int i = 0; i < cmbIdsClase.Items.Count; i++)
			{
				if (((ComboBoxItem<XmlClassDefinition, string>)cmbIdsClase.Items[i]).Key == configuration.XmlClassIdentifier)
					cmbIdsClase.SelectedIndex = i;
			}

			cmbMaxDepth.SelectedIndex = 0;
			for (int i = 0; i < cmbMaxDepth.Items.Count; i++)
			{
				if (((int)cmbMaxDepth.Items[i]) == configuration.maxArrayDepth)
					cmbMaxDepth.SelectedIndex = i;
			}

			chkFullProperties.Checked = configuration.UseFullProperties;
			chkArrayAsList.Checked = configuration.ArrayAsList;
			chkPropertiesAsClasses.Checked = configuration.PropertiesAsClasses;
			chkHideElementName.Checked = configuration.HideName;
			chkHideNamespace.Checked = configuration.HideNamespace;
		}

		private void ProcessDecorators()
		{
			Current.RootDecorators = txtRootDecorators.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			Current.ClassDecorators = txtClassDecorators.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			Current.PropertyDecorators = txtPropertyDecorators.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			Current.ArrayDecorators = txtArrayDecorators.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			Current.AttributeDecorators = txtAttributeDecorators.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		}
		private void LoadDecorators(XmlConfiguration configuration)
		{
			txtRootDecorators.Text = string.Join("\n", configuration.RootDecorators);
			txtClassDecorators.Text = string.Join("\n", configuration.ClassDecorators);
			txtPropertyDecorators.Text = string.Join("\n", configuration.PropertyDecorators);
			txtArrayDecorators.Text = string.Join("\n", configuration.ArrayDecorators);
			txtAttributeDecorators.Text = string.Join("\n", configuration.AttributeDecorators);
		}

		private void ProcessFilters()
		{
			Current.IgnoredAttributes = new List<ElementNameFilter>();
			Current.TreatedAsRoot = new List<ElementNameFilter>();
			Current.IgnoredClasses = new List<ElementNameFilter>();

			var listBoxes = new List<(ListBox listBox, List<ElementNameFilter> configList)>()
			{
				(lstIgnoredAttributes, Current.IgnoredAttributes),
				(lstRootClasses,Current.TreatedAsRoot),
				(lstIgnoredClasses,Current.IgnoredClasses)
			};

			for (int i = 0; i < listBoxes.Count; i++)
			{
				foreach (string item in listBoxes[i].listBox.Items)
				{
					Match match = Regex.Match(item, @"(?<namespace>((\[[:]\])|[^:\s]))(?<separator>[:])(?<name>((\[[:]\])|[^:\s]))");
					if (match.Success)
					{
						listBoxes[i].configList.Add(new ElementNameFilter()
						{
							Namespace = match.Groups["namespace"].Value,
							Name = match.Groups["name"].Value
						});
					}
				}
			}
		}
		private void LoadFilters(XmlConfiguration configuration)
		{
			configuration.IgnoredAttributes = new List<ElementNameFilter>();
			configuration.TreatedAsRoot = new List<ElementNameFilter>();
			configuration.IgnoredClasses = new List<ElementNameFilter>();

			var listBoxes = new List<(ListBox listBox, List<ElementNameFilter> configList)>()
			{
				(lstIgnoredAttributes, configuration.IgnoredAttributes),
				(lstRootClasses,configuration.TreatedAsRoot),
				(lstIgnoredClasses,configuration.IgnoredClasses)
			};

			for (int i = 0; i < listBoxes.Count; i++)
			{
				foreach (var item in listBoxes[i].configList)
				{
					var cadena = $"{item.Namespace}:{item.Name}";
					Match match = Regex.Match(cadena, @"(?<namespace>((\[[:]\])|[^:\s]))(?<separator>[:])(?<name>((\[[:]\])|[^:\s]))");
					if (match.Success)
					{
						listBoxes[i].listBox.Items.Add(cadena);
					}
				}
			}
		}

		//EVENTOS
		private void Form1_Load(object sender, EventArgs e)
		{
			Current = (XmlConfiguration)Custom.Clone();
			LoadConfiguration(Custom);
		}

		private void btnListAdd_Click(object sender, EventArgs e)
		{
			FormNameFilter dialog = null;
			ListBox listBox = null;
			if (sender == btnIgnoredAttributesAdd)
			{
				dialog = new FormNameFilter()
				{
					Text = "Add Ignored Attribute"
				};
				listBox = lstIgnoredAttributes;
			}
			else if (sender == btnRootClassesAdd)
			{
				dialog = new FormNameFilter()
				{
					Text = "Add Root Class"
				};
				listBox = lstRootClasses;
			}
			else if (sender == btnIgnoredClassesAdd)
			{
				dialog = new FormNameFilter()
				{
					Text = "Add Ignored Class"
				};
				listBox = lstIgnoredClasses;
			}

			if (dialog != null && listBox != null)
			{
				foreach (string item in listBox.Items)
				{
					Match match = Regex.Match(item, @"(?<namespace>((\[[:]\])|[^:\s]))(?<separator>[:])(?<name>((\[[:]\])|[^:\s]))");
					if (match.Success)
					{
						dialog.Regexes.Add((match.Groups["namespace"].Value, match.Groups["name"].Value));
					}
				}

				dialog.ShowDialog();
				if (dialog.DialogResult == DialogResult.OK)
				{
					listBox.Items.Add($"{dialog.regexNamespace.ToString()}:{dialog.regexName.ToString()}");
				}
			}
		}

		private void btnListRemove_Click(object sender, EventArgs e)
		{
			ListBox listBox = null;
			if (sender == btnIgnoredAttributesRemove)
			{
				listBox = lstIgnoredAttributes;
			}
			else if (sender == btnRootClassesRemove)
			{
				listBox = lstRootClasses;
			}
			else if (sender == btnIgnoredClassesRemove)
			{
				listBox = lstIgnoredClasses;
			}

			if (0 <= listBox.SelectedIndex && listBox.Items.Count > listBox.SelectedIndex)
			{
				listBox.Items.RemoveAt(listBox.SelectedIndex);
			}
		}

		private void BtnAccept_Click(object sender, EventArgs e)
		{
			Current = (XmlConfiguration)Default.Clone();
			LoadConfiguration(Current);
		}

		private void BtnRestoreDefault_Click(object sender, EventArgs e)
		{
			Custom = Current;
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Current = Custom;
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}





}

