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
            this.tsMenuBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuOrdner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuFolderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuChangeCreateDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuChangeEditDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuChangeLastOpenDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuFragezeichen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dateiname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 174);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-6, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Durchsuchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zeitangabe Datum: TT.MM.JJJJ";
            // 
            // button2
            // 
            this.button2.AccessibleName = "Änderungsdatum ändern";
            this.button2.Location = new System.Drawing.Point(87, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
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
            this.textBox2.Location = new System.Drawing.Point(0, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zeitangabe Uhrzeit: HH:MM:SS";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 88);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.AccessibleName = "Zugriffsdatum ändern";
            this.button3.Location = new System.Drawing.Point(171, 131);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Auf \'letzter Zugriff\' anwenden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "Erstellungsdatum ändern";
            this.button4.Location = new System.Drawing.Point(0, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 28);
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
            this.MenuMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuMain.Size = new System.Drawing.Size(610, 24);
            this.MenuMain.TabIndex = 9;
            this.MenuMain.Text = "Hauptmenü";
            // 
            // tsMenuDatei
            // 
            this.tsMenuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuBeenden});
            this.tsMenuDatei.Name = "tsMenuDatei";
            this.tsMenuDatei.Size = new System.Drawing.Size(46, 22);
            this.tsMenuDatei.Text = "&Datei";
            // 
            // tsMenuBeenden
            // 
            this.tsMenuBeenden.Name = "tsMenuBeenden";
            this.tsMenuBeenden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsMenuBeenden.Size = new System.Drawing.Size(180, 22);
            this.tsMenuBeenden.Text = "&Beenden";
            this.tsMenuBeenden.Click += new System.EventHandler(this.tsMenuBeenden_Click);
            // 
            // tsMenuOrdner
            // 
            this.tsMenuOrdner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuFolderInfo,
            this.toolStripSeparator1,
            this.tsMenuChangeCreateDate,
            this.tsMenuChangeEditDate,
            this.tsMenuChangeLastOpenDate});
            this.tsMenuOrdner.Name = "tsMenuOrdner";
            this.tsMenuOrdner.Size = new System.Drawing.Size(56, 22);
            this.tsMenuOrdner.Text = "&Ordner";
            // 
            // tsMenuFolderInfo
            // 
            this.tsMenuFolderInfo.Name = "tsMenuFolderInfo";
            this.tsMenuFolderInfo.Size = new System.Drawing.Size(207, 22);
            this.tsMenuFolderInfo.Text = "Ordner&information";
            this.tsMenuFolderInfo.Click += new System.EventHandler(this.tsMenuFolderInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // tsMenuChangeCreateDate
            // 
            this.tsMenuChangeCreateDate.Name = "tsMenuChangeCreateDate";
            this.tsMenuChangeCreateDate.Size = new System.Drawing.Size(207, 22);
            this.tsMenuChangeCreateDate.Text = "&Erstellungsdatum ändern";
            this.tsMenuChangeCreateDate.Click += new System.EventHandler(this.tsMenuChangeCreateDate_Click);
            // 
            // tsMenuChangeEditDate
            // 
            this.tsMenuChangeEditDate.Name = "tsMenuChangeEditDate";
            this.tsMenuChangeEditDate.Size = new System.Drawing.Size(207, 22);
            this.tsMenuChangeEditDate.Text = "&Änderungsdatum ändern";
            this.tsMenuChangeEditDate.Click += new System.EventHandler(this.tsMenuChangeEditDate_Click);
            // 
            // tsMenuChangeLastOpenDate
            // 
            this.tsMenuChangeLastOpenDate.Name = "tsMenuChangeLastOpenDate";
            this.tsMenuChangeLastOpenDate.Size = new System.Drawing.Size(207, 22);
            this.tsMenuChangeLastOpenDate.Text = "Letzten &Zugriff ändern";
            this.tsMenuChangeLastOpenDate.Click += new System.EventHandler(this.tsMenuChangeLastOpenDate_Click);
            // 
            // tsMenuFragezeichen
            // 
            this.tsMenuFragezeichen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuInfo});
            this.tsMenuFragezeichen.Name = "tsMenuFragezeichen";
            this.tsMenuFragezeichen.Size = new System.Drawing.Size(24, 22);
            this.tsMenuFragezeichen.Text = "&?";
            // 
            // tsMenuInfo
            // 
            this.tsMenuInfo.Name = "tsMenuInfo";
            this.tsMenuInfo.Size = new System.Drawing.Size(95, 22);
            this.tsMenuInfo.Text = "&Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 409);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuChangeCreateDate;
        private System.Windows.Forms.ToolStripMenuItem tsMenuChangeEditDate;
        private System.Windows.Forms.ToolStripMenuItem tsMenuChangeLastOpenDate;
    }
}

