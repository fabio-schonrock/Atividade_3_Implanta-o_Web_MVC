using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Fabio Schonrock", "fabio@gmail.com", "44565685895", "LUKE");
        Cliente cliente2 = new Cliente(02, "Camila Schonrock", "camila@gmail.com", "54568752365", "LECE");   
        Cliente cliente3 = new Cliente(02, "Gabriela Schonrock", "gabi@gmail.com", "94678254312", "MAILON");
        Cliente cliente4 = new Cliente(03, "Sarah Schonrock", "sarah@gmail.com", "19349764852", "BRUTUS");
        Cliente cliente5 = new Cliente(04, "Maria Schonrock", "maria@gmail.com", "27593614987", "TONTO");
        
        //lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.ListaClientes = listaClientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "16.465.502/0001-90", "c-pet@pet.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Central Pet", "19.645.253/0001-78", "centralpet.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Top Petiscos", "18.231.598/0001-84", "toppetiscos.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Agrobruto", "25.294.386/0001-63", "agrobruto.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bico de Papagaio Rações", "32.689.273/0001-61", "bicodepapagaio.com.br");

        //lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = listaFornecedores;

        return View();
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
