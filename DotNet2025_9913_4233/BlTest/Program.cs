using BO;
using DalTest;
namespace BlTest {
public class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    static void Main()
    {
            Initialization.initialize();    
        Console.WriteLine("Welcome to the Order Management System!");
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\n************ Start a New Order ************");
            Console.Write("Enter customer ID (or 0 for anonymous): ");
            int customerId = int.Parse(Console.ReadLine() ?? "0");
            Order order = new Order
            {
                listProduct = new List<ProductInOrder>(),
                finalPrice = 0
            };
            bool addingProducts = true;
            while (addingProducts)
            {
                Console.Write("\nEnter product ID: ");
                int productId = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine() ?? "0");

                try
                {
                    // מוצר להזמנה וקבל מבצעים זמינים
                    List<SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, productId, quantity);

                    // בשביל הדפסת המבצעים
                    if (sales.Any())
                    {
                        Console.WriteLine("\n*** sales for this product: ***");
                        foreach (var sale in sales)
                        {
                            Console.WriteLine($"- Sale {sale._saleId}: {sale._quantityForSale} units for {sale._price:C}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo sales for this product.");
                    }

                    // מדפיס את המחיר הנוכחי הסופי
                    Console.WriteLine($"\nCurrent total order price: {order.finalPrice:C}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                }
                // אם המשתמש רוצה להוסיף מוצר אחר
                Console.Write("\nWould you like to add another product? (y/n): ");
                string? answer = Console.ReadLine()?.Trim().ToLower();
                if (answer != "y")
                    addingProducts = false;
            }
            // בשביל לעדכן את המלאי
            try
            {
                s_bl.Order.DoOrder(order);// בשביל להוריד מהמלאי
                Console.WriteLine("\n*** Order completed successfully! ***");
                Console.WriteLine($"Final total price: {order.finalPrice:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError while completing the order: {ex.Message}");
            }
            // אם המשתמש רוצה להתחיל הזמנה מחדש
            Console.Write("\nWould you like to start a new order? (y/n): ");
            string? continueAnswer = Console.ReadLine()?.Trim().ToLower();
            if (continueAnswer != "y")
                continueRunning = false;
        }
        Console.WriteLine("\nGoodbye!");
    }
}


}