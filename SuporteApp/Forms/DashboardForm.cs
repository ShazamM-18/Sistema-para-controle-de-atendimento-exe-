using SuporteApp.Services;

namespace SuporteApp
{
    public partial class DashboardForm : Form
    {
        private readonly ApiService _apiService;
        private readonly SessaoUsuario _sessao;

        public DashboardForm(ApiService apiService, SessaoUsuario sessao)
        {
            InitializeComponent();
            _apiService = apiService;
            _sessao = sessao;
        }
    }
}