using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapatanGame.cs.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TapatanGame.cs
{
    public partial class GamePage : Form
    {
        private Dictionary<string, int> playerWins = new Dictionary<string, int>();
        private Dictionary<string, int> playerGames = new Dictionary<string, int>();

        private bool player1, won;
        private bool player2;
        private int p1MoveCount;
        private int p2MoveCount;
        private PictureBox pxt = new PictureBox();
        private string text1;
        private string text2;
        private Stopwatch stopwatch = new Stopwatch();
        private System.Windows.Forms.Timer CountDown;
        private Label lblTime = new Label();
        private SoundPlayer player = new SoundPlayer();


        //---------------------------
        public GamePage()
        {
            InitializeComponent();
            PlayMusic();
            pnlbckonlopt.SendToBack();

            lblp1turn.Visible = false;
            player1 = true;
            p1MoveCount = 0;
            p2MoveCount = 0;
            GameTimer.Start();
            stopwatch = new Stopwatch();
            CountDown = new System.Windows.Forms.Timer();
            lblTime = new Label();

            // Set up controls
            lblTime.Text = "00:00:00";
            lblTime.Font = new Font("BankGothic Md BT", 20);
            lblTime.ForeColor = System.Drawing.Color.Turquoise;
            lblTime.BackColor = TransparencyKey;
            lblTime.BringToFront();
            lblTime.AutoSize = true;
            lblTime.Location = new Point(270, 93);
            Controls.Add(lblTime);
            // Set timer interval to 1 millisecond for accurate timing
            CountDown.Interval = 1;
            CountDown.Tick += CountDownTimer_Tick;
            CountDown.Start();

            //----------------------------
            exitpnl.Hide();
        }

        #region Game Leaderboard Functions
        private void UpdateLeaderboard()
        {
            var sortedPlayers = playerWins.OrderByDescending(x => (double)x.Value / playerGames[x.Key])
                                           .Select(x => x.Key)
                                           .ToList();

            leaderboardListBox.Items.Clear();

            foreach (var player in sortedPlayers)
            {
                double winrate;
                if (playerGames[player] == 0)
                {
                    // If no games have been played, win rate is 0%
                    winrate = 0.0;
                }
                else
                {
                    // Calculate win rate
                    winrate = (double)playerWins[player] / playerGames[player] * 100;
                }

                // Format win rate to two decimal places
                string formattedWinrate = winrate.ToString("F2");

                leaderboardListBox.Items.Add($"{player}: Winrate - {formattedWinrate}%");
                
            }

        }

        private void UpdatePlayerStats(string player, bool hasWon)
        {
            if (!playerWins.ContainsKey(player))
            {
                playerWins[player] = 0;
                playerGames[player] = 0;
            }

            playerGames[player]++;
            if (hasWon)
            {
                playerWins[player]++;
            }

            UpdateLeaderboard();
        }
        private void GameEnded(string winner)
        {
            UpdatePlayerStats(winner, true);
            string loser = (winner == "Player 1") ? "Player 2" : "Player 1";
            UpdatePlayerStats(loser, false);

            
        }
        #endregion

        #region Game Music
        private void PlayMusic()
        {
            try
            {
                player.SoundLocation = @"C:\path\to\your\bgmusic\bg1.wav";
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing music: " + ex.Message);
            }

        }
        #endregion

        #region Game Cells
        private void cells(object sender, EventArgs e)
        {
            pxt = sender as PictureBox;


            if (p1MoveCount < 3 || p2MoveCount < 3)
            {
                stopwatch.Start();
                if (player1 && pxt.Text != "MR. CAPYBARA" && pxt.Text != "MR. HEDGEHOG")
                {

                    pxt.Image = Resources.capy;
                    pxt.Text = "MR. CAPYBARA";
                    text1 = pxt.Text;
                    p1MoveCount++;
                    lblp1turn.Visible = true;
                    lblp2turn.Visible = false;
                    player1 = false;
                    player2 = true;

                }

                if (player2 && pxt.Text != "MR. CAPYBARA" && pxt.Text != "MR. HEDGEHOG")
                {
                    pxt.Image = Resources.hedgehog;
                    pxt.Text = "MR. HEDGEHOG";
                    text2 = pxt.Text;
                    p2MoveCount++;
                    lblp1turn.Visible = false;
                    lblp2turn.Visible = true;
                    player1 = true;
                    player2 = false;
                }

            }
            else
            {
                if (player1 && pxt.Text == "MR. CAPYBARA")
                {
                    pxt.Image = null;
                    pxt.Text = null;
                    p1MoveCount--;
                }

                if (player2 && pxt.Text == "MR. HEDGEHOG")
                {
                    pxt.Image = null;
                    pxt.Text = null;
                    p2MoveCount--;
                }
            }


        }
        #endregion

        #region Game Check Winner
        private void CheckForWinner()
        {
            string winner = "";
            bool timerup = false;

            // Check for horizontal
            if ((pbpos1.Text == text1 && pbpos2.Text == text1 && pbpos3.Text == text1) ||
                (pbpos1.Text == text2 && pbpos2.Text == text2 && pbpos3.Text == text2))
            {
                won = true;
                winner = (pbpos1.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }
            else if ((pbpos4.Text == text1 && pbpos5.Text == text1 && pbpos6.Text == text1) ||
                     (pbpos4.Text == text2 && pbpos5.Text == text2 && pbpos6.Text == text2))
            {
                won = true;
                winner = (pbpos4.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }
            else if ((pbpos7.Text == text1 && pbpos8.Text == text1 && pbpos9.Text == text1) ||
                     (pbpos7.Text == text2 && pbpos8.Text == text2 && pbpos9.Text == text2))
            {
                won = true;
                winner = (pbpos7.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }

            // Check for vertical
            else if ((pbpos1.Text == text1 && pbpos4.Text == text1 && pbpos7.Text == text1) ||
                     (pbpos1.Text == text2 && pbpos4.Text == text2 && pbpos7.Text == text2))
            {
                won = true;
                winner = (pbpos1.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }
            else if ((pbpos2.Text == text1 && pbpos5.Text == text1 && pbpos8.Text == text1) ||
                     (pbpos2.Text == text2 && pbpos5.Text == text2 && pbpos8.Text == text2))
            {
                won = true;
                winner = (pbpos2.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }
            else if ((pbpos3.Text == text1 && pbpos6.Text == text1 && pbpos9.Text == text1) ||
                     (pbpos3.Text == text2 && pbpos6.Text == text2 && pbpos9.Text == text2))
            {
                won = true;
                winner = (pbpos3.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }

            // Check for diagonal
            else if ((pbpos1.Text == text1 && pbpos5.Text == text1 && pbpos9.Text == text1) ||
                     (pbpos1.Text == text2 && pbpos5.Text == text2 && pbpos9.Text == text2))
            {
                won = true;
                winner = (pbpos1.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }
            else if ((pbpos3.Text == text1 && pbpos5.Text == text1 && pbpos7.Text == text1) ||
                     (pbpos3.Text == text2 && pbpos5.Text == text2 && pbpos7.Text == text2))
            {
                won = true;
                winner = (pbpos3.Text == text1) ? "Player 1" : "Player 2"; // Player 1 or Player 2 wins
                timerup = true;
            }

            if (timerup) // Stop timer if there's a winner or no more empty cells
            {
                GameTimer.Stop();
            }
            GameEnded(winner);
        }
        #endregion

        #region Game Events
        private void Homepg(object sender, EventArgs e)
        {
            Form1 homepg = new Form1();
            homepg.ShowDialog();
            this.Hide();
        }
        private void gpSetting(object sender, EventArgs e)
        {
            pnlbckonlopt.BringToFront();
            stopwatch.Stop();
        }
        private void gpSkippnl(object sender, EventArgs e)
        {
            pnlbckonlopt.SendToBack();
            stopwatch.Start();
        }
        private void exitGame(object sender, EventArgs e)
        {
            exitpnl.Show();
        }
        private void exitNo(object sender, EventArgs e)
        {
            exitpnl.SendToBack();
        }
        private void exitYes(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void leadbaord(object sender, EventArgs e)
        {
            pnlleadboard2.BringToFront();
        }

        private void skipleadboard(object sender, EventArgs e)
        {
            pnlleadboard2.SendToBack();
        }


        #region sett_inner_funcs
        private void Game_Restart(object sender, EventArgs e)
        {
            gameRestart();
        }
        private void musicoff(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void musicon(object sender, EventArgs e)
        {
            PlayMusic();
        }
        #endregion


        #endregion

        #region Game Restart
        void gameRestart()
        {
            // Reset game state variables
            player1 = true;
            p1MoveCount = 0;
            p2MoveCount = 0;
            won = false;
            text1 = ".";
            text2 = ".";
            stopwatch.Stop();
            pnlsettings.SendToBack();
            won = false;
            stopwatch.Reset();
            lblTime.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");

            // Reset picture boxes (clear images and text)
            foreach (Control control in pnlgameboard.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    if (pictureBox.Name == "pbboardaxis")
                    {

                    }
                    else
                    {
                        pictureBox.Image = null;
                        pictureBox.Text = "";
                    }

                }
            }
            GameTimer.Start();

        }
        #endregion

        #region Game Timer
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            CheckForWinner();

            if (won)
            {
                stopwatch.Stop();
                MessageBox.Show($"{pxt.Text} wins!", "Congratulations!");

                stopwatch.Reset();
                won = false;
                lblTime.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
                gameRestart();
            }
        }
        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");

            if (stopwatch.Elapsed >= TimeSpan.FromMinutes(1))
            {
                stopwatch.Stop();
                CountDown.Stop();
                MessageBox.Show("Time's Up!");


            }
        }
        #endregion


    }
}