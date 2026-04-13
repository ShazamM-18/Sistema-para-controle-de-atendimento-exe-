namespace SuporteApp
{
    partial class PrincipalForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBoasVindas;
        private Button btnAtendimentos;
        private Button btnDashboard;
        private Button btnSair;

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
            lblBoasVindas = new Label();
            btnAtendimentos = new Button();
            btnDashboard = new Button();
            btnSair = new Button();
            SuspendLayout();

            // lblBoasVindas
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBoasVindas.Location = new Point(30, 25);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(139, 25);
            lblBoasVindas.Text = "Bem-vindo(a)!";

            // btnAtendimentos
            btnAtendimentos.Location = new Point(35, 90);
            btnAtendimentos.Name = "btnAtendimentos";
            btnAtendimentos.Size = new Size(220, 45);
            btnAtendimentos.Text = "Atendimentos";
            btnAtendimentos.UseVisualStyleBackColor = true;
            btnAtendimentos.Click += btnAtendimentos_Click;

            // btnDashboard
            btnDashboard.Location = new Point(35, 150);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 45);
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;

            // btnSair
            btnSair.Location = new Point(35, 210);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(220, 45);
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;

            // PrincipalForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 320);
            Controls.Add(lblBoasVindas);
            Controls.Add(btnAtendimentos);
            Controls.Add(btnDashboard);
            Controls.Add(btnSair);
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += PrincipalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}