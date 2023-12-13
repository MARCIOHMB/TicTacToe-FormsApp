namespace Tic_Tac_Toe__FormsApp
{
    partial class Play2Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.RTbtnpy2 = new System.Windows.Forms.Button();
            this.P1textBox = new System.Windows.Forms.TextBox();
            this.P2textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.P1Sbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(166, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tic Tac Toe";
            // 
            // RTbtnpy2
            // 
            this.RTbtnpy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RTbtnpy2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RTbtnpy2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTbtnpy2.Location = new System.Drawing.Point(12, 12);
            this.RTbtnpy2.Name = "RTbtnpy2";
            this.RTbtnpy2.Size = new System.Drawing.Size(76, 37);
            this.RTbtnpy2.TabIndex = 5;
            this.RTbtnpy2.Text = "<--";
            this.RTbtnpy2.UseVisualStyleBackColor = false;
            this.RTbtnpy2.Click += new System.EventHandler(this.RTbtnpy2_Click);
            // 
            // P1textBox
            // 
            this.P1textBox.Location = new System.Drawing.Point(194, 44);
            this.P1textBox.Name = "P1textBox";
            this.P1textBox.Size = new System.Drawing.Size(118, 20);
            this.P1textBox.TabIndex = 0;
            // 
            // P2textBox
            // 
            this.P2textBox.Location = new System.Drawing.Point(194, 91);
            this.P2textBox.Name = "P2textBox";
            this.P2textBox.Size = new System.Drawing.Size(118, 20);
            this.P2textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 1 Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player 2 Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.P1Sbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.P2textBox);
            this.groupBox1.Controls.Add(this.P1textBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(166, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // P1Sbtn
            // 
            this.P1Sbtn.BackColor = System.Drawing.Color.Yellow;
            this.P1Sbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.P1Sbtn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Sbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.P1Sbtn.Location = new System.Drawing.Point(64, 174);
            this.P1Sbtn.Name = "P1Sbtn";
            this.P1Sbtn.Size = new System.Drawing.Size(169, 45);
            this.P1Sbtn.TabIndex = 6;
            this.P1Sbtn.Text = "start Game";
            this.P1Sbtn.UseVisualStyleBackColor = false;
            this.P1Sbtn.Click += new System.EventHandler(this.P1Sbtn_Click);
            // 
            // Play2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(664, 531);
            this.Controls.Add(this.RTbtnpy2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Play2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play2Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RTbtnpy2;
        private System.Windows.Forms.TextBox P1textBox;
        private System.Windows.Forms.TextBox P2textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button P1Sbtn;
    }
}