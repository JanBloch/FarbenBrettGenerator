namespace FarbenBrett
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.numAreaWidth = new System.Windows.Forms.NumericUpDown();
            this.numAreaHeight = new System.Windows.Forms.NumericUpDown();
            this.lblDescWidthNum = new System.Windows.Forms.Label();
            this.lblDescHeightNum = new System.Windows.Forms.Label();
            this.grpSizeControls = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numRectWidth = new System.Windows.Forms.NumericUpDown();
            this.lblDescRectangleHeightNum = new System.Windows.Forms.Label();
            this.btnSetRectangleSize = new System.Windows.Forms.Button();
            this.lblDescRectangleWidthNum = new System.Windows.Forms.Label();
            this.numRectHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaHeight)).BeginInit();
            this.grpSizeControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRectHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(12, 125);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(439, 293);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(9, 78);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(179, 23);
            this.btnSetSize.TabIndex = 1;
            this.btnSetSize.Text = "Ok";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.btnSetSize_Click);
            // 
            // numAreaWidth
            // 
            this.numAreaWidth.Location = new System.Drawing.Point(68, 19);
            this.numAreaWidth.Name = "numAreaWidth";
            this.numAreaWidth.Size = new System.Drawing.Size(120, 20);
            this.numAreaWidth.TabIndex = 2;
            // 
            // numAreaHeight
            // 
            this.numAreaHeight.Location = new System.Drawing.Point(68, 49);
            this.numAreaHeight.Name = "numAreaHeight";
            this.numAreaHeight.Size = new System.Drawing.Size(120, 20);
            this.numAreaHeight.TabIndex = 3;
            // 
            // lblDescWidthNum
            // 
            this.lblDescWidthNum.AutoSize = true;
            this.lblDescWidthNum.Location = new System.Drawing.Point(6, 21);
            this.lblDescWidthNum.Name = "lblDescWidthNum";
            this.lblDescWidthNum.Size = new System.Drawing.Size(34, 13);
            this.lblDescWidthNum.TabIndex = 4;
            this.lblDescWidthNum.Text = "Breite";
            // 
            // lblDescHeightNum
            // 
            this.lblDescHeightNum.AutoSize = true;
            this.lblDescHeightNum.Location = new System.Drawing.Point(6, 51);
            this.lblDescHeightNum.Name = "lblDescHeightNum";
            this.lblDescHeightNum.Size = new System.Drawing.Size(33, 13);
            this.lblDescHeightNum.TabIndex = 5;
            this.lblDescHeightNum.Text = "Höhe";
            // 
            // grpSizeControls
            // 
            this.grpSizeControls.Controls.Add(this.numAreaWidth);
            this.grpSizeControls.Controls.Add(this.lblDescHeightNum);
            this.grpSizeControls.Controls.Add(this.btnSetSize);
            this.grpSizeControls.Controls.Add(this.lblDescWidthNum);
            this.grpSizeControls.Controls.Add(this.numAreaHeight);
            this.grpSizeControls.Location = new System.Drawing.Point(12, 12);
            this.grpSizeControls.Name = "grpSizeControls";
            this.grpSizeControls.Size = new System.Drawing.Size(206, 107);
            this.grpSizeControls.TabIndex = 6;
            this.grpSizeControls.TabStop = false;
            this.grpSizeControls.Text = "Set Area Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numRectWidth);
            this.groupBox1.Controls.Add(this.lblDescRectangleWidthNum);
            this.groupBox1.Controls.Add(this.lblDescRectangleHeightNum);
            this.groupBox1.Controls.Add(this.numRectHeight);
            this.groupBox1.Controls.Add(this.btnSetRectangleSize);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Rectangle Size";
            // 
            // numRectWidth
            // 
            this.numRectWidth.Location = new System.Drawing.Point(68, 17);
            this.numRectWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRectWidth.Name = "numRectWidth";
            this.numRectWidth.Size = new System.Drawing.Size(120, 20);
            this.numRectWidth.TabIndex = 7;
            // 
            // lblDescRectangleHeightNum
            // 
            this.lblDescRectangleHeightNum.AutoSize = true;
            this.lblDescRectangleHeightNum.Location = new System.Drawing.Point(6, 49);
            this.lblDescRectangleHeightNum.Name = "lblDescRectangleHeightNum";
            this.lblDescRectangleHeightNum.Size = new System.Drawing.Size(33, 13);
            this.lblDescRectangleHeightNum.TabIndex = 10;
            this.lblDescRectangleHeightNum.Text = "Höhe";
            // 
            // btnSetRectangleSize
            // 
            this.btnSetRectangleSize.Location = new System.Drawing.Point(9, 76);
            this.btnSetRectangleSize.Name = "btnSetRectangleSize";
            this.btnSetRectangleSize.Size = new System.Drawing.Size(179, 23);
            this.btnSetRectangleSize.TabIndex = 6;
            this.btnSetRectangleSize.Text = "Ok";
            this.btnSetRectangleSize.UseVisualStyleBackColor = true;
            this.btnSetRectangleSize.Click += new System.EventHandler(this.btnSetRectangleSize_Click);
            // 
            // lblDescRectangleWidthNum
            // 
            this.lblDescRectangleWidthNum.AutoSize = true;
            this.lblDescRectangleWidthNum.Location = new System.Drawing.Point(6, 19);
            this.lblDescRectangleWidthNum.Name = "lblDescRectangleWidthNum";
            this.lblDescRectangleWidthNum.Size = new System.Drawing.Size(34, 13);
            this.lblDescRectangleWidthNum.TabIndex = 9;
            this.lblDescRectangleWidthNum.Text = "Breite";
            // 
            // numRectHeight
            // 
            this.numRectHeight.Location = new System.Drawing.Point(68, 47);
            this.numRectHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRectHeight.Name = "numRectHeight";
            this.numRectHeight.Size = new System.Drawing.Size(120, 20);
            this.numRectHeight.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSizeControls);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAreaWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaHeight)).EndInit();
            this.grpSizeControls.ResumeLayout(false);
            this.grpSizeControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRectHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.NumericUpDown numAreaWidth;
        private System.Windows.Forms.NumericUpDown numAreaHeight;
        private System.Windows.Forms.Label lblDescWidthNum;
        private System.Windows.Forms.Label lblDescHeightNum;
        private System.Windows.Forms.GroupBox grpSizeControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numRectWidth;
        private System.Windows.Forms.Label lblDescRectangleWidthNum;
        private System.Windows.Forms.Label lblDescRectangleHeightNum;
        private System.Windows.Forms.NumericUpDown numRectHeight;
        private System.Windows.Forms.Button btnSetRectangleSize;
    }
}

