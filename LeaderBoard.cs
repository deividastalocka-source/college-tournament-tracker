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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_PROTOTYPE_ASSIGNMENT
{
    public partial class LeaderBoard : Form
    {

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

        public LeaderBoard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Load += LeaderBoard_Load; // Loads Data

            label27.Text = "Gold";
            label28.Text = "Sliver";
            label29.Text = "Bronze";
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            leaderquitbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, leaderquitbtn.Width, leaderquitbtn.Height, 30, 30));
            leaderquitpnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, leaderquitpnl.Width, leaderquitpnl.Height, 30, 30));
            leadertitle.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, leadertitle.Width, leadertitle.Height, 30, 30));

            //Collects all points of Team A and add thems to be shown on the leaderboard 
            decimal teamFootA = Properties.Settings.Default.teamFootA;
            decimal teamBaskA = Properties.Settings.Default.teamBaskA;
            decimal teamTugA = Properties.Settings.Default.teamTugA;
            decimal teamRugA = Properties.Settings.Default.teamRugA;
            decimal teamBaseA = Properties.Settings.Default.teamBaseA;

            decimal teamA = teamFootA + teamBaskA + teamTugA + teamRugA + teamBaseA;

            label12.Text = teamA.ToString();

            //Collects all points of Team B and add thems to be shown on the leaderboard 
            decimal teamFootB = Properties.Settings.Default.teamFootB;
            decimal teamBaskB = Properties.Settings.Default.teamBaskB;
            decimal teamTugB = Properties.Settings.Default.teamTugB;
            decimal teamRugB = Properties.Settings.Default.teamRugB;
            decimal teamBaseB = Properties.Settings.Default.teamBaseB;

            decimal teamB = teamFootB + teamBaskB + teamTugB + teamRugB + teamBaseB;

            label13.Text = teamB.ToString();

            //Collects all points of Team C and add thems to be shown on the leaderboard 
            decimal teamFootC = Properties.Settings.Default.teamFootC;
            decimal teamBaskC = Properties.Settings.Default.teamBaskC;
            decimal teamTugC = Properties.Settings.Default.teamTugC;
            decimal teamRugC = Properties.Settings.Default.teamRugC;
            decimal teamBaseC = Properties.Settings.Default.teamBaseC;

            decimal teamC = teamFootC + teamBaskC + teamTugC + teamRugC + teamBaseC;

            label14.Text = teamC.ToString();

            //Collects all points of Team D and add thems to be shown on the leaderboard 
            decimal teamFootD = Properties.Settings.Default.teamFootD;
            decimal teamBaskD = Properties.Settings.Default.teamBaskD;
            decimal teamTugD = Properties.Settings.Default.teamTugD;
            decimal teamRugD = Properties.Settings.Default.teamRugD;
            decimal teamBaseD = Properties.Settings.Default.teamBaseD;

            decimal teamD = teamFootD + teamBaskD + teamTugD + teamRugD + teamBaseD;

            label15.Text = teamD.ToString();

            //Calculates The Highest Number Of Points

         
            int[] totalTeamPoints = { (int)teamA, (int)teamB, (int)teamC, (int)teamD };

            //Checking What Team Has The Most Amount Of Points

            int max, max2, max3;
            max3 = max = max2 = totalTeamPoints[0];
            for (int i = 0; i < totalTeamPoints.Length; i++)
            {
                if (totalTeamPoints[i] > max)
                {
                    max3 = max2;
                    max2 = max;
                    max = totalTeamPoints[i];
                }
                else if (totalTeamPoints[i] > max2)
                {
                    max3 = max2;
                    max2 = totalTeamPoints[i];
                }
                else if (totalTeamPoints[i] > max3)
                    max3 = totalTeamPoints[i];
                else 
                { 

                }
            
            }

            //Checking If Team A has the most points

            if (teamA == max)
            {
                label22.Text = "Gold";

                //Checking If Team B has the 2nd Most Points
                if (teamB == max2)
                {
                    label23.Text = "Silver";
                }
           
                //Checking If Team C has the 2nd Most Points
                if (teamC == max2)
                {
                    label25.Text = "Silver";
                }
                
                //Checking If Team D has the 2nd most points
                if (teamD == max2)
                {
                    label26.Text = "Silver";
                }

                //Checking If Team B has the 3rd Most Points
                if (teamB == max3)
                {
                    label23.Text = "Bronze";
                }

                //Checking If Team C has the 3rd Most Points
                if (teamC == max2)
                {
                    label25.Text = "Bronze";
                }

                //Checking If Team D has the 3rd most points
                if (teamD == max2)
                {
                    label26.Text = "Bronze";
                }

                //Checking If Team B has the lowest Points
                if (teamB != max3 && teamB != max2)
                {
                    label23.Text = "No Award";
                }

                //Checking If Team C has the lowest Points
                if (teamC != max3 && teamC != max2)
                {
                    label25.Text = "No Award";
                }

                //Checking If Team D has the lowest points
                if (teamD != max3 && teamD != max2)
                {
                    label26.Text = "No Award";
                }

            }


            //Checking If Team B has the most points

            if (teamB == max)
            {
                label23.Text = "Gold";

                //Checking If Team A has The 2nd Most Points
                if (teamA == max2)
                {
                    label22.Text = "Silver";
                }

                //Checking If Team C has The 2nd Most Points
                if (teamC == max2)
                {
                    label25.Text = "Silver";
                }

                //Checking If Team D has The 2nd Most Points
                if (teamD == max2)
                {
                    label26.Text = "Silver";
                }

                //Checking If Team A has the 3rd Most Points

                if (teamA == max3)
                {
                    label22.Text = "Bronze";
                }

                //Checking If Team C has The 3rd Most Points
                if (teamC == max3)
                {
                    label25.Text = "Bronze";
                }

                //Checking If Team D has The 3rd Most Points
                if (teamD == max3)
                {
                    label26.Text = "Bronze";
                }

                //Checking If Team B has the lowest Points
                if (teamA != max3 && teamA != max2)
                {
                    label22.Text = "No Award";
                }

                //Checking If Team C has the lowest Points
                if (teamC != max3 && teamC != max2)
                {
                    label25.Text = "No Award";
                }

                //Checking If Team D has the lowest points
                if (teamD != max3 && teamD != max2)
                {
                    label26.Text = "No Award";
                }

            }

            //Checking If Team C Has the most Points
            if (teamC == max)
            {
                label25.Text = "Gold";

                //Checking If Team A Has the 2nd Most Amount Of Points
                if (teamA == max2)
                {
                    label22.Text = "Silver";
                }

                //Checking If Team B Has the 2nd Most Amount Of Points
                if (teamB == max2)
                {
                    label23.Text = "Silver";
                }

                //Checking If Team D Has the 2nd Most Amount Of Points
                if (teamD == max2)
                {
                    label26.Text = "Silver";
                }

                //Checking If Team A Has the 3rd Most Amount Of Points
                if (teamA == max3)
                {
                    label22.Text = "Bronze";
                }

                //Checking If Team B Has the 3rd Most Amount Of Points
                if (teamB == max3)
                {
                    label23.Text = "Bronze";
                }

                //Checking If Team D Has the 3rd Most Amount Of Points
                if (teamD == max3)
                {
                    label26.Text = "Bronze";
                }

                //Checking If Team B has the lowest Points
                if (teamB != max3 && teamB != max2)
                {
                    label23.Text = "No Award";
                }

                //Checking If Team A has the lowest Points
                if (teamA != max3 && teamA != max2)
                {
                    label25.Text = "No Award";
                }

                //Checking If Team D has the lowest points
                if (teamD != max3 && teamD != max2)
                {
                    label26.Text = "No Award";
                }



                //********************************************** TEAM D ***************************************

                if (teamD == max)
            {
                label26.Text = "Gold";

                //Checking If Team A has The 2nd Most Points
                if (teamA == max2)
                {
                    label22.Text = "Silver";
                }

                //Checking If Team B Has the 2nd Most Amount Of Points
                if (teamB == max2)
                {
                    label23.Text = "Silver";
                }

                //Checking If Team C has The 2nd Most Points
                if (teamC == max2)
                {
                    label25.Text = "Silver";
                }

                //Checking If Team A has The 3rd Most Points
                if (teamA == max3)
                {
                    label22.Text = "Silver";
                }

                //Checking If Team B Has the 3rd Most Amount Of Points
                if (teamB == max3)
                {
                    label23.Text = "Silver";
                }

                //Checking If Team C has The 3rd Most Points
                if (teamC == max3)
                {
                    label25.Text = "Silver";
                }

                //Checking If Team A has the lowest Points
                if (teamA != max3 && teamA != max2)
                {
                    label22.Text = "No Award";
                }

                //Checking If Team B has the lowest Points
                if (teamB != max3 && teamB != max2)
                {
                    label23.Text = "No Award";
                }

                //Checking If Team C has the lowest points
                if (teamC != max3 && teamC != max2)
                {
                    label25.Text = "No Award";
                }

                }

            }
            

            

            //************************************************************ INDIVIDUAL LEADERBOARD ********************************************************

            //Golf

            decimal indivGolf1 = Properties.Settings.Default.indivGolf1;
            decimal indivGolf2 = Properties.Settings.Default.indivGolf2;
            decimal indivGolf3 = Properties.Settings.Default.indivGolf3;

            //Coding 

            decimal indivCode1 = Properties.Settings.Default.indivCode1;
            decimal indivCode2 = Properties.Settings.Default.indivCode2;
            decimal indivCode3 = Properties.Settings.Default.indivCode3;

            //Table Tennis 

            decimal indivTennis1 = Properties.Settings.Default.indivTennis1;
            decimal indivTennis2 = Properties.Settings.Default.indivTennis2;
            decimal indivTennis3 = Properties.Settings.Default.indivTennis3;

            //Bowling

            decimal indivBowling1 = Properties.Settings.Default.indivBowling1;
            decimal indivBowling2 = Properties.Settings.Default.indivBowling2;
            decimal indivBowling3 = Properties.Settings.Default.indivBowling3;

            //Art

            decimal indivArt1 = Properties.Settings.Default.indivArt1;
            decimal indivArt2 = Properties.Settings.Default.indivArt2;
            decimal indivArt3 = Properties.Settings.Default.indivArt3;



            //Array for all Individuals Points 

            int[] individualAllPoints = { (int)indivGolf1, (int)indivGolf2, (int)indivGolf3, (int)indivCode1, (int)indivCode2, (int)indivCode3, (int)indivTennis1, 
                (int)indivTennis2, (int)indivTennis3, (int)indivBowling1, (int)indivBowling2, (int)indivBowling3, (int)indivArt1, (int)indivArt2, (int)indivArt3 };

            //Checking The Individuals With The Most Points 

            int max4, max5, max6;
            max6 = max4 = max5 = individualAllPoints[0];
            for (int i = 0; i < individualAllPoints.Length; i++)
            {
                if (individualAllPoints[i] > max4)
                {
                    max6 = max5;
                    max5 = max4;
                    max4 = individualAllPoints[i];

                }
                else if (individualAllPoints[i] > max5)
                {
                    max6 = max5;
                    max5 = individualAllPoints[i];
                }
                else if (individualAllPoints[i] > max6)
                    max6 = individualAllPoints[i];
                else
                {

                }

            }

            //Showing The Top Three Highest Points Achieved

            label19.Text = max4.ToString();
            label20.Text = max5.ToString();
            label21.Text = max6.ToString();

            //********************************************************************Showing The Individual In 1st Place*********************************************************

            //Golf

            if (indivGolf1 == max4)
            {
                label16.Text = Properties.Settings.Default.individual1;
            }

            else if (indivGolf2 == max4)
            {
                label16.Text = Properties.Settings.Default.individual2;
            }

            else if (indivGolf3 == max4)
            {
                label16.Text = Properties.Settings.Default.individual3;
            }

            //Code

            else if (indivCode1 == max4)
            {
                label16.Text = Properties.Settings.Default.individual4;
            }

            else if (indivCode2 == max4)
            {
                label16.Text = Properties.Settings.Default.individual5;
            }

            else if (indivCode3 == max4)
            {
                label16.Text = Properties.Settings.Default.individual6;
            }

            //Tennis

            else if (indivTennis1 == max4)
            {
                label16.Text = Properties.Settings.Default.individual7;
            }

            else if (indivTennis2 == max4)
            {
                label16.Text = Properties.Settings.Default.individual8;
            }

            else if (indivTennis3 == max4)
            {
                label16.Text = Properties.Settings.Default.individual9;
            }

            //Bowling

            else if (indivBowling1 == max4)
            {
                label16.Text = Properties.Settings.Default.individual10;
            }

            else if (indivBowling2 == max4)
            {
                label16.Text = Properties.Settings.Default.individual11;
            }

            else if (indivBowling3 == max4)
            {
                label16.Text = Properties.Settings.Default.individual12;
            }

            //Art

            else if (indivArt1 == max4)
            {
                label16.Text = Properties.Settings.Default.individual13;
            }

            else if (indivArt2 == max4)
            {
                label16.Text = Properties.Settings.Default.individual14;
            }

            else if (indivArt3 == max4)
            {
                label16.Text = Properties.Settings.Default.individual15;
            }

            //*************************************************************************************Showing The Individual In 2nd Place********************************************************************************

            //Golf

            if (indivGolf1 == max5)
            {
                label17.Text = Properties.Settings.Default.individual1;
            }

            else if (indivGolf2 == max5)
            {
                label17.Text = Properties.Settings.Default.individual2;
            }

            else if (indivGolf3 == max5)
            {
                label17.Text = Properties.Settings.Default.individual3;
            }

            //Code

            else if (indivCode1 == max5)
            {
                label17.Text = Properties.Settings.Default.individual4;
            }

            else if (indivCode2 == max5)
            {
                label17.Text = Properties.Settings.Default.individual5;
            }

            else if (indivCode3 == max5)
            {
                label17.Text = Properties.Settings.Default.individual6;
            }

            //Tennis

            else if (indivTennis1 == max5)
            {
                label17.Text = Properties.Settings.Default.individual7;
            }

            else if (indivTennis2 == max5)
            {
                label17.Text = Properties.Settings.Default.individual8;
            }

            else if (indivTennis3 == max5)
            {
                label17.Text = Properties.Settings.Default.individual9;
            }

            //Bowling

            else if (indivBowling1 == max5)
            {
                label17.Text = Properties.Settings.Default.individual10;
            }

            else if (indivBowling2 == max5)
            {
                label17.Text = Properties.Settings.Default.individual11;
            }

            else if (indivBowling3 == max5)
            {
                label17.Text = Properties.Settings.Default.individual12;
            }

            //Art

            else if (indivArt1 == max5)
            {
                label17.Text = Properties.Settings.Default.individual13;
            }

            else if (indivArt2 == max5)
            {
                label17.Text = Properties.Settings.Default.individual14;
            }

            else if (indivArt3 == max5)
            {
                label17.Text = Properties.Settings.Default.individual15;
            }

            //*************************************************************************************Showing The Individual In 3rd Place********************************************************************************

            //Golf

            if (indivGolf1 == max6)
            {
                label18.Text = Properties.Settings.Default.individual1;
            }

            else if (indivGolf2 == max6)
            {
                label18.Text = Properties.Settings.Default.individual2;
            }

            else if (indivGolf3 == max6)
            {
                label18.Text = Properties.Settings.Default.individual3;
            }

            //Code

            else if (indivCode1 == max6)
            {
                label18.Text = Properties.Settings.Default.individual4;
            }

            else if (indivCode2 == max6)
            {
                label18.Text = Properties.Settings.Default.individual5;
            }

            else if (indivCode3 == max6)
            {
                label18.Text = Properties.Settings.Default.individual6;
            }

            //Tennis

            else if (indivTennis1 == max6)
            {
                label18.Text = Properties.Settings.Default.individual7;
            }

            else if (indivTennis2 == max6)
            {
                label18.Text = Properties.Settings.Default.individual8;
            }

            else if (indivTennis3 == max6)
            {
                label18.Text = Properties.Settings.Default.individual9;
            }

            //Bowling

            else if (indivBowling1 == max6)
            {
                label18.Text = Properties.Settings.Default.individual10;
            }

            else if (indivBowling2 == max6)
            {
                label18.Text = Properties.Settings.Default.individual11;
            }

            else if (indivBowling3 == max6)
            {
                label18.Text = Properties.Settings.Default.individual12;
            }

            //Art

            else if (indivArt1 == max6)
            {
                label18.Text = Properties.Settings.Default.individual13;
            }

            else if (indivArt2 == max6)
            {
                label18.Text = Properties.Settings.Default.individual14;
            }

            else if (indivArt3 == max6)
            {
                label18.Text = Properties.Settings.Default.individual15;
            }

            else
            {

            }

            if (label16.Text == "")
            {
                label16.Text = "Unnamed";
            }

            if (label17.Text == "")
            {
                label17.Text = "Unnamed";
            }

            if (label18.Text == "")
            {
                label18.Text = "Unnamed";
            }

        }

        private void leaderquitbtn_Click(object sender, EventArgs e)
        {
            mainmenu mainquitbutton = new mainmenu();
            this.Hide();
            mainquitbutton.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            
        }
    }
}
