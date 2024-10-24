namespace Practica_7_visual_studio
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
            valor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Resultado = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // valor
            // 
            valor.Location = new Point(129, 43);
            valor.Name = "valor";
            valor.Size = new Size(100, 23);
            valor.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(40, 35);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 6;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 35);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 7;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(97, 64);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(149, 31);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 9;
            Resultado.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(valor);
            groupBox1.Location = new Point(179, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 125);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingresa valor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(179, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 117);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones de conversion";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(Resultado);
            groupBox3.Location = new Point(183, 290);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 73);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados en grados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 34);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 13;
            label2.Text = "Equivalente en grados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox valor;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox Resultado;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
    }
}