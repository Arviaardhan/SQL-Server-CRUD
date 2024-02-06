namespace CRUD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtNamaDepan = new TextBox();
            txtNamaBelakang = new TextBox();
            txtNilai = new TextBox();
            dataGridView1 = new DataGridView();
            btnInsert = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 85);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 0;
            label1.Text = "NO ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 143);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 1;
            label2.Text = "NAMA DEPAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 199);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 2;
            label3.Text = "NAMA BELAKANG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 255);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 3;
            label4.Text = "NILAI";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(352, 86);
            txtID.Name = "txtID";
            txtID.Size = new Size(285, 31);
            txtID.TabIndex = 4;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // txtNamaDepan
            // 
            txtNamaDepan.BorderStyle = BorderStyle.FixedSingle;
            txtNamaDepan.Location = new Point(352, 144);
            txtNamaDepan.Name = "txtNamaDepan";
            txtNamaDepan.Size = new Size(285, 31);
            txtNamaDepan.TabIndex = 5;
            // 
            // txtNamaBelakang
            // 
            txtNamaBelakang.BorderStyle = BorderStyle.FixedSingle;
            txtNamaBelakang.Location = new Point(352, 200);
            txtNamaBelakang.Name = "txtNamaBelakang";
            txtNamaBelakang.Size = new Size(285, 31);
            txtNamaBelakang.TabIndex = 6;
            // 
            // txtNilai
            // 
            txtNilai.BorderStyle = BorderStyle.FixedSingle;
            txtNilai.Location = new Point(352, 257);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(285, 31);
            txtNilai.TabIndex = 7;
            txtNilai.KeyPress += txtNilai_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(720, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(780, 278);
            dataGridView1.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.ForestGreen;
            btnInsert.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = SystemColors.ControlLightLight;
            btnInsert.Location = new Point(81, 601);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 41);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(1388, 601);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 41);
            btnClose.TabIndex = 10;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1567, 804);
            Controls.Add(btnClose);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(txtNilai);
            Controls.Add(txtNamaBelakang);
            Controls.Add(txtNamaDepan);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtNamaDepan;
        private TextBox txtNamaBelakang;
        private TextBox txtNilai;
        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnClose;
    }
}