using FociWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FociWebApp.Pages
{
    public class BajnoksagAllasaModel : PageModel
    {
        private readonly FociDBcontext _context;

        public BajnoksagAllasaModel(FociDBcontext context)
        {
            _context = context;
        }

        public List<Meccs> meccsek;
        public List<CsapatEredmenyei> csapatokEredemenyei;


        
        public void OnGet()
        {
            meccsek = _context.Meccsek.ToList();
            csapatokEredemenyei = new List<CsapatEredmenyei>();
            foreach (var item in meccsek.Select(x=>x.Hazaicsapat).Distinct())
            {
                CsapatEredmenyei ujcsapat = new CsapatEredmenyei();
                ujcsapat.CsapatNev = item;
                csapatokEredemenyei.Add(ujcsapat);

            }

            foreach (var item in csapatokEredemenyei)
            {
                item.GyozelemekSzama = meccsek.Where(x => x.GyoztesCsapatNeve() == item.CsapatNev).Count();
                item.GyozelemekSzama = meccsek.Where(x => x.Hazaicsapat == item.CsapatNev || x.Hazaicsapat == item.CsapatNev && x.GyoztesCsapatNeve() != item.CsapatNev && x.GyoztesCsapatNeve() != "").Count();
            }

            
        }
    }
}
