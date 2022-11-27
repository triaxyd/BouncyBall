using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p21120ball
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int x, y;
        public Form2()
        {
            x = rnd.Next(-10, 10);
            y = rnd.Next(-10, 10);

            InitializeComponent();
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            GraphicsPath shape = new GraphicsPath();
            shape.AddEllipse(0, 0, 150, 150);
            this.Region = new Region(shape);
        }

           

        private void Form2_Load(object sender, EventArgs e)
        {
            while ((x > -5 && x < 5) || (y >-5 && y < 5))
            {
                x = rnd.Next(-10, 10);
                y = rnd.Next(-10, 10);
            }
            this.SetDesktopLocation(rnd.Next(Screen.PrimaryScreen.Bounds.Left + this.Width, Screen.PrimaryScreen.Bounds.Right - this.Width),
                rnd.Next(Screen.PrimaryScreen.Bounds.Top + this.Height , Screen.PrimaryScreen.Bounds.Bottom - this.Height));
            //this.SetDesktopLocation(rnd.Next(Screen.PrimaryScreen.Bounds.Width - this.Width), rnd.Next(Screen.PrimaryScreen.Bounds.Height - this.Height));
            timer1.Start();
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            changeLocation();

        }
        private void changeLocation()
        {
            this.Location = new Point(this.Location.X + x, this.Location.Y + y);
            if (this.Location.X < 0 || this.Location.X + this.Width > Screen.PrimaryScreen.Bounds.Width)
            {
                x = -x;
            }
            if (this.Location.Y < 0 || this.Location.Y + this.Height > Screen.PrimaryScreen.Bounds.Height)
            {
                y = -y;
            }
        }

    }
}






           
            
  
