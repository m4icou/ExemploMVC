using Microsoft.AspNetCore.Mvc;

namespace ExemploMVC.Controllers;

[Route("usuario")]
public class UsuarioController : Controller 
{
    [Route("cadastro")]
    public IActionResult Cadastro()
    {
        return View();
    }
}