namespace Sistema_Cursos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_codigocurso = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_mensalidade = new System.Windows.Forms.TextBox();
            this.tb_nomecurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_sexo_aluno = new System.Windows.Forms.ComboBox();
            this.cb_curso_aluno = new System.Windows.Forms.ComboBox();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefone_aluno = new System.Windows.Forms.TextBox();
            this.tb_nascimento_aluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nome_aluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_codigo_aluno = new System.Windows.Forms.Label();
            this.rb_curso = new System.Windows.Forms.RadioButton();
            this.rb_sexo = new System.Windows.Forms.RadioButton();
            this.rb_mensalidade = new System.Windows.Forms.RadioButton();
            this.Grid_pesquisa = new System.Windows.Forms.DataGridView();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.lb_pesquisa = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb_codigocurso);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.tb_mensalidade);
            this.tabPage1.Controls.Add(this.tb_nomecurso);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASRTRO DE CURSOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_codigocurso
            // 
            this.lb_codigocurso.BackColor = System.Drawing.Color.Black;
            this.lb_codigocurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigocurso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_codigocurso.Location = new System.Drawing.Point(26, 88);
            this.lb_codigocurso.Name = "lb_codigocurso";
            this.lb_codigocurso.Size = new System.Drawing.Size(95, 38);
            this.lb_codigocurso.TabIndex = 9;
            this.lb_codigocurso.Text = "1";
            this.lb_codigocurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(94, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO DO CURSO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOME DO CURSO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MENSALIDADE";
            this.Column3.Name = "Column3";
            // 
            // tb_mensalidade
            // 
            this.tb_mensalidade.Location = new System.Drawing.Point(487, 106);
            this.tb_mensalidade.Name = "tb_mensalidade";
            this.tb_mensalidade.Size = new System.Drawing.Size(172, 20);
            this.tb_mensalidade.TabIndex = 5;
            // 
            // tb_nomecurso
            // 
            this.tb_nomecurso.Location = new System.Drawing.Point(276, 106);
            this.tb_nomecurso.Name = "tb_nomecurso";
            this.tb_nomecurso.Size = new System.Drawing.Size(172, 20);
            this.tb_nomecurso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MENSALIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME DO CURSO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO DO CURSO";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_codigo_aluno);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.cb_sexo_aluno);
            this.tabPage2.Controls.Add(this.cb_curso_aluno);
            this.tabPage2.Controls.Add(this.Grid2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.telefone_aluno);
            this.tabPage2.Controls.Add(this.tb_nascimento_aluno);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_nome_aluno);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CADASTRO DE ALUNOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 38);
            this.button4.TabIndex = 16;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_sexo_aluno
            // 
            this.cb_sexo_aluno.FormattingEnabled = true;
            this.cb_sexo_aluno.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_sexo_aluno.Location = new System.Drawing.Point(298, 163);
            this.cb_sexo_aluno.Name = "cb_sexo_aluno";
            this.cb_sexo_aluno.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo_aluno.TabIndex = 14;
            // 
            // cb_curso_aluno
            // 
            this.cb_curso_aluno.FormattingEnabled = true;
            this.cb_curso_aluno.Location = new System.Drawing.Point(298, 217);
            this.cb_curso_aluno.Name = "cb_curso_aluno";
            this.cb_curso_aluno.Size = new System.Drawing.Size(121, 21);
            this.cb_curso_aluno.TabIndex = 13;
            // 
            // Grid2
            // 
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.CURSO});
            this.Grid2.Location = new System.Drawing.Point(18, 250);
            this.Grid2.Name = "Grid2";
            this.Grid2.Size = new System.Drawing.Size(616, 150);
            this.Grid2.TabIndex = 12;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CODIGO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NOME";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NASCIMENTO";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SEXO";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TELEFONE";
            this.Column8.Name = "Column8";
            // 
            // CURSO
            // 
            this.CURSO.HeaderText = "CURSO";
            this.CURSO.Name = "CURSO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "CURSO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TELEFONE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SEXO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "NASCIMENTO";
            // 
            // telefone_aluno
            // 
            this.telefone_aluno.Location = new System.Drawing.Point(38, 224);
            this.telefone_aluno.Name = "telefone_aluno";
            this.telefone_aluno.Size = new System.Drawing.Size(100, 20);
            this.telefone_aluno.TabIndex = 6;
            // 
            // tb_nascimento_aluno
            // 
            this.tb_nascimento_aluno.Location = new System.Drawing.Point(38, 147);
            this.tb_nascimento_aluno.Name = "tb_nascimento_aluno";
            this.tb_nascimento_aluno.Size = new System.Drawing.Size(100, 20);
            this.tb_nascimento_aluno.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "NOME";
            // 
            // tb_nome_aluno
            // 
            this.tb_nome_aluno.Location = new System.Drawing.Point(298, 80);
            this.tb_nome_aluno.Name = "tb_nome_aluno";
            this.tb_nome_aluno.Size = new System.Drawing.Size(100, 20);
            this.tb_nome_aluno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CODIGO";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Pesquisar);
            this.tabPage3.Controls.Add(this.lb_pesquisa);
            this.tabPage3.Controls.Add(this.tb_pesquisa);
            this.tabPage3.Controls.Add(this.Grid_pesquisa);
            this.tabPage3.Controls.Add(this.rb_mensalidade);
            this.tabPage3.Controls.Add(this.rb_sexo);
            this.tabPage3.Controls.Add(this.rb_curso);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PESQUISAS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lb_codigo_aluno
            // 
            this.lb_codigo_aluno.BackColor = System.Drawing.Color.Black;
            this.lb_codigo_aluno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo_aluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_codigo_aluno.Location = new System.Drawing.Point(35, 80);
            this.lb_codigo_aluno.Name = "lb_codigo_aluno";
            this.lb_codigo_aluno.Size = new System.Drawing.Size(96, 25);
            this.lb_codigo_aluno.TabIndex = 17;
            this.lb_codigo_aluno.Text = "1";
            this.lb_codigo_aluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_curso
            // 
            this.rb_curso.AutoSize = true;
            this.rb_curso.Location = new System.Drawing.Point(25, 62);
            this.rb_curso.Name = "rb_curso";
            this.rb_curso.Size = new System.Drawing.Size(106, 17);
            this.rb_curso.TabIndex = 0;
            this.rb_curso.TabStop = true;
            this.rb_curso.Text = "Alunos Por Curso";
            this.rb_curso.UseVisualStyleBackColor = true;
            this.rb_curso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_sexo
            // 
            this.rb_sexo.AutoSize = true;
            this.rb_sexo.Location = new System.Drawing.Point(25, 98);
            this.rb_sexo.Name = "rb_sexo";
            this.rb_sexo.Size = new System.Drawing.Size(103, 17);
            this.rb_sexo.TabIndex = 1;
            this.rb_sexo.TabStop = true;
            this.rb_sexo.Text = "Alunos Por Sexo";
            this.rb_sexo.UseVisualStyleBackColor = true;
            this.rb_sexo.CheckedChanged += new System.EventHandler(this.rb_sexo_CheckedChanged);
            // 
            // rb_mensalidade
            // 
            this.rb_mensalidade.AutoSize = true;
            this.rb_mensalidade.Location = new System.Drawing.Point(25, 141);
            this.rb_mensalidade.Name = "rb_mensalidade";
            this.rb_mensalidade.Size = new System.Drawing.Size(175, 17);
            this.rb_mensalidade.TabIndex = 2;
            this.rb_mensalidade.TabStop = true;
            this.rb_mensalidade.Text = "Curso Por valor da Mensalidade";
            this.rb_mensalidade.UseVisualStyleBackColor = true;
            this.rb_mensalidade.CheckedChanged += new System.EventHandler(this.rb_mensalidade_CheckedChanged);
            // 
            // Grid_pesquisa
            // 
            this.Grid_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_pesquisa.Location = new System.Drawing.Point(25, 225);
            this.Grid_pesquisa.Name = "Grid_pesquisa";
            this.Grid_pesquisa.Size = new System.Drawing.Size(549, 150);
            this.Grid_pesquisa.TabIndex = 3;
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(267, 95);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(173, 20);
            this.tb_pesquisa.TabIndex = 4;
            // 
            // lb_pesquisa
            // 
            this.lb_pesquisa.AutoSize = true;
            this.lb_pesquisa.Location = new System.Drawing.Point(287, 76);
            this.lb_pesquisa.Name = "lb_pesquisa";
            this.lb_pesquisa.Size = new System.Drawing.Size(72, 13);
            this.lb_pesquisa.TabIndex = 5;
            this.lb_pesquisa.Text = "Pesquisar Por";
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(290, 141);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(116, 48);
            this.Pesquisar.TabIndex = 6;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox tb_mensalidade;
        private System.Windows.Forms.TextBox tb_nomecurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefone_aluno;
        private System.Windows.Forms.TextBox tb_nascimento_aluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nome_aluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sexo_aluno;
        private System.Windows.Forms.ComboBox cb_curso_aluno;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_codigocurso;
        private System.Windows.Forms.Label lb_codigo_aluno;
        private System.Windows.Forms.Label lb_pesquisa;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.DataGridView Grid_pesquisa;
        private System.Windows.Forms.RadioButton rb_mensalidade;
        private System.Windows.Forms.RadioButton rb_sexo;
        private System.Windows.Forms.RadioButton rb_curso;
        private System.Windows.Forms.Button Pesquisar;
    }
}

