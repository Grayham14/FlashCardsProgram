using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace FlashCards
{
    internal class Flashcard
    {
        public string Frontside {  get; set; }
        public string Backside { get; set; }

        
        public enum currentStatus 
        {
            False = 0,
            Correct = 1,
            Unsure = 2
        } 

        public currentStatus CurrentStatus { get; set; }


        public Flashcard(string frontside, string backside, currentStatus currentstatus) 
        { 
            Frontside = frontside;
            Backside = backside;

            CurrentStatus = currentstatus;


        }



    }
}
