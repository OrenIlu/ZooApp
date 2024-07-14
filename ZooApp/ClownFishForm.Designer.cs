
namespace ZooApp
{
    partial class ClownFishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClownFishForm));
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
            this.btnShow = new System.Windows.Forms.Button();
            this.chkHasTracker = new System.Windows.Forms.CheckBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.comboxWaterType = new System.Windows.Forms.ComboBox();
            this.chkIsNemo = new System.Windows.Forms.CheckBox();
            this.comboxSpecies = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::ZooApp.Properties.Resources.Ephippium_Clownfish;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(211, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 30);
            this.label2.TabIndex = 73;
            this.label2.Text = "Welcome to the ClownFish Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Water Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Species";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(52, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 23);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Add.Location = new System.Drawing.Point(235, 373);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 23);
            this.btn_Add.TabIndex = 61;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(414, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(617, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(139, 71);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(204, 20);
            this.txbxName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(415, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 238);
            this.listBox1.TabIndex = 56;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShow.Location = new System.Drawing.Point(511, 314);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 23);
            this.btnShow.TabIndex = 74;
            this.btnShow.Text = "Show Picture";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chkHasTracker
            // 
            this.chkHasTracker.AutoSize = true;
            this.chkHasTracker.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasTracker.Location = new System.Drawing.Point(52, 155);
            this.chkHasTracker.Name = "chkHasTracker";
            this.chkHasTracker.Size = new System.Drawing.Size(213, 25);
            this.chkHasTracker.TabIndex = 76;
            this.chkHasTracker.Text = "Does It Have a Tracker?";
            this.chkHasTracker.UseVisualStyleBackColor = true;
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(104, 113);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(45, 20);
            this.numericAge.TabIndex = 77;
            // 
            // comboxWaterType
            // 
            this.comboxWaterType.FormattingEnabled = true;
            this.comboxWaterType.Items.AddRange(new object[] {
            "Salted",
            "Sweet",
            "Mixed"});
            this.comboxWaterType.Location = new System.Drawing.Point(166, 204);
            this.comboxWaterType.Name = "comboxWaterType";
            this.comboxWaterType.Size = new System.Drawing.Size(121, 21);
            this.comboxWaterType.TabIndex = 78;
            // 
            // chkIsNemo
            // 
            this.chkIsNemo.AutoSize = true;
            this.chkIsNemo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsNemo.Location = new System.Drawing.Point(52, 254);
            this.chkIsNemo.Name = "chkIsNemo";
            this.chkIsNemo.Size = new System.Drawing.Size(121, 25);
            this.chkIsNemo.TabIndex = 79;
            this.chkIsNemo.Text = "Is It Nemo?";
            this.chkIsNemo.UseVisualStyleBackColor = true;
            // 
            // comboxSpecies
            // 
            this.comboxSpecies.FormattingEnabled = true;
            this.comboxSpecies.Items.AddRange(new object[] {
            "Common",
            "Ephippium",
            "Latezonatus",
            "Sandaracinos"});
            this.comboxSpecies.Location = new System.Drawing.Point(130, 313);
            this.comboxSpecies.Name = "comboxSpecies";
            this.comboxSpecies.Size = new System.Drawing.Size(121, 21);
            this.comboxSpecies.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ZooApp.Properties.Resources.Sound_Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(720, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // ClownFishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooApp.Properties.Resources.ClownFish_bkg;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboxSpecies);
            this.Controls.Add(this.chkIsNemo);
            this.Controls.Add(this.comboxWaterType);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.chkHasTracker);
            this.Controls.Add(this.btnShow);
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
            this.Name = "ClownFishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClownFishForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox chkHasTracker;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.ComboBox comboxWaterType;
        private System.Windows.Forms.CheckBox chkIsNemo;
        private System.Windows.Forms.ComboBox comboxSpecies;
        private System.Windows.Forms.Button button1;
    }
}