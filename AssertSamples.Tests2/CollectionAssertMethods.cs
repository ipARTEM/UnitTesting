using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertSamples.Tests2
{
    [TestClass]
    public  class CollectionAssertMethods
    {
        static List<string> employees;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            employees = new List<string>();
            employees.Add("Artem");
            employees.Add("Nastya");
            employees.Add("Nikita");
            employees.Add("Demid");
        }

        [TestMethod]
        public void AllItemAreNotNull()
        {
            //Проверка, что все элементы коллекции созданны
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            // проверка значений коллекций на уникальность
            CollectionAssert.AllItemsAreUnique(employees, "Uniqueness faild");
        }


        [TestMethod]
        public void AreEqual()
        {
            List<string> employeesTest = new List<string>();
            employeesTest.Add("Nastya");
            employeesTest.Add("Artem");
            employeesTest.Add("Nikita");
            employeesTest.Add("Demid");

            //в тесте значение и последовательность должны совпадать
            CollectionAssert.AreEqual(employees, employeesTest);

        }

        [TestMethod]
        public void AreEquivalent()
        {
            List<string> employeesTest = new List<string>();
            employeesTest.Add("Nastya");
            employeesTest.Add("Artem");
            employeesTest.Add("Nikita");
            employeesTest.Add("Demid");

            // последовательность не обязательна
            CollectionAssert.AreEquivalent(employees, employeesTest);
        }

        public void employees_Subset()
        {
            List<string> empl_sub = new List<string>();
            empl_sub.Add(employees[2]);

            CollectionAssert.IsSubsetOf(empl_sub, employees, "failed");
        }


    }
}
