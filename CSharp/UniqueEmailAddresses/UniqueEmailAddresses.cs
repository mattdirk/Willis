using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueEmailAddresses
{
    public static class UniqueEmailAddresses
    {
        public static int NumberOfUniqueEmailAddresses(string[] emails)
        {
            List<string> cleanEmails = new List<string>();
            try
            {
                foreach(string email in emails)
                {
                    string[] parts = email.Split("@");
                    if(parts.Length > 2)
                    {
                        continue;
                    }
                    string clean = parts[0].Replace(".", "");
                    int firstIndex = clean.IndexOf("+");
                    if(firstIndex > -1)
                    {
                        clean = clean.Substring(0, firstIndex);
                    }
                    cleanEmails.Add(clean + "@" + parts[1]);
                }
                List<string> distinct = new List<string>(cleanEmails.Distinct());
                return distinct.Count;
            }catch(Exception ex)
            {

            }
            return 0;
        }
    }
}