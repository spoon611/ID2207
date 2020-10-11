﻿using System;

namespace DataTier
{
    public class EventRequest
    {
        public EventRequest(string recordNr, Client client, string eventType, DateTime from, DateTime to, int attendees, double budget)
        {
            RecordNr = recordNr;
            Client = client;
            EventType = eventType;
            From = from;
            To = to;
            Attendees = attendees;
            Budget = budget;
        }

        public string RecordNr { get; set; }
        public Client Client { get; set; }
        public string EventType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Attendees { get; set; }
        public double Budget { get; set; }
    }
}