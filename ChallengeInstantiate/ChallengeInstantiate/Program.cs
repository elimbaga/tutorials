using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInstantiate
{
    class Program
    {
        static void Main(string[] args)
        {

            //Car montero = new Car();
            //montero.store = "Somewhere";

            //montero.Drive();
            //montero.Stop();
            string retVal;
            retVal = Add(1,2);

             


        }


        static string Add(int numbah1, int numbah2){

            int result = numbah1 + numbah2;
            string answer = "Success";
            Console.WriteLine(result);

            return answer;
        }
    }
}
