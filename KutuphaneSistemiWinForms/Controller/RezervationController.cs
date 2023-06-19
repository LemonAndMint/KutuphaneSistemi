using KutuphaneSistemiWinForms.SystemData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemiWinForms.Controller
{
    public class RezervationController : BaseController
    {
        public bool getRezervOrTaken(int bookID)
        {
            List<String> variableName = new List<String>{ "bookID", "rezOver" };
            List<String> searchValue = new List<String> { bookID.ToString(), "0" };

            if(databaseManager.listData<Rezervation>(variableName, searchValue) != null)
            {
                return true;
            }

            return false;
        }
        public void createRezervation(Rezervation rezervation)
        {
            databaseManager.createData(rezervation);
        }

        public List<Rezervation> getRezervationFromMember(int memberID)
        {
            List<String> variableName = new List<String> { "memberID" };
            List<String> searchValue = new List<String> { memberID.ToString() };

            List<Rezervation> rezervations = databaseManager.listData<Rezervation>(variableName, searchValue).Cast<Rezervation>().ToList();
        
            return rezervations;
        }

        public Rezervation getCurrentRezervationFromMember(int memberID)
        {
            List<String> variableName = new List<String> { "memberID" , "rezOver" };
            List<String> searchValue = new List<String> { memberID.ToString() , "0" };

            Rezervation rezervation = databaseManager.listData<Rezervation>(variableName, searchValue).Cast<Rezervation>().ToList()[0];

            return rezervation;
        }

        public void updateRezervation(Rezervation rezervation)
        {
            databaseManager.updateData(rezervation);
        }

        public Rezervation getLatestRezervationQueue(int bookID)
        {
            List<String> variableName = new List<String> { "bookID", "rezOver" };
            List<String> searchValue = new List<String> { bookID.ToString(), "0" };

            List<Rezervation> rezervations = databaseManager.listData<Rezervation>(variableName, searchValue).Cast<Rezervation>().ToList();
            
            DateTime latestTime = rezervations.Max(r => r.startTime);
            Rezervation latestRezervation = rezervations.Where(r => r.startTime == latestTime).ToList()[0];

            return latestRezervation;
        
        }
    }
}
