namespace Topic_10_assignment
{
    partial class FormAddingResourcesAssignment
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
            this.btnEmerald = new System.Windows.Forms.Button();
            this.btnQuartz = new System.Windows.Forms.Button();
            this.btnBismuth = new System.Windows.Forms.Button();
            this.btnBismuthBear = new System.Windows.Forms.Button();
            this.imgMineral = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMineral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmerald
            // 
            this.btnEmerald.Location = new System.Drawing.Point(12, 123);
            this.btnEmerald.Name = "btnEmerald";
            this.btnEmerald.Size = new System.Drawing.Size(118, 56);
            this.btnEmerald.TabIndex = 0;
            this.btnEmerald.Text = "Emerald";
            this.btnEmerald.UseVisualStyleBackColor = true;
            // 
            // btnQuartz
            // 
            this.btnQuartz.Location = new System.Drawing.Point(12, 185);
            this.btnQuartz.Name = "btnQuartz";
            this.btnQuartz.Size = new System.Drawing.Size(118, 56);
            this.btnQuartz.TabIndex = 1;
            this.btnQuartz.Text = "Quartz";
            this.btnQuartz.UseVisualStyleBackColor = true;
            // 
            // btnBismuth
            // 
            this.btnBismuth.Location = new System.Drawing.Point(12, 247);
            this.btnBismuth.Name = "btnBismuth";
            this.btnBismuth.Size = new System.Drawing.Size(118, 56);
            this.btnBismuth.TabIndex = 2;
            this.btnBismuth.Text = "Bismuth";
            this.btnBismuth.UseVisualStyleBackColor = true;
            // 
            // btnBismuthBear
            // 
            this.btnBismuthBear.Location = new System.Drawing.Point(12, 309);
            this.btnBismuthBear.Name = "btnBismuthBear";
            this.btnBismuthBear.Size = new System.Drawing.Size(118, 56);
            this.btnBismuthBear.TabIndex = 3;
            this.btnBismuthBear.Text = "Bear?";
            this.btnBismuthBear.UseVisualStyleBackColor = true;
            // 
            // imgMineral
            // 
            this.imgMineral.Location = new System.Drawing.Point(325, 151);
            this.imgMineral.Name = "imgMineral";
            this.imgMineral.Size = new System.Drawing.Size(100, 50);
            this.imgMineral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMineral.TabIndex = 4;
            this.imgMineral.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 42);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Select a Mineral to View It";
            // 
            // FormAddingResourcesAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgMineral);
            this.Controls.Add(this.btnBismuthBear);
            this.Controls.Add(this.btnBismuth);
            this.Controls.Add(this.btnQuartz);
            this.Controls.Add(this.btnEmerald);
            this.Name = "FormAddingResourcesAssignment";
            this.Text = "Adding to Resources Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.imgMineral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmerald;
        private System.Windows.Forms.Button btnQuartz;
        private System.Windows.Forms.Button btnBismuth;
        private System.Windows.Forms.Button btnBismuthBear;
        private System.Windows.Forms.PictureBox imgMineral;
        private System.Windows.Forms.Label lblTitle;
    }
}

