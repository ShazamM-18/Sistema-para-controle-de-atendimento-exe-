using SuporteApp.Models;
using SuporteApp.Responses;
using SuporteApp.Services;

namespace SuporteApp
{
    public partial class AtendimentoDetalheForm : Form
    {
        private readonly ApiService _apiService;
        private readonly SessaoUsuario _sessao;
        private readonly int _idAtendimento;

        public AtendimentoDetalheForm(ApiService apiService, SessaoUsuario sessao, int idAtendimento)
        {
            InitializeComponent();
            _apiService = apiService;
            _sessao = sessao;
            _idAtendimento = idAtendimento;
        }

        private async void AtendimentoDetalheForm_Load(object sender, EventArgs e)
        {
            ConfigurarGridInteracoes();
            await CarregarDetalhesAsync();
        }

        private void ConfigurarGridInteracoes()
        {
            dgvInteracoes.AutoGenerateColumns = false;
            dgvInteracoes.Columns.Clear();

            dgvInteracoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "data_interacao",
                HeaderText = "Data",
                DataPropertyName = "data_interacao",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dgvInteracoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "descricao_interacao",
                HeaderText = "Descrição",
                DataPropertyName = "descricao_interacao",
                Width = 360
            });

            dgvInteracoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "solucao_aplicada",
                HeaderText = "Solução",
                DataPropertyName = "solucao_aplicada",
                Width = 260
            });

            dgvInteracoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInteracoes.MultiSelect = false;
            dgvInteracoes.ReadOnly = true;
            dgvInteracoes.AllowUserToAddRows = false;
            dgvInteracoes.AllowUserToDeleteRows = false;
        }

        private async Task CarregarDetalhesAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var response = await _apiService.GetAsync<ApiResponse<AtendimentoDetalheResponse>>(
                    $"Atendimentos/{_idAtendimento}"
                );

                if (response == null)
                {
                    MessageBox.Show("Sem resposta da API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!response.sucesso || response.dados?.atendimento == null)
                {
                    MessageBox.Show(response.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var atendimento = response.dados.atendimento;

                lblProtocoloValor.Text = atendimento.protocolo;
                lblProtocoloExternoValor.Text = atendimento.protocolo_externo ?? "-";
                lblOrigemValor.Text = atendimento.origem_atendimento ?? "-";
                lblAssuntoValor.Text = atendimento.assunto;
                lblSistemaValor.Text = atendimento.sistema_afetado ?? "-";
                lblTelaValor.Text = atendimento.tela_afetada ?? "-";
                lblDataAberturaValor.Text = atendimento.data_abertura.ToString("dd/MM/yyyy HH:mm");
                txtDescricaoInicial.Text = atendimento.descricao_inicial;
                txtSolucaoFinal.Text = atendimento.solucao_final ?? string.Empty;

                dgvInteracoes.DataSource = response.dados.interacoes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar detalhes:{Environment.NewLine}{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnAdicionarInteracao_Click(object sender, EventArgs e)
        {
            try
            {
                var descricao = txtNovaInteracao.Text.Trim();
                var solucao = txtNovaSolucao.Text.Trim();

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("Informe a descrição da interação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNovaInteracao.Focus();
                    return;
                }

                var request = new AdicionarInteracaoInternaRequest
                {
                    descricao_interacao = descricao,
                    solucao_aplicada = string.IsNullOrWhiteSpace(solucao) ? null : solucao
                };

                var response = await _apiService.PostAsync<AdicionarInteracaoInternaRequest, ApiResponse<string>>(
                    $"Atendimentos/{_idAtendimento}/interacoes-internas",
                    request
                );

                if (response == null)
                {
                    MessageBox.Show("Sem resposta da API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!response.sucesso)
                {
                    MessageBox.Show(response.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Interação adicionada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNovaInteracao.Clear();
                txtNovaSolucao.Clear();

                await CarregarDetalhesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar interação:{Environment.NewLine}{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                var solucaoFinal = txtSolucaoFinal.Text.Trim();

                if (string.IsNullOrWhiteSpace(solucaoFinal))
                {
                    MessageBox.Show("Informe a solução final.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSolucaoFinal.Focus();
                    return;
                }

                var request = new FinalizarAtendimentoInternoRequest
                {
                    solucao_final = solucaoFinal
                };

                var response = await _apiService.PatchAsync<FinalizarAtendimentoInternoRequest, ApiResponse<string>>(
                    $"Atendimentos/{_idAtendimento}/finalizar-interno",
                    request
                );

                if (response == null)
                {
                    MessageBox.Show("Sem resposta da API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!response.sucesso)
                {
                    MessageBox.Show(response.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Atendimento finalizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await CarregarDetalhesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar atendimento:{Environment.NewLine}{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}