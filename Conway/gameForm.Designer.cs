namespace Conway
{
    partial class gameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decTime = new System.Windows.Forms.Button();
            this.incTime = new System.Windows.Forms.Button();
            this.currInterval = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":-)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(12, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause/Start";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(28, 45);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C#onway";
            // 
            // decTime
            // 
            this.decTime.Location = new System.Drawing.Point(12, 42);
            this.decTime.Name = "decTime";
            this.decTime.Size = new System.Drawing.Size(30, 23);
            this.decTime.TabIndex = 3;
            this.decTime.Text = "-";
            this.decTime.UseVisualStyleBackColor = true;
            this.decTime.Click += new System.EventHandler(this.decTime_Click);
            // 
            // incTime
            // 
            this.incTime.Location = new System.Drawing.Point(57, 42);
            this.incTime.Name = "incTime";
            this.incTime.Size = new System.Drawing.Size(30, 23);
            this.incTime.TabIndex = 4;
            this.incTime.Text = "+";
            this.incTime.UseVisualStyleBackColor = true;
            this.incTime.Click += new System.EventHandler(this.incTime_Click);
            // 
            // currInterval
            // 
            this.currInterval.AutoSize = true;
            this.currInterval.Location = new System.Drawing.Point(93, 47);
            this.currInterval.Name = "currInterval";
            this.currInterval.Size = new System.Drawing.Size(38, 13);
            this.currInterval.TabIndex = 5;
            this.currInterval.Text = "150ms";
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1235, 568);
            this.Controls.Add(this.currInterval);
            this.Controls.Add(this.incTime);
            this.Controls.Add(this.decTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pause);
            this.Name = "gameForm";
            this.Text = "gameForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decTime;
        private System.Windows.Forms.Button incTime;
        private System.Windows.Forms.Label currInterval;
    }
}