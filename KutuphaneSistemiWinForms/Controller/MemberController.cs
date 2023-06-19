using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemiWinForms.SystemData;
using KutuphaneSistemiWinForms.SystemData.Member;
using Microsoft.IdentityModel.Tokens;

namespace KutuphaneSistemiWinForms.Controller
{
    public class MemberController : BaseController
    {
        static public NormalMember currentMember;

        public void createMember(NormalMember member)
        {
            databaseManager.createData(member);
        }

        public void updateMember(NormalMember member)
        {
            databaseManager.updateData(member);
        }


        public bool loginMember(string nickName, string password)
        {
            List<string> variableNames = new List<string> { "memberNick", "memberPassword" };
            List<string> searchValues = new List<string> { nickName, password };

            List<NormalMember> loginCredits = databaseManager.listData<NormalMember>(variableNames, searchValues).Cast<NormalMember>().ToList();

            if (loginCredits.IsNullOrEmpty())
            {
                return false;
            }
            int i = loginCredits[0].MemberID;

            currentMember = loginCredits[0]; //Bu noktada currentMember ataması yapılır, viewde atama yapılmaz \ Corpyr.
            return true;
        }

        public void generateNickAndPassword()
        {

        }

    }
}
