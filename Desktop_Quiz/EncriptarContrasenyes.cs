using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    public class EncriptarContrasenyes
    {
        public String encriptarContrasenya (String contrasenya)
        {
            String contraEncriptada;
            contraEncriptada = BCrypt.Net.BCrypt.HashPassword(contrasenya);
            return contraEncriptada;
        }
        public Boolean verificarContra (String contraEncriptada, String contraUser)
        {
            Boolean validPass = BCrypt.Net.BCrypt.Verify(contraEncriptada, contraUser);
            return validPass;
        }
    }
}
