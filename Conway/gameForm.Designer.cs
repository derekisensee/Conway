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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.decTime = new System.Windows.Forms.Button();
            this.incTime = new System.Windows.Forms.Button();
            this.currInterval = new System.Windows.Forms.Label();
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.structurePlaceFormButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 9);
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
            this.pause.Location = new System.Drawing.Point(119, 3);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause/Start";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // decTime
            // 
            this.decTime.Location = new System.Drawing.Point(3, 3);
            this.decTime.Name = "decTime";
            this.decTime.Size = new System.Drawing.Size(30, 23);
            this.decTime.TabIndex = 3;
            this.decTime.Text = "-";
            this.decTime.UseVisualStyleBackColor = true;
            this.decTime.Click += new System.EventHandler(this.decTime_Click);
            // 
            // incTime
            // 
            this.incTime.Location = new System.Drawing.Point(39, 3);
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
            this.currInterval.Location = new System.Drawing.Point(75, 0);
            this.currInterval.Name = "currInterval";
            this.currInterval.Size = new System.Drawing.Size(38, 13);
            this.currInterval.TabIndex = 5;
            this.currInterval.Text = "150ms";
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(209, 3);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(75, 23);
            this.zoomIn.TabIndex = 6;
            this.zoomIn.Text = "Zoom In";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(290, 3);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(75, 23);
            this.zoomOut.TabIndex = 7;
            this.zoomOut.Text = "Zoom Out";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 495);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.decTime);
            this.flowLayoutPanel1.Controls.Add(this.incTime);
            this.flowLayoutPanel1.Controls.Add(this.currInterval);
            this.flowLayoutPanel1.Controls.Add(this.pause);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.zoomIn);
            this.flowLayoutPanel1.Controls.Add(this.zoomOut);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.structurePlaceFormButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1174, 30);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Location = new System.Drawing.Point(200, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 23);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(371, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 23);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // structurePlaceFormButton
            // 
            this.structurePlaceFormButton.Location = new System.Drawing.Point(380, 3);
            this.structurePlaceFormButton.Name = "structurePlaceFormButton";
            this.structurePlaceFormButton.Size = new System.Drawing.Size(203, 23);
            this.structurePlaceFormButton.TabIndex = 8;
            this.structurePlaceFormButton.Text = "Place Structure";
            this.structurePlaceFormButton.UseVisualStyleBackColor = true;
            this.structurePlaceFormButton.Click += new System.EventHandler(this.structurePlaceFormButton_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1198, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameForm";
            this.Text = "gameForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button decTime;
        private System.Windows.Forms.Button incTime;
        private System.Windows.Forms.Label currInterval;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button structurePlaceFormButton;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
    }
}