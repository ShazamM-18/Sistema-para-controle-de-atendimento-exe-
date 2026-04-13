using System.Xml.Linq;
using System.Drawing;

namespace SuporteApp
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 25);
            lblTitulo.Text = "Dashboard em criação";

            // DashboardForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(lblTitulo);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}