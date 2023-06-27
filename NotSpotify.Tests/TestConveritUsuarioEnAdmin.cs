using NotSpotify.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Tests
{
    [TestClass]
    public class TestConveritUsuarioEnAdmin
    {
        [TestMethod]
        public void TestUsuarioExiste()
        {
            Usuario unUsuario = new Usuario("Pepe", "Luis", "pep@gmail.com", "asdfas67");
            Administrador unAdmin = new Administrador("Jota", "Rodriguez", "Jt@gmail.com", "1ssss233", "12345678");

            VerificadorDeInicio.PersonasCargadas.Add(unUsuario);
            VerificadorDeInicio.PersonasCargadas.Add(unAdmin);

            //-----------------

            string eMail = "pep@gmail.com";
            string dni = "12345670";
            Usuario otroUsuario = new Usuario("Lucas", "Longo", eMail, "1asdad67");

            AdministradorABM.ConveritUsuarioEnAdmin(otroUsuario, dni);

            Assert.AreEqual(2, VerificadorDeInicio.PersonasCargadas.Count);
            Assert.IsInstanceOfType(VerificadorDeInicio.PersonasCargadas[0], typeof(Administrador));
            Assert.IsInstanceOfType(VerificadorDeInicio.PersonasCargadas[1], typeof(Administrador));
            Assert.AreNotEqual(((Administrador)VerificadorDeInicio.PersonasCargadas[0]).Dni, ((Administrador)VerificadorDeInicio.PersonasCargadas[1]).Dni);
        }

        [TestMethod]
        public void TestUsuarioNoExiste()
        {
            Usuario unUsuario = new Usuario("Pepe", "Luis", "pep@gmail.com", "ajsfajkf");
            Administrador unAdmin = new Administrador("Jota", "Rodriguez", "Jt@gmail.com", "1asdfag33", "12345678");

            VerificadorDeInicio.PersonasCargadas.Add(unUsuario);
            VerificadorDeInicio.PersonasCargadas.Add(unAdmin);

            //-----------------

            string eMail = "lukita@gmail.com";
            string dni = "12411567";
            Usuario otroUsuario = new Usuario("Lucas", "Longo", eMail, "1asdad67");            

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.ConveritUsuarioEnAdmin(otroUsuario, dni));

            Assert.AreEqual("ERROR, El usuario no exite, no puede ser ascendido", ex.Message);
        }

        [TestMethod]
        public void TestUsuarioDniMal()
        {
            Usuario unUsuario = new Usuario("Pepe", "Luis", "mem@gmail.com", "1234567");
            Administrador unAdmin = new Administrador("Jota", "Rodriguez", "Jt@gmail.com", "12341233", "12345678");

            VerificadorDeInicio.PersonasCargadas.Add(unUsuario);
            VerificadorDeInicio.PersonasCargadas.Add(unAdmin);

            //-----------------

            string eMail = "mem@gmail.com";
            string dni = "1271156";
            Usuario otroUsuario = new Usuario("dfsdfsdf", "Longo", eMail, "1asdad67");

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.ConveritUsuarioEnAdmin(otroUsuario, dni));

            Assert.AreEqual("El dni tiene que estar formado solo por 8 numeros", ex.Message);
        }

        [TestMethod]
        public void TestUsuarioDniOcupado()
        {
            Usuario unUsuario = new Usuario("Pepe", "Luis", "pep@gmail.com", "1234567");
            Administrador unAdmin = new Administrador("Jota", "Rodriguez", "Jt@gmail.com", "12341233", "12345678");

            VerificadorDeInicio.PersonasCargadas.Add(unUsuario);
            VerificadorDeInicio.PersonasCargadas.Add(unAdmin);

            //-----------------

            string eMail = "pep@gmail.com";
            string dni = "12345678";
            Usuario otroUsuario = new Usuario("asdfa", "Longo", eMail, "1asdad67");

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.ConveritUsuarioEnAdmin(otroUsuario, dni));

            Assert.AreEqual("Dni en uso, la persona ya existe", ex.Message);
        }


    }
}
