using SuporteApp.Models;
using SuporteApp.Responses;
using SuporteApp.Services;

namespace SuporteApp
{
    public partial class AtendimentosForm : Form
    {
        private readonly ApiService _apiService;
        private readonly SessaoUsuario _sessao;

        public AtendimentosForm(ApiService apiService, SessaoUsuario sessao)
        {
            InitializeComponent();
            _apiService = apiService;
            _sessao = sessao;
        }

        private async void AtendimentosForm_Load(object sender, EventArgs e)
        {
            cbOrigem.Items.Clear();
            cbOrigem.Items.Add("");
            cbOrigem.Items.Add("WHATSAPP");
            cbOrigem.Items.Add("INSTAGRAM");
            cbOrigem.Items.Add("TELEGRAM");
            cbOrigem.Items.Add("EMAIL");
            cbOrigem.Items.Add("TELEFONE");
            cbOrigem.Items.Add("OUTRO");
            cbOrigem.SelectedIndex = 0;

            ConfigurarGrid();
            await CarregarAtendimentosAsync();
        }

        private void ConfigurarGrid()
        {
            dgvAtendimentos.AutoGenerateColumns = false;
            dgvAtendimentos.Columns.Clear();

            dgvAtendimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id_atendimento",
                HeaderText = "ID",
                DataPropertyName = "id_atendimento",
                Width = 60
            });

            dgvAtendimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "protocolo",
                HeaderText = "Protocolo",
                DataPropertyName = "protocolo",
                Width = 150
            });

            dgvAtendimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "protocolo_externo",
                HeaderText = "Prot. Externo",
                DataPropertyName = "protocolo_externo",
                Width = 120
            });

            dgvAtendimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "origem_atendimento",
                HeaderText = "Origem",
                DataPropertyName = "origem_atendimento",
                Width = 100
            });

            dgvAtendimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "assunto",
                HeaderText = "Assunto",
                DataPropertyName = "assunto",
                Width = 280
            });

            dgvAtendimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "data_abertura",
                HeaderText = "Abertura",
                DataPropertyName = "data_abertura",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dgvAtendimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtendimentos.MultiSelect = false;
            dgvAtendimentos.ReadOnly = true;
            dgvAtendimentos.AllowUserToAddRows = false;
            dgvAtendimentos.AllowUserToDeleteRows = false;
        }

        private async Task CarregarAtendimentosAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var protocolo = txtProtocolo.Text.Trim();
                var protocoloExterno = txtProtocoloExterno.Text.Trim();
                var origem = cbOrigem.Text.Trim();

                var queryParams = new List<string>
                {
                    "pagina=1",
                    "tamanho_pagina=100"
                };

                if (!string.IsNullOrWhiteSpace(protocolo))
                    queryParams.Add($"protocolo={Uri.EscapeDataString(protocolo)}");

                if (!string.IsNullOrWhiteSpace(protocoloExterno))
                    queryParams.Add($"protocolo_externo={Uri.EscapeDataString(protocoloExterno)}");

                if (!string.IsNullOrWhiteSpace(origem))
                    queryParams.Add($"origem_atendimento={Uri.EscapeDataString(origem)}");

                var endpoint = "Atendimentos?" + string.Join("&", queryParams);

                var response = await _apiService.GetAsync<ApiResponse<AtendimentoListaResponse>>(endpoint);

                if (response == null)
                {
                    MessageBox.Show("Sem resposta da API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!response.sucesso || response.dados == null)
                {
                    MessageBox.Show(response.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvAtendimentos.DataSource = response.dados.registros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar atendimentos:{Environment.NewLine}{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            await CarregarAtendimentosAsync();
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new NovoAtendimentoForm(_apiService, _sessao);

            if (form.ShowDialog() == DialogResult.OK)
            {
                await CarregarAtendimentosAsync();
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (dgvAtendimentos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um atendimento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvAtendimentos.CurrentRow.DataBoundItem is not AtendimentoListaItem item)
            {
                MessageBox.Show("Não foi possível obter o atendimento selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AtendimentoDetalheForm(_apiService, _sessao, item.id_atendimento);
            form.ShowDialog();

            _ = CarregarAtendimentosAsync();
        }
    }
}