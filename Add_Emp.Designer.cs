namespace S_Squared_Entrprises_Personnel_System_Win
{
    partial class Add_Emp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst_roles = new System.Windows.Forms.ListBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_SquaredDataSet = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSet();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.lbl_roles = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_empid = new System.Windows.Forms.Label();
            this.cmb_manager = new System.Windows.Forms.ComboBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_manager = new System.Windows.Forms.Label();
            this.Add_new_emp = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.managerTableAdapter = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.ManagerTableAdapter();
            this.departmentTableAdapter = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.DepartmentTableAdapter();
            this.tableAdapterManager = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter1 = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.EmployeeTableAdapter();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_SquaredDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lst_roles);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_lname);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.txt_empid);
            this.panel1.Controls.Add(this.lbl_roles);
            this.panel1.Controls.Add(this.lbl_lastname);
            this.panel1.Controls.Add(this.lbl_fname);
            this.panel1.Controls.Add(this.lbl_empid);
            this.panel1.Controls.Add(this.cmb_manager);
            this.panel1.Controls.Add(this.lbl_manager);
            this.panel1.Controls.Add(this.Add_new_emp);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BorderStyle", this.bindingSource1, "emp_id", true));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 988);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lst_roles
            // 
            this.lst_roles.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "dept_id", true));
            this.lst_roles.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.bindingSource1, "dept_id", true));
            this.lst_roles.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "dept_id", true));
            this.lst_roles.DataSource = this.departmentBindingSource;
            this.lst_roles.DisplayMember = "dept_name";
            this.lst_roles.FormattingEnabled = true;
            this.lst_roles.ItemHeight = 32;
            this.lst_roles.Location = new System.Drawing.Point(534, 545);
            this.lst_roles.Name = "lst_roles";
            this.lst_roles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_roles.Size = new System.Drawing.Size(460, 356);
            this.lst_roles.TabIndex = 13;
            this.lst_roles.ValueMember = "dept_id";
            
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.s_SquaredDataSet;
            // 
            // s_SquaredDataSet
            // 
            this.s_SquaredDataSet.DataSetName = "S_SquaredDataSet";
            this.s_SquaredDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(802, 916);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 54);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(547, 916);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 54);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.s_SquaredDataSet, "Employee.last_name", true));
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(534, 489);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(460, 39);
            this.txt_lname.TabIndex = 9;
            // 
            // txt_fname
            // 
            this.txt_fname.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.s_SquaredDataSet, "Employee.first_name", true));
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(534, 378);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(460, 39);
            this.txt_fname.TabIndex = 8;
            // 
            // txt_empid
            // 
            this.txt_empid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.s_SquaredDataSet, "Employee.emp_id", true));
            this.txt_empid.Enabled = false;
            this.txt_empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.Location = new System.Drawing.Point(534, 279);
            this.txt_empid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(460, 39);
            this.txt_empid.TabIndex = 7;
            // 
            // lbl_roles
            // 
            this.lbl_roles.AutoSize = true;
            this.lbl_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roles.Location = new System.Drawing.Point(420, 565);
            this.lbl_roles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_roles.Name = "lbl_roles";
            this.lbl_roles.Size = new System.Drawing.Size(87, 32);
            this.lbl_roles.TabIndex = 6;
            this.lbl_roles.Text = "Roles";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(354, 486);
            this.lbl_lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(150, 32);
            this.lbl_lastname.TabIndex = 5;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(354, 375);
            this.lbl_fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(151, 32);
            this.lbl_fname.TabIndex = 4;
            this.lbl_fname.Text = "First Name";
            // 
            // lbl_empid
            // 
            this.lbl_empid.AutoSize = true;
            this.lbl_empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empid.Location = new System.Drawing.Point(328, 275);
            this.lbl_empid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(175, 32);
            this.lbl_empid.TabIndex = 3;
            this.lbl_empid.Text = "Employee ID";
            // 
            // cmb_manager
            // 
            this.cmb_manager.DataSource = this.managerBindingSource;
            this.cmb_manager.DisplayMember = "manager_name";
            this.cmb_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_manager.FormattingEnabled = true;
            this.cmb_manager.Location = new System.Drawing.Point(534, 162);
            this.cmb_manager.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_manager.Name = "cmb_manager";
            this.cmb_manager.Size = new System.Drawing.Size(460, 40);
            this.cmb_manager.TabIndex = 2;
            this.cmb_manager.ValueMember = "manager_id";
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.s_SquaredDataSet;
            // 
            // lbl_manager
            // 
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manager.Location = new System.Drawing.Point(372, 162);
            this.lbl_manager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(134, 32);
            this.lbl_manager.TabIndex = 1;
            this.lbl_manager.Text = "Manager:";
            // 
            // Add_new_emp
            // 
            this.Add_new_emp.AutoSize = true;
            this.Add_new_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_new_emp.Location = new System.Drawing.Point(552, 28);
            this.Add_new_emp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Add_new_emp.Name = "Add_new_emp";
            this.Add_new_emp.Size = new System.Drawing.Size(432, 54);
            this.Add_new_emp.TabIndex = 0;
            this.Add_new_emp.Text = "Add New Employee";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Employee";
            this.bindingSource1.DataSource = this.s_SquaredDataSet;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.fillByToolStrip.Size = new System.Drawing.Size(1524, 44);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(64, 34);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.s_SquaredDataSet;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            this.empidDataGridViewTextBoxColumn.Width = 175;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // manageridDataGridViewTextBoxColumn
            // 
            this.manageridDataGridViewTextBoxColumn.DataPropertyName = "manager_id";
            this.manageridDataGridViewTextBoxColumn.HeaderText = "manager_id";
            this.manageridDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.manageridDataGridViewTextBoxColumn.Name = "manageridDataGridViewTextBoxColumn";
            this.manageridDataGridViewTextBoxColumn.Width = 175;
            // 
            // deptidDataGridViewTextBoxColumn
            // 
            this.deptidDataGridViewTextBoxColumn.DataPropertyName = "dept_id";
            this.deptidDataGridViewTextBoxColumn.HeaderText = "dept_id";
            this.deptidDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.deptidDataGridViewTextBoxColumn.Name = "deptidDataGridViewTextBoxColumn";
            this.deptidDataGridViewTextBoxColumn.Width = 175;
            // 
            // Add_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 1062);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Emp";
            this.Text = "Add_Emp";
            this.Load += new System.EventHandler(this.Add_Emp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_SquaredDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Label lbl_roles;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_empid;
        private System.Windows.Forms.ComboBox cmb_manager;
        private System.Windows.Forms.Label lbl_manager;
        private System.Windows.Forms.Label Add_new_emp;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private S_SquaredDataSet s_SquaredDataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private S_SquaredDataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private S_SquaredDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private S_SquaredDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ListBox lst_roles;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private S_SquaredDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptidDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.BindingSource managerBindingSource1;
    }
}