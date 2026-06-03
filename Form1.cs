using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimaStudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_tima_3_StudentCoursesDBDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.db_tima_3_StudentCoursesDBDataSet.Students);
            this.dataGridView1.Columns[0].Visible = false;
            //this.dataGridView1.Columns[1].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedCells[0].RowIndex;
            if (selectedId != -1) {
                studentsTableAdapter
            }

            //var selectedIds = dataGridView1.SelectedRows
            //    .Cast<DataGridViewRow>()
            //    .Select(row => Convert.ToInt32(row.Cells["ID"].Value))
            //    .ToList();

            //MessageBox.Show(selectedIds.Select(id => id.ToString()).ToArray().);
        }
    }
}
