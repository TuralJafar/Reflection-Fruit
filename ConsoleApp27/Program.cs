using System.Reflection;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Fruit fruit = new Fruit();
            Fruit[] Basket = new Fruit[3];

            Basket[0]=new Apple(54,12,1.5,"Qizil Ehmedi");

            Basket[1] = new Orange(405,2.5,"Hamlin");
            Basket[2] = new Pinapple(2, 0, 7, " Kayenna");
           

            //Console.WriteLine(Basket);

            // Fruit[] Basket =new Fruit[apple,orange,pinapple];

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();


            foreach (var type in Basket)
            {
                Type type1=type.GetType();
                Console.WriteLine(type1.Name);
                foreach (FieldInfo type2 in type1.GetFields())
                {
                    Console.WriteLine(type2.Name + "." + type2.GetValue(type));
                    
                    //Console.WriteLine(type2.Name);
                    //Console.WriteLine(type2.GetValue(type));
                }
                
                
                //MethodInfo method = typeof(Fruit).GetMethod("taste" ,BindingFlags.NonPublic|BindingFlags.Instance);
                //method.Invoke(Basket,null);
                type.Taste();
                Console.WriteLine("*********");

            }






        }
    }
}