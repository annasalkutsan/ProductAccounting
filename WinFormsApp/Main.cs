using Application.Services;
using Domain.Entities;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        private readonly ProductService _productService;
        private readonly ManufacturerService _manufacturerService;
        private readonly CategoryService _categoryService;
        private ICollection<Product> _products;

        public Main(ProductService productService, ManufacturerService manufacturerService, CategoryService categoryService)
        {
            _productService = productService;
            _manufacturerService = manufacturerService;
            _categoryService = categoryService;
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            _products = _productService.GetAllProducts();
            dgvProducts.DataSource = _products;
        }

        private void btnShowDiscounted_Click(object sender, EventArgs e)
        {
            var discountedItems = _productService.GetDiscountedProducts();
            dgvProducts.DataSource = discountedItems;
        }

        private void buttonManufacture_Click(object sender, EventArgs e)
        {
            var manufacture = new Manufacture(_manufacturerService);
            manufacture.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            var category = new Category(_categoryService);
            category.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var price = decimal.Parse(textBoxPrice.Text);
            var id = _productService.AddProduct(textBoxName.Text, price, dateTimePicker.Value, textBoxBash.Text,
                Guid.Parse(textBoxManufacturer.Text), Guid.Parse(textBoxCategory.Text));
            textBoxId.Text = id.ToString();
            LoadProducts();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var price = decimal.Parse(textBoxPrice.Text);
            var id = Guid.Parse(textBoxId.Text);
            var idUpdated = _productService.UpdateProduct(id, textBoxName.Text, price, dateTimePicker.Value, textBoxBash.Text,
                Guid.Parse(textBoxManufacturer.Text), Guid.Parse(textBoxCategory.Text));
            textBoxId.Text = idUpdated.ToString();
            LoadProducts();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(textBoxId.Text);
            _productService.DeleteProduct(id);
            LoadProducts();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;

            var product = _productService.GetProductByDetails(name);

            if (product != null)
            {
                string message = $"Название: {product.Name}\nЦена: {product.Price}\n Дата истечения срока годности: {product.ExpiryDate}\n" +
                    $"Цена по скидке: {product.DiscountedPrice}\nНомер партии: {product.BatchNumber}";
                MessageBox.Show(message, "Информация о товаре", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Товар не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}
