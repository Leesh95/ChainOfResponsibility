namespace ChainOfResponsibility
{
    public class FirstCheck : Test
    {
        public override void Handle(Vehicle request)
        {
            if (!request.IsFixed)
            {
                int score = Score();
                Console.WriteLine($"Vehicle Number {request.VehicleNum} - {this.GetType().Name}'s Test: \nScore:{score}");
                //
                if (score >= 7)
                {
                    Console.WriteLine($"Vehicle Number {request.VehicleNum} is fixed at the {this.GetType().Name}!");
                    request.IsFixed = true;
                }
                else if (next != null)
                {
                    Console.WriteLine($"{this.GetType().Name}'s Test - Problem not found");
                    next.Handle(request);
                }
            }
            else
                Console.WriteLine($"Vehicle Number {request.VehicleNum} is OK. The vehicle did not need further examination.");
        }
    }
}