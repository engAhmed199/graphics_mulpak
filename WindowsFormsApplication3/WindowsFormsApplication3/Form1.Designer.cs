namespace WindowsFormsApplication3
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
            this.board = new System.Windows.Forms.Panel();
            this.xcntr = new System.Windows.Forms.TextBox();
            this.ycntr = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.board.Location = new System.Drawing.Point(282, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(909, 468);
            this.board.TabIndex = 1;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.board_Paint);
            // 
            // xcntr
            // 
            this.xcntr.Location = new System.Drawing.Point(123, 145);
            this.xcntr.Name = "xcntr";
            this.xcntr.Size = new System.Drawing.Size(100, 22);
            this.xcntr.TabIndex = 2;
            // 
            // ycntr
            // 
            this.ycntr.Location = new System.Drawing.Point(123, 259);
            this.ycntr.Name = "ycntr";
            this.ycntr.Size = new System.Drawing.Size(100, 22);
            this.ycntr.TabIndex = 3;
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(123, 357);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 22);
            this.radius.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "x center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "y center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "radius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.ycntr);
            this.Controls.Add(this.xcntr);
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
        private System.Windows.Forms.TextBox xcntr;
        private System.Windows.Forms.TextBox ycntr;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

