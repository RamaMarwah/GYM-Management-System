namespace GYM_project_safa_rama
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.empcomboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataBaseDataSet = new GYM_project_safa_rama.GymDataBaseDataSet();
            this.editcomboBox = new System.Windows.Forms.ComboBox();
            this.editedtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new GYM_project_safa_rama.GymDataBaseDataSetTableAdapters.EmployeeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empcomboBox
            // 
            this.empcomboBox.DataSource = this.employeeBindingSource;
            this.empcomboBox.DisplayMember = "NameEmp";
            this.empcomboBox.FormattingEnabled = true;
            this.empcomboBox.Location = new System.Drawing.Point(250, 58);
            this.empcomboBox.Name = "empcomboBox";
            this.empcomboBox.Size = new System.Drawing.Size(121, 21);
            this.empcomboBox.TabIndex = 0;
            this.empcomboBox.ValueMember = "ID";
            this.empcomboBox.SelectedIndexChanged += new System.EventHandler(this.empcomboBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.gymDataBaseDataSet;
            // 
            // gymDataBaseDataSet
            // 
            this.gymDataBaseDataSet.DataSetName = "GymDataBaseDataSet";
            this.gymDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editcomboBox
            // 
            this.editcomboBox.FormattingEnabled = true;
            this.editcomboBox.Items.AddRange(new object[] {
            "Edit Name",
            "Edit Salary",
            "Edit Password"});
            this.editcomboBox.Location = new System.Drawing.Point(250, 104);
            this.editcomboBox.Name = "editcomboBox";
            this.editcomboBox.Size = new System.Drawing.Size(121, 21);
            this.editcomboBox.TabIndex = 1;
            // 
            // editedtextBox
            // 
            this.editedtextBox.Location = new System.Drawing.Point(250, 150);
            this.editedtextBox.Name = "editedtextBox";
            this.editedtextBox.Size = new System.Drawing.Size(121, 20);
            this.editedtextBox.TabIndex = 2;
            this.editedtextBox.TextChanged += new System.EventHandler(this.editedtextBox_TextChanged);
            this.editedtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editedtextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type new edited Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "Choose what you want to edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Choose Employee";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editedtextBox);
            this.Controls.Add(this.editcomboBox);
            this.Controls.Add(this.empcomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditEmployee";
            this.Text = "Edit Employee Information";
            this.Load += new System.EventHandler(this.EditEmployee_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox empcomboBox;
        private System.Windows.Forms.ComboBox editcomboBox;
        private System.Windows.Forms.TextBox editedtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GymDataBaseDataSet gymDataBaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GymDataBaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button button1;

    }
}