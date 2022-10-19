using DesignPattern.BusinessClasses;

namespace DesignPattern
{
    internal class Factory
    {

        public static BaseClass ReturnClassObject(ClassType classType)
        {
           switch (classType)
           {
                case ClassType.Base:
                    return new BaseClass();
                case ClassType.DerivedA:
                    return new DerivedA();
                case ClassType.DerivedB:
                    return new DerivedB();
                default:
                     throw new Exception("Not a valid Class type");
                
            }
        }

        public static BaseClass ReturnClassObject()
        {
            var setting = "ClientA"; //Application may read this setting from
                                     //Database or Configuration file 

            switch (setting)
            {
                case "ClientA":
                    return new BaseClass();
                case "ClientB":
                    return new DerivedA();
                case "ClientC":
                    return new DerivedB();
                default:
                    return new BaseClass();
                    //throw new Exception("Not a valid client type");


            }
        }
    }
}
