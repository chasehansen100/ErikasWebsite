using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisinessEntities.Enums;
using BusinessEntities;
using Dapper;
using System.Data;

namespace DataAccess.RSVPRepository
{
    public class RSVPRepository : DapperBase
    {
        public static RSVP CreateRSVP(RSVP rsvp)
        {
            using (var con = Open())
            {
                rsvp.CreateDate = DateTime.Now;
                rsvp.ConfimationNumber = new Guid();
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_CreateRSVP.ToString(),
                    new
                    {
                        rsvp.RSVPId,
                        rsvp.CreateDate,
                        rsvp.ConfimationNumber,
                        rsvp.isAttending,
                        rsvp.AttendingGuests,
                        rsvp.FavoriteWine,
                        rsvp.FirstName,
                        rsvp.LastName,
                        rsvp.ShortDescription,
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).FirstOrDefault();
            }

            if (rsvp == null)
            {
                rsvp = new RSVP();
            }


            return rsvp;
        }
        public static List<RSVP> GetAllRSVPEntries()
        {
            List<RSVP> rsvp = new List<RSVP>();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_GetAllRSVPEntries.ToString(), commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).ToList();
            }
            return rsvp;
        }
        public static RSVP GetRSVPById(int id)
        {
            RSVP rsvp = new RSVP();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_GetRSVP.ToString(),
                    new
                    {
                        id = id
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).FirstOrDefault();
            }
            return rsvp;
        }
        public static RSVP GetRSVPByConfirmationNumber(string number)
        {
            RSVP rsvp = new RSVP();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_GetRSVPByConfimationNumber.ToString(),
                    new
                    {
                        ConfimationNumber = number
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).FirstOrDefault();
            }
            return rsvp;
        }
        public static RSVP EditRSVP(RSVP rsvp)
        {
            using (var con = Open())
            {
                rsvp.EditDate = DateTime.Now;
                rsvp.ConfimationNumber = new Guid();
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_EditRSVP.ToString(),
                    new
                    {
                        rsvp.RSVPId,
                        rsvp.CreateDate,
                        rsvp.ConfimationNumber,
                        rsvp.isAttending,
                        rsvp.AttendingGuests,
                        rsvp.FavoriteWine,
                        rsvp.FirstName,
                        rsvp.LastName,
                        rsvp.ShortDescription,
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).FirstOrDefault();
            }

            if (rsvp == null)
            {
                rsvp = new RSVP();
            }


            return rsvp;
        }
        public static void DeleteRSVP(int id)
        {
            RSVP rsvp = new RSVP();
            using (var con = Open())
            {
                CommandDefinition command = new CommandDefinition(StoredProcedures.Proc_Custom_RSVPRepositories_DeleteRSVP.ToString(),
                    new
                    {
                        id = id
                    }, commandType: CommandType.StoredProcedure);
                rsvp = con.Query<RSVP>(command).FirstOrDefault();
            }
        }
    }
}
