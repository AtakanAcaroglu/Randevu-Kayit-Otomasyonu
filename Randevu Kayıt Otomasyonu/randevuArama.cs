using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_şeysi
{
    internal class randevuArama
    {
        public string nameSurname;
        public bool detailedSearch;
        public string date;
        public string phone;

        public randevuArama(string nameSurname, bool detailedSearch, string date, string phone)
        {
            this.nameSurname = nameSurname;
            this.detailedSearch = detailedSearch;
            this.date = date;
            this.phone = phone;
        }

        public string getName()
        {
            return nameSurname;
        }

        public bool checkDetailedSearch()
        {
            return detailedSearch;
        }

        public string getDate()
        {
            return date;
        }

        public string getPhone()
        {
            return phone;
        }
    }
}
