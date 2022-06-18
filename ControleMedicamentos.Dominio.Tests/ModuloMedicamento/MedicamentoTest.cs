using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleMedicamentos.Dominio.ModuloFornecedor;
using ControleMedicamentos.Dominio.ModuloMedicamento;

namespace ControleMedicamentos.Dominio.Tests.ModuloMedicamento
{
    [TestClass]
    public class MedicamentoTest
    {
        private readonly Fornecedor fornecedor;
        private readonly Medicamento medicamento;

        public MedicamentoTest()
        {
            fornecedor = new()
            {
                Nome = "Fornecedor1",
                Telefone = "9999999999",
                Email = "fornecedor@gmail.com",
                Cidade = "Lages",
                Estado = "Santa Catarina"
            };
            medicamento = new()
            {
                Nome = 
            }
        }
        [TestMethod]
    }
}
