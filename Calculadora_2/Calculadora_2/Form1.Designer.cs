namespace Calculadora_2
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
            this.txt_valor1 = new System.Windows.Forms.TextBox();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_expressão = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.txt_expressao = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_valor1
            // 
            this.txt_valor1.Location = new System.Drawing.Point(61, 88);
            this.txt_valor1.Name = "txt_valor1";
            this.txt_valor1.Size = new System.Drawing.Size(100, 20);
            this.txt_valor1.TabIndex = 0;
            // 
            // txt_valor2
            // 
            this.txt_valor2.Location = new System.Drawing.Point(304, 88);
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(100, 20);
            this.txt_valor2.TabIndex = 1;
            // 
            // lbl_valor1
            // 
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Location = new System.Drawing.Point(61, 53);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(40, 13);
            this.lbl_valor1.TabIndex = 2;
            this.lbl_valor1.Text = "Valor 1";
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Location = new System.Drawing.Point(304, 53);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(40, 13);
            this.lbl_valor2.TabIndex = 3;
            this.lbl_valor2.Text = "Valor 2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(184, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 163);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(28, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(184, 186);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(29, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "*";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(184, 209);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(30, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "/";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(64, 268);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "&Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_expressão
            // 
            this.lbl_expressão.AutoSize = true;
            this.lbl_expressão.Location = new System.Drawing.Point(61, 304);
            this.lbl_expressão.Name = "lbl_expressão";
            this.lbl_expressão.Size = new System.Drawing.Size(56, 13);
            this.lbl_expressão.TabIndex = 9;
            this.lbl_expressão.Text = "Expressão";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(61, 335);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.Text = "Resultado";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(61, 362);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 11;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // txt_expressao
            // 
            this.txt_expressao.Location = new System.Drawing.Point(169, 301);
            this.txt_expressao.Name = "txt_expressao";
            this.txt_expressao.Size = new System.Drawing.Size(100, 20);
            this.txt_expressao.TabIndex = 12;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(169, 335);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 407);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_expressao);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_expressão);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbl_valor2);
            this.Controls.Add(this.lbl_valor1);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.txt_valor1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor1;
        private System.Windows.Forms.TextBox txt_valor2;
        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_expressão;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TextBox txt_expressao;
        private System.Windows.Forms.TextBox txt_resultado;
    }
}

