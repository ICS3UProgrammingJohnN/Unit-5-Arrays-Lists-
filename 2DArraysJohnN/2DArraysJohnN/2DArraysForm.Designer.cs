namespace _2DArraysJohnN
{
    partial class frm2DArrays
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lstValues = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(55, 45);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(71, 26);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(55, 104);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(64, 26);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(159, 43);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 33);
            this.numLength.TabIndex = 2;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(159, 104);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 33);
            this.numWidth.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(363, 71);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 36);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(154, 370);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(17, 26);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = " ";
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.ItemHeight = 26;
            this.lstValues.Location = new System.Drawing.Point(60, 179);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(378, 160);
            this.lstValues.TabIndex = 5;
            // 
            // frm2DArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 430);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lstValues);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm2DArrays";
            this.Text = "Average with 2DArrays";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.ListBox lstValues;
    }
}

