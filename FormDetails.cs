using System;
using System.Linq;
using System.Windows.Forms;
using Practica.Models;
namespace Practica
{
    public partial class FormRepairHistory : Form
    {
        private DataBaseContext dbContext;
        private int technicId;
        public FormRepairHistory(int technicId)
        {
            InitializeComponent();
            this.technicId = technicId;
            dbContext = new DataBaseContext();
            LoadRepairHistory();
        }
        private void LoadRepairHistory()
        {
            var repairHistory = dbContext.RepairHistories
                .Where(r => r.TechnicId == technicId)
                .ToList();
            dataGridViewRepairHistory.DataSource = repairHistory;
        }
    }
}