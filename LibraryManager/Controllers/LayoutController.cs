using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace LibraryManager
{
    public class LayoutController : Controller
    {
        public void SetLanguage(string lang)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
        }
    }
}
