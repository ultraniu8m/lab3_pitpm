using System;
using lab3_pitpm;
namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(5000, 100, 7, 2, 3, 1.1);
           
        }
    }
}
