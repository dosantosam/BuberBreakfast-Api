using BuberBreakfest.Models;

namespace BuberBreakfest.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        Breakfast GetBreakfast(Guid id);
    }
}