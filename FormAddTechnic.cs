using System;
using System.Windows.Forms;
using Practica.Models;

namespace Practica
{
    public partial class FormAddTechnic : Form
    {
        public Technic NewTechnic { get; private set; }

        public FormAddTechnic()
        {
            InitializeComponent();
        }

        public FormAddTechnic(Technic technic) : this()
        {
            textBoxName.Text = technic.Name;
            textBoxModel.Text = technic.Model;
            textBoxSerialNumber.Text = technic.SerialNumber;
            // Измените эту строку в конструкторе FormAddTechnic
            dateTimePickerPurchaseDate.Value = technic.PurchaseDate?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewTechnic = new Technic
            {
                Name = textBoxName.Text,
                Model = textBoxModel.Text,
                SerialNumber = textBoxSerialNumber.Text,
                PurchaseDate = DateOnly.FromDateTime(dateTimePickerPurchaseDate.Value) // Преобразование DateTime в DateOnly
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
