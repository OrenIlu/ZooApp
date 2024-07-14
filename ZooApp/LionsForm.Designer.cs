
namespace ZooApp
{
    partial class LionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LionsForm));
            this.chkHasOffspring = new System.Windows.Forms.CheckBox();
            this.comboxRegion = new System.Windows.Forms.ComboBox();
            this.chkIsKing = new System.Windows.Forms.CheckBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericManeLength = new System.Windows.Forms.NumericUpDown();
            this.btnShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericManeLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chkHasOffspring
            // 
            this.chkHasOffspring.AutoSize = true;
            this.chkHasOffspring.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasOffspring.Location = new System.Drawing.Point(55, 157);
            this.chkHasOffspring.Name = "chkHasOffspring";
            this.chkHasOffspring.Size = new System.Drawing.Size(204, 25);
            this.chkHasOffspring.TabIndex = 76;
            this.chkHasOffspring.Text = "Does It Has Offspring?";
            this.chkHasOffspring.UseVisualStyleBackColor = true;
            // 
            // comboxRegion
            // 
            this.comboxRegion.FormattingEnabled = true;
            this.comboxRegion.Items.AddRange(new object[] {
            "Nearctic",
            "Neotropical",
            "African",
            "Palearctic",
            "Oriental"});
            this.comboxRegion.Location = new System.Drawing.Point(138, 210);
            this.comboxRegion.Name = "comboxRegion";
            this.comboxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboxRegion.TabIndex = 74;
            // 
            // chkIsKing
            // 
            this.chkIsKing.AutoSize = true;
            this.chkIsKing.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsKing.Location = new System.Drawing.Point(52, 258);
            this.chkIsKing.Name = "chkIsKing";
            this.chkIsKing.Size = new System.Drawing.Size(221, 25);
            this.chkIsKing.TabIndex = 73;
            this.chkIsKing.Text = "Is It King Of the Jungle?";
            this.chkIsKing.UseVisualStyleBackColor = true;
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(108, 115);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(45, 20);
            this.numericAge.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Image = global::ZooApp.Properties.Resources.Common_Clownfish;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(211, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 30);
            this.label2.TabIndex = 71;
            this.label2.Text = "Welcome to the Lions Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 69;
            this.label5.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Mane Length (cm.)";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(55, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 23);
            this.btnClear.TabIndex = 67;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(235, 373);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 23);
            this.btn_Add.TabIndex = 66;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(414, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(617, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(126, 74);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(204, 20);
            this.txbxName.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(414, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 238);
            this.listBox1.TabIndex = 61;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericManeLength
            // 
            this.numericManeLength.Location = new System.Drawing.Point(214, 313);
            this.numericManeLength.Name = "numericManeLength";
            this.numericManeLength.Size = new System.Drawing.Size(45, 20);
            this.numericManeLength.TabIndex = 77;
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShow.Location = new System.Drawing.Point(511, 314);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 23);
            this.btnShow.TabIndex = 78;
            this.btnShow.Text = "Show Picture";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ZooApp.Properties.Resources.Sound_Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(719, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 79;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // LionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.numericManeLength);
            this.Controls.Add(this.chkHasOffspring);
            this.Controls.Add(this.comboxRegion);
            this.Controls.Add(this.chkIsKing);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericManeLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHasOffspring;
        private System.Windows.Forms.ComboBox comboxRegion;
        private System.Windows.Forms.CheckBox chkIsKing;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericManeLength;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button button1;
    }
}