namespace CostomerManagement
{
    partial class CostomerForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_costomer = new System.Windows.Forms.TabControl();
            this.tb_costomerInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_costomerLookup = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_costomerInsert = new System.Windows.Forms.Button();
            this.btn_costomerDelete = new System.Windows.Forms.Button();
            this.btn_costomer = new System.Windows.Forms.Button();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rental = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_lentalLookup = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_rentalLookup = new System.Windows.Forms.Button();
            this.tb_repair = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_manufacture = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_bycicle = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tb_part = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_lookupRepair = new System.Windows.Forms.Button();
            this.btn_LookupManufacture = new System.Windows.Forms.Button();
            this.btn_LookupBycicle = new System.Windows.Forms.Button();
            this.btn_LookupPart = new System.Windows.Forms.Button();
            this.btn_DeleteManufacture = new System.Windows.Forms.Button();
            this.btn_DeleteBycicle = new System.Windows.Forms.Button();
            this.btn_DeletePart = new System.Windows.Forms.Button();
            this.btn_InsertRepair = new System.Windows.Forms.Button();
            this.btn_InsertManufacture = new System.Windows.Forms.Button();
            this.btn_InsertBycicle = new System.Windows.Forms.Button();
            this.btn_InsertPart = new System.Windows.Forms.Button();
            this.dataGridView_repair = new System.Windows.Forms.DataGridView();
            this.dataGridView_Manufacture = new System.Windows.Forms.DataGridView();
            this.dataGridView_Bycicle = new System.Windows.Forms.DataGridView();
            this.dataGridView_Part = new System.Windows.Forms.DataGridView();
            this.tc_costomer.SuspendLayout();
            this.tb_costomerInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_costomerLookup)).BeginInit();
            this.panel1.SuspendLayout();
            this.tb_rental.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lentalLookup)).BeginInit();
            this.panel3.SuspendLayout();
            this.tb_repair.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tb_manufacture.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tb_bycicle.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tb_part.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_repair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manufacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bycicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Part)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_costomer
            // 
            this.tc_costomer.Controls.Add(this.tb_costomerInfo);
            this.tc_costomer.Controls.Add(this.tb_rental);
            this.tc_costomer.Controls.Add(this.tb_repair);
            this.tc_costomer.Controls.Add(this.tb_manufacture);
            this.tc_costomer.Controls.Add(this.tb_bycicle);
            this.tc_costomer.Controls.Add(this.tb_part);
            this.tc_costomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_costomer.ItemSize = new System.Drawing.Size(108, 30);
            this.tc_costomer.Location = new System.Drawing.Point(0, 0);
            this.tc_costomer.Name = "tc_costomer";
            this.tc_costomer.SelectedIndex = 0;
            this.tc_costomer.Size = new System.Drawing.Size(1830, 907);
            this.tc_costomer.TabIndex = 0;
            // 
            // tb_costomerInfo
            // 
            this.tb_costomerInfo.Controls.Add(this.panel2);
            this.tb_costomerInfo.Controls.Add(this.panel1);
            this.tb_costomerInfo.Location = new System.Drawing.Point(8, 38);
            this.tb_costomerInfo.Name = "tb_costomerInfo";
            this.tb_costomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_costomerInfo.Size = new System.Drawing.Size(1814, 861);
            this.tb_costomerInfo.TabIndex = 0;
            this.tb_costomerInfo.Text = "고객정보";
            this.tb_costomerInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView_costomerLookup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1808, 783);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_costomerLookup
            // 
            this.dataGridView_costomerLookup.AllowUserToAddRows = false;
            this.dataGridView_costomerLookup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_costomerLookup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_costomerLookup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_costomerLookup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_costomerLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_costomerLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_costomerLookup.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_costomerLookup.MultiSelect = false;
            this.dataGridView_costomerLookup.Name = "dataGridView_costomerLookup";
            this.dataGridView_costomerLookup.ReadOnly = true;
            this.dataGridView_costomerLookup.RowHeadersVisible = false;
            this.dataGridView_costomerLookup.RowTemplate.Height = 37;
            this.dataGridView_costomerLookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_costomerLookup.Size = new System.Drawing.Size(1806, 781);
            this.dataGridView_costomerLookup.TabIndex = 0;
            this.dataGridView_costomerLookup.ReadOnlyChanged += new System.EventHandler(this.dataGridView_costomerLookup_ReadOnlyChanged);
            this.dataGridView_costomerLookup.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_costomerLookup_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_costomerInsert);
            this.panel1.Controls.Add(this.btn_costomerDelete);
            this.panel1.Controls.Add(this.btn_costomer);
            this.panel1.Controls.Add(this.textbox_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1808, 72);
            this.panel1.TabIndex = 0;
            // 
            // btn_costomerInsert
            // 
            this.btn_costomerInsert.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_costomerInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_costomerInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_costomerInsert.Location = new System.Drawing.Point(1206, 0);
            this.btn_costomerInsert.Name = "btn_costomerInsert";
            this.btn_costomerInsert.Size = new System.Drawing.Size(200, 70);
            this.btn_costomerInsert.TabIndex = 4;
            this.btn_costomerInsert.Text = "추가";
            this.btn_costomerInsert.UseVisualStyleBackColor = false;
            this.btn_costomerInsert.Click += new System.EventHandler(this.btn_costomerInsert_Click);
            // 
            // btn_costomerDelete
            // 
            this.btn_costomerDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_costomerDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_costomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_costomerDelete.Location = new System.Drawing.Point(1406, 0);
            this.btn_costomerDelete.Name = "btn_costomerDelete";
            this.btn_costomerDelete.Size = new System.Drawing.Size(200, 70);
            this.btn_costomerDelete.TabIndex = 3;
            this.btn_costomerDelete.Text = "삭제";
            this.btn_costomerDelete.UseVisualStyleBackColor = false;
            this.btn_costomerDelete.Click += new System.EventHandler(this.btn_costomerDelete_Click);
            // 
            // btn_costomer
            // 
            this.btn_costomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_costomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_costomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_costomer.Location = new System.Drawing.Point(1606, 0);
            this.btn_costomer.Name = "btn_costomer";
            this.btn_costomer.Size = new System.Drawing.Size(200, 70);
            this.btn_costomer.TabIndex = 2;
            this.btn_costomer.Text = "조회";
            this.btn_costomer.UseVisualStyleBackColor = false;
            this.btn_costomer.Click += new System.EventHandler(this.btn_costomer_Click);
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(141, 18);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(182, 35);
            this.textbox_name.TabIndex = 1;
            this.textbox_name.TextChanged += new System.EventHandler(this.textbox_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객이름";
            // 
            // tb_rental
            // 
            this.tb_rental.Controls.Add(this.panel4);
            this.tb_rental.Controls.Add(this.panel3);
            this.tb_rental.Location = new System.Drawing.Point(8, 38);
            this.tb_rental.Name = "tb_rental";
            this.tb_rental.Padding = new System.Windows.Forms.Padding(3);
            this.tb_rental.Size = new System.Drawing.Size(1814, 861);
            this.tb_rental.TabIndex = 1;
            this.tb_rental.Text = "자전거대여현황";
            this.tb_rental.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView_lentalLookup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1808, 785);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView_lentalLookup
            // 
            this.dataGridView_lentalLookup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_lentalLookup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_lentalLookup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_lentalLookup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_lentalLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lentalLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_lentalLookup.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_lentalLookup.MultiSelect = false;
            this.dataGridView_lentalLookup.Name = "dataGridView_lentalLookup";
            this.dataGridView_lentalLookup.ReadOnly = true;
            this.dataGridView_lentalLookup.RowHeadersVisible = false;
            this.dataGridView_lentalLookup.RowTemplate.Height = 37;
            this.dataGridView_lentalLookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_lentalLookup.Size = new System.Drawing.Size(1806, 783);
            this.dataGridView_lentalLookup.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_rentalLookup);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1808, 70);
            this.panel3.TabIndex = 0;
            // 
            // btn_rentalLookup
            // 
            this.btn_rentalLookup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rentalLookup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_rentalLookup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rentalLookup.Location = new System.Drawing.Point(1606, 0);
            this.btn_rentalLookup.Name = "btn_rentalLookup";
            this.btn_rentalLookup.Size = new System.Drawing.Size(200, 68);
            this.btn_rentalLookup.TabIndex = 3;
            this.btn_rentalLookup.Text = "조회";
            this.btn_rentalLookup.UseVisualStyleBackColor = false;
            this.btn_rentalLookup.Click += new System.EventHandler(this.btn_rentalLookup_Click);
            // 
            // tb_repair
            // 
            this.tb_repair.Controls.Add(this.dataGridView_repair);
            this.tb_repair.Controls.Add(this.panel5);
            this.tb_repair.Location = new System.Drawing.Point(8, 38);
            this.tb_repair.Name = "tb_repair";
            this.tb_repair.Padding = new System.Windows.Forms.Padding(3);
            this.tb_repair.Size = new System.Drawing.Size(1814, 861);
            this.tb_repair.TabIndex = 2;
            this.tb_repair.Text = "수리";
            this.tb_repair.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.btn_InsertRepair);
            this.panel5.Controls.Add(this.btn_lookupRepair);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1808, 70);
            this.panel5.TabIndex = 0;
            // 
            // tb_manufacture
            // 
            this.tb_manufacture.Controls.Add(this.dataGridView_Manufacture);
            this.tb_manufacture.Controls.Add(this.panel6);
            this.tb_manufacture.Location = new System.Drawing.Point(8, 38);
            this.tb_manufacture.Name = "tb_manufacture";
            this.tb_manufacture.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manufacture.Size = new System.Drawing.Size(1814, 861);
            this.tb_manufacture.TabIndex = 3;
            this.tb_manufacture.Text = "제조회사";
            this.tb_manufacture.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.btn_InsertManufacture);
            this.panel6.Controls.Add(this.btn_DeleteManufacture);
            this.panel6.Controls.Add(this.btn_LookupManufacture);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1808, 70);
            this.panel6.TabIndex = 1;
            // 
            // tb_bycicle
            // 
            this.tb_bycicle.Controls.Add(this.dataGridView_Bycicle);
            this.tb_bycicle.Controls.Add(this.panel7);
            this.tb_bycicle.Location = new System.Drawing.Point(8, 38);
            this.tb_bycicle.Name = "tb_bycicle";
            this.tb_bycicle.Padding = new System.Windows.Forms.Padding(3);
            this.tb_bycicle.Size = new System.Drawing.Size(1814, 861);
            this.tb_bycicle.TabIndex = 4;
            this.tb_bycicle.Text = "자전거";
            this.tb_bycicle.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Controls.Add(this.btn_InsertBycicle);
            this.panel7.Controls.Add(this.btn_DeleteBycicle);
            this.panel7.Controls.Add(this.btn_LookupBycicle);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1808, 70);
            this.panel7.TabIndex = 1;
            // 
            // tb_part
            // 
            this.tb_part.Controls.Add(this.dataGridView_Part);
            this.tb_part.Controls.Add(this.panel8);
            this.tb_part.Location = new System.Drawing.Point(8, 38);
            this.tb_part.Name = "tb_part";
            this.tb_part.Padding = new System.Windows.Forms.Padding(3);
            this.tb_part.Size = new System.Drawing.Size(1814, 861);
            this.tb_part.TabIndex = 5;
            this.tb_part.Text = "부품";
            this.tb_part.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.btn_InsertPart);
            this.panel8.Controls.Add(this.btn_DeletePart);
            this.panel8.Controls.Add(this.btn_LookupPart);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1808, 70);
            this.panel8.TabIndex = 1;
            // 
            // btn_lookupRepair
            // 
            this.btn_lookupRepair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_lookupRepair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_lookupRepair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lookupRepair.Location = new System.Drawing.Point(1608, 0);
            this.btn_lookupRepair.Name = "btn_lookupRepair";
            this.btn_lookupRepair.Size = new System.Drawing.Size(200, 70);
            this.btn_lookupRepair.TabIndex = 4;
            this.btn_lookupRepair.Text = "조회";
            this.btn_lookupRepair.UseVisualStyleBackColor = false;
            this.btn_lookupRepair.Click += new System.EventHandler(this.btn_lookupRepair_Click);
            // 
            // btn_LookupManufacture
            // 
            this.btn_LookupManufacture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_LookupManufacture.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_LookupManufacture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LookupManufacture.Location = new System.Drawing.Point(1608, 0);
            this.btn_LookupManufacture.Name = "btn_LookupManufacture";
            this.btn_LookupManufacture.Size = new System.Drawing.Size(200, 70);
            this.btn_LookupManufacture.TabIndex = 4;
            this.btn_LookupManufacture.Text = "조회";
            this.btn_LookupManufacture.UseVisualStyleBackColor = false;
            this.btn_LookupManufacture.Click += new System.EventHandler(this.btn_LookupManufacture_Click);
            // 
            // btn_LookupBycicle
            // 
            this.btn_LookupBycicle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_LookupBycicle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_LookupBycicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LookupBycicle.Location = new System.Drawing.Point(1608, 0);
            this.btn_LookupBycicle.Name = "btn_LookupBycicle";
            this.btn_LookupBycicle.Size = new System.Drawing.Size(200, 70);
            this.btn_LookupBycicle.TabIndex = 4;
            this.btn_LookupBycicle.Text = "조회";
            this.btn_LookupBycicle.UseVisualStyleBackColor = false;
            this.btn_LookupBycicle.Click += new System.EventHandler(this.btn_LookupBycicle_Click);
            // 
            // btn_LookupPart
            // 
            this.btn_LookupPart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_LookupPart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_LookupPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LookupPart.Location = new System.Drawing.Point(1608, 0);
            this.btn_LookupPart.Name = "btn_LookupPart";
            this.btn_LookupPart.Size = new System.Drawing.Size(200, 70);
            this.btn_LookupPart.TabIndex = 4;
            this.btn_LookupPart.Text = "조회";
            this.btn_LookupPart.UseVisualStyleBackColor = false;
            this.btn_LookupPart.Click += new System.EventHandler(this.btn_LookupPart_Click);
            // 
            // btn_DeleteManufacture
            // 
            this.btn_DeleteManufacture.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeleteManufacture.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DeleteManufacture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteManufacture.Location = new System.Drawing.Point(1408, 0);
            this.btn_DeleteManufacture.Name = "btn_DeleteManufacture";
            this.btn_DeleteManufacture.Size = new System.Drawing.Size(200, 70);
            this.btn_DeleteManufacture.TabIndex = 5;
            this.btn_DeleteManufacture.Text = "삭제";
            this.btn_DeleteManufacture.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteBycicle
            // 
            this.btn_DeleteBycicle.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeleteBycicle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DeleteBycicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteBycicle.Location = new System.Drawing.Point(1408, 0);
            this.btn_DeleteBycicle.Name = "btn_DeleteBycicle";
            this.btn_DeleteBycicle.Size = new System.Drawing.Size(200, 70);
            this.btn_DeleteBycicle.TabIndex = 5;
            this.btn_DeleteBycicle.Text = "삭제";
            this.btn_DeleteBycicle.UseVisualStyleBackColor = false;
            // 
            // btn_DeletePart
            // 
            this.btn_DeletePart.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeletePart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeletePart.Location = new System.Drawing.Point(1408, 0);
            this.btn_DeletePart.Name = "btn_DeletePart";
            this.btn_DeletePart.Size = new System.Drawing.Size(200, 70);
            this.btn_DeletePart.TabIndex = 5;
            this.btn_DeletePart.Text = "삭제";
            this.btn_DeletePart.UseVisualStyleBackColor = false;
            // 
            // btn_InsertRepair
            // 
            this.btn_InsertRepair.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_InsertRepair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_InsertRepair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InsertRepair.Location = new System.Drawing.Point(1408, 0);
            this.btn_InsertRepair.Name = "btn_InsertRepair";
            this.btn_InsertRepair.Size = new System.Drawing.Size(200, 70);
            this.btn_InsertRepair.TabIndex = 5;
            this.btn_InsertRepair.Text = "추가";
            this.btn_InsertRepair.UseVisualStyleBackColor = false;
            // 
            // btn_InsertManufacture
            // 
            this.btn_InsertManufacture.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_InsertManufacture.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_InsertManufacture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InsertManufacture.Location = new System.Drawing.Point(1208, 0);
            this.btn_InsertManufacture.Name = "btn_InsertManufacture";
            this.btn_InsertManufacture.Size = new System.Drawing.Size(200, 70);
            this.btn_InsertManufacture.TabIndex = 6;
            this.btn_InsertManufacture.Text = "추가";
            this.btn_InsertManufacture.UseVisualStyleBackColor = false;
            // 
            // btn_InsertBycicle
            // 
            this.btn_InsertBycicle.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_InsertBycicle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_InsertBycicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InsertBycicle.Location = new System.Drawing.Point(1208, 0);
            this.btn_InsertBycicle.Name = "btn_InsertBycicle";
            this.btn_InsertBycicle.Size = new System.Drawing.Size(200, 70);
            this.btn_InsertBycicle.TabIndex = 6;
            this.btn_InsertBycicle.Text = "추가";
            this.btn_InsertBycicle.UseVisualStyleBackColor = false;
            // 
            // btn_InsertPart
            // 
            this.btn_InsertPart.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_InsertPart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_InsertPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InsertPart.Location = new System.Drawing.Point(1208, 0);
            this.btn_InsertPart.Name = "btn_InsertPart";
            this.btn_InsertPart.Size = new System.Drawing.Size(200, 70);
            this.btn_InsertPart.TabIndex = 6;
            this.btn_InsertPart.Text = "추가";
            this.btn_InsertPart.UseVisualStyleBackColor = false;
            // 
            // dataGridView_repair
            // 
            this.dataGridView_repair.AllowUserToAddRows = false;
            this.dataGridView_repair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_repair.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_repair.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_repair.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_repair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_repair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_repair.Location = new System.Drawing.Point(3, 73);
            this.dataGridView_repair.MultiSelect = false;
            this.dataGridView_repair.Name = "dataGridView_repair";
            this.dataGridView_repair.ReadOnly = true;
            this.dataGridView_repair.RowHeadersVisible = false;
            this.dataGridView_repair.RowTemplate.Height = 37;
            this.dataGridView_repair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_repair.Size = new System.Drawing.Size(1808, 785);
            this.dataGridView_repair.TabIndex = 1;
            // 
            // dataGridView_Manufacture
            // 
            this.dataGridView_Manufacture.AllowUserToAddRows = false;
            this.dataGridView_Manufacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Manufacture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Manufacture.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Manufacture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Manufacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Manufacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Manufacture.Location = new System.Drawing.Point(3, 73);
            this.dataGridView_Manufacture.MultiSelect = false;
            this.dataGridView_Manufacture.Name = "dataGridView_Manufacture";
            this.dataGridView_Manufacture.ReadOnly = true;
            this.dataGridView_Manufacture.RowHeadersVisible = false;
            this.dataGridView_Manufacture.RowTemplate.Height = 37;
            this.dataGridView_Manufacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Manufacture.Size = new System.Drawing.Size(1808, 785);
            this.dataGridView_Manufacture.TabIndex = 2;
            // 
            // dataGridView_Bycicle
            // 
            this.dataGridView_Bycicle.AllowUserToAddRows = false;
            this.dataGridView_Bycicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Bycicle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Bycicle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Bycicle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Bycicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bycicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Bycicle.Location = new System.Drawing.Point(3, 73);
            this.dataGridView_Bycicle.MultiSelect = false;
            this.dataGridView_Bycicle.Name = "dataGridView_Bycicle";
            this.dataGridView_Bycicle.ReadOnly = true;
            this.dataGridView_Bycicle.RowHeadersVisible = false;
            this.dataGridView_Bycicle.RowTemplate.Height = 37;
            this.dataGridView_Bycicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Bycicle.Size = new System.Drawing.Size(1808, 785);
            this.dataGridView_Bycicle.TabIndex = 3;
            // 
            // dataGridView_Part
            // 
            this.dataGridView_Part.AllowUserToAddRows = false;
            this.dataGridView_Part.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Part.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Part.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Part.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Part.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Part.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Part.Location = new System.Drawing.Point(3, 73);
            this.dataGridView_Part.MultiSelect = false;
            this.dataGridView_Part.Name = "dataGridView_Part";
            this.dataGridView_Part.ReadOnly = true;
            this.dataGridView_Part.RowHeadersVisible = false;
            this.dataGridView_Part.RowTemplate.Height = 37;
            this.dataGridView_Part.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Part.Size = new System.Drawing.Size(1808, 785);
            this.dataGridView_Part.TabIndex = 4;
            // 
            // CostomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 907);
            this.Controls.Add(this.tc_costomer);
            this.Name = "CostomerForm";
            this.Text = "CostomerManagement";
            this.Load += new System.EventHandler(this.CostomerForm_Load);
            this.tc_costomer.ResumeLayout(false);
            this.tb_costomerInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_costomerLookup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tb_rental.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lentalLookup)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tb_repair.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tb_manufacture.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tb_bycicle.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tb_part.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_repair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manufacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bycicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Part)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_costomer;
        private System.Windows.Forms.TabPage tb_costomerInfo;
        private System.Windows.Forms.TabPage tb_rental;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_costomerLookup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_costomer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_lentalLookup;
        private System.Windows.Forms.Button btn_costomerInsert;
        private System.Windows.Forms.Button btn_costomerDelete;
        private System.Windows.Forms.TabPage tb_repair;
        private System.Windows.Forms.TabPage tb_manufacture;
        private System.Windows.Forms.TabPage tb_bycicle;
        private System.Windows.Forms.TabPage tb_part;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_rentalLookup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_InsertRepair;
        private System.Windows.Forms.Button btn_lookupRepair;
        private System.Windows.Forms.Button btn_InsertManufacture;
        private System.Windows.Forms.Button btn_DeleteManufacture;
        private System.Windows.Forms.Button btn_LookupManufacture;
        private System.Windows.Forms.Button btn_InsertBycicle;
        private System.Windows.Forms.Button btn_DeleteBycicle;
        private System.Windows.Forms.Button btn_LookupBycicle;
        private System.Windows.Forms.Button btn_InsertPart;
        private System.Windows.Forms.Button btn_DeletePart;
        private System.Windows.Forms.Button btn_LookupPart;
        private System.Windows.Forms.DataGridView dataGridView_repair;
        private System.Windows.Forms.DataGridView dataGridView_Manufacture;
        private System.Windows.Forms.DataGridView dataGridView_Bycicle;
        private System.Windows.Forms.DataGridView dataGridView_Part;
    }
}

