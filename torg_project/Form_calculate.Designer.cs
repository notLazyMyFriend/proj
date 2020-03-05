namespace torg_project
{
    partial class Form_calculate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_analysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_install = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_support = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_hard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.senior,
            this.middle,
            this.junior,
            this.rate_analysis,
            this.rate_install,
            this.rate_support,
            this.rate_time,
            this.rate_hard,
            this.rate_add});
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1164, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // senior
            // 
            this.senior.HeaderText = "Senior";
            this.senior.Name = "senior";
            // 
            // middle
            // 
            this.middle.HeaderText = "Middle";
            this.middle.Name = "middle";
            // 
            // junior
            // 
            this.junior.HeaderText = "Junior";
            this.junior.Name = "junior";
            // 
            // rate_analysis
            // 
            this.rate_analysis.HeaderText = "Анализ";
            this.rate_analysis.Name = "rate_analysis";
            // 
            // rate_install
            // 
            this.rate_install.HeaderText = "Установка";
            this.rate_install.Name = "rate_install";
            // 
            // rate_support
            // 
            this.rate_support.HeaderText = "Обслуживание";
            this.rate_support.Name = "rate_support";
            // 
            // rate_time
            // 
            this.rate_time.HeaderText = "Время";
            this.rate_time.Name = "rate_time";
            // 
            // rate_hard
            // 
            this.rate_hard.HeaderText = "Сложность";
            this.rate_hard.Name = "rate_hard";
            // 
            // rate_add
            // 
            this.rate_add.HeaderText = "Дополнительный";
            this.rate_add.Name = "rate_add";
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.Location = new System.Drawing.Point(479, 297);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(163, 35);
            this.button_saveChanges.TabIndex = 23;
            this.button_saveChanges.Text = "Сохранить";
            this.button_saveChanges.UseVisualStyleBackColor = true;
            this.button_saveChanges.Click += new System.EventHandler(this.button_saveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\study\\1c\\DE_Variant_7_s_kriteriami_2\\ДЭ Вариант 7 с критериями\\Style Guide\\log" +
    "o.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 97);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form_calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_saveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_calculate";
            this.Text = "Вычисление";
            this.Load += new System.EventHandler(this.Form_calculate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn senior;
        private System.Windows.Forms.DataGridViewTextBoxColumn middle;
        private System.Windows.Forms.DataGridViewTextBoxColumn junior;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_analysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_install;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_support;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_hard;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_add;
        private System.Windows.Forms.Button button_saveChanges;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}