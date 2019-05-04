namespace Extensions.DateTime
{
    public static class BusinessDays
    {
        public static System.DateTime AddBusinessDays(this System.DateTime date, double businessDays)
        {
            while (businessDays > 0)
            {
                if (businessDays >= 1)
                {
                    if (date.DayOfWeek == System.DayOfWeek.Saturday)
                    {
                        date = date.AddDays(2);
                    }
                    else
                    {
                        date = date.AddDays(1);
                        businessDays -= 1;
                    }
                }
                else
                {
                    date = date.AddDays(businessDays);
                    businessDays -= 1;
                }
            }
            return date;
        }
    }
}