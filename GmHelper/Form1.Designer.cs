namespace GmHelper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extra_1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extra_2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extra_1_Button = new System.Windows.Forms.Button();
            this.extra_2_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.AcceptsReturn = true;
            this.searchTextBox.Location = new System.Drawing.Point(7, 40);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(7, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SearchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.menuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.menuToolStripMenuItem.Text = "Macros";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.macrosToolStripMenuItem_Click);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extra_1_ToolStripMenuItem,
            this.extra_2_ToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.archivosToolStripMenuItem.Text = "Notas";
            // 
            // extra_1_ToolStripMenuItem
            // 
            this.extra_1_ToolStripMenuItem.Name = "extra_1_ToolStripMenuItem";
            this.extra_1_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extra_1_ToolStripMenuItem.Text = "Notas 1";
            this.extra_1_ToolStripMenuItem.Click += new System.EventHandler(this.extra_1_ToolStripMenuItem_Click);
            // 
            // extra_2_ToolStripMenuItem
            // 
            this.extra_2_ToolStripMenuItem.Name = "extra_2_ToolStripMenuItem";
            this.extra_2_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extra_2_ToolStripMenuItem.Text = "Notas 2";
            this.extra_2_ToolStripMenuItem.Click += new System.EventHandler(this.extra_2_ToolStripMenuItem_Click);
            // 
            // extra_1_Button
            // 
            this.extra_1_Button.Location = new System.Drawing.Point(88, 68);
            this.extra_1_Button.Name = "extra_1_Button";
            this.extra_1_Button.Size = new System.Drawing.Size(75, 23);
            this.extra_1_Button.TabIndex = 5;
            this.extra_1_Button.Text = "Extra";
            this.extra_1_Button.UseVisualStyleBackColor = true;
            this.extra_1_Button.Click += new System.EventHandler(this.extra_1_Button_Click);
            // 
            // extra_2_Button
            // 
            this.extra_2_Button.Location = new System.Drawing.Point(170, 68);
            this.extra_2_Button.Name = "extra_2_Button";
            this.extra_2_Button.Size = new System.Drawing.Size(75, 23);
            this.extra_2_Button.TabIndex = 6;
            this.extra_2_Button.Text = "Extra";
            this.extra_2_Button.UseVisualStyleBackColor = true;
            this.extra_2_Button.Click += new System.EventHandler(this.extra_2_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 109);
            this.Controls.Add(this.extra_2_Button);
            this.Controls.Add(this.extra_1_Button);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.2D;
            this.Text = "GmHelper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SearchTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button extra_1_Button;
        private System.Windows.Forms.Button extra_2_Button;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extra_1_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extra_2_ToolStripMenuItem;
    }
}

