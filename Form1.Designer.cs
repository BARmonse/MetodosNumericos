
namespace MetodosNumericos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRungeKutta = new System.Windows.Forms.RadioButton();
            this.rbEuler = new System.Windows.Forms.RadioButton();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.constanteC = new System.Windows.Forms.TextBox();
            this.constanteB = new System.Windows.Forms.TextBox();
            this.limSuperiorA = new System.Windows.Forms.TextBox();
            this.limInferiorA = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.btnGraficarXFuncionTiempo = new System.Windows.Forms.Button();
            this.btnGraficarDerivadaFuncionTiempo = new System.Windows.Forms.Button();
            this.btnGraficarDerivadaSegundaFuncionTiempo = new System.Windows.Forms.Button();
            this.btnGraficarDerivadaSegundaFuncionX = new System.Windows.Forms.Button();
            this.btnGraficarDerivadaFuncionX = new System.Windows.Forms.Button();
            this.btnGraficarDerivadaSegundaFuncionDerivada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRungeKutta);
            this.groupBox1.Controls.Add(this.rbEuler);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el método";
            // 
            // rbRungeKutta
            // 
            this.rbRungeKutta.AutoSize = true;
            this.rbRungeKutta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRungeKutta.Location = new System.Drawing.Point(105, 35);
            this.rbRungeKutta.Name = "rbRungeKutta";
            this.rbRungeKutta.Size = new System.Drawing.Size(109, 25);
            this.rbRungeKutta.TabIndex = 1;
            this.rbRungeKutta.TabStop = true;
            this.rbRungeKutta.Text = "RungeKutta";
            this.rbRungeKutta.UseVisualStyleBackColor = true;
            // 
            // rbEuler
            // 
            this.rbEuler.AutoSize = true;
            this.rbEuler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEuler.Location = new System.Drawing.Point(18, 35);
            this.rbEuler.Name = "rbEuler";
            this.rbEuler.Size = new System.Drawing.Size(63, 25);
            this.rbEuler.TabIndex = 0;
            this.rbEuler.TabStop = true;
            this.rbEuler.Text = "Euler";
            this.rbEuler.UseVisualStyleBackColor = true;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.constanteC);
            this.gbParametros.Controls.Add(this.constanteB);
            this.gbParametros.Controls.Add(this.limSuperiorA);
            this.gbParametros.Controls.Add(this.limInferiorA);
            this.gbParametros.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbParametros.Location = new System.Drawing.Point(254, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(172, 162);
            this.gbParametros.TabIndex = 3;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "A max:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "A min:";
            // 
            // constanteC
            // 
            this.constanteC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.constanteC.Location = new System.Drawing.Point(60, 129);
            this.constanteC.Name = "constanteC";
            this.constanteC.Size = new System.Drawing.Size(100, 25);
            this.constanteC.TabIndex = 3;
            this.constanteC.Text = "5";
            // 
            // constanteB
            // 
            this.constanteB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.constanteB.Location = new System.Drawing.Point(60, 98);
            this.constanteB.Name = "constanteB";
            this.constanteB.Size = new System.Drawing.Size(100, 25);
            this.constanteB.TabIndex = 2;
            this.constanteB.Text = "10";
            // 
            // limSuperiorA
            // 
            this.limSuperiorA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limSuperiorA.Location = new System.Drawing.Point(60, 63);
            this.limSuperiorA.Name = "limSuperiorA";
            this.limSuperiorA.Size = new System.Drawing.Size(100, 25);
            this.limSuperiorA.TabIndex = 1;
            this.limSuperiorA.Text = "2";
            // 
            // limInferiorA
            // 
            this.limInferiorA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limInferiorA.Location = new System.Drawing.Point(60, 32);
            this.limInferiorA.Name = "limInferiorA";
            this.limInferiorA.Size = new System.Drawing.Size(100, 25);
            this.limInferiorA.TabIndex = 0;
            this.limInferiorA.Text = "0,5";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(12, 91);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(236, 83);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // grdResultados
            // 
            this.grdResultados.AllowUserToAddRows = false;
            this.grdResultados.AllowUserToDeleteRows = false;
            this.grdResultados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Location = new System.Drawing.Point(12, 181);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.ReadOnly = true;
            this.grdResultados.RowTemplate.Height = 25;
            this.grdResultados.Size = new System.Drawing.Size(943, 265);
            this.grdResultados.TabIndex = 5;
            // 
            // btnGraficarXFuncionTiempo
            // 
            this.btnGraficarXFuncionTiempo.Location = new System.Drawing.Point(432, 43);
            this.btnGraficarXFuncionTiempo.Name = "btnGraficarXFuncionTiempo";
            this.btnGraficarXFuncionTiempo.Size = new System.Drawing.Size(153, 40);
            this.btnGraficarXFuncionTiempo.TabIndex = 6;
            this.btnGraficarXFuncionTiempo.Text = "Graficar X1(t)";
            this.btnGraficarXFuncionTiempo.UseVisualStyleBackColor = true;
            this.btnGraficarXFuncionTiempo.Click += new System.EventHandler(this.btnGraficarXFuncionTiempo_Click);
            // 
            // btnGraficarDerivadaFuncionTiempo
            // 
            this.btnGraficarDerivadaFuncionTiempo.Location = new System.Drawing.Point(432, 89);
            this.btnGraficarDerivadaFuncionTiempo.Name = "btnGraficarDerivadaFuncionTiempo";
            this.btnGraficarDerivadaFuncionTiempo.Size = new System.Drawing.Size(153, 39);
            this.btnGraficarDerivadaFuncionTiempo.TabIndex = 7;
            this.btnGraficarDerivadaFuncionTiempo.Text = "Graficar X2(t)";
            this.btnGraficarDerivadaFuncionTiempo.UseVisualStyleBackColor = true;
            this.btnGraficarDerivadaFuncionTiempo.Click += new System.EventHandler(this.btnGraficarDerivadaFuncionTiempo_Click);
            // 
            // btnGraficarDerivadaSegundaFuncionTiempo
            // 
            this.btnGraficarDerivadaSegundaFuncionTiempo.Location = new System.Drawing.Point(432, 134);
            this.btnGraficarDerivadaSegundaFuncionTiempo.Name = "btnGraficarDerivadaSegundaFuncionTiempo";
            this.btnGraficarDerivadaSegundaFuncionTiempo.Size = new System.Drawing.Size(153, 41);
            this.btnGraficarDerivadaSegundaFuncionTiempo.TabIndex = 8;
            this.btnGraficarDerivadaSegundaFuncionTiempo.Text = "Graficar X2\'(t)";
            this.btnGraficarDerivadaSegundaFuncionTiempo.UseVisualStyleBackColor = true;
            this.btnGraficarDerivadaSegundaFuncionTiempo.Click += new System.EventHandler(this.btnGraficarDerivadaSegundaFuncionTiempo_Click);
            // 
            // btnGraficarDerivadaSegundaFuncionX
            // 
            this.btnGraficarDerivadaSegundaFuncionX.Location = new System.Drawing.Point(591, 43);
            this.btnGraficarDerivadaSegundaFuncionX.Name = "btnGraficarDerivadaSegundaFuncionX";
            this.btnGraficarDerivadaSegundaFuncionX.Size = new System.Drawing.Size(153, 40);
            this.btnGraficarDerivadaSegundaFuncionX.TabIndex = 9;
            this.btnGraficarDerivadaSegundaFuncionX.Text = "Graficar X2\'(X1)";
            this.btnGraficarDerivadaSegundaFuncionX.UseVisualStyleBackColor = true;
            this.btnGraficarDerivadaSegundaFuncionX.Click += new System.EventHandler(this.btnGraficarDerivadaSegundaFuncionX_Click);
            // 
            // btnGraficarDerivadaFuncionX
            // 
            this.btnGraficarDerivadaFuncionX.Location = new System.Drawing.Point(591, 88);
            this.btnGraficarDerivadaFuncionX.Name = "btnGraficarDerivadaFuncionX";
            this.btnGraficarDerivadaFuncionX.Size = new System.Drawing.Size(153, 40);
            this.btnGraficarDerivadaFuncionX.TabIndex = 10;
            this.btnGraficarDerivadaFuncionX.Text = "Graficar X2(X1)";
            this.btnGraficarDerivadaFuncionX.UseVisualStyleBackColor = true;
            this.btnGraficarDerivadaFuncionX.Click += new System.EventHandler(this.btnGraficarDerivadaFuncionX_Click);
            // 
            // btnGraficarDerivadaSegundaFuncionDerivada
            // 
            this.btnGraficarDerivadaSegundaFuncionDerivada.Location = new System.Drawing.Point(591, 135);
            this.btnGraficarDerivadaSegundaFuncionDerivada.Name = "btnGraficarDerivadaSegundaFuncionDerivada";
            this.btnGraficarDerivadaSegundaFuncionDerivada.Size = new System.Drawing.Size(153, 40);
            this.btnGraficarDerivadaSegundaFuncionDerivada.TabIndex = 11;
            this.btnGraficarDerivadaSegundaFuncionDerivada.Text = "Graficar X2\'(X2)";
            this.btnGraficarDerivadaSegundaFuncionDerivada.UseVisualStyleBackColor = true;
            this.btnGraficarDerivadaSegundaFuncionDerivada.Click += new System.EventHandler(this.btnGraficarDerivadaSegundaFuncionDerivada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btnGraficarDerivadaSegundaFuncionDerivada);
            this.Controls.Add(this.btnGraficarDerivadaFuncionX);
            this.Controls.Add(this.btnGraficarDerivadaSegundaFuncionX);
            this.Controls.Add(this.btnGraficarDerivadaSegundaFuncionTiempo);
            this.Controls.Add(this.btnGraficarDerivadaFuncionTiempo);
            this.Controls.Add(this.btnGraficarXFuncionTiempo);
            this.Controls.Add(this.grdResultados);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRungeKutta;
        private System.Windows.Forms.RadioButton rbEuler;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox constanteC;
        private System.Windows.Forms.TextBox constanteB;
        private System.Windows.Forms.TextBox limSuperiorA;
        private System.Windows.Forms.TextBox limInferiorA;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.Button btnGraficarXFuncionTiempo;
        private System.Windows.Forms.Button btnGraficarDerivadaFuncionTiempo;
        private System.Windows.Forms.Button btnGraficarDerivadaSegundaFuncionTiempo;
        private System.Windows.Forms.Button btnGraficarDerivadaSegundaFuncionX;
        private System.Windows.Forms.Button btnGraficarDerivadaFuncionX;
        private System.Windows.Forms.Button btnGraficarDerivadaSegundaFuncionDerivada;
    }
}

