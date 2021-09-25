namespace WindowsFormsApplication4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.board = new System.Windows.Forms.Panel();
            this.xcntr = new System.Windows.Forms.TextBox();
            this.rx = new System.Windows.Forms.TextBox();
            this.ycntr = new System.Windows.Forms.TextBox();
            this.ry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ellipse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x center";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "y center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "radius x";
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.board.Location = new System.Drawing.Point(323, 26);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(984, 456);
            this.board.TabIndex = 4;
            // 
            // xcntr
            // 
            this.xcntr.Location = new System.Drawing.Point(147, 58);
            this.xcntr.Name = "xcntr";
            this.xcntr.Size = new System.Drawing.Size(113, 22);
            this.xcntr.TabIndex = 5;
            // 
            // rx
            // 
            this.rx.Location = new System.Drawing.Point(147, 245);
            this.rx.Name = "rx";
            this.rx.Size = new System.Drawing.Size(113, 22);
            this.rx.TabIndex = 6;
            // 
            // ycntr
            // 
            this.ycntr.Location = new System.Drawing.Point(147, 148);
            this.ycntr.Name = "ycntr";
            this.ycntr.Size = new System.Drawing.Size(113, 22);
            this.ycntr.TabIndex = 7;
            // 
            // ry
            // 
            this.ry.Location = new System.Drawing.Point(147, 337);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(113, 22);
            this.ry.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "radius y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ry);
            this.Controls.Add(this.ycntr);
            this.Controls.Add(this.rx);
            this.Controls.Add(this.xcntr);
            this.Controls.Add(this.board);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.TextBox xcntr;
        private System.Windows.Forms.TextBox rx;
        private System.Windows.Forms.TextBox ycntr;
        private System.Windows.Forms.TextBox ry;
        private System.Windows.Forms.Label label4;
    }
}

