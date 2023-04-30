using HW_4.Data.Models;

namespace HW_4.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ASPDeveloper> developers { get; set; }

        public int amount { get; set; }
    }
}