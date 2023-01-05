namespace GYM_project_safa_rama
{
    partial class EditCoach
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataBaseDataSet = new GYM_project_safa_rama.GymDataBaseDataSet();
            this.coachTableAdapter = new GYM_project_safa_rama.GymDataBaseDataSetTableAdapters.CoachTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editedtextBox = new System.Windows.Forms.TextBox();
            this.editcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(188, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Choose Coach";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.coachBindingSource;
            this.comboBox1.DisplayMember = "CoachName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "ID";
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.gymDataBaseDataSet;
            // 
            // gymDataBaseDataSet
            // 
            this.gymDataBaseDataSet.DataSetName = "GymDataBaseDataSet";
            this.gymDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Choose what you want to edit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 14);
            this.label5.TabIndex = 39;
            this.label5.Text = "Type new edited Information";
            // 
            // editedtextBox
            // 
            this.editedtextBox.Location = new System.Drawing.Point(213, 143);
            this.editedtextBox.Name = "editedtextBox";
            this.editedtextBox.Size = new System.Drawing.Size(121, 20);
            this.editedtextBox.TabIndex = 38;
            this.editedtextBox.TextChanged += new System.EventHandler(this.editedtextBox_TextChanged);
            this.editedtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editedtextBox_KeyPress);
            // 
            // editcomboBox
            // 
            this.editcomboBox.FormattingEnabled = true;
            this.editcomboBox.Items.AddRange(new object[] {
            "Edit Name",
            "Edit Salary",
            "Edit Password"});
            this.editcomboBox.Location = new System.Drawing.Point(213, 102);
            this.editcomboBox.Name = "editcomboBox";
            this.editcomboBox.Size = new System.Drawing.Size(121, 21);
            this.editcomboBox.TabIndex = 37;
            // 
            // EditCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GYM_project_safa_rama.Properties.Resources.gym_bg_dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editedtextBox);
            this.Controls.Add(this.editcomboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditCoach";
            this.Text = "EditCoach";
            this.Load += new System.EventHandler(this.EditCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private GymDataBaseDataSet gymDataBaseDataSet;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private GymDataBaseDataSetTableAdapters.CoachTableAdapter coachTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editedtextBox;
        private System.Windows.Forms.ComboBox editcomboBox;
    }
}