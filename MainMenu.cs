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
    public partial class mainmenu : Form
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


        public mainmenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Calls function to round the edges of all squares/rectangles
        private void Form1_Load(object sender, EventArgs e)
        {
            optionpnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, optionpnl.Width, optionpnl.Height, 30, 30));
            quitbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, quitbtn.Width, quitbtn.Height, 30, 30));
            teamsbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, teamsbtn.Width, teamsbtn.Height, 30, 30));
            individualbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, individualbtn.Width, individualbtn.Height, 30, 30));
            leaderboardbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, leaderboardbtn.Width, leaderboardbtn.Height, 30, 30));
            mainmenupnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mainmenupnl.Width, mainmenupnl.Height, 30, 30));
        }

        //View Leader board button
        private void leaderboardbtn_Click(object sender, EventArgs e)
        {
            LeaderBoard leaderboardbutton = new LeaderBoard();
            this.Hide();
            leaderboardbutton.ShowDialog();
        }

        private void mainmenulbl_Click(object sender, EventArgs e)
        {

        }

        //Quit Button
        private void quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //View Team Events Button
        private void teamsbtn_Click(object sender, EventArgs e)
        {
            TeamEvents teambutton = new TeamEvents();
            this.Hide();
            teambutton.ShowDialog();
            
        }

        //View Individual Events Button 
        private void individualbtn_Click(object sender, EventArgs e)
        {
            IndividualEvents individualbutton = new IndividualEvents();
            this.Hide();
            individualbutton.ShowDialog();
        }
    }
}
