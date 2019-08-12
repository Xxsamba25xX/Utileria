namespace Prueba_extensiones.App
{
	partial class FormNameFilter
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpNamespace = new System.Windows.Forms.GroupBox();
			this.chkNamespaceCaseSensitive = new System.Windows.Forms.CheckBox();
			this.rdNamespaceRegex = new System.Windows.Forms.RadioButton();
			this.chkNamespaceAnchored = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.txtNamespace = new System.Windows.Forms.TextBox();
			this.lblNamespaceResult = new System.Windows.Forms.Label();
			this.rdNamespaceText = new System.Windows.Forms.RadioButton();
			this.rdNamespaceAny = new System.Windows.Forms.RadioButton();
			this.grpName = new System.Windows.Forms.GroupBox();
			this.chkNameCaseSensitive = new System.Windows.Forms.CheckBox();
			this.rdNameRegex = new System.Windows.Forms.RadioButton();
			this.chkNameAnchored = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblNameResult = new System.Windows.Forms.Label();
			this.chkNameText = new System.Windows.Forms.RadioButton();
			this.chkNameAny = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.grpPrefix = new System.Windows.Forms.GroupBox();
			this.chkPrefixCaseSensitive = new System.Windows.Forms.CheckBox();
			this.rdPrefixRegex = new System.Windows.Forms.RadioButton();
			this.chkPrefixAnchored = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.lblPrefixResult = new System.Windows.Forms.Label();
			this.rdPrefixText = new System.Windows.Forms.RadioButton();
			this.rdPrefixAny = new System.Windows.Forms.RadioButton();
			this.grpNamespace.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.grpName.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.grpPrefix.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpNamespace
			// 
			this.grpNamespace.AutoSize = true;
			this.grpNamespace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.grpNamespace.Controls.Add(this.chkNamespaceCaseSensitive);
			this.grpNamespace.Controls.Add(this.rdNamespaceRegex);
			this.grpNamespace.Controls.Add(this.chkNamespaceAnchored);
			this.grpNamespace.Controls.Add(this.flowLayoutPanel2);
			this.grpNamespace.Controls.Add(this.rdNamespaceText);
			this.grpNamespace.Controls.Add(this.rdNamespaceAny);
			this.grpNamespace.Location = new System.Drawing.Point(12, 12);
			this.grpNamespace.Name = "grpNamespace";
			this.grpNamespace.Size = new System.Drawing.Size(197, 208);
			this.grpNamespace.TabIndex = 3;
			this.grpNamespace.TabStop = false;
			this.grpNamespace.Text = "Namespace";
			// 
			// chkNamespaceCaseSensitive
			// 
			this.chkNamespaceCaseSensitive.AutoSize = true;
			this.chkNamespaceCaseSensitive.Location = new System.Drawing.Point(6, 172);
			this.chkNamespaceCaseSensitive.Name = "chkNamespaceCaseSensitive";
			this.chkNamespaceCaseSensitive.Size = new System.Drawing.Size(96, 17);
			this.chkNamespaceCaseSensitive.TabIndex = 6;
			this.chkNamespaceCaseSensitive.Text = "Case Sensitive";
			this.chkNamespaceCaseSensitive.UseVisualStyleBackColor = true;
			this.chkNamespaceCaseSensitive.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// rdNamespaceRegex
			// 
			this.rdNamespaceRegex.AutoSize = true;
			this.rdNamespaceRegex.Location = new System.Drawing.Point(6, 68);
			this.rdNamespaceRegex.Name = "rdNamespaceRegex";
			this.rdNamespaceRegex.Size = new System.Drawing.Size(56, 17);
			this.rdNamespaceRegex.TabIndex = 12;
			this.rdNamespaceRegex.Text = "Regex";
			this.rdNamespaceRegex.UseVisualStyleBackColor = true;
			this.rdNamespaceRegex.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// chkNamespaceAnchored
			// 
			this.chkNamespaceAnchored.AutoSize = true;
			this.chkNamespaceAnchored.Location = new System.Drawing.Point(6, 149);
			this.chkNamespaceAnchored.Name = "chkNamespaceAnchored";
			this.chkNamespaceAnchored.Size = new System.Drawing.Size(72, 17);
			this.chkNamespaceAnchored.TabIndex = 5;
			this.chkNamespaceAnchored.Text = "Anchored";
			this.chkNamespaceAnchored.UseVisualStyleBackColor = true;
			this.chkNamespaceAnchored.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Controls.Add(this.txtNamespace);
			this.flowLayoutPanel2.Controls.Add(this.lblNamespaceResult);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 91);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(185, 52);
			this.flowLayoutPanel2.TabIndex = 13;
			// 
			// txtNamespace
			// 
			this.txtNamespace.Location = new System.Drawing.Point(3, 3);
			this.txtNamespace.Name = "txtNamespace";
			this.txtNamespace.Size = new System.Drawing.Size(179, 20);
			this.txtNamespace.TabIndex = 0;
			this.txtNamespace.TextChanged += new System.EventHandler(this.txtTextChanged);
			// 
			// lblNamespaceResult
			// 
			this.lblNamespaceResult.AutoSize = true;
			this.lblNamespaceResult.Location = new System.Drawing.Point(3, 29);
			this.lblNamespaceResult.Margin = new System.Windows.Forms.Padding(3);
			this.lblNamespaceResult.MinimumSize = new System.Drawing.Size(0, 20);
			this.lblNamespaceResult.Name = "lblNamespaceResult";
			this.lblNamespaceResult.Size = new System.Drawing.Size(0, 20);
			this.lblNamespaceResult.TabIndex = 2;
			this.lblNamespaceResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rdNamespaceText
			// 
			this.rdNamespaceText.AutoSize = true;
			this.rdNamespaceText.Location = new System.Drawing.Point(6, 45);
			this.rdNamespaceText.Name = "rdNamespaceText";
			this.rdNamespaceText.Size = new System.Drawing.Size(46, 17);
			this.rdNamespaceText.TabIndex = 11;
			this.rdNamespaceText.Text = "Text";
			this.rdNamespaceText.UseVisualStyleBackColor = true;
			this.rdNamespaceText.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// rdNamespaceAny
			// 
			this.rdNamespaceAny.AutoSize = true;
			this.rdNamespaceAny.Checked = true;
			this.rdNamespaceAny.Location = new System.Drawing.Point(6, 22);
			this.rdNamespaceAny.Name = "rdNamespaceAny";
			this.rdNamespaceAny.Size = new System.Drawing.Size(43, 17);
			this.rdNamespaceAny.TabIndex = 10;
			this.rdNamespaceAny.TabStop = true;
			this.rdNamespaceAny.Text = "Any";
			this.rdNamespaceAny.UseVisualStyleBackColor = true;
			this.rdNamespaceAny.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// grpName
			// 
			this.grpName.AutoSize = true;
			this.grpName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.grpName.Controls.Add(this.chkNameCaseSensitive);
			this.grpName.Controls.Add(this.rdNameRegex);
			this.grpName.Controls.Add(this.chkNameAnchored);
			this.grpName.Controls.Add(this.flowLayoutPanel1);
			this.grpName.Controls.Add(this.chkNameText);
			this.grpName.Controls.Add(this.chkNameAny);
			this.grpName.Location = new System.Drawing.Point(468, 12);
			this.grpName.Name = "grpName";
			this.grpName.Size = new System.Drawing.Size(197, 208);
			this.grpName.TabIndex = 4;
			this.grpName.TabStop = false;
			this.grpName.Text = "Name";
			// 
			// chkNameCaseSensitive
			// 
			this.chkNameCaseSensitive.AutoSize = true;
			this.chkNameCaseSensitive.Location = new System.Drawing.Point(6, 172);
			this.chkNameCaseSensitive.Name = "chkNameCaseSensitive";
			this.chkNameCaseSensitive.Size = new System.Drawing.Size(96, 17);
			this.chkNameCaseSensitive.TabIndex = 15;
			this.chkNameCaseSensitive.Text = "Case Sensitive";
			this.chkNameCaseSensitive.UseVisualStyleBackColor = true;
			this.chkNameCaseSensitive.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// rdNameRegex
			// 
			this.rdNameRegex.AutoSize = true;
			this.rdNameRegex.Location = new System.Drawing.Point(6, 67);
			this.rdNameRegex.Name = "rdNameRegex";
			this.rdNameRegex.Size = new System.Drawing.Size(56, 17);
			this.rdNameRegex.TabIndex = 18;
			this.rdNameRegex.Text = "Regex";
			this.rdNameRegex.UseVisualStyleBackColor = true;
			this.rdNameRegex.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// chkNameAnchored
			// 
			this.chkNameAnchored.AutoSize = true;
			this.chkNameAnchored.Location = new System.Drawing.Point(6, 149);
			this.chkNameAnchored.Name = "chkNameAnchored";
			this.chkNameAnchored.Size = new System.Drawing.Size(72, 17);
			this.chkNameAnchored.TabIndex = 14;
			this.chkNameAnchored.Text = "Anchored";
			this.chkNameAnchored.UseVisualStyleBackColor = true;
			this.chkNameAnchored.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.txtName);
			this.flowLayoutPanel1.Controls.Add(this.lblNameResult);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 88);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(185, 52);
			this.flowLayoutPanel1.TabIndex = 19;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(3, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(179, 20);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtTextChanged);
			// 
			// lblNameResult
			// 
			this.lblNameResult.AutoSize = true;
			this.lblNameResult.Location = new System.Drawing.Point(3, 29);
			this.lblNameResult.Margin = new System.Windows.Forms.Padding(3);
			this.lblNameResult.MinimumSize = new System.Drawing.Size(0, 20);
			this.lblNameResult.Name = "lblNameResult";
			this.lblNameResult.Size = new System.Drawing.Size(0, 20);
			this.lblNameResult.TabIndex = 2;
			this.lblNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkNameText
			// 
			this.chkNameText.AutoSize = true;
			this.chkNameText.Location = new System.Drawing.Point(6, 44);
			this.chkNameText.Name = "chkNameText";
			this.chkNameText.Size = new System.Drawing.Size(46, 17);
			this.chkNameText.TabIndex = 17;
			this.chkNameText.Text = "Text";
			this.chkNameText.UseVisualStyleBackColor = true;
			this.chkNameText.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// chkNameAny
			// 
			this.chkNameAny.AutoSize = true;
			this.chkNameAny.Checked = true;
			this.chkNameAny.Location = new System.Drawing.Point(6, 21);
			this.chkNameAny.Name = "chkNameAny";
			this.chkNameAny.Size = new System.Drawing.Size(43, 17);
			this.chkNameAny.TabIndex = 16;
			this.chkNameAny.TabStop = true;
			this.chkNameAny.Text = "Any";
			this.chkNameAny.UseVisualStyleBackColor = true;
			this.chkNameAny.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(590, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 226);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// grpPrefix
			// 
			this.grpPrefix.AutoSize = true;
			this.grpPrefix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.grpPrefix.Controls.Add(this.chkPrefixCaseSensitive);
			this.grpPrefix.Controls.Add(this.rdPrefixRegex);
			this.grpPrefix.Controls.Add(this.chkPrefixAnchored);
			this.grpPrefix.Controls.Add(this.flowLayoutPanel3);
			this.grpPrefix.Controls.Add(this.rdPrefixText);
			this.grpPrefix.Controls.Add(this.rdPrefixAny);
			this.grpPrefix.Location = new System.Drawing.Point(240, 12);
			this.grpPrefix.Name = "grpPrefix";
			this.grpPrefix.Size = new System.Drawing.Size(197, 208);
			this.grpPrefix.TabIndex = 3;
			this.grpPrefix.TabStop = false;
			this.grpPrefix.Text = "Prefix";
			// 
			// chkPrefixCaseSensitive
			// 
			this.chkPrefixCaseSensitive.AutoSize = true;
			this.chkPrefixCaseSensitive.Location = new System.Drawing.Point(6, 172);
			this.chkPrefixCaseSensitive.Name = "chkPrefixCaseSensitive";
			this.chkPrefixCaseSensitive.Size = new System.Drawing.Size(96, 17);
			this.chkPrefixCaseSensitive.TabIndex = 6;
			this.chkPrefixCaseSensitive.Text = "Case Sensitive";
			this.chkPrefixCaseSensitive.UseVisualStyleBackColor = true;
			this.chkPrefixCaseSensitive.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// rdPrefixRegex
			// 
			this.rdPrefixRegex.AutoSize = true;
			this.rdPrefixRegex.Location = new System.Drawing.Point(6, 68);
			this.rdPrefixRegex.Name = "rdPrefixRegex";
			this.rdPrefixRegex.Size = new System.Drawing.Size(56, 17);
			this.rdPrefixRegex.TabIndex = 12;
			this.rdPrefixRegex.Text = "Regex";
			this.rdPrefixRegex.UseVisualStyleBackColor = true;
			this.rdPrefixRegex.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// chkPrefixAnchored
			// 
			this.chkPrefixAnchored.AutoSize = true;
			this.chkPrefixAnchored.Location = new System.Drawing.Point(6, 149);
			this.chkPrefixAnchored.Name = "chkPrefixAnchored";
			this.chkPrefixAnchored.Size = new System.Drawing.Size(72, 17);
			this.chkPrefixAnchored.TabIndex = 5;
			this.chkPrefixAnchored.Text = "Anchored";
			this.chkPrefixAnchored.UseVisualStyleBackColor = true;
			this.chkPrefixAnchored.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel3.Controls.Add(this.txtPrefix);
			this.flowLayoutPanel3.Controls.Add(this.lblPrefixResult);
			this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 91);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(185, 52);
			this.flowLayoutPanel3.TabIndex = 13;
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(3, 3);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(179, 20);
			this.txtPrefix.TabIndex = 0;
			this.txtPrefix.TextChanged += new System.EventHandler(this.txtTextChanged);
			// 
			// lblPrefixResult
			// 
			this.lblPrefixResult.AutoSize = true;
			this.lblPrefixResult.Location = new System.Drawing.Point(3, 29);
			this.lblPrefixResult.Margin = new System.Windows.Forms.Padding(3);
			this.lblPrefixResult.MinimumSize = new System.Drawing.Size(0, 20);
			this.lblPrefixResult.Name = "lblPrefixResult";
			this.lblPrefixResult.Size = new System.Drawing.Size(0, 20);
			this.lblPrefixResult.TabIndex = 2;
			this.lblPrefixResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rdPrefixText
			// 
			this.rdPrefixText.AutoSize = true;
			this.rdPrefixText.Location = new System.Drawing.Point(6, 45);
			this.rdPrefixText.Name = "rdPrefixText";
			this.rdPrefixText.Size = new System.Drawing.Size(46, 17);
			this.rdPrefixText.TabIndex = 11;
			this.rdPrefixText.Text = "Text";
			this.rdPrefixText.UseVisualStyleBackColor = true;
			this.rdPrefixText.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// rdPrefixAny
			// 
			this.rdPrefixAny.AutoSize = true;
			this.rdPrefixAny.Checked = true;
			this.rdPrefixAny.Location = new System.Drawing.Point(6, 22);
			this.rdPrefixAny.Name = "rdPrefixAny";
			this.rdPrefixAny.Size = new System.Drawing.Size(43, 17);
			this.rdPrefixAny.TabIndex = 10;
			this.rdPrefixAny.TabStop = true;
			this.rdPrefixAny.Text = "Any";
			this.rdPrefixAny.UseVisualStyleBackColor = true;
			this.rdPrefixAny.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// FormNameFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 259);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.grpName);
			this.Controls.Add(this.grpPrefix);
			this.Controls.Add(this.grpNamespace);
			this.Name = "FormNameFilter";
			this.Text = "FormNameFilter";
			this.grpNamespace.ResumeLayout(false);
			this.grpNamespace.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.grpName.ResumeLayout(false);
			this.grpName.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.grpPrefix.ResumeLayout(false);
			this.grpPrefix.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox grpNamespace;
		private System.Windows.Forms.RadioButton rdNamespaceRegex;
		private System.Windows.Forms.CheckBox chkNamespaceAnchored;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.TextBox txtNamespace;
		private System.Windows.Forms.Label lblNamespaceResult;
		private System.Windows.Forms.RadioButton rdNamespaceText;
		private System.Windows.Forms.RadioButton rdNamespaceAny;
		private System.Windows.Forms.GroupBox grpName;
		private System.Windows.Forms.RadioButton rdNameRegex;
		private System.Windows.Forms.CheckBox chkNameAnchored;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblNameResult;
		private System.Windows.Forms.RadioButton chkNameText;
		private System.Windows.Forms.RadioButton chkNameAny;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox chkNamespaceCaseSensitive;
		private System.Windows.Forms.CheckBox chkNameCaseSensitive;
		private System.Windows.Forms.GroupBox grpPrefix;
		private System.Windows.Forms.CheckBox chkPrefixCaseSensitive;
		private System.Windows.Forms.RadioButton rdPrefixRegex;
		private System.Windows.Forms.CheckBox chkPrefixAnchored;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label lblPrefixResult;
		private System.Windows.Forms.RadioButton rdPrefixText;
		private System.Windows.Forms.RadioButton rdPrefixAny;
	}
}