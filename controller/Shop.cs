using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]


public class Shop : ControllerBase
{
    Shopme un = new Shopme();
    [HttpPost]
    public string insert(Crud x)
    {
        return un.AddProduct(x);

    }



    [HttpGet]
    public List<Crud> GetAll()
    {

        return un.GetAllproduct();

    }

    [HttpDelete]
    public string Delete(int ID)
    {

        return un.DeleteProduct(ID);

    }
    [HttpPut]
    public string Update(Crud x)
    {
        return un.UpdateProduct(x);

    }

}