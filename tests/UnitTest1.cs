using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3_pitpm;
namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void value_test()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(5000, 10, 7, 2, 3, 1.1);
            Assert.AreEqual(Result,1);
        }
       public void test_devide_zero()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(5000, 0, 7, 2, 3, 1.1);
            Assert.AreEqual(Result, -11);
        }
        public void test_get_sum_of_n()
        {
            main_vich test_class = new main_vich();
            int Result1 = test_class.get_count(5000, 100, 7, 2, 3, 1.1);
            int Result2 = test_class.get_count(5000, 100, 7, 2, 3, 1.1);
            int total = Result1 + Result2;
            Assert.AreEqual(total, 6);
        }
        public void big_numbers()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(50000000000, 100000, 17, 20, 13, 1.1);
            Assert.AreEqual(Result, 59);
        }
        public void really_big_numbers()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(5000000000000000000000000000, 100000, 100, 68, 55, 1.1);
            Assert.AreEqual(Result, 11);
        }
        public void numbers_less_than_0()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(-100, -1, 1, 3, 5, 1.1);
            Assert.AreEqual(Result, -11);
        }
        public void letters_in_input_data()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count('hello', 1, 1, 3, 5, 1.1);
            Assert.AreEqual(Result, -11);
        }
        public void value_test_2()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(1000, 10, 7, 3, 5, 1.1);
            Assert.AreEqual(Result, 0);
        }
        public void nums_less_than_0()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(0.1, 0.001, 0.07, 0.003, 0.0005, 1.1);
            Assert.AreEqual(Result, 3069);
        }
        public void koefficient_less_than_can_be()
        {
            main_vich test_class = new main_vich();
            int Result = test_class.get_count(0.1, 0.001, 0.07, 0.003, 0.0005, 0.1);
            Assert.AreEqual(Result, -11);
        }
    }
}
