using RepairWorkFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RepairWorkFormsApp
{
    public partial class FormWorks : Form
    {
        public FormWorks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RepairWorksContext db = new RepairWorksContext())
            {
                WorksGrid.DataSource = db.Devices.ToList();
            }
        }
        public void LoadData()
        {
            using (RepairWorksContext db = new RepairWorksContext())
            {
                WorksGrid.DataSource = db.RepairJobs.Select(d => new
                {
                    Id = d.Id,
                    Device = d.Device.Name,
                    Master = d.Master.FirstName,
                    OwnerName = d.OwnerName,
                    Breakdown = d.Breakdown,
                    ReceivedDate = d.ReceivedDate,
                    RepairCost = d.RepairCost,
                }).ToList();
                WorksGrid!.Columns["Id"]!.Visible = false;
                WorksGrid!.Columns["Id"]!.DisplayIndex = 0;

                WorksGrid!.Columns["Master"]!.HeaderText = "Мастер";
                WorksGrid!.Columns["Master"]!.DisplayIndex = 1;

                WorksGrid!.Columns["Device"]!.HeaderText = "Прибор";
                WorksGrid!.Columns["Device"]!.DisplayIndex = 2;

                WorksGrid!.Columns["OwnerName"]!.HeaderText = "Владелец";
                WorksGrid!.Columns["OwnerName"]!.DisplayIndex = 3;

                WorksGrid!.Columns["Breakdown"]!.HeaderText = "Вид поломки";
                WorksGrid!.Columns["Breakdown"]!.DisplayIndex = 4;

                WorksGrid!.Columns["ReceivedDate"]!.HeaderText = "Дата приема";
                WorksGrid!.Columns["ReceivedDate"]!.DisplayIndex = 5;

                WorksGrid!.Columns["RepairCost"]!.HeaderText = "Стоимость ремонта";
                WorksGrid!.Columns["RepairCost"]!.DisplayIndex = 6;

                WorksGrid!.Refresh();
            }
        }
        private void WorksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormWorks_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
