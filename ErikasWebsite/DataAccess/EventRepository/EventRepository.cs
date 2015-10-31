using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisinessEntities.Enums;
using BusinessEntities;
using Dapper;
using System.Data;
using BuisinessEntities;


namespace DataAccess.EventRepository
{
    public class EventRepository : DapperBase
    {
        public static Event CreateEvent(Event eventModel)
        {
            using (var con = Open())
            {
                eventModel.CreateDate = DateTime.Now;
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_EventRepositories_CreateEvent.ToString(),
                    new
                    {
                        eventModel.EventId,
                        eventModel.EventDate,
                        eventModel.EventLocation,
                        eventModel.GuestsAttending,
                        eventModel.Title,
                        eventModel.EventDescription,
                        eventModel.CreateDate,
                    }, commandType: CommandType.StoredProcedure);
                eventModel = con.Query<Event>(command).FirstOrDefault();
            }

            if (eventModel == null)
            {
                eventModel = new Event();
            }


            return eventModel;
        }
        public static List<Event> GetAllEvents()
        {
            List<Event> eventModel = new List<Event>();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_EventRepositories_GetAllEvents.ToString(), commandType: CommandType.StoredProcedure);
                eventModel = con.Query<Event>(command).ToList();
            }
            return eventModel;
        }
        public static Event GetEventById(int id)
        {
            Event eventModel = new Event();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_EventRepositories_GetEventById.ToString(),
                    new
                    {
                        id = id
                    }, commandType: CommandType.StoredProcedure);
                eventModel = con.Query<Event>(command).FirstOrDefault();
            }
            return eventModel;
        }
        public static RSVP GetEventRSVPs(string number)
        {
            RSVP rsvp = new RSVP();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_GetEventRSVPs.ToString(),
                    new
                    {
                        ConfimationNumber = number
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).FirstOrDefault();
            }
            return rsvp;
        }
        public static Event EditEvent(Event eventModel)
        {
            using (var con = Open())
            {
                eventModel.EditDate = DateTime.Now;
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_EventRepositories_EditEvent.ToString(),
                    new
                    {
                        eventModel.EventId,
                        eventModel.EventDate,
                        eventModel.EventLocation,
                        eventModel.GuestsAttending,
                        eventModel.Title,
                        eventModel.EventDescription,
                        eventModel.CreateDate,
                    }, commandType: CommandType.StoredProcedure);
                eventModel = con.Query<Event>(command).FirstOrDefault();
            }

            if (eventModel == null)
            {
                eventModel = new Event();
            }


            return eventModel;
        }
        public static void DeleteEvent(int id)
        {
            Event rsvp = new Event();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_EventRepositories_DeleteEvent.ToString(),
                    new
                    {
                        id = id
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<Event>(command).FirstOrDefault();
            }
        }
    }
}
