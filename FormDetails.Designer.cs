namespace Practica
{
    partial class FormRepairHistory
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.dataGridViewRepairHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRepairHistory
            // 
            this.dataGridViewRepairHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepairHistory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRepairHistory.Name = "dataGridViewRepairHistory";
            this.dataGridViewRepairHistory.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewRepairHistory.TabIndex = 0;
            // 
            // FormRepairHistory
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRepairHistory);
            this.Name = "FormRepairHistory";
            this.Text = "История ремонтов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairHistory)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.DataGridView dataGridViewRepairHistory;
    }
}
