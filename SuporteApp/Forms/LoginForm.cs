using SuporteApp.Models;
using SuporteApp.Responses;
using SuporteApp.Services;

namespace SuporteApp
{
    public partial class LoginForm : Form
    {
        private readonly ApiService _apiService;

        public LoginForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                btnEntrar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var login = txtLogin.Text.Trim();
                var senha = txtSenha.Text;

                if (string.IsNullOrWhiteSpace(login))
                {
                    MessageBox.Show("Informe o login.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogin.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Informe a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenha.Focus();
                    return;
                }

                var request = new LoginRequest
                {
                    login = login,
                    senha = senha
                };

                var response = await _apiService.PostAsync<LoginRequest, ApiResponse<LoginResponseData>>(
                    "Auth/login",
                    request
                );

                if (response == null)
                {
                    MessageBox.Show("Sem resposta da API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!response.sucesso || response.dados == null)
                {
                    MessageBox.Show(response.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _apiService.DefinirToken(response.dados.token);

                var sessao = new SessaoUsuario
                {
                    token = response.dados.token,
                    usuario = response.dados.usuario,
                    perfil = response.dados.perfil
                };

                var principal = new PrincipalForm(_apiService, sessao);
                principal.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEntrar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}