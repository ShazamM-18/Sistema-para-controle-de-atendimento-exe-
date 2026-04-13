namespace SuporteApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;

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
            lblLogin = new Label();
            lblSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(110, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 30);
            lblTitulo.Text = "SuporteApp";

            // lblLogin
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(50, 100);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.Text = "Login";

            // txtLogin
            txtLogin.Location = new Point(50, 120);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 23);

            // lblSenha
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(50, 160);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.Text = "Senha";

            // txtSenha
            txtSenha.Location = new Point(50, 180);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(250, 23);
            txtSenha.UseSystemPasswordChar = true;

            // btnEntrar
            btnEntrar.Location = new Point(50, 230);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(250, 35);
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;

            // LoginForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 320);
            Controls.Add(lblTitulo);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnEntrar);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}