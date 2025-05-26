namespace Practica
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            buttonExit = new Button();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // buttonExit
            // 
            resources.ApplyResources(buttonExit, "buttonExit");
            buttonExit.Name = "buttonExit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonStart
            // 
            resources.ApplyResources(buttonStart, "buttonStart");
            buttonStart.Name = "buttonStart";
            buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonStart);
            Controls.Add(buttonExit);
            Name = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Button buttonExit;
        private Button buttonStart;
    }
}