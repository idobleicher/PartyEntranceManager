namespace Managing
{
    partial class Managing
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.TextBox();
            this.Rent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FileUpload = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.updateFields = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.עדכן = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(854, 321);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(240, 23);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "מחק את הנבחר";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(926, 283);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(168, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "הוספה";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsersGrid
            // 
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(57, 55);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.RowTemplate.Height = 24;
            this.UsersGrid.Size = new System.Drawing.Size(726, 421);
            this.UsersGrid.TabIndex = 2;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(926, 153);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(168, 22);
            this.fullName.TabIndex = 3;
            // 
            // Rent
            // 
            this.Rent.Location = new System.Drawing.Point(926, 238);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(168, 22);
            this.Rent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "שם מלא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1085, 205);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "שכר";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            this.OpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FileUpload
            // 
            this.FileUpload.Location = new System.Drawing.Point(877, 55);
            this.FileUpload.Name = "FileUpload";
            this.FileUpload.Size = new System.Drawing.Size(217, 23);
            this.FileUpload.TabIndex = 5;
            this.FileUpload.Text = "עלה רשימה של יחצנים";
            this.FileUpload.UseVisualStyleBackColor = true;
            this.FileUpload.Click += new System.EventHandler(this.FileUpload_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(917, 402);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // updateFields
            // 
            this.updateFields.Location = new System.Drawing.Point(801, 453);
            this.updateFields.Name = "updateFields";
            this.updateFields.Size = new System.Drawing.Size(312, 23);
            this.updateFields.TabIndex = 1;
            this.updateFields.Text = "עדכן את השכר של הנבחר/או אחוזי בקבוק";
            this.updateFields.UseVisualStyleBackColor = true;
            this.updateFields.Click += new System.EventHandler(this.updateFields_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1035, 369);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "עדכן שכר";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1035, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 369);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "אחוזי בקבוק עדכון";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // עדכן
            // 
            this.עדכן.Location = new System.Drawing.Point(1019, 88);
            this.עדכן.Name = "עדכן";
            this.עדכן.Size = new System.Drawing.Size(75, 23);
            this.עדכן.TabIndex = 6;
            this.עדכן.Text = "עדכן";
            this.עדכן.UseVisualStyleBackColor = true;
            this.עדכן.Click += new System.EventHandler(this.עדכן_Click);
            // 
            // Managing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 511);
            this.Controls.Add(this.עדכן);
            this.Controls.Add(this.FileUpload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.UsersGrid);
            this.Controls.Add(this.updateFields);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_del);
            this.Name = "Managing";
            this.Text = "ניהול";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox Rent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button FileUpload;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button updateFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button עדכן;
    }
}

