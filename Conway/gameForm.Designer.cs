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
            this.stepTimer = new System.Windows.Forms.Timer(this.components);
            this.Pause = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slowSpeedButton = new System.Windows.Forms.Button();
            this.mediumSpeedButton = new System.Windows.Forms.Button();
            this.fastSpeedButton = new System.Windows.Forms.Button();
            this.fastestSpeedButton = new System.Windows.Forms.Button();
            this.randomizerButton = new System.Windows.Forms.Button();
            this.clearBoard = new System.Windows.Forms.Button();
            this.structurePlaceFormButton = new System.Windows.Forms.Button();
            this.ManipulationHolder = new System.Windows.Forms.GroupBox();
            this.timeControlsHolder = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aliveCount = new System.Windows.Forms.Label();
            this.generationsCount = new System.Windows.Forms.Label();
            this.aliveLabel = new System.Windows.Forms.Label();
            this.generationsLable = new System.Windows.Forms.Label();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ManipulationHolder.SuspendLayout();
            this.timeControlsHolder.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // stepTimer
            // 
            this.stepTimer.Enabled = true;
            this.stepTimer.Interval = 150;
            this.stepTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(6, 48);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(242, 23);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "Pause/Start";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(6, 48);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(111, 23);
            this.zoomIn.TabIndex = 6;
            this.zoomIn.Text = "Zoom In";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(6, 77);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(111, 23);
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
            this.panel1.Location = new System.Drawing.Point(272, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 531);
            this.panel1.TabIndex = 0;
            // 
            // slowSpeedButton
            // 
            this.slowSpeedButton.Location = new System.Drawing.Point(6, 19);
            this.slowSpeedButton.Name = "slowSpeedButton";
            this.slowSpeedButton.Size = new System.Drawing.Size(46, 23);
            this.slowSpeedButton.TabIndex = 16;
            this.slowSpeedButton.Text = "Slow";
            this.slowSpeedButton.UseVisualStyleBackColor = true;
            this.slowSpeedButton.Click += new System.EventHandler(this.slowSpeedButton_Click);
            // 
            // mediumSpeedButton
            // 
            this.mediumSpeedButton.Location = new System.Drawing.Point(58, 19);
            this.mediumSpeedButton.Name = "mediumSpeedButton";
            this.mediumSpeedButton.Size = new System.Drawing.Size(59, 23);
            this.mediumSpeedButton.TabIndex = 17;
            this.mediumSpeedButton.Text = "Medium";
            this.mediumSpeedButton.UseVisualStyleBackColor = true;
            this.mediumSpeedButton.Click += new System.EventHandler(this.mediumSpeedButton_Click);
            // 
            // fastSpeedButton
            // 
            this.fastSpeedButton.Location = new System.Drawing.Point(123, 19);
            this.fastSpeedButton.Name = "fastSpeedButton";
            this.fastSpeedButton.Size = new System.Drawing.Size(54, 23);
            this.fastSpeedButton.TabIndex = 18;
            this.fastSpeedButton.Text = "Fast";
            this.fastSpeedButton.UseVisualStyleBackColor = true;
            this.fastSpeedButton.Click += new System.EventHandler(this.fastSpeedButton_Click);
            // 
            // fastestSpeedButton
            // 
            this.fastestSpeedButton.Location = new System.Drawing.Point(183, 19);
            this.fastestSpeedButton.Name = "fastestSpeedButton";
            this.fastestSpeedButton.Size = new System.Drawing.Size(65, 23);
            this.fastestSpeedButton.TabIndex = 19;
            this.fastestSpeedButton.Text = "Fastest";
            this.fastestSpeedButton.UseVisualStyleBackColor = true;
            this.fastestSpeedButton.Click += new System.EventHandler(this.fastestSpeedButton_Click);
            // 
            // randomizerButton
            // 
            this.randomizerButton.Location = new System.Drawing.Point(123, 77);
            this.randomizerButton.Name = "randomizerButton";
            this.randomizerButton.Size = new System.Drawing.Size(125, 23);
            this.randomizerButton.TabIndex = 15;
            this.randomizerButton.Text = "Randomizer";
            this.randomizerButton.UseVisualStyleBackColor = true;
            this.randomizerButton.Click += new System.EventHandler(this.randomizerButton_Click);
            // 
            // clearBoard
            // 
            this.clearBoard.Location = new System.Drawing.Point(123, 48);
            this.clearBoard.Name = "clearBoard";
            this.clearBoard.Size = new System.Drawing.Size(125, 23);
            this.clearBoard.TabIndex = 13;
            this.clearBoard.Text = "Clear Board";
            this.clearBoard.UseVisualStyleBackColor = true;
            this.clearBoard.Click += new System.EventHandler(this.clearBoard_Click);
            // 
            // structurePlaceFormButton
            // 
            this.structurePlaceFormButton.Location = new System.Drawing.Point(6, 19);
            this.structurePlaceFormButton.Name = "structurePlaceFormButton";
            this.structurePlaceFormButton.Size = new System.Drawing.Size(242, 23);
            this.structurePlaceFormButton.TabIndex = 8;
            this.structurePlaceFormButton.Text = "Place Structure";
            this.structurePlaceFormButton.UseVisualStyleBackColor = true;
            this.structurePlaceFormButton.Click += new System.EventHandler(this.structurePlaceFormButton_Click);
            // 
            // ManipulationHolder
            // 
            this.ManipulationHolder.Controls.Add(this.structurePlaceFormButton);
            this.ManipulationHolder.Controls.Add(this.zoomOut);
            this.ManipulationHolder.Controls.Add(this.zoomIn);
            this.ManipulationHolder.Controls.Add(this.randomizerButton);
            this.ManipulationHolder.Controls.Add(this.clearBoard);
            this.ManipulationHolder.Location = new System.Drawing.Point(12, 12);
            this.ManipulationHolder.Name = "ManipulationHolder";
            this.ManipulationHolder.Size = new System.Drawing.Size(254, 150);
            this.ManipulationHolder.TabIndex = 9;
            this.ManipulationHolder.TabStop = false;
            this.ManipulationHolder.Text = "Board Manipulation Controls";
            // 
            // timeControlsHolder
            // 
            this.timeControlsHolder.Controls.Add(this.HistoryButton);
            this.timeControlsHolder.Controls.Add(this.Pause);
            this.timeControlsHolder.Controls.Add(this.fastestSpeedButton);
            this.timeControlsHolder.Controls.Add(this.fastSpeedButton);
            this.timeControlsHolder.Controls.Add(this.mediumSpeedButton);
            this.timeControlsHolder.Controls.Add(this.slowSpeedButton);
            this.timeControlsHolder.Location = new System.Drawing.Point(12, 169);
            this.timeControlsHolder.Name = "timeControlsHolder";
            this.timeControlsHolder.Size = new System.Drawing.Size(254, 109);
            this.timeControlsHolder.TabIndex = 10;
            this.timeControlsHolder.TabStop = false;
            this.timeControlsHolder.Text = "Time Controls";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aliveCount);
            this.groupBox1.Controls.Add(this.generationsCount);
            this.groupBox1.Controls.Add(this.aliveLabel);
            this.groupBox1.Controls.Add(this.generationsLable);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Numbers!";
            // 
            // aliveCount
            // 
            this.aliveCount.AutoSize = true;
            this.aliveCount.Location = new System.Drawing.Point(88, 38);
            this.aliveCount.Name = "aliveCount";
            this.aliveCount.Size = new System.Drawing.Size(13, 13);
            this.aliveCount.TabIndex = 3;
            this.aliveCount.Text = "0";
            // 
            // generationsCount
            // 
            this.generationsCount.AutoSize = true;
            this.generationsCount.Location = new System.Drawing.Point(88, 16);
            this.generationsCount.Name = "generationsCount";
            this.generationsCount.Size = new System.Drawing.Size(13, 13);
            this.generationsCount.TabIndex = 2;
            this.generationsCount.Text = "0";
            // 
            // aliveLabel
            // 
            this.aliveLabel.AutoSize = true;
            this.aliveLabel.Location = new System.Drawing.Point(15, 38);
            this.aliveLabel.Name = "aliveLabel";
            this.aliveLabel.Size = new System.Drawing.Size(58, 13);
            this.aliveLabel.TabIndex = 1;
            this.aliveLabel.Text = "Alive Cells:";
            // 
            // generationsLable
            // 
            this.generationsLable.AutoSize = true;
            this.generationsLable.Location = new System.Drawing.Point(15, 16);
            this.generationsLable.Name = "generationsLable";
            this.generationsLable.Size = new System.Drawing.Size(67, 13);
            this.generationsLable.TabIndex = 0;
            this.generationsLable.Text = "Generations:";
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(7, 78);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(241, 23);
            this.HistoryButton.TabIndex = 20;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1198, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeControlsHolder);
            this.Controls.Add(this.ManipulationHolder);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameForm";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ManipulationHolder.ResumeLayout(false);
            this.timeControlsHolder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer stepTimer;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button structurePlaceFormButton;
        private System.Windows.Forms.Button clearBoard;
        private System.Windows.Forms.Button randomizerButton;
        private System.Windows.Forms.Button slowSpeedButton;
        private System.Windows.Forms.Button mediumSpeedButton;
        private System.Windows.Forms.Button fastSpeedButton;
        private System.Windows.Forms.Button fastestSpeedButton;
        private System.Windows.Forms.GroupBox ManipulationHolder;
        private System.Windows.Forms.GroupBox timeControlsHolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aliveLabel;
        private System.Windows.Forms.Label generationsLable;
        private System.Windows.Forms.Label aliveCount;
        private System.Windows.Forms.Label generationsCount;
        private System.Windows.Forms.Button HistoryButton;
    }
}