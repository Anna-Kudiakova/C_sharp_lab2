using System;

namespace CSharp.Lab02.Models
{
    class Person
    {

        private string _name;
        private string _surname;
        private string _mail;
        private DateTime? _birthDate;

        public Person(string name, string surname, string email, DateTime? birthdate = null)
        {
            _name = name;
            _surname = surname;
            _mail = email;
            if (birthdate != null)
                Birthdate = birthdate.Value;
        }

        public Person(string name = " ", string surname = " ", string email = " ")
        {
            _name = name;
            _surname = surname;
            _mail = email;
        }

        public Person(string name, string surname, DateTime? birthdate)
        {
            _name = name;
            _surname = surname;
            _birthDate = birthdate;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public DateTime? Birthdate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public int Age { get { return DefineAge(); } }
        public string SunSign { get { return DefineSunSign(); } }
        public string ChineseSign { get { return DefineChineseSign(); } }
        public bool IsAduld { get { return Age >= 18; } }
        public bool HaveBirthday { get { return DateTime.Now.DayOfYear == _birthDate.Value.DayOfYear; } }

        private int DefineAge()
        {
            int age = DateTime.Now.Year - _birthDate.Value.Year;
            if (DateTime.Now.DayOfYear < _birthDate.Value.DayOfYear)
            {
                age -= 1;
            }
            return age;

        }

        private string DefineSunSign()
        {
            string zodiac = "";
            int month = _birthDate.Value.Month;
            int day = _birthDate.Value.Day;
            if ((day >= 21 && month == 3) || (day <= 19 && month == 4))
                zodiac = "Aries";
            if ((day >= 23 && month == 9) || (day <= 23 && month == 10))
                zodiac = "Libra";
            if ((day >= 20 && month == 4) || (day <= 20 && month == 5))
                zodiac = "Taurus";
            if ((day >= 24 && month == 10) || (day <= 21 && month == 11))
                zodiac = "Scorpio";
            if ((day >= 21 && month == 5) || (day <= 21 && month == 6))
                zodiac = "Gemini";
            if ((day >= 22 && month == 11) || (day <= 21 && month == 12))
                zodiac = "Sagittarius";
            if ((day >= 22 && month == 6) || (day <= 22 && month == 7))
                zodiac = "Cancer";
            if ((day >= 22 && month == 12) || (day <= 19 && month == 1))
                zodiac = "Capricorn";
            if ((day >= 23 && month == 7) || (day <= 22 && month == 8))
                zodiac = "Leo";
            if ((day >= 20 && month == 1) || (day <= 18 && month == 2))
                zodiac = "Aquarius";
            if ((day >= 24 && month == 8) || (day <= 23 && month == 9))
                zodiac = "Virgo";
            if ((day >= 19 && month == 2) || (day <= 20 && month == 3))
                zodiac = "Pisces";
            return zodiac;
        }

        private string DefineChineseSign()
        {
            int zodiac = (_birthDate.Value.Year - 4) % 12;
            string[] animals = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
            string chineseZodiac = animals[zodiac];
            return chineseZodiac;
        }

    }
}
