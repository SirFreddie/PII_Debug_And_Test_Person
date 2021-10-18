using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string date)
        {
            this.Name = name;
            this.ID = id;
            this.Date = date;
        }

        private string name;

        private string id;

        private string date;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }

            set
            {
                if(string.IsNullOrEmpty(this.date) || (this.date.Length < 10))
                {
                    this.date = "01/01/1990";
                }
                else
                {
                    this.date = value;
                }     
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
