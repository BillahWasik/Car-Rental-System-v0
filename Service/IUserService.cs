namespace Car_Rental_System.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}