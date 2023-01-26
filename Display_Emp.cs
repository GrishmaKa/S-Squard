using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Squared_Entrprises_Personnel_System_Win
{
    public partial class Display_frm : Form
    {
        public Display_frm()
        {
            InitializeComponent();
        }

        private void Display_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's_SquaredDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.s_SquaredDataSet.Employee);
            // TODO: This line of code loads data into the 's_SquaredDataSet.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.s_SquaredDataSet.Manager);
            employeeBindingSource.DataSource=this.s_SquaredDataSet.Employee;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.managerTableAdapter.FillBy(this.s_SquaredDataSet.Manager);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmb_managerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_managerList.Text))
            {
                DGV_Display.DataSource = employeeBindingSource;
            }
            else
            {
                string strmanager_id = cmb_managerList.SelectedValue.ToString();
                int manager_id = Int32.Parse(strmanager_id);
                this.employeeTableAdapter.FillBymanager_id(this.s_SquaredDataSet.Employee, manager_id);
            }
        }

        private void Add_emp_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Emp add_empfrm = new Add_Emp();
                add_empfrm.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                employeeBindingSource.ResetBindings(false);
            }
        }
    }
}
