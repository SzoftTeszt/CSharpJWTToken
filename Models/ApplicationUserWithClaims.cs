namespace JWTTokenAPI.Models
{
    public class ApplicationUserWithClaims: ApplicationUser
    {
        public IList<string>? Claims { get; set; }
    }
}
