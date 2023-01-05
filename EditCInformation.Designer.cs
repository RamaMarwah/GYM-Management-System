namespace GYM_project_safa_rama
{
    partial class EditCInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editcomboBox = new System.Windows.Forms.ComboBox();
            this.editedtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataBaseDataSet = new GYM_project_safa_rama.GymDataBaseDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new GYM_project_safa_rama.GymDataBaseDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose what to edit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(130, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editcomboBox
            // 
            this.editcomboBox.FormattingEnabled = true;
            this.editcomboBox.Items.AddRange(new object[] {
            "Edit Weight",
            "Edit Preganent"});
            this.editcomboBox.Location = new System.Drawing.Point(101, 117);
            this.editcomboBox.Name = "editcomboBox";
            this.editcomboBox.Size = new System.Drawing.Size(166, 21);
            this.editcomboBox.TabIndex = 23;
            this.editcomboBox.SelectedIndexChanged += new System.EventHandler(this.editcomboBox_SelectedIndexChanged);
            // 
            // editedtextBox
            // 
            this.editedtextBox.Location = new System.Drawing.Point(101, 193);
            this.editedtextBox.Name = "editedtextBox";
            this.editedtextBox.Size = new System.Drawing.Size(166, 20);
            this.editedtextBox.TabIndex = 24;
            this.editedtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Type new edited value";
            // 
            // namecomboBox
            // 
            this.namecomboBox.DataSource = this.customerBindingSource;
            this.namecomboBox.DisplayMember = "CustomerName";
            this.namecomboBox.FormattingEnabled = true;
            this.namecomboBox.Location = new System.Drawing.Point(101, 59);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(166, 21);
            this.namecomboBox.TabIndex = 26;
            this.namecomboBox.ValueMember = "ID";
            this.namecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.gymDataBaseDataSet;
            // 
            // gymDataBaseDataSet
            // 
            this.gymDataBaseDataSet.DataSetName = "GymDataBaseDataSet";
            this.gymDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Choose Customer";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // EditCInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editedtextBox);
            this.Controls.Add(this.editcomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditCInformation";
            this.Text = "EditCInformation";
            this.Load += new System.EventHandler(this.EditCInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox editcomboBox;
        private System.Windows.Forms.TextBox editedtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox namecomboBox;
        private System.Windows.Forms.Label label3;
        private GymDataBaseDataSet gymDataBaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private GymDataBaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}