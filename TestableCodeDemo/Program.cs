namespace TestableCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var ntc = new NonTestableBusinessClass();
            Console.WriteLine(ntc.GetData());

            //Dependency Resolver 
            var dal = new DataAccessLayer();

            var tc = new TestableBusinessClass(dal);

            Console.WriteLine(tc.GetData());


        }
    }
}