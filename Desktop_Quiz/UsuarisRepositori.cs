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

        /**
         * Lista estática pública para cargar los usuarios que hay
         */
        public static List<Usuari> users;

        /**
         * Constante que nos indica la ruta del JSON.
         */
        private const String RUTAJSON = @"..\..\JSON\USUARIS.json";

        /**
        * Función que infla la lista con la informacion leida del JSON
        */
        public static void LoadUsersList() 
        {
            JArray arrayUsers = JArray.Parse(File.ReadAllText(RUTAJSON));
            users = arrayUsers.ToObject<List<Usuari>>();
        }

        /**
        * Función que añade un usuario nuevo a la lista
        */
        public static void AddUser (Usuari userAfegir)
        {
            users.Add(userAfegir);
            
        }
        /**
        * Función que substituye un usuario de la lista por otro usuario modificado
        * @usuariEdited usuario de la clase Usuari que vamos a substituir
        * @usuariEdited posición del usuario que vamso a modificar
        */
        public static void EditUser(Usuari usuariEdited, int indexPosition, bool modifyPassword)
        {
            if (modifyPassword)
            {
                users[indexPosition] = usuariEdited;
            }
            else
            {
                users[indexPosition] = new Usuari(usuariEdited.nickname, usuariEdited.nom, users[indexPosition].contrasenya, usuariEdited.tipus, usuariEdited.add, usuariEdited.modify, usuariEdited.delete);
            }
            
        }
        /**
        * Función que borra el usuario que tenga el mismo nickname(id)
        * @nickname id del usuario que queremos borrar
        */
        public static void DeleteUser (String nickname)
        {
            //encuentramos al usuario mediante una funcion lambda 
            int UserPosition = users.FindIndex(x => x.nickname == nickname);
            users.RemoveAt(UserPosition);
        }

        /**
        * Función que guarda en una ruta la lista statica de usuarios.
        * La ruta es la misma que cuando leemos machacamos todo el rato el JSON
        */
        public static void SaveUsers ()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(RUTAJSON, json);

        }
    }
}
