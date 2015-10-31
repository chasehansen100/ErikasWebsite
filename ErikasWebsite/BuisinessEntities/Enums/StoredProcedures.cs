using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisinessEntities.Enums
{
    public enum StoredProcedures
    {
        Proc_Custom_RSVPRepositories_CreateRSVP,
        Proc_Custom_RSVPRepositories_GetRSVP,
        Proc_Custom_RSVPRepositories_GetAllRSVPEntries,
        Proc_Custom_RSVPRepositories_EditRSVP,
        Proc_Custom_RSVPRepositories_DeleteRSVP,
        Proc_Custom_RSVPRepositories_GetRSVPByConfimationNumber,
        Proc_Custom_RSVPRepositories_GetEventRSVPs,
        Proc_Custom_EventRepositories_CreateEvent,
        Proc_Custom_EventRepositories_GetAllEvents,
        Proc_Custom_EventRepositories_GetEventById,
        Proc_Custom_EventRepositories_EditEvent,
        Proc_Custom_EventRepositories_GetEventRSVPs,
        Proc_Custom_EventRepositories_DeleteEvent
    }
}
