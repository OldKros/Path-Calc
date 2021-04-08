using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Path_Calculator
{
    public partial class Form1 : Form
    {
        List<Vec2> waypoints = new List<Vec2>();

        public Form1()
        {
            InitializeComponent();
        }

        // This function runs when the calculate button is clicked
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // simple lambda that shows the exception message ex
            Action<Exception> showExceptionMessage = (ex) =>
            { MessageBox.Show(ex.Message); };

            int enemyCount = 0;
            double enemyMoveSpeed = 0d;
            double timeBetweenSpawns = 0d;
            double timeBetweenSpawnsRandom = 0d;
            double loopDelay = 0d;
            int loopCounter= 0;
            double initDelay = 0d;
            bool needAllDestroyed = NeedAllDestroyedCheckbox.Checked;
            if (needAllDestroyed)
                loopCounter = 200;

            // Make sure all our data is valid
            try
            {
                enemyCount = Convert.ToInt32(EnemyCountTextBox.Text);
                enemyMoveSpeed = Convert.ToDouble(EnemyMoveSpeedTextBox.Text);
                timeBetweenSpawns = Convert.ToDouble(TimeBetweenSpawnsTextBox.Text);
                timeBetweenSpawnsRandom  = Convert.ToDouble(SpawnTimeRandomTextBox.Text);
                loopDelay = Convert.ToDouble(LoopDelayTextBox.Text);
                if (!needAllDestroyed)
                    loopCounter = Convert.ToInt32(LoopCountTextBox.Text);
                initDelay = Convert.ToDouble(InitialDelayTextBox.Text);
            }
            catch (Exception ex) { showExceptionMessage(ex); }

            // Start the Calculation
            Random random = new Random();
            double differenceFirstToLast = 0d;
            // we calculate the time difference between the first enemy and the last enemy
            for (int i = 0; i < enemyCount; i++)
            {
                differenceFirstToLast += (timeBetweenSpawns + (random.NextDouble() * timeBetweenSpawnsRandom));
            }

            double timeForOneEnemy = CalcOneEnemy(enemyMoveSpeed);

            string loopText = "";
            double loopBeginTimer = initDelay;
            double loopEndTimer;

            for (int i=0; i<=loopCounter; i++)
            {
                loopEndTimer = loopBeginTimer + timeForOneEnemy + differenceFirstToLast;

                loopText += $"Wave Loop {i}: " +
                            $"starts: {(int)loopBeginTimer/60:0}m {(int)loopBeginTimer%60:00}s, " +
                            $"finishes: {(int)loopEndTimer/60}m {(int)loopEndTimer%60:00}s" + Environment.NewLine;

                loopBeginTimer = loopEndTimer + loopDelay;
            }

            ResultTextBox.Text = $"Time one enemy is on screen: {timeForOneEnemy:0.0}s," +
                Environment.NewLine +
                $"Average difference between first and last: {differenceFirstToLast:0.0}s," +
                Environment.NewLine + loopText;
        }

        // Calculate the time it takes a single enemy to traverse the route
        private double CalcOneEnemy(double moveSpeed)
        {
            double time = 0d;
            double distanceBetweenCurAndNext = 0d;

            double xLength = 0d;
            double yLength = 0d;
            Vec2 cur;

            for (int i = 0; i < waypoints.Count-1; i++)
            {
                cur = waypoints[i];
                xLength = cur.X - waypoints[i+1].X;
                yLength = cur.Y - waypoints[i+1].Y;
                // c² = a² + b² or c = sqrt(a+b)
                distanceBetweenCurAndNext = Math.Sqrt((xLength * xLength) + (yLength * yLength));
                time += distanceBetweenCurAndNext / moveSpeed;
            }
            return time;
        }

        // This function is called when the AddToList button is clicked
        // It checks whether the item is correctly formatted and appends it
        // to the working list and then clears the text box
        private void AddToListButton_Click(object sender, EventArgs e)
        {
            string position = "";
            string[] xAndY = new string[2];
            WaypointsListBox.DataSource = waypoints;
            try
            {
                position = WaypointXYTextbox.Text;
                if (position == "")
                {
                    throw new FormatException();
                }
                xAndY = position.Split(',');
                double x = Convert.ToDouble(xAndY[0]);
                double y = Convert.ToDouble(xAndY[1]);
                waypoints.Add(new Vec2(x, y));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter two numbers seperated by a comma");
            }
            catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("Enter two numbers seperated by a comma");
            }

            WaypointXYTextbox.Clear();
        }

        // This function is run when the remove selected item button is clicked
        // it simply removes the item from the list if it is valid.
        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            if (WaypointsListBox.SelectedItem != null)
                waypoints.Remove(waypoints[WaypointsListBox.SelectedIndex]);
        }

        private void EmptyListButton_Click(object sender, EventArgs e)
        { waypoints.Clear(); }

        private void NeedAllDestroyedCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (NeedAllDestroyedCheckbox.Checked)
            {
                LoopCountTextBox.Enabled = false;
            }
            else
            {
                LoopCountTextBox.Enabled = true;
            }
        }
    }

    // Data structure to contain the X and Y coordinates and correctly format them on print
    class Vec2
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vec2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
