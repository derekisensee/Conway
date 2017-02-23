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
            this.cellGameField = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cellGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // cellGameField
            // 
            this.cellGameField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellGameField.Location = new System.Drawing.Point(12, 12);
            this.cellGameField.Name = "cellGameField";
            this.cellGameField.Size = new System.Drawing.Size(761, 405);
            this.cellGameField.TabIndex = 0;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 429);
            this.Controls.Add(this.cellGameField);
            this.Name = "gameForm";
            this.Text = "gameForm";
            ((System.ComponentModel.ISupportInitialize)(this.cellGameField)).EndInit();
            this.ResumeLayout(false);
            
        }

        #endregion

        private System.Windows.Forms.DataGridView cellGameField;
    }
}