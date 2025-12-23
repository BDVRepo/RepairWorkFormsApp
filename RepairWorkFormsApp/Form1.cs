using RepairWorkFormsApp.Models;

namespace RepairWorkFormsApp
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd frm = new FormAdd(1, 0);
            frm.Owner = this;

            frm.Show();
        }

        public void LoadData()
        {
            using (RepairWorksContext db = new RepairWorksContext())
            {
                MasterGrid.DataSource = db.Masters.Select(d => new { Id = d.Id, MiddleName = d.MiddleName, FirstName = d.FirstName, LastName = d.LastName, Qualification = d.Qualification, HireDate = d.HireDate, Count = d.RepairJobs.Count() }).ToList();
                MasterGrid!.Columns["Id"]!.Visible = false;
                MasterGrid!.Columns["Id"]!.DisplayIndex = 0;

                MasterGrid!.Columns["MiddleName"]!.HeaderText = "Ôàìèëèÿ";
                MasterGrid!.Columns["MiddleName"]!.DisplayIndex = 1;

                MasterGrid!.Columns["FirstName"]!.HeaderText = "Èìÿ";
                MasterGrid!.Columns["FirstName"]!.DisplayIndex = 2;

                MasterGrid!.Columns["LastName"]!.HeaderText = "Îò÷åñòâî";
                MasterGrid!.Columns["LastName"]!.DisplayIndex = 3;

                MasterGrid!.Columns["Qualification"]!.HeaderText = "Ðàçðÿä";
                MasterGrid!.Columns["Qualification"]!.DisplayIndex = 4;

                MasterGrid!.Columns["HireDate"]!.HeaderText = "Äàòà ïðèåìà íà ðàáîòó";
                MasterGrid!.Columns["HireDate"]!.DisplayIndex = 5;

                MasterGrid!.Columns["Count"]!.HeaderText = "Âûïîëíåíî ðåìîíòíûõ ðàáîò";
                MasterGrid!.Columns["Count"]!.DisplayIndex = 6;

                MasterGrid!.Refresh();
            }
        }
        private void MasterForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MasterGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void MasterGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    MasterGrid.CurrentCell = MasterGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    MasterGrid.Rows[e.RowIndex].Selected = true;
                    MasterGrid.Focus();
                }
            }
            catch { }
        }

        private void ðåäàêòèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd frm = new FormAdd(2, Convert.ToInt32(MasterGrid.SelectedRows[0].Cells["Id"].Value));
            frm.Owner = this;

            frm.Show();
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RepairWorksContext db = new RepairWorksContext())
            {
                var master = db.Masters.FirstOrDefault(d => d.Id == Convert.ToInt32(MasterGrid.SelectedRows[0].Cells["Id"].Value));
                db.Remove(master);
                db.SaveChanges();
            }
            this.LoadData();
        }
    }
}
