namespace WinFormsApp
{
    partial class Category
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
            dgvCategories = new DataGridView();
            buttonName = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            labelId = new Label();
            textBoxId = new TextBox();
            buttonAdd = new Button();
            labelName = new Label();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
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
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(12, 62);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(428, 233);
            dgvCategories.TabIndex = 1;
            // 
            // buttonName
            // 
            buttonName.Location = new Point(526, 265);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(176, 25);
            buttonName.TabIndex = 21;
            buttonName.Text = "Найти по названию";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(684, 222);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 20;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(579, 222);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(619, 78);
            labelId.Name = "labelId";
            labelId.Size = new Size(94, 15);
            labelId.TabIndex = 18;
            labelId.Text = "Идентификатор";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(613, 110);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 17;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(470, 222);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(459, 78);
            labelName.Name = "labelName";
            labelName.Size = new Size(118, 15);
            labelName.TabIndex = 14;
            labelName.Text = "Название категории";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(462, 108);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 12;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 328);
            Controls.Add(buttonName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(buttonAdd);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(dgvCategories);
            Controls.Add(buttonBack);
            Name = "Category";
            Text = "Категории товаров";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private DataGridView dgvCategories;
        private Button buttonName;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label labelId;
        private TextBox textBoxId;
        private Button buttonAdd;
        private Label labelName;
        private TextBox textBoxName;
    }
}