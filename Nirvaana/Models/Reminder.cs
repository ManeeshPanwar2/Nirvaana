using System;
using System.Reflection.Metadata;

namespace Nirvaana.Models
{
    public class Reminder
    {
        private Document Documentcs { get; set; }

        Reminder()
        {
            Documentcs = new Document();
        }
        public void SendReminderToUserAboutDocumentExpiration(int documentId)
        {
            //logic for check Expireation and send mail to user
            throw new NotImplementedException();
        }
    }
}
