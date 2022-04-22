namespace ChainOfResponsibility
{
    public class ExpertMechanic : Test
    {
        public override void Handle(Vehicle request)
        {
            int score = Score();
            Console.WriteLine($"Vehicle Number {request.VehicleNum} - {this.GetType().Name}'s Test: \nScore:{score}");
            //
            if (score >= 7)
            {
                Console.WriteLine($"Vehicle Number {request.VehicleNum} is fixed at the {this.GetType().Name}!");
                request.IsFixed = true;
            }
            else
                Console.WriteLine($"{this.GetType().Name}'s Test - Problem not found");
        }
    }
}