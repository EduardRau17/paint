namespace cel_mai_aproape_smr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_start = new System.Windows.Forms.Panel();
            this.panel_name = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pb_start = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_start.SuspendLayout();
            this.panel_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_start
            // 
            this.panel_start.Controls.Add(this.panel_name);
            this.panel_start.Controls.Add(this.pb_start);
            this.panel_start.Location = new System.Drawing.Point(213, 106);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(319, 217);
            this.panel_start.TabIndex = 1;
            this.panel_start.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_start_Paint);
            // 
            // panel_name
            // 
            this.panel_name.Controls.Add(this.txt_name);
            this.panel_name.Location = new System.Drawing.Point(3, 141);
            this.panel_name.Name = "panel_name";
            this.panel_name.Size = new System.Drawing.Size(313, 76);
            this.panel_name.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(27, 17);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(260, 41);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // pb_start
            // 
            this.pb_start.Location = new System.Drawing.Point(66, 3);
            this.pb_start.Name = "pb_start";
            this.pb_start.Size = new System.Drawing.Size(194, 132);
            this.pb_start.TabIndex = 0;
            this.pb_start.TabStop = false;
            this.pb_start.Click += new System.EventHandler(this.pb_start_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(748, 404);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 34);
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_start.ResumeLayout(false);
            this.panel_name.ResumeLayout(false);
            this.panel_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.PictureBox pb_start;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_name;
    }
}

