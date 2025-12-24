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
    public partial class FormPribor : Form
    {
        int idMaster { get; set; }
        public FormPribor(int idMaster)
        {
            this.idMaster = idMaster;
            InitializeComponent();
        }
        public void LoadData()
        {
            using (RepairWorksContext db = new RepairWorksContext())
            {

                PriborGrid.DataSource = db.Devices.Select(d => new { Id = d.Id, Name = d.Name, Type = d.Type, ProductionDate = d.ProductionDate }).ToList();
                PriborGrid!.Columns["Id"]!.Visible = false;
                PriborGrid!.Columns["Id"]!.DisplayIndex = 0;

                PriborGrid!.Columns["Name"]!.HeaderText = "Название";
                PriborGrid!.Columns["Name"]!.DisplayIndex = 1;

                PriborGrid!.Columns["Type"]!.HeaderText = "Тип";
                PriborGrid!.Columns["Type"]!.DisplayIndex = 2;

                PriborGrid!.Columns["ProductionDate"]!.HeaderText = "Дата производства";
                PriborGrid!.Columns["ProductionDate"]!.DisplayIndex = 3;

                PriborGrid!.Refresh();
            }
        }
        private void FormPribor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PriborGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
