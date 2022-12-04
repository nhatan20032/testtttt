﻿namespace _3.PL.View
{
    partial class FrmHoaDon
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
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_hdct = new System.Windows.Forms.DataGridView();
            this.IDCTSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrid_hoadon = new System.Windows.Forms.DataGridView();
            this.btn_Them = new _3.PL.Custom.AnButtons();
            this.anButtons2 = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TK.Location = new System.Drawing.Point(11, 61);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(288, 29);
            this.txt_TK.TabIndex = 18;
            this.txt_TK.Text = "Tìm kiếm hóa đơn...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hóa đơn chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hóa đơn";
            // 
            // dgrid_hdct
            // 
            this.dgrid_hdct.BackgroundColor = System.Drawing.Color.Tomato;
            this.dgrid_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hdct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCTSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia});
            this.dgrid_hdct.Location = new System.Drawing.Point(8, 287);
            this.dgrid_hdct.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_hdct.Name = "dgrid_hdct";
            this.dgrid_hdct.RowHeadersWidth = 62;
            this.dgrid_hdct.RowTemplate.Height = 33;
            this.dgrid_hdct.Size = new System.Drawing.Size(797, 139);
            this.dgrid_hdct.TabIndex = 15;
            // 
            // IDCTSP
            // 
            this.IDCTSP.HeaderText = "ID";
            this.IDCTSP.Name = "IDCTSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "TenSP";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            // 
            // dgrid_hoadon
            // 
            this.dgrid_hoadon.BackgroundColor = System.Drawing.Color.Tomato;
            this.dgrid_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadon.Location = new System.Drawing.Point(11, 101);
            this.dgrid_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_hoadon.Name = "dgrid_hoadon";
            this.dgrid_hoadon.RowHeadersWidth = 62;
            this.dgrid_hoadon.RowTemplate.Height = 33;
            this.dgrid_hoadon.Size = new System.Drawing.Size(797, 150);
            this.dgrid_hoadon.TabIndex = 14;
            this.dgrid_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_hoadon_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Them.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::_3.PL.Properties.Resources.member1;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(319, 58);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(137, 35);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Tìm kiếm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_TIMKIEM_Click);
            // 
            // anButtons2
            // 
            this.anButtons2.BackColor = System.Drawing.Color.OrangeRed;
            this.anButtons2.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.anButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons2.BorderRadius = 20;
            this.anButtons2.BorderSize = 0;
            this.anButtons2.FlatAppearance.BorderSize = 0;
            this.anButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons2.ForeColor = System.Drawing.Color.White;
            this.anButtons2.Image = global::_3.PL.Properties.Resources.delete;
            this.anButtons2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anButtons2.Location = new System.Drawing.Point(678, 61);
            this.anButtons2.Name = "anButtons2";
            this.anButtons2.Size = new System.Drawing.Size(122, 32);
            this.anButtons2.TabIndex = 22;
            this.anButtons2.Text = "Xóa";
            this.anButtons2.TextColor = System.Drawing.Color.White;
            this.anButtons2.UseVisualStyleBackColor = false;
            this.anButtons2.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.anButtons2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_hdct);
            this.Controls.Add(this.dgrid_hoadon);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_hdct;
        private System.Windows.Forms.DataGridView dgrid_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private Custom.AnButtons btn_Them;
        private Custom.AnButtons anButtons2;
    }
}