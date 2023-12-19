using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.UsersClasses
{
    public class InfoEmailSending
    {  
         public InfoEmailSending(string satpClientAdress,
         StringPair emailAdressFrom,
         string emailPassword,
         StringPair emailAddresTo,
         string subject,
         string body)
        {
            SmtpCLientAdress = String.IsNullOrWhiteSpace(satpClientAdress) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") : satpClientAdress;

            EmailAdressFrom = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressFrom));

            EmailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") : emailPassword;

            EmailAdressTo = emailAddresTo ?? throw new ArgumentNullException(nameof(emailAddresTo));
            
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            
            Body = body ?? throw new ArgumentNullException(nameof(body));
        }

        public string SmtpCLientAdress { get; set; }
        public StringPair EmailAdressFrom { get; set; }
        public string EmailPassword { get; set; }
        public StringPair EmailAdressTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


        public class StringPair
        {
            public StringPair(string emailAdress, string name)
            {
                EmailAdress = String.IsNullOrWhiteSpace(emailAdress) ? 
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") : emailAdress; 

                Name = String.IsNullOrWhiteSpace(name) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") : name;
            }

            public string EmailAdress { get; set;}
            public string Name { get; set;}
        }
    }
}
