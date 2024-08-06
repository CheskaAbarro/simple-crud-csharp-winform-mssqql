using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUDSampleWinForms
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        //varibles
        string connectionString = "Data Source=LAPTOP-Zephyrus\\SQLEXPRESS;Initial Catalog=CRUDWinForms;Integrated Security=True;TrustServerCertificate=True";

        //LOAD ALL RECORDS -------------------------------
        private void CRUD_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        //SAVE TO DB -------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    //SQL
                    string sqlQuery = "INSERT INTO CRUD_Basic (Name, Age) VALUES (" + "'" + txtName.Text + "'" + "," + "'" + txtAge.Text + "'" + ")";

                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    //Open conn, execute sql and close conn
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //Reload records
                    MessageBox.Show("Data saved!");
                    LoadAllRecords();
                }
                else
                {
                    MessageBox.Show("Fill out all text box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //CELL CLICKED DATA BIND -------------------------
        private void dataRecordsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //select entire row
                    dataRecordsView.Rows[e.RowIndex].Selected = true;

                    //retrieve data from selected row
                    DataGridViewRow selectedRow = dataRecordsView.Rows[e.RowIndex];

                    //bind data to txtbox
                    idLabel.Text = selectedRow.Cells["ID"].Value.ToString();
                    txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                    txtAge.Text = selectedRow.Cells["Age"].Value.ToString();

                    //enable buttons
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //EDIT AND SAVE TO DB ----------------------------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataRecordsView.SelectedRows.Count > 0)
                {
                    //retrieve ID from table
                    int selectedId = Convert.ToInt32(dataRecordsView.SelectedRows[0].Cells["ID"].Value);

                    //check if textbox is empty
                    if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAge.Text))
                    {
                        //SQL
                        string sqlQuery = "UPDATE CRUD_Basic SET Name=@Name, Age=@Age WHERE ID = @ID";

                        //assign sql connection and query
                        SqlConnection conn = new SqlConnection(connectionString);
                        SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                        //assign value from form to query 
                        cmd.Parameters.AddWithValue("@ID", idLabel.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text);

                        //Open conn, execute sql and close conn
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Record successfully updated!");

                        //clear out textbox
                        idLabel.Text = string.Empty;
                        txtName.Text = string.Empty;
                        txtAge.Text = string.Empty;

                        //enable buttons
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;

                        //reload records
                        LoadAllRecords();
                    }
                    else
                    {
                        MessageBox.Show("Fill out all boxes!");
                    }
                }
                else
                {
                    MessageBox.Show("No selected data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DELETE DATA FROM DB ----------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataRecordsView.SelectedRows.Count > 0)
                {
                    //retrieve ID from records
                    int selectedId = Convert.ToInt32(dataRecordsView.SelectedRows[0].Cells["ID"].Value);

                    //Confirm deletion
                    DialogResult resultConfirm = MessageBox.Show(
                        "Are you sure you want to delete this record?", 
                        "Confirm Deletion", MessageBoxButtons.YesNo);

                    //if user chose Yes
                    if (resultConfirm == DialogResult.Yes)
                    {
                        //SQL
                        string sqlQuery = "DELETE FROM CRUD_Basic WHERE ID = @ID";

                        //SQL connection and strings
                        SqlConnection conn = new SqlConnection(connectionString);
                        SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                        //assign value from form to query 
                        cmd.Parameters.AddWithValue("@ID", idLabel.Text);

                        //Open conn, execute sql and close conn
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Record successfully deleted!");

                        //clear out textbox
                        idLabel.Text = string.Empty;
                        txtName.Text = string.Empty;
                        txtAge.Text = string.Empty;

                        //enable buttons
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;

                        //reload records
                        LoadAllRecords();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Method ------------------------------
        //Retrieve all records from DB --------
        private void LoadAllRecords()
        {
            try
            {
                string sqlQuery = "SELECT * FROM CRUD_Basic";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataRecordsView.DataSource = dataTable;
                dataRecordsView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataRecordsView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataRecordsView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
