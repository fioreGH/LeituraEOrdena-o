namespace WindowsFormsAppLeitorXLXs
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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rBQuick = new System.Windows.Forms.RadioButton();
            this.rBBubble = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(27, 35);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(486, 20);
            this.txtCaminho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho do Arquivo:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(531, 35);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(122, 23);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.btnExecutar);
            this.gBox.Controls.Add(this.rBQuick);
            this.gBox.Controls.Add(this.rBBubble);
            this.gBox.Enabled = false;
            this.gBox.Location = new System.Drawing.Point(27, 97);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(200, 115);
            this.gBox.TabIndex = 5;
            this.gBox.TabStop = false;
            this.gBox.Text = "Escolha o Método de Ordenação:";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(23, 86);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(146, 23);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rBQuick
            // 
            this.rBQuick.AutoSize = true;
            this.rBQuick.Location = new System.Drawing.Point(62, 54);
            this.rBQuick.Name = "rBQuick";
            this.rBQuick.Size = new System.Drawing.Size(72, 17);
            this.rBQuick.TabIndex = 6;
            this.rBQuick.TabStop = true;
            this.rBQuick.Text = "QuickSort";
            this.rBQuick.UseVisualStyleBackColor = true;
            // 
            // rBBubble
            // 
            this.rBBubble.AutoSize = true;
            this.rBBubble.Location = new System.Drawing.Point(62, 30);
            this.rBBubble.Name = "rBBubble";
            this.rBBubble.Size = new System.Drawing.Size(77, 17);
            this.rBBubble.TabIndex = 5;
            this.rBBubble.TabStop = true;
            this.rBBubble.Text = "BubbleSort";
            this.rBBubble.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(262, 148);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(531, 174);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 224);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminho);
            this.Name = "Form1";
            this.Text = "Método de Ordenação em Planilha do Excel";
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton rBQuick;
        private System.Windows.Forms.RadioButton rBBubble;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExecutar;
    }
}

