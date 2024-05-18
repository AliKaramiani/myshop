
public interface IShopme
{
    string AddProduct(Crud x);
    List<Crud>GetAllproduct();
    string DeleteProduct(int ID);
    string UpdateProduct(Crud x);

}