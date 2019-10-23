namespace UCL_OOP_I
{
    partial class Trash_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trash_register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clsbtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_user = new System.Windows.Forms.TextBox();
            this.trash_weight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTrashType = new System.Windows.Forms.ComboBox();
            this.recycle_button = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qualitybox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clsbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycle_button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(197)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 45);
            this.panel1.TabIndex = 0;
            // 
            // clsbtn
            // 
            this.clsbtn.Image = ((System.Drawing.Image)(resources.GetObject("clsbtn.Image")));
            this.clsbtn.Location = new System.Drawing.Point(327, 1);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(25, 18);
            this.clsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clsbtn.TabIndex = 1;
            this.clsbtn.TabStop = false;
            this.clsbtn.Click += new System.EventHandler(this.Clsbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente Id";
            // 
            // id_user
            // 
            this.id_user.Location = new System.Drawing.Point(178, 60);
            this.id_user.Name = "id_user";
            this.id_user.Size = new System.Drawing.Size(121, 20);
            this.id_user.TabIndex = 3;
            // 
            // trash_weight
            // 
            this.trash_weight.Location = new System.Drawing.Point(178, 102);
            this.trash_weight.Name = "trash_weight";
            this.trash_weight.Size = new System.Drawing.Size(121, 20);
            this.trash_weight.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trash Weight (Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trash Type";
            // 
            // comboBoxTrashType
            // 
            this.comboBoxTrashType.FormattingEnabled = true;
            this.comboBoxTrashType.Location = new System.Drawing.Point(178, 154);
            this.comboBoxTrashType.Name = "comboBoxTrashType";
            this.comboBoxTrashType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrashType.TabIndex = 7;
            this.comboBoxTrashType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTrashType_SelectedIndexChanged);
            // 
            // recycle_button
            // 
            this.recycle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recycle_button.Image = ((System.Drawing.Image)(resources.GetObject("recycle_button.Image")));
            this.recycle_button.Location = new System.Drawing.Point(118, 293);
            this.recycle_button.Name = "recycle_button";
            this.recycle_button.Size = new System.Drawing.Size(100, 50);
            this.recycle_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recycle_button.TabIndex = 0;
            this.recycle_button.TabStop = false;
            this.recycle_button.Click += new System.EventHandler(this.Recycle_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(101, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "RECYCLE";
            // 
            // qualitybox
            // 
            this.qualitybox.FormattingEnabled = true;
            this.qualitybox.Location = new System.Drawing.Point(178, 228);
            this.qualitybox.Name = "qualitybox";
            this.qualitybox.Size = new System.Drawing.Size(121, 21);
            this.qualitybox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(50, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trash Quality";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(50, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trash Item";
            // 
            // Trash_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.qualitybox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recycle_button);
            this.Controls.Add(this.comboBoxTrashType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trash_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trash_register";
            this.Text = "Trash_register";
            ((System.ComponentModel.ISupportInitialize)(this.clsbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycle_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox clsbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_user;
        private System.Windows.Forms.TextBox trash_weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTrashType;
        private System.Windows.Forms.PictureBox recycle_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox qualitybox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}