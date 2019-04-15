/*APADivRepInfo class that gets the information for the proper
 division rep*/

using System.Linq;
using System.Data.Entity;
using APA;

namespace APAApp
{
    public class APADivRepInfo
    {
        APADataEntities data = new APADataEntities();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int DivNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //constructor that accepts divNum as an argument to get the correct division
        //rep's information
        public APADivRepInfo(int divNum)
        {
            //load DivisionReps Table            
            data.DivisionReps.Load();

            //query local DivisionReps table where DivRepDivisionNumber matches divNum and select
            //those values and add them to a list
            var dr = data.DivisionReps.Local
                .Where(d => d.DivRepDivisionNumber == divNum)
                .Select(s => new
                {                    
                    s.DivRepFirstName,
                    s.DivRepLastName,
                    s.DivRepPhone
                })
                .ToList();

            //loop over dr list and assign item values to properties
            foreach (var item in dr)
            {
                FirstName = item.DivRepFirstName;
                LastName = item.DivRepLastName;
                Phone = item.DivRepPhone;
            }
        }

        public APADivRepInfo(string email)
        {
            data.DivisionReps.Load();

            var divRep = data.DivisionReps.Local
                .Where(d => d.DivRepEmail == email)
                .Select(s => new
                {
                    s.DivRepDivisionNumber,
                    s.DivRepEmail,
                    s.DivRepFirstName,
                    s.DivRepLastName,
                    s.DivRepPhone,
                    s.DivRepPassword
                });

            foreach (var item in divRep)
            {
                FirstName = item.DivRepFirstName;
                LastName = item.DivRepLastName;
                Phone = item.DivRepPhone;
                DivNumber = item.DivRepDivisionNumber;
                Email = item.DivRepEmail;
                Password = item.DivRepPassword;
            }
        }
    }
}
