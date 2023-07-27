namespace Login
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.rbReceberPagamento = new System.Windows.Forms.RadioButton();
            this.rbCadrastrarPedido = new System.Windows.Forms.RadioButton();
            this.rbCadrastrarCliente = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma opção:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Location = new System.Drawing.Point(0, 181);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(190, 39);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogoff);
            this.groupBox1.Controls.Add(this.rbReceberPagamento);
            this.groupBox1.Controls.Add(this.rbCadrastrarPedido);
            this.groupBox1.Controls.Add(this.rbCadrastrarCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogoff.Location = new System.Drawing.Point(255, 181);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(87, 37);
            this.btnLogoff.TabIndex = 8;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // rbReceberPagamento
            // 
            this.rbReceberPagamento.AutoSize = true;
            this.rbReceberPagamento.Location = new System.Drawing.Point(11, 145);
            this.rbReceberPagamento.Name = "rbReceberPagamento";
            this.rbReceberPagamento.Size = new System.Drawing.Size(230, 30);
            this.rbReceberPagamento.TabIndex = 7;
            this.rbReceberPagamento.TabStop = true;
            this.rbReceberPagamento.Text = "Receber Pagamento";
            this.rbReceberPagamento.UseVisualStyleBackColor = true;
            // 
            // rbCadrastrarPedido
            // 
            this.rbCadrastrarPedido.AutoSize = true;
            this.rbCadrastrarPedido.Location = new System.Drawing.Point(11, 109);
            this.rbCadrastrarPedido.Name = "rbCadrastrarPedido";
            this.rbCadrastrarPedido.Size = new System.Drawing.Size(206, 30);
            this.rbCadrastrarPedido.TabIndex = 6;
            this.rbCadrastrarPedido.TabStop = true;
            this.rbCadrastrarPedido.Text = "Cadrastrar Pedido";
            this.rbCadrastrarPedido.UseVisualStyleBackColor = true;
            this.rbCadrastrarPedido.CheckedChanged += new System.EventHandler(this.rbCadrastrarPedido_CheckedChanged);
            // 
            // rbCadrastrarCliente
            // 
            this.rbCadrastrarCliente.AutoSize = true;
            this.rbCadrastrarCliente.Location = new System.Drawing.Point(11, 73);
            this.rbCadrastrarCliente.Name = "rbCadrastrarCliente";
            this.rbCadrastrarCliente.Size = new System.Drawing.Size(206, 30);
            this.rbCadrastrarCliente.TabIndex = 5;
            this.rbCadrastrarCliente.TabStop = true;
            this.rbCadrastrarCliente.Text = "Cadrastrar Cliente";
            this.rbCadrastrarCliente.UseVisualStyleBackColor = true;
            this.rbCadrastrarCliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(372, 260);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReceberPagamento;
        private System.Windows.Forms.RadioButton rbCadrastrarPedido;
        private System.Windows.Forms.RadioButton rbCadrastrarCliente;
        private System.Windows.Forms.Button btnLogoff;
    }
}