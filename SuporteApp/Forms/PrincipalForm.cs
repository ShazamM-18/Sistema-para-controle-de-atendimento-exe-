using SuporteApp.Services;

namespace SuporteApp
{
    public partial class PrincipalForm : Form
    {
        private readonly ApiService _apiService;
        private readonly SessaoUsuario _sessao;

        public PrincipalForm(ApiService apiService, SessaoUsuario sessao)
        {
            InitializeComponent();
            _apiService = apiService;
            _sessao = sessao;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            Text = $"SuporteApp - Usuário: {_sessao.usuario} ({_sessao.perfil})";
            lblBoasVindas.Text = $"Bem-vindo, {_sessao.usuario}!";
        }

        private void btnAtendimentos_Click(object sender, EventArgs e)
        {
            var form = new AtendimentosForm(_apiService, _sessao);
            form.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var form = new DashboardForm(_apiService, _sessao);
            form.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}