using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pstep91
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Project9Entities();
            var post = new Table_2()
            {
                email = "abc",
               nickname = "sss",
               password = "www",
             };
            context.Table_2.Add(post);
            context.SaveChanges();
        }
    }
}
