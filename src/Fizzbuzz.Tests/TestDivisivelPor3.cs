using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Fizzbuzz;

namespace Fizzbuzz.Tests
{
    public class TestDivisivelPor3
    {
        [TestFixture]
        public class DivisiveisPor3
        {
            [Test]
            public void Entrar_Com_Numero_Divisiveis_Por_3()
            {
                //Arrange
                int atual = 3;
                var esperado = "Fizz";
                Fizzbuzzapp fizzbuzzapp = new Fizzbuzzapp();

                //Act
                var resultado = fizzbuzzapp.GerarFizzBuzz(atual);
                //Assert
                Assert.AreEqual(esperado, resultado);
            }

            [Test]
            public void Entrar_Com_Numero_Divisiveis_Por_5()
            {
                //Arrange
                int atual = 5;
                var esperado = "Buzz";
                Fizzbuzzapp fizzbuzzapp = new Fizzbuzzapp();

                //Act
                var resultado = fizzbuzzapp.GerarFizzBuzz(atual);
                //Assert
                Assert.AreEqual(esperado, resultado);
            }

            [Test]
            [TestCase(2)]
            [TestCase(4)]
            [TestCase(7)]
            [TestCase(8)]
            [TestCase(13)]
            [TestCase(22)]
            public void Deve_Retornar_Mesmo_Numero(int value)
            {
                //Arrange
                int atual = value;
                var esperado = value.ToString();
                Fizzbuzzapp fizzbuzzapp = new Fizzbuzzapp();

                //Act
                var resultado = fizzbuzzapp.GerarFizzBuzz(atual);
                //Assert
                Assert.AreEqual(esperado, resultado);
            }

            [Test]
            public void Entrar_Com_Numero_Divisiveis_Por_3_5()
            {
                //Arrange
                int atual = 15;
                var esperado = "FizzBuzz";
                Fizzbuzzapp fizzbuzzapp = new Fizzbuzzapp();

                //Act
                var resultado = fizzbuzzapp.GerarFizzBuzz(atual);
                //Assert
                Assert.AreEqual(esperado, resultado);
            }
            [Test]
            public void testar_de_0_a_100()
            {
                //Arrange
                int atual = 5;
                var esperado = "Buzz";
                Fizzbuzzapp fizzbuzzapp = new Fizzbuzzapp();

                //Act
                var resultado = fizzbuzzapp.EntradaFizzBuzz();


                //Assert
                Assert.IsNotNull(resultado);
            }

        }
    }
}
