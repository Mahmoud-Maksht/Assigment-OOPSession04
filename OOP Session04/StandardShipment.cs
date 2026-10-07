using System.ComponentModel;

namespace OOP_Session04;

internal class StandardShipment:Shipment
{
    public StandardShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination):base (trackingcode, description, weight, deliveryfee, destination)
    {
        
    }
    public override decimal EstimatedCost()
    {
        return DeliveryFee + (decimal)(Weight * 5);
    }
    public override void PrintShipmentDetails()
    {
            base.PrintShipmentDetails();
    }
}

