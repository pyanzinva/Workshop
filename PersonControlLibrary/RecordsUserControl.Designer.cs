namespace WorkShopControlLib
{
    partial class RecordsUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idText = new TextBox();
            IDLabel = new Label();
            DateLabel = new Label();
            Datetextbox = new TextBox();
            DeviceLabel = new Label();
            DeviceTextBox = new TextBox();
            DescriptionLabel = new Label();
            DescTextBox = new TextBox();
            ErrorLabel = new Label();
            ErrorTextBox = new TextBox();
            buttonEdit = new Button();
            buttonDel = new Button();
            ClientLabel = new Label();
            ClientTextBox = new TextBox();
            EMPlabel = new Label();
            EMPtextbox = new TextBox();
            Statuslabel = new Label();
            cmbStatus = new ComboBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // idText
            // 
            idText.BackColor = Color.White;
            idText.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idText.Location = new Point(32, 53);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(53, 35);
            idText.TabIndex = 0;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(32, 13);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(37, 28);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(141, 13);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(56, 28);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Дата";
            // 
            // Datetextbox
            // 
            Datetextbox.BackColor = Color.White;
            Datetextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Datetextbox.Location = new Point(101, 53);
            Datetextbox.Name = "Datetextbox";
            Datetextbox.ReadOnly = true;
            Datetextbox.Size = new Size(166, 35);
            Datetextbox.TabIndex = 2;
            // 
            // DeviceLabel
            // 
            DeviceLabel.AutoSize = true;
            DeviceLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceLabel.Location = new Point(274, 13);
            DeviceLabel.Name = "DeviceLabel";
            DeviceLabel.Size = new Size(121, 28);
            DeviceLabel.TabIndex = 5;
            DeviceLabel.Text = "Устройство";
            // 
            // DeviceTextBox
            // 
            DeviceTextBox.BackColor = Color.White;
            DeviceTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceTextBox.Location = new Point(274, 53);
            DeviceTextBox.Name = "DeviceTextBox";
            DeviceTextBox.ReadOnly = true;
            DeviceTextBox.Size = new Size(150, 35);
            DeviceTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(440, 13);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(109, 28);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Описание";
            // 
            // DescTextBox
            // 
            DescTextBox.BackColor = Color.White;
            DescTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescTextBox.Location = new Point(440, 53);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.ReadOnly = true;
            DescTextBox.Size = new Size(150, 35);
            DescTextBox.TabIndex = 6;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.Location = new Point(605, 13);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(102, 28);
            ErrorLabel.TabIndex = 9;
            ErrorLabel.Text = "Поломка";
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.BackColor = Color.White;
            ErrorTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorTextBox.Location = new Point(605, 53);
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.ReadOnly = true;
            ErrorTextBox.Size = new Size(127, 35);
            ErrorTextBox.TabIndex = 8;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(1174, 25);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(119, 37);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDel.Location = new Point(1174, 68);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(119, 37);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientLabel.Location = new Point(739, 13);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(82, 28);
            ClientLabel.TabIndex = 13;
            ClientLabel.Text = "Клиент";
            // 
            // ClientTextBox
            // 
            ClientTextBox.BackColor = Color.White;
            ClientTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientTextBox.Location = new Point(739, 53);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.ReadOnly = true;
            ClientTextBox.Size = new Size(130, 35);
            ClientTextBox.TabIndex = 12;
            // 
            // EMPlabel
            // 
            EMPlabel.AutoSize = true;
            EMPlabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPlabel.Location = new Point(877, 13);
            EMPlabel.Name = "EMPlabel";
            EMPlabel.Size = new Size(112, 28);
            EMPlabel.TabIndex = 15;
            EMPlabel.Text = "Сотрудник";
            // 
            // EMPtextbox
            // 
            EMPtextbox.BackColor = Color.White;
            EMPtextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPtextbox.Location = new Point(877, 53);
            EMPtextbox.Name = "EMPtextbox";
            EMPtextbox.ReadOnly = true;
            EMPtextbox.Size = new Size(130, 35);
            EMPtextbox.TabIndex = 14;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Statuslabel.Location = new Point(1014, 13);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(72, 28);
            Statuslabel.TabIndex = 22;
            Statuslabel.Text = "Статус";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(1014, 53);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 36);
            cmbStatus.TabIndex = 21;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 117);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1311, 10);
            progressBar1.TabIndex = 23;
            // 
            // RecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(progressBar1);
            Controls.Add(Statuslabel);
            Controls.Add(cmbStatus);
            Controls.Add(EMPlabel);
            Controls.Add(EMPtextbox);
            Controls.Add(ClientLabel);
            Controls.Add(ClientTextBox);
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(ErrorLabel);
            Controls.Add(ErrorTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescTextBox);
            Controls.Add(DeviceLabel);
            Controls.Add(DeviceTextBox);
            Controls.Add(DateLabel);
            Controls.Add(Datetextbox);
            Controls.Add(IDLabel);
            Controls.Add(idText);
            Name = "RecordsUserControl";
            Size = new Size(1311, 132);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idText;
        private Label IDLabel;
        private Label DateLabel;
        private TextBox Datetextbox;
        private Label DeviceLabel;
        private TextBox DeviceTextBox;
        private Label DescriptionLabel;
        private TextBox DescTextBox;
        private Label ErrorLabel;
        private TextBox ErrorTextBox;
        private Button buttonEdit;
        private Button buttonDel;
        private Label ClientLabel;
        private TextBox ClientTextBox;
        private Label EMPlabel;
        private TextBox EMPtextbox;
        private Label Statuslabel;
        public ComboBox cmbStatus;
        private ProgressBar progressBar1;
    }
}