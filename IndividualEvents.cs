using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_PROTOTYPE_ASSIGNMENT
{
    public partial class IndividualEvents : Form
    {
        List<string> individualsNames = new List<string>();
        List<int> indiv_scores = new List<int>();




        //code to round edges of all squares/rectangles
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
          );

        public IndividualEvents()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Load += IndividualEvents_Load; // Loads Data
        }

        private void TeamTitle_Click(object sender, EventArgs e)
        {

        }

        private void IndividualEvents_Load(object sender, EventArgs e)
        {
            indivquitbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, indivquitbtn.Width, indivquitbtn.Height, 30, 30));
            indivtitle.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, indivtitle.Width, indivtitle.Height, 30, 30));
            indivquitpnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, indivquitpnl.Width, indivquitpnl.Height, 30, 30));

            //*******************************************LOADING INDIVIDUAL NAMES DATA **********************************************

            //Loading Last Individual1's Name Given
            textBox1.Text = Properties.Settings.Default.individual1;

            //Loading Last Individual2's Name Given
            textBox2.Text = Properties.Settings.Default.individual2;

            //Loading Last Individual3's Name Given
            textBox3.Text = Properties.Settings.Default.individual3;

            //Loading Last Individual4's Name Given
            textBox4.Text = Properties.Settings.Default.individual4;

            //Loading Last Individual5's Name Given
            textBox5.Text = Properties.Settings.Default.individual5;

            //Loading Last Individual6's Name Given
            textBox6.Text = Properties.Settings.Default.individual6;

            //Loading Last Individual7's Name Given
            textBox7.Text = Properties.Settings.Default.individual7;

            //Loading Last Individual8's Name Given
            textBox8.Text = Properties.Settings.Default.individual8;

            //Loading Last Individual9's Name Given
            textBox9.Text = Properties.Settings.Default.individual9;

            //Loading Last Individual10's Name Given
            textBox10.Text = Properties.Settings.Default.individual10;

            //Loading Last Individual11's Name Given
            textBox11.Text = Properties.Settings.Default.individual11;

            //Loading Last Individual12's Name Given
            textBox12.Text = Properties.Settings.Default.individual12;

            //Loading Last Individual13's Name Given
            textBox13.Text = Properties.Settings.Default.individual13;

            //Loading Last Individual14's Name Given
            textBox14.Text = Properties.Settings.Default.individual14;

            //Loading Last Individual15's Name Given
            textBox15.Text = Properties.Settings.Default.individual15;

            //****************************************** LOADING POINTS DATA ************************************************************

            //GOLF


            //Golf Loading Previous Data - Individual 1 
            decimal indivGolf1 = Properties.Settings.Default.indivGolf1;
            numericUpDown17.Value = indivGolf1;

            //Golf Loading Previous Data - Individual 2
            decimal indivGolf2 = Properties.Settings.Default.indivGolf2;
            numericUpDown1.Value = indivGolf2;

            //Golf Loading Previous Data - Individual 3 
            decimal indivGolf3 = Properties.Settings.Default.indivGolf3;
            numericUpDown2.Value = indivGolf3;

            //CODING

            
            //Coding Loading Previous Data - Individual 1 
            decimal indivCode1 = Properties.Settings.Default.indivCode1;
            numericUpDown3.Value = indivCode1;

            //Coding Loading Previous Data - Individual 2
            decimal indivCode2 = Properties.Settings.Default.indivCode2;
            numericUpDown4.Value = indivCode2;

            //Coding Loading Previous Data - Individual 3 
            decimal indivCode3 = Properties.Settings.Default.indivCode3;
            numericUpDown5.Value = indivCode3;

            //TABLE TENNIS


            //Table Tennis Loading Previous Data - Individual 1 
            decimal indivTennis1 = Properties.Settings.Default.indivTennis1;
            numericUpDown6.Value = indivTennis1;

            //Table Tennis Loading Previous Data - Individual 2
            decimal indivTennis2 = Properties.Settings.Default.indivTennis2;
            numericUpDown7.Value = indivTennis2;

            //Table Tennis Loading Previous Data - Individual 3 
            decimal indivTennis3 = Properties.Settings.Default.indivTennis3;
            numericUpDown8.Value = indivTennis3;

            //BOWLING


            //Bowling Loading Previous Data - Individual 1 
            decimal indivBowling1 = Properties.Settings.Default.indivBowling1;
            numericUpDown9.Value = indivBowling1;

            //Bowling Loading Previous Data - Individual 2
            decimal indivBowling2 = Properties.Settings.Default.indivBowling2;
            numericUpDown10.Value = indivBowling2;

            //Bowling Loading Previous Data - Individual 3 
            decimal indivBowling3 = Properties.Settings.Default.indivBowling3;
            numericUpDown11.Value = indivBowling3;

            //ART


            //Art Loading Previous Data - Individual 1 
            decimal indivArt1 = Properties.Settings.Default.indivArt1;
            numericUpDown12.Value = indivArt1;

            //Art Loading Previous Data - Individual 2
            decimal indivArt2 = Properties.Settings.Default.indivArt2;
            numericUpDown13.Value = indivArt2;

            //Art Loading Previous Data - Individual 3 
            decimal indivArt3 = Properties.Settings.Default.indivArt3;
            numericUpDown14.Value = indivArt3;




        }

        private void indivtitle_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void indivquitpnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Quit Button
        private void indivquitbtn_Click(object sender, EventArgs e)
        {
            mainmenu mainquitbutton = new mainmenu();
            this.Hide();
            mainquitbutton.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //GOLF


        //Awarding system depending on points achieved by the 1st place individual for Golf
        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 1
            Properties.Settings.Default.indivGolf1 = numericUpDown17.Value;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual1's Name
            Properties.Settings.Default.individual1 = textBox1.Text;
            Properties.Settings.Default.Save();
            
            individualsNames.Add(textBox1.Text);
            individualsNames.Add(textBox2.Text);
            individualsNames.Add(textBox3.Text);
            individualsNames.Add(textBox4.Text);
            individualsNames.Add(textBox5.Text);
            individualsNames.Add(textBox6.Text);
            individualsNames.Add(textBox7.Text);
            individualsNames.Add(textBox8.Text);
            individualsNames.Add(textBox9.Text);
            individualsNames.Add(textBox10.Text);
            individualsNames.Add(textBox11.Text);
            individualsNames.Add(textBox12.Text);
            individualsNames.Add(textBox13.Text);
            individualsNames.Add(textBox14.Text);
            individualsNames.Add(textBox15.Text);
            individualsNames = individualsNames.Distinct().ToList();

            for (int i=0; i<individualsNames.Count; i++)
            {
                indiv_scores.Add(0);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual2's Name
            Properties.Settings.Default.individual2 = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual3's Name
            Properties.Settings.Default.individual3 = textBox3.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual4's Name
            Properties.Settings.Default.individual4 = textBox4.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual5's Name
            Properties.Settings.Default.individual5 = textBox5.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual6's Name
            Properties.Settings.Default.individual6 = textBox6.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual7's Name
            Properties.Settings.Default.individual7 = textBox7.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual8's Name
            Properties.Settings.Default.individual8 = textBox8.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual9's Name
            Properties.Settings.Default.individual9 = textBox9.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual10's Name
            Properties.Settings.Default.individual10 = textBox10.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual11's Name
            Properties.Settings.Default.individual11 = textBox11.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual12's Name
            Properties.Settings.Default.individual12 = textBox12.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual13's Name
            Properties.Settings.Default.individual13 = textBox13.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual14's Name
            Properties.Settings.Default.individual14 = textBox14.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            //Save Data Individual15's Name
            Properties.Settings.Default.individual15 = textBox15.Text;
            Properties.Settings.Default.Save();
        }

     



        private void label31_Click(object sender, EventArgs e)
        {

        }

        //Awarding system depending on points achieved by the 2nd place individual for Golf
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 2
            Properties.Settings.Default.indivGolf2 = numericUpDown1.Value;
            Properties.Settings.Default.Save();

            
        }

        //Awarding system depending on points achieved by the 3rd place individual for Golf
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 3
            Properties.Settings.Default.indivGolf3 = numericUpDown2.Value;
            Properties.Settings.Default.Save();

          
        }

        //CODING


        //Awarding system depending on points achieved by the 1st place individual for Coding
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 1
            Properties.Settings.Default.indivCode1 = numericUpDown3.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 2nd place individual for Coding
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 2
            Properties.Settings.Default.indivCode2 = numericUpDown4.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 3rd place individual for Coding
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 3
            Properties.Settings.Default.indivCode3 = numericUpDown5.Value;
            Properties.Settings.Default.Save();


        }

        //TABLE TENNIS


        //Awarding system depending on points achieved by the 1st place individual for Table Tennis
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 1
            Properties.Settings.Default.indivTennis1 = numericUpDown6.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 2nd place individual for Table Tennis
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 2
            Properties.Settings.Default.indivTennis2 = numericUpDown7.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 3rd place individual for Table Tennis
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 3
            Properties.Settings.Default.indivTennis3 = numericUpDown8.Value;
            Properties.Settings.Default.Save();
        }

        //BOWLING


        //Awarding system depending on points achieved by the 1st place individual for Bowling
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 1
            Properties.Settings.Default.indivBowling1 = numericUpDown9.Value;
            Properties.Settings.Default.Save();


        }

        //Awarding system depending on points achieved by the 2nd place individual for Bowling
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 2
            Properties.Settings.Default.indivBowling2 = numericUpDown10.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 3rd place individual for Bowling
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 3
            Properties.Settings.Default.indivBowling3 = numericUpDown11.Value;
            Properties.Settings.Default.Save();

        }

        //ART


        //Awarding system depending on points achieved by the 1st place individual for Art
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 1
            Properties.Settings.Default.indivArt1 = numericUpDown12.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 2nd place individual for Art
        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 2
            Properties.Settings.Default.indivArt2 = numericUpDown13.Value;
            Properties.Settings.Default.Save();
        }

        //Awarding system depending on points achieved by the 3rd place individual for Art
        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            //Save Data For Individual 3
            Properties.Settings.Default.indivArt3 = numericUpDown14.Value;
            Properties.Settings.Default.Save();
        }

        
    }
}
