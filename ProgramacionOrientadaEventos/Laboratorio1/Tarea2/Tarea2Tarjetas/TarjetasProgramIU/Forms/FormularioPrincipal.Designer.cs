namespace TarjetasProgramIU.Forms
{
    partial class FormularioPrincipal
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
            ButtonRealizarCompra = new Button();
            ListBoxProductos = new ListBox();
            PrecioProductoLabel = new Label();
            WelcomeLabel = new Label();
            LabelIndication = new Label();
            SuspendLayout();
            // 
            // ButtonRealizarCompra
            // 
            ButtonRealizarCompra.BackColor = Color.FromArgb(192, 0, 192);
            ButtonRealizarCompra.Font = new Font("Agency FB", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ButtonRealizarCompra.ForeColor = Color.White;
            ButtonRealizarCompra.Location = new Point(211, 342);
            ButtonRealizarCompra.Name = "ButtonRealizarCompra";
            ButtonRealizarCompra.Size = new Size(206, 52);
            ButtonRealizarCompra.TabIndex = 0;
            ButtonRealizarCompra.Text = "Realizar Compra";
            ButtonRealizarCompra.UseVisualStyleBackColor = false;
            ButtonRealizarCompra.Click += ButtonRealizarCompra_Click;
            // 
            // ListBoxProductos
            // 
            ListBoxProductos.BackColor = Color.Fuchsia;
            ListBoxProductos.BorderStyle = BorderStyle.FixedSingle;
            ListBoxProductos.FormattingEnabled = true;
            ListBoxProductos.ItemHeight = 15;
            ListBoxProductos.Location = new Point(211, 61);
            ListBoxProductos.Name = "ListBoxProductos";
            ListBoxProductos.SelectionMode = SelectionMode.MultiExtended;
            ListBoxProductos.Size = new Size(206, 92);
            ListBoxProductos.TabIndex = 1;
            ListBoxProductos.SelectedIndexChanged += ListBoxProductos_SelectedIndexChanged;
            // 
            // PrecioProductoLabel
            // 
            PrecioProductoLabel.AutoSize = true;
            PrecioProductoLabel.Font = new Font("Agency FB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PrecioProductoLabel.ForeColor = Color.White;
            PrecioProductoLabel.Location = new Point(211, 264);
            PrecioProductoLabel.Name = "PrecioProductoLabel";
            PrecioProductoLabel.Size = new Size(113, 31);
            PrecioProductoLabel.TabIndex = 2;
            PrecioProductoLabel.Text = "Total a pagar";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BackColor = Color.Transparent;
            WelcomeLabel.Font = new Font("Agency FB", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(131, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(355, 35);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "BIENVENID@ A LA TIENDA \"EL BARATON\"\r\n";
            // 
            // LabelIndication
            // 
            LabelIndication.AutoSize = true;
            LabelIndication.BackColor = Color.Transparent;
            LabelIndication.Font = new Font("Agency FB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelIndication.ForeColor = Color.White;
            LabelIndication.Location = new Point(96, 171);
            LabelIndication.Name = "LabelIndication";
            LabelIndication.Size = new Size(453, 93);
            LabelIndication.TabIndex = 4;
            LabelIndication.Text = "Por favor selecciona tu producto puedes seleccionar mas\r\n productos dando clic derecho + CTRL  si asi lo deseas.\r\n\r\n";
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(653, 406);
            Controls.Add(LabelIndication);
            Controls.Add(WelcomeLabel);
            Controls.Add(PrecioProductoLabel);
            Controls.Add(ListBoxProductos);
            Controls.Add(ButtonRealizarCompra);
            ForeColor = Color.Black;
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonRealizarCompra;
        private ListBox ListBoxProductos;
        private Label PrecioProductoLabel;
        private Label WelcomeLabel;
        private Label LabelIndication;
    }
}