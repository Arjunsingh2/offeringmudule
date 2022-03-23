using IPTreatmentOffering.Model;
using IPTreatmentOffering.Provider;
using System.Collections.Generic;

namespace IPTreatmentOffering.Repository
{
    public class SpecialistRepo:ISpecialistRepo
    {
        public SpecialistRepo()
        { }
        public void Addspecialist(TreatmentContext cont)
        {
            List<Specialist> list = new List<Specialist>
            {
                new Specialist("Logan","Orthopedic","Senior",1,8448677710),
                new Specialist("Owen","Orthopedic","Senior",1,9678574143),
                new Specialist("Wyatt","Orthopedic","Senior",1,9678574798),
                new Specialist("Jackson","Orthopedic","Senior",1,4545455643),
                new Specialist("Matthew","Orthopedi","Senior",1,8009678574),
                new Specialist("Owen","Skin","Senior",1,9678534098),
                new Specialist("Luke","Skin","Senior",1,9678574879),
                new Specialist("Logan","Skin","Senior",1,9678574013),
                new Specialist("Sebastian","Skin","Senior",1,6909678574),
                new Specialist("Samuel","Skin","Senior",1,9064734345),
                new Specialist("Levi","Gastro","Senior",1,825576710),
                new Specialist("Thomas","Gastro","Senior",1,9834467567),
                new Specialist("Charels","Gastro","Senior",1,6864667567),
                new Specialist("Christopher","Gastro","Senior",1,6834667567),
                new Specialist("Jaxon","Gastro","Senior",1,8014667567),
                new Specialist("Thomas","Dental","Senior",1,9834667517),
                new Specialist("Charels","Dental","Senior",1,6834667067),
                new Specialist("Christopher","Dental","Senior",1,6034667567),
                new Specialist("Jaxon","Dental","Senior",1,8034767567),
                new Specialist("Sebastian","Dental","Senior",1,9575678568),
                new Specialist("Mateo","Respira","Senior",1,345345098),
                 new Specialist("Joseph","Respira","Senior",1,7096745402),
                new Specialist("David","Respira","Senior",1,9284035345),
                new Specialist("Wyatt","Respira","Senior",1,9235046576),
                new Specialist("Matthew","Respira","Senior",1,9336670567),
                new Specialist("Jack","Urology","Senior",1,9453677786),
                 new Specialist("Owen","Urology","Senior",1,7806745402),
                new Specialist("David","Urology","Senior",1,9234035345),
                new Specialist("Wyatt","Urology","Senior",1,9235376576),
                new Specialist("Theodore","Urology","Senior",1,9242345305),
                new Specialist("Matthew","Neuro","Senior",1,6346670567),
                new Specialist("Owen","Neuro","Senior",1,9678574907),
                new Specialist("Theodore","Neuro","Senior",1,9242045325),
                new Specialist("Aiden","Neuro","Senior",1,9856745602),
                new Specialist("Samuel","Neuro","Senior",1,9054735345),
                new Specialist("Theodore","Orthopedic","Junior",1,9242345325),
                new Specialist("Aiden","Orthopedic","Junior",1,7856745602),
                new Specialist("Samuel","Orthopedic","Junior",1,9054735345),
                new Specialist("Joseph","Orthopedic","Junior",1,7896745402),
                new Specialist("David","Orthopedic","Junior",1,9234235345),
                new Specialist("Wyatt","Skin","Junior",1,9235346576),
                new Specialist("Matthew","Skin","Junior",1,9346670567),
                new Specialist("Luke","Skin","Junior",1,8034667567),
                new Specialist("Asher","Skin","Junior",1,7034667567),
                new Specialist("Carter","Skin","Junior",1,6334667567),
                new Specialist("Julian","Gastero","Junior",1,9834667567),
                new Specialist("Grayson","Gastero","Junior",1,7834667567),
                new Specialist("Leo","Gastero","Junior",1,7534667567),
                new Specialist("Jayden","Gastero","Junior",1,6234667567),
                new Specialist("Averill","Gastero","Junior",1,6134667567),
                new Specialist("Liam","","Dental",1,9034667567),
                new Specialist("Alfred","Dental","Junior",1,6034667567),
                new Specialist("Anthony","Dental","Junior",1,8934667567),
                new Specialist("Amberjill","Dental","Junior",1,9134667567),
                new Specialist("Afton","Dental","Junior",1,9534667567),
                new Specialist("Alife","Repira","Junior",1,7634667567),
                new Specialist("Joshnu","Repira","Junior",1,9834667567),
                new Specialist("Lucy","Repira","Junior",1,6834667567),
                new Specialist("Ryan","Repira","Junior",1,6934667567),
                new Specialist("Sophine","Repira","Junior",1,8034667567),
                new Specialist("Lisa","Urology","Junior",1,9346670967),
                new Specialist("Lily","Urology","Junior",1,8004667567),
                new Specialist("Emily","Urology","Junior",1,7024667567),
                new Specialist("Mia","Urology","Junior",1,6334067567),
                new Specialist("Oliver","Urology","Junior",1,9834067567),
                new Specialist("Oscar","Neuro","Junior",1,7804667567),
                new Specialist("Jack","Neuro","Junior",1,7534669567),
                new Specialist("George","Neuro","Junior",1,6230667567),
                new Specialist("Noah","Neuro","Junior",1,6144667567),
                new Specialist("Harry","Neuro","Junior",1,9034767567),
            };
            foreach(var item in list)
            {
                cont.Specialists.Add(item);
            }
        }
    }
}
