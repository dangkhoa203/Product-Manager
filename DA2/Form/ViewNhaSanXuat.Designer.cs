namespace DA2
{
    partial class ViewNhaSanXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVNhasanxuat = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tID = new System.Windows.Forms.TextBox();
            this.tten = new System.Windows.Forms.TextBox();
            this.tsdt = new System.Windows.Forms.TextBox();
            this.temail = new System.Windows.Forms.TextBox();
            this.tdiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bthem = new System.Windows.Forms.Button();
            this.Bxoa = new System.Windows.Forms.Button();
            this.Bsua = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lthoat = new System.Windows.Forms.Label();
            this.lw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhasanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVNhasanxuat
            // 
            this.DGVNhasanxuat.AllowUserToAddRows = false;
            this.DGVNhasanxuat.AllowUserToDeleteRows = false;
            this.DGVNhasanxuat.AllowUserToResizeColumns = false;
            this.DGVNhasanxuat.AllowUserToResizeRows = false;
            this.DGVNhasanxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNhasanxuat.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNhasanxuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVNhasanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNhasanxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.sdt,
            this.email,
            this.diachi});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNhasanxuat.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVNhasanxuat.EnableHeadersVisualStyles = false;
            this.DGVNhasanxuat.Location = new System.Drawing.Point(12, 387);
            this.DGVNhasanxuat.Name = "DGVNhasanxuat";
            this.DGVNhasanxuat.ReadOnly = true;
            this.DGVNhasanxuat.RowHeadersVisible = false;
            this.DGVNhasanxuat.RowHeadersWidth = 51;
            this.DGVNhasanxuat.RowTemplate.Height = 24;
            this.DGVNhasanxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNhasanxuat.ShowCellErrors = false;
            this.DGVNhasanxuat.ShowCellToolTips = false;
            this.DGVNhasanxuat.ShowEditingIcon = false;
            this.DGVNhasanxuat.ShowRowErrors = false;
            this.DGVNhasanxuat.Size = new System.Drawing.Size(1170, 266);
            this.DGVNhasanxuat.TabIndex = 0;
            this.DGVNhasanxuat.TabStop = false;
            this.DGVNhasanxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhasanxuat_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID nhà sản xuất";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên nhà sản xuất";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email nhà sản xuất";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ nhà sản xuất";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(304, 97);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(412, 29);
            this.tID.TabIndex = 1;
            this.tID.TextChanged += new System.EventHandler(this.tID_TextChanged);
            // 
            // tten
            // 
            this.tten.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tten.Location = new System.Drawing.Point(304, 146);
            this.tten.Name = "tten";
            this.tten.Size = new System.Drawing.Size(412, 29);
            this.tten.TabIndex = 2;
            // 
            // tsdt
            // 
            this.tsdt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsdt.Location = new System.Drawing.Point(304, 196);
            this.tsdt.Name = "tsdt";
            this.tsdt.Size = new System.Drawing.Size(412, 29);
            this.tsdt.TabIndex = 3;
            // 
            // temail
            // 
            this.temail.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temail.Location = new System.Drawing.Point(304, 253);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(412, 29);
            this.temail.TabIndex = 4;
            // 
            // tdiachi
            // 
            this.tdiachi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdiachi.Location = new System.Drawing.Point(304, 309);
            this.tdiachi.Name = "tdiachi";
            this.tdiachi.Size = new System.Drawing.Size(412, 29);
            this.tdiachi.TabIndex = 5;
            this.tdiachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdiachi_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID nhà sản xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên nhà sản xuất";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bthem
            // 
            this.Bthem.BackColor = System.Drawing.Color.GreenYellow;
            this.Bthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bthem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bthem.Location = new System.Drawing.Point(905, 74);
            this.Bthem.Name = "Bthem";
            this.Bthem.Size = new System.Drawing.Size(239, 43);
            this.Bthem.TabIndex = 6;
            this.Bthem.TabStop = false;
            this.Bthem.Text = "Thêm";
            this.Bthem.UseVisualStyleBackColor = false;
            this.Bthem.Click += new System.EventHandler(this.Bthem_Click);
            // 
            // Bxoa
            // 
            this.Bxoa.BackColor = System.Drawing.Color.DarkRed;
            this.Bxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bxoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bxoa.Location = new System.Drawing.Point(905, 132);
            this.Bxoa.Name = "Bxoa";
            this.Bxoa.Size = new System.Drawing.Size(239, 43);
            this.Bxoa.TabIndex = 7;
            this.Bxoa.TabStop = false;
            this.Bxoa.Text = "Xóa";
            this.Bxoa.UseVisualStyleBackColor = false;
            this.Bxoa.Click += new System.EventHandler(this.Bxoa_Click);
            // 
            // Bsua
            // 
            this.Bsua.BackColor = System.Drawing.Color.LightGray;
            this.Bsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsua.Location = new System.Drawing.Point(905, 196);
            this.Bsua.Name = "Bsua";
            this.Bsua.Size = new System.Drawing.Size(239, 43);
            this.Bsua.TabIndex = 8;
            this.Bsua.TabStop = false;
            this.Bsua.Text = "Sửa";
            this.Bsua.UseVisualStyleBackColor = false;
            this.Bsua.Click += new System.EventHandler(this.Bsua_Click);
            // 
            // Bsave
            // 
            this.Bsave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsave.Location = new System.Drawing.Point(905, 267);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(239, 43);
            this.Bsave.TabIndex = 9;
            this.Bsave.TabStop = false;
            this.Bsave.Text = "Save";
            this.Bsave.UseVisualStyleBackColor = false;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // tsearch
            // 
            this.tsearch.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearch.Location = new System.Drawing.Point(1048, 358);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(134, 23);
            this.tsearch.TabIndex = 10;
            this.tsearch.TextChanged += new System.EventHandler(this.tsearch_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(884, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search theo tên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1194, 40);
            this.label6.TabIndex = 39;
            this.label6.Text = "QUẢN LÝ NHÀ SẢN XUẤT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lthoat
            // 
            this.lthoat.AutoSize = true;
            this.lthoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lthoat.ForeColor = System.Drawing.Color.Red;
            this.lthoat.Location = new System.Drawing.Point(12, 49);
            this.lthoat.Name = "lthoat";
            this.lthoat.Size = new System.Drawing.Size(67, 24);
            this.lthoat.TabIndex = 40;
            this.lthoat.Text = "Thoát";
            this.lthoat.Click += new System.EventHandler(this.lthoat_Click);
            // 
            // lw
            // 
            this.lw.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lw.ForeColor = System.Drawing.Color.Red;
            this.lw.Location = new System.Drawing.Point(722, 88);
            this.lw.Name = "lw";
            this.lw.Size = new System.Drawing.Size(159, 49);
            this.lw.TabIndex = 41;
            this.lw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewNhaSanXuat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1194, 654);
            this.Controls.Add(this.lw);
            this.Controls.Add(this.lthoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.Bsave);
            this.Controls.Add(this.Bsua);
            this.Controls.Add(this.Bxoa);
            this.Controls.Add(this.Bthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdiachi);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.tsdt);
            this.Controls.Add(this.tten);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.DGVNhasanxuat);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ViewNhaSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sản xuất";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNhaSanXuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhasanxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVNhasanxuat;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.TextBox tten;
        private System.Windows.Forms.TextBox tsdt;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tdiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bthem;
        private System.Windows.Forms.Button Bxoa;
        private System.Windows.Forms.Button Bsua;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Label lw;
    }
}

