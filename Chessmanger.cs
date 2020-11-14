﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAROGAME
{
    public class Chessmanager
    {
        #region Properties
        private Panel chessboard;
        public Panel Chessboard
        {
            get { return chessboard; }
            set { chessboard = value; }
        }

        public List<Player> Player { get => player; set => player = value; }
        public int Currentplayer { get => currentplayer; set => currentplayer = value; }
        public TextBox Playername { get => playername; set => playername = value; }
        public PictureBox Playermark { get => playermark; set => playermark = value; }

        public List<List<Button>> GetMatrix()
        {
            return matrix;
        }

        public void SetMatrix(List<List<Button>> value)
        {
            matrix = value;
        }

        private List<Player> player;

        private int currentplayer;//nguoi choi hien tai 

        private TextBox playername;

        private PictureBox playermark;
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;

        public Stack<PlayInfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }
        #endregion

        #region Initialize
        public Chessmanager(Panel Chessboard, TextBox playername, PictureBox mark)
        {
            this.Chessboard = Chessboard;
            this.Playername = playername;
            this.Playermark = mark ;

            this.Player = new List<Player>() 
            {
                new Player("X TURN", Image.FromFile(Application.StartupPath +"\\Resources\\X LOGO.png")),
                new Player("O TURN", Image.FromFile(Application.StartupPath +"\\Resources\\O LOGO.png"))

                // truyen bieu tuong nguoi choi vao
                /*new Player("BLACK TURN", Color.Black),
                new Player("RED TURN", Color.Red)*/

            };

            currentplayer = 0;
            ChangePlayer();
        }

        #endregion

        #region Methods
        public void Drawchessboard()
        {
            SetMatrix(new List<List<Button>>());

            Button oldbutton = new Button { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constains.chessboardheight; i++)
            {
                GetMatrix().Add(new List<Button>());
                for (int j = 0; j < Constains.chessboardwidth; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constains.chesswidth,
                        Height = Constains.chessheight,
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    
                    
                    btn.Click += Btn_Click;
                    
                    Chessboard.Controls.Add(btn);

                    GetMatrix()[i].Add(btn);

                    oldbutton = btn;

                    btn.FlatStyle = FlatStyle.Flat;
                    //btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + Constains.chessheight);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
                
            }
        }

        private void Btn_Click(object sender, EventArgs e)// uy thac mot cai event cho button
        {

            Button btn = sender as Button; // day chinh la button ma ban click vo
             if (btn.BackgroundImage != null)
                return;
            Mark(btn);
            ChangePlayer();
            if (isEndGame(btn))
            {
                EndGame();
            }

            /*btn.BackColor = Player[currentplayer].Mark;
            //doi nguoi choi hien tai 
              currentplayer = currentplayer == 1 ? 0 : 1;
            Playername.Text = Player[currentplayer].Name;
            Playermark.BackColor = Player[currentplayer].Mark;*/
        }

        private void EndGame()
        {
            MessageBox.Show("THE GAME IS OVER!!! :)) ");
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = GetMatrix()[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }


        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (GetMatrix()[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Constains.chessboardwidth; i++)
            {
                if (GetMatrix()[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 4;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (GetMatrix()[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Constains.chessboardheight; i++)
            {
                if (GetMatrix()[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 4;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (GetMatrix()[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Constains.chessboardwidth - point.X; i++)
            {
                if (point.Y + i >= Constains.chessboardheight || point.X + i >= Constains.chessboardwidth)
                    break;

                if (GetMatrix()[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 4;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Constains.chessboardwidth || point.Y - i < 0)
                    break;

                if (GetMatrix()[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Constains.chessboardwidth - point.X; i++)
            {
                if (point.Y + i >= Constains.chessboardheight || point.X - i < 0)
                    break;

                if (GetMatrix()[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 4;
        }


        private void Mark(Button btn)
        {
            //btn.BackgroundImage = Player[currentplayer].Mark;
            //btn.BackColor = Player[currentplayer].Mark;

            btn.BackgroundImage = Player[currentplayer].Mark;
            currentplayer = currentplayer == 1 ? 0 : 1;
        }

        private void ChangePlayer()
        {
            Playername.Text = Player[currentplayer].Name;
            Playermark.BackgroundImage = Player[currentplayer].Mark;

            //Playermark.BackColor = Player[currentplayer].Mark;
        }

    }
    #endregion


}
