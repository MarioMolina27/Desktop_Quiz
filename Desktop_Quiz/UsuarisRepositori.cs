using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    public class UsuarisRepositori
    {
        public static List<Usuari> Users;


        public static void AddUser (Usuari user)
        {
            Users.Add(user);
            
        }

        public static void DeleteUser (String nickname)
        {   
            //elimina els usuaris que tinguin el matiex nickname que el paremetre
            Users.RemoveAll(x => x.nickname.Equals(nickname));
        }

        public static void ModifyUser (String nickname, Usuari user)
        {
            //funcio landa que ens troba la posicio del user que te el mateix id(nickname), guardem la posicio en una variable
            int UserPosition = Users.FindIndex(x => x.nickname == nickname);

            //comprobem si ha trobat l'usuari, si el troba el modifica
            if(UserPosition != -1)
            {
                Users[UserPosition] = user;    
            }
        }
    }
}
