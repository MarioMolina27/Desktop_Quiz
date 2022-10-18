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

        public static List<Personatge> personatgesCat { get; set; }
        public static List<Personatge> personatgesCast { get; set; }
        public static List<Personatge> personatgesAng { get; set; }


        private const String RUTACAT = @"..\..\JSON\PersCAT.json";
        private const String RUTACAST = @"..\..\JSON\PersCAST.json";
        private const String RUTAANG = @"..\..\JSON\PersAngles.json";

        public static void LoadPersListCat()
        {
            JArray arrayPersCat = JArray.Parse(File.ReadAllText(RUTACAT));
            PersRepo.personatgesCat = arrayPersCat.ToObject<List<Personatge>>();
        }

        public static void LoadPersListCast()
        {

                    JArray arrayPersCast = JArray.Parse(File.ReadAllText(RUTACAST));
                    PersRepo.personatgesCast = arrayPersCast.ToObject<List<Personatge>>();
        }

        public static void LoadPersListAng()
        {
            JArray arrayPersAng = JArray.Parse(File.ReadAllText(RUTAANG));
            PersRepo.personatgesAng = arrayPersAng.ToObject<List<Personatge>>();
        }

        public static void AddPers()
        {

            

        }

        public static void DeletePers(String nomPers)
        {

            personatgesCat.RemoveAll(x => x.nomPers.Equals(nomPers));
        }

        public static void SavePers()
        {

            string json = JsonConvert.SerializeObject(personatgesCat, Formatting.Indented);
            File.WriteAllText(RUTACAT, json);

        }

    }
}
