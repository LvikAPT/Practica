namespace Practica
{
    partial class FormAddTechnic
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.PlaceholderText = "Название";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 38);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(260, 20);
            this.textBoxModel.TabIndex = 1;
            this.textBoxModel.PlaceholderText = "Модель";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(12, 64);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(260, 20);
            this.textBoxSerialNumber.TabIndex = 2;
            this.textBoxSerialNumber.PlaceholderText = "Серийный номер";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(12, 90);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerPurchaseDate.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(260, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAddTechnic
            // 
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerPurchaseDate);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddTechnic";
            this.Text = "Добавить технику";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.Button buttonSave;
    }
}
