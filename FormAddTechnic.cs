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
            dateTimePickerPurchaseDate.Value = technic.PurchaseDate ?? DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewTechnic = new Technic
            {
                Name = textBoxName.Text,
                Model = textBoxModel.Text,
                SerialNumber = textBoxSerialNumber.Text,
                PurchaseDate = dateTimePickerPurchaseDate.Value
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
