namespace WindowsFormsApp1
{
    partial class criar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criar));
            this.tabelaItensTableAdapter1 = new WindowsFormsApp1.BancoEstoqueDataSetTableAdapters.TabelaItensTableAdapter();
            this.tabelaItensTableAdapter2 = new WindowsFormsApp1.BancoEstoqueDataSetTableAdapters.TabelaItensTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EstoqueMinimo = new System.Windows.Forms.TextBox();
            this.txt_EstoqueAtual = new System.Windows.Forms.TextBox();
            this.txt_EstoqueMaximo = new System.Windows.Forms.TextBox();
            this.txt_ValorUnitario = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabelaItensTableAdapter1
            // 
            this.tabelaItensTableAdapter1.ClearBeforeFill = true;
            // 
            // tabelaItensTableAdapter2
            // 
            this.tabelaItensTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.button1.Location = new System.Drawing.Point(67, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(15, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Descrição";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cod";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor unitário";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estoque máximo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estoque mínimo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estoque atual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Criar";
            // 
            // txt_EstoqueMinimo
            // 
            this.txt_EstoqueMinimo.Location = new System.Drawing.Point(154, 162);
            this.txt_EstoqueMinimo.Name = "txt_EstoqueMinimo";
            this.txt_EstoqueMinimo.Size = new System.Drawing.Size(93, 20);
            this.txt_EstoqueMinimo.TabIndex = 18;
            // 
            // txt_EstoqueAtual
            // 
            this.txt_EstoqueAtual.Location = new System.Drawing.Point(156, 126);
            this.txt_EstoqueAtual.Name = "txt_EstoqueAtual";
            this.txt_EstoqueAtual.Size = new System.Drawing.Size(93, 20);
            this.txt_EstoqueAtual.TabIndex = 17;
            // 
            // txt_EstoqueMaximo
            // 
            this.txt_EstoqueMaximo.Location = new System.Drawing.Point(155, 198);
            this.txt_EstoqueMaximo.Name = "txt_EstoqueMaximo";
            this.txt_EstoqueMaximo.Size = new System.Drawing.Size(93, 20);
            this.txt_EstoqueMaximo.TabIndex = 16;
            // 
            // txt_ValorUnitario
            // 
            this.txt_ValorUnitario.Location = new System.Drawing.Point(156, 237);
            this.txt_ValorUnitario.Name = "txt_ValorUnitario";
            this.txt_ValorUnitario.Size = new System.Drawing.Size(93, 20);
            this.txt_ValorUnitario.TabIndex = 15;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(156, 87);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(93, 20);
            this.txt_descricao.TabIndex = 28;
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.lbl_cod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cod.Location = new System.Drawing.Point(184, 58);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(39, 20);
            this.lbl_cod.TabIndex = 29;
            this.lbl_cod.Text = "Cod";
            // 
            // criar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(315, 322);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_EstoqueMinimo);
            this.Controls.Add(this.txt_EstoqueAtual);
            this.Controls.Add(this.txt_EstoqueMaximo);
            this.Controls.Add(this.txt_ValorUnitario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "criar";
            this.Text = "criar";
            this.Load += new System.EventHandler(this.criar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BancoEstoqueDataSetTableAdapters.TabelaItensTableAdapter tabelaItensTableAdapter1;
        private BancoEstoqueDataSetTableAdapters.TabelaItensTableAdapter tabelaItensTableAdapter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EstoqueMinimo;
        private System.Windows.Forms.TextBox txt_EstoqueAtual;
        private System.Windows.Forms.TextBox txt_EstoqueMaximo;
        private System.Windows.Forms.TextBox txt_ValorUnitario;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_cod;
    }
}