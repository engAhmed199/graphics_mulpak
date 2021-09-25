namespace WindowsFormsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.Panel();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.board.Location = new System.Drawing.Point(312, 42);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(1027, 556);
            this.board.TabIndex = 1;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(55, 93);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(114, 22);
            this.x1.TabIndex = 2;
            this.x1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(55, 343);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(114, 22);
            this.y2.TabIndex = 3;
            this.y2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // x2
            // 
            this.x2.AcceptsReturn = true;
            this.x2.AcceptsTab = true;
            this.x2.Location = new System.Drawing.Point(55, 165);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(114, 22);
            this.x2.TabIndex = 4;
            this.x2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(55, 261);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(114, 22);
            this.y1.TabIndex = 5;
            this.y1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "y2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 637);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

