using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteCopiaDeImagens
{
    [TestClass]
    public class Testes
    {
        string _path = @"C:\Imagens3";

        [TestMethod]
        public void CreateDiretorioSucesso()
        {
            var result = CopiaDeImagens.Program.CriarDiretorio(_path);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CreateDiretorioFalhou()
        {
            var result = CopiaDeImagens.Program.CriarDiretorio("");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CopiaDeImagensSucesso()
        {
            var result = CopiaDeImagens.Program.CopiarImagens(_path);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CopiaDeImagensFalhou()
        {
            var result = CopiaDeImagens.Program.CopiarImagens("");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void DiretorioExiste()
        {
            var result = CopiaDeImagens.Program.DiretorioExiste(_path);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DiretorioNaoExiste()
        {
            var result = CopiaDeImagens.Program.DiretorioExiste("");
            Assert.AreEqual(false, result);
        }
    }

}
