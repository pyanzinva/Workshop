namespace WorkShop
{
    partial class RecordsEditDialog
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
            SaveButton = new Button();
            EMPlabel = new Label();
            EMPtextboxdialog = new TextBox();
            ClientLabel = new Label();
            ClientTextBoxdialog = new TextBox();
            ErrorLabel = new Label();
            ErrorTextBoxdialog = new TextBox();
            DescriptionLabel = new Label();
            DescTextBoxdialog = new TextBox();
            DeviceLabel = new Label();
            DeviceTextBoxdialog = new TextBox();
            IDLabel = new Label();
            idTextdialog = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(124, 342);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(177, 45);
            SaveButton.TabIndex = 39;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += okButton_Click;
            // 
            // EMPlabel
            // 
            EMPlabel.AutoSize = true;
            EMPlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPlabel.Location = new Point(14, 269);
            EMPlabel.Name = "EMPlabel";
            EMPlabel.Size = new Size(111, 28);
            EMPlabel.TabIndex = 53;
            EMPlabel.Text = "Сотрудник";
            // 
            // EMPtextboxdialog
            // 
            EMPtextboxdialog.BackColor = Color.White;
            EMPtextboxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPtextboxdialog.Location = new Point(134, 269);
            EMPtextboxdialog.Name = "EMPtextboxdialog";
            EMPtextboxdialog.Size = new Size(130, 34);
            EMPtextboxdialog.TabIndex = 52;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientLabel.Location = new Point(14, 171);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(77, 28);
            ClientLabel.TabIndex = 51;
            ClientLabel.Text = "Клиент";
            // 
            // ClientTextBoxdialog
            // 
            ClientTextBoxdialog.BackColor = Color.White;
            ClientTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientTextBoxdialog.Location = new Point(97, 171);
            ClientTextBoxdialog.Name = "ClientTextBoxdialog";
            ClientTextBoxdialog.Size = new Size(130, 34);
            ClientTextBoxdialog.TabIndex = 50;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.Location = new Point(14, 64);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(95, 28);
            ErrorLabel.TabIndex = 49;
            ErrorLabel.Text = "Поломка";
            // 
            // ErrorTextBoxdialog
            // 
            ErrorTextBoxdialog.BackColor = Color.White;
            ErrorTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorTextBoxdialog.Location = new Point(115, 61);
            ErrorTextBoxdialog.Name = "ErrorTextBoxdialog";
            ErrorTextBoxdialog.Size = new Size(127, 34);
            ErrorTextBoxdialog.TabIndex = 48;
            ErrorTextBoxdialog.TextChanged += ErrorTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(14, 223);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(104, 28);
            DescriptionLabel.TabIndex = 47;
            DescriptionLabel.Text = "Описание";
            // 
            // DescTextBoxdialog
            // 
            DescTextBoxdialog.BackColor = Color.White;
            DescTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescTextBoxdialog.Location = new Point(124, 223);
            DescTextBoxdialog.Name = "DescTextBoxdialog";
            DescTextBoxdialog.Size = new Size(150, 34);
            DescTextBoxdialog.TabIndex = 46;
            // 
            // DeviceLabel
            // 
            DeviceLabel.AutoSize = true;
            DeviceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceLabel.Location = new Point(12, 120);
            DeviceLabel.Name = "DeviceLabel";
            DeviceLabel.Size = new Size(116, 28);
            DeviceLabel.TabIndex = 45;
            DeviceLabel.Text = "Устройство";
            // 
            // DeviceTextBoxdialog
            // 
            DeviceTextBoxdialog.BackColor = Color.White;
            DeviceTextBoxdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceTextBoxdialog.Location = new Point(134, 120);
            DeviceTextBoxdialog.Name = "DeviceTextBoxdialog";
            DeviceTextBoxdialog.Size = new Size(150, 34);
            DeviceTextBoxdialog.TabIndex = 44;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(14, 9);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(31, 28);
            IDLabel.TabIndex = 41;
            IDLabel.Text = "ID";
            // 
            // idTextdialog
            // 
            idTextdialog.BackColor = Color.White;
            idTextdialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTextdialog.Location = new Point(65, 9);
            idTextdialog.Name = "idTextdialog";
            idTextdialog.Size = new Size(99, 34);
            idTextdialog.TabIndex = 40;
            // 
            // RecordsEditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(421, 421);
            Controls.Add(EMPlabel);
            Controls.Add(EMPtextboxdialog);
            Controls.Add(ClientLabel);
            Controls.Add(ClientTextBoxdialog);
            Controls.Add(ErrorLabel);
            Controls.Add(ErrorTextBoxdialog);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescTextBoxdialog);
            Controls.Add(DeviceLabel);
            Controls.Add(DeviceTextBoxdialog);
            Controls.Add(IDLabel);
            Controls.Add(idTextdialog);
            Controls.Add(SaveButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecordsEditDialog";
            Text = "PresonEditDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label EMPlabel;
        private TextBox EMPtextboxdialog;
        private Label ClientLabel;
        private TextBox ClientTextBoxdialog;
        private Label ErrorLabel;
        private TextBox ErrorTextBoxdialog;
        private Label DescriptionLabel;
        private TextBox DescTextBoxdialog;
        private Label DeviceLabel;
        private TextBox DeviceTextBoxdialog;
        private Label IDLabel;
        private TextBox idTextdialog;
    }
}