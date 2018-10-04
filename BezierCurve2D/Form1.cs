using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierCurve2D
{
    //2-D Cubic Bezier Curve program developed by Adeel Ahmed, BSCS-VI, Sec A (Evening)
    //For the class of 'Computer Graphics', taught by Prof. Muhammad Saeed


    public partial class Form1 : Form
    {
        //X and Y will bring origin to centre of the window. animSpeed determines how fast curve is drawn
        float X, Y, animSpeed;

        //Reference to the control points
        float x1, x2, x3, x4;
        float y1, y2, y3, y4;

        //For Keeping Track of Animation Slider's Previous Value
        int sliderPreviousValue;

        public Form1()
        {
            InitializeComponent();


            X = this.ClientSize.Width / 2;
            Y = this.ClientSize.Height / 2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Keep animationSpeed fast by default, because people are generally impatient by nature. Haha!
            animSpeed = 0.001F;

            //Keep Track of Slider's Initial Value
            sliderPreviousValue = trackBarAnimSpeed.Value;

            //Set the control points to default initially
            DefaultCoordinates();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw XY-axes lines 
            Pen pen = new Pen(Color.LightBlue);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            e.Graphics.DrawLine(pen, 0, Y, this.ClientSize.Width, Y);
            e.Graphics.DrawLine(pen, X, 0, X, this.ClientSize.Height);

            pen.Dispose();
        }

        private void buttonDrawCurve_Click(object sender, EventArgs e)
        {
            //Set initial value of t to 0.01 for calculating first point B1(x,y)
            float t = 0.001F;
            
            //Instead of repeating same calculation, just calculate once and store in a variable for reuse
            float a = 1 - t;

            Graphics g = this.CreateGraphics();
            Pen CurvePen = new Pen(Color.DarkBlue);

            //Initially calculate B1(x,y)
            float bx1 = Convert.ToSingle(Math.Pow(a, 3) * x1 + 3 * Math.Pow(a, 2) * t * x2 + 3 * a * Math.Pow(t, 2) * x3 + Math.Pow(t,3) * x4);
            float by1 = Convert.ToSingle(Math.Pow(a, 3) * y1 + 3 * Math.Pow(a, 2) * t * y2 + 3 * a * Math.Pow(t, 2) * y3 + Math.Pow(t, 3) * y4);

            //animSpeed controls the level of incremention, which translates to how slow or fast curve is drawn
            for (t = 0.002F; t <= 1.0F; t += animSpeed)
            {
                a = 1 - t;

                //Calucate B2(x,y)
                float bx2 = Convert.ToSingle(Math.Pow(a, 3) * x1 + 3 * Math.Pow(a, 2) * t * x2 + 3 * a * Math.Pow(t, 2) * x3 + Math.Pow(t, 3) * x4);
                float by2 = Convert.ToSingle(Math.Pow(a, 3) * y1 + 3 * Math.Pow(a, 2) * t * y2 + 3 * a * Math.Pow(t, 2) * y3 + Math.Pow(t, 3) * y4);

                //Draw a very small line from B1(x,y) to B2(x,y)
                g.DrawLine(CurvePen, X + bx1, Y - by1, X + bx2, Y - by2);
                
                //Store this newly calculated B2(x,y) into B1(x,y) --- we need to start drawing line from where we left
                bx1 = bx2;
                by1 = by2;
            }

            CurvePen.Dispose();
        }

        private void buttonEraseCurve_Click(object sender, EventArgs e)
        {
            //This function merely erases the curves, but retains the value of control points, if changed
            this.Invalidate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //This function not only clears the curve(s), but also resets the control points to their default
            this.Invalidate();
            DefaultCoordinates();
        }

        private void trackBarAnimSpeed_Scroll(object sender, EventArgs e)
        {
            //If there's a decrease from the slider's previous value, this means animation should be slowed down.
            //Else, if there's an increase from slider's previous value, speed up animation.
            if (trackBarAnimSpeed.Value < sliderPreviousValue) animSpeed /= 10;
            else animSpeed *= 10;

            //Keep track of the newly changed value of slider.
            sliderPreviousValue = trackBarAnimSpeed.Value;
        }

        private void DefaultCoordinates()
        {
            //Default Control Points to draw a curve with
            
            //As defined currently, the points will draw a sine wave
            x1 = -260.0F;
            numericUpDownX1.Value = Convert.ToDecimal(x1);

            x2 = 0.0F;
            numericUpDownX2.Value = Convert.ToDecimal(x2);

            x3 = 0.0F;
            numericUpDownX3.Value = Convert.ToDecimal(x3);

            x4 = 260.0F;
            numericUpDownX4.Value = Convert.ToDecimal(x4);

            y1 = 0.0F;
            numericUpDownY1.Value = Convert.ToDecimal(y1);

            y2 = 350.0F;
            numericUpDownY2.Value = Convert.ToDecimal(y2);

            y3 = -350.0F;
            numericUpDownY3.Value = Convert.ToDecimal(y3);

            y4 = 0.0F;
            numericUpDownY4.Value = Convert.ToDecimal(y4);
        }

        #region Coordinates NumericUpDown Values Changes

        //Below functions all assign the changed values of the numericUpDowns to their respective variables

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            x1 = Convert.ToSingle(numericUpDownX1.Value);
        }

        private void numericUpDownX2_ValueChanged(object sender, EventArgs e)
        {
            x2 = Convert.ToSingle(numericUpDownX2.Value);
        }

        private void numericUpDownX3_ValueChanged(object sender, EventArgs e)
        {
            x3 = Convert.ToSingle(numericUpDownX3.Value);
        }


        private void numericUpDownX4_ValueChanged(object sender, EventArgs e)
        {
            x4 = Convert.ToSingle(numericUpDownX4.Value);
        }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            y1 = Convert.ToSingle(numericUpDownY1.Value);
        }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            y2 = Convert.ToSingle(numericUpDownY2.Value);
        }

        private void numericUpDownY3_ValueChanged(object sender, EventArgs e)
        {
            y3 = Convert.ToSingle(numericUpDownY3.Value);
        }

        private void numericUpDownY4_ValueChanged(object sender, EventArgs e)
        {
            y4 = Convert.ToSingle(numericUpDownY4.Value);
        }
        #endregion
    }
}
