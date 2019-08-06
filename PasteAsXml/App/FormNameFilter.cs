using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_extensiones.App
{
	public partial class FormNameFilter : Form
	{
		public Regex regexNamespace = new Regex("");
		public Regex regexName = new Regex("");
		Regex inside = new Regex(@"^(\/)?(?<inside>.*?)(\/|(?<ignoreCase>\/i))?$", RegexOptions.IgnoreCase);

		public List<(string key, string value)> Regexes { get; set; } = new List<(string key, string value)>();

		public FormNameFilter()
		{
			InitializeComponent();
			UpdateLabel(lblNamespaceResult, lblNamespaceResult.Parent as FlowLayoutPanel, lblNamespaceResult.Parent.Parent as GroupBox);
			UpdateLabel(lblNameResult, lblNameResult.Parent as FlowLayoutPanel, lblNameResult.Parent.Parent as GroupBox);
		}

		private void txtTextChanged(object sender, EventArgs e)
		{
			var box = sender as TextBox;

			if (box.Enabled == false) return;

			while (true)
			{
				var selectionStart = box.SelectionStart;
				var indexRemoved = box.Text.IndexOf(":");
				if (indexRemoved == -1) break;
				box.Enabled = false;
				box.Text = box.Text.Remove(indexRemoved, 1);
				box.Enabled = true;
				box.Focus();
				box.SelectionStart = Math.Min(selectionStart >= indexRemoved ? selectionStart - 1 : selectionStart, box.Text.Length);
				box.SelectionLength = 0;
			}

			UpdateLabel((sender as Control).Parent.Controls.OfType<Label>().First(), (sender as Control).Parent as FlowLayoutPanel, (sender as Control).Parent.Parent as GroupBox);
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			Label label = (sender as Control).Parent == grpNamespace ? lblNamespaceResult : lblNameResult;
			UpdateLabel(label, label.Parent as FlowLayoutPanel, (sender as Control).Parent as GroupBox);
		}

		private void UpdateLabel(Label me, FlowLayoutPanel parent, GroupBox grandParent)
		{
			var radioButtons = grandParent.Controls.OfType<RadioButton>();
			var checkBoxes = grandParent.Controls.OfType<CheckBox>();

			var textBox = parent.Controls.OfType<TextBox>().First();
			var rdType = GetRDType(radioButtons.FirstOrDefault(x => x.Checked) ?? radioButtons.FirstOrDefault());
			bool anchored = checkBoxes.First(x => x.Name.Contains("Anchored")).Checked;
			bool caseInsensitive = checkBoxes.First(x => x.Name.Contains("CaseSensitive")).Checked;
			bool isNamespace = grandParent.Name.Contains("Namespace");

			textBox.Enabled = rdType != txtType.Any;

			StringBuilder strLabel = new StringBuilder();
			strLabel.Clear();
			switch (rdType)
			{
				case txtType.Any:
					strLabel.Append(".*?");
					break;
				case txtType.Text:
					strLabel.Append(GetText(textBox.Text));
					break;
				case txtType.Regex:
					strLabel.Append(textBox.Text);
					break;
				default:
					strLabel.Append(".*?");
					break;
			}

			if (anchored)
			{
				strLabel.Insert(0, "^");
				strLabel.Append("$");
			}

			if (caseInsensitive)
			{
				strLabel.Insert(0, "/");
				strLabel.Append("/i");
			}
			me.Text = strLabel.ToString();
		}

		private string GetText(string text)
		{
			Regex specialChars = new Regex(@"[\/\[\]]");
			text = text.Replace("\\", "\\\\");
			text = Regex.Replace(text, @"[^\w\s\d]", (x => (specialChars.IsMatch(x.Value)) ? $"[\\{x.Value}]" : $"[{x.Value}]"));
			return text;
		}

		private txtType GetRDType(RadioButton radioButtonSelected)
		{
			radioButtonSelected.Checked = true;

			if (radioButtonSelected.Name.Contains("Any"))
				return txtType.Any;
			if (radioButtonSelected.Name.Contains("Text"))
				return txtType.Text;
			if (radioButtonSelected.Name.Contains("Regex"))
				return txtType.Regex;

			return txtType.Any;
		}

		private bool valuateRegexes()
		{
			try
			{
				Match namespaceMatch = inside.Match(lblNamespaceResult.Text);
				bool ignoreCase = namespaceMatch.Groups["ignoreCase"].Success;
				regexNamespace = new Regex(namespaceMatch.Value, ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None);
			}
			catch (Exception)
			{
				MessageBox.Show("Hubo un error al validar el Regex Namespace, revisalo bien.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			try
			{
				Match nameMatch = inside.Match(lblNamespaceResult.Text);
				bool ignoreCase = nameMatch.Groups["ignoreCase"].Success;
				regexName = new Regex(nameMatch.Value, ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None);
			}
			catch (Exception)
			{
				MessageBox.Show("Hubo un error al validar el Regex Name, revisalo bien.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (Regexes.Any(x => x.key == lblNamespaceResult.Text && x.value == lblNameResult.Text))
			{
				MessageBox.Show("Ya se ha ingresado un Regex igual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void ButtonOk_Click(object sender, EventArgs e)
		{
			if (valuateRegexes())
			{
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{

			}
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			regexName = null;
			regexNamespace = null;
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}

	enum txtType
	{
		Any = 0,
		Text = 1,
		Regex = 2
	}
}
