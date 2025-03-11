using Application.Services;


namespace WinFormsApp
{
    public partial class Category : Form
    {
        private readonly CategoryService _categoryService;
        private ICollection<Domain.Entities.Category> _categories;

        public Category(CategoryService categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            _categories = _categoryService.GetAllCategories();
            dgvCategories.DataSource = _categories;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var id = _categoryService.AddCategory(name);
            textBoxId.Text = id.ToString();
            LoadCategories();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(textBoxId.Text);
            var name = textBoxName.Text;
            var idUpdated = _categoryService.UpdateCategory(id, name);
            textBoxId.Text = idUpdated.ToString();
            LoadCategories();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(textBoxId.Text);
            _categoryService.DeleteCategory(id);
            LoadCategories();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var manufacturer = _categoryService.GetCategoryByName(name);

            if (manufacturer != null)
            {
                string message = $"Название: {manufacturer.Name}";
                MessageBox.Show(message, "Информация о категории", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Категория не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}