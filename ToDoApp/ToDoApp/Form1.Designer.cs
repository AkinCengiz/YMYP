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
            btnAdd = new Button();
            lblTime = new Label();
            dtpTime = new DateTimePicker();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvToDo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(41, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(46, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Başlık : ";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(93, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(353, 23);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Açıklama : ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(93, 62);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(353, 139);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 25);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Tarih : ";
            // 
            // dgvToDo
            // 
            dgvToDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToDo.Columns.AddRange(new DataGridViewColumn[] { DateInfo, Saat, Title, Description });
            dgvToDo.Dock = DockStyle.Fill;
            dgvToDo.Location = new Point(3, 19);
            dgvToDo.Name = "dgvToDo";
            dgvToDo.RowTemplate.Height = 25;
            dgvToDo.Size = new Size(669, 306);
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
            // btnAdd
            // 
            btnAdd.Location = new Point(532, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 33);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(485, 65);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(38, 15);
            lblTime.TabIndex = 10;
            lblTime.Text = "Saat : ";
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(532, 59);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(150, 23);
            dtpTime.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(532, 129);
            button1.Name = "button1";
            button1.Size = new Size(150, 33);
            button1.TabIndex = 11;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvToDo);
            groupBox1.Location = new Point(12, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 328);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yapılacaklar Listesi";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(532, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 33);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(532, 19);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 23);
            dtpDate.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 557);
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
            Name = "Form1";
            Text = "Yapılacaklar Listesi";
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
        private DataGridViewTextBoxColumn DateInfo;
        private DataGridViewTextBoxColumn Saat;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
    }
}