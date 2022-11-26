using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cel_mai_aproape_smr
{
    public class topic
    {
        public Form1 form1;
        Panel panel_topic;
        Button btn_topic_1;
        Button btn_topic_2;
        Button btn_topic_3;
        public topic(Form1 form1)
        {
                this.form1 = form1;             
        }
        public void create_topic()
        {
            panel_topic = new Panel();
            btn_topic_1 = new Button();
            btn_topic_2 = new Button();
            btn_topic_3 = new Button();

            form1.Controls.Add(panel_topic);
            panel_topic.BackColor = Color.Transparent;
            panel_topic.Location = new Point(213/2, 106);
            panel_topic.Size = new Size(300*2, 200);

            panel_topic.Controls.Add(btn_topic_1);
            this.init_btn(btn_topic_1, "btn1", 0);

            panel_topic.Controls.Add(btn_topic_2);
            this.init_btn(btn_topic_2, "btn2", 1);

            panel_topic.Controls.Add(btn_topic_3);
            this.init_btn(btn_topic_3, "btn3", 2);


            form1.panel_start.Visible = false;
            panel_topic.Visible = true;

        }
        private void init_btn(Button btn,String text,int id)
        {
            btn.Text = text;
            btn.Size = new Size(73*2, 50);
            btn.Location = new Point(20*2 + (id * 93 * 2), 75);
        }
    }
}
