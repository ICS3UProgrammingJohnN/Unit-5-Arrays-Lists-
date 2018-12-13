namespace ListsJohnN
{
    partial class frmLists
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
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(256, 44);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 33);
            this.txtMark.TabIndex = 0;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.BackColor = System.Drawing.Color.Transparent;
            this.lblMark.Location = new System.Drawing.Point(0, 47);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(255, 26);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Enter a mark between 1- 100:";
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.ItemHeight = 26;
            this.lstMarks.Location = new System.Drawing.Point(12, 131);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(351, 238);
            this.lstMarks.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(268, 83);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 29);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(102, 375);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(171, 33);
            this.btnCalculateAverage.TabIndex = 4;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(112, 446);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 26);
            this.lblAverage.TabIndex = 5;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 481);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.txtMark);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLists";
            this.Text = "List Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblAverage;
    }
}

