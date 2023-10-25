
namespace Hello_World
{
    partial class Cliente
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
            this.Telefone = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.Idade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.dateTimerPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Telefone
            // 
            this.Telefone.BackColor = System.Drawing.SystemColors.Window;
            this.Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Black;
            this.Telefone.Location = new System.Drawing.Point(216, 330);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(257, 26);
            this.Telefone.TabIndex = 3;
            this.Telefone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Black;
            this.Nome.Location = new System.Drawing.Point(216, 79);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(257, 26);
            this.Nome.TabIndex = 4;
            this.Nome.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Endereco
            // 
            this.Endereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.ForeColor = System.Drawing.Color.Black;
            this.Endereco.Location = new System.Drawing.Point(216, 179);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(257, 26);
            this.Endereco.TabIndex = 5;
            this.Endereco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Idade
            // 
            this.Idade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idade.ForeColor = System.Drawing.Color.Black;
            this.Idade.Location = new System.Drawing.Point(216, 279);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(257, 26);
            this.Idade.TabIndex = 6;
            this.Idade.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(608, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Proximo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Voltar.Location = new System.Drawing.Point(12, 430);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(81, 23);
            this.Voltar.TabIndex = 8;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tela de Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(213, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(213, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(213, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(213, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(213, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Idade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(213, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sexo";
            // 
            // Sexo
            // 
            this.Sexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.ForeColor = System.Drawing.Color.Black;
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "M",
            "F",
            "Outro"});
            this.Sexo.Location = new System.Drawing.Point(216, 380);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(97, 26);
            this.Sexo.TabIndex = 17;
            this.Sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(216, 229);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(257, 26);
            this.Email.TabIndex = 18;
            this.Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimerPicker
            // 
            this.dateTimerPicker.Location = new System.Drawing.Point(216, 430);
            this.dateTimerPicker.Name = "dateTimerPicker";
            this.dateTimerPicker.Size = new System.Drawing.Size(257, 20);
            this.dateTimerPicker.TabIndex = 19;
            this.dateTimerPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(217, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data de nascimento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(213, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cpf";
            // 
            // Cpf
            // 
            this.Cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.ForeColor = System.Drawing.Color.Black;
            this.Cpf.Location = new System.Drawing.Point(216, 129);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(257, 26);
            this.Cpf.TabIndex = 21;
            this.Cpf.TextChanged += new System.EventHandler(this.Cpf_TextChanged);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(10)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(695, 465);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimerPicker);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Telefone);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.DateTimePicker dateTimerPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Cpf;
    }
}