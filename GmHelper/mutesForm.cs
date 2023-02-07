using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GmHelper
{
    public partial class mutesForm : Form
    {
        private readonly string mutesPath;
        private readonly string F2text1 = "Copiar";        
        public mutesForm(string mutesPath)
        {
            InitializeComponent();
            this.mutesPath = mutesPath;            
    }

        private void mutesForm_Load(object sender, EventArgs e)
        {
            string line;
            int y = 10;

            try
            {
                using (StreamReader sr = new StreamReader(mutesPath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Trim() != "")
                        {
                            TextBox textBox = new TextBox();
                            textBox.Text = line;
                            textBox.ReadOnly = false;
                            textBox.Location = new Point(10, y);
                            textBox.Width = 550;
                            Button button = new Button();
                            button.Text = F2text1;
                            button.Location = new Point(570, y);
                            button.Click += (s, ev) =>
                            {
                                Clipboard.SetText(textBox.Text);
                            };

                            panel1.Controls.Add(textBox);
                            panel1.Controls.Add(button);
                            y += 25;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
         

                int maxY = panel1.Controls.OfType<TextBox>().Max(x => x.Bottom);
                int maxX = panel1.Controls.OfType<Button>().Max(x => x.Right);
                this.Height = maxY + 60;
                this.Width = maxX + 30;
           

        }
    }
}
