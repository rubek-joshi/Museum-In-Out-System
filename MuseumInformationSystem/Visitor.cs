using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumInformationSystem
{
    class Visitor
    {
        public Visitor(){
        }

        public Visitor(string[] data)
        {
            CardNumber = int.TryParse(data[0], out int cardNumber) ? cardNumber : 0;
            FullName = data[1];
            Email = data[2];
            DateOfBirth = data[3];
            Gender = data[4];
            ContactNumber = data[5];
            Occupation = data[6];
            EntryTime = DateTime.Parse(data[7]);
            if(data.Length.Equals(9))
            {
                ExitTime = DateTime.Parse(data[8]);
            }
        }

        public int CardNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Occupation { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
