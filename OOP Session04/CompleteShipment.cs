namespace OOP_Session04;

internal sealed class CompleteShipment : Shipment
{
    public CompleteShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination) : base(trackingcode, description, weight, deliveryfee, destination)
    {
          
    }   
}

