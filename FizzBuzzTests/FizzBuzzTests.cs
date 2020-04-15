using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestClass()]

    
    
    public class FizzBuzzTests
    {
        public static FizzBuzz fizzbuzz;
        [TestInitialize]
        public void Setup()
        {
            fizzbuzz = new FizzBuzz();
        }

        [TestMethod()]
        public void FizzTest_Devuelve_un_numero_entero()
        {
            var numero = 4;
         
            var response = fizzbuzz.Fizz(numero);
            Assert.AreEqual(numero.ToString(), response);

        }

        [TestMethod()]
        public void FizzTest_devuelve_fizz_si_es_Tres()
        {
            var numero = 3;
            var response = fizzbuzz.Fizz(numero);
            Assert.AreEqual("fizz", response);
        }

        [TestMethod()]
        public void FizzTest_devuelve_fizz_si_el_numero_es_multiplo_de_tres()
        {
            var numero = 6;
            var response = fizzbuzz.Fizz(numero);
            Assert.AreEqual("fizz", response);
        }
        [TestMethod()]
        public void FizzTest_devuelve_fizz_si_el_numero_es_multiplo_de_cinco()
        {
            var numero = 5;

            var response = fizzbuzz.Buzz(numero);
            Assert.AreEqual("buzz", response);
        }
    }
}