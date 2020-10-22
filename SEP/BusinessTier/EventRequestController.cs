﻿using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessTier
{
    public class EventRequestController
    {

        public EventRequest Create(string recordNr, Client client, string eventType, DateTime from, DateTime to, decimal attendees, string budgetString)
        {
            try
            {
                if (from > to || client == null)
                    return null;

                double budget = double.Parse(budgetString);

                EventRequest eventRequest = new EventRequest(recordNr, client, eventType, from, to, Convert.ToInt32(attendees), budget);
                Seed.eventRequests.Add(eventRequest);
                return eventRequest;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool ChangeState(EventRequest eventRequest, User.Roles role, string feedback)
        {
            switch (role)
            {
                case User.Roles.SeniorCustomerServiceOfficer:
                    eventRequest.State = EventRequest.States.ApprovedBySCSO;
                    return true;
                case User.Roles.FinancialManager:
                    eventRequest.State = EventRequest.States.FinancialFeedbackAdded;
                    eventRequest.FinancialFeedback = feedback;
                    return true;
                case User.Roles.AdministrationDepartmentManager:
                    eventRequest.State = EventRequest.States.Finalized;
                    new EventController().Create(eventRequest);
                    return true;
                default:
                    return false;
            }
        }

        public List<EventRequest> GetEventRequests(User.Roles role)
        {
            switch (role)
            {
                case User.Roles.SeniorCustomerServiceOfficer:
                    return Seed.eventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.Created || eventRequest.State == EventRequest.States.Finalized).ToList();
                case User.Roles.FinancialManager:
                    return Seed.eventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.ApprovedBySCSO).ToList();
                case User.Roles.AdministrationDepartmentManager:
                    return Seed.eventRequests.Where(eventRequest => eventRequest.State == EventRequest.States.FinancialFeedbackAdded).ToList();
                default:
                    return null;
            }
        }
    }
}
