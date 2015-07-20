using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Space_Cruiser
{
    public partial class Space : UserControl
    {

        public Space()
        {
            InitializeComponent();
        }


        private Random _rnd = new Random();			// Our handy dandy random number generator.
        private Star[,] _stars;						// Star positions and layers.
        private Timer PaintTimer = new Timer();
 


        /// <summary>
        /// Function to draw a layer of stars.
        /// </summary>
        /// <param name="layer">Layer to draw.</param>
        /// <param name="deltaTime">Frame delta.</param>
        private void DrawStars(int layer, float deltaTime, Graphics gfx)
        {

            // Draw the stars.
            for (int i = 0; i < _stars.Length / 4; i++)
            {
                gfx.DrawLine(_stars[i, layer].Magnitude, _stars[i, layer].Position.X, _stars[i, layer].Position.Y, _stars[i, layer].Position.X + 1.0f, _stars[i, layer].Position.Y + 1.0f);


                // Move the stars down.
                _stars[i, layer].Position.Y += _stars[i, layer].VDelta * deltaTime;

                // Wrap around.
                if (_stars[i, layer].Position.Y > this.Height)
                    _stars[i, layer].Position = new Vector2D((float)(_rnd.NextDouble() * this.Width), 0);
            }


        }

        private void Space_Load(object sender, EventArgs e)
        {

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserMouse | ControlStyles.UserPaint, true);

            // Create stars.
            _stars = new Star[64, 4];

            // Create the star.
            for (int layer = 0; layer < 4; layer++)
            {
                for (int i = 0; i < _stars.Length / 4; i++)
                {
                    _stars[i, layer].Position = new Vector2D((float)(_rnd.NextDouble() * this.Width), (float)(_rnd.NextDouble() * this.Height));

                    // Select magnitude. 3 > 2 > 1 > 0
                    switch (layer)
                    {
                        case 3:
                            _stars[i, layer].Magnitude = new Pen(System.Drawing.Color.FromArgb(255, 255, 255), 2.0f);
                            _stars[i, layer].VDelta = (float)(_rnd.NextDouble() * 100.0) + 55.0f;
                            break;
                        case 2:
                            _stars[i, layer].Magnitude = new Pen(System.Drawing.Color.FromArgb(192, 192, 192), 1.0f);
                            _stars[i, layer].VDelta = (float)(_rnd.NextDouble() * 50.0) + 27.5f;
                            break;
                        case 1:
                            _stars[i, layer].Magnitude = new Pen(System.Drawing.Color.FromArgb(128, 128, 128), 0.5f);
                            _stars[i, layer].VDelta = (float)(_rnd.NextDouble() * 25.0) + 13.5f;
                            break;
                        default://0
                            _stars[i, layer].Magnitude = new Pen(System.Drawing.Color.FromArgb(64, 64, 64), 0.25f);
                            _stars[i, layer].VDelta = (float)(_rnd.NextDouble() * 12.5) + 1.0f;
                            break;
                    }
                }
            }

            PaintTimer.Interval = 33;//30 FPS

            PaintTimer.Tick += new EventHandler(PaintTimer_Tick);

            PaintTimer.Enabled = true;

        }

        void PaintTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Space_Paint(object sender, PaintEventArgs e)
        {

            if (!PaintTimer.Enabled || this.DesignMode)
            {
                return;
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            // Draw stars.
            DrawStars(0, 0.01f, e.Graphics);

            // Draw stars.
            DrawStars(1, 0.02f, e.Graphics);

            // Draw stars.
            DrawStars(2, 0.03f, e.Graphics);

            // Draw stars.
            DrawStars(3, 0.02f, e.Graphics);

        }

    }
}