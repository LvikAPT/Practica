using System;
using System.Linq;
using System.Windows.Forms;
using Practica.Models;

namespace Practica
{
    public partial class FormTechnic : Form
    {
        private DataBaseContext dbContext;

        public FormTechnic()
        {
            InitializeComponent();
            dbContext = new DataBaseContext();
            LoadData();
        }

        private void LoadData()
        {
            var technics = dbContext.Technics.ToList();
            dataGridView1.DataSource = technics;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var formAddTechnic = new FormAddTechnic())
            {
                if (formAddTechnic.ShowDialog() == DialogResult.OK)
                {
                    var newTechnic = formAddTechnic.NewTechnic;

                    dbContext.Technics.Add(newTechnic);
                    dbContext.SaveChanges();

                    LoadData(); // Обновление данных в DataGridView
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateTechnic();
        }

        private void UpdateTechnic()
        {
            if (dataGridView1.CurrentRow != null)
            {
                var technicId = (int)dataGridView1.CurrentRow.Cells["TechnicId"].Value;
                var technic = dbContext.Technics.Find(technicId);

                if (technic != null)
                {
                    using (var formAddTechnic = new FormAddTechnic(technic))
                    {
                        if (formAddTechnic.ShowDialog() == DialogResult.OK)
                        {
                            dbContext.SaveChanges();
                            LoadData();
                        }
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTechnic();
        }

        private void DeleteTechnic()
        {
            if (dataGridView1.CurrentRow != null)
            {
                var technicId = (int)dataGridView1.CurrentRow.Cells["TechnicId"].Value;
                var technic = dbContext.Technics.Find(technicId);

                if (technic != null)
                {
                    dbContext.Technics.Remove(technic);
                    dbContext.SaveChanges();
                    LoadData();
                }
            }
        }
        private void buttonShowHistory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var technicId = (int)dataGridView1.CurrentRow.Cells["TechnicId"].Value;
                FormRepairHistory formRepairHistory = new FormRepairHistory(technicId);
                formRepairHistory.ShowDialog();
            }
        }
    }
}
