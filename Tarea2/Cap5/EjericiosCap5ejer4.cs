using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro.Tarea2.EjerciciosCap5
{
    public partial class EjericiosCap5ejer4 : Form
    {
        private GroupBox groupBox1;
        private Label resultadoTextBox;
        private Button CalcularButton;
        private Label label1;
        private TextBox CantidadTextBox;

        public EjericiosCap5ejer4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultadoTextBox = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultadoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(114, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(108, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.AutoSize = true;
            this.resultadoTextBox.Location = new System.Drawing.Point(22, 24);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(50, 13);
            this.resultadoTextBox.TabIndex = 3;
            this.resultadoTextBox.Text = "resultado";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(257, 41);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(50, 23);
            this.CalcularButton.TabIndex = 11;
            this.CalcularButton.Text = "Calcular factorial";
            this.CalcularButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite Numero";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(147, 44);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(76, 20);
            this.CantidadTextBox.TabIndex = 9;
            // 
            // EjericiosCap5ejer4
            // 
            this.ClientSize = new System.Drawing.Size(332, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantidadTextBox);
            this.Name = "EjericiosCap5ejer4";
            this.Text = "EjericiosCap5ejer4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
