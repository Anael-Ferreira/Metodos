namespace Atividade_Metodos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_elevado = new System.Windows.Forms.Button();
            this.btn_menor = new System.Windows.Forms.Button();
            this.btn_maior = new System.Windows.Forms.Button();
            this.btn_media = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite 5 numeros inteiros:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(128, 323);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(86, 31);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "label2";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(49, 139);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 2;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(49, 165);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 4;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(49, 113);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(49, 87);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 6;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(49, 191);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 7;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(247, 69);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(83, 29);
            this.btn_soma.TabIndex = 8;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_elevado
            // 
            this.btn_elevado.Location = new System.Drawing.Point(247, 209);
            this.btn_elevado.Name = "btn_elevado";
            this.btn_elevado.Size = new System.Drawing.Size(83, 45);
            this.btn_elevado.TabIndex = 9;
            this.btn_elevado.Text = "2° elevando ao 3°";
            this.btn_elevado.UseVisualStyleBackColor = true;
            this.btn_elevado.Click += new System.EventHandler(this.btn_elevado_Click);
            // 
            // btn_menor
            // 
            this.btn_menor.Location = new System.Drawing.Point(247, 174);
            this.btn_menor.Name = "btn_menor";
            this.btn_menor.Size = new System.Drawing.Size(83, 29);
            this.btn_menor.TabIndex = 10;
            this.btn_menor.Text = "Menor";
            this.btn_menor.UseVisualStyleBackColor = true;
            this.btn_menor.Click += new System.EventHandler(this.btn_menor_Click);
            // 
            // btn_maior
            // 
            this.btn_maior.Location = new System.Drawing.Point(247, 139);
            this.btn_maior.Name = "btn_maior";
            this.btn_maior.Size = new System.Drawing.Size(83, 29);
            this.btn_maior.TabIndex = 11;
            this.btn_maior.Text = "Maior";
            this.btn_maior.UseVisualStyleBackColor = true;
            this.btn_maior.Click += new System.EventHandler(this.btn_maior_Click);
            // 
            // btn_media
            // 
            this.btn_media.Location = new System.Drawing.Point(247, 104);
            this.btn_media.Name = "btn_media";
            this.btn_media.Size = new System.Drawing.Size(83, 29);
            this.btn_media.TabIndex = 12;
            this.btn_media.Text = "Media";
            this.btn_media.UseVisualStyleBackColor = true;
            this.btn_media.Click += new System.EventHandler(this.btn_media_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.btn_media);
            this.Controls.Add(this.btn_maior);
            this.Controls.Add(this.btn_menor);
            this.Controls.Add(this.btn_elevado);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_elevado;
        private System.Windows.Forms.Button btn_menor;
        private System.Windows.Forms.Button btn_maior;
        private System.Windows.Forms.Button btn_media;
    }
}

