namespace ConverteBase
{
    partial class JanelaConverte
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opcDecimal = new System.Windows.Forms.RadioButton();
            this.opcOctal = new System.Windows.Forms.RadioButton();
            this.opcHexa = new System.Windows.Forms.RadioButton();
            this.opcBinario = new System.Windows.Forms.RadioButton();
            this.valorInserido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(103, 204);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor que deseja converter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione o tipo de valor inserido:";
            // 
            // opcDecimal
            // 
            this.opcDecimal.AutoSize = true;
            this.opcDecimal.Location = new System.Drawing.Point(184, 96);
            this.opcDecimal.Name = "opcDecimal";
            this.opcDecimal.Size = new System.Drawing.Size(63, 17);
            this.opcDecimal.TabIndex = 3;
            this.opcDecimal.TabStop = true;
            this.opcDecimal.Text = "Decimal";
            this.opcDecimal.UseVisualStyleBackColor = true;
            // 
            // opcOctal
            // 
            this.opcOctal.AutoSize = true;
            this.opcOctal.Location = new System.Drawing.Point(184, 142);
            this.opcOctal.Name = "opcOctal";
            this.opcOctal.Size = new System.Drawing.Size(50, 17);
            this.opcOctal.TabIndex = 4;
            this.opcOctal.TabStop = true;
            this.opcOctal.Text = "Octal";
            this.opcOctal.UseVisualStyleBackColor = true;
            // 
            // opcHexa
            // 
            this.opcHexa.AutoSize = true;
            this.opcHexa.Location = new System.Drawing.Point(184, 165);
            this.opcHexa.Name = "opcHexa";
            this.opcHexa.Size = new System.Drawing.Size(86, 17);
            this.opcHexa.TabIndex = 5;
            this.opcHexa.TabStop = true;
            this.opcHexa.Text = "Hexadecimal";
            this.opcHexa.UseVisualStyleBackColor = true;
            // 
            // opcBinario
            // 
            this.opcBinario.AutoSize = true;
            this.opcBinario.Location = new System.Drawing.Point(184, 119);
            this.opcBinario.Name = "opcBinario";
            this.opcBinario.Size = new System.Drawing.Size(57, 17);
            this.opcBinario.TabIndex = 6;
            this.opcBinario.TabStop = true;
            this.opcBinario.Text = "Binário";
            this.opcBinario.UseVisualStyleBackColor = true;
            // 
            // valorInserido
            // 
            this.valorInserido.Location = new System.Drawing.Point(155, 28);
            this.valorInserido.Name = "valorInserido";
            this.valorInserido.Size = new System.Drawing.Size(117, 20);
            this.valorInserido.TabIndex = 7;
            // 
            // JanelaConverte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.valorInserido);
            this.Controls.Add(this.opcBinario);
            this.Controls.Add(this.opcHexa);
            this.Controls.Add(this.opcOctal);
            this.Controls.Add(this.opcDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverter);
            this.Name = "JanelaConverte";
            this.Text = "Convertendo a Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton opcDecimal;
        private System.Windows.Forms.RadioButton opcOctal;
        private System.Windows.Forms.RadioButton opcHexa;
        private System.Windows.Forms.RadioButton opcBinario;
        private System.Windows.Forms.TextBox valorInserido;
    }
}

