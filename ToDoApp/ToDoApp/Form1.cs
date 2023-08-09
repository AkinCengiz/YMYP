namespace ToDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string dateInfo = dtpDate.Value.ToShortDateString();
            string timeInfo = dtpTime.Value.ToShortTimeString();
            dgvToDo.Rows.Add(dateInfo, timeInfo, txtTitle.Text, txtDescription.Text);
            ClearControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateInfo = dtpDate.Value.ToShortDateString();
            string timeInfo = dtpTime.Value.ToShortTimeString();
            dgvToDo.CurrentRow.Cells[0].Value = dateInfo;
            dgvToDo.CurrentRow.Cells[1].Value = timeInfo;
            dgvToDo.CurrentRow.Cells[2].Value = txtTitle.Text;
            dgvToDo.CurrentRow.Cells[3].Value = txtDescription.Text;
            ClearControls();
        }

        private void dgvToDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDate.Value = Convert.ToDateTime(dgvToDo.CurrentRow.Cells[0].Value);
            dtpTime.Value = Convert.ToDateTime(dgvToDo.CurrentRow.Cells[1].Value);
            txtTitle.Text = dgvToDo.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgvToDo.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvToDo.Rows.RemoveAt(dgvToDo.SelectedRows[0].Index);
            txtTitle.Clear();
            txtDescription.Clear();

        }

        void ClearControls()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
        }
    }
}