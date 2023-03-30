using BusesControl.Models;
using BusesControl.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BusesControl.ViewComponents {
    public class MenuSec : ViewComponent {

        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public MenuSec(IFuncionarioRepositorio funcionarioRepositorio) {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public async Task<IViewComponentResult> InvokeAsync() {

            string sectionUser = HttpContext.Session.GetString("sectionUserAutenticado");

            if (string.IsNullOrEmpty(sectionUser)) {
                return null;
            }

            Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(sectionUser);
            funcionario = _funcionarioRepositorio.ListarPorIdNoJoin(funcionario.Id);
            return View(funcionario);
        }
    }
}
