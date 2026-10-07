namespace OOP_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre Deriver");
            string drivername = Console.ReadLine();
            Driver driver = new Driver(drivername);

            Console.WriteLine("Entre Centre Name");
            string centername = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centername);

            center.Driver = driver;

            Console.WriteLine("---------- Standard Shipment ----------");
            Console.Write("Entre TrackingCode :");
            string trackingcode = Console.ReadLine();
            Console.Write("Entre Decription :");
            string desription = Console.ReadLine();
            Console.Write("Entre Weight :");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Entre DeliveryFee :");
            decimal deliveryfee = decimal.Parse(Console.ReadLine());
            Console.Write("Enter city :");
            string city = Console.ReadLine();
            Console.Write("Entre Street :");
            string street = Console.ReadLine();
            Console.Write("Entre BuildingNumber :");
            int buildingNumber = int.Parse(Console.ReadLine());
            DeliveryAddress deliveryAddress = new DeliveryAddress(city, street, buildingNumber);
            StandardShipment standardShipment = new(trackingcode, desription, weight, deliveryfee, deliveryAddress);


            Console.WriteLine("---------- Express Shipment ----------");
            Console.Write("Entre TrackingCode :");
            string trackingcode2 = Console.ReadLine();
            Console.Write("Entre Decription :");
            string desription2 = Console.ReadLine();
            Console.Write("Entre Weight :");
            double weight2 = double.Parse(Console.ReadLine());
            Console.Write("Entre DeliveryFee :");
            decimal deliveryfee2 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter city :");
            string city2 = Console.ReadLine();
            Console.Write("Entre Street :");
            string street2 = Console.ReadLine();
            Console.Write("Entre BuildingNumber :");
            int buildingNumber2 = int.Parse(Console.ReadLine());
            Console.Write("Entre Extrafee :");
            decimal extrafee = decimal.Parse(Console.ReadLine());
            DeliveryAddress deliveryAddress2 = new DeliveryAddress(city2, street2, buildingNumber2);
            ExpressShipment expressShipment = new ExpressShipment(trackingcode2, desription2, weight2, deliveryfee2, deliveryAddress2, extrafee);

            Console.WriteLine("---------- International Shipment ----------");
            Console.Write("Entre TrackingCode :");
            string trackingcode3 = Console.ReadLine();
            Console.Write("Entre Decription :");
            string desription3 = Console.ReadLine();
            Console.Write("Entre Weight :");
            double weight3 = double.Parse(Console.ReadLine());
            Console.Write("Entre DeliveryFee :");
            decimal deliveryfee3 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter city :");
            string city3 = Console.ReadLine();
            Console.Write("Entre Street :");
            string street3 = Console.ReadLine();
            Console.Write("Entre BuildingNumber :");
            int buildingNumber3 = int.Parse(Console.ReadLine());
            Console.Write("Entre DestenationCountry :");
            string destenationcountry = Console.ReadLine();
            Console.Write("Entre CustomFee :");
            decimal customfee = decimal.Parse(Console.ReadLine());
            DeliveryAddress deliveryAddress3 = new DeliveryAddress(city3, street3, buildingNumber3);
            InternationalShipment internationalShipment = new InternationalShipment(trackingcode3, desription3, weight3, deliveryfee3, deliveryAddress3, destenationcountry, customfee);

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            Console.WriteLine("---------- print shipments ----------");
            Console.WriteLine($"Driver: {drivername}");
            center.PrintAllShipments();

            DeliveryHelper deliveryHelper = new DeliveryHelper();
            Console.WriteLine("---------- print shipment details ----------");
            deliveryHelper.PrintShipment(standardShipment);
            deliveryHelper.PrintShipment(expressShipment);
            deliveryHelper.PrintShipment(internationalShipment);

            Console.WriteLine("---------- Demonstrate both versions of UpdateWeight ----------");
            Console.WriteLine();
            Console.WriteLine("---------- Update Weight ----------");
            Console.WriteLine($"Original Weight: {standardShipment.Weight}KG");
            Console.WriteLine("Enter new weight:");
            double newWeight = double.Parse(Console.ReadLine());
            standardShipment.UpdateWeight(newWeight);
            Console.WriteLine($"Updated Weight: {standardShipment.Weight}KG");
            Console.WriteLine("Updating Packing Weight:");
            double extraPackingWeight = double.Parse(Console.ReadLine());
            standardShipment.UpdateWeight(newWeight, extraPackingWeight);
            Console.WriteLine($"Updated Weight After Packing: {standardShipment.Weight}KG");

            Console.WriteLine("---------- print shipment details ----------");
            Shipment[] shipments = { standardShipment, expressShipment, internationalShipment };
            for (int i = 0; i < shipments.Length; i++)
            {
                Console.WriteLine($"Shipment {i + 1}:");
                shipments[i].PrintShipmentDetails();
                Console.WriteLine();
            }

            Console.WriteLine("---------- Sealed Class And Sealed Methods ----------");
            //CompletedShipment is a sealed class.

            //GenerateCustomsReport() is a sealed method
            //in PriorityInternationalShipment.
        }
    }
}
