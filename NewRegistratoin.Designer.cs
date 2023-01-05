namespace GYM_project_safa_rama
{
    partial class NewRegistratoin
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
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.paymenttextBox = new System.Windows.Forms.TextBox();
            this.durationtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataBaseDataSet = new GYM_project_safa_rama.GymDataBaseDataSet();
            this.customerTableAdapter = new GYM_project_safa_rama.GymDataBaseDataSetTableAdapters.CustomerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.coachcomboBox = new System.Windows.Forms.ComboBox();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachTableAdapter = new GYM_project_safa_rama.GymDataBaseDataSetTableAdapters.CoachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typecomboBox
            // 
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.Items.AddRange(new object[] {
            "DAILY",
            "WEEKLY",
            "MONTHLY",
            "YEARLY"});
            this.typecomboBox.Location = new System.Drawing.Point(347, 92);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(121, 21);
            this.typecomboBox.TabIndex = 27;
            // 
            // paymenttextBox
            // 
            this.paymenttextBox.Location = new System.Drawing.Point(347, 147);
            this.paymenttextBox.Name = "paymenttextBox";
            this.paymenttextBox.ReadOnly = true;
            this.paymenttextBox.Size = new System.Drawing.Size(100, 20);
            this.paymenttextBox.TabIndex = 26;
            // 
            // durationtextBox
            // 
            this.durationtextBox.Location = new System.Drawing.Point(347, 121);
            this.durationtextBox.Name = "durationtextBox";
            this.durationtextBox.Size = new System.Drawing.Size(100, 20);
            this.durationtextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Duration Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Period of Duration";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // namecomboBox
            // 
            this.namecomboBox.DataSource = this.customerBindingSource;
            this.namecomboBox.DisplayMember = "CustomerName";
            this.namecomboBox.FormattingEnabled = true;
            this.namecomboBox.Location = new System.Drawing.Point(347, 27);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(121, 21);
            this.namecomboBox.TabIndex = 33;
            this.namecomboBox.ValueMember = "ID";
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(347, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Calc Payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Choose Coach";
            // 
            // coachcomboBox
            // 
            this.coachcomboBox.DataSource = this.coachBindingSource;
            this.coachcomboBox.DisplayMember = "CoachName";
            this.coachcomboBox.FormattingEnabled = true;
            this.coachcomboBox.Location = new System.Drawing.Point(347, 60);
            this.coachcomboBox.Name = "coachcomboBox";
            this.coachcomboBox.Size = new System.Drawing.Size(121, 21);
            this.coachcomboBox.TabIndex = 36;
            this.coachcomboBox.ValueMember = "ID";
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.gymDataBaseDataSet;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // NewRegistratoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GYM_project_safa_rama.Properties.Resources.exercise_weights_iron_dumbbell_with_extra_plates_1423_223;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 281);
            this.Controls.Add(this.coachcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typecomboBox);
            this.Controls.Add(this.paymenttextBox);
            this.Controls.Add(this.durationtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewRegistratoin";
            this.Text = "NewRegistratoin";
            this.Load += new System.EventHandler(this.NewRegistratoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typecomboBox;
        private System.Windows.Forms.TextBox paymenttextBox;
        private System.Windows.Forms.TextBox durationtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox namecomboBox;
        private GymDataBaseDataSet gymDataBaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private GymDataBaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coachcomboBox;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private GymDataBaseDataSetTableAdapters.CoachTableAdapter coachTableAdapter;
    }
}