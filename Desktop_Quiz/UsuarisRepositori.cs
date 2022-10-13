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
    public class UsuarisRepositori
    {
        public static List<Usuari> users;
        private const String RUTAJSON = @"..\..\JSON\USUARIS.json"; 

        public static void LoadUsersList() 
        {
            JArray arrayUsers = JArray.Parse(File.ReadAllText(RUTAJSON));
            UsuarisRepositori.users = arrayUsers.ToObject<List<Usuari>>();
        }
        public static void AddUser (Usuari user)
        {
            users.Add(user);
            
        }

        public static void DeleteUser (String nickname)
        {   
            //elimina els usuaris que tinguin el matiex nickname que el paremetre
            users.RemoveAll(x => x.nickname.Equals(nickname));
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
