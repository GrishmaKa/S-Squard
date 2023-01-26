using S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S_Squared_Entrprises_Personnel_System_Win
{
    public partial class Add_Emp : Form
    {
        private object employeeTableAdapter;

        public object S_SquaredDataSet { get; private set; }
        public object EmployeeTableAdapter { get; private set; }
        public object employeeBindingSource { get; private set; }

        public Add_Emp()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Emp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's_SquaredDataSet.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.s_SquaredDataSet.Manager);
            this.departmentTableAdapter.FillByDeptName(s_SquaredDataSet.Department);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's_SquaredDataSet.Employee' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.s_SquaredDataSet.Manager);
            // TODO: This line of code loads data into the 's_SquaredDataSet.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.s_SquaredDataSet.Manager);
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source=localhost;Initial Catalog=S_Squared;Integrated Security=True");
            sc.Open();
            com.Connection = sc;
            com.CommandText = (@"INSERT INTO Employee (first_name, last_name, manager_id, dept_id)" +
             " VALUES ('" + txt_fname.Text + "','" + txt_lname.Text + "'," + cmb_manager.SelectedValue + "," + lst_roles.SelectedValue + ")");
            com.ExecuteNonQuery();
            sc.Close();
            Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            Add_Emp.ActiveForm.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txt_empid.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            lst_roles.ClearSelected();
        }
    }
}
