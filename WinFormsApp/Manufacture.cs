using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Interfaces.Repositories;
using Application.Services;
using Domain.Entities;

namespace WinFormsApp
{
    public partial class Manufacture : Form
    {
        private readonly ManufacturerService _manufacturerService;
        private ICollection<Manufacturer> _manufacturers;

        public Manufacture(ManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
            InitializeComponent();
            LoadManufacturers();
        }

        private void LoadManufacturers()
        {
            _manufacturers = _manufacturerService.GetAllManufacturers();
            dgvManufacturers.DataSource = _manufacturers;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var contactInfo = textBoxContactInfo.Text;
            var id = _manufacturerService.AddManufacturer(name, contactInfo);
            textBoxId.Text = id.ToString();
            LoadManufacturers();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(textBoxId.Text);
            var name = textBoxName.Text;
            var contactInfo = textBoxContactInfo.Text;
            var idUpdated = _manufacturerService.UpdateManufacturer(id, name, contactInfo);
            textBoxId.Text = idUpdated.ToString();
            LoadManufacturers();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(textBoxId.Text);
            _manufacturerService.DeleteManufacturer(id);
            LoadManufacturers();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var manufacturer = _manufacturerService.GetManufacturerByName(name);

            if (manufacturer != null)
            {
                string message = $"Название: {manufacturer.Name}\nКонтактная информация: {manufacturer.ContactInfo ?? "Нет данных"}";
                MessageBox.Show(message, "Информация о производителе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Производитель не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
