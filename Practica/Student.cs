using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime LastEvent { get; set; }

        public Student(string name, string group, DateTime lastEvent)
        {
            Name = name;
            Group = group;
            LastEvent = lastEvent;
        }
        public bool WantsToParticipate()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }
    }
}

