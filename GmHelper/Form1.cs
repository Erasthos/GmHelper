using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GmHelper
{
    public partial class Form1 : Form
    {
        private string folderPath;
        private string Text1 = "Seleccione la carpeta donde se encuentran sus macros.";
        private string Text2 = "Configuración.";
        private string Text3 = "Se encontraron coincidencias en los siguientes archivos:\n\n";
        private string Text4 = "Resultados de la búsqueda";
        private string Text5 = "No se encontraron coincidencias.";
        private string Text6 = "ID misión";
        private string Text7 = "Buscar en WowHead";
        private string Text8 = "Buscar";
        private string Text9 = "Carpeta Macros";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchTextBox.Text = Text6;
            checkBox1.Text = Text7;
            searchButton.Text = Text8;
            selectFolderButton.Text = Text9;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\GmHelper");

            if (registryKey != null)
            {
                folderPath = (string)registryKey.GetValue("folderPath");
                registryKey.Close();
            }

            else
            {
                MessageBox.Show(Text1, Text2);
                selectFolderButton_Click(null, EventArgs.Empty);
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (RectangleToScreen(Bounds).Contains(PointToScreen(Cursor.Position)))
            {
                case true:
                    if (Opacity >= 1) { }
                    else
                    {
                        Opacity += 0.20;

                    }
                    break;
                case false:
                    if (Opacity >= 0.21)
                    {
                        Opacity -= 0.20;

                    }
                    break;
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = String.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text;
            string[] files = Directory.GetFiles(folderPath);
            string resultFiles = "";

            foreach (string file in files)
            {
                string fileText = File.ReadAllText(file);
                if (fileText.Contains(searchTerm))
                {
                    resultFiles += Path.GetFileName(file) + "\n";
                }
            }

            if (resultFiles.Length > 0)
            {
                MessageBox.Show(Text3 + resultFiles, Text4);
                if (checkBox1.Checked == true)
                {
                    string wowheadLink = "https://wowhead.com/es/quest=" + searchTerm;
                    Process.Start(wowheadLink);
                }
            }
            else
            {
                MessageBox.Show(Text5, Text4);
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    folderPath = selectedFolderPath;

                    RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GmHelper");
                    registryKey.SetValue("folderPath", folderPath);
                    registryKey.Close();
                }
                else
                {
                    selectFolderButton_Click(null, EventArgs.Empty);
                }
            }
        }
    }
}
