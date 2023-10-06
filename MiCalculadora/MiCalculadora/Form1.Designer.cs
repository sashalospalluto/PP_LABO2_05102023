namespace MiCalculadora
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
            grpSistema = new GroupBox();
            rbdDecimal = new RadioButton();
            rbdBinario = new RadioButton();
            txtSegundoOperador = new TextBox();
            txtPrimerOperador = new TextBox();
            lblResultado = new Label();
            cmbOperacion = new ComboBox();
            lblSegundoOperador = new Label();
            lblOperacion = new Label();
            lblPrimerOperador = new Label();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            btnOperar = new Button();
            lblHistorial = new Label();
            rchHistorial = new RichTextBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rbdDecimal);
            grpSistema.Controls.Add(rbdBinario);
            grpSistema.Location = new Point(225, 134);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(269, 80);
            grpSistema.TabIndex = 23;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rbdDecimal
            // 
            rbdDecimal.AutoSize = true;
            rbdDecimal.Checked = true;
            rbdDecimal.Location = new Point(35, 34);
            rbdDecimal.Name = "rbdDecimal";
            rbdDecimal.Size = new Size(68, 19);
            rbdDecimal.TabIndex = 6;
            rbdDecimal.TabStop = true;
            rbdDecimal.Text = "Decimal";
            rbdDecimal.UseVisualStyleBackColor = true;
            // 
            // rbdBinario
            // 
            rbdBinario.AutoSize = true;
            rbdBinario.Location = new Point(143, 34);
            rbdBinario.Name = "rbdBinario";
            rbdBinario.Size = new Size(62, 19);
            rbdBinario.TabIndex = 7;
            rbdBinario.Text = "Binario";
            rbdBinario.UseVisualStyleBackColor = true;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(480, 299);
            txtSegundoOperador.MaxLength = 10;
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(193, 23);
            txtSegundoOperador.TabIndex = 15;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(57, 299);
            txtPrimerOperador.MaxLength = 10;
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(181, 23);
            txtPrimerOperador.TabIndex = 13;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(38, 23);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(246, 65);
            lblResultado.TabIndex = 22;
            lblResultado.Text = "Resultado:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(274, 299);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(156, 23);
            cmbOperacion.TabIndex = 14;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(480, 253);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(204, 30);
            lblSegundoOperador.TabIndex = 20;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(299, 253);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(120, 30);
            lblOperacion.TabIndex = 18;
            lblOperacion.Text = "Operacion:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(57, 253);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(181, 30);
            lblPrimerOperador.TabIndex = 16;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(480, 371);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(183, 43);
            btnCerrar.TabIndex = 21;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(260, 371);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(183, 43);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(57, 371);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(183, 43);
            btnOperar.TabIndex = 17;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(879, 134);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(87, 25);
            lblHistorial.TabIndex = 24;
            lblHistorial.Text = "Historial";
            // 
            // rchHistorial
            // 
            rchHistorial.Location = new Point(724, 168);
            rchHistorial.Name = "rchHistorial";
            rchHistorial.Size = new Size(384, 249);
            rchHistorial.TabIndex = 26;
            rchHistorial.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 477);
            Controls.Add(rchHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(grpSistema);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(cmbOperacion);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumna Sasha Lospalluto";
            FormClosing += Form1_FormClosing;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSistema;
        private RadioButton rbdDecimal;
        private RadioButton rbdBinario;
        private TextBox txtSegundoOperador;
        private TextBox txtPrimerOperador;
        private Label lblResultado;
        private ComboBox cmbOperacion;
        private Label lblSegundoOperador;
        private Label lblOperacion;
        private Label lblPrimerOperador;
        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnOperar;
        private Label lblHistorial;
        private RichTextBox rchHistorial;
    }
}