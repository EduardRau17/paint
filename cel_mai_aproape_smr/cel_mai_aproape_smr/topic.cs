using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cel_mai_aproape_smr
{
    public class topic
    {
        public Form1 form1;
        public form_game fgame;
        Panel panel_topic;
        Button btn_topic_1;
        Button btn_topic_2;
        Button btn_topic_3;
        
        
        public topic(Form1 form1, form_game fGame)
        {
                this.form1 = form1;             
                this.fgame = fGame;
        }
        public void create_topic()
        {
            panel_topic = new Panel();
            btn_topic_1 = new Button();
            btn_topic_2 = new Button();
            btn_topic_3 = new Button();
            Random rd = new Random();

            string btn1_text;
            string btn2_text;
            string btn3_text;

            form1.Controls.Add(panel_topic);
            panel_topic.BackColor = Color.Transparent;
            panel_topic.Location = new Point(213 / 2, 106);
            panel_topic.Size = new Size(300 * 2, 200);

            string[] lines = System.IO.File.ReadAllLines("../../topics.txt");
            btn1_text = lines[rd.Next(6)];
            btn2_text = lines[rd.Next(6)];
            btn3_text = lines[rd.Next(6)];
            while (btn1_text == btn2_text || btn1_text == btn3_text || btn2_text == btn3_text) { 
                btn2_text = lines[rd.Next(6)];
                btn3_text = lines[rd.Next(6)];
            }
        

            panel_topic.Controls.Add(btn_topic_1);
            this.init_btn(btn_topic_1, btn1_text, 0);

            panel_topic.Controls.Add(btn_topic_2);
            this.init_btn(btn_topic_2, btn2_text, 1);

            panel_topic.Controls.Add(btn_topic_3);
            this.init_btn(btn_topic_3, btn3_text, 2);


            form1.panel_start.Visible = false;
            panel_topic.Visible = true;

            //click_event

            this.btn_topic_1.Click += new System.EventHandler(this.Btn_topic_Click); 
            this.btn_topic_2.Click += new System.EventHandler(this.Btn_topic_Click); 
            this.btn_topic_3.Click += new System.EventHandler(this.Btn_topic_Click); 

        }


        private void Btn_topic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            form1.c_topic = btn.Text;
           
            form1.Visible = false;

            
        }

        private void init_btn(Button btn,String text,int id)
        {
            btn.Text = text;
            btn.Size = new Size(73*2, 50);
            btn.Location = new Point(20*2 + (id * 93 * 2), 75);

        }
    }
}
