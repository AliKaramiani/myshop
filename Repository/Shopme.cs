public class Shopme : IShopme
{

    Context db = new Context();
    public string AddProduct(Crud x)
    {
        if(db.Tbl_OnlineShop.Any(b=>b.ProductName==x.ProductName))
        return "Duplicate";
        db.Tbl_OnlineShop.Add(x);
        db.SaveChanges();
        return "Done";

    }

    public string DeleteProduct(int ID)
    {
        var x = db.Tbl_OnlineShop.Find(ID);
        db.Tbl_OnlineShop.Remove(x);
        db.SaveChanges();
        return "Done";
    }

    public List<Crud> GetAllproduct()
    {
        return db.Tbl_OnlineShop.ToList();
    }

    public string UpdateProduct(Crud x)
    {
        var result = db.Tbl_OnlineShop.Find(x.ID);
        result.Number = x.Number;
        result.Price = x.Price;
        result.ProductName = x.ProductName;
        db.Tbl_OnlineShop.Update(result);
        db.SaveChanges();
        return "Done";
    }
}