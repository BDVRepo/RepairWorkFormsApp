namespace RepairWorkFormsApp
{
    partial class FormAdd
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
            MiddleName = new TextBox();
            LastName = new TextBox();
            FirstName = new TextBox();
            Qualification = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            HireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // MiddleName
            // 
            MiddleName.Location = new Point(170, 54);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(162, 23);
            MiddleName.TabIndex = 0;
            // 
            // LastName
            // 
            LastName.Location = new Point(170, 130);
            LastName.Name = "LastName";
            LastName.Size = new Size(162, 23);
            LastName.TabIndex = 1;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(170, 92);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(162, 23);
            FirstName.TabIndex = 2;
            // 
            // Qualification
            // 
            Qualification.Location = new Point(170, 175);
            Qualification.Name = "Qualification";
            Qualification.Size = new Size(162, 23);
            Qualification.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(42, 384);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 383);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 7;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 8;
            label1.Text = "Фамилия";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 95);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 9;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 138);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 178);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Разряд";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 224);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата приема";
            // 
            // HireDate
            // 
            HireDate.Location = new Point(170, 218);
            HireDate.Name = "HireDate";
            HireDate.Size = new Size(162, 23);
            HireDate.TabIndex = 5;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(HireDate);
            Controls.Add(Qualification);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(MiddleName);
            Name = "FormAdd";
            Text = "Добавление мастера";
            Load += FormAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MiddleName;
        private TextBox LastName;
        private TextBox FirstName;
        private TextBox Qualification;
        private DateTimePicker HireDate;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        
    }
}