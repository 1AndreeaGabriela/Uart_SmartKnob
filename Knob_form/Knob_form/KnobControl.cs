using System.Drawing.Drawing2D;
using static Knob_form.Form1;

namespace Knob_form
{
    public class KnobControl: Control
    {
        private byte direction;

        private float indicatorAngle; 
        private int percentFilled = 0;

        /* Indicator offset from the knob perimeter*/
        private float offset = 10;

        public Color GradientStartColor { get; set; } = Color.Pink;
        public Color GradientEndColor { get; set; } = Color.Coral;
        public Color IndicatorColor { get; set; } = Color.Red;

        public float Limit1Angle { get; set; } = 0;  // Default angle for limit 1
        public float Limit2Angle { get; set; } = 90; // Default angle for limit 2

        public float OnOffAngle { get; set; } = 0; // Default angle, adjust as needed

        private Point AngleToPoint(float angle, int radius , int offset = 0)
        {
            double angleRad = (Math.PI / 180.0) * (angle - 90); // Adjusting by -90 degrees to align 0 with the top
            int x = (int)((radius - offset) * Math.Cos(angleRad)) + Width / 2;
            int y = (int)((radius - offset) * Math.Sin(angleRad)) + Height / 2;
            return new Point(x, y);
        }

        public enum Mode
        {
            Endless,
            OnOff,
            TwoLimits,
            ReturnToCenter
        }

        private Mode currentMode;
        public KnobControl()
        {
            this.DoubleBuffered = true;
            this.Resize += OnResize;
            SetInitialSize(); 
        }
        public void SetMode(Mode mode)
        {
            currentMode = mode;
            if (mode == Mode.OnOff)
            {
                OnOffAngle = 0; // Set to the desired angle or retrieve from a configuration
            }
            Invalidate();  // Redraw the control with the new mode settings
        }

      

        public int PercentFilled
        {
            get { return percentFilled; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    percentFilled = value;
                    Invalidate(); 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("PercentFilled must be between 0 and 100.");
                }
            }
        }

        public float IndicatorAngle
        {
            get { return indicatorAngle; }
            set
            {
                if (value >= 0 && value < 360)
                {
                    indicatorAngle = value;
                    Invalidate(); 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("SmallCircleAngle must be between 0 and 360 degrees.");
                }
            }
        }


        private void OnResize(object sender, EventArgs e)
        {
            AdjustControlSize();
        }

        private void SetInitialSize()
        {
            int IndicatorRadius = 10;
            int diameter = IndicatorRadius * 2 + (int)offset * 2;
            this.Size = new Size(diameter, diameter);
        }

        private void AdjustControlSize()
        {
            int IndicatorRadius = 10;
            int diameter = IndicatorRadius * 2 + (int)offset * 2;
 
            if (this.Width < diameter || this.Height < diameter)
            {
                this.SuspendLayout();
                this.Size = new Size(diameter + 20, diameter + 20);
                this.ResumeLayout(); 
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = Math.Min(ClientSize.Width - 70, ClientSize.Height - 70);
            int radius = diameter / 2;

            /* Define the bounding rectangle for the circle */
            Rectangle rect = new Rectangle(ClientSize.Width / 2 - radius, ClientSize.Height / 2 - radius, diameter, diameter);

            /* Calculate the height of the filled portion based on the percentage */
            int fillHeight = (int)(diameter * percentFilled / 100.0);
            if (fillHeight == 0 && percentFilled > 0) fillHeight = 1;

           // Define the filled rectangle starting from the bottom of the circle
           Rectangle fillRect = new Rectangle(ClientSize.Width / 2 - radius, ClientSize.Height / 2 + radius - fillHeight, diameter, fillHeight);


            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(rect);
            g.SetClip(circlePath);

           // Create a gradient brush for the fill

             //Apelează funcția pentru a desena partea umplută 
            DrawFilledPart(g, rect, fillHeight);

            g.ResetClip();

                /*Draw the circle outline with a gradient effect*/
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawEllipse(pen, rect);
            }

            DrawInnerShadow(g, rect);
            DrawIndicator(g, radius, rect);
        }
        private void DrawFilledPart(Graphics g, Rectangle rect, int fillHeight)
        {
            /* Early return if fillHeight is zero or negative*/
            if (fillHeight <= 0)
            {
                return;
            }

            Rectangle fillRect = new Rectangle(rect.X, rect.Bottom - fillHeight, rect.Width, fillHeight);

            switch (currentMode)
            {
                case Mode.Endless:
                    /*if (fillHeight > 0)
                    {
                        using (LinearGradientBrush brush = new LinearGradientBrush(fillRect, GradientStartColor, GradientEndColor, LinearGradientMode.Vertical))
                        {
                            g.FillRectangle(brush, fillRect);
                        }
                    }*/


                    break;
                case Mode.OnOff:

                    int radius1 = Math.Min(Width, Height) / 2 - 10;  // Calculate the radius
                    Point center1 = new Point(Width / 2, Height / 2);

                    // Determine if we should draw the "ON/OFF" line
                    if (currentMode == Mode.OnOff)
                    {
                        // Calculate the start and end points for the "ON/OFF" line
                        Point onOffStart = AngleToPoint(OnOffAngle, radius1, 50);  // Start point with an offset
                        Point onOffEnd = AngleToPoint(OnOffAngle, radius1);        // End point on the perimeter

                        using (Pen onOffPen = new Pen(Color.OrangeRed, 4)) // Use a blue pen of width 3 for "ON/OFF"
                        {
                            g.DrawLine(onOffPen, onOffStart, onOffEnd);
                        }
                    }

                   /* if (fillHeight > 0)
                    {
                        using (LinearGradientBrush brush = new LinearGradientBrush(fillRect, Color.AliceBlue, Color.Aqua, LinearGradientMode.Vertical))
                        {
                            g.FillRectangle(brush, fillRect);
                        }
                    }*/

                    break;

                case Mode.TwoLimits:

                    // Calculate the center and radius
                    int radius = Math.Min(Width, Height) / 2 - 10;  // Subtract to fit within bounds
                    Point center = new Point(Width / 2 , Height / 2 );

                    // Get points for limits
                    Point limit1Start = AngleToPoint(Limit1Angle, radius , 50);
                    Point limit2Start = AngleToPoint(Limit2Angle, radius , 50);

                    Point limit1End = AngleToPoint(Limit1Angle, radius);
                    Point limit2End = AngleToPoint(Limit2Angle, radius);

                    // Draw limits
                    using (Pen limitPen = new Pen(Color.OrangeRed, 4)) // Use a red pen of width 3
                    {
                        g.DrawLine(limitPen, limit1Start, limit1End); // Draw line for limit 1
                        g.DrawLine(limitPen, limit2Start, limit2End); // Draw line for limit 2
                    }

                    break;
                case Mode.ReturnToCenter:

                    if (fillHeight > 0)
                    {
                        using (LinearGradientBrush brush = new LinearGradientBrush(fillRect, GradientStartColor, GradientEndColor, LinearGradientMode.Vertical))
                        {
                            g.FillRectangle(brush, fillRect);
                        }
                    }
                    break;
            }

        }

        private void DrawLimit(Graphics g, float angle, int radius, int lineLength)
        {
            // Calculate the main point on the perimeter
            Point centerPoint = AngleToPoint(angle, radius);

            // Calculate the offset points for the small line segment
            Point startPoint = AngleToPoint(angle - 0.5f, radius);  // Adjust the angle slightly for the start point
            Point endPoint = AngleToPoint(angle + 0.5f, radius);    // Adjust the angle slightly for the end point

            using (Pen limitPen = new Pen(Color.Red, 2))  // Change the color and thickness as needed
            {
                g.DrawLine(limitPen, startPoint, endPoint); // Draw the small line segment
            }
        }

        private void DrawIndicator(Graphics g, int radius, Rectangle rect)
        {
            int smallCircleRadius = 10; 
            float angle = indicatorAngle;


            if (direction == 0)
            {
                angle = indicatorAngle;
            }
            else
            {
                angle = indicatorAngle;
            }

            /*Convert the angle in radius*/
            float angleRadians = angle * (float)Math.PI / 180;

            float directionMultiplier =  -1f;

            
            float adjustedRadius = radius - smallCircleRadius - offset; 

            int smallCircleX = ClientSize.Width / 2 + (int)((adjustedRadius) * Math.Cos(angleRadians * directionMultiplier)) - smallCircleRadius;
            int smallCircleY = ClientSize.Height / 2 - (int)((adjustedRadius) * Math.Sin(angleRadians * directionMultiplier)) - smallCircleRadius;

            /* Draw indicator (small circle) */
            using (Brush brush = new SolidBrush(IndicatorColor))
            using (Pen pen = new Pen(Color.Black, 2)) 
            {

                g.FillEllipse(brush, smallCircleX, smallCircleY, smallCircleRadius * 2, smallCircleRadius * 2);
                g.DrawEllipse(pen, smallCircleX, smallCircleY, smallCircleRadius * 2, smallCircleRadius * 2);
            }
        }

        private void DrawInnerShadow(Graphics g, Rectangle rect)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.Transparent;
                    brush.SurroundColors = new Color[] { Color.FromArgb(100, Color.Black) };
                    brush.FocusScales = new PointF(0.8f, 0.8f);
                    g.FillPath(brush, path);
                }
            }
        }
    }
}

