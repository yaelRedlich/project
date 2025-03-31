
namespace DO;
public record Product
(

     int _id,
     string _nameProduct,
     CategoryName _category,
     double _price,
     int _quantityInStock
)

{
    public Product(int _id) : this(0, "", new CategoryName(), 0.0, 0)
    {

    }
}