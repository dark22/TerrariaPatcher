﻿extern alias PluginLoaderXNA;
using System;
using System.Reflection;
using System.Windows.Forms;
using PluginLoaderXNA::PluginLoader;

namespace TerrariaPatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;

            if (!Utils.IsProcessElevated)
                MessageBox.Show("Elevated administrator privileges not detected, you could run into issues!", AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        internal static string AssemblyName;

        /// <summary>
        /// Displays an error message.
        /// </summary>
        public static void ShowErrorMessage(string err)
        {
            MessageBox.Show(err, AssemblyName + " :: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
