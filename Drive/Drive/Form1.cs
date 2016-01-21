using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Drive
{
    public partial class Form1 : Form
    {
        System.Threading.Timer gameTimer = null;
        private bool buttonClicked = false;

        List<Car> playerList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Start()
        {
            TimerCallback timercb = new TimerCallback(TimerCB);
            gameTimer = new System.Threading.Timer(timercb, null, 75, 75);
        }

        void button1_Click(Object sender, EventArgs e)
        {
            buttonClicked = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            Car Player1 = new Car(1, 0);
            playerList.Add(Player1);
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        void button2_Click(Object sender, EventArgs e)
        {
            buttonClicked = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            Car Player1 = new Car(0, 0);
            Car Player2 = new Car(2, 1);
            playerList.Add(Player1);
            playerList.Add(Player2);
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown1);
        }
        void button3_Click(Object sender, EventArgs e)
        {
            buttonClicked = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            Car Player1 = new Car(0, 0);
            Car Player2 = new Car(1, 1);
            Car Player3 = new Car(2, 2);
            playerList.Add(Player1);
            playerList.Add(Player2);
            playerList.Add(Player3);
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown2);
        }
        void button4_Click(Object sender, EventArgs e)
        {
            buttonClicked = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            Car Player1 = new Car(0, 0);
            Car Player2 = new Car(1, 1);
            Car Player3 = new Car(2, 2);
            Car Player4 = new Car(3, 3);
            playerList.Add(Player1);
            playerList.Add(Player2);
            playerList.Add(Player3);
            playerList.Add(Player4);
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown2);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown3);
        }
        void button5_Click(Object sender, EventArgs e)
        {
            Invalidate();
            winnerLabel.Visible = false;
            buttonClicked = true;
            textBox1.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            if (playerList.Count == 1)
            {
                playerList.Clear();
                buttonClicked = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                Car Player1 = new Car(1, 0);
                playerList.Add(Player1);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                /*
                playerList[0].reset();
                 * */

            }
            else if (playerList.Count == 2)
            {
                playerList.Clear();
                buttonClicked = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                Car Player1 = new Car(0, 0);
                Car Player2 = new Car(2, 1);
                playerList.Add(Player1);
                playerList.Add(Player2);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                /*
                playerList[0].reset();
                playerList[1].reset();
                 * */
            }
            else if (playerList.Count == 3)
            {
                playerList.Clear();
                buttonClicked = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                Car Player1 = new Car(0, 0);
                Car Player2 = new Car(1, 1);
                Car Player3 = new Car(2, 2);
                playerList.Add(Player1);
                playerList.Add(Player2);
                playerList.Add(Player3);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                /*
                playerList[0].reset();
                playerList[1].reset();
                playerList[2].reset();
                 * */

            }
            else
            {
                playerList.Clear();
                buttonClicked = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                Car Player1 = new Car(0, 0);
                Car Player2 = new Car(1, 1);
                Car Player3 = new Car(2, 2);
                Car Player4 = new Car(3, 3);
                playerList.Add(Player1);
                playerList.Add(Player2);
                playerList.Add(Player3);
                playerList.Add(Player4);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                /*
                playerList[0].reset();
                playerList[1].reset();
                playerList[2].reset();
                playerList[3].reset();
                 * */
            }


        }
        void button6_Click(Object sender, EventArgs e)
        {
            Invalidate();
            playerList.Clear();
            buttonClicked = false;
            winnerLabel.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

         
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            base.OnPaint(e);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 0, 0, 1200, 0);
            e.Graphics.DrawLine(pen, 0, 0, 0, 700);
            e.Graphics.DrawLine(pen, 1200, 0, 1200, 700);
            e.Graphics.DrawLine(pen, 0, 700, 1200, 700);
            if (!this.DesignMode)
            {
                Graphics g = e.Graphics;
                foreach (Car Player in playerList)
                {
                    Player.Draw(g);
                }

            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (buttonClicked)
            {
                buttonClicked = false;
                gameTimer_Start();
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (playerList[0].Direction != Car.Directions.Right)
                        playerList[0].Direction = Car.Directions.Left;
                    break;
                case Keys.Right:
                    if (playerList[0].Direction != Car.Directions.Left)
                        playerList[0].Direction = Car.Directions.Right;
                    break;
                case Keys.Up:
                    if (playerList[0].Direction != Car.Directions.Down)
                        playerList[0].Direction = Car.Directions.Up;
                    break;
                case Keys.Down:
                    if (playerList[0].Direction != Car.Directions.Up)
                        playerList[0].Direction = Car.Directions.Down;
                    break; 
                case Keys.Space:


                 
                    break;
            }
        }
        private void Form1_KeyDown1(object sender, KeyEventArgs e)
        {
            if (buttonClicked)
            {
                buttonClicked = false;
                gameTimer_Start();
            }
            if (playerList.Count >= 2)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (playerList[1].Direction != Car.Directions.Right)
                            playerList[1].Direction = Car.Directions.Left;
                        break;
                    case Keys.D:
                        if (playerList[1].Direction != Car.Directions.Left)
                            playerList[1].Direction = Car.Directions.Right;
                        break;
                    case Keys.W:
                        if (playerList[1].Direction != Car.Directions.Down)
                            playerList[1].Direction = Car.Directions.Up;
                        break;
                    case Keys.S:
                        if (playerList[1].Direction != Car.Directions.Up)
                            playerList[1].Direction = Car.Directions.Down;
                        break;
                }
            }
        }
        private void Form1_KeyDown2(object sender, KeyEventArgs e)
        {
            if (buttonClicked)
            {
                buttonClicked = false;
                gameTimer_Start();
            }
            if(playerList.Count >= 3){
                switch (e.KeyCode)
                {
                    case Keys.F:
                        if (playerList[2].Direction != Car.Directions.Right)
                            playerList[2].Direction = Car.Directions.Left;
                        break;
                    case Keys.H:
                        if (playerList[2].Direction != Car.Directions.Left)
                            playerList[2].Direction = Car.Directions.Right;
                        break;
                    case Keys.T:
                        if (playerList[2].Direction != Car.Directions.Down)
                            playerList[2].Direction = Car.Directions.Up;
                        break;
                    case Keys.G:
                        if (playerList[2].Direction != Car.Directions.Up)
                            playerList[2].Direction = Car.Directions.Down;
                        break;
                }
            }
        }
        private void Form1_KeyDown3(object sender, KeyEventArgs e)
        {
            if (buttonClicked)
            {
                buttonClicked = false;
                gameTimer_Start();
            }
            if (playerList.Count == 4)
            {

                switch (e.KeyCode)
                {
                    case Keys.J:
                        if (playerList[3].Direction != Car.Directions.Right)
                            playerList[3].Direction = Car.Directions.Left;
                        break;
                    case Keys.L:
                        if (playerList[3].Direction != Car.Directions.Left)
                            playerList[3].Direction = Car.Directions.Right;
                        break;
                    case Keys.I:
                        if (playerList[3].Direction != Car.Directions.Down)
                            playerList[3].Direction = Car.Directions.Up;
                        break;
                    case Keys.K:
                        if (playerList[3].Direction != Car.Directions.Up)
                            playerList[3].Direction = Car.Directions.Down;
                        break;
                }
            }
        }

        private void collide()
        {
  
            if(playerList.Count == 2){
                int index = 1;
                foreach (Car Player in playerList){
                    CarBody head = Player.Body[0];
                    bool crash = false;
                    for (int i = 1; i < playerList[index].Body.Count; i++)
                    {
                        crash = head.recBody.IntersectsWith(playerList[index].Body[i].recBody);
                        if (crash)
                            Player.setDead(true);
     

                    }
                    index--;
                }
            }
            if (playerList.Count == 3)
            {
                int index1 = 1;
                int index2 = 2;
                foreach (Car Player in playerList)
                {
                    CarBody head = Player.Body[0];
                    bool crash = false;
                    for (int i = 1; i < playerList[index1].Body.Count; i++)
                    {

                        crash = head.recBody.IntersectsWith(playerList[index1].Body[i].recBody);
                        if (crash)
                            Player.setDead(true);
                    }
                    for (int i = 1; i < playerList[index2].Body.Count; i++)
                    {
                        crash = head.recBody.IntersectsWith(playerList[index2].Body[i].recBody);
 
                        if (crash)
                            Player.setDead(true);

                     }

                     if (index1 == 0)
                     {
                         index2--;
                     }
                        if (index1 > 0)
                        {
                            index1--;
                        }
                 }
            }
            if (playerList.Count == 4)
                {
                    int index1 = 1;
                    int index2 = 2;
                    int index3 = 3;
                    foreach (Car Player in playerList)
                    {
                        CarBody head = Player.Body[0];
                        bool crash = false;

                        for (int i = 1; i < playerList[index1].Body.Count; i++)
                        {
                            crash = head.recBody.IntersectsWith(playerList[index1].Body[i].recBody);
                            if (crash)
                                Player.setDead(true);

                        }
                        for (int i = 1; i < playerList[index2].Body.Count; i++)
                        {
                            crash = head.recBody.IntersectsWith(playerList[index2].Body[i].recBody);
                        
                            if (crash)
                                Player.setDead(true);
                        }
                        for (int i = 1; i < playerList[index3].Body.Count; i++)
                        {
                            crash = head.recBody.IntersectsWith(playerList[index3].Body[i].recBody);
                            if (crash)
                                Player.setDead(true);
                        
                        }          
                        if (index2 == 1)
                        {
                            index3--;
                        }
                        if (index1 == 0)
                        {
                            index2--;
                        }
                        if (index1 > 0)
                        {
                            index1--;
                        }
                    }
             }
        }
        private void gameTimer_Tick(object sender)
        {
            // The game loop
            if(playerList.Count == 1)
            {
                playerList[0].Update();
                playerList[0].AddEnd();
                playerList[0].HitSelf();
                playerList[0].crashBoundary();
                if (playerList[0].isDead())
                {
                    gameTimer.Dispose();
                    if (textBox1.InvokeRequired)
                    {
                        winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "You Crashed!"; }));
                    }
                    if (winnerLabel.InvokeRequired)
                    {
                        winnerLabel.Invoke(new MethodInvoker(delegate { winnerLabel.Text = "Game Over!"; }));
                    }
                    gameOver();
                }
            }
            else if (playerList.Count == 2)
            {
                if (!playerList[0].isDead())
                {
                    playerList[0].Update();
                    playerList[0].AddEnd();
                    playerList[0].HitSelf();
                    playerList[0].crashBoundary();

                }
                if (!playerList[1].isDead())
                {
                    playerList[1].Update();
                    playerList[1].AddEnd();
                    playerList[1].HitSelf();
                    playerList[1].crashBoundary();

                }
                collide();
                if (playerList[0].isDead() && playerList[1].isDead())
                {
                    gameTimer.Dispose();
                    if (textBox1.InvokeRequired)
                    {
                        winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Everyone lose."; }));
                    }
                    gameOver();
                }
                else if (playerList[0].isDead() || playerList[1].isDead())
                {
                    gameTimer.Dispose();
                    if (!playerList[0].isDead())
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 1 Wins!"; }));
                        }
                    }
                    else
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 2 Wins!"; }));
                        }
                    }
                    gameOver();
                }
            }
            if (playerList.Count == 3)
            {
                if (!playerList[0].isDead())
                {
                    playerList[0].Update();
                    playerList[0].AddEnd();
                    playerList[0].HitSelf();
                    playerList[0].crashBoundary();
                }
                if (!playerList[1].isDead())
                {
                    playerList[1].Update();
                    playerList[1].AddEnd();
                    playerList[1].HitSelf();
                    playerList[1].crashBoundary();
                }
                if (!playerList[2].isDead())
                {
                    playerList[2].Update();
                    playerList[2].AddEnd();
                    playerList[2].HitSelf();
                    playerList[2].crashBoundary();
                }
                collide();
                if (playerList[0].isDead() && playerList[1].isDead() && playerList[2].isDead())
                {
                    gameTimer.Dispose();
                    if (textBox1.InvokeRequired)
                    {
                        winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Everyone lose."; }));
                    }
                    gameOver();
                }
                else if ((playerList[0].isDead() && playerList[1].isDead())
                || (playerList[0].isDead() && playerList[2].isDead() )
                || (playerList[1].isDead() && playerList[2].isDead() ))
                {
                    gameTimer.Dispose();
                    if (!playerList[0].isDead())
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 1 Wins!"; }));
                        }
                    }
                    else if (!playerList[1].isDead())
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 2 Wins!"; }));
                        }
                    }
                    else
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 3 Wins!"; }));
                        }
                    }
                    gameOver();
                }
            }
            if (playerList.Count == 4)
            {
                if (!playerList[0].isDead())
                {
                    playerList[0].Update();
                    playerList[0].AddEnd();
                    playerList[0].HitSelf();
                    playerList[0].crashBoundary();
                }
                if (!playerList[1].isDead())
                {
                    playerList[1].Update();
                    playerList[1].AddEnd();
                    playerList[1].HitSelf();
                    playerList[1].crashBoundary();
                }
                if (!playerList[2].isDead())
                {
                    playerList[2].Update();
                    playerList[2].AddEnd();
                    playerList[2].HitSelf();
                    playerList[2].crashBoundary();
                }
                if (!playerList[3].isDead())
                {
                    playerList[3].Update();
                    playerList[3].AddEnd();
                    playerList[3].HitSelf();
                    playerList[3].crashBoundary();
                }
                collide();
                if (playerList[0].isDead() && playerList[1].isDead() && playerList[2].isDead() && playerList[3].isDead())
                {
                    gameTimer.Dispose();
                    if (textBox1.InvokeRequired)
                    {
                        winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Everyone lose."; }));
                    }
                    gameOver();
                }
                else if ((playerList[0].isDead() && playerList[1].isDead() && playerList[2].isDead())
                    || (playerList[0].isDead() && playerList[1].isDead() && playerList[3].isDead())
                    || (playerList[0].isDead() && playerList[2].isDead() && playerList[3].isDead())
                    || (playerList[1].isDead() && playerList[2].isDead() && playerList[3].isDead()))
                {
                    //gameTimer.
                    gameTimer.Dispose();
                    if (!playerList[0].isDead())
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 1 Wins!"; }));
                        }
                    }
                    else if (!playerList[1].isDead())
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 2 Wins!"; }));
                        }
                    }
                    else if (!playerList[2].isDead())
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 3 Wins!"; }));
                        }
                    }
                    else
                    {
                        if (textBox1.InvokeRequired)
                        {
                            winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.Text = "Player 4 Wins!"; }));
                        }
                    }
                    gameOver();

                }
            }
        }
        /// <summary>
        /// This is called when the timer fires.
        /// </summary>
        /// <param name="o"></param>
        protected void TimerCB(object o)
        {

            //Move the rectangle
            gameTimer_Tick(o);

            //Redraw the form
            Invalidate();
        }
        public void gameOver()
        {
            if (winnerLabel.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate { winnerLabel.Visible = true; }));
            }
            if (button5.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate { button5.Visible = true; }));
            }
            if (button5.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate { button5.BringToFront(); }));
            }
            if (button6.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate { button6.Visible = true; }));
            }
            if (button6.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate { button6.BringToFront(); }));
            }
            if (textBox1.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate {textBox1.Visible = true; }));
            }
            if (textBox1.InvokeRequired)
            {
                winnerLabel.Invoke(new MethodInvoker(delegate { textBox1.BringToFront(); }));
            }
            /*
            winnerLabel.Visible = true;
            button5.Visible = true;
            button5.BringToFront();
            button6.Visible = true;
            button6.BringToFront();
            textBox1.Visible = true;
            textBox1.BringToFront();
            */
        }
    }
}
