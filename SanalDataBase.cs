using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SanalDataBase
    {
        public static List<Kullanıcı> KullanıcıDatabase = new List<Kullanıcı>();
        static SanalDataBase()
        {
           KullanıcıDatabase.Add(new Kullanıcı()
           {
               id="1",
               İsim="Kubilay",
               şifre="123",
               soyisim="Topaktaş",
               kullanıcıAdı="Kubilaay_tpktss",
               Açıklama="Kubilay Topaktaşın profili"

            });
            KullanıcıDatabase.Add(new Kullanıcı()
            {
                id = "2",
                İsim = "Keramettin",
                şifre="1234",
                soyisim = "Topaktaş",
                kullanıcıAdı = "Keramettin_tpktss",
                Açıklama = "Keramettin Topaktaşın profili"

            });

        }

    }
}
