namespace ChainOfResponsibility
{
    public class Vehicle
    {
        public string VehicleNum;
        public bool IsFixed;
        //
        public Vehicle(string vehicleNum, bool isFixed = false)
        {
            VehicleNum = vehicleNum;
            IsFixed = isFixed;
        }
    }
}