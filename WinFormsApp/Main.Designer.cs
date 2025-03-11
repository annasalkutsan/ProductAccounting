namespace WinFormsApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            btnShowDiscounted = new Button();
            buttonManufacture = new Button();
            buttonClose = new Button();
            buttonCategory = new Button();
            dateTimePicker = new DateTimePicker();
            textBoxName = new TextBox();
            textBoxBash = new TextBox();
            textBoxManufacturer = new TextBox();
            labelManufacturer = new Label();
            labelBash = new Label();
            labelName = new Label();
            labelCategory = new Label();
            textBoxCategory = new TextBox();
            labelExpiryDate = new Label();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            textBoxDiscountedPrice = new TextBox();
            labelDiscountedPrice = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            textBoxId = new TextBox();
            labelId = new Label();
            buttonDelete = new Button();
            buttonFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(727, 313);
            dgvProducts.TabIndex = 0;
            // 
            // btnShowDiscounted
            // 
            btnShowDiscounted.Location = new Point(12, 343);
            btnShowDiscounted.Name = "btnShowDiscounted";
            btnShowDiscounted.Size = new Size(112, 49);
            btnShowDiscounted.TabIndex = 1;
            btnShowDiscounted.Text = "Показать товары на скидке";
            btnShowDiscounted.UseVisualStyleBackColor = true;
            btnShowDiscounted.Click += btnShowDiscounted_Click;
            // 
            // buttonManufacture
            // 
            buttonManufacture.Location = new Point(275, 356);
            buttonManufacture.Name = "buttonManufacture";
            buttonManufacture.Size = new Size(103, 23);
            buttonManufacture.TabIndex = 2;
            buttonManufacture.Text = "Производители";
            buttonManufacture.UseVisualStyleBackColor = true;
            buttonManufacture.Click += buttonManufacture_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(1066, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.Location = new Point(161, 356);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(75, 23);
            buttonCategory.TabIndex = 4;
            buttonCategory.Text = "Категории";
            buttonCategory.UseVisualStyleBackColor = true;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(459, 369);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(459, 434);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxBash
            // 
            textBoxBash.Location = new Point(604, 434);
            textBoxBash.Name = "textBoxBash";
            textBoxBash.Size = new Size(100, 23);
            textBoxBash.TabIndex = 7;
            // 
            // textBoxManufacturer
            // 
            textBoxManufacturer.Location = new Point(459, 513);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.Size = new Size(100, 23);
            textBoxManufacturer.TabIndex = 8;
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Location = new Point(402, 482);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(180, 15);
            labelManufacturer.TabIndex = 9;
            labelManufacturer.Text = "Идентификатор производителя";
            // 
            // labelBash
            // 
            labelBash.AutoSize = true;
            labelBash.Location = new Point(604, 401);
            labelBash.Name = "labelBash";
            labelBash.Size = new Size(87, 15);
            labelBash.TabIndex = 10;
            labelBash.Text = "Номер партии";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(460, 401);
            labelName.Name = "labelName";
            labelName.Size = new Size(99, 15);
            labelName.TabIndex = 11;
            labelName.Text = "Название товара";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(604, 482);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(153, 15);
            labelCategory.TabIndex = 13;
            labelCategory.Text = "Идентификатор категории";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(604, 513);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(100, 23);
            textBoxCategory.TabIndex = 12;
            // 
            // labelExpiryDate
            // 
            labelExpiryDate.AutoSize = true;
            labelExpiryDate.Location = new Point(459, 343);
            labelExpiryDate.Name = "labelExpiryDate";
            labelExpiryDate.Size = new Size(180, 15);
            labelExpiryDate.TabIndex = 14;
            labelExpiryDate.Text = "Дата истечения срока годности";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(823, 398);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 15);
            labelPrice.TabIndex = 15;
            labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(823, 434);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 16;
            // 
            // textBoxDiscountedPrice
            // 
            textBoxDiscountedPrice.Location = new Point(823, 529);
            textBoxDiscountedPrice.Name = "textBoxDiscountedPrice";
            textBoxDiscountedPrice.Size = new Size(100, 23);
            textBoxDiscountedPrice.TabIndex = 18;
            // 
            // labelDiscountedPrice
            // 
            labelDiscountedPrice.AutoSize = true;
            labelDiscountedPrice.Location = new Point(823, 493);
            labelDiscountedPrice.Name = "labelDiscountedPrice";
            labelDiscountedPrice.Size = new Size(128, 15);
            labelDiscountedPrice.TabIndex = 17;
            labelDiscountedPrice.Text = "Цена с учетом скидки";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(30, 444);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 19;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(121, 444);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 20;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(930, 354);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 21;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(930, 327);
            labelId.Name = "labelId";
            labelId.Size = new Size(94, 15);
            labelId.TabIndex = 22;
            labelId.Text = "Идентификатор";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(220, 444);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 23;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(210, 529);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(75, 23);
            buttonFind.TabIndex = 24;
            buttonFind.Text = "Найти";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 621);
            Controls.Add(buttonFind);
            Controls.Add(buttonDelete);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDiscountedPrice);
            Controls.Add(labelDiscountedPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelExpiryDate);
            Controls.Add(labelCategory);
            Controls.Add(textBoxCategory);
            Controls.Add(labelName);
            Controls.Add(labelBash);
            Controls.Add(labelManufacturer);
            Controls.Add(textBoxManufacturer);
            Controls.Add(textBoxBash);
            Controls.Add(textBoxName);
            Controls.Add(dateTimePicker);
            Controls.Add(buttonCategory);
            Controls.Add(buttonClose);
            Controls.Add(buttonManufacture);
            Controls.Add(btnShowDiscounted);
            Controls.Add(dgvProducts);
            Name = "Main";
            Text = "Учет срока годности товаров";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnShowDiscounted;
        private Button buttonManufacture;
        private Button buttonClose;
        private Button buttonCategory;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxName;
        private TextBox textBoxBash;
        private TextBox textBoxManufacturer;
        private Label labelManufacturer;
        private Label labelBash;
        private Label labelName;
        private Label labelCategory;
        private TextBox textBoxCategory;
        private Label labelExpiryDate;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private TextBox textBoxDiscountedPrice;
        private Label labelDiscountedPrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private TextBox textBoxId;
        private Label labelId;
        private Button buttonDelete;
        private Button buttonFind;
    }
}
