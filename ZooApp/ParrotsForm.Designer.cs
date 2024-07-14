
namespace ZooApp
{
    partial class ParrotsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParrotsForm));
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
            this.chkCanFly = new System.Windows.Forms.CheckBox();
            this.comboxDiet = new System.Windows.Forms.ComboBox();
            this.chkCanSpeak = new System.Windows.Forms.CheckBox();
            this.comboxColor = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = global::ZooApp.Properties.Resources.Oriental_Lion;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(211, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 30);
            this.label2.TabIndex = 91;
            this.label2.Text = "Welcome to the Parrots Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 89;
            this.label7.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "Diet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Color";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(55, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 23);
            this.btnClear.TabIndex = 80;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Add.Location = new System.Drawing.Point(235, 390);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 23);
            this.btn_Add.TabIndex = 79;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(414, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(617, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbxName
            // 
            this.txbxName.Location = new System.Drawing.Point(117, 72);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(204, 20);
            this.txbxName.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 75;
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
            this.listBox1.TabIndex = 74;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(103, 114);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(45, 20);
            this.numericAge.TabIndex = 92;
            // 
            // chkCanFly
            // 
            this.chkCanFly.AutoSize = true;
            this.chkCanFly.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkCanFly.Location = new System.Drawing.Point(52, 156);
            this.chkCanFly.Name = "chkCanFly";
            this.chkCanFly.Size = new System.Drawing.Size(112, 25);
            this.chkCanFly.TabIndex = 93;
            this.chkCanFly.Text = "Can It Fly?";
            this.chkCanFly.UseVisualStyleBackColor = true;
            // 
            // comboxDiet
            // 
            this.comboxDiet.FormattingEnabled = true;
            this.comboxDiet.Items.AddRange(new object[] {
            "Seeds",
            "Worms",
            "Fruits",
            "Fish"});
            this.comboxDiet.Location = new System.Drawing.Point(103, 207);
            this.comboxDiet.Name = "comboxDiet";
            this.comboxDiet.Size = new System.Drawing.Size(121, 21);
            this.comboxDiet.TabIndex = 94;
            // 
            // chkCanSpeak
            // 
            this.chkCanSpeak.AutoSize = true;
            this.chkCanSpeak.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkCanSpeak.Location = new System.Drawing.Point(51, 254);
            this.chkCanSpeak.Name = "chkCanSpeak";
            this.chkCanSpeak.Size = new System.Drawing.Size(133, 25);
            this.chkCanSpeak.TabIndex = 95;
            this.chkCanSpeak.Text = "Can It Speak?";
            this.chkCanSpeak.UseVisualStyleBackColor = true;
            // 
            // comboxColor
            // 
            this.comboxColor.FormattingEnabled = true;
            this.comboxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black"});
            this.comboxColor.Location = new System.Drawing.Point(117, 303);
            this.comboxColor.Name = "comboxColor";
            this.comboxColor.Size = new System.Drawing.Size(121, 21);
            this.comboxColor.TabIndex = 96;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.SystemColors.Window;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShow.Location = new System.Drawing.Point(511, 314);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 23);
            this.btnShow.TabIndex = 97;
            this.btnShow.Text = "Show Picture";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ZooApp.Properties.Resources.Sound_Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(719, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 98;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // ParrotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.comboxColor);
            this.Controls.Add(this.chkCanSpeak);
            this.Controls.Add(this.comboxDiet);
            this.Controls.Add(this.chkCanFly);
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
            this.Name = "ParrotsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParrotForm";
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
        private System.Windows.Forms.CheckBox chkCanFly;
        private System.Windows.Forms.ComboBox comboxDiet;
        private System.Windows.Forms.CheckBox chkCanSpeak;
        private System.Windows.Forms.ComboBox comboxColor;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button button1;
    }
}