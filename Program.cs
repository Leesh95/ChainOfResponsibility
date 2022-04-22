namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("#1", false));
            vehicles.Add(new Vehicle("#2", false));
            vehicles.Add(new Vehicle("#3", false));
            vehicles.Add(new Vehicle("#4", true));
            //
            Test test1 = new FirstCheck();
            Test test2 = new Mechanic();
            Test test3 = new Electrician();
            Test test4 = new ExpertMechanic();
            test1.SetNext(test2);
            test2.SetNext(test3);
            test3.SetNext(test4);
            //
            foreach (Vehicle vehicle in vehicles)
            {
                test1.Handle(vehicle);
                Console.WriteLine("___________________\n");
            }
        }
    }
}