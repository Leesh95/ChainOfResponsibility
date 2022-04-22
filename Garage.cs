namespace ChainOfResponsibility
{
    public abstract class Test
    {
        protected Test? next;
        //
        public void SetNext(Test next)
        {
            this.next = next;
        }
        //
        public abstract void Handle(Vehicle request);
        //
        public int Score()
        {
            Random scoreNum = new Random();
            return scoreNum.Next(1, 11);
        }
    }
}