using Microsoft.AspNetCore.Mvc;
using ProjetoCleanyBeaches.Models;
using System.Diagnostics;

namespace ProjetoCleanyBeaches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var praias = new List<Praia> {
                new Praia{
                    id = 1,
                    Nome = "Praia da Enseada",
                    img = "img/imgPraia1.png",
                    linkMaps = "https://maps.app.goo.gl/gqdxmhhr2rE6okZy6"
                },
                new Praia{
                    id = 2,
                    Nome = "Praia do L�zaro",
                    img = "img/imgPraia2.png",
                    linkMaps = "https://maps.app.goo.gl/xTXPew5gkUr7jS3Y9"
                },
                new Praia{
                    id = 3,
                    Nome = "Praia do F�lix",
                    img = "img/imgPraia3.png",
                    linkMaps = "https://maps.app.goo.gl/tdjCXRcYNJAtmxHJ9"
                }
            };
            return View(praias);
        }


        public IActionResult Rotas()
        {

            var praias = new List<Praia> {
                new Praia{
                    id = 1,
                    Nome = "Praia da Enseada",
                    img = "imgPraia1.png",
                    condicao = "Pr�pria",
                    rota = "Acesso pela Rodovia Rio-Santos (BR-101). Basta seguir pela rodovia at� o trevo de Ubatuba e ent�o pegar a sa�da em dire��o ao bairro de Toninhas, onde a praia est� localizada.",
                    municipio = new Municipio {
                        Nome = "Ubatuba",
                        Id = 1,
                    }
                },
                new Praia{
                    id = 2,
                    Nome = "Praia do L�zaro",
                    img = "imgPraia2.png",
                    condicao = "Pr�pria",
                    rota = "Para chegar l�, basta seguir pela rodovia BR-101 e, em Ubatuba, pegar a avenida principal que leva ao bairro do L�zaro.",
                    municipio = new Municipio {
                        Nome = "Ubatuba",
                        Id = 1,
                    }
                },
                new Praia{
                    id = 3,
                    Nome = "Praia do F�lix",
                    img = "imgPraia3.png",
                    condicao = "Pr�pria",
                    rota = "Acesso pela Rodovia Rio-Santos (BR-101). Basta seguir pela rodovia at� o trevo de Ubatuba e ent�o pegar a sa�da em dire��o ao bairro de Toninhas, onde a praia est� localizada.",

            municipio = new Municipio {
                        Nome = "Ubatuba",
                        Id = 1,
                    }
                },
            };
            return View(praias);
        }

        public IActionResult Sobre()
        {
            ViewBag.Sobre = "N�s somos uma organiza��o sem fins lucrativos que tem como objetivo recrutar novos trabalhadores volunt�rios para as t�o importantes ONG�s ambientais mar�timas e litor�neas.\r\nNosso aplicativo tamb�m inclui informa��es sobre as praias mais pr�ximas de voc� e refer�ncias de como chegar a esses lugares maravilhosos";
            return View();
        }

        public IActionResult ONGs()
        {
            var ongs = new List<ONG> {
                new ONG{
                    Id = 1,
                    Nome =  "ONG Formiguinhas da Praia",
                    Img =  "imgONGF.png",
                    Instagram = "https://www.instagram.com/formiguinhasdapraia/",
                    Facebook = "https://www.facebook.com/p/Formiguinhas-da-Praia-100083835773071/",
                    Telefone = "(13) 9978-4132",
                    Email = "formiguinhasdapraia@gmail.com",
                    Color = "#4BA0FF",
                    regiao = new Regiao{
                        Id = 1,
                        Nome = "Litoral Sul",
                    }
                },
                new ONG{
                    Id = 2,
                    Nome =  "Instituto EcoFaxina",
                    Img =  "imgONGIEco.png",
                    Instagram = "https://www.instagram.com/ecofaxina",
                    Facebook = "https://www.facebook.com/ecofaxina?_rdc=2&_rdr",
                    Telefone = "(13) 3301-2391",
                    Email = "contato@institutoecofaxina.org.br",
                    Color = "#FFF352",
                    regiao = new Regiao{
                        Id = 2,
                        Nome = "Baixada Santista",
                    }
                },
                new ONG{
                    Id = 3,
                    Nome =  "Mar Limpo",
                    Img =  "imgONGML.png",
                    Instagram = "https://www.instagram.com/mar_limpo",
                    Facebook = "https://www.facebook.com/MarLimpoBrasil/",
                    Telefone = "(12) 9816-8421",
                    Email = "contato@marlimpo.org.br",
                    Color = "#00B0FF",
                    regiao = new Regiao{
                        Id = 3,
                        Nome = "Litoral Norte",
                    }
                },
            };
            return View(ongs);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
