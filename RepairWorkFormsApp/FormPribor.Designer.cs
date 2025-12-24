namespace RepairWorkFormsApp
{
    partial class FormPribor
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
            PriborGrid = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)PriborGrid).BeginInit();
            SuspendLayout();
            // 
            // PriborGrid
            // 
            PriborGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PriborGrid.Location = new Point(47, 24);
            PriborGrid.Name = "PriborGrid";
            PriborGrid.Size = new Size(410, 366);
            PriborGrid.TabIndex = 0;
            PriborGrid.CellContentClick += PriborGrid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(79, 411);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 411);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Возврат";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormPribor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PriborGrid);
            Name = "FormPribor";
            Text = "Приборы";
            Load += FormPribor_Load;
            ((System.ComponentModel.ISupportInitialize)PriborGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PriborGrid;
        private Button button1;
        private Button button2;
    }
}