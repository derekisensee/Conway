namespace Conway
{
    partial class randomizer
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
            this.randomComboLabel = new System.Windows.Forms.Label();
            this.randomize = new System.Windows.Forms.Button();
            this.randomDensity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.randomDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // randomComboLabel
            // 
            this.randomComboLabel.AutoSize = true;
            this.randomComboLabel.Location = new System.Drawing.Point(30, 17);
            this.randomComboLabel.Name = "randomComboLabel";
            this.randomComboLabel.Size = new System.Drawing.Size(125, 13);
            this.randomComboLabel.TabIndex = 1;
            this.randomComboLabel.Text = "Density/Chance for Alive";
            // 
            // randomize
            // 
            this.randomize.Location = new System.Drawing.Point(108, 227);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(75, 23);
            this.randomize.TabIndex = 2;
            this.randomize.Text = "Randomize!";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // randomDensity
            // 
            this.randomDensity.DecimalPlaces = 3;
            this.randomDensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.randomDensity.Location = new System.Drawing.Point(161, 15);
            this.randomDensity.Name = "randomDensity";
            this.randomDensity.Size = new System.Drawing.Size(120, 20);
            this.randomDensity.TabIndex = 3;
            this.randomDensity.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 412);
            this.Controls.Add(this.randomDensity);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.randomComboLabel);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "randomizer";
            this.Text = "randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.randomizer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.randomDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomComboLabel;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.NumericUpDown randomDensity;
    }
}