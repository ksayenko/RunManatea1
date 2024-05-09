using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetratechTools;


namespace RunManatea
{
    public struct APP_Config_Keys
    { public static string _3mbIniFile = "3mbIniFile";
        public static string gridCSV = "gridCSV";
        public static string gridBinary = "gridBinary";
        public static string pileCSV = "pileCSV";
        public static string dbSeaData = "dbSeaData";
        public static string output = "output";

    }
    public partial class Settings : Form
    {
        private string _3mbIniFile;
        private string gridCSV;
        private string gridBinary;
        private string pileCSV;
        private string dbSeaData;
        private string output;

        private LogHandler logHandler;

        public void Initialize2()
        {
            InitializeComponent();
            //table panel layout keep disspapera from the controls

            bool badded = false;
            foreach (Control c in this.Controls)
            {
                if (c.Name == tableLayoutPanel1.Name)
                {
                    badded = true; break;
                }
            }
            if (!badded)
                this.Controls.Add(tableLayoutPanel1);

        }
        public Settings(LogHandler lh = null)
        {
            Initialize2();
            if (lh == null)
            logHandler = new LogHandler();
            else
                logHandler = lh;

            ReadSettings(logHandler);

            labelTextBox_3mb.LabelText = "Location " + APP_Config_Keys._3mbIniFile;
            labelTextBox_3mb.TextBoxText = A3mbIniFile;
            labelTextBox_3mb.IsFile = true;
            
            labelTextBox_gridcsv.LabelText = "Location " + APP_Config_Keys.gridCSV;
            labelTextBox_gridcsv.TextBoxText = gridCSV;
            labelTextBox_gridcsv.IsFile = true;

            labelTextBox_GridBinary.LabelText = "Location " + APP_Config_Keys.gridBinary;
            labelTextBox_GridBinary.TextBoxText = GridBinary;
            labelTextBox_GridBinary.IsFile = true;

            labelTextBox_pileCSV.LabelText = "Location " + APP_Config_Keys.pileCSV;
            labelTextBox_pileCSV.TextBoxText = pileCSV;
            labelTextBox_pileCSV.IsFile = true;

            labelTextBox_dbSeaData.LabelText = "Location " + APP_Config_Keys.dbSeaData;
            labelTextBox_dbSeaData.TextBoxText = dbSeaData;
            labelTextBox_dbSeaData.IsFolder = true;
            labelTextBox_dbSeaData.IsFile = false;

            labelTextBox_Out.LabelText = "Location " + APP_Config_Keys.output;
            labelTextBox_Out.TextBoxText = output;
            labelTextBox_Out.IsFolder = true;
            labelTextBox_Out.IsFile = false;



        }

        public string A3mbIniFile { get => _3mbIniFile; set => _3mbIniFile = value; }
        public string GridCSV { get => gridCSV; set => gridCSV = value; }
        public string GridBinary { get => gridBinary; set => gridBinary = value; }
        public string PileCSV { get => pileCSV; set => pileCSV = value; }
        public string DbSeaData { get => dbSeaData; set => dbSeaData = value; }
        public string Output { get => output; set => output = value; }

        public void ReadSettings(LogHandler lh = null)
        {
            if (lh == null)
                lh = new LogHandler();

            string[] keys = null;
            try
            {
                keys = ConfigurationManager.AppSettings.AllKeys;
            }
            catch { }

            try
            {
                if (ContainsInArray(keys, APP_Config_Keys._3mbIniFile)) 
                    A3mbIniFile = ConfigurationManager.AppSettings[APP_Config_Keys._3mbIniFile].ToString().Trim();
                //if (_3mbIniFile == null || _3mbIniFile == "")
                //    throw new Exception("no catalog in config file, use default ");
            }
            catch (Exception ex)
            {
                lh.LogError(ex, MethodBase.GetCurrentMethod());
                A3mbIniFile = "NA";
            }



            try
            {
                if (ContainsInArray(keys, APP_Config_Keys.gridCSV))
                    GridCSV = ConfigurationManager.AppSettings[APP_Config_Keys.gridCSV].ToString();
            }
            catch (Exception ex)
            {
                lh.LogError(" Error in ReadSettings (gridCSV): ");
                lh.LogError(ex);
            }

            try
            {
                if (ContainsInArray(keys, APP_Config_Keys.gridBinary))
                    gridBinary = ConfigurationManager.AppSettings[APP_Config_Keys.gridBinary].ToString();
            }
            catch (Exception ex)
            {
                lh.LogError(" Error in ReadSettings (gridBinary): ");
                lh.LogError(ex);
            }

            try
            {
                if (ContainsInArray(keys, APP_Config_Keys.pileCSV))
                    pileCSV = ConfigurationManager.AppSettings[APP_Config_Keys.pileCSV].ToString();
            }
            catch (Exception ex)
            {
                lh.LogError(" Error in ReadSettings (pileCSV): ");
                lh.LogError(ex);
            }

            try
            {
                if (ContainsInArray(keys, APP_Config_Keys.dbSeaData))
                    dbSeaData = ConfigurationManager.AppSettings[APP_Config_Keys.dbSeaData].ToString();
            }
            catch (Exception ex)
            {
                lh.LogError(" Error in ReadSettings (dbSeaData): ");
                lh.LogError(ex);
            }

            if (dbSeaData == null)
                dbSeaData = "C:\\Users";

            try
            {
                if (ContainsInArray(keys, APP_Config_Keys.output))
                    output = ConfigurationManager.AppSettings[APP_Config_Keys.output].ToString();

                if (output == null || output == "")
                   {
                    FileInfo fi = new FileInfo(this._3mbIniFile);
                    output = fi.Directory 
                        + Path.DirectorySeparatorChar.ToString()
                        + fi.Name.Replace(".", "");
                }
            }
            catch (Exception ex)
            {
                lh.LogError(" Error in ReadSettings (output): ");
                lh.LogError(ex);
                output = "";
            }

           

        }


        public bool ContainsInArray(string[] arraystring, string key)
        {
            bool rv = false;
            if (arraystring != null && key != null && key != "")
            {
                foreach (string s in arraystring)
                {
                    if (s.Equals(key))
                        return true;
                }
            }
            return rv;
        }


        public void SaveSetting(string sKey, object sValue, LogHandler lh = null)
        {
            if (sKey != null && sKey != "" && sValue != null)
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var appSettings = configFile.AppSettings.Settings;
                    if (appSettings[sKey] == null)
                    {
                        appSettings.Add(sKey, sValue.ToString());
                    }
                    else
                    {
                        appSettings[sKey].Value = sValue.ToString();
                    }
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                    if (lh != null)
                        lh.LogWarning("The setting " + sKey + " has been saved.");
                }
                catch (Exception ex)
                {
                    if (lh != null)
                    {
                        lh.LogError(ex, MethodBase.GetCurrentMethod());
                        /*
                        lh.LogError("Error in Save Settings : " + ex.ToString());
                        if (ex.InnerException != null)
                            lh.LogError(ex.InnerException.ToString());
                        */
                    }
                }
        }

        public void SaveOutputFolderToConfigFile()
        {
            SaveSetting(APP_Config_Keys.output, this.output, logHandler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pileCSV = labelTextBox_pileCSV.TextBoxText;
            this.gridBinary = labelTextBox_GridBinary.TextBoxText;
            this.A3mbIniFile = labelTextBox_3mb.TextBoxText; 
            this.gridCSV = labelTextBox_gridcsv.TextBoxText; ;
            this.dbSeaData = labelTextBox_dbSeaData.TextBoxText;
            this.output = labelTextBox_Out.TextBoxText;
            SaveSetting(APP_Config_Keys.pileCSV, labelTextBox_pileCSV.TextBoxText, logHandler);
            SaveSetting(APP_Config_Keys._3mbIniFile, labelTextBox_3mb.TextBoxText, logHandler);
            SaveSetting(APP_Config_Keys.gridCSV, labelTextBox_gridcsv.TextBoxText, logHandler);
            SaveSetting(APP_Config_Keys.gridBinary, labelTextBox_GridBinary.TextBoxText, logHandler);
            SaveSetting(APP_Config_Keys.dbSeaData, labelTextBox_dbSeaData.TextBoxText, logHandler);
            SaveSetting(APP_Config_Keys.output, labelTextBox_Out.TextBoxText, logHandler);

            this.Close();
        }

        private void labelTextBox_pileCSV_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
           
            if (this.pileCSV == null) 
                pileCSV = labelTextBox_pileCSV.TextBoxText = "";

            if (this.gridBinary == null) 
                this.gridBinary = labelTextBox_GridBinary.TextBoxText = "";
            if (this.A3mbIniFile == null)
                this.A3mbIniFile = labelTextBox_3mb.TextBoxText = "";
          if (this.gridCSV == null)
            {
                this.gridCSV = labelTextBox_gridcsv.TextBoxText = "";

            }
          if (this.dbSeaData == null)
            {
                this.dbSeaData = labelTextBox_dbSeaData.TextBoxText = "";

            }
            if (this.output == null)
            {
                this.output = labelTextBox_Out.TextBoxText = "";

            }
            tableLayoutPanel1.Visible = true;
            labelTextBox_dbSeaData.Visible = labelTextBox_dbSeaData.Visible = true;

        }

        private void labelTextBox_Out_Load(object sender, EventArgs e)
        {

        }
    }
}
