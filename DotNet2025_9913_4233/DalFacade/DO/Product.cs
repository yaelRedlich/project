


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

    public Product() : this(0, "",new CategoryName() , 0.0, 0)
    {
       


    }
}