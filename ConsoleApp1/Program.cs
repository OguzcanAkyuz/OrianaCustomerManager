using DataAccess.Concrete.MongoDB;
using System;

namespace ConsoleApp1
{
    public class Program
    {
      private static MongoDB_UserDal mongoDB_UserDal = new MongoDB_UserDal();
        static void Main(string[] args)
        {
            foreach (var item in mongoDB_UserDal.GetClaims("111111111111111111111111"))
            {
                Console.WriteLine(item.Name);
            }
           
        }
    }
}
