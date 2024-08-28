namespace GeradordeSenhas
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
            this.lbxSenhas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.checkMaiusculas = new System.Windows.Forms.CheckBox();
            this.checkAlgarismos = new System.Windows.Forms.CheckBox();
            this.checkSimbolos = new System.Windows.Forms.CheckBox();
            this.numCaracteres = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCaracteres)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSenhas
            // 
            this.lbxSenhas.FormattingEnabled = true;
            this.lbxSenhas.Location = new System.Drawing.Point(12, 12);
            this.lbxSenhas.Name = "lbxSenhas";
            this.lbxSenhas.Size = new System.Drawing.Size(163, 199);
            this.lbxSenhas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num de Caracteres";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(185, 179);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(120, 32);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // checkMaiusculas
            // 
            this.checkMaiusculas.AutoSize = true;
            this.checkMaiusculas.Location = new System.Drawing.Point(185, 66);
            this.checkMaiusculas.Name = "checkMaiusculas";
            this.checkMaiusculas.Size = new System.Drawing.Size(120, 17);
            this.checkMaiusculas.TabIndex = 3;
            this.checkMaiusculas.Text = "Usar MAIUSCULAS";
            this.checkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // checkAlgarismos
            // 
            this.checkAlgarismos.AutoSize = true;
            this.checkAlgarismos.Location = new System.Drawing.Point(185, 89);
            this.checkAlgarismos.Name = "checkAlgarismos";
            this.checkAlgarismos.Size = new System.Drawing.Size(101, 17);
            this.checkAlgarismos.TabIndex = 4;
            this.checkAlgarismos.Text = "Usar Algarismos";
            this.checkAlgarismos.UseVisualStyleBackColor = true;
            // 
            // checkSimbolos
            // 
            this.checkSimbolos.AutoSize = true;
            this.checkSimbolos.Location = new System.Drawing.Point(185, 112);
            this.checkSimbolos.Name = "checkSimbolos";
            this.checkSimbolos.Size = new System.Drawing.Size(93, 17);
            this.checkSimbolos.TabIndex = 5;
            this.checkSimbolos.Text = "Usar Simbolos";
            this.checkSimbolos.UseVisualStyleBackColor = true;
            // 
            // numCaracteres
            // 
            this.numCaracteres.Location = new System.Drawing.Point(185, 29);
            this.numCaracteres.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCaracteres.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCaracteres.Name = "numCaracteres";
            this.numCaracteres.Size = new System.Drawing.Size(120, 20);
            this.numCaracteres.TabIndex = 6;
            this.numCaracteres.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 227);
            this.Controls.Add(this.numCaracteres);
            this.Controls.Add(this.checkSimbolos);
            this.Controls.Add(this.checkAlgarismos);
            this.Controls.Add(this.checkMaiusculas);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxSenhas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCaracteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.CheckBox checkMaiusculas;
        private System.Windows.Forms.CheckBox checkAlgarismos;
        private System.Windows.Forms.CheckBox checkSimbolos;
        private System.Windows.Forms.NumericUpDown numCaracteres;
    }
}

