using System;
using System.Collections.Generic;

namespace Mocking
{
    
    public class MailBox 
    {
        List<Mail> maillist;
        public MailBox()
        {
            maillist = new List<Mail>();
        }

        private int num;
        public int NumReceivedMessages {
            get { return maillist.Count; }
            set { num = value; }
        }

       
        public void Add(Mail o)
        {
            maillist.Add(o);
            
            
            
        }
        
        public string GetLatestMessageText()
        {
            string result = "";
            foreach (Mail amail in maillist)
            {
                result += amail.Content;
            }
            return result;
        }
    }
}