using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Product{
    string name;
    string productCode;
    string brandName;
    int stockLeft;
    double price;
    DateTime expiryDate;
	
	
    public string Name{ get {  return name; } set { name = value; } }
    public string ProductCode { get { return productCode; } set { productCode = value; } }
    public string BrandName { get { return brandName; } set { brandName = value; } }
    public int StockLeft { get { return stockLeft; } set { stockLeft = value; } }
    public double Price { get { return price; } set { price = value; } }
    public DateTime ExpiryDate { get { return expiryDate; } set {  expiryDate=value; } }
	
	
    public Product() { }
	
    public Product(string name, string productCode, string brandName, int stockLeft, double price, DateTime expiryDate)
    {
        this.name = name;this.productCode = productCode;
        this.brandName = brandName;this.stockLeft = stockLeft;
	is.price = price;this.expiryDate = expiryDate;
    }
	
	
    public override string ToString()
    {
        string str = "Name:" + name + "\nProductCode:" + productCode + "\nBrandName:" + brandName + "\nStockLeft:" + stockLeft + "\nPrice:" + price + "\nExpiryDate:" + expiryDate;
        return str;
    }
	
	
    public  bool Equals(Product p)
    {
        if (this.name.ToLower() == p.name.ToLower() & this.productCode == p.productCode)
            return true;
        else
            return false;
    }
}
