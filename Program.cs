using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFactory obj = new ConcreteMembership();

            Console.WriteLine("Which type Membership do you want");
            string type = Console.ReadLine();

            Igym instance = obj.GetGymMembershipType(type);
            Console.WriteLine(instance.getCharges());
        }
    }

         public interface Igym
    {
        int getCharges();
    }
    public class Monthly : Igym
    {
        int Igym.getCharges()
        {
            return 2000;
        }
    }

    public class Yearly : Igym
    {
        int Igym.getCharges()
        {
            return 8000;
        }
    }

    public abstract class MembershipFactory // Factory Class - Creator
    {
        public abstract Igym GetGymMembershipType(string type);
        
    }

    public class ConcreteMembership : MembershipFactory // Concrete creator
    {
        public override Igym GetGymMembershipType(string type)
        {
            switch (type)
            {
                case "montly":
                    return new Monthly();
                    
                case "yearly":
                    return new Yearly();
                    
                default:
                    throw new ApplicationException(string.Format("membership'{0}' not available", type));
            }
        }
    }
   
}
