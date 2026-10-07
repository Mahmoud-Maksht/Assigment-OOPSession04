using System.Security.Cryptography.X509Certificates;

namespace OOP_Session04;

internal class ExpressShipment:Shipment
{
    private decimal Extrafee;
    public ExpressShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, decimal extrafee) : base(trackingcode, description, weight, deliveryfee, destination)
    {
        ExtraFee = extrafee;
   
    }
    public decimal ExtraFee
    {
        get
        {
            return Extrafee;
        }
        set
        {
            Extrafee = value >= 0 ? value : throw new ArgumentException("ExtraFee must be grear than or equal 0");
        }
    }
    public override decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
    }
    public override void PrintShipmentDetails()
    {
        base.PrintShipmentDetails();
        Console.WriteLine($"Extra Fee: {ExtraFee:C}");
    }
}

