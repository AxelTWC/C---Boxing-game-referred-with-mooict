
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

﻿﻿/* boxingGame
   Name: Axel Tang
   Date: May 26
   Teacher: Mrs.Schilstra
   Purpose: Creating a boxing game
*/
namespace boxingGame
{

    public partial class myHealth : Form
    {

        bool blockAttack = false;  //Block boolean

        List<string> enemyAttacks = new List<string> { "left", "right" , "block"};
        //To generatate random numbers
        Random rnd = new Random();

        int enemySpeed = 5;// the speed of the enemy boxer

        int i = 0;

        bool enemyBlocked; 

        int playerHealth = 100; //Set player's health to 100
        int enemyHealth = 100;  //Set enemy's health to 100


        public myHealth()
        {
                   
            InitializeComponent();
            MessageBox.Show("Left arrow key to punch with left hand,Right arrow key to punch with right hand, down arrow key to block opponent's attack!", "Instructions"); //Introduction
        }

        private void keyisdown(object sender, KeyEventArgs e) //method for pressing keys
        {
            if (e.KeyCode == Keys.Down) //When player hits the down arrow key
            {
                boxer.Image = Properties.Resources.boxer_block; //Change image to block
                blockAttack = true; //Block
            }

            if (e.KeyCode == Keys.Left)//Left key
            {
                boxer.Image = Properties.Resources.boxer_left_punch;

                if (enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !enemyBlocked)
                {
                    enemyHealth -= 5;
                }
            }
            if (e.KeyCode == Keys.Right)//Right Key
            {
                boxer.Image = Properties.Resources.boxer_right_punch;

                if (enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !enemyBlocked)
                {
                    enemyHealth -= 5;
                }
            }
        }

        private void keyisup(object sender, KeyEventArgs e)//When player releases key
        {
            boxer.Image = Properties.Resources.boxer_stand;
            blockAttack = false;
        }

        private void resetGame()
        {
            enemyTimer.Start();//Starts the enemy punch timer
            enemyMove.Start(); //Start the enemy move timer

            enemyBoxer.Left = 385;
            enemyBoxer.Top = 297;

            enemyBoxer.Image = Properties.Resources.enemy_stand;
            boxer.Image = Properties.Resources.boxer_stand;

            playerHealth = 100; //reset player health to 100
            enemyHealth = 100;  //reset enemy health to 100
        }

        private void enemyMoveEvent (object sender, EventArgs e) 
        {
            enemyBoxer.Left += enemySpeed; //linking the enemy speed to enemy moving left

            if (playerHealth > 1)
            {
                playerLife.Value = Convert.ToInt32(playerHealth); //Link to progressbar/health bar
            }
            if (enemyHealth > 1) 
            {
                enemyLife.Value = Convert.ToInt32(enemyHealth); //Link to enemy life progress bar
            }
            if (enemyBoxer.Left >480) //Movements
            {
                enemySpeed = -5;
            }

            if(enemyBoxer.Left <315)
            {
                enemySpeed = 5;
            }

            if (enemyHealth < 1)
            {
                enemyTimer.Stop();
                enemyMove.Stop();
                MessageBox.Show("Congrats! You've beaten Rob, Click OK to Play Again!");//Message when Win
                resetGame();
            }
            if (playerHealth <1)
            {
                enemyTimer.Stop();
                enemyMove.Stop(); 
                MessageBox.Show("Mission failed, we will get em next time :> ! Click ok to retry!");//Message when lose
                resetGame();
        }
      }
    private void enemyPunchEvent(object sender, EventArgs e)
{
    i = rnd.Next(0,enemyAttacks.Count);

    switch  (enemyAttacks[i].ToString())
{
            // When Attack Left 
    case "Left":
    enemyBoxer.Image = Properties.Resources.enemy_punch1;

    if(enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !blockAttack)
{
    playerHealth -= 20;
}
    enemyBlocked = false; 
        //When Attack Right
    break;
    case "right":
    enemyBoxer.Image = Properties.Resources.enemy_punch2;
    if (enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !blockAttack)
{
    playerHealth -=20;
}
    enemyBlocked = false; 
    break;
            //When Blocking
    case "block":
    enemyBoxer.Image = Properties.Resources.enemy_block;
    enemyBlocked = true;
    break;
}

}

}

}
