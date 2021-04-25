using Microsoft.AspNetCore.Mvc;
using SiparisTakip.Bll.Managers;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Model;
using SiparisTakip.Interface.IServices;

namespace SiparisTakip.MVCWebUI.Contollers
{
    public class KullaniciController : Controller
    {
        IKullaniciService kullaniciService =
            new KullaniciManager(new EfKullaniciRepository());

        public IActionResult KullaniciGiris()
        {
            return View();
        }

        public JsonResult KullaniciGiris(Kullanici kullanici)
        {
            try
            {
              var user=  kullaniciService.GirisYap(kullanici.KullaniciAdi, kullanici.Parola);
                if (user!=null)
                {
                    //Session["kullaniciId"] = kullanici.KullaniciID;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
