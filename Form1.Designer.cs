namespace WinFormsTabla
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
            panelprincipal = new Panel();
            labelAlumno = new Label();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.Brown;
            panelprincipal.Controls.Add(labelAlumno);
            panelprincipal.Controls.Add(richTextBoxResultados);
            panelprincipal.Controls.Add(buttonVer);
            panelprincipal.Controls.Add(textBoxNum);
            panelprincipal.Controls.Add(labelNumero);
            panelprincipal.Controls.Add(labelTitulo);
            panelprincipal.Location = new Point(12, 27);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(644, 344);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panelprincipal_Paint;
            // 
            // labelAlumno
            // 
            labelAlumno.AutoSize = true;
            labelAlumno.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAlumno.Location = new Point(226, 16);
            labelAlumno.Name = "labelAlumno";
            labelAlumno.Size = new Size(199, 20);
            labelAlumno.TabIndex = 5;
            labelAlumno.Text = "Danna Majhli Avalos Santos";
            labelAlumno.Click += labelAlumno_Click;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxResultados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(336, 66);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(158, 262);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.WhiteSmoke;
            buttonVer.ForeColor = SystemColors.ActiveCaptionText;
            buttonVer.Location = new Point(134, 167);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(75, 23);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.Silver;
            textBoxNum.Location = new Point(136, 126);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(73, 23);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = Color.FromArgb(64, 64, 64);
            labelNumero.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.ForeColor = Color.Black;
            labelNumero.Location = new Point(105, 91);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(162, 21);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Black;
            labelTitulo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.Brown;
            labelTitulo.Location = new Point(242, 36);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(163, 18);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de multiplicar";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 394);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labelNumero;
        private Label labelTitulo;
        private TextBox textBoxNum;
        private Button buttonVer;
        private RichTextBox richTextBoxResultados;
        private Label labelAlumno;
    }
}
