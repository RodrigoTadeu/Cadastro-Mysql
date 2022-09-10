namespace cadastro
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
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Sexo = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.bnt_Mostrar = new System.Windows.Forms.Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Adicionar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Adicionar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Adicionar.Location = new System.Drawing.Point(788, 21);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(203, 43);
            this.btn_Adicionar.TabIndex = 0;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(28, 37);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(75, 27);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Id.Location = new System.Drawing.Point(637, 163);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(90, 34);
            this.txt_Id.TabIndex = 2;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Telefone.Location = new System.Drawing.Point(28, 163);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(323, 34);
            this.txt_Telefone.TabIndex = 3;
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Sexo.Location = new System.Drawing.Point(411, 163);
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Size = new System.Drawing.Size(202, 34);
            this.txt_Sexo.TabIndex = 4;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nome.Location = new System.Drawing.Point(28, 72);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(323, 34);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(411, 72);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(316, 34);
            this.txt_Email.TabIndex = 6;
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Remover.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remover.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Remover.Location = new System.Drawing.Point(788, 72);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(203, 39);
            this.btn_Remover.TabIndex = 7;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Atualizar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Atualizar.Location = new System.Drawing.Point(788, 126);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(203, 41);
            this.btn_Atualizar.TabIndex = 8;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // bnt_Mostrar
            // 
            this.bnt_Mostrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.bnt_Mostrar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt_Mostrar.ForeColor = System.Drawing.Color.Crimson;
            this.bnt_Mostrar.Location = new System.Drawing.Point(788, 173);
            this.bnt_Mostrar.Name = "bnt_Mostrar";
            this.bnt_Mostrar.Size = new System.Drawing.Size(203, 44);
            this.bnt_Mostrar.TabIndex = 9;
            this.bnt_Mostrar.Text = "Mostrar no Id";
            this.bnt_Mostrar.UseVisualStyleBackColor = false;
            this.bnt_Mostrar.Click += new System.EventHandler(this.bnt_Mostrar_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(411, 37);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(73, 27);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Telefone.Location = new System.Drawing.Point(28, 133);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(108, 27);
            this.lbl_Telefone.TabIndex = 11;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sexo.Location = new System.Drawing.Point(411, 133);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(66, 27);
            this.lbl_Sexo.TabIndex = 12;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Id.Location = new System.Drawing.Point(637, 133);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(31, 27);
            this.lbl_Id.TabIndex = 13;
            this.lbl_Id.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1018, 248);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.bnt_Mostrar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Sexo);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Adicionar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Adicionar;
        private Label lbl_Nome;
        private TextBox txt_Id;
        private TextBox txt_Telefone;
        private TextBox txt_Sexo;
        private TextBox txt_Nome;
        private TextBox txt_Email;
        private Button btn_Remover;
        private Button btn_Atualizar;
        private Button bnt_Mostrar;
        private Label lbl_Email;
        private Label lbl_Telefone;
        private Label lbl_Sexo;
        private Label lbl_Id;
    }
}