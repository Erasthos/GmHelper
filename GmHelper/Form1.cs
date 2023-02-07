using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GmHelper
{
    public partial class Form1 : Form
    {
        private string macrosfolderPath = String.Empty;
        private string mutesPath = string.Empty;
        private readonly string F1Text1 = "Seleccione la carpeta donde se encuentran sus macros.";
        private readonly string F1Text2 = "Configuración.";
        private readonly string F1Text3 = "Se encontraron coincidencias en los siguientes archivos:\n\n";
        private readonly string F1Text4 = "Desea buscar en WowHead ?";
        private readonly string F1Text5 = "No se encontraron coincidencias.";
        private readonly string F1Text6 = "ID misión";
        private readonly string F1Text8 = "Buscar";
        private readonly string F1Text9 = "Mutes";
        private readonly string F1Text11 = "Seleccione el archivo donde se encuentran sus sanciones.";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            searchTextBox.Text = F1Text6;
            searchButton.Text = F1Text8;
            mutesButton.Text = F1Text9;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\GmHelper");

            if (registryKey != null)
            {
                macrosfolderPath = (string)registryKey.GetValue("macrosfolderPath");
                mutesPath = (string)registryKey.GetValue("mutesPath");
                registryKey.Close();
            }
            else
            {
                macrosToolStripMenuItem_Click(null, EventArgs.Empty);
                mutesToolStripMenuItem_Click(null, EventArgs.Empty);
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
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(null, EventArgs.Empty);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(macrosfolderPath))
            {
                macrosToolStripMenuItem_Click(null, EventArgs.Empty);
            }

            string searchTerm = searchTextBox.Text;
           
            bool success = int.TryParse(searchTerm, out int r);

            if (success) 
            {
                string[] files = Directory.GetFiles(macrosfolderPath);
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
                    DialogResult result = MessageBox.Show(F1Text3 + resultFiles, F1Text4, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string wowheadLink = "https://wowhead.com/es/quest=" + searchTerm;
                        Process.Start(wowheadLink);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(F1Text5, F1Text4, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string wowheadLink = "https://wowhead.com/es/quest=" + searchTerm;
                        Process.Start(wowheadLink);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(F1Text4, F1Text5, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string wowheadLink = "https://www.wowhead.com/es/search?q=" + searchTerm;
                    Process.Start(wowheadLink);
                }
            }

            
        }
        private void macrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(F1Text1, F1Text2);
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    macrosfolderPath = selectedFolderPath;
                    RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GmHelper");
                    registryKey.SetValue("macrosfolderPath", macrosfolderPath);
                    registryKey.Close();
                }
                else
                {
                    if (macrosfolderPath.Length == 0)
                    {
                        macrosToolStripMenuItem_Click(null, EventArgs.Empty);
                    }
                }
            }
        }
        private void mutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(F1Text11, F1Text2);
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mutesPath = openFileDialog1.FileName;
                RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GmHelper");
                registryKey.SetValue("mutesPath", mutesPath);
                registryKey.Close();
            }
            else
            {
                if (mutesPath.Length == 0)
                {
                    mutesToolStripMenuItem_Click(null, EventArgs.Empty);
                }
            }
        }
        private void mutesButton_Click(object sender, EventArgs e)
        {

            mutesForm form = Application.OpenForms.OfType<mutesForm>().FirstOrDefault();

            if (!File.Exists(mutesPath))
            {
                mutesToolStripMenuItem_Click(null, EventArgs.Empty);
                

            }

            if (form == null && mutesPath != String.Empty)
            {
                mutesForm frm = new mutesForm(mutesPath);
                frm.Show();              
            }
            else
            {
                form.Close();
            }
        }       

    }
}
