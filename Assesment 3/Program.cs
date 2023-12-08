
namespace Assesment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs MyDog = new Dogs("Brown", 4, true);

            Console.WriteLine("What Colour is the Dog? " + MyDog.GetColour());
            Console.WriteLine("How many legs? " + MyDog.GetLegs());
            if (MyDog.GetGender())
            {
                Console.WriteLine("Gender : Male Dog ");

            }
            else 
            {

                Console.WriteLine("Gender : Female Dog ");
            }
        }
    }
}