namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            dgvToDo = new DataGridView();
            DateInfo = new DataGridViewTextBoxColumn();
            Saat = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            lblTime = new Label();
            dtpTime = new DateTimePicker();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            dtpDate = new DateTimePicker();
            cbxStatus = new ComboBox();
            lblDurum = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvToDo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(59, 35);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Başlık : ";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Red;
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(133, 31);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(503, 29);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 2;
            label1.Text = "Açıklama : ";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Red;
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(133, 87);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(503, 257);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(693, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 5;
            label2.Text = "Tarih : ";
            // 
            // dgvToDo
            // 
            dgvToDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToDo.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvToDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToDo.Columns.AddRange(new DataGridViewColumn[] { DateInfo, Saat, Title, Description, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvToDo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvToDo.Dock = DockStyle.Fill;
            dgvToDo.Location = new Point(4, 26);
            dgvToDo.Margin = new Padding(4);
            dgvToDo.Name = "dgvToDo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvToDo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvToDo.RowHeadersVisible = false;
            dgvToDo.RowTemplate.Height = 25;
            dgvToDo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToDo.Size = new Size(956, 429);
            dgvToDo.TabIndex = 6;
            dgvToDo.CellClick += dgvToDo_CellClick;
            // 
            // DateInfo
            // 
            DateInfo.HeaderText = "Tarih";
            DateInfo.Name = "DateInfo";
            // 
            // Saat
            // 
            Saat.HeaderText = "Saat";
            Saat.Name = "Saat";
            // 
            // Title
            // 
            Title.HeaderText = "Başlık";
            Title.Name = "Title";
            // 
            // Description
            // 
            Description.HeaderText = "Açıklama";
            Description.Name = "Description";
            // 
            // Status
            // 
            Status.HeaderText = "Durum";
            Status.Name = "Status";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.Location = new Point(760, 190);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 46);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(693, 91);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(55, 21);
            lblTime.TabIndex = 10;
            lblTime.Text = "Saat : ";
            // 
            // dtpTime
            // 
            dtpTime.CalendarForeColor = Color.White;
            dtpTime.CalendarMonthBackground = Color.Red;
            dtpTime.CalendarTitleBackColor = Color.Red;
            dtpTime.CalendarTitleForeColor = Color.White;
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(760, 83);
            dtpTime.Margin = new Padding(4);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(213, 29);
            dtpTime.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(760, 245);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(214, 46);
            button1.TabIndex = 11;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvToDo);
            groupBox1.Location = new Point(17, 368);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(964, 459);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yapılacaklar Listesi";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(760, 300);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(214, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpDate
            // 
            dtpDate.CalendarForeColor = Color.Black;
            dtpDate.CalendarMonthBackground = Color.Red;
            dtpDate.CalendarTitleBackColor = Color.Red;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(760, 27);
            dtpDate.Margin = new Padding(4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(213, 29);
            dtpDate.TabIndex = 4;
            // 
            // cbxStatus
            // 
            cbxStatus.BackColor = Color.Red;
            cbxStatus.ForeColor = Color.White;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Devam ediyor", "Tamamlandı" });
            cbxStatus.Location = new Point(760, 136);
            cbxStatus.Margin = new Padding(4);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(213, 29);
            cbxStatus.TabIndex = 14;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(676, 140);
            lblDurum.Margin = new Padding(4, 0, 4, 0);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(75, 21);
            lblDurum.TabIndex = 15;
            lblDurum.Text = "Durum : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(999, 839);
            Controls.Add(lblDurum);
            Controls.Add(cbxStatus);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(lblTime);
            Controls.Add(dtpTime);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Yapılacaklar Listesi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvToDo).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private DataGridView dgvToDo;
        private Button btnAdd;
        private Label lblTime;
        private DateTimePicker dtpTime;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnDelete;
        private DateTimePicker dtpDate;
        private ComboBox cbxStatus;
        private Label lblDurum;
        private DataGridViewTextBoxColumn DateInfo;
        private DataGridViewTextBoxColumn Saat;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
    }
}