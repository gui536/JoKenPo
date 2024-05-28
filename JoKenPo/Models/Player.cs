using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Choice Choice { get; set; }

        public void MakeChoice()
        {
            Choice = (Choice)new Random().Next(3);
        }
    }
}
