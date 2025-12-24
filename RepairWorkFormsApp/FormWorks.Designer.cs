namespace RepairWorkFormsApp
{
    partial class FormWorks
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
            button1 = new Button();
            button2 = new Button();
            WorksGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)WorksGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(73, 384);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Показать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(638, 384);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Возврат";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // WorksGrid
            // 
            WorksGrid.AllowUserToAddRows = false;
            WorksGrid.AllowUserToDeleteRows = false;
            WorksGrid.AllowUserToResizeColumns = false;
            WorksGrid.AllowUserToResizeRows = false;
            WorksGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WorksGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorksGrid.Location = new Point(27, 12);
            WorksGrid.MultiSelect = false;
            WorksGrid.Name = "WorksGrid";
            WorksGrid.ReadOnly = true;
            WorksGrid.ScrollBars = ScrollBars.Vertical;
            WorksGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorksGrid.Size = new Size(745, 356);
            WorksGrid.TabIndex = 2;
            WorksGrid.CellContentClick += WorksGrid_CellContentClick;
            // 
            // FormWorks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WorksGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormWorks";
            Text = "Учет выполненных ремонтных работ";
            Load += FormWorks_Load;
            ((System.ComponentModel.ISupportInitialize)WorksGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView WorksGrid;
    }
}