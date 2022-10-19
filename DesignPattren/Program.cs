
namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Singleton
            //var businessObject = new BusinessClass();

            var businessObject = BusinessClass.GetSingletonObject();

            businessObject.PrintHelloOnScreen();


            //Factory
            var printer = Factory.ReturnClassObject(ClassType.Base);

            printer.WriteOnScreen();


        }
    }
}