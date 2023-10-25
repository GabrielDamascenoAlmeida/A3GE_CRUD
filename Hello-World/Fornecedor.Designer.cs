
namespace Hello_World
{
    partial class Fornecedor
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
            this.chkcondesp = new System.Windows.Forms.CheckBox();
            this.rdomasc = new System.Windows.Forms.RadioButton();
            this.rdofem = new System.Windows.Forms.RadioButton();
            this.rdooutro = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonsalva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.DgvFornecedor = new System.Windows.Forms.DataGridView();
            this.textNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCpfFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // chkcondesp
            // 
            this.chkcondesp.AutoSize = true;
            this.chkcondesp.Location = new System.Drawing.Point(12, 6);
            this.chkcondesp.Name = "chkcondesp";
            this.chkcondesp.Size = new System.Drawing.Size(124, 17);
            this.chkcondesp.TabIndex = 1;
            this.chkcondesp.Text = "Condições Especiais";
            this.chkcondesp.UseVisualStyleBackColor = true;
            // 
            // rdomasc
            // 
            this.rdomasc.AutoSize = true;
            this.rdomasc.Location = new System.Drawing.Point(12, 29);
            this.rdomasc.Name = "rdomasc";
            this.rdomasc.Size = new System.Drawing.Size(72, 17);
            this.rdomasc.TabIndex = 2;
            this.rdomasc.TabStop = true;
            this.rdomasc.Text = "masculino";
            this.rdomasc.UseVisualStyleBackColor = true;
            // 
            // rdofem
            // 
            this.rdofem.AutoSize = true;
            this.rdofem.Location = new System.Drawing.Point(90, 29);
            this.rdofem.Name = "rdofem";
            this.rdofem.Size = new System.Drawing.Size(64, 17);
            this.rdofem.TabIndex = 3;
            this.rdofem.TabStop = true;
            this.rdofem.Text = "feminino";
            this.rdofem.UseVisualStyleBackColor = true;
            // 
            // rdooutro
            // 
            this.rdooutro.AutoSize = true;
            this.rdooutro.Location = new System.Drawing.Point(160, 29);
            this.rdooutro.Name = "rdooutro";
            this.rdooutro.Size = new System.Drawing.Size(49, 17);
            this.rdooutro.TabIndex = 4;
            this.rdooutro.TabStop = true;
            this.rdooutro.Text = "outro";
            this.rdooutro.UseVisualStyleBackColor = true;
            this.rdooutro.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Produto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Zelador",
            "Fornecedor",
            "Entregador",
            "Administrador",
            "RH"});
            this.cboCargo.Location = new System.Drawing.Point(12, 68);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(138, 21);
            this.cboCargo.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 14;
            // 
            // buttonsalva
            // 
            this.buttonsalva.Location = new System.Drawing.Point(679, 218);
            this.buttonsalva.Name = "buttonsalva";
            this.buttonsalva.Size = new System.Drawing.Size(136, 23);
            this.buttonsalva.TabIndex = 15;
            this.buttonsalva.Text = "Salvar fornecedor";
            this.buttonsalva.UseVisualStyleBackColor = true;
            this.buttonsalva.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(559, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fornecimento de serviços";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(293, 123);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(70, 13);
            this.Date.TabIndex = 18;
            this.Date.Text = "Id fornecedor";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Location = new System.Drawing.Point(296, 139);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdFornecedor.TabIndex = 19;
            this.txtIdFornecedor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DgvFornecedor
            // 
            this.DgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFornecedor.Location = new System.Drawing.Point(451, 45);
            this.DgvFornecedor.Name = "DgvFornecedor";
            this.DgvFornecedor.Size = new System.Drawing.Size(364, 124);
            this.DgvFornecedor.TabIndex = 20;
            this.DgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedor_CellContentClick);
            // 
            // textNomeFornecedor
            // 
            this.textNomeFornecedor.Location = new System.Drawing.Point(296, 179);
            this.textNomeFornecedor.Name = "textNomeFornecedor";
            this.textNomeFornecedor.Size = new System.Drawing.Size(100, 20);
            this.textNomeFornecedor.TabIndex = 22;
            this.textNomeFornecedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome Fornecedor";
            // 
            // textCpfFornecedor
            // 
            this.textCpfFornecedor.Location = new System.Drawing.Point(296, 220);
            this.textCpfFornecedor.Name = "textCpfFornecedor";
            this.textCpfFornecedor.Size = new System.Drawing.Size(100, 20);
            this.textCpfFornecedor.TabIndex = 24;
            this.textCpfFornecedor.TextChanged += new System.EventHandler(this.textCpfFornecedor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Alterar Dados";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(451, 218);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar\r\n\r\n";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(847, 254);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCpfFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNomeFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvFornecedor);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonsalva);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdooutro);
            this.Controls.Add(this.rdofem);
            this.Controls.Add(this.rdomasc);
            this.Controls.Add(this.chkcondesp);
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkcondesp;
        private System.Windows.Forms.RadioButton rdomasc;
        private System.Windows.Forms.RadioButton rdofem;
        private System.Windows.Forms.RadioButton rdooutro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonsalva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.DataGridView DgvFornecedor;
        private System.Windows.Forms.TextBox textNomeFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCpfFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlterar;
    }
}