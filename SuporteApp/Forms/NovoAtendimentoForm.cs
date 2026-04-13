using SuporteApp.Models;
using SuporteApp.Responses;
using SuporteApp.Services;

namespace SuporteApp
{
    public partial class NovoAtendimentoForm : Form
    {
        private readonly ApiService _apiService;
        private readonly SessaoUsuario _sessao;

        public NovoAtendimentoForm(ApiService apiService, SessaoUsuario sessao)
        {
            InitializeComponent();
            _apiService = apiService;
            _sessao = sessao;
        }

        private void NovoAtendimentoForm_Load(object sender, EventArgs e)
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

            cbPrioridade.Items.Clear();
            cbPrioridade.Items.Add(new ComboItem { id = 1, nome = "BAIXA" });
            cbPrioridade.Items.Add(new ComboItem { id = 2, nome = "MEDIA" });
            cbPrioridade.Items.Add(new ComboItem { id = 3, nome = "ALTA" });
            cbPrioridade.Items.Add(new ComboItem { id = 4, nome = "URGENTE" });
            cbPrioridade.DisplayMember = "nome";
            cbPrioridade.ValueMember = "id";
            cbPrioridade.SelectedIndex = 1;

            cbCanal.Items.Clear();
            cbCanal.Items.Add(new ComboItem { id = 1, nome = "WHATSAPP" });
            cbCanal.Items.Add(new ComboItem { id = 2, nome = "TELEFONE" });
            cbCanal.Items.Add(new ComboItem { id = 3, nome = "EMAIL" });
            cbCanal.Items.Add(new ComboItem { id = 4, nome = "PRESENCIAL" });
            cbCanal.Items.Add(new ComboItem { id = 5, nome = "ACESSO_REMOTO" });
            cbCanal.DisplayMember = "nome";
            cbCanal.ValueMember = "id";
            cbCanal.SelectedIndex = 0;

            cbCategoria.Items.Clear();
            cbCategoria.Items.Add(new ComboItem { id = 1, nome = "DUVIDA" });
            cbCategoria.Items.Add(new ComboItem { id = 2, nome = "ERRO_SISTEMA" });
            cbCategoria.Items.Add(new ComboItem { id = 3, nome = "TREINAMENTO" });
            cbCategoria.Items.Add(new ComboItem { id = 4, nome = "CONFIGURACAO" });
            cbCategoria.Items.Add(new ComboItem { id = 5, nome = "IMPLANTACAO" });
            cbCategoria.DisplayMember = "nome";
            cbCategoria.ValueMember = "id";
            cbCategoria.SelectedIndex = 1;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                btnSalvar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (!int.TryParse(txtIdCliente.Text.Trim(), out int idCliente))
                {
                    MessageBox.Show("Informe um ID de cliente válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCliente.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAssunto.Text))
                {
                    MessageBox.Show("Informe o assunto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAssunto.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescricaoInicial.Text))
                {
                    MessageBox.Show("Informe a descrição inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescricaoInicial.Focus();
                    return;
                }

                if (cbPrioridade.SelectedItem is not ComboItem prioridade)
                {
                    MessageBox.Show("Selecione a prioridade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbCanal.SelectedItem is not ComboItem canal)
                {
                    MessageBox.Show("Selecione o canal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? idCategoria = null;
                if (cbCategoria.SelectedItem is ComboItem categoria)
                    idCategoria = categoria.id;

                var request = new AbrirAtendimentoRequest
                {
                    protocolo_externo = string.IsNullOrWhiteSpace(txtProtocoloExterno.Text) ? null : txtProtocoloExterno.Text.Trim(),
                    origem_atendimento = string.IsNullOrWhiteSpace(cbOrigem.Text) ? null : cbOrigem.Text.Trim(),
                    id_cliente = idCliente,
                    id_prioridade_atendimento = prioridade.id,
                    id_canal_atendimento = canal.id,
                    id_categoria_atendimento = idCategoria,
                    assunto = txtAssunto.Text.Trim(),
                    descricao_inicial = txtDescricaoInicial.Text.Trim(),
                    sistema_afetado = string.IsNullOrWhiteSpace(txtSistemaAfetado.Text) ? null : txtSistemaAfetado.Text.Trim(),
                    tela_afetada = string.IsNullOrWhiteSpace(txtTelaAfetada.Text) ? null : txtTelaAfetada.Text.Trim()
                };

                var response = await _apiService.PostAsync<AbrirAtendimentoRequest, ApiResponse<AbrirAtendimentoResponse>>(
                    "Atendimentos",
                    request
                );

                if (response == null)
                {
                    MessageBox.Show("Sem resposta da API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!response.sucesso || response.dados == null)
                {
                    var mensagem = response.mensagem;
                    if (response.erros != null && response.erros.Count > 0)
                        mensagem += Environment.NewLine + string.Join(Environment.NewLine, response.erros);

                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Atendimento aberto com sucesso!{Environment.NewLine}Protocolo: {response.dados.protocolo}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir atendimento:{Environment.NewLine}{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnSalvar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}