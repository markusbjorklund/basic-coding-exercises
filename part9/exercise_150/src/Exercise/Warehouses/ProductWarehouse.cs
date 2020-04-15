namespace Exercise
{
  public class ProductWarehouse : Warehouse
  {

    public string productName;

    public ProductWarehouse(string productName, int capacity) : base(capacity)
    {
      this.productName = productName;
      this.capacity = capacity; 
    }

    public override string ToString()
    {
      // juice me baby, do I need a this?
      return this.productName + ": " + base.ToString();
    }
  }
}