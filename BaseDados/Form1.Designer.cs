﻿namespace BaseDados
{
    partial class Form1
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(13, 13);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(775, 64);
            this.labelResultado.TabIndex = 0;
            this.labelResultado.Text = "Resultado";
            // 
            // lista
            // 
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email});
            this.lista.Location = new System.Drawing.Point(18, 303);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.Size = new System.Drawing.Size(580, 406);
            this.lista.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(488, 31);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(109, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(489, 31);
            this.txtName.TabIndex = 5;
            // 
            // btnConectar
            // 
            this.btnConectar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(604, 303);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(184, 56);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCriarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTabela.Location = new System.Drawing.Point(604, 365);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.Size = new System.Drawing.Size(184, 64);
            this.btnCriarTabela.TabIndex = 7;
            this.btnCriarTabela.Text = "Criar Tabela";
            this.btnCriarTabela.UseVisualStyleBackColor = true;
            this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(604, 435);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(184, 64);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(604, 505);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(184, 64);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(604, 575);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(184, 64);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(604, 645);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(184, 64);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCriarTabela);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.labelResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}

