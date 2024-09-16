using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaWorldCup_app.Entities
{
    public class Controller
    {
        List<Teams> lstTeams = new List<Teams>();
        public IEnumerable<Teams> AllCollection(){
            return lstTeams;
        }
        public void CreateTeams(){
            Teams team= new Teams();
            Console.WriteLine("Ingrese Codigo Equipo:");
            team.IdTeam = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre Equipo:");
            team.NameTeam = Console.ReadLine();
            lstTeams.Add(team);
            Console.WriteLine(lstTeams.Count);
            Console.ReadKey(); 
        }
    }
}