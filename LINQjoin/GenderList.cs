using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LINQjoin
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
               Id= Guid.Parse("dad88543-2ab1-4fa0-822b-b83f6d07753e"),
               GenderName ="male"
            }, 

            new Gender()
            {
               Id= Guid.Parse("da988543-2ab1-4fa0-822b-b83f6d07753e"),
               GenderName ="female"
            }
        };
    }
}
