﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_extensiones.App
{
	public partial class Form1 : Form
	{
		ResourceManager rm = new ResourceManager(typeof(Form1));

		public Form1(Microsoft.VisualStudio.Settings.WritableSettingsStore userSettingsStore)
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}