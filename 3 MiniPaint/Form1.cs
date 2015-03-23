using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_MiniPaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Image ImageKopia;
        Pen pioroSzare, pioro;
        SolidBrush pedzel;
        Point p1, p2;

        public Form1()
        {
            InitializeComponent();

            pioroSzare = new Pen(Color.Gray, 2);
            pioro = new Pen(Color.Red);
            buttonColorLinii.BackColor = pioro.Color;

            pedzel = new SolidBrush(Color.Blue);
            buttonColorWypelnienia.BackColor = pedzel.Color;

            rysunek.Image = new Bitmap(rysunek.Width, rysunek.Height);
            g = Graphics.FromImage(rysunek.Image);
            g.Clear(Color.White);
            rysunek.Refresh();
        }

        private void rysunek_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                p1 = e.Location;
                ImageKopia = (rysunek.Image.Clone() as Image);
            }
        }

        private void rysunek_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (radioKrzywa.Checked)
                {
                    p2 = e.Location;
                    g.DrawLine(pioro, p1, p2);
                    p1 = p2;
                }
                else if (radioLinia.Checked)
                {
                    p2 = e.Location;
                    PrzywrocObraz();
                    g.DrawLine(pioroSzare, p1, p2);
                }
                else if (radioElipsa.Checked)
                {
                    p2 = e.Location;
                    PrzywrocObraz();
                    g.DrawEllipse(pioroSzare, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                }
                else if (radioProstokat.Checked)
                {
                    p2 = e.Location;
                    PrzywrocObraz();
                    g.DrawRectangle(pioroSzare, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
                }
            }
            rysunek.Refresh();
        }

        private void rysunek_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (radioKrzywa.Checked)
                {
                    p2 = e.Location;
                    g.DrawLine(pioro, p1, p2);
                }
                if (radioLinia.Checked)
                {
                    p2 = e.Location;
                    PrzywrocObraz();
                    g.DrawLine(pioro, p1, p2);
                }
                else if (radioElipsa.Checked)
                {
                    p2 = e.Location;
                    PrzywrocObraz();

                    if (checkBoxCzyWypelnienie.Checked)
                    {
                        g.FillEllipse(pedzel, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                    }
                    g.DrawEllipse(pioro, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                }
                else if (radioProstokat.Checked)
                {
                    p2 = e.Location;
                    PrzywrocObraz();

                    if (checkBoxCzyWypelnienie.Checked)
                    {
                        g.FillRectangle(pedzel, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
                    }
                    g.DrawRectangle(pioro, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
                }
            }
            rysunek.Refresh();
        }

        private void buttonColorLinii_Click(object sender, EventArgs e)
        {
            colorDialog.Color = buttonColorLinii.BackColor;
            colorDialog.ShowDialog();
            buttonColorLinii.BackColor = colorDialog.Color;
            pioro.Color = colorDialog.Color;
        }
        private void buttonColorWypelnienia_Click(object sender, EventArgs e)
        {
            colorDialog.Color = buttonColorWypelnienia.BackColor;
            colorDialog.ShowDialog();
            buttonColorWypelnienia.BackColor = colorDialog.Color;
            pedzel.Color = colorDialog.Color;
        }

        private void tbGrubosc_Scroll(object sender, EventArgs e)
        {
            pioro.Width = tbGrubosc.Value;
        }

        private void PrzywrocObraz()
        {
            rysunek.Image = (ImageKopia.Clone() as Image);
            g = Graphics.FromImage(rysunek.Image);
        }
    }
}
