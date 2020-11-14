using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CAROGAME
{
    public partial class Form1 : Form
    {
        #region Properties
        Chessmanager Chessboard;

        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            Chessboard = new Chessmanager(panelchessboard, playerturn, picturematch);
            Chessboard.EndedGame += ChessBoard_EndedGame;
            //Chessboard.PlayerMarked += ChessBoard_PlayerMarked;
            
            Chessboard.Drawchessboard();

            prcbCountDown.Step = Constains.COOL_DOWN_STEP;
            prcbCountDown.Maximum = Constains.COOL_DOWN_TIME;
            prcbCountDown.Value = 0;

            tmCoolDown.Interval = Constains.COOL_DOWN_INTERVAL;

            socket = new SocketManager();

            NewGame();
        }

        #region Methods

        void EndGame()
        {
            tmCoolDown.Stop();
            panelchessboard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("Kết thúc");
        }

        void NewGame()
        {
            prcbCountDown.Value = 0;
            tmCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            Chessboard.Drawchessboard();
        }

        void Quit()
        {
            Application.Exit();
        }

        private void Undo()
        {
            Chessboard.Undo();
            prcbCountDown.Value = 0;
        }

        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            panelchessboard.Enabled = false;
            prcbCountDown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            undoToolStripMenuItem.Enabled = false;

            Listen();
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCountDown.PerformStep();

            if (prcbCountDown.Value >= prcbCountDown.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            panelchessboard.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

               

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        panelchessboard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prcbCountDown.Value = 0;
                        panelchessboard.Enabled = true;
                        tmCoolDown.Start();
                        Chessboard.OtherPlayerMark(data.Point);
                        undoToolStripMenuItem.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    prcbCountDown.Value = 0;
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Đã 5 con trên 1 hàng");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Hết giờ");
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Người chơi đã thoát");
                    break;
                default:
                    break;
            }

            Listen();
        }

        #endregion

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            //if (!socket.ConnectServer())
            //{
            //    socket.CreateServer();

            //    Thread listenThread = new Thread(() =>
            //    {
            //        while (true)
            //        {
            //            Thread.Sleep(500);
            //            try
            //            {
            //                Listen();
            //                break;
            //            }
            //            catch
            //            {

            //            }
            //        }
            //    });
            //    listenThread.IsBackground = true;
            //    listenThread.Start();
            //}
            //else
            //{
            //    Thread listenThread = new Thread(() =>
            //    {
            //        Listen();
            //    });
            //    listenThread.IsBackground = true;
            //    listenThread.Start();

            //    socket.Send("Thông tin từ Client");
            //}

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                panelchessboard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                panelchessboard.Enabled = false;
                Listen();
            }
        }
    }
}
