namespace Login
{
    partial class frmCadPedido
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbSelecPed = new System.Windows.Forms.ComboBox();
            this.mskDataPed = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumPed = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnAddPed = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinPed = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValItem = new System.Windows.Forms.TextBox();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbSelecPed
            // 
            this.cbSelecPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.cbSelecPed.FormattingEnabled = true;
            this.cbSelecPed.Location = new System.Drawing.Point(224, 82);
            this.cbSelecPed.Name = "cbSelecPed";
            this.cbSelecPed.Size = new System.Drawing.Size(188, 34);
            this.cbSelecPed.TabIndex = 1;
            // 
            // mskDataPed
            // 
            this.mskDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.mskDataPed.Location = new System.Drawing.Point(186, 44);
            this.mskDataPed.Mask = "00/00/0000";
            this.mskDataPed.Name = "mskDataPed";
            this.mskDataPed.Size = new System.Drawing.Size(123, 32);
            this.mskDataPed.TabIndex = 2;
            this.mskDataPed.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione o Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite a Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Digite o Valor do Item:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Subtotal:";
            // 
            // txtNumPed
            // 
            this.txtNumPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtNumPed.Location = new System.Drawing.Point(220, 6);
            this.txtNumPed.Name = "txtNumPed";
            this.txtNumPed.Size = new System.Drawing.Size(192, 32);
            this.txtNumPed.TabIndex = 8;
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtQuant.Location = new System.Drawing.Point(228, 160);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(102, 32);
            this.txtQuant.TabIndex = 10;
            // 
            // btnAddPed
            // 
            this.btnAddPed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnAddPed.Location = new System.Drawing.Point(17, 280);
            this.btnAddPed.Name = "btnAddPed";
            this.btnAddPed.Size = new System.Drawing.Size(199, 38);
            this.btnAddPed.TabIndex = 12;
            this.btnAddPed.Text = "Adicionar Pedido";
            this.btnAddPed.UseVisualStyleBackColor = false;
            this.btnAddPed.Click += new System.EventHandler(this.btnAddPed_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnLimpar.Location = new System.Drawing.Point(298, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 39);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFinPed
            // 
            this.btnFinPed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFinPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnFinPed.Location = new System.Drawing.Point(222, 280);
            this.btnFinPed.Name = "btnFinPed";
            this.btnFinPed.Size = new System.Drawing.Size(180, 38);
            this.btnFinPed.TabIndex = 14;
            this.btnFinPed.Text = "Finalizar Pedido";
            this.btnFinPed.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(12, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:  R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblTotal.Location = new System.Drawing.Point(123, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(186, 28);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "R$ 0                     ";
            // 
            // txtValItem
            // 
            this.txtValItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtValItem.Location = new System.Drawing.Point(246, 122);
            this.txtValItem.Name = "txtValItem";
            this.txtValItem.Size = new System.Drawing.Size(111, 32);
            this.txtValItem.TabIndex = 17;
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblSubTot.Location = new System.Drawing.Point(116, 201);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(144, 28);
            this.lblSubTot.TabIndex = 18;
            this.lblSubTot.Text = "R$ 0              ";
            // 
            // frmCadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lblSubTot);
            this.Controls.Add(this.txtValItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinPed);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAddPed);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtNumPed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDataPed);
            this.Controls.Add(this.cbSelecPed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedido";
            this.Load += new System.EventHandler(this.frmCadPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbSelecPed;
        private System.Windows.Forms.MaskedTextBox mskDataPed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumPed;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnAddPed;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinPed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtValItem;
        private System.Windows.Forms.Label lblSubTot;
    }
}