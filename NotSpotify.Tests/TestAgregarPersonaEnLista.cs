using NotSpotify.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Tests
{
    [TestClass]
    public class TestAgregarPersonaEnLista
    {
        [TestMethod]
        public void TestAdmin()
        {
            string nombre = "Nombre";
            string apellido = "Apellido";
            string eMail = "email@gmail.com";
            string password = "Password";
            string dni = "12345678";
            string[] datos = { nombre, apellido, eMail, password, dni };

            AdministradorABM.AgregarPersonaEnLista<Administrador>(datos);

            Assert.AreEqual(1, VerificadorDeInicio.PersonasCargadas.Count);
            Assert.AreEqual(nombre, VerificadorDeInicio.PersonasCargadas[0].Nombre);
            Assert.AreEqual(apellido, VerificadorDeInicio.PersonasCargadas[0].Apellido);
            Assert.AreEqual(eMail, VerificadorDeInicio.PersonasCargadas[0].Email);
            Assert.AreEqual(password, VerificadorDeInicio.PersonasCargadas[0].Password);
            Assert.AreEqual(dni, ((Administrador)VerificadorDeInicio.PersonasCargadas[0]).Dni);
        }

        [TestMethod]
        public void TestUsuario()
        {
            string nombre = "Nombre";
            string apellido = "Apellido";
            string eMail = "email2@gmail.com";
            string password = "Password";
            string dni = "12345679";
            string[] datos = { nombre, apellido, eMail, password, dni };

            AdministradorABM.AgregarPersonaEnLista<Usuario>(datos);

            Assert.AreEqual(2, VerificadorDeInicio.PersonasCargadas.Count);
            Assert.AreEqual(nombre, VerificadorDeInicio.PersonasCargadas[0].Nombre);
            Assert.AreEqual(apellido, VerificadorDeInicio.PersonasCargadas[0].Apellido);
            Assert.AreEqual(eMail, VerificadorDeInicio.PersonasCargadas[0].Email);
            Assert.AreEqual(password, VerificadorDeInicio.PersonasCargadas[0].Password);
        }

        [TestMethod]
        public void TestNombre()
        {
            string nombre = "dasd4asd3423a";
            string apellido = "Apellido";
            string eMail = "email@gmail.com";
            string password = "Password";
            string dni = "12345678";
            string[] datos = { nombre, apellido, eMail, password, dni };

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.AgregarPersonaEnLista<Usuario>(datos));

            Assert.AreEqual("El nombre y apellido solo puede contener letras y no mas de 40", ex.Message);
        }

        [TestMethod]
        public void TestApellido()
        {
            string nombre = "Nombre";
            string apellido = "Apellidoasdfdsderenfderdsedfgresaedfasdfc"; //41
            string eMail = "email@gmail.com";
            string password = "Password";
            string dni = "12345678";
            string[] datos = { nombre, apellido, eMail, password, dni };

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.AgregarPersonaEnLista<Usuario>(datos));

            Assert.AreEqual("El nombre y apellido solo puede contener letras y no mas de 40", ex.Message);
        }

        [TestMethod]
        public void TestEmail()
        {
            string nombre = "Nombre";
            string apellido = "Apellido";
            string eMail = "5gmail.com";
            string password = "Password";
            string dni = "12345678";
            string[] datos = { nombre, apellido, eMail, password, dni };

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.AgregarPersonaEnLista<Administrador>(datos));

            Assert.AreEqual("El email no es valido", ex.Message);
        }

        [TestMethod]
        public void TestPassword()
        {
            string nombre = "Nombre";
            string apellido = "Apellido";
            string eMail = "5@gmail.com";
            string password = "Pass"; //4
            string dni = "12345678";
            string[] datos = { nombre, apellido, eMail, password, dni };

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.AgregarPersonaEnLista<Administrador>(datos));

            Assert.AreEqual("La password debe tener mas de 5 caracteres y menos de 40", ex.Message);
        }

        [TestMethod]
        public void TestDni()
        {
            string nombre = "Nombre";
            string apellido = "Apellido";
            string eMail = "5@gmail.com";
            string password = "Passw";
            string dni = "1234567a";
            string[] datos = { nombre, apellido, eMail, password, dni };

            var ex = Assert.ThrowsException<Exception>(() => AdministradorABM.AgregarPersonaEnLista<Administrador>(datos));

            Assert.AreEqual("El dni tiene que estar formado solo por 8 numeros", ex.Message);
        }
    }
}
