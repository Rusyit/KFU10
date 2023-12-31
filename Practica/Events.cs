﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int ParticipantsPerGroup { get; set; }
        public List<Student> Participants { get; set; }

        public Event(string name, DateTime date, int participantsPerGroup)
        {
            Name = name;
            Date = date;
            ParticipantsPerGroup = participantsPerGroup;
            Participants = new List<Student>();
        }
    }
}

