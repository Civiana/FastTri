namespace FastTri
{
    partial class Form1
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
            this.btnYY = new System.Windows.Forms.Button();
            this.btnZZ = new System.Windows.Forms.Button();
            this.btnDD = new System.Windows.Forms.Button();
            this.btnNN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYY
            // 
            this.btnYY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYY.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYY.Location = new System.Drawing.Point(36, 209);
            this.btnYY.MaximumSize = new System.Drawing.Size(170, 70);
            this.btnYY.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnYY.Name = "btnYY";
            this.btnYY.Size = new System.Drawing.Size(170, 50);
            this.btnYY.TabIndex = 0;
            this.btnYY.Text = "YY";
            this.btnYY.UseVisualStyleBackColor = true;
            this.btnYY.Click += new System.EventHandler(this.btnYY_Click);
            // 
            // btnZZ
            // 
            this.btnZZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZZ.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZZ.Location = new System.Drawing.Point(609, 209);
            this.btnZZ.MaximumSize = new System.Drawing.Size(170, 60);
            this.btnZZ.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnZZ.Name = "btnZZ";
            this.btnZZ.Size = new System.Drawing.Size(170, 50);
            this.btnZZ.TabIndex = 1;
            this.btnZZ.Text = "ZZ";
            this.btnZZ.UseVisualStyleBackColor = true;
            this.btnZZ.Click += new System.EventHandler(this.btnZZ_Click);
            // 
            // btnDD
            // 
            this.btnDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDD.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDD.Location = new System.Drawing.Point(233, 209);
            this.btnDD.MaximumSize = new System.Drawing.Size(170, 60);
            this.btnDD.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(170, 50);
            this.btnDD.TabIndex = 2;
            this.btnDD.Text = "DD";
            this.btnDD.UseVisualStyleBackColor = true;
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // btnNN
            // 
            this.btnNN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNN.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNN.Location = new System.Drawing.Point(425, 209);
            this.btnNN.MaximumSize = new System.Drawing.Size(170, 60);
            this.btnNN.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnNN.Name = "btnNN";
            this.btnNN.Size = new System.Drawing.Size(170, 50);
            this.btnNN.TabIndex = 3;
            this.btnNN.Text = "NN";
            this.btnNN.UseVisualStyleBackColor = true;
            this.btnNN.Click += new System.EventHandler(this.btnNN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.btnNN);
            this.Controls.Add(this.btnDD);
            this.Controls.Add(this.btnZZ);
            this.Controls.Add(this.btnYY);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYY;
        private System.Windows.Forms.Button btnZZ;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Button btnNN;
    }
}

