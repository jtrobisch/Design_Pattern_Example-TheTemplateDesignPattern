using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //In Template pattern, an abstract class exposes defined way(s)/template(s) to execute its 
            //methods.Its subclasses can override the method implementation as per need but the invocation
            //is to be in the same way as defined by an abstract class. This pattern comes under behavior 
            //pattern category.

           Game game = new Cricket();
            game.play();

            Console.WriteLine("\n\n\n");

            game = new Football();
            game.play();

            Console.ReadLine();
        }
    }
}
