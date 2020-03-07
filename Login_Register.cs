using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Login_Register : Form
    { //55.50 57:41
        public Login_Register()
        {
            InitializeComponent();
        }

        //display image on the panel (close and minimalize)
        private void Login_Register_Load(object sender, EventArgs e)
        {
            //panel3.BackgroundImage = Image.FromFile("../../images/img1.png");
        }

        //login button
        private void button_Login_Click(object sender, EventArgs e)
        {

        }

        //register button
        private void button_Register_Click(object sender, EventArgs e)
        {

        }

        //browse button
        private void button_browse_Click(object sender, EventArgs e)
        {
            //select and display image in the picture box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfileImage.Image = Image.FromFile(opf.FileName);
            }
        }

        //label go to the register section
        private void labelGoToRegister_Click(object sender, EventArgs e)
        {
            timer1.Start();
            labelGoToRegister.Enabled = false;
            labelGoToLogin.Enabled = false;
        }

        //label go to the login section
        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            timer2.Start();
            labelGoToLogin.Enabled = false;
            labelGoToRegister.Enabled = false;
        }

        //button close
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //button minimize
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }

        //when this timer will start we will show only the register part
        private void timer1_Tick(object sender, EventArgs e)
        {   
            //-260 is where you can see the register part
            //the first 260 is where the login part is
            //so the panel need to go outside the form by 260
            //and the same when we want to show the login part
            //we need to set the location (x) of the panel to 0
            if (panel2.Location.X > -260)
            {
                panel2.Location = new Point(panel2.Location.X - 10, panel2.Location.Y);
            }
            else
            {
                timer1.Stop();
                labelGoToLogin.Enabled = true;
                labelGoToRegister.Enabled = true;
            }
        }

        //when this timer will start we will show only the login part
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X < 260)
            {
                panel2.Location = new Point(panel2.Location.X + 10, panel2.Location.Y);
            }
            else
            {
                timer2.Stop();
                labelGoToLogin.Enabled = true;
                labelGoToRegister.Enabled = true;
            }
        }
    }
}
