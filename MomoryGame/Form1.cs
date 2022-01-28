using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;

namespace MomoryGame
{
    public partial class Form1 : Form
    {
        private static Random r = new Random();

        List<Moves> MovesGenerated = new List<Moves>();
        List<Moves> MovesPlayer = new List<Moves>();
        Color defColott = Color.White;
        private GameData gameData;
        private int waittime = 300;
        private SoundPlayer failSound = new SoundPlayer(@"fail.wav");
        private SoundPlayer clickSound = new SoundPlayer(@"click.wav");
        private SoundPlayer chackkSound = new SoundPlayer(@"chack.wav");
        private SoundPlayer winSound = new SoundPlayer(@"win.wav");

        public Form1()
        {
            InitializeComponent();

            buttonLeftDown.BackColor = defColott;
            buttonLeftUp.BackColor = defColott;
            buttonRightDown.BackColor = defColott;
            buttonRightUp.BackColor = defColott;

            if (File.Exists("game.data"))
            {
                gameData = SerializToFile.DeSerializ<GameData>("game.data");
            }
            else
            {
                gameData = new GameData();
            }
            WriteData();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            chackkSound.Play();
            buttonCech.Enabled = false;
            MovesPlayer.Clear();
            MovesGenerated.Clear();

            gameData.PlayerNmame = textBoxPlayerName.Text;

            GenerateMoves();

            Game();

            buttonLeftDown.BackColor = defColott;
            buttonLeftUp.BackColor = defColott;
            buttonRightDown.BackColor = defColott;
            buttonRightUp.BackColor = defColott;

            WriteData();
            buttonCech.Enabled = true;
        }

        private void buttonLeftUp_Click(object sender, EventArgs e)
        {
            MovesPlayer.Add(Moves.LeftUp);
            WriteData();
            clickSound.Play();
        }

        private void buttonRightUp_Click(object sender, EventArgs e)
        {
            MovesPlayer.Add(Moves.RightUp);
            WriteData();
            clickSound.Play();
        }

        private void buttonLeftDown_Click(object sender, EventArgs e)
        {
            MovesPlayer.Add(Moves.LeftDown);
            WriteData();
            clickSound.Play();
        }

        private void buttonRightDown_Click(object sender, EventArgs e)
        {
            MovesPlayer.Add(Moves.RightDown);
            WriteData();
            clickSound.Play();
        }

        private void Game() 
        {
            buttonStart.Enabled = false;
            buttonCech.Enabled = false;
            foreach (var item in MovesGenerated)
            {
                switch (item)
                {
                    case MomoryGame.Moves.LeftUp:
                        buttonLeftUp.BackColor = Color.Red;
                        Application.DoEvents();
                        Thread.Sleep(waittime);
                        buttonLeftUp.BackColor = defColott;
                        break;
                    case MomoryGame.Moves.RightUp:
                        buttonRightUp.BackColor = Color.Red;
                        Application.DoEvents();
                        Thread.Sleep(waittime);
                        buttonRightUp.BackColor = defColott;
                        break;
                    case MomoryGame.Moves.LeftDown:
                        buttonLeftDown.BackColor = Color.Red;
                        Application.DoEvents();
                        Thread.Sleep(waittime);
                        buttonLeftDown.BackColor = defColott;
                        break;
                    case MomoryGame.Moves.RightDown:
                        buttonRightDown.BackColor = Color.Red;
                        Application.DoEvents();
                        Thread.Sleep(waittime);
                        buttonRightDown.BackColor = defColott;
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(waittime);
            }
            buttonStart.Enabled = true;
            buttonCech.Enabled = true; 
        }

        private void WriteData() 
        {
            labelfails.Text = gameData.Fails.ToString();
            labelrounds.Text = gameData.Round.ToString();
            labelWinns.Text = gameData.Winns.ToString();
            labelplayerName.Text = gameData.PlayerNmame.ToString();
            labelMoveDone.Text = MovesPlayer.Count().ToString();
        }

        private bool Chack() 
        {
            if (MovesGenerated.Count != MovesPlayer.Count)
            {
                return false;
            }
            for (int i = 0; i < MovesGenerated.Count; i++) 
            {
                if (MovesGenerated[i] != MovesPlayer[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void GenerateMoves() 
        {
            MovesGenerated.Clear();
            for (int i = 0; i < gameData.Round; i++)
            {
                MovesGenerated.Add((Moves)r.Next(4));
            }
        }

        private void buttonCech_Click(object sender, EventArgs e)
        {

            if (Chack())
            {
                gameData.Round++;
                gameData.Winns++;
                winSound.Play();
            }
            else
            {
                gameData.Fails++;
                failSound.Play();
            }
            WriteData();
            MovesPlayer.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializToFile.Serializ<GameData>(gameData, "game.data");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            gameData = new GameData();
            WriteData();
        }

        private void EnambleChack() 
        {
            buttonCech.Enabled = true;
        }
    }
}
