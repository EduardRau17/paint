using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
//using System.Threading;

namespace cel_mai_aproape_smr
{
    public partial class Form1 : Form
    {
        form_game game;
        topic topic;
        Timer timer_t;
        Random random;
        public string c_topic;
        public String resurse = "../../resurse/";
        public String nume;
        private bool valid_strat = false;
        private bool lala = false;
        private String default_text = "Zi un nume shefule";
        public Form1()
        {
            InitializeComponent();
            game = new form_game(this);
        }
        
        public void face_tick(object sender, EventArgs e)
        {
            if (txt_name.Text == default_text)
            {
                panel_name.BackColor = Color.FromArgb(random.Next(100, 256), 0, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Controls.Add(timer);
            pb_start.BackgroundImage = Image.FromFile(resurse+"btn_start.png");
            pb_start.BackgroundImageLayout = ImageLayout.Stretch;
            btn_close.BackgroundImage = Image.FromFile(resurse + "btn_close.png");
            btn_close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_close.BackColor= Color.Transparent;
            this.BackgroundImage = Image.FromFile(resurse + "bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel_start.BackColor = Color.Transparent;
            txt_name.Text = default_text ;
            timer_t = new Timer();
            timer_t.Interval = 100;
            timer_t.Start();
            timer_t.Tick += new System.EventHandler(this.face_tick);
            random = new Random();
            topic = new topic(this,game);
            topic.create_topic();
        }

        private void pb_start_Click(object sender, EventArgs e)
        {
                valid_strat = false;
            if (!(txt_name.Text == default_text || txt_name.Text.Length == 0 || txt_name.Text.IndexOf(' ') == 0)) {
                valid_strat = true;

            }


            if (valid_strat)
            {
                this.nume = txt_name.Text;
                this.panel_name.BackColor = Color.Transparent;
                topic.see_pane();

            }

        }

        private void btn_close_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            this.panel_name.BackColor = Color.Transparent;
        }

        private void panel_start_Paint(object sender, PaintEventArgs e)
        {

        }
        public String get_name()
        {
            return this.nume;
        }
    }
}
