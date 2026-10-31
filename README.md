# SuporteApp | Controle de Atendimentos

![.NET](https://img.shields.io/badge/.NET-8-512BD4) ![C#](https://img.shields.io/badge/C%23-WinForms-512BD4) ![Windows](https://img.shields.io/badge/Windows-Desktop-0078D4)

Aplicação desktop Windows para controle de atendimentos de suporte, desenvolvida em C# com Windows Forms e .NET 8. O aplicativo consome uma API HTTP externa.

> Este repositório contém o cliente desktop, não o código da API ou do banco de dados.

## Funcionalidades identificadas no código
- Login e sessão de usuário;
- Listagem de atendimentos, dashboard e visualização de detalhes;
- Abertura de atendimento com validação de cliente, assunto e descrição;
- Classificação por origem, canal, categoria e prioridade;
- Modelos de interações internas e finalização;
- Integração HTTP com token de autenticação Bearer.

## Tecnologias
| Camada | Tecnologia |
| --- | --- |
| Interface | Windows Forms |
| Linguagem | C# |
| Plataforma | .NET 8 (net8.0-windows) |
| Integração | HttpClient e System.Text.Json |
| Autenticação | Token Bearer enviado à API |

## Estrutura do projeto
- **SuporteApp/Forms:** telas da interface;
- **SuporteApp/Models:** modelos de dados e requisições;
- **SuporteApp/Responses:** respostas da API;
- **SuporteApp/Services:** cliente HTTP e sessão;
- **SuporteApp.slnx:** solução do Visual Studio.

## Como executar
1. Utilize Windows com o .NET 8 SDK e ferramentas de desenvolvimento desktop .NET.
2. Clone: `git clone https://github.com/ShazamM-18/Sistema-para-controle-de-atendimento-exe-.git`
3. Abra a solução `SuporteApp.slnx` no Visual Studio.
4. Confira a propriedade `BaseUrl` em `SuporteApp/Services/ApiService.cs`: atualmente `https://localhost:7043/api`.
5. Disponibilize uma API compatível com os endpoints esperados pelo cliente. Ela não está neste repositório.
6. Execute: `dotnet run --project SuporteApp/SuporteApp.csproj`.

**Limitação:** sem a API compatível, login e operações de consulta ou gravação não funcionarão. A URL está definida no código, não em arquivo de configuração.

## Melhorias futuras
- Mover a URL da API para configuração externa;
- Melhorar tratamento de falhas de rede e HTTP;
- Criar testes automatizados;
- Documentar contratos da API e adicionar capturas de tela.

**Status:** projeto demonstrativo. Recursos descritos foram identificados no código e não constituem garantia de funcionamento em produção.

Desenvolvido por [Michel Abrantes](https://github.com/ShazamM-18).