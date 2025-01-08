namespace Assignment3_Q1EmployeeLib
{
    public class Date
    {

        private int day;
        private int month;
        private int year;

        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {

            return month;
        }
        public int getYear()
        {
            return year;
        }

        public void setDay(int day)
        {
            this.day = day;
        }
        public void setMonth(int month)
        {
            this.month = month;
        }
        public void setYear()
        {
            this.year = 0;
        }
        public Date(int day)
        {
            this.day = day;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter day: ");
            day=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            month =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year =Convert.ToInt32(Console.ReadLine());


           
        }

        public void PrintDate()
        {
            Console.WriteLine(getDay()+"/"+getMonth()+"/"+getYear());
        }


        public bool IsValid()
        {

            if (getMonth() < 1 || getMonth() > 12 || getDay() < 1 || getDay() > 31 || getYear() < 1)
                return false;

            if (getMonth() == 2)
            {
                bool isLeapYear = (getYear() % 4 == 0 && getYear() % 100 != 0) || (getYear() % 400 == 0);
                return getDay() <= (isLeapYear ? 29 : 28);
            }

            if (getMonth() == 4 || getMonth() == 6 || getMonth() == 9 || getMonth() == 11)
                return getDay() <= 30;

            return true;
        }


        public  override string ToString()
        {
            return (getDay() + "/"+getMonth() +"/"+getYear());

        }

        public static int DifferenceInYears(Date d1, Date d2)
        {
            return Math.Abs(d1.year - d2.year);
        }
        public static int operator -(Date d1, Date d2)
        {
            return DifferenceInYears(d1, d2);
        }

    }
}
