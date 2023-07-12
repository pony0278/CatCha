namespace Cart2
{
    partial class Frm_Cart2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerCartDetails = new System.Windows.Forms.SplitContainer();
            this.labCartDetails = new System.Windows.Forms.Label();
            this.labNote = new System.Windows.Forms.Label();
            this.dgvCartList = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.recipientInputAddress = new System.Windows.Forms.RadioButton();
            this.txtRecipientAddress = new System.Windows.Forms.TextBox();
            this.txtRecipientPhone = new System.Windows.Forms.TextBox();
            this.txtRecipientName = new System.Windows.Forms.TextBox();
            this.labRecipientAddress = new System.Windows.Forms.Label();
            this.labRecipient = new System.Windows.Forms.Label();
            this.labRecipientPhone = new System.Windows.Forms.Label();
            this.recipientAsCommonAddress = new System.Windows.Forms.RadioButton();
            this.recipientAsMemberInfo = new System.Windows.Forms.RadioButton();
            this.cmbCommonAddress = new System.Windows.Forms.ComboBox();
            this.labCommonAddress = new System.Windows.Forms.Label();
            this.labRecipientInfo = new System.Windows.Forms.Label();
            this.splitContainerTotal = new System.Windows.Forms.SplitContainer();
            this.ckbUseLoyaltyPoints = new System.Windows.Forms.CheckBox();
            this.labNote2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labLoyaltyPointsValue = new System.Windows.Forms.Label();
            this.cmbSelectCoupon = new System.Windows.Forms.ComboBox();
            this.labCouponValue = new System.Windows.Forms.Label();
            this.cmbSelectPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labShippment = new System.Windows.Forms.Label();
            this.labCartTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.labOrderTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCartDetails)).BeginInit();
            this.splitContainerCartDetails.Panel1.SuspendLayout();
            this.splitContainerCartDetails.Panel2.SuspendLayout();
            this.splitContainerCartDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTotal)).BeginInit();
            this.splitContainerTotal.Panel1.SuspendLayout();
            this.splitContainerTotal.Panel2.SuspendLayout();
            this.splitContainerTotal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerCartDetails
            // 
            this.splitContainerCartDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerCartDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCartDetails.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCartDetails.Name = "splitContainerCartDetails";
            this.splitContainerCartDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCartDetails.Panel1
            // 
            this.splitContainerCartDetails.Panel1.Controls.Add(this.labCartDetails);
            this.splitContainerCartDetails.Panel1.Controls.Add(this.labNote);
            this.splitContainerCartDetails.Panel1.Controls.Add(this.dgvCartList);
            // 
            // splitContainerCartDetails.Panel2
            // 
            this.splitContainerCartDetails.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainerCartDetails.Size = new System.Drawing.Size(1608, 1055);
            this.splitContainerCartDetails.SplitterDistance = 254;
            this.splitContainerCartDetails.SplitterWidth = 2;
            this.splitContainerCartDetails.TabIndex = 20;
            // 
            // labCartDetails
            // 
            this.labCartDetails.AutoSize = true;
            this.labCartDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCartDetails.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCartDetails.Location = new System.Drawing.Point(0, 0);
            this.labCartDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCartDetails.Name = "labCartDetails";
            this.labCartDetails.Size = new System.Drawing.Size(150, 34);
            this.labCartDetails.TabIndex = 17;
            this.labCartDetails.Text = "購物車明細";
            // 
            // labNote
            // 
            this.labNote.AutoSize = true;
            this.labNote.Location = new System.Drawing.Point(191, 65);
            this.labNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(94, 18);
            this.labNote.TabIndex = 16;
            this.labNote.Text = "可獲得 0 紅利";
            // 
            // dgvCartList
            // 
            this.dgvCartList.AllowUserToAddRows = false;
            this.dgvCartList.AllowUserToDeleteRows = false;
            this.dgvCartList.AllowUserToResizeColumns = false;
            this.dgvCartList.AllowUserToResizeRows = false;
            this.dgvCartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCartList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCartList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCartList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCartList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCartList.EnableHeadersVisualStyles = false;
            this.dgvCartList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCartList.Location = new System.Drawing.Point(0, 102);
            this.dgvCartList.MultiSelect = false;
            this.dgvCartList.Name = "dgvCartList";
            this.dgvCartList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCartList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCartList.RowHeadersVisible = false;
            this.dgvCartList.RowHeadersWidth = 60;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCartList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCartList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCartList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Bisque;
            this.dgvCartList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvCartList.RowTemplate.Height = 35;
            this.dgvCartList.RowTemplate.ReadOnly = true;
            this.dgvCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartList.Size = new System.Drawing.Size(1606, 150);
            this.dgvCartList.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.recipientInputAddress);
            this.splitContainer2.Panel1.Controls.Add(this.txtRecipientAddress);
            this.splitContainer2.Panel1.Controls.Add(this.txtRecipientPhone);
            this.splitContainer2.Panel1.Controls.Add(this.txtRecipientName);
            this.splitContainer2.Panel1.Controls.Add(this.labRecipientAddress);
            this.splitContainer2.Panel1.Controls.Add(this.labRecipient);
            this.splitContainer2.Panel1.Controls.Add(this.labRecipientPhone);
            this.splitContainer2.Panel1.Controls.Add(this.recipientAsCommonAddress);
            this.splitContainer2.Panel1.Controls.Add(this.recipientAsMemberInfo);
            this.splitContainer2.Panel1.Controls.Add(this.cmbCommonAddress);
            this.splitContainer2.Panel1.Controls.Add(this.labCommonAddress);
            this.splitContainer2.Panel1.Controls.Add(this.labRecipientInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainerTotal);
            this.splitContainer2.Size = new System.Drawing.Size(1608, 799);
            this.splitContainer2.SplitterDistance = 215;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // recipientInputAddress
            // 
            this.recipientInputAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recipientInputAddress.AutoSize = true;
            this.recipientInputAddress.Location = new System.Drawing.Point(486, 0);
            this.recipientInputAddress.Name = "recipientInputAddress";
            this.recipientInputAddress.Size = new System.Drawing.Size(82, 22);
            this.recipientInputAddress.TabIndex = 77;
            this.recipientInputAddress.TabStop = true;
            this.recipientInputAddress.Text = "自訂地址";
            this.recipientInputAddress.UseVisualStyleBackColor = true;
            this.recipientInputAddress.CheckedChanged += new System.EventHandler(this.recipientInputAddress_CheckedChanged);
            // 
            // txtRecipientAddress
            // 
            this.txtRecipientAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRecipientAddress.Location = new System.Drawing.Point(430, 111);
            this.txtRecipientAddress.Name = "txtRecipientAddress";
            this.txtRecipientAddress.Size = new System.Drawing.Size(204, 26);
            this.txtRecipientAddress.TabIndex = 76;
            // 
            // txtRecipientPhone
            // 
            this.txtRecipientPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRecipientPhone.Location = new System.Drawing.Point(430, 75);
            this.txtRecipientPhone.Name = "txtRecipientPhone";
            this.txtRecipientPhone.Size = new System.Drawing.Size(204, 26);
            this.txtRecipientPhone.TabIndex = 75;
            // 
            // txtRecipientName
            // 
            this.txtRecipientName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRecipientName.Location = new System.Drawing.Point(430, 39);
            this.txtRecipientName.Name = "txtRecipientName";
            this.txtRecipientName.Size = new System.Drawing.Size(204, 26);
            this.txtRecipientName.TabIndex = 74;
            // 
            // labRecipientAddress
            // 
            this.labRecipientAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecipientAddress.AutoSize = true;
            this.labRecipientAddress.Location = new System.Drawing.Point(330, 113);
            this.labRecipientAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRecipientAddress.Name = "labRecipientAddress";
            this.labRecipientAddress.Size = new System.Drawing.Size(39, 18);
            this.labRecipientAddress.TabIndex = 73;
            this.labRecipientAddress.Text = "地址:";
            // 
            // labRecipient
            // 
            this.labRecipient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecipient.AutoSize = true;
            this.labRecipient.Location = new System.Drawing.Point(330, 44);
            this.labRecipient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRecipient.Name = "labRecipient";
            this.labRecipient.Size = new System.Drawing.Size(39, 18);
            this.labRecipient.TabIndex = 71;
            this.labRecipient.Text = "姓名:";
            // 
            // labRecipientPhone
            // 
            this.labRecipientPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecipientPhone.AutoSize = true;
            this.labRecipientPhone.Location = new System.Drawing.Point(330, 77);
            this.labRecipientPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRecipientPhone.Name = "labRecipientPhone";
            this.labRecipientPhone.Size = new System.Drawing.Size(39, 18);
            this.labRecipientPhone.TabIndex = 72;
            this.labRecipientPhone.Text = "手機:";
            // 
            // recipientAsCommonAddress
            // 
            this.recipientAsCommonAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recipientAsCommonAddress.AutoSize = true;
            this.recipientAsCommonAddress.Location = new System.Drawing.Point(745, 0);
            this.recipientAsCommonAddress.Name = "recipientAsCommonAddress";
            this.recipientAsCommonAddress.Size = new System.Drawing.Size(110, 22);
            this.recipientAsCommonAddress.TabIndex = 63;
            this.recipientAsCommonAddress.TabStop = true;
            this.recipientAsCommonAddress.Text = "選擇常用地址";
            this.recipientAsCommonAddress.UseVisualStyleBackColor = true;
            this.recipientAsCommonAddress.CheckedChanged += new System.EventHandler(this.recipientAsCommonAddress_CheckedChanged);
            // 
            // recipientAsMemberInfo
            // 
            this.recipientAsMemberInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recipientAsMemberInfo.AutoSize = true;
            this.recipientAsMemberInfo.Location = new System.Drawing.Point(334, 0);
            this.recipientAsMemberInfo.Name = "recipientAsMemberInfo";
            this.recipientAsMemberInfo.Size = new System.Drawing.Size(96, 22);
            this.recipientAsMemberInfo.TabIndex = 62;
            this.recipientAsMemberInfo.TabStop = true;
            this.recipientAsMemberInfo.Text = "同會員資料";
            this.recipientAsMemberInfo.UseVisualStyleBackColor = true;
            this.recipientAsMemberInfo.CheckedChanged += new System.EventHandler(this.recipientAsMemberInfo_CheckedChanged);
            // 
            // cmbCommonAddress
            // 
            this.cmbCommonAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCommonAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommonAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCommonAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCommonAddress.FormattingEnabled = true;
            this.cmbCommonAddress.Location = new System.Drawing.Point(868, 70);
            this.cmbCommonAddress.Name = "cmbCommonAddress";
            this.cmbCommonAddress.Size = new System.Drawing.Size(408, 26);
            this.cmbCommonAddress.TabIndex = 57;
            // 
            // labCommonAddress
            // 
            this.labCommonAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labCommonAddress.AutoSize = true;
            this.labCommonAddress.Location = new System.Drawing.Point(747, 73);
            this.labCommonAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCommonAddress.Name = "labCommonAddress";
            this.labCommonAddress.Size = new System.Drawing.Size(67, 18);
            this.labCommonAddress.TabIndex = 56;
            this.labCommonAddress.Text = "常用地址:";
            // 
            // labRecipientInfo
            // 
            this.labRecipientInfo.AutoSize = true;
            this.labRecipientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labRecipientInfo.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRecipientInfo.Location = new System.Drawing.Point(0, 0);
            this.labRecipientInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRecipientInfo.Name = "labRecipientInfo";
            this.labRecipientInfo.Size = new System.Drawing.Size(150, 34);
            this.labRecipientInfo.TabIndex = 44;
            this.labRecipientInfo.Text = "收件人資料";
            // 
            // splitContainerTotal
            // 
            this.splitContainerTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTotal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTotal.Name = "splitContainerTotal";
            this.splitContainerTotal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTotal.Panel1
            // 
            this.splitContainerTotal.Panel1.Controls.Add(this.ckbUseLoyaltyPoints);
            this.splitContainerTotal.Panel1.Controls.Add(this.labNote2);
            this.splitContainerTotal.Panel1.Controls.Add(this.label5);
            this.splitContainerTotal.Panel1.Controls.Add(this.labLoyaltyPointsValue);
            this.splitContainerTotal.Panel1.Controls.Add(this.cmbSelectCoupon);
            this.splitContainerTotal.Panel1.Controls.Add(this.labCouponValue);
            this.splitContainerTotal.Panel1.Controls.Add(this.cmbSelectPaymentMethod);
            this.splitContainerTotal.Panel1.Controls.Add(this.label4);
            this.splitContainerTotal.Panel1.Controls.Add(this.labShippment);
            this.splitContainerTotal.Panel1.Controls.Add(this.labCartTotal);
            // 
            // splitContainerTotal.Panel2
            // 
            this.splitContainerTotal.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerTotal.Panel2.Controls.Add(this.btnSendOrder);
            this.splitContainerTotal.Panel2.Controls.Add(this.labOrderTotal);
            this.splitContainerTotal.Size = new System.Drawing.Size(1608, 582);
            this.splitContainerTotal.SplitterDistance = 250;
            this.splitContainerTotal.SplitterWidth = 2;
            this.splitContainerTotal.TabIndex = 0;
            // 
            // ckbUseLoyaltyPoints
            // 
            this.ckbUseLoyaltyPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbUseLoyaltyPoints.AutoSize = true;
            this.ckbUseLoyaltyPoints.Location = new System.Drawing.Point(386, 35);
            this.ckbUseLoyaltyPoints.Name = "ckbUseLoyaltyPoints";
            this.ckbUseLoyaltyPoints.Size = new System.Drawing.Size(212, 22);
            this.ckbUseLoyaltyPoints.TabIndex = 57;
            this.ckbUseLoyaltyPoints.Text = "使用 0 點紅利點數折抵 NT$ 0";
            this.ckbUseLoyaltyPoints.UseVisualStyleBackColor = true;
            this.ckbUseLoyaltyPoints.CheckedChanged += new System.EventHandler(this.ckbUseLoyaltyPoints_CheckedChanged);
            // 
            // labNote2
            // 
            this.labNote2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labNote2.AutoSize = true;
            this.labNote2.Location = new System.Drawing.Point(805, 37);
            this.labNote2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNote2.Name = "labNote2";
            this.labNote2.Size = new System.Drawing.Size(94, 18);
            this.labNote2.TabIndex = 5;
            this.labNote2.Text = "可獲得 0 紅利";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "付款方式:";
            // 
            // labLoyaltyPointsValue
            // 
            this.labLoyaltyPointsValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labLoyaltyPointsValue.AutoSize = true;
            this.labLoyaltyPointsValue.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoyaltyPointsValue.Location = new System.Drawing.Point(1086, 112);
            this.labLoyaltyPointsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLoyaltyPointsValue.Name = "labLoyaltyPointsValue";
            this.labLoyaltyPointsValue.Size = new System.Drawing.Size(138, 18);
            this.labLoyaltyPointsValue.TabIndex = 23;
            this.labLoyaltyPointsValue.Text = "紅利折抵 - NT$ 0.00";
            this.labLoyaltyPointsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSelectCoupon
            // 
            this.cmbSelectCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSelectCoupon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCoupon.FormattingEnabled = true;
            this.cmbSelectCoupon.Location = new System.Drawing.Point(486, 77);
            this.cmbSelectCoupon.Name = "cmbSelectCoupon";
            this.cmbSelectCoupon.Size = new System.Drawing.Size(204, 26);
            this.cmbSelectCoupon.TabIndex = 54;
            this.cmbSelectCoupon.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCoupon_SelectedIndexChanged);
            // 
            // labCouponValue
            // 
            this.labCouponValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labCouponValue.AutoSize = true;
            this.labCouponValue.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCouponValue.Location = new System.Drawing.Point(1086, 148);
            this.labCouponValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCouponValue.Name = "labCouponValue";
            this.labCouponValue.Size = new System.Drawing.Size(132, 18);
            this.labCouponValue.TabIndex = 21;
            this.labCouponValue.Text = "優惠券折抵 - NT$ 0";
            this.labCouponValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSelectPaymentMethod
            // 
            this.cmbSelectPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSelectPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectPaymentMethod.FormattingEnabled = true;
            this.cmbSelectPaymentMethod.Location = new System.Drawing.Point(486, 115);
            this.cmbSelectPaymentMethod.Name = "cmbSelectPaymentMethod";
            this.cmbSelectPaymentMethod.Size = new System.Drawing.Size(204, 26);
            this.cmbSelectPaymentMethod.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "優惠券:";
            // 
            // labShippment
            // 
            this.labShippment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labShippment.AutoSize = true;
            this.labShippment.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShippment.Location = new System.Drawing.Point(1086, 75);
            this.labShippment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShippment.Name = "labShippment";
            this.labShippment.Size = new System.Drawing.Size(116, 18);
            this.labShippment.TabIndex = 20;
            this.labShippment.Text = "運費   NT$ 80.00";
            this.labShippment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labCartTotal
            // 
            this.labCartTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labCartTotal.AutoSize = true;
            this.labCartTotal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCartTotal.Location = new System.Drawing.Point(1086, 37);
            this.labCartTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCartTotal.Name = "labCartTotal";
            this.labCartTotal.Size = new System.Drawing.Size(100, 18);
            this.labCartTotal.TabIndex = 16;
            this.labCartTotal.Text = "商品小計 NT$ ";
            this.labCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(522, 266);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 62);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(5, 25);
            this.linkLabel1.Location = new System.Drawing.Point(3, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(556, 22);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "合作洽談：CatchaShop@gmail.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(556, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "※貓抓股份有限公司版權所有";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(3, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(556, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Copyright © 2020 All rights reserved";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSendOrder.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendOrder.Location = new System.Drawing.Point(706, 63);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(194, 35);
            this.btnSendOrder.TabIndex = 25;
            this.btnSendOrder.Text = "送出訂單";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // labOrderTotal
            // 
            this.labOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labOrderTotal.AutoSize = true;
            this.labOrderTotal.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOrderTotal.ForeColor = System.Drawing.Color.Red;
            this.labOrderTotal.Location = new System.Drawing.Point(737, 18);
            this.labOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labOrderTotal.Name = "labOrderTotal";
            this.labOrderTotal.Size = new System.Drawing.Size(107, 24);
            this.labOrderTotal.TabIndex = 24;
            this.labOrderTotal.Text = "總計 NT$ 0";
            this.labOrderTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Cart2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1608, 1055);
            this.Controls.Add(this.splitContainerCartDetails);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Cart2";
            this.Text = "Frm_Cart2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CartDetailsPage_Load);
            this.splitContainerCartDetails.Panel1.ResumeLayout(false);
            this.splitContainerCartDetails.Panel1.PerformLayout();
            this.splitContainerCartDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCartDetails)).EndInit();
            this.splitContainerCartDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainerTotal.Panel1.ResumeLayout(false);
            this.splitContainerTotal.Panel1.PerformLayout();
            this.splitContainerTotal.Panel2.ResumeLayout(false);
            this.splitContainerTotal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTotal)).EndInit();
            this.splitContainerTotal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerCartDetails;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainerTotal;
        private System.Windows.Forms.Label labLoyaltyPointsValue;
        private System.Windows.Forms.Label labCouponValue;
        private System.Windows.Forms.Label labShippment;
        private System.Windows.Forms.Label labCartTotal;
        private System.Windows.Forms.Label labNote2;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Label labOrderTotal;
        private System.Windows.Forms.Label labRecipientInfo;
        private System.Windows.Forms.CheckBox ckbUseLoyaltyPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSelectCoupon;
        private System.Windows.Forms.ComboBox cmbSelectPaymentMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCartList;
        private System.Windows.Forms.ComboBox cmbCommonAddress;
        private System.Windows.Forms.Label labCommonAddress;
        private System.Windows.Forms.RadioButton recipientAsCommonAddress;
        private System.Windows.Forms.RadioButton recipientAsMemberInfo;
        private System.Windows.Forms.RadioButton recipientInputAddress;
        private System.Windows.Forms.TextBox txtRecipientAddress;
        private System.Windows.Forms.TextBox txtRecipientPhone;
        private System.Windows.Forms.TextBox txtRecipientName;
        private System.Windows.Forms.Label labRecipientAddress;
        private System.Windows.Forms.Label labRecipient;
        private System.Windows.Forms.Label labRecipientPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labCartDetails;
        private System.Windows.Forms.Label labNote;
        private CatCha.UserToolStrip userToolStrip1;
    }
}

