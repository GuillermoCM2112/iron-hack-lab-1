using NUnit;
using MiProyecto; // Asegúrate de usar el espacio de nombres correcto

namespace MiProyecto.Tests
{
    public class CalculadoraTests
    {
        [Test]
        public void Sumar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
 
            int a = 5;
            int b = 3;

            // Act
            var resultado = a + b;

            // Assert
            Assert.Equals(8, resultado);
        }
    }
}
