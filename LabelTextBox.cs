using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////Install-Package Microsoft.WindowsAPICodePack-Shell
using Microsoft.WindowsAPICodePack.Dialogs;
using TetratechTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RunManatea
{
    public partial class LabelTextBox : UserControl
    {
        public bool IsFolder = false;
        public bool IsFile = true;
     
        public string LabelText { get => label.Text; set => label.Text = value; }
        public string TextBoxText { get => textBox.Text; set => textBox.Text = value; }

        CommonOpenFileDialog dialog;
        LogHandler logHandler;  

        public void SetLabelText(string sLabel)
        {
            label.Text = sLabel;

        }
        public LabelTextBox(string labelText, string textBoxInitialText, bool IsFolder = false, bool IsFile = true)
        {
            Initialize2();
            label.Text = labelText;
            textBox.Text = textBoxInitialText;
            this.IsFolder = IsFolder;
            this.IsFile = IsFile;
            openFileDialog1 = new OpenFileDialog();
            dialog =  new CommonOpenFileDialog();   
            logHandler = new LogHandler();  

        }

        public void Initialize2()
        {
            InitializeComponent();
            //table panel layout keep disspapera from the controls

            bool badded = false;
            foreach(Control c in this.Controls) { 
                if (c.Name == tableLayoutPanel1.Name )
                {
                    badded = true; break;
                }
                    }
            if (!badded)
                this.Controls.Add(tableLayoutPanel1);

        }

        public LabelTextBox()
        {
            Initialize2();
            label.Text = "NA";
            textBox.Text = "NA";
            this.IsFolder = false;
            this.IsFile = true;
            openFileDialog1 =  new OpenFileDialog();
            dialog = new CommonOpenFileDialog();

        }

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            SetFolderOrFile();
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            SetFolderOrFile();
        }

        private void SetFolderOrFile()
        {
            string inPath = textBox.Text;
            if (IsFolder || IsFile)
            {
                bool bExists = false;
                if (IsFolder)
                {
                    bExists = Directory.Exists(textBox.Text);
                    
                    dialog.InitialDirectory = "C:\\Users";
                    try
                    {
                        dialog.InitialDirectory = textBox.Text;
                    }
                    catch (Exception ex)
                    {
                        logHandler.LogError(ex);    
                    }
                    dialog.IsFolderPicker = true;
                    try
                    {
                        if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                        {
                            FolderOK();
                            //MessageBox.Show("You selected: " + dialog.FileName);
                        }
                    }
                    catch(Exception ex) { logHandler.LogError(ex);}
                    finally { bExists = true; } 
                }
                else
                {
                    bExists = File.Exists(textBox.Text);
                    openFileDialog1.FileName = inPath;
                    DialogResult dr = openFileDialog1.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        FileOK();
                    }
                }
            }

        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileOK();
        }

        private void FileOK()
        {
            if (IsFile)
            {
                string filename = openFileDialog1.FileName;

                textBox.Text = filename;
            }
        }

        private void FolderOK()
        {
            if (IsFolder)
            {
                string filename = dialog.FileName;

              
                    textBox.Text = filename;
            }
        }

        private void tableLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            SetFolderOrFile();
        }

        private void label_Click(object sender, EventArgs e)
        {
            SetFolderOrFile();
        }
    }
}
