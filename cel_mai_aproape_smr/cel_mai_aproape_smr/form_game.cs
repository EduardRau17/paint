using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cel_mai_aproape_smr
{
    public partial class form_game : Form
    {
        Graphics g;
        int mouse_x = 1;
        int mouse_y = 1;
        bool moving = false;
        Pen pen;
        Pen pen_b;
        Form1 form1;
        //SolidBrush brush = new SolidBrush(Color.Gold);
        public form_game(Form1 form1)
        {
            InitializeComponent();
            g = panel_main.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen_b = new Pen(Color.Gold, 10);

            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.form1 = form1;


        }

        private void change_colour_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pen.Color = pictureBox.BackColor;
            pb_black.BorderStyle = BorderStyle.FixedSingle;
            pb_gold.BorderStyle = BorderStyle.FixedSingle;
            pb_dblue.BorderStyle = BorderStyle.FixedSingle;
            pb_lime.BorderStyle = BorderStyle.FixedSingle;
            pb_orange.BorderStyle = BorderStyle.FixedSingle;
            pb_red.BorderStyle = BorderStyle.FixedSingle;
            pb_lblue.BorderStyle = BorderStyle.FixedSingle;
            pb_green.BorderStyle = BorderStyle.FixedSingle;
            pb_coral.BorderStyle = BorderStyle.FixedSingle;
            pb_white.BorderStyle = BorderStyle.FixedSingle;
            pb_eraser.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;//comment


        }

        private void create_border()
        {
            g.DrawLine(pen_b,0,0,650,0);
            g.DrawLine(pen_b,650,0,650,350);
            g.DrawLine(pen_b,650,350,0,350);
            g.DrawLine(pen_b, 0 ,350 , 0 ,0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            mouse_x = e.X;
            mouse_y = e.Y;
            panel_main.Cursor = Cursors.Cross;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (moving)
            {
                g.DrawLine(pen, new Point(mouse_x, mouse_y), e.Location);
                mouse_x = e.X;
                mouse_y = e.Y;
                //label1.Text=(mouse_x + "   " + mouse_y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            mouse_x = -1;
            mouse_y = -1;
            panel_main.Cursor = Cursors.Default;
        }

        private void form_game_Load(object sender, EventArgs e)
        {
            pb_close.BackgroundImage = Image.FromFile(this.form1.resurse + "btn_close.png");
            pb_close.BackgroundImageLayout = ImageLayout.Stretch;
            pb_eraser.BackgroundImage = Image.FromFile(this.form1.resurse + "eraser.png");
            pb_eraser.BackgroundImageLayout = ImageLayout.Stretch;
            //panel_main.BackgroundImage = Image.FromFile(this.form1.resurse + "border_paint.png");
            //panel_main.BackgroundImageLayout = ImageLayout.Stretch
            this.BackgroundImage = Image.FromFile(this.form1.resurse + "bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            pb_fill.BackgroundImage = Image.FromFile(this.form1.resurse + "galeata.png");
            pb_fill.BackgroundImageLayout = ImageLayout.Stretch;
            panel_change_colour.BackColor = Color.Transparent;

            ///
            pictureBox10.BackgroundImage = Image.FromFile(this.form1.resurse + "dim.png");
            pictureBox11.BackgroundImage = Image.FromFile(this.form1.resurse + "dim.png");
            pictureBox12.BackgroundImage = Image.FromFile(this.form1.resurse + "dim.png");
            pictureBox13.BackgroundImage = Image.FromFile(this.form1.resurse + "dim.png");
            ///
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            ///
            pictureBox13.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;  

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Visible = true;
        }

        private void pb_eraser_Click(object sender, EventArgs e)
        {
            pen.Color = this.panel_main.BackColor;
            pb_black.BorderStyle = BorderStyle.FixedSingle;
            pb_gold.BorderStyle = BorderStyle.FixedSingle;
            pb_dblue.BorderStyle = BorderStyle.FixedSingle;
            pb_lime.BorderStyle = BorderStyle.FixedSingle;
            pb_orange.BorderStyle = BorderStyle.FixedSingle;
            pb_red.BorderStyle = BorderStyle.FixedSingle;
            pb_eraser.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pen.Width = pictureBox.Size.Width - 5;
        }

        private void panel_main_MouseEnter(object sender, EventArgs e)
        {
            create_border();

        }

        private void pb_fill_Click(object sender, EventArgs e)
        {
            panel_main.BackColor = this.pen.Color;
        }
    }
}
