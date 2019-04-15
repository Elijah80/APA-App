/*Class APATeamInfo performs a query on the database and assigns values
 to properties to be used*/

using System.Linq;
using System.Data.Entity;
using APA;

namespace APAApp
{
    public class APATeamInfo
    {
        APADataEntities data = new APADataEntities();

        public int Number { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Points { get; set; }

        //constructor that takes an int as an argument and then peforms the query
        public APATeamInfo(int teamNumber)
        {
            //load the data from the database            
            data.Teams.Load();

            //perform the query based off of the condition that pulls the information
            //from the table where TeamNumber matches teamNumber and then add those
            //items to a list
            var team = data.Teams.Local
                .Where(t => t.TeamNumber == teamNumber)
                .Select(s => new
                {
                    s.TeamNumber,
                    s.TeamName,
                    s.TeamLocation,
                    s.TeamPoints
                })
                .ToList();
            
            //loop over data and assign properties with values from the Teams table
            foreach (var item in team)
            {
                Number = item.TeamNumber;
                Name = item.TeamName;
                Location = item.TeamLocation;
                Points = item.TeamPoints;
            }
        }
    }
}
