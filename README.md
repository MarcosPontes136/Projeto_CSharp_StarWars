# Projeto_CSharp_StarWars
<h2>Projeto criado para curso em SQL Server usando Windows Form com C# e SQL Serve... Representação de uma API baseada em dados de Star Wars.</h2>
<div>
Nesse presente projeto foi abordado os conceitos de SQL Server, no mesmo projeto foi utilizado a linguagem C# para integrar o banco de dados...
<br>Para que ambos funcionasse foi usado o ASP.NET para unir o WindowsForm, C# e SQL Server e poder consultar, verificar e autorizar.</br>
</div>

<h2>Pagina principal</h2>

<div align="center">
    <img src="/docs/Captura de tela 2022-02-03 173831.png" border="0" width="600" height="200">
    <p>Tela principal</p>
</div>
<div>
Em Tela Principal podemos fazer a sincronização com o banco de dados por causa da classe SincronizadorService que tem esses códigos associados a API com dados do STAR WARS:

```shell script
using Projeto_CShap_Com_SQL.Dao;
using Projeto_CShap_Com_SQL.Entidades;
using Projeto_CShap_Com_SQL.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Projeto_CShap_Com_SQL.Servicos
{
    public class SincronizadorService
    {
        private const string URL_PLANETAS = "http://swapi.dev/api/planets/";
        private const string URL_NAVES = "http://swapi.dev/api/starships/";
        private const string URL_PILOTOS = "http://swapi.dev/api/people/";

        public Task Sincronizar()
        {
            var tasks = new List<Task>();

            tasks.Add(SincronizarPlanetas());
            tasks.Add(SincronizarNaves());

            Task.WhenAll(tasks);

            return SincronizarPilotos();
        }

        private async Task SincronizarPlanetas()
        {
            var httpClient = new HttpClient();
            var lista = new List<PlanetaViewModel>();
            ResultadoApi<PlanetaViewModel> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoApi<PlanetaViewModel>>(resultadoApi?.Next ?? URL_PLANETAS);
                lista.AddRange(resultadoApi.Results);
            } while (resultadoApi.Next != null);

            var planetas = lista.Select(item => new Planeta
            {
                IdPlaneta = item.IdPlaneta,
                Nome = item.Name,
                Clima = item.Climate,
                Diametro = item.Diametro,
                Orbita = item.Orbita,
                Rotacao = item.Rotacao,
                Populacao = item.Populacao
            }).ToList();

            using (var dao = new PlanetaDao())
                await dao.InserirPlanetas(planetas);
        }

        private async Task SincronizarNaves()
        {
            var httpClient = new HttpClient();
            var lista = new List<NaveViewModel>();
            ResultadoApi<NaveViewModel> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoApi<NaveViewModel>>(resultadoApi?.Next ?? URL_NAVES);
                lista.AddRange(resultadoApi.Results);
            } while (resultadoApi.Next != null);

            var naves = lista.Select(item => new Nave
            {
                IdNave = item.IdNave,
                Nome = item.Name,
                Carga = item.Carga,
                Classe = item.Starship_Class,
                Modelo = item.Model,
                Passageiros = item.Passageiros
            }).ToList();

            using (var dao = new NaveDao())
                await dao.InserirNaves(naves);
        }

        private async Task SincronizarPilotos()
        {
            var httpClient = new HttpClient();
            var lista = new List<PilotoViewModel>();
            ResultadoApi<PilotoViewModel> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoApi<PilotoViewModel>>(resultadoApi?.Next ?? URL_PILOTOS);
                lista.AddRange(resultadoApi.Results.Where(p => p.Starships.Any()).ToList());
            } while (resultadoApi.Next != null);

            var pilotos = lista.Select(item => new Piloto
            {
                IdPiloto = item.IdPiloto,
                Nome = item.Name,
                AnoNascimento = item.Birth_Year,
                IdPlaneta = item.IdPlaneta,
                Naves = item.IdNaves.Select(idNave => new Nave
                {
                    IdNave = int.Parse(idNave)
                }).ToList()
            }).ToList();

            using (var pilotoDao = new PilotoDao())
            {
                await pilotoDao.InserirPilotos(pilotos);
                await pilotoDao.InserirPilotosNaves(pilotos);
            }
        }

    }
}
``` 
</div>
<div>
Essa API juntamente com os códigos, fornece todos os dados necessários para sincronizar os dados que estão sendo buscados até o preenchimento total do banco de dados. 
</div>

<div>
<h2>Tela de Controle de Nave</h2>
</div>
<div align="center">
    <img src="/docs/Captura de tela 2022-02-03 175441.png" border="0" width="800" height="400">
    <p>Tela de Controle de Nave</p>
</div>
<div>
Com o banco de dados sincronizado, basta apertar em "CONTROLE" que será encaminhado a próxima tela <h2>⬆️.</h2><br> 
Nessa tela podemos consultar se o piloto tem autorização para entrar ou sair do planeta... 
Podemos fazer todo o controle na tela, colocando o nome e a nave, se está saindo ou chegando. Após selecionar como o modelo acima mostra, vamos em "AVANÇAR":
</br>
</div>

<div align="center"><br>
    <img src="/docs/Captura de tela 2022-02-03 175418.png" border="0" width="800" height="400">
    <p>Registro de Entrada e Saída</p>
</div></br>
<div>
Quando entramos na próxima tela podemos reparar que lado esquerdo e lado direto superior, temos informações mais completas sobre Nave e Piloto, e logo baixo podemos reparar que 
Temos algumas mensagens, essas mensagens mudará caso a caso, nesse caso o Piloto não tinha autorização para chegar nessa Nave, até então temos a mensagem de Perigo:
<br>
PERIGO - PILOTO NÃO SAIU PARA VIAGEM, DEVE SER UM IMPOSTOR
PERIGO - PILOTO QUE RETIROU A NAVE FOI 'HAN SOLO'
</br>
<br>Graças ao código inserido nessa etapa, podemos gerar as mensagens de acordo com cada caso:</br>
</div>

```shell script
using Projeto_CShap_Com_SQL.Dao;
using Projeto_CShap_Com_SQL.Entidades;
using Projeto_CShap_Com_SQL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CShap_Com_SQL.Forms
{
    public partial class frmRegistrarEntradaSaida : Form
    {
        private Piloto _piloto;
        private Piloto _pilotoComandante;
        private Nave _nave;
        private int _idNave;
        private int _idPiloto;
        private bool _chegada;
        private bool _pilotoViajando;

        public frmRegistrarEntradaSaida(int idNave, int idPiloto, bool chegada)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _idNave = idNave;
            _idPiloto = idPiloto;
            _chegada = chegada;

            InitializeComponent();
        }

        private async void frmRegistrarEntradaSaida_Load_2(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? idPilotoComandante;
            using (var naveDao = new NaveDao())
            {
                _nave = await naveDao.ObterPorId(_idNave);
                idPilotoComandante = await naveDao.ObterComandante(_idNave);
            }

            using (var pilotoDao = new PilotoDao())
            {
                _piloto = await pilotoDao.ObterPorId(_idPiloto);
                _pilotoViajando = await pilotoDao.PilotoEstaViajando(_idPiloto);

                if (idPilotoComandante.HasValue)
                    _pilotoComandante = await pilotoDao.ObterPorId(idPilotoComandante.Value);
            }

            lvAlertas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvAlertas.PerformLayout();

            PreencherDadosNave();
            PreencherDadosPiloto();

            if (EhValido())
            {
                btnRegistrar.Enabled = true;
                this.Height = 228;
            }
            else
            {
                btnRegistrar.Enabled = false;
                this.Height = 490;
            }

            if (_chegada)
                btnRegistrar.Text = "Registrar Chegada";
            else
                btnRegistrar.Text = "Registrar Saída";

            Cursor = Cursors.Default;
        }
        private void PreencherDadosNave()
        {
            lblNomeNave.Text = _nave.Nome;
            lblModelo.Text = _nave.Modelo;
            lblClasse.Text = _nave.Classe;
        }

        private void PreencherDadosPiloto()
        {
            lblNomePiloto.Text = _piloto.Nome;
            lblAnoNacimento.Text = _piloto.AnoNascimento;
            lblPlaneta.Text = _piloto.Planeta.Nome;
        }

        private bool EhValido()
        {
            bool ehValido = PilotoEhValido();
            ehValido = NaveEhValida() && ehValido;

            return ehValido;
        }

        private bool PilotoEhValido()
        {
            bool ehValido = true;

            //Saindo
            if (!_chegada)
            {
                if (_pilotoViajando)
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - PILOTO AINDA NÃO CHEGOU DE VIAGEM, DEVE SER UM IMPOSTOR"));
                }

                if (!_piloto.Naves.Any(nave => nave.IdNave == _nave.IdNave))
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem("Este piloto não está habilitado para esta nave"));
                }
            }

            //Chegando
            if (_chegada && !_pilotoViajando)
            {
                ehValido = false;
                lvAlertas.Items.Add(new ListViewItem("PERIGO - PILOTO NÃO SAIU PARA VIAGEM, DEVE SER UM IMPOSTOR"));
            }

            return ehValido;
        }

        private bool NaveEhValida()
        {
            bool ehValido = true;

            //Saindo
            if (!_chegada && _pilotoComandante != null)
            {
                ehValido = false;
                lvAlertas.Items.Add(new ListViewItem("Nave já está em viagem"));
            }

            //Chegando
            if (_chegada)
            {
                if (_pilotoComandante == null)
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - NAVE NÃO SAIU, PODE SER UMA NAVE IMPOSTORA"));
                }

                if (_pilotoComandante != null && _pilotoComandante.IdPiloto != _piloto.IdPiloto)
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem($"PERIGO - PILOTO QUE RETIROU A NAVE FOI '{_pilotoComandante.Nome.ToUpper()}'"));
                }
            }

            return ehValido;
        }

        private void FormRegistrarEntradaSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_chegada)
                await RegistrarEntrada();
            else
                await RegistrarSaida();

            btnRegistrar.Enabled = false;
            MessageBox.Show("Registro efetuado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task RegistrarEntrada()
        {
            using (var pilotoDao = new PilotoDao())
                await pilotoDao.RegistrarFimViagem(_idPiloto, _idNave);
        }

        private async Task RegistrarSaida()
        {
            using (var pilotoDao = new PilotoDao())
                await pilotoDao.RegistrarInicioViagem(_idPiloto, _idNave);
        }
    }
}
```
<div>
<h2>⚠️Deixo de último aviso... A apresentação no README é uma pequena parcela desse projeto, aconselho a survar e curtir⚠️</h2>
<br>
O conteúdo do projeto é bem interessante, a onde podemos até mesmo criar novos projetos a partir desse e aprender cada vez mais!. 
</br>
</div>
