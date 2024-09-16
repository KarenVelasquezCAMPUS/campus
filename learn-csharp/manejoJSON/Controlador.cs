using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManejoJson.Entities;
using Newtonsoft.Json;

namespace ManejoJson {
    public class Controlador {
        List<Team> teams = new List<Team>();
        public Controlador(){
            if (!ExistsFile()) {
                CrearFile();
            }
        }
        public bool ExistsFile () {
            bool isValid = true;
            if (File.Exists("fifawc.json")) {
                isValid = true;
            } else {
                isValid = false;
            }
            return isValid;
        }
        public void CrearFile() {
            if (!ExistsFile()) {
                File.Create("fifawc.json");
            }
        }
        public void Addinfo() {
            Team equipo = new Team();
            Console.WriteLine("Ingrese el Id del equipo: ");
            equipo.IdTeam = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre del equipo: ");
            equipo.NameTeam = Console.ReadLine();
            teams.Add(equipo);
            SaveDataFile();
        }
        public void SaveDataFile() {
            string json = JsonConvert.SerializeObject(teams, Formatting.Indented);
            File.WriteAllText("fifawc.json", json);
        }
    }
}