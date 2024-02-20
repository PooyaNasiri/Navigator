using System;
using System.Windows.Forms;

namespace Navigator
{

    internal partial class Navigator : Form
    {
        internal const int Length = n;
        private static int startX, startY, z;
        private static State currnetState;
        private static Agenda agenda;
        private static System.Threading.Thread thread;
        private static System.Drawing.Color red = System.Drawing.Color.Red,
            green = System.Drawing.Color.Green;
        private static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

        internal Navigator() { InitializeComponent(); }
        private void App_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                {
                    State.isOk[i, j] = true;
                    buttons[i, j].BackColor = green;
                }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            char[] d1, d2, d3, d4;
            bool q1 = false, q2 = false, q3 = false, q4 = false, p = true;
            z = 0;
            label2.Text = "            Loading...";
            System.Threading.Tasks.Task.Delay(1).Wait();
            watch = System.Diagnostics.Stopwatch.StartNew();
            startX = int.Parse(Xtextbox.Text);
            startY = int.Parse(Ytextbox.Text);

            d1 = XtextboxEnd.Text.ToCharArray();
            d2 = YtextboxEnd.Text.ToCharArray();
            d3 = Xtextbox.Text.ToCharArray();
            d4 = Ytextbox.Text.ToCharArray();
            for (int i = 48; i < 48 + n; i++)
            {
                if (d1[0] == i)
                    q1 = true;
                if (d2[0] == i)
                    q2 = true;
                if (d3[0] == i)
                    q3 = true;
                if (d4[0] == i)
                    q4 = true;
            }
            
            label2.Text = "            " + ((!q1 || !q2) ? "end pos not Ok!" : "") + ((!q3 || !q4) ? "  start pos not Ok!" : "");

            if(q1 && q2 && q3 && q4)
            {
                if (!State.isOk[int.Parse(YtextboxEnd.Text), int.Parse(XtextboxEnd.Text)])
                {
                    label2.Text = "            end pos has to be accessible";
                    p = false;
                }
                if (!State.isOk[startY, startX])
                {
                    label2.Text = "            Start pos has to be accessible";
                    p = false;
                }
            }


            if (p && q1 && q2 && q3 && q4)
            {
                int[,] Cross = new int[Length + 5, Length + 5];
                for (int i = 0; i < Length; i++)
                    for (int j = 0; j < Length; j++)
                        Cross[i, j] = 0;
                currnetState = new State('.', "S", Cross, startX, startY, 5);
                agenda = new Agenda(currnetState);
                while (!GOAL(currnetState))
                {
                    int x = currnetState.getX(), y = currnetState.getY();
                    int[,] g = currnetState.getCross();
                    if (x < Length - 1 && (currnetState.getLastMove() != 1))
                        if (State.isOk[y, x + 1])
                            agenda.Add('R', currnetState.getWay(), g, x + 1, y, 0);

                    if (y < Length - 1 && (currnetState.getLastMove() != 2))
                        if (State.isOk[y + 1, x])
                            agenda.Add('D', currnetState.getWay(), g, x, y + 1, 3);

                    if (y >= 1 && (currnetState.getLastMove() != 3))
                        if (State.isOk[y - 1, x])
                            agenda.Add('U', currnetState.getWay(), g, x, y - 1, 2);

                    if (x >= 1 && (currnetState.getLastMove() != 0))
                        if (State.isOk[y, x - 1])
                            agenda.Add('L', currnetState.getWay(), g, x - 1, y, 1);

                    z++;
                    if (!agenda.Remove(ref currnetState)) { label2.Text = "            No way to Finish!!!\n" + z + " ways has been checked. in " + watch.ElapsedMilliseconds + "ms"; break; }
                }
            }

        }

        private bool GOAL(State currnetState)
        {
            int[,] cross = currnetState.getCross();
            if (z >= 2000000)
            {
                label2.Text = "            Out of RAM!!!\n" + z + " ways have been checked. in " + watch.ElapsedMilliseconds + "ms";
                return true;
            }
            if (currnetState.getWay().Length > (n*n))
            {
                label2.Text = "            No way to Finish!!!\n" + z + " ways have been checked. in " + watch.ElapsedMilliseconds + "ms";
                return true;
            }
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    if (currnetState.getX().ToString() != XtextboxEnd.Text || currnetState.getY().ToString() != YtextboxEnd.Text)
                        return false;

            watch.Stop();
            label2.Text = "            Ok\n" + z + " ways have been checked. in " + watch.ElapsedMilliseconds + "ms";
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(__Show));
            thread.Start();
            return true;
        }

        private void __Show()
        {
            char[] a = currnetState.getWay().ToCharArray();
            int x = startX, y = startY;
            for (int i = 2; i < a.Length; i++)
            {
                buttons[x, y].BackColor = System.Drawing.Color.FromArgb((255 * i) / a.Length, (255 * i) / a.Length, (255 * i) / a.Length);
                switch (a[i])
                {
                    case 'R': x++; break;
                    case 'D': y++; break;
                    case 'L': x--; break;
                    case 'U': y--; break;
                    default: break;
                }
                System.Threading.Tasks.Task.Delay(300).Wait();
            }
            buttons[x, y].BackColor = System.Drawing.Color.White;
        }
        
        private void Clear_Click(object sender, EventArgs e)
        {
            if (thread != null)
                if (thread.ThreadState != System.Threading.ThreadState.Stopped)
                    thread.Suspend();

            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                {
                    State.isOk[i, j] = true;
                    buttons[i, j].BackColor = green;
                }
            label2.Text = "            Ok";
            label1.Text = "...";
            Xtextbox.Text = "0";
            Ytextbox.Text = "0";
            XtextboxEnd.Text = "0";
            YtextboxEnd.Text = "0";

        }
        
        private void buttons_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Length; i++)
                for (int j = 0; j < Length; j++)
                    if (buttons[i, j].Capture)
                    {
                        buttons[i, j].BackColor = (buttons[i, j].BackColor == red) ? green : red;
                        State.isOk[j, i] = (State.isOk[j, i]) ? false : true;
                    }
        }
        
    }

    internal class State
    {
        internal State next;
        private char name;
        private const int length = Navigator.Length + 1;
        private string way;
        private int x, y, lastMove;
        private int[,] Cross;
        internal static bool[,] isOk = new bool[length, length];
        internal State(char name, string way, int[,] C, int x, int y, int lastMove)
        {
            this.lastMove = lastMove;
            Cross = new int[length, length];
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    Cross[i, j] = C[i, j];
            Cross[x, y]++;
            this.name = name;
            this.way = way + name;
            this.x = x;
            this.y = y;
        }
        internal string getWay()
        {
            return way;
        }
        internal int getLastMove()
        {
            return lastMove;
        }
        internal int getX()
        {
            return x;
        }
        internal int getY()
        {
            return y;
        }
        internal int[,] getCross()
        {
            return this.Cross;
        }
    }

    internal class Agenda
    {
        private State front, rear;
        internal Agenda(State currnetState)
        {
            front = currnetState;
            rear = currnetState;
            front.next = rear;
        }
        internal bool Add(char name, string way, int[,] Cross, int x, int y, int lastMove)
        {
            State s = new State(name, way, Cross, x, y, lastMove);
            rear.next = s;
            rear = s;
            return true;
        }
        internal bool Remove(ref State item)
        {
            if (front == null) return false;
            item = front;
            if (front == rear) rear = front = null;
            else front = front.next;
            return true;
        }
    }

}
