/*APAPlayerInfo class that assigns properties with the values from the 
 Players table*/

using System.Linq;
using System.Data.Entity;
using APA;

namespace APAApp
{
    public class APAPlayerInfo
    {
        APADataEntities data = new APADataEntities();

        public int PlayerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int MatchesPlayed { get; set; }
        public int DivNumber { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int TeamNumber { get; set; }
        public int SkillLevel { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public string ExpDate { get; set; }
        public string Status { get; set; }

        //constructor to get player info from the email that is passed to it from 
        //the form
        public APAPlayerInfo(string email)
        {
            //load the Players table
            data.Players.Load();

            //query the local Players table where PlayerEmail matches email that 
            //was passed as an argument and select the values from the table and 
            //add them to a list
            var user = data.Players.Local
                .Where(p => p.PlayerEmail == email)
                .Select(s => new
                {
                    s.PlayerNumber,
                    s.PlayerFirstName,
                    s.PlayerLastName,
                    s.PlayerEmail,
                    s.MatchesPlayed,
                    s.PlayerDivNumber,
                    s.PlayerPassword,
                    s.PlayerPhone,
                    s.PlayerTeamNumber,
                    s.SkillLevel,
                    s.Address,
                    s.City,
                    s.State,
                    s.Zip,
                    s.CardNumber,
                    s.CVC,
                    s.CardExpDate,
                    s.Status
                })
                .ToList();

            //loop over the user list and assign item values to properties
            foreach (var item in user)
            {
                PlayerNumber = item.PlayerNumber;
                FirstName = item.PlayerFirstName;
                LastName = item.PlayerLastName;
                Address = item.Address;
                Email = item.PlayerEmail;
                MatchesPlayed = item.MatchesPlayed;
                DivNumber = item.PlayerDivNumber;
                Password = item.PlayerPassword;
                Phone = item.PlayerPhone;
                TeamNumber = item.PlayerTeamNumber;
                SkillLevel = item.SkillLevel;
                City = item.City;
                State = item.State;
                Zip = item.Zip;
                CardNumber = item.CardNumber;
                ExpDate = item.CardExpDate;
                CVC = item.CVC;
                Status = item.Status;
            }
        }

        //constructor that accepts teamNum as an argument to get the information for 
        //the team captain
        public APAPlayerInfo(int teamNum)
        {
            //load the Players table
            data.Players.Load();

            //query the local Players table where PlayerTeamNumber matches teamNum and
            //Status matches Captain select values to be added to a list
            var captain = data.Players.Local
                .Where(c => c.PlayerTeamNumber == teamNum && c.Status == "Captain")
                .Select(s => new
                {
                    s.PlayerFirstName,
                    s.PlayerLastName,
                    s.PlayerPhone
                })
                .ToList();

            //loop over captain list and assign item values to properties
            foreach (var item in captain)
            {
                FirstName = item.PlayerFirstName;
                LastName = item.PlayerLastName;
                Phone = item.PlayerPhone;
            }
        }
    }
}
