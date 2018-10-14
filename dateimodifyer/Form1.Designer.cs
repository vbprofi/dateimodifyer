namespace dateimodifyer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.tsMenuDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuOrdner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuFragezeichen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuFolderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dateiname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Durchsuchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zeitangabe Datum: TT.MM.JJJJ";
            // 
            // button2
            // 
            this.button2.AccessibleName = "Änderungsdatum ändern";
            this.button2.Location = new System.Drawing.Point(130, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Auf \'Zuletzt geändert\' anwenden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zeitangabe Uhrzeit: HH:MM:SS";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.AccessibleName = "Zugriffsdatum ändern";
            this.button3.Location = new System.Drawing.Point(260, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Auf \'letzter Zugriff\' anwenden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "Erstellungsdatum ändern";
            this.button4.Location = new System.Drawing.Point(0, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 43);
            this.button4.TabIndex = 7;
            this.button4.Text = "Auf \'Erstellt am\' anwenden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuDatei,
            this.tsMenuOrdner,
            this.tsMenuFragezeichen});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(712, 33);
            this.MenuMain.TabIndex = 9;
            this.MenuMain.Text = "Hauptmenü";
            // 
            // tsMenuDatei
            // 
            this.tsMenuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuBeenden});
            this.tsMenuDatei.Name = "tsMenuDatei";
            this.tsMenuDatei.Size = new System.Drawing.Size(65, 29);
            this.tsMenuDatei.Text = "&Datei";
            // 
            // tsMenuOrdner
            // 
            this.tsMenuOrdner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuFolderInfo});
            this.tsMenuOrdner.Name = "tsMenuOrdner";
            this.tsMenuOrdner.Size = new System.Drawing.Size(80, 29);
            this.tsMenuOrdner.Text = "&Ordner";
            // 
            // tsMenuFragezeichen
            // 
            this.tsMenuFragezeichen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuInfo});
            this.tsMenuFragezeichen.Name = "tsMenuFragezeichen";
            this.tsMenuFragezeichen.Size = new System.Drawing.Size(32, 29);
            this.tsMenuFragezeichen.Text = "&?";
            // 
            // tsMenuInfo
            // 
            this.tsMenuInfo.Name = "tsMenuInfo";
            this.tsMenuInfo.Size = new System.Drawing.Size(252, 30);
            this.tsMenuInfo.Text = "&Info";
            // 
            // tsMenuBeenden
            // 
            this.tsMenuBeenden.Name = "tsMenuBeenden";
            this.tsMenuBeenden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsMenuBeenden.Size = new System.Drawing.Size(252, 30);
            this.tsMenuBeenden.Text = "&Beenden";
            this.tsMenuBeenden.Click += new System.EventHandler(this.tsMenuBeenden_Click);
            // 
            // tsMenuFolderInfo
            // 
            this.tsMenuFolderInfo.Name = "tsMenuFolderInfo";
            this.tsMenuFolderInfo.Size = new System.Drawing.Size(252, 30);
            this.tsMenuFolderInfo.Text = "Ordner&information";
            this.tsMenuFolderInfo.Click += new System.EventHandler(this.tsMenuFolderInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 528);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.Name = "Form1";
            this.Text = "DateiModifyer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDatei;
        private System.Windows.Forms.ToolStripMenuItem tsMenuBeenden;
        private System.Windows.Forms.ToolStripMenuItem tsMenuOrdner;
        private System.Windows.Forms.ToolStripMenuItem tsMenuFolderInfo;
        private System.Windows.Forms.ToolStripMenuItem tsMenuFragezeichen;
        private System.Windows.Forms.ToolStripMenuItem tsMenuInfo;
    }
}

