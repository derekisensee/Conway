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
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.slowSpeedButton = new System.Windows.Forms.Button();
            this.mediumSpeedButton = new System.Windows.Forms.Button();
            this.fastSpeedButton = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.structurePlaceFormButton = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.randomizerButton = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.clearBoard = new System.Windows.Forms.Button();
            this.fastestSpeedButton = new System.Windows.Forms.Button();
            this.ManipulationHolder = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ManipulationHolder.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(805, 9);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(84, 32);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause/Start";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(174, 32);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(75, 23);
            this.zoomIn.TabIndex = 6;
            this.zoomIn.Text = "Zoom In";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(3, 61);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 495);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.slowSpeedButton);
            this.flowLayoutPanel1.Controls.Add(this.mediumSpeedButton);
            this.flowLayoutPanel1.Controls.Add(this.fastSpeedButton);
            this.flowLayoutPanel1.Controls.Add(this.fastestSpeedButton);
            this.flowLayoutPanel1.Controls.Add(this.pause);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.zoomIn);
            this.flowLayoutPanel1.Controls.Add(this.zoomOut);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.splitter3);
            this.flowLayoutPanel1.Controls.Add(this.randomizerButton);
            this.flowLayoutPanel1.Controls.Add(this.splitter4);
            this.flowLayoutPanel1.Controls.Add(this.clearBoard);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(932, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 159);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // slowSpeedButton
            // 
            this.slowSpeedButton.Location = new System.Drawing.Point(3, 3);
            this.slowSpeedButton.Name = "slowSpeedButton";
            this.slowSpeedButton.Size = new System.Drawing.Size(75, 23);
            this.slowSpeedButton.TabIndex = 16;
            this.slowSpeedButton.Text = "Slow";
            this.slowSpeedButton.UseVisualStyleBackColor = true;
            this.slowSpeedButton.Click += new System.EventHandler(this.slowSpeedButton_Click);
            // 
            // mediumSpeedButton
            // 
            this.mediumSpeedButton.Location = new System.Drawing.Point(84, 3);
            this.mediumSpeedButton.Name = "mediumSpeedButton";
            this.mediumSpeedButton.Size = new System.Drawing.Size(75, 23);
            this.mediumSpeedButton.TabIndex = 17;
            this.mediumSpeedButton.Text = "Medium";
            this.mediumSpeedButton.UseVisualStyleBackColor = true;
            this.mediumSpeedButton.Click += new System.EventHandler(this.mediumSpeedButton_Click);
            // 
            // fastSpeedButton
            // 
            this.fastSpeedButton.Location = new System.Drawing.Point(165, 3);
            this.fastSpeedButton.Name = "fastSpeedButton";
            this.fastSpeedButton.Size = new System.Drawing.Size(75, 23);
            this.fastSpeedButton.TabIndex = 18;
            this.fastSpeedButton.Text = "Fast";
            this.fastSpeedButton.UseVisualStyleBackColor = true;
            this.fastSpeedButton.Click += new System.EventHandler(this.fastSpeedButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Location = new System.Drawing.Point(165, 32);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 23);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(84, 61);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 23);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // structurePlaceFormButton
            // 
            this.structurePlaceFormButton.Location = new System.Drawing.Point(6, 19);
            this.structurePlaceFormButton.Name = "structurePlaceFormButton";
            this.structurePlaceFormButton.Size = new System.Drawing.Size(203, 23);
            this.structurePlaceFormButton.TabIndex = 8;
            this.structurePlaceFormButton.Text = "Place Structure";
            this.structurePlaceFormButton.UseVisualStyleBackColor = true;
            this.structurePlaceFormButton.Click += new System.EventHandler(this.structurePlaceFormButton_Click);
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter3.Location = new System.Drawing.Point(93, 61);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 23);
            this.splitter3.TabIndex = 12;
            this.splitter3.TabStop = false;
            // 
            // randomizerButton
            // 
            this.randomizerButton.Location = new System.Drawing.Point(102, 61);
            this.randomizerButton.Name = "randomizerButton";
            this.randomizerButton.Size = new System.Drawing.Size(75, 23);
            this.randomizerButton.TabIndex = 15;
            this.randomizerButton.Text = "Randomizer";
            this.randomizerButton.UseVisualStyleBackColor = true;
            this.randomizerButton.Click += new System.EventHandler(this.randomizerButton_Click);
            // 
            // splitter4
            // 
            this.splitter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter4.Location = new System.Drawing.Point(183, 61);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 23);
            this.splitter4.TabIndex = 14;
            this.splitter4.TabStop = false;
            // 
            // clearBoard
            // 
            this.clearBoard.Location = new System.Drawing.Point(3, 90);
            this.clearBoard.Name = "clearBoard";
            this.clearBoard.Size = new System.Drawing.Size(75, 23);
            this.clearBoard.TabIndex = 13;
            this.clearBoard.Text = "Clear Board";
            this.clearBoard.UseVisualStyleBackColor = true;
            this.clearBoard.Click += new System.EventHandler(this.clearBoard_Click);
            // 
            // fastestSpeedButton
            // 
            this.fastestSpeedButton.Location = new System.Drawing.Point(3, 32);
            this.fastestSpeedButton.Name = "fastestSpeedButton";
            this.fastestSpeedButton.Size = new System.Drawing.Size(75, 23);
            this.fastestSpeedButton.TabIndex = 19;
            this.fastestSpeedButton.Text = "Fastest";
            this.fastestSpeedButton.UseVisualStyleBackColor = true;
            this.fastestSpeedButton.Click += new System.EventHandler(this.fastestSpeedButton_Click);
            // 
            // ManipulationHolder
            // 
            this.ManipulationHolder.Controls.Add(this.structurePlaceFormButton);
            this.ManipulationHolder.Location = new System.Drawing.Point(932, 177);
            this.ManipulationHolder.Name = "ManipulationHolder";
            this.ManipulationHolder.Size = new System.Drawing.Size(248, 150);
            this.ManipulationHolder.TabIndex = 9;
            this.ManipulationHolder.TabStop = false;
            this.ManipulationHolder.Text = "Manipulation Controls";
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1198, 555);
            this.Controls.Add(this.ManipulationHolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameForm";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ManipulationHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button structurePlaceFormButton;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button clearBoard;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button randomizerButton;
        private System.Windows.Forms.Button slowSpeedButton;
        private System.Windows.Forms.Button mediumSpeedButton;
        private System.Windows.Forms.Button fastSpeedButton;
        private System.Windows.Forms.Button fastestSpeedButton;
        private System.Windows.Forms.GroupBox ManipulationHolder;
    }
}