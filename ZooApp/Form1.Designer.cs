
namespace ZooApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_eagles = new System.Windows.Forms.Button();
            this.btn_Parrots = new System.Windows.Forms.Button();
            this.btn_Clownfish = new System.Windows.Forms.Button();
            this.btn_Dolphins = new System.Windows.Forms.Button();
            this.btn_tigers = new System.Windows.Forms.Button();
            this.btn_lions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_eagles);
            this.groupBox1.Controls.Add(this.btn_Parrots);
            this.groupBox1.Controls.Add(this.btn_Clownfish);
            this.groupBox1.Controls.Add(this.btn_Dolphins);
            this.groupBox1.Controls.Add(this.btn_tigers);
            this.groupBox1.Controls.Add(this.btn_lions);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(51, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Sections";
            // 
            // btn_eagles
            // 
            this.btn_eagles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eagles.Image = ((System.Drawing.Image)(resources.GetObject("btn_eagles.Image")));
            this.btn_eagles.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_eagles.Location = new System.Drawing.Point(359, 172);
            this.btn_eagles.Name = "btn_eagles";
            this.btn_eagles.Size = new System.Drawing.Size(99, 30);
            this.btn_eagles.TabIndex = 5;
            this.btn_eagles.Text = "See Eagles";
            this.btn_eagles.UseVisualStyleBackColor = true;
            this.btn_eagles.Click += new System.EventHandler(this.btn_eagles_Click);
            // 
            // btn_Parrots
            // 
            this.btn_Parrots.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Parrots.Image = ((System.Drawing.Image)(resources.GetObject("btn_Parrots.Image")));
            this.btn_Parrots.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Parrots.Location = new System.Drawing.Point(359, 85);
            this.btn_Parrots.Name = "btn_Parrots";
            this.btn_Parrots.Size = new System.Drawing.Size(99, 30);
            this.btn_Parrots.TabIndex = 4;
            this.btn_Parrots.Text = "See Parrots";
            this.btn_Parrots.UseVisualStyleBackColor = true;
            this.btn_Parrots.Click += new System.EventHandler(this.btn_Parrots_Click);
            // 
            // btn_Clownfish
            // 
            this.btn_Clownfish.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clownfish.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clownfish.Image")));
            this.btn_Clownfish.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Clownfish.Location = new System.Drawing.Point(194, 172);
            this.btn_Clownfish.Name = "btn_Clownfish";
            this.btn_Clownfish.Size = new System.Drawing.Size(99, 30);
            this.btn_Clownfish.TabIndex = 3;
            this.btn_Clownfish.Text = "See Clownfish";
            this.btn_Clownfish.UseVisualStyleBackColor = true;
            this.btn_Clownfish.Click += new System.EventHandler(this.btn_Clownfish_Click);
            // 
            // btn_Dolphins
            // 
            this.btn_Dolphins.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dolphins.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dolphins.Image")));
            this.btn_Dolphins.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Dolphins.Location = new System.Drawing.Point(194, 85);
            this.btn_Dolphins.Name = "btn_Dolphins";
            this.btn_Dolphins.Size = new System.Drawing.Size(99, 30);
            this.btn_Dolphins.TabIndex = 2;
            this.btn_Dolphins.Text = "See Dolphins";
            this.btn_Dolphins.UseVisualStyleBackColor = true;
            this.btn_Dolphins.Click += new System.EventHandler(this.btn_Dolphins_Click);
            // 
            // btn_tigers
            // 
            this.btn_tigers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tigers.Image = ((System.Drawing.Image)(resources.GetObject("btn_tigers.Image")));
            this.btn_tigers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_tigers.Location = new System.Drawing.Point(32, 172);
            this.btn_tigers.Name = "btn_tigers";
            this.btn_tigers.Size = new System.Drawing.Size(99, 30);
            this.btn_tigers.TabIndex = 1;
            this.btn_tigers.Text = "See Tigers";
            this.btn_tigers.UseVisualStyleBackColor = true;
            this.btn_tigers.Click += new System.EventHandler(this.btn_tigers_Click);
            // 
            // btn_lions
            // 
            this.btn_lions.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lions.Image")));
            this.btn_lions.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_lions.Location = new System.Drawing.Point(32, 85);
            this.btn_lions.Name = "btn_lions";
            this.btn_lions.Size = new System.Drawing.Size(99, 30);
            this.btn_lions.TabIndex = 0;
            this.btn_lions.Text = "See Lions";
            this.btn_lions.UseVisualStyleBackColor = true;
            this.btn_lions.Click += new System.EventHandler(this.btn_lions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooApp.Properties.Resources.zoo;
            this.ClientSize = new System.Drawing.Size(617, 467);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Dolphins;
        private System.Windows.Forms.Button btn_tigers;
        private System.Windows.Forms.Button btn_lions;
        private System.Windows.Forms.Button btn_Clownfish;
        private System.Windows.Forms.Button btn_eagles;
        private System.Windows.Forms.Button btn_Parrots;
    }
}

