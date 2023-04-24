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
            List<Usuario> listaUsuarios = new List<Usuario>();

            Usuario unUsuario = new Usuario("Sylvan", "Utting", "sutting0@tumblr.com", "oP532E7");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Charley", "Frounks", "cfrounks1@vistaprint.com", "UTUKcZW5hb6");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Donal", "Manthorpe", "dmanthorpe2@wordpress.com", "A6kqjJA73dcG");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Ad", "Sushams", "asushams3@tuttocitta.it", "Pu63eKp");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Tamas", "Howford", "thowford4@clickbank.net", "H4CnEjFSGePh");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Letta", "Keerl", "lkeerl5@mtv.com", "lvjbaoyyJ");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Elston", "Menear", "emenear6@tinyurl.com", "qndYPY75KBr");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Nesta", "Sillitoe", "nsillitoe7@noaa.gov", "v6Qqcx");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Dacy", "Wolstenholme", "dwolstenholme8@artisteer.com", "NNWMOFF");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Yulma", "Rasell", "yrasell9@reddit.com", "OB26fm");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Cash", "McBayne", "cmcbaynea@phoca.cz", "Wc7dFhX7o2");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Rooney", "Whitehouse", "rwhitehouseb@apple.com", "InjZt5kqR");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Heidi", "Baford", "hbafordc@nsw.gov.au", "3UMA1EAVPeA");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Fredi", "Frederick", "ffrederickd@artisteer.com", "LShde492OeA");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Jesse", "Gibbons", "jgibbonse@free.fr", "5mn1c3arLR");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Lind", "Slyman", "lslymanf@pen.io", "LFvDPI");
            listaUsuarios.Add(unUsuario);
            unUsuario = new Usuario("Guido", "Insua", "guido@gmail.com", "123");
            listaUsuarios.Add(unUsuario);

            return listaUsuarios;
        }

        static public Administrador HardCodearAdmin()
        {
            Administrador admin = new Administrador("Agustin", "Insua", "insua@gmail.com", "123", "42806238");

            return admin;
        }
    }


}
