using System;

namespace Serializer
{
    [Serializable]
    public class Staff
    {
        private int Id { get; set; }
        public string Departure { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Salary { get; set; }
        public double BonusRate { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public Address Address { get; set; }

        public Staff() : this(0, "", "", 0, 0, 0.0, "", "", new Address("", "", "", "", 0, "")) { }

        public Staff(int id, string departure, string name, int grade, int salary, double bonusRate, string homePhone, string workPhone, Address address)
        {
            Id = id;
            Departure = departure;
            Name = name;
            Grade = grade;
            Salary = salary;
            BonusRate = bonusRate;
            HomePhone = homePhone;
            WorkPhone = workPhone;
            Address = address;
        }

        public override string ToString()
        {
            return Name + ": " + Salary + " (" + BonusRate + ")";
        }
    }
}