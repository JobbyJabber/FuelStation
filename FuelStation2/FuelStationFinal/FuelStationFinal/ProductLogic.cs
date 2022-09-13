namespace FuelStationFinal;

public class ProductLogic
{
    public ProductSelect finalProduct;

    public ProductLogic()
    {
        finalProduct = null;
    }

    public ProductLogic(ProductSelect finalProduct)
    {
        this.finalProduct = finalProduct;
    }

    public ProductSelect FinalProduct
    {
        get { return finalProduct; }
        set { finalProduct = value; }
    }

    public bool addProduct(Product productInfo)
    {
        if (productInfo == null)
        {
            return false;
        }

        if (finalProduct == null)
        {
            finalProduct = new ProductSelect();
            finalProduct.Product = productInfo;
        }

        return false;
    }

    public void listProducts()
    {
        if (!(finalProduct == null))
        {
            ProductSelect tmp = finalProduct;
            while (tmp != null)
            {
                tmp.Product.ShowProductStatus();
                tmp = tmp.Next;
            }
        }
        else
        {
            Console.WriteLine("bagnoooo");
        }
    }

    public void listProductByReceipe()
    {
        if (!(finalProduct == null))
        {
            ProductSelect tmp = finalProduct;
            while (tmp != null)
            {
                tmp.Product.itemStatusByInvoice();
                tmp = tmp.Next;
            }
        }
        else
        {
            Console.WriteLine("This receipe is empty.");
        }
    }

    public decimal totalValue()
    {
        decimal count = 0;
        if (!(finalProduct == null))
        {
            ProductSelect tmp = finalProduct;
            while (tmp != null)
            {
                count += tmp.Product.TotalPrice;
                tmp = tmp.Next;
            }
        }

        return count;
    }
}
