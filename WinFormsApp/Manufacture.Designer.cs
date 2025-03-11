namespace WinFormsApp
{
    partial class Manufacture
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
            buttonBack = new Button();
            dgvManufacturers = new DataGridView();
            textBoxName = new TextBox();
            textBoxContactInfo = new TextBox();
            labelName = new Label();
            labelContactInfo = new Label();
            buttonAdd = new Button();
            textBoxId = new TextBox();
            labelId = new Label();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonName = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturers).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dgvManufacturers
            // 
            dgvManufacturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturers.Location = new Point(12, 52);
            dgvManufacturers.Name = "dgvManufacturers";
            dgvManufacturers.Size = new Size(495, 288);
            dgvManufacturers.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(531, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxContactInfo
            // 
            textBoxContactInfo.Location = new Point(716, 82);
            textBoxContactInfo.Name = "textBoxContactInfo";
            textBoxContactInfo.Size = new Size(100, 23);
            textBoxContactInfo.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(528, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(158, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Название/Имя поставщика";
            // 
            // labelContactInfo
            // 
            labelContactInfo.AutoSize = true;
            labelContactInfo.Location = new Point(713, 52);
            labelContactInfo.Name = "labelContactInfo";
            labelContactInfo.Size = new Size(139, 15);
            labelContactInfo.TabIndex = 5;
            labelContactInfo.Text = "Контакная информация";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(537, 231);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(531, 161);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 7;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(537, 129);
            labelId.Name = "labelId";
            labelId.Size = new Size(94, 15);
            labelId.TabIndex = 8;
            labelId.Text = "Идентификатор";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(646, 231);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(751, 231);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonName
            // 
            buttonName.Location = new Point(593, 274);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(176, 25);
            buttonName.TabIndex = 11;
            buttonName.Text = "Найти по названию/имени";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // Manufacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 484);
            Controls.Add(buttonName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(buttonAdd);
            Controls.Add(labelContactInfo);
            Controls.Add(labelName);
            Controls.Add(textBoxContactInfo);
            Controls.Add(textBoxName);
            Controls.Add(dgvManufacturers);
            Controls.Add(buttonBack);
            Name = "Manufacture";
            Text = "Производители";
            ((System.ComponentModel.ISupportInitialize)dgvManufacturers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private DataGridView dgvManufacturers;
        private TextBox textBoxName;
        private TextBox textBoxContactInfo;
        private Label labelName;
        private Label labelContactInfo;
        private Button buttonAdd;
        private TextBox textBoxId;
        private Label labelId;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonName;
    }
}