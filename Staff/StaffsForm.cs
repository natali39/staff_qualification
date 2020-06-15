using System;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffsForm : Form
    {
        DataTable table = new DataTable();
        StaffService service = new StaffService();
        StaffFileRepository repository = new StaffFileRepository();

        int indexRow;

        public StaffsForm()
        {
            InitializeComponent();
            SetFormProperties();
        }

        public void SetFormProperties()
        {
            staffDataGridView.DataSource = GetTable();
            staffDataGridView.AllowUserToAddRows = false;
        }

        private DataTable GetTable()
        {
            return table = service.GetData(repository);
        }

        private void UpdateStaffsData()
        {
            service.UpdateData(repository, table);
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            var result = DialogResult.None;
            if (this.IsEmptyData())
                result = MessageBox.Show("Поля не заполнены. Будет добавлена пустая строка. Продолжить?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (!this.IsEmptyData() || result == DialogResult.Yes)
            {
                result = MessageBox.Show($"Добавить новую запись: {DataFromTextBoxes()} в таблицу?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    table.Rows.Add(idTextBox.Text, lastNameTextBox.Text, firstNameTextBox.Text, middleNameTextBox.Text, positionTextBox.Text);
            }
            staffDataGridView.DataSource = table;
            UpdateStaffsData();
            ClearTextBoxes();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Изменить текущую строку на: {DataFromTextBoxes()}?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow newDataRow = staffDataGridView.Rows[indexRow];
                    newDataRow.Cells[0].Value = idTextBox.Text;
                    newDataRow.Cells[1].Value = lastNameTextBox.Text;
                    newDataRow.Cells[2].Value = firstNameTextBox.Text;
                    newDataRow.Cells[3].Value = middleNameTextBox.Text;
                    newDataRow.Cells[4].Value = positionTextBox.Text;
                    UpdateStaffsData();
                    ClearTextBoxes();
                }
            }
            catch
            {
                MessageBox.Show("В таблице нет записей");
            }
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var currentIndex = staffDataGridView.CurrentRow.Index;
                var result = MessageBox.Show("Удалить запись?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    staffDataGridView.Rows.RemoveAt(currentIndex);
                    UpdateStaffsData();
                    ClearTextBoxes();
                }
            }
            catch
            {
                MessageBox.Show("В таблице нет записей");
            }
        }

        private void ClearTextBoxes()
        {
            idTextBox.Text = String.Empty;
            idTextBox.Focus();
            lastNameTextBox.Text = String.Empty;
            firstNameTextBox.Text = String.Empty;
            middleNameTextBox.Text = String.Empty;
            positionTextBox.Text = String.Empty;
            idTextBox.Focus();
        }

        private string DataFromTextBoxes()
        {
            return $"{idTextBox.Text} {lastNameTextBox.Text} {firstNameTextBox.Text} {middleNameTextBox.Text} {positionTextBox.Text}";
        }

        private bool IsEmptyData()
        {
            return idTextBox.Text == String.Empty &&
                   lastNameTextBox.Text == String.Empty &&
                   firstNameTextBox.Text == String.Empty &&
                   middleNameTextBox.Text == String.Empty &&
                   positionTextBox.Text == String.Empty;
        }

        private void staffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow selectedRow = staffDataGridView.Rows[indexRow];
            idTextBox.Text = selectedRow.Cells[0].Value.ToString();
            lastNameTextBox.Text = selectedRow.Cells[1].Value.ToString();
            firstNameTextBox.Text = selectedRow.Cells[2].Value.ToString();
            middleNameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            positionTextBox.Text = selectedRow.Cells[4].Value.ToString();
        }

        //private string GetFormatedLinesFromStaffDataGridView()
        //{
        //    var lines = string.Empty;
        //    var row = string.Empty;
        //    for (int i = 0; i < staffDataGridView.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < staffDataGridView.Rows[i].Cells.Count; j++)
        //        {
        //            if (j != staffDataGridView.Rows[i].Cells.Count - 1)
        //                row = row + staffDataGridView.Rows[i].Cells[j].Value + ";";
        //            else
        //                row = row + staffDataGridView.Rows[i].Cells[j].Value + Environment.NewLine;
        //        }
        //        lines = lines + row;
        //        row = string.Empty;
        //    }
        //    return lines;
        //}
    }
}
