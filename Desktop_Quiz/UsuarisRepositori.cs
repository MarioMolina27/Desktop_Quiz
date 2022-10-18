using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Desktop_Quiz
{
    public static class UsuarisRepositori
    {
        //en c# puede ser public
        public static List<Usuari> users;


        private const String RUTAJSON = @"..\..\JSON\USUARIS.json"; 

        public static void LoadUsersList() 
        {
            JArray arrayUsers = JArray.Parse(File.ReadAllText(RUTAJSON));
            UsuarisRepositori.users = arrayUsers.ToObject<List<Usuari>>();
        }
        public static void AddUser (Usuari userAfegir)
        {
            users.Add(userAfegir);
            
        }

        public static void EditUser(Usuari usuariEdited, int indexPosition)
        {   
            //editem el usuari que estigui a la amteixa posició
            users[indexPosition] = usuariEdited;
        }

        public static void DeleteUser (int indexPosition)
        {
            //elimina l'usuari que estigui a la mateixa posició
            users.RemoveAt(indexPosition);
        }

        public static void SaveUsers ()
        {
            //funcio landa que ens troba la posicio del user que te el mateix id(nickname), guardem la posicio en una variable
            //int UserPosition = users.FindIndex(x => x.nickname == nickname);

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(RUTAJSON, json);

        }
    }
}
