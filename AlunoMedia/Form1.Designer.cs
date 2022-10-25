namespace AlunoMedia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Nota4 = new System.Windows.Forms.ComboBox();
            this.Nota3 = new System.Windows.Forms.ComboBox();
            this.Nota2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nota1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(148, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Nota4);
            this.groupBox1.Controls.Add(this.Nota3);
            this.groupBox1.Controls.Add(this.Nota2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nota1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas Aluno";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(148, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 31);
            this.txtCode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "RA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar Notas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Nota4
            // 
            this.Nota4.FormattingEnabled = true;
            this.Nota4.Location = new System.Drawing.Point(151, 290);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(121, 33);
            this.Nota4.TabIndex = 9;
            // 
            // Nota3
            // 
            this.Nota3.FormattingEnabled = true;
            this.Nota3.Location = new System.Drawing.Point(151, 237);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(121, 33);
            this.Nota3.TabIndex = 8;
            // 
            // Nota2
            // 
            this.Nota2.FormattingEnabled = true;
            this.Nota2.Location = new System.Drawing.Point(151, 192);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(121, 33);
            this.Nota2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota 1";
            // 
            // Nota1
            // 
            this.Nota1.FormattingEnabled = true;
            this.Nota1.Location = new System.Drawing.Point(151, 147);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(121, 33);
            this.Nota1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(420, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(856, 424);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "RA";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nota 1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nota 2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nota 3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nota 4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Media";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Situacao";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 615);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Nota4;
        private System.Windows.Forms.ComboBox Nota3;
        private System.Windows.Forms.ComboBox Nota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Nota1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

