
namespace ZooApp
{
    partial class DolphinsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DolphinsForm));
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
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.chkIsTrained = new System.Windows.Forms.CheckBox();
            this.comboxWaterType = new System.Windows.Forms.ComboBox();
            this.comboxColor = new System.Windows.Forms.ComboBox();
            this.chkHasTracker = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Image = global::ZooApp.Properties.Resources.Lion_bkg;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(211, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 30);
            this.label2.TabIndex = 55;
            this.label2.Text = "Welcome to the Dolphins Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Water Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Color";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(55, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(235, 373);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 23);
            this.btn_Add.TabIndex = 43;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(414, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(617, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(126, 74);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(204, 20);
            this.txbxName.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 39;
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
            this.listBox1.TabIndex = 38;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(108, 115);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(45, 20);
            this.numericAge.TabIndex = 56;
            // 
            // chkIsTrained
            // 
            this.chkIsTrained.AutoSize = true;
            this.chkIsTrained.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsTrained.Location = new System.Drawing.Point(55, 252);
            this.chkIsTrained.Name = "chkIsTrained";
            this.chkIsTrained.Size = new System.Drawing.Size(135, 25);
            this.chkIsTrained.TabIndex = 57;
            this.chkIsTrained.Text = "Is It Trained?";
            this.chkIsTrained.UseVisualStyleBackColor = true;
            // 
            // comboxWaterType
            // 
            this.comboxWaterType.FormattingEnabled = true;
            this.comboxWaterType.Items.AddRange(new object[] {
            "Salted",
            "Sweet",
            "Mixed"});
            this.comboxWaterType.Location = new System.Drawing.Point(163, 207);
            this.comboxWaterType.Name = "comboxWaterType";
            this.comboxWaterType.Size = new System.Drawing.Size(121, 21);
            this.comboxWaterType.TabIndex = 58;
            // 
            // comboxColor
            // 
            this.comboxColor.FormattingEnabled = true;
            this.comboxColor.Items.AddRange(new object[] {
            "Grey",
            "White",
            "Black",
            "Pink"});
            this.comboxColor.Location = new System.Drawing.Point(108, 310);
            this.comboxColor.Name = "comboxColor";
            this.comboxColor.Size = new System.Drawing.Size(121, 21);
            this.comboxColor.TabIndex = 59;
            // 
            // chkHasTracker
            // 
            this.chkHasTracker.AutoSize = true;
            this.chkHasTracker.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasTracker.Location = new System.Drawing.Point(55, 156);
            this.chkHasTracker.Name = "chkHasTracker";
            this.chkHasTracker.Size = new System.Drawing.Size(213, 25);
            this.chkHasTracker.TabIndex = 60;
            this.chkHasTracker.Text = "Does It Have a Tracker?";
            this.chkHasTracker.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShow.Location = new System.Drawing.Point(511, 314);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 23);
            this.btnShow.TabIndex = 75;
            this.btnShow.Text = "Show Picture";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ZooApp.Properties.Resources.Sound_Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(719, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 80;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // DolphinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooApp.Properties.Resources.Dolphin_bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkHasTracker);
            this.Controls.Add(this.comboxColor);
            this.Controls.Add(this.comboxWaterType);
            this.Controls.Add(this.chkIsTrained);
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
            this.Name = "DolphinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolphinForm";
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
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.CheckBox chkIsTrained;
        private System.Windows.Forms.ComboBox comboxWaterType;
        private System.Windows.Forms.ComboBox comboxColor;
        private System.Windows.Forms.CheckBox chkHasTracker;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button button1;
    }
}