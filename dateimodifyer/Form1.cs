using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IniFileLib;



namespace dateimodifyer
{
    public partial class Form1 : Form
    {

        static String iniFilePath = "config.ini";
        String iniMainSection = "Main";
        String iniKey = "LastFile";
        String iniValue = "";
        String iniOpenFileKey = "LastFolder";
        String iniOpenFileValue = Application.StartupPath;

        static String iniSettingsSection = "Settings";
        static String iniSetKey = "DateTimeMode";
        static String iniSetValue = "auto"; //auto or manual
        string iniReadSetvalue = IniFileHelper.ReadValue(iniSettingsSection, iniSetKey, System.IO.Path.GetFullPath(iniFilePath));

        String iniManualSection = "Manual";
        String iniManualDateKey = "Date";
        String iniManualTimeKey = "Time";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iniReadvalue = IniFileHelper.ReadValue(iniMainSection, iniOpenFileKey, System.IO.Path.GetFullPath(iniFilePath));

            openFileDialog1.Title = "Datei wählen";
            openFileDialog1.InitialDirectory = iniReadvalue;
            openFileDialog1.ValidateNames = true;
            openFileDialog1.FileName = iniValue;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.CheckFileExists)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    //iniOpenFileValue = openFileDialog1.FileName;
                    String directory = openFileDialog1.FileName.Substring(0, openFileDialog1.FileName.LastIndexOf('\\'));
                    iniValue = openFileDialog1.SafeFileName;
                    iniOpenFileValue = directory;
                }
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string iniReadvalue = IniFileHelper.ReadValue(iniMainSection, iniKey, System.IO.Path.GetFullPath(iniFilePath));
            textBox1.Text = iniReadvalue;

            string iniReadManualDatevalue = IniFileHelper.ReadValue(iniManualSection, iniManualDateKey, System.IO.Path.GetFullPath(iniFilePath));
            if (iniReadManualDatevalue == "" || iniReadSetvalue == "auto")
                textBox2.Text = DateTime.Now.ToShortDateString();
            else
                textBox2.Text = iniReadManualDatevalue;

            string iniReadManualTimevalue = IniFileHelper.ReadValue(iniManualSection, iniManualTimeKey, System.IO.Path.GetFullPath(iniFilePath));
            if (iniReadManualTimevalue == "" || iniReadSetvalue == "auto")
            textBox3.Text = DateTime.Now.ToLongTimeString();
            else
                textBox3.Text = iniReadManualTimevalue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show("Datei nicht vorhanden.\n" + textBox1.Text, "Fehler!");
                }
                else
                {
                    String getErDatum = "\nErstellt am: " + File.GetCreationTime(textBox1.Text).ToString();
                    String getZugDatum = "\nLetzter Zugriff: " + File.GetLastAccessTime(textBox1.Text).ToString();
                    String getGeAendert = "\nZuletzt geändert: " + File.GetLastWriteTime(textBox1.Text).ToString();
                    MessageBox.Show(textBox1.Text + getErDatum + getZugDatum + getGeAendert + "\n Aktuelles Datum: " + textBox2.Text + "\n Aktuelle Uhrzeit: " + textBox3.Text, "Auf zuletzt geändert anwenden");

                    //Zuletzt geändert
                    try
                    {
                        File.SetLastWriteTime(textBox1.Text, DateTime.Parse(textBox2.Text + " " + textBox3.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Fehler!");
                    }

                    //MessageBox.Show(dateTimePicker1.Value.ToFileTime().ToString());
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show("Datei nicht vorhanden.\n" + textBox1.Text, "Fehler!");
                }
                else
                {
                    String getErDatum = "\nErstellt am: " + File.GetCreationTime(textBox1.Text).ToString();
                    String getZugDatum = "\nLetzter Zugriff: " + File.GetLastAccessTime(textBox1.Text).ToString();
                    String getGeAendert = "\nZuletzt geändert: " + File.GetLastWriteTime(textBox1.Text).ToString();
                    MessageBox.Show(textBox1.Text + getErDatum + getZugDatum + getGeAendert + "\n Aktuelles Datum: " + textBox2.Text + "\n Aktuelle Uhrzeit: " + textBox3.Text, "Auf letzter Zugriff anwenden");

                    //letzter Zugriff
                    try
                    {
                        File.SetLastAccessTime(textBox1.Text, DateTime.Parse(textBox2.Text + " " + textBox3.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Fehler!");
                    }

                    //MessageBox.Show(dateTimePicker1.Value.ToFileTime().ToString());
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show("Datei nicht vorhanden.\n" + textBox1.Text, "Fehler!");
                }
                else
                {
                    String getErDatum = "\nErstellt am: " + File.GetCreationTime(textBox1.Text).ToString();
                    String getZugDatum = "\nLetzter Zugriff: " + File.GetLastAccessTime(textBox1.Text).ToString();
                    String getGeAendert = "\nZuletzt geändert: " + File.GetLastWriteTime(textBox1.Text).ToString();
                    MessageBox.Show(textBox1.Text + getErDatum + getZugDatum + getGeAendert + "\n Aktuelles Datum: " + textBox2.Text + "\n Aktuelle Uhrzeit: " + textBox3.Text, "Auf Erstellt am  anwenden");

                    //Erstellt am
                    try
                    {
                        File.SetCreationTime(textBox1.Text, DateTime.Parse(textBox2.Text + " " + textBox3.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Fehler!");
                    }

                    //MessageBox.Show(dateTimePicker1.Value.ToFileTime().ToString());
                }
            }

        }

        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text != "")
                iniValue = textBox1.Text;

            writeToINI();
        }

        private void writeToINI()
        {
            if (!File.Exists(iniFilePath))
            {
                bool DateTimeMode = IniFileHelper.WriteValue(iniSettingsSection, iniSetKey, iniSetValue, System.IO.Path.GetFullPath(iniFilePath));
            }

            bool lastfile = IniFileHelper.WriteValue(iniMainSection, iniKey, iniValue, System.IO.Path.GetFullPath(iniFilePath));
            bool lastfolder = IniFileHelper.WriteValue(iniMainSection, iniOpenFileKey, iniOpenFileValue, System.IO.Path.GetFullPath(iniFilePath));
                        
            if (iniReadSetvalue == "manual")
            {
                bool ManualDate = IniFileHelper.WriteValue(iniManualSection, iniManualDateKey, textBox2.Text, System.IO.Path.GetFullPath(iniFilePath));
                bool ManualTime = IniFileHelper.WriteValue(iniManualSection, iniManualTimeKey, textBox3.Text, System.IO.Path.GetFullPath(iniFilePath));
            }

            if (iniReadSetvalue == "auto")
            {
                bool ManualDate = IniFileHelper.DeleteSection(iniManualSection, System.IO.Path.GetFullPath(iniFilePath));
            }

        }

        private void tsMenuFolderInfo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Wähle einen Ordner aus.";
            folder.ShowNewFolderButton = false;
            if(folder.ShowDialog() == DialogResult.OK)
            {
                String getErDatum = "\nErstellt am: " + Directory.GetCreationTime(folder.SelectedPath).ToString();
                String getZugDatum = "\nLetzter Zugriff: " + Directory.GetLastAccessTime(folder.SelectedPath).ToString();
                String getGeAendert = "\nZuletzt geändert: " + Directory.GetLastWriteTime(folder.SelectedPath).ToString();
                MessageBox.Show(textBox1.Text + getErDatum + getZugDatum + getGeAendert + "\n Aktuelles Datum: " + textBox2.Text + "\n Aktuelle Uhrzeit: " + textBox3.Text, "Ordnerinformation");
            }
        }

        private void tsMenuBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }//end class
}//end namespace
