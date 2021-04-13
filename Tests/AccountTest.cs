using SportsMate.Business_Layer.Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class AccountTest
    {

        private readonly string _validFirstName = "Michael";
        private readonly string _validLastName = "Kagnew";

        public AccountTest()
        {
        }

        [Theory]
        [MemberData(nameof(BirthdayGreaterData))]
        public void DenyBirthdayGreaterThanCurrent( string dateGreater)
        {
            Assert.Throws<ArgumentException>(() => new AdminAccount(_validFirstName, _validLastName, dateGreater));
        }

        public static IEnumerable<object[]> BirthdayGreaterData()
        {
            yield return new object[] { DateTime.Now.AddDays(10).ToString() };
            yield return new object[] { DateTime.Now.AddDays(100).ToString() };
            yield return new object[] { DateTime.Now.AddDays(1).ToString() };

        }


        [Theory]
        [MemberData(nameof(BirthdayDenyAgeData))]
        public void DenyCertainAge(string date)
        {
            Assert.Throws<ArgumentException>(() => new AdminAccount(_validFirstName, _validLastName, date));

        }
        public static IEnumerable<object[]> BirthdayDenyAgeData()
        {
            yield return new object[] { DateTime.Now.AddDays(-10).ToString() };
            yield return new object[] { DateTime.Now.AddDays(-100).ToString() };
            yield return new object[] { DateTime.Now.AddDays(-1).ToString() };

        }

        [Theory]
        [MemberData(nameof(AcceptBirthdayData))]
        public void AcceptBirthday(DateTime birthdate)
        {
            Assert.True(Account.ValidateAgeofAccount(birthdate));
        }

        public static IEnumerable<object[]> AcceptBirthdayData()
        {
            yield return new object[] { new DateTime(2001, 03, 30) };
            yield return new object[] { new DateTime(DateTime.Now.Year -  Account.MIN_AGE, 01, 01) };
            yield return new object[] { new DateTime(1999, 03, 25) };

        }
    }
}
