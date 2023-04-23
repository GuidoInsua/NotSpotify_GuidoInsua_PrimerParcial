using NotSpotify.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Metodos
{
    static public class ModificadorDeUsuraios
    {
        static public List<Usuario> HardCodearUsuarios()
        {
            Usuario unUsuario = new Usuario("Guido", "Insua", "guido@gmail.com", "123");
            List <Usuario> listaUsuarios = new List<Usuario>();

            for (int i=0;i < 10; i++)
            {
                listaUsuarios.Add(unUsuario);
            }

            return listaUsuarios;
        }

        static public Administrador HardCodearAdmin()
        {
            Administrador admin = new Administrador("Agustin", "Insua", "insua@gmail.com", "123", "42806238");

            return admin;
        }
    }


}
