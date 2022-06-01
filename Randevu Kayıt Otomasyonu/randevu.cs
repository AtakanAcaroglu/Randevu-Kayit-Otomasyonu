using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_şeysi
{
    internal class randevu
    {
        public string nameSurname;
        public string job;
        public string gender;
        public string phone;
        public string complaint;
        public string date;
        public string notes;
        public string medicines;
        public object prefferedDoctor;
        
        public randevu(string nameSurname, string job, string gender, string phone, string compaint, string date, string notes, string medicines, object prefferedDoctor)
        {
            this.nameSurname = nameSurname;
            this.job = job;
            this.gender = gender;
            this.phone = phone;
            this.complaint = compaint;
            this.date = date;
            this.notes = notes;
            this.medicines = medicines;
            this.prefferedDoctor = prefferedDoctor;
        }

    }
}
