namespace TarjetasProgramIU.Forms
{
    partial class FormularioCompra
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
            ButtonConfirmarCompra = new Button();
            TextBoxMontoCompra = new TextBox();
            LabelPurchaseFormIndication = new Label();
            LabelPrecioProducto = new Label();
            SuspendLayout();
            // 
            // ButtonConfirmarCompra
            // 
            ButtonConfirmarCompra.BackColor = Color.Fuchsia;
            ButtonConfirmarCompra.Font = new Font("Agency FB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ButtonConfirmarCompra.Location = new Point(154, 179);
            ButtonConfirmarCompra.Name = "ButtonConfirmarCompra";
            ButtonConfirmarCompra.Size = new Size(190, 51);
            ButtonConfirmarCompra.TabIndex = 0;
            ButtonConfirmarCompra.Text = "Confirmar Compra";
            ButtonConfirmarCompra.UseVisualStyleBackColor = false;
            ButtonConfirmarCompra.Click += ButtonConfirmarCompra_Click;
            // 
            // TextBoxMontoCompra
            // 
            TextBoxMontoCompra.Location = new Point(154, 140);
            TextBoxMontoCompra.Name = "TextBoxMontoCompra";
            TextBoxMontoCompra.Size = new Size(190, 23);
            TextBoxMontoCompra.TabIndex = 1;
            TextBoxMontoCompra.KeyPress += TextBoxMontoCompra_KeyPress;
            // 
            // LabelPurchaseFormIndication
            // 
            LabelPurchaseFormIndication.AutoSize = true;
            LabelPurchaseFormIndication.BackColor = Color.Transparent;
            LabelPurchaseFormIndication.Font = new Font("Agency FB", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelPurchaseFormIndication.ForeColor = Color.White;
            LabelPurchaseFormIndication.Location = new Point(12, 9);
            LabelPurchaseFormIndication.Name = "LabelPurchaseFormIndication";
            LabelPurchaseFormIndication.Size = new Size(519, 102);
            LabelPurchaseFormIndication.TabIndex = 4;
            LabelPurchaseFormIndication.Text = "Por favor ingresa el total a pagar de tu producto el dinero \r\nse te descontara de tus tarjetas.\r\n\r\n";
            // 
            // LabelPrecioProducto
            // 
            LabelPrecioProducto.AutoSize = true;
            LabelPrecioProducto.BackColor = Color.Transparent;
            LabelPrecioProducto.Font = new Font("Agency FB", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelPrecioProducto.ForeColor = Color.White;
            LabelPrecioProducto.Location = new Point(187, 89);
            LabelPrecioProducto.Name = "LabelPrecioProducto";
            LabelPrecioProducto.Size = new Size(128, 48);
            LabelPrecioProducto.TabIndex = 5;
            LabelPrecioProducto.Text = "Precio del producto:\r\n\r\n";
            LabelPrecioProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormularioCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(521, 256);
            Controls.Add(LabelPrecioProducto);
            Controls.Add(LabelPurchaseFormIndication);
            Controls.Add(TextBoxMontoCompra);
            Controls.Add(ButtonConfirmarCompra);
            Name = "FormularioCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonConfirmarCompra;
        private TextBox TextBoxMontoCompra;
        private Label LabelPurchaseFormIndication;
        private Label LabelPrecioProducto;
    }
}