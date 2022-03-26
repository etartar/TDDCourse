namespace TDDCourse.Calculator
{
    public class SalaryCalculator
    {
        const int _hoursInYear = 2340;

        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * _hoursInYear;

        public decimal GetHourlyWage(decimal annualSalary) => annualSalary / _hoursInYear;
    }
}
