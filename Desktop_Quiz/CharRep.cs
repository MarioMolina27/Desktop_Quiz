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
    internal class CharRep
    {

        public static List<Character> characters { get; set; }

        private const string CHARROUTECAT = @"..\\..\\JSON\\PersCAT.json\";
        private const string CHARROUTECAST = @"..\\..\\JSON\\PersCAST.json\";
        private const string CHARROUTEENG = @"..\\..\\JSON\\PersAngles.json\";

        private static void loadCharListCat() {
        
            JArray arrayCharCat = JArray.Parse(File.ReadAllText(CHARROUTECAT));
            CharRep.characters = arrayCharCat.ToObject<List<Character>>();

        }

        private static void loadCharListCast()
        {

            JArray arrayCharCast = JArray.Parse(File.ReadAllText(CHARROUTECAST));
            CharRep.characters = arrayCharCast.ToObject<List<Character>>();

        }

        private static void loadCharListAng()
        {

            JArray arrayCharEng = JArray.Parse(File.ReadAllText(CHARROUTEENG));
            CharRep.characters = arrayCharEng.ToObject<List<Character>>();

        }

        public static void DeleteCharCat(String name)
        {
            characters.RemoveAll(x => x.nameChar.Equals(name));
        }

        public static void SaveCharCat()
        {

            string json = JsonConvert.SerializeObject(characters, Formatting.Indented);
            File.WriteAllText(CHARROUTECAT, json);

        }

        public static void DeleteCharCast(String name)
        {
            characters.RemoveAll(x => x.nameChar.Equals(name));
        }

        public static void SaveCharCast()
        {

            string json = JsonConvert.SerializeObject(characters, Formatting.Indented);
            File.WriteAllText(CHARROUTECAST, json);

        }

        public static void DeleteCharEng(String name)
        {
            characters.RemoveAll(x => x.nameChar.Equals(name));
        }

        public static void SaveCharEng()
        {

            string json = JsonConvert.SerializeObject(characters, Formatting.Indented);
            File.WriteAllText(CHARROUTEENG, json);

        }

    }
}
