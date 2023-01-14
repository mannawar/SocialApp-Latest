namespace API.Extensions
{
    public static class DateTimeExtension
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;

            var age = today.Year - dob.Year;

            if(dob > today.AddYears(-age)) age--;

            return age;
        }
    }
}