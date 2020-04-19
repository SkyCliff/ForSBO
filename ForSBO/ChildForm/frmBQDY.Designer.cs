namespace ForSBO.ChildForm
{
    partial class frmBQDY
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDYJ = new System.Windows.Forms.ComboBox();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnPrintSelect = new System.Windows.Forms.Button();
            this.cmbBM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPH = new System.Windows.Forms.ComboBox();
            this.btnSelectData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbZT = new System.Windows.Forms.ComboBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docentry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAK5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DYBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.cmbDYFS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "打印机";
            // 
            // cmbDYJ
            // 
            this.cmbDYJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDYJ.FormattingEnabled = true;
            this.cmbDYJ.Location = new System.Drawing.Point(68, 21);
            this.cmbDYJ.Name = "cmbDYJ";
            this.cmbDYJ.Size = new System.Drawing.Size(403, 20);
            this.cmbDYJ.TabIndex = 2;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintAll.Location = new System.Drawing.Point(1448, 20);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(150, 23);
            this.btnPrintAll.TabIndex = 2;
            this.btnPrintAll.Text = "打印所有标签";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnPrintSelect
            // 
            this.btnPrintSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSelect.Location = new System.Drawing.Point(1626, 21);
            this.btnPrintSelect.Name = "btnPrintSelect";
            this.btnPrintSelect.Size = new System.Drawing.Size(150, 23);
            this.btnPrintSelect.TabIndex = 3;
            this.btnPrintSelect.Text = "打印选中标签";
            this.btnPrintSelect.UseVisualStyleBackColor = true;
            this.btnPrintSelect.Click += new System.EventHandler(this.btnPrintSelect_Click);
            // 
            // cmbBM
            // 
            this.cmbBM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBM.FormattingEnabled = true;
            this.cmbBM.Items.AddRange(new object[] {
            "原材料仓库",
            "压制车间",
            "整形车间",
            "包装车间",
            "成品仓库"});
            this.cmbBM.Location = new System.Drawing.Point(711, 22);
            this.cmbBM.Name = "cmbBM";
            this.cmbBM.Size = new System.Drawing.Size(154, 20);
            this.cmbBM.TabIndex = 4;
            this.cmbBM.SelectedIndexChanged += new System.EventHandler(this.cmbBM_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部  门";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(290, 60);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(181, 20);
            this.cmbName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "名  称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "老编号";
            // 
            // cmbBH
            // 
            this.cmbBH.FormattingEnabled = true;
            this.cmbBH.Location = new System.Drawing.Point(538, 60);
            this.cmbBH.Name = "cmbBH";
            this.cmbBH.Size = new System.Drawing.Size(115, 20);
            this.cmbBH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "批  号";
            // 
            // cmbPH
            // 
            this.cmbPH.FormattingEnabled = true;
            this.cmbPH.Location = new System.Drawing.Point(711, 60);
            this.cmbPH.Name = "cmbPH";
            this.cmbPH.Size = new System.Drawing.Size(154, 20);
            this.cmbPH.TabIndex = 5;
            // 
            // btnSelectData
            // 
            this.btnSelectData.Location = new System.Drawing.Point(900, 58);
            this.btnSelectData.Name = "btnSelectData";
            this.btnSelectData.Size = new System.Drawing.Size(160, 23);
            this.btnSelectData.TabIndex = 0;
            this.btnSelectData.Text = "查询数据";
            this.btnSelectData.UseVisualStyleBackColor = true;
            this.btnSelectData.Click += new System.EventHandler(this.btnSelectData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "账  套";
            // 
            // cmbZT
            // 
            this.cmbZT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZT.FormattingEnabled = true;
            this.cmbZT.Items.AddRange(new object[] {
            "金恒",
            "骏马"});
            this.cmbZT.Location = new System.Drawing.Point(538, 21);
            this.cmbZT.Name = "cmbZT";
            this.cmbZT.Size = new System.Drawing.Size(115, 20);
            this.cmbZT.TabIndex = 6;
            this.cmbZT.SelectedIndexChanged += new System.EventHandler(this.cmbZT_SelectedIndexChanged);
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemCode,
            this.ItemName,
            this.Docentry,
            this.BAK3,
            this.Quantity,
            this.turn,
            this.BAK5,
            this.bath,
            this.DYBS,
            this.DDATE});
            this.dgData.Location = new System.Drawing.Point(24, 112);
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.RowTemplate.Height = 23;
            this.dgData.Size = new System.Drawing.Size(1752, 688);
            this.dgData.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "物料编号";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "物料名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Docentry
            // 
            this.Docentry.DataPropertyName = "Docentry";
            this.Docentry.HeaderText = "订单号";
            this.Docentry.Name = "Docentry";
            this.Docentry.ReadOnly = true;
            // 
            // BAK3
            // 
            this.BAK3.DataPropertyName = "BAK3";
            this.BAK3.HeaderText = "老编号";
            this.BAK3.Name = "BAK3";
            this.BAK3.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // turn
            // 
            this.turn.DataPropertyName = "turn";
            this.turn.HeaderText = "箱号";
            this.turn.Name = "turn";
            this.turn.ReadOnly = true;
            // 
            // BAK5
            // 
            this.BAK5.DataPropertyName = "BAK5";
            this.BAK5.HeaderText = "包装批号";
            this.BAK5.Name = "BAK5";
            this.BAK5.ReadOnly = true;
            // 
            // bath
            // 
            this.bath.DataPropertyName = "bath";
            this.bath.HeaderText = "生产批号";
            this.bath.Name = "bath";
            this.bath.ReadOnly = true;
            // 
            // DYBS
            // 
            this.DYBS.DataPropertyName = "DYBS";
            this.DYBS.HeaderText = "打印标识";
            this.DYBS.Name = "DYBS";
            this.DYBS.ReadOnly = true;
            // 
            // DDATE
            // 
            this.DDATE.DataPropertyName = "DDATE";
            this.DDATE.HeaderText = "打印日期";
            this.DDATE.Name = "DDATE";
            this.DDATE.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "新编号";
            // 
            // cmbCode
            // 
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(68, 60);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(155, 20);
            this.cmbCode.TabIndex = 8;
            // 
            // cmbDYFS
            // 
            this.cmbDYFS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDYFS.FormattingEnabled = true;
            this.cmbDYFS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDYFS.Location = new System.Drawing.Point(957, 22);
            this.cmbDYFS.Name = "cmbDYFS";
            this.cmbDYFS.Size = new System.Drawing.Size(103, 20);
            this.cmbDYFS.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(898, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "打印份数";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("宋体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblData.Location = new System.Drawing.Point(643, 403);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(489, 35);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "正在处理数据，请稍候......";
            this.lblData.Visible = false;
            // 
            // frmBQDY
            // 
            this.AcceptButton = this.btnSelectData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 831);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbDYFS);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.cmbZT);
            this.Controls.Add(this.btnSelectData);
            this.Controls.Add(this.cmbPH);
            this.Controls.Add(this.cmbBH);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbBM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDYJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPrintSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintAll);
            this.Name = "frmBQDY";
            this.Text = "标签重新打印";
            this.Load += new System.EventHandler(this.frmBQDY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDYJ;
        private System.Windows.Forms.Button btnPrintSelect;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.ComboBox cmbBM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPH;
        private System.Windows.Forms.Button btnSelectData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbZT;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.ComboBox cmbDYFS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docentry;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn turn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAK5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DYBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDATE;
        private System.Windows.Forms.Label lblData;
    }
}