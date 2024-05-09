using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RunManatea
{
    public partial class Form1 : Form
    {
        Read3mb.ReadRunWriteAnimat an = null;
        Read3mb.GridFile3dSoundLevel mat = null;
        string path = @"C:\Users\kateryna.sayenko\Documents\AuditoryBiophysicsLab\VS Manatea\RunManatea";
        string name = "CVOWC_01_09_2024.3mb";

        double step = 1;
        int nx = 635, ny = 605, nz = 509;
            double  xcorner = 384370,  ycornrer= 4023453;
        double dx = 2.292825136501570e+02;
        double dy = 2.292825136501570e+02;

        public Form1()
        {
            InitializeComponent();
            txtSizex.Text = nx.ToString();
            txtSizey.Text = ny.ToString();
            txtSizez.Text = nz.ToString();
            txtxllCorner0.Text= xcorner.ToString(); 
            txtyllCorner0.Text = ycornrer.ToString();   
            txtStep.Text = step.ToString();
            txtDx.Text = txtDy.Text = dx.ToString();    



        }

        private void button1_Click(object sender, EventArgs e)
        {
             path = @"C:\Users\kateryna.sayenko\Documents\AuditoryBiophysicsLab\VS Manatea\RunManatea";
             name = "CVOWC_01_09_2024.3mb";
            an = new Read3mb.ReadRunWriteAnimat(path + "\\" + name);
            Color c = this.btnReadFile.BackColor;
            this.btnReadFile.BackColor = Color.Coral;
            lblStatus.Text = " READING GRID FILE....";
            //bool b = an.Read();
            this.btnReadFile.BackColor = c;
            lblStatus.Text = " done";
        }

        private void btnWriteFiles_Click(object sender, EventArgs e)
        {
            if (an == null) return;
           if(an.File3MB ==null) return;
            an.File3MB.Animats.Sort();
            string outp = "";
            an.File3MB.WriteFiles(path,ref outp);

        }

        private void but3dgridRead_Click(object sender, EventArgs e)
        {
            //load('CVOWC_Complex_Grid_01092024_LF.mat', 'dx0', 'dy0', 'grid3D', 'xllCorner0', 'yllCorner0', 'nCols0', 'nRows0', 'depthStep', 'nFiles');
            path = @"C:\Users\kateryna.sayenko\Documents\AuditoryBiophysicsLab\VS Manatea\RunManatea";
            name = "CVOWC_Complex_Grid_01092024_LF.mat";
            nx = Int32.Parse(txtSizex.Text);
            ny = Int32.Parse(txtSizey.Text); 
            nz = Int32.Parse(txtSizez.Text);
            xcorner = Double.Parse(txtxllCorner0.Text);
            ycornrer = Double.Parse(txtyllCorner0.Text);
            step = Double.Parse(txtStep.Text);
            dx = double.Parse(txtDx.Text); 
            mat = new Read3mb.GridFile3dSoundLevel(path, name, nx, ny, nz, xcorner ,ycornrer,step, dx,dy);
            Color c = this.btnReadMatFile.BackColor;
            this.btnReadMatFile.BackColor = Color.Coral;
            lblStatus.Text = " READING GRID FILE....";
            System.Threading.Thread.Sleep(1000);
            mat.ReadGrid3dCSV(path+"\\"+name);
            this.btnReadMatFile.BackColor = c;
            lblStatus.Text = " done";


        }

        private void btnRunManatea_Click(object sender, EventArgs e)
        {
            if (an == null) return;
            if (an.File3MB == null) return;
            an.RunManatea(this.mat);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
