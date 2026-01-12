namespace DDD_ERP_Sample.Forms.Item
{
    partial class ItemMasterRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStandardPrice;

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
            tableLayoutPanel = new TableLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblUnit = new Label();
            cmbUnit = new ComboBox();
            lblStandardPrice = new Label();
            txtStandardPrice = new TextBox();
            btnRegister = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tableLayoutPanel.Controls.Add(lblId, 0, 0);
            tableLayoutPanel.Controls.Add(txtId, 1, 0);
            tableLayoutPanel.Controls.Add(lblName, 0, 1);
            tableLayoutPanel.Controls.Add(txtName, 1, 1);
            tableLayoutPanel.Controls.Add(lblType, 0, 2);
            tableLayoutPanel.Controls.Add(cmbType, 1, 2);
            tableLayoutPanel.Controls.Add(lblUnit, 0, 3);
            tableLayoutPanel.Controls.Add(cmbUnit, 1, 3);
            tableLayoutPanel.Controls.Add(lblStandardPrice, 0, 4);
            tableLayoutPanel.Controls.Add(txtStandardPrice, 1, 4);
            tableLayoutPanel.Controls.Add(btnRegister, 1, 5);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(12, 12);
            tableLayoutPanel.Margin = new Padding(8);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(8);
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(776, 254);
            tableLayoutPanel.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(254, 17);
            txtId.Margin = new Padding(3, 3, 16, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(498, 22);
            txtId.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 1;
            lblName.Text = "名称";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(254, 57);
            txtName.Margin = new Padding(3, 3, 16, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(498, 22);
            txtName.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left;
            lblType.AutoSize = true;
            lblType.Location = new Point(11, 100);
            lblType.Name = "lblType";
            lblType.Size = new Size(37, 15);
            lblType.TabIndex = 2;
            lblType.Text = "種類";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(254, 94);
            cmbType.Margin = new Padding(3, 3, 16, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(498, 23);
            cmbType.TabIndex = 2;
            // 
            // lblUnit
            // 
            lblUnit.Anchor = AnchorStyles.Left;
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(11, 140);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(37, 15);
            lblUnit.TabIndex = 3;
            lblUnit.Text = "単位";
            // 
            // cmbUnit
            // 
            cmbUnit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(254, 134);
            cmbUnit.Margin = new Padding(3, 3, 16, 3);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(498, 23);
            cmbUnit.TabIndex = 3;
            // 
            // lblStandardPrice
            // 
            lblStandardPrice.Anchor = AnchorStyles.Left;
            lblStandardPrice.AutoSize = true;
            lblStandardPrice.Location = new Point(11, 180);
            lblStandardPrice.Name = "lblStandardPrice";
            lblStandardPrice.Size = new Size(67, 15);
            lblStandardPrice.TabIndex = 4;
            lblStandardPrice.Text = "標準価格";
            // 
            // txtStandardPrice
            // 
            txtStandardPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStandardPrice.Location = new Point(254, 177);
            txtStandardPrice.Margin = new Padding(3, 3, 16, 3);
            txtStandardPrice.Name = "txtStandardPrice";
            txtStandardPrice.Size = new Size(498, 22);
            txtStandardPrice.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Right;
            btnRegister.Location = new Point(632, 214);
            btnRegister.Margin = new Padding(3, 3, 16, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 28);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "登録";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // ItemMasterRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 288);
            Controls.Add(tableLayoutPanel);
            Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "ItemMasterRegisterForm";
            Padding = new Padding(12);
            Text = "品目マスタ登録";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private ComboBox cmbType;
        private ComboBox cmbUnit;
        private TextBox txtStandardPrice;
        private Button btnRegister;
    }
}