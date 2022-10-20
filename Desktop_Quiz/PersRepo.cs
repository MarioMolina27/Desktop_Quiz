using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
    public class PersRepo
    {

         

        public static List<Personatge> personatges { get; set; }


        private const String RUTACAT = @"..\..\JSON\PersCAT.json";
        private const String RUTACAST = @"..\..\JSON\PersCAST.json";
        private const String RUTAANG = @"..\..\JSON\PersAngles.json";

        public static void LoadPersListCat()
        {
            JArray arrayPersCat = JArray.Parse(File.ReadAllText(RUTACAT));
            PersRepo.personatges = arrayPersCat.ToObject<List<Personatge>>();
        }

        public static void LoadPersListCast()
        {

                    JArray arrayPersCast = JArray.Parse(File.ReadAllText(RUTACAST));
                    PersRepo.personatges = arrayPersCast.ToObject<List<Personatge>>();
        }

        public static void LoadPersListAng()
        {
            JArray arrayPersAng = JArray.Parse(File.ReadAllText(RUTAANG));
            PersRepo.personatges = arrayPersAng.ToObject<List<Personatge>>();
        }

        public static void SavePersCat()
        {

            string json = JsonConvert.SerializeObject(personatges, Formatting.Indented);
            File.WriteAllText(RUTACAT, json);

        }
        public static void SavePersCast()
        {

            string json = JsonConvert.SerializeObject(personatges, Formatting.Indented);
            File.WriteAllText(RUTACAST, json);

        }
        public static void SavePersAng()
        {

            string json = JsonConvert.SerializeObject(personatges, Formatting.Indented);
            File.WriteAllText(RUTAANG, json);

        }

    }
}
