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

    /**
     * public partial class MainWindow : Form
     * Aquesta classe servirà per poder llegir i escriure els Jsons amb les dades que haguem afegit o modificat
     */

    public class PersRepo
    {
        /**
         * public PersRepo()
         */

        /**
         * Creem una llista d'Objectes Personatge on carregarem les dades dels Jsons
         */
        public static List<Personatge> personatges { get; set; }

        /**
         * Declarem tres constants amb les rutes del diferents arxius
         */

        private const String RUTACAT = @"..\..\JSON\PersCAT.json";
        private const String RUTACAST = @"..\..\JSON\PersCAST.json";
        private const String RUTAANG = @"..\..\JSON\PersAngles.json";

        /**
         * Les funcions a continuació s'encarreguen de carregar l'informació dels Jsons a la llista
         * personatges depenent de l'idioma escollit per l'usuari
         */

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

        /**
         * Les funcions a continuació s'encarreguen de guardar la nova informació que s'hagi modificat a la llista
         * personatges als Jsons per mantindre'ls actualitzats
         */

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
