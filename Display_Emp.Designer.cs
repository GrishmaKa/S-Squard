namespace S_Squared_Entrprises_Personnel_System_Win
{
    partial class Display_frm
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
            this.Form_name = new System.Windows.Forms.Label();
            this.cmb_managerList = new System.Windows.Forms.ComboBox();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.s_SquaredDataSet = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSet();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_emp = new System.Windows.Forms.Button();
            this.DGV_Display = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.ManagerTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeeTableAdapter = new S_Squared_Entrprises_Personnel_System_Win.S_SquaredDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_SquaredDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_name
            // 
            this.Form_name.AutoSize = true;
            this.Form_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_name.Location = new System.Drawing.Point(188, 40);
            this.Form_name.Name = "Form_name";
            this.Form_name.Size = new System.Drawing.Size(889, 54);
            this.Form_name.TabIndex = 0;
            this.Form_name.Text = "S-Squared Enterprises Personnel System";
            // 
            // cmb_managerList
            // 
            this.cmb_managerList.DataSource = this.managerBindingSource1;
            this.cmb_managerList.DisplayMember = "manager_name";
            this.cmb_managerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_managerList.FormattingEnabled = true;
            this.cmb_managerList.Location = new System.Drawing.Point(571, 163);
            this.cmb_managerList.Name = "cmb_managerList";
            this.cmb_managerList.Size = new System.Drawing.Size(363, 40);
            this.cmb_managerList.TabIndex = 1;
            this.cmb_managerList.ValueMember = "manager_id";
            this.cmb_managerList.SelectedIndexChanged += new System.EventHandler(this.cmb_managerList_SelectedIndexChanged);
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.s_SquaredDataSet;
            // 
            // s_SquaredDataSet
            // 
            this.s_SquaredDataSet.DataSetName = "S_SquaredDataSet";
            this.s_SquaredDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.s_SquaredDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Add_emp);
            this.panel1.Controls.Add(this.DGV_Display);
            this.panel1.Controls.Add(this.cmb_managerList);
            this.panel1.Controls.Add(this.Form_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1564, 941);
            this.panel1.TabIndex = 3;
            // 
            // Add_emp
            // 
            this.Add_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_emp.Location = new System.Drawing.Point(571, 772);
            this.Add_emp.Name = "Add_emp";
            this.Add_emp.Size = new System.Drawing.Size(363, 70);
            this.Add_emp.TabIndex = 4;
            this.Add_emp.Text = "Add Employee";
            this.Add_emp.UseVisualStyleBackColor = true;
            this.Add_emp.Click += new System.EventHandler(this.Add_emp_Click);
            // 
            // DGV_Display
            // 
            this.DGV_Display.AutoGenerateColumns = false;
            this.DGV_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.DGV_Display.DataSource = this.employeeBindingSource;
            this.DGV_Display.Location = new System.Drawing.Point(230, 235);
            this.DGV_Display.Name = "DGV_Display";
            this.DGV_Display.RowHeadersWidth = 72;
            this.DGV_Display.RowTemplate.Height = 31;
            this.DGV_Display.Size = new System.Drawing.Size(1074, 498);
            this.DGV_Display.TabIndex = 3;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            this.empidDataGridViewTextBoxColumn.Width = 175;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.s_SquaredDataSet;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1761, 40);
            this.fillByToolStrip.TabIndex = 4;
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
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Display_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 965);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel1);
            this.Name = "Display_frm";
            this.Text = "S-Squared Enterprises Personnel System";
            this.Load += new System.EventHandler(this.Display_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_SquaredDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form_name;
        private System.Windows.Forms.ComboBox cmb_managerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Display;
        private S_SquaredDataSet s_SquaredDataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private S_SquaredDataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private S_SquaredDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button Add_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource managerBindingSource1;
    }
}

