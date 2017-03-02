namespace Conway
{
    partial class structurePlace
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
            this.xValSelector = new System.Windows.Forms.NumericUpDown();
            this.yValSelector = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.structureSelector = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xValSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValSelector)).BeginInit();
            this.structureSelector.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xValSelector
            // 
            this.xValSelector.Location = new System.Drawing.Point(29, 12);
            this.xValSelector.Name = "xValSelector";
            this.xValSelector.Size = new System.Drawing.Size(120, 20);
            this.xValSelector.TabIndex = 0;
            // 
            // yValSelector
            // 
            this.yValSelector.Location = new System.Drawing.Point(29, 39);
            this.yValSelector.Name = "yValSelector";
            this.yValSelector.Size = new System.Drawing.Size(120, 20);
            this.yValSelector.TabIndex = 1;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(9, 14);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(9, 41);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // structureSelector
            // 
            this.structureSelector.Controls.Add(this.tabPage1);
            this.structureSelector.Controls.Add(this.tabPage2);
            this.structureSelector.Controls.Add(this.tabPage3);
            this.structureSelector.Controls.Add(this.tabPage4);
            this.structureSelector.Location = new System.Drawing.Point(29, 65);
            this.structureSelector.Name = "structureSelector";
            this.structureSelector.SelectedIndex = 0;
            this.structureSelector.Size = new System.Drawing.Size(413, 427);
            this.structureSelector.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Static";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oscillators";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(405, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spaceships";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(405, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Guns";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // structurePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 504);
            this.Controls.Add(this.structureSelector);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yValSelector);
            this.Controls.Add(this.xValSelector);
            this.Name = "structurePlace";
            this.Text = "structurePlace";
            ((System.ComponentModel.ISupportInitialize)(this.xValSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValSelector)).EndInit();
            this.structureSelector.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown xValSelector;
        private System.Windows.Forms.NumericUpDown yValSelector;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl structureSelector;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}