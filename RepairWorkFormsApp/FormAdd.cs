using RepairWorkFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RepairWorkFormsApp
{
    public partial class FormAdd : Form
    {
        int oper { get; set; }
        int idMaster { get; set; }
        public FormAdd(int oper, int idMaster)
        {
            this.oper = oper;
            this.idMaster = idMaster;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                this.Text = "Добавить сотрудника";
                button2.Text = "Добавить";
                this.MiddleName.Text = "";
                this.FirstName.Text = "";
                this.LastName.Text = "";
                this.Qualification.Text = "";
                this.HireDate.Value = DateTime.Now;
            }
            else
            {
                button2.Text = "Редактировать";
                this.Text = "Редактровать данные мастера";
                using (RepairWorksContext db = new RepairWorksContext())
                {
                    var master = db.Masters.FirstOrDefault(d => d.Id == idMaster);
                    this.MiddleName.Text = master!.MiddleName;
                    this.FirstName.Text = master!.FirstName;
                    this.LastName.Text = master!.LastName;
                    this.Qualification.Text = master!.Qualification;
                    this.HireDate.Value = master!.HireDate.ToDateTime(TimeOnly.MinValue);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                if (string.IsNullOrEmpty(this.MiddleName.Text)
                    || string.IsNullOrEmpty(this.FirstName.Text)
                    || string.IsNullOrEmpty(this.LastName.Text)
                    || string.IsNullOrEmpty(this.Qualification.Text)
                    || string.IsNullOrEmpty(this.HireDate.Text))
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    using (RepairWorksContext db = new RepairWorksContext())
                    {
                        Master master = new Master
                        {
                            MiddleName = this.MiddleName.Text,
                            FirstName = this.FirstName.Text,
                            LastName = this.LastName.Text,
                            Qualification = this.Qualification.Text,
                            HireDate = DateOnly.FromDateTime(this.HireDate.Value)
                        };

                        db.Add(master);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.MiddleName.Text)
                   || string.IsNullOrEmpty(this.FirstName.Text)
                   || string.IsNullOrEmpty(this.LastName.Text)
                   || string.IsNullOrEmpty(this.Qualification.Text)
                   || string.IsNullOrEmpty(this.HireDate.Text))
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    using (RepairWorksContext db = new RepairWorksContext())
                    {
                        var master = db.Masters.FirstOrDefault(d => d.Id == this.idMaster);
                        master!.MiddleName = this.MiddleName.Text;
                        master!.FirstName = this.FirstName.Text;
                        master!.LastName = this.LastName.Text;
                        master!.Qualification = this.Qualification.Text;
                        master!.HireDate = DateOnly.FromDateTime(this.HireDate.Value);

                        db.SaveChanges();
                    }
                }
            }

            MasterForm? masterf = this.Owner as MasterForm;

            masterf!.LoadData();
            masterf!.Refresh();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
