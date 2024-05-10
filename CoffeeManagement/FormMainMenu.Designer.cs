﻿namespace CoffeeManagement
{
    partial class FormMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ChangeInfo = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Table = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(309, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 94);
            this.panel1.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Freestyle Script", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(380, 9);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(193, 71);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "H O M E";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(309, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 567);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CoffeeManagement.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_ChangeInfo);
            this.panel3.Controls.Add(this.btn_LogOut);
            this.panel3.Controls.Add(this.btn_Admin);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_Table);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 661);
            this.panel3.TabIndex = 1;
            // 
            // btn_ChangeInfo
            // 
            this.btn_ChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChangeInfo.FlatAppearance.BorderSize = 0;
            this.btn_ChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeInfo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeInfo.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeInfo.Image = global::CoffeeManagement.Properties.Resources.icons8_info_32;
            this.btn_ChangeInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangeInfo.Location = new System.Drawing.Point(0, 403);
            this.btn_ChangeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChangeInfo.Name = "btn_ChangeInfo";
            this.btn_ChangeInfo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_ChangeInfo.Size = new System.Drawing.Size(309, 103);
            this.btn_ChangeInfo.TabIndex = 9;
            this.btn_ChangeInfo.Text = "       Change Info";
            this.btn_ChangeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangeInfo.UseVisualStyleBackColor = true;
            this.btn_ChangeInfo.Click += new System.EventHandler(this.btn_ChangeInfo_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Black;
            this.btn_LogOut.Image = global::CoffeeManagement.Properties.Resources.icons8_logout_32;
            this.btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 300);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_LogOut.Size = new System.Drawing.Size(309, 103);
            this.btn_LogOut.TabIndex = 8;
            this.btn_LogOut.Text = "       Log Out";
            this.btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.Black;
            this.btn_Admin.Image = global::CoffeeManagement.Properties.Resources.icons8_admin_settings_male_32;
            this.btn_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.Location = new System.Drawing.Point(0, 197);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_Admin.Size = new System.Drawing.Size(309, 103);
            this.btn_Admin.TabIndex = 7;
            this.btn_Admin.Text = "         Admin";
            this.btn_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(256, 103);
            this.button1.TabIndex = 7;
            this.button1.Text = "         Combo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Table
            // 
            this.btn_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Table.FlatAppearance.BorderSize = 0;
            this.btn_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table.ForeColor = System.Drawing.Color.Black;
            this.btn_Table.Image = global::CoffeeManagement.Properties.Resources.icons8_coffee_32;
            this.btn_Table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Table.Location = new System.Drawing.Point(0, 94);
            this.btn_Table.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_Table.Size = new System.Drawing.Size(309, 103);
            this.btn_Table.TabIndex = 6;
            this.btn_Table.Text = "         Table";
            this.btn_Table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Table.UseVisualStyleBackColor = true;
            this.btn_Table.Click += new System.EventHandler(this.btn_Table_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 94);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PBL3 Coffee Shop";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ChangeInfo;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Table;
    }
}