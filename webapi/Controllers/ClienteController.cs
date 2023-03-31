using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("cliente")]

public class ClienteController : ControllerBase
{
	[HttpGet]
	[Route("list")]
	public	dynamic listClient()
	{
		List<Client> clientes = new List<Client>
		{
			new Client
			{
				id = "1",
				email = "correp@gmail.com",
				name = "Tomas",
				age = "35",
			},
			new Client
			{
				id = "2",
				email = "correp2@gmail.com",
				name = "Sebas",
				age = "45",
			},
		};

		return clientes;
	}	

	[HttpPost]
	[Route("save")]
	public	dynamic saveClient(Client cliente)
	{
		cliente.id = "3";

		return new
		{
			sucess = true,
			message = "Cliente registrado",
			result = cliente
		};

	}	

	[HttpPost]
	[Route("save-admin")]
	public	dynamic saveAdmin(Client cliente)
	{
		Request.Headers.Where(x=> x.Key == "Authorization");
		cliente.id = "3";

		return new
		{
			sucess = true,
			message = "Cliente registrado",
			result = cliente
		};

	}	
}
