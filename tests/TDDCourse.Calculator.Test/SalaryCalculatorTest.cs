using TDDCourse.Calculator;
using Xunit;

namespace TDDCourse.Tests
{
    public class SalaryCalculatorTest
    {
        [Fact]
        public void Test1()
        {
            // Haz�rlama A�amas� - Arrange
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            // Hareket A�amas� - Act
            decimal annualSalary = salaryCalculator.GetAnnualSalary(40);

            // �ddia Etme A�amas� - Assert
            Assert.Equal(93600, annualSalary);
        }

        [Fact]
        public void Test2()
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            decimal hourlyWage = salaryCalculator.GetHourlyWage(93600);

            Assert.Equal(40, hourlyWage);
        }
    }
}
