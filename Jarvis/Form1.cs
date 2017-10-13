using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis
{
	public partial class Form1 : Form
	{
		List<Point> points;

		public Form1()
		{
			InitializeComponent();
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			var g = Graphics.FromImage(pictureBox1.Image);
			g.Clear(Color.White);
			points = new List<Point>();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MouseEventArgs me = (MouseEventArgs)e;
			Point coordinates = me.Location;
			points.Add(coordinates);
			Brush br = new SolidBrush(Color.Black);
			Graphics g = Graphics.FromImage(pictureBox1.Image);
			g.FillRectangle(br, coordinates.X, coordinates.Y, 2, 2);
			pictureBox1.Refresh();
		}

		private void randomize_n(object sender, EventArgs e)
		{
			ToolStripMenuItem b = sender as ToolStripMenuItem;
			Random rnd = new Random();
			int w = pictureBox1.Width;
			int h = pictureBox1.Height;
			for (int i = 0; i < Int32.Parse(b.Text); i++)
			{
				int r_w = rnd.Next(0, w);
				int r_h = rnd.Next(0, h);
				Brush br = new SolidBrush(Color.Black);
				Graphics g = Graphics.FromImage(pictureBox1.Image);
				g.FillRectangle(br, r_w, r_h, 2, 2);
				points.Add(new Point(r_w, r_h));
			}
			pictureBox1.Refresh();
		}

		private void Jarvis(object sender, EventArgs e)
		{
			var sorted = points.OrderBy(po => po.X).ThenBy(po => po.Y);
			List<Point> hull = new List<Point>();
			hull.Add(sorted.ElementAt(0));
			Point current = sorted.ElementAt(0);
			//hull.Add(sorted.ElementAt(1));
			Point last = sorted.ElementAt(1);
			do
			{
				foreach (var p in sorted)
				{
					if (p == current || p == last)
						continue;
					int pos = (last.X - current.X) * (p.Y - current.Y) 
						- (last.Y - current.Y) * (p.X - current.X);
					if (pos < 0)
						last = p;
				}
				hull.Add(last);
			}
			while (current != hull.Last());
			Point cur = hull.First();
			Brush br = new SolidBrush(Color.Black);
			Pen pen = new Pen(br, 2);
			Graphics g = Graphics.FromImage(pictureBox1.Image);
			foreach (var hp in hull)
			{
				g.DrawLine(pen, cur, hp);
				cur = hp;
			}
			pictureBox1.Refresh();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var g = Graphics.FromImage(pictureBox1.Image);
			g.Clear(Color.White);
			points.Clear();
			pictureBox1.Refresh();
		}
	}
}
