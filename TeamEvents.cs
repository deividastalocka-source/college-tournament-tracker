using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROTOTYPE_ASSIGNMENT
{
    public partial class TeamEvents : Form
    {
        //code to round edges of all squares/rectangles
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //Function To Create The Edges Of UI
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
          );

        public TeamEvents()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //Rounds Edges Of UI
            Load += TeamEvents_Load; // Loads Data
        }

        private void TeamEvents_Load(object sender, EventArgs e)
        {
            //Code For Rounding The Edges Of The UI
            title.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, title.Width, title.Height, 30, 30));
            quitpnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, quitpnl.Width, quitpnl.Height, 30, 30));
            teamquitbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, teamquitbtn.Width, teamquitbtn.Height, 30, 30));

            //FOOTBALL


            //Football Loading Previous Data - Team A
            decimal teamFootA = Properties.Settings.Default.teamFootA;
            numericUpDown2.Value = teamFootA;

            //Football Loading Previous Data - Team B
            decimal teamFootB = Properties.Settings.Default.teamFootB;
            numericUpDown1.Value = teamFootB;

            //Football Loading Previous Data - Team C
            decimal teamFootC = Properties.Settings.Default.teamFootC;
            numericUpDown3.Value = teamFootC;

            //Football Loading Previous Data - Team D
            decimal teamFootD = Properties.Settings.Default.teamFootD;
            numericUpDown4.Value = teamFootD;

            //BASKETBALL


            //Basketball Loading Previous Data - Team A
            decimal teamBaskA = Properties.Settings.Default.teamBaskA;
            numericUpDown5.Value = teamBaskA;

            //Basketball Loading Previous Data - Team B
            decimal teamBaskB = Properties.Settings.Default.teamBaskB;
            numericUpDown6.Value = teamBaskB;

            //Basketball Loading Previous Data - Team C
            decimal teamBaskC = Properties.Settings.Default.teamBaskC;
            numericUpDown7.Value = teamBaskC;

            //Basketball Loading Previous Data - Team D
            decimal teamBaskD = Properties.Settings.Default.teamBaskD;
            numericUpDown8.Value = teamBaskD;

            //TUG OF WAR


            //Tug Of War Loading Previous Data - Team A
            decimal teamTugA = Properties.Settings.Default.teamTugA;
            numericUpDown9.Value = teamTugA;

            //Tug Of War Loading Previous Data - Team B
            decimal teamTugB = Properties.Settings.Default.teamTugB;
            numericUpDown10.Value = teamTugB;

            //Tug Of War Loading Previous Data - Team C
            decimal teamTugC = Properties.Settings.Default.teamTugC;
            numericUpDown11.Value = teamTugC;

            //Tug Of War Loading Previous Data - Team D
            decimal teamTugD = Properties.Settings.Default.teamTugD;
            numericUpDown12.Value = teamTugD;

            //RUGBY


            //Rugby Loading Previous Data - Team A
            decimal teamRugA = Properties.Settings.Default.teamRugA;
            numericUpDown13.Value = teamRugA;

            //Rugby Loading Previous Data - Team B
            decimal teamRugB = Properties.Settings.Default.teamRugB;
            numericUpDown14.Value = teamRugB;

            //Rugby Loading Previous Data - Team C
            decimal teamRugC = Properties.Settings.Default.teamRugC;
            numericUpDown15.Value = teamRugC;

            //Rugyby Loading Previous Data - Team D
            decimal teamRugD = Properties.Settings.Default.teamRugD;
            numericUpDown16.Value = teamRugD;

            //BASEBALL


            //Baseball Loading Previous Data - Team A
            decimal teamBaseA = Properties.Settings.Default.teamBaseA;
            numericUpDown17.Value = teamBaseA;

            //Baseball Loading Previous Data - Team B
            decimal teamBaseB = Properties.Settings.Default.teamBaseB;
            numericUpDown18.Value = teamBaseB;

            //Baseball Loading Previous Data - Team C
            decimal teamBaseC = Properties.Settings.Default.teamBaseC;
            numericUpDown19.Value = teamBaseC;

            //Baseball Loading Previous Data - Team D
            decimal teamBaseD = Properties.Settings.Default.teamBaseD;
            numericUpDown20.Value = teamBaseD;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teams_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void TeamTitle_Click(object sender, EventArgs e)
        {

        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitpnl_Paint(object sender, PaintEventArgs e)
        {

        }


        //Quit Button 
        private void quitbtn_Click(object sender, EventArgs e)
        {
            mainmenu mainquitbutton = new mainmenu();
            this.Hide();
            mainquitbutton.ShowDialog();

        }

        //Football Activity
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team A
            Properties.Settings.Default.teamFootA = numericUpDown2.Value;
            Properties.Settings.Default.Save();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team B
            Properties.Settings.Default.teamFootB = numericUpDown1.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team C
            Properties.Settings.Default.teamFootC = numericUpDown3.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team D
            Properties.Settings.Default.teamFootD = numericUpDown4.Value;
            Properties.Settings.Default.Save();
        }

        //Basketball Activity
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

            //Save Data For Team A
            Properties.Settings.Default.teamBaskA = numericUpDown5.Value;
            Properties.Settings.Default.Save();

        }

        //Awarding system depending on points achieved on the B Team For Basketball
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team B
            Properties.Settings.Default.teamBaskB = numericUpDown6.Value;
            Properties.Settings.Default.Save();

        }

        //Awarding system depending on points achieved on the C Team For Basketball
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team C
            Properties.Settings.Default.teamBaskC = numericUpDown7.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the D Team For Basketball
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team D
            Properties.Settings.Default.teamBaskD = numericUpDown8.Value;
            Properties.Settings.Default.Save();



        }
        //Tug Of War
        //Awarding system depending on points achieved on the A Team For Tug Of War
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team A
            Properties.Settings.Default.teamTugA = numericUpDown9.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the B Team For Tug Of War
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team B
            Properties.Settings.Default.teamTugB = numericUpDown10.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the C Team For Tug Of War
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team C
            Properties.Settings.Default.teamTugC = numericUpDown11.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the D Team For Tug Of War
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team D
            Properties.Settings.Default.teamTugD = numericUpDown12.Value;
            Properties.Settings.Default.Save();
        }


        //Rugby Activity
        //Awarding system depending on points achieved on the A Team For Rugby
        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team A
            Properties.Settings.Default.teamRugA = numericUpDown13.Value;
            Properties.Settings.Default.Save();


        }

        //Awarding system depending on points achieved on the B Team For Rugby
        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team B
            Properties.Settings.Default.teamRugB = numericUpDown14.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the C Team For Rugby
        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team C
            Properties.Settings.Default.teamRugC = numericUpDown15.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the D Team For Rugby
        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team D
            Properties.Settings.Default.teamRugD = numericUpDown16.Value;
            Properties.Settings.Default.Save();
        }

        //Baseball Activity
        //Awarding system depending on points achieved on the A Team For Baseball
        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team A
            Properties.Settings.Default.teamBaseA = numericUpDown17.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the B Team For Baseball
        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team B
            Properties.Settings.Default.teamBaseB = numericUpDown18.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the C Team For Baseball
        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team C
            Properties.Settings.Default.teamBaseC = numericUpDown19.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved on the D Team For Baseball
        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Team D
            Properties.Settings.Default.teamBaseD = numericUpDown20.Value;
            Properties.Settings.Default.Save();

        }
    }
}

