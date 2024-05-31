using System;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public float CalculateTotalCost()
    {
        float totalCost = 0;
        foreach(var product in _products){
            totalCost += product.GetTotalCost();
            
        }
        if(_customer.IsInUnitedStates() == true){
                totalCost += 5;
            }
            else{
                totalCost += 35;
            }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(var product in _products){
            packingLabel += product.DisplayProduct() + "\n";
        }
        return packingLabel; //.Trim() Para eliminar el carácter de nueva línea al final
    }
}