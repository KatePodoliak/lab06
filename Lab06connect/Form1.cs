using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab06connect
{
    public partial class Form1 : Form
    {
        static string source = @"WIN-5UUGETFTJ1E\SQLEXPRESS"; //сервер
        static string catalog = "library"; //база данных
        string connString = "Data Source=" + source + ";Initial Catalog=" + catalog + ";Integrated Security=True";
        string str = "", sql;

        public Form1()
        {
            InitializeComponent();
            cmbCommand1.Items.Add("Select");
            cmbCommand1.Items.Add("Search");
            cmbCommand1.Items.Add("Sort");
            cmbCommand1.SelectedIndex = 0;
            cmbSort.Items.Add("ASC");
            cmbSort.Items.Add("DESC");
            cmbSort.SelectedIndex = 0;
            cmbCommand.Items.Add("Insert");
            cmbCommand.Items.Add("Delete");
            cmbCommand.Items.Add("Update");
            cmbCommand.SelectedIndex = 0;
            label10.Text = "Fields:";
            label11.Text = "Values:";
            textBoxFields.Visible = true;
            textBoxValuesCmd.Visible = true;
            textBoxSet.Visible = false;
            textBoxWhere.Visible = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    labelInfo.Text = "Connection...\nConnection successful!\nServer: " + source + "\nDatabase: " + catalog;
                    btnCmd1.Enabled = true;
                    btnCmd2.Enabled = true;
                    btnDoQuery.Enabled = true;
                }
            }
            catch
            {

                labelInfo.Text = "Connection...\nConnection failed!\n";
                btnCmd1.Enabled = false;
                btnCmd2.Enabled = false;
                btnDoQuery.Enabled = false;
            }
           
        }

        private void btnDoQuery_Click(object sender, EventArgs e)
        {
            try
            {
                sql = textBoxQuery.Text;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgwData.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Input valid parameters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCommand.Text)
            {
                case "Insert":
                    label10.Text = "Fields:";
                    label11.Text = "Values:";
                    textBoxFields.Visible = true;
                    textBoxValuesCmd.Visible = true;
                    textBoxSet.Visible = false;
                    textBoxWhere.Visible = false;
                    break;
                case "Delete":
                    label10.Text = "Set:";
                    label11.Text = "Where:";
                    textBoxFields.Visible = false;
                    textBoxValuesCmd.Visible = false;
                    textBoxSet.Visible = true;
                    textBoxWhere.Visible = true;
                    break;
                case "Update":
                    label10.Text = "Set:";
                    label11.Text = "Where:";
                    textBoxFields.Visible = false;
                    textBoxValuesCmd.Visible = false;
                    textBoxSet.Visible = true;
                    textBoxWhere.Visible = true;
                    break;
            }
        }

        private void btnCmd2_Click(object sender, EventArgs e)
        {
            str = "Input valid parameters!";
            try
            {
                switch (cmbCommand.Text)
                {
                    case "Insert":
                        sql = "INSERT " + textBoxTableCmd.Text + "(" + textBoxFields.Text + ")" + "VALUES(" + textBoxValuesCmd.Text + ")";
                        break;
                    case "Delete":
                        sql = "DELETE FROM " + textBoxTableCmd.Text + " WHERE " + textBoxWhere.Text;
                        break;
                    case "Update":
                        sql = "UPDATE " + textBoxTableCmd.Text + " SET " + textBoxSet.Text + " WHERE " + textBoxWhere.Text;
                        break;
                    default:
                        break;
                }
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        con.Close();
                    }
                }
                sql = "SELECT" + " * " + "FROM" + " " + textBoxTableCmd.Text;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgwData.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCmd1_Click(object sender, EventArgs e)
        {
            str = "Input valid parameters!";
            try
            {
                switch (cmbCommand1.Text)
                {
                    case "Select":
                        if (textBoxTable.Text.Length == 0)
                            str = "Input name of table!";
                        sql = "SELECT" + " * " + "FROM" + " " + textBoxTable.Text;
                        break;
                    case "Search":
                        if (textBoxTable.Text.Length == 0 || textBoxAttribute.Text.Length == 0 || textBoxValue.Text.Length == 0)
                            str = "Input parameters!";
                        sql = "SELECT * FROM " + textBoxTable.Text + " WHERE " + textBoxAttribute.Text + " ='" + textBoxValue.Text + "'";
                        break;
                    case "Sort":
                        if (textBoxTable.Text.Length == 0 || textBoxAttribute.Text.Length == 0)
                            str = "Input parameters!";
                        sql = "SELECT * FROM " + textBoxTable.Text + " ORDER BY " + textBoxAttribute.Text + " " + cmbSort.Text;
                        break;
                    default:
                        break;
                }
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgwData.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
