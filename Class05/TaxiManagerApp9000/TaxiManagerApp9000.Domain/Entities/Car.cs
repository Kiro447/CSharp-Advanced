namespace TaxiManagerApp9000.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public DateTime LicensePlateExpiryDate { get; set; }
        public List<Driver> AsignedDrivers { get; set; } = new List<Driver>();

        public Car(string model, string licensePlate, DateTime licensePlateExpiryDate, List<Driver> asignedDrivers)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = licensePlateExpiryDate;
            AsignedDrivers = asignedDrivers;
        }

        public override string Print()
        {
            int counter = 1;
            string drivers = string.Empty;
            foreach (Driver driver in AsignedDrivers)
            {
                drivers += counter + ".)" + driver.FirstName + " " + driver.LastName + "\n";
                counter++;
            }
            return $"Car {Model} with plates {LicensePlate} that expiry on {LicensePlateExpiryDate.Month + LicensePlateExpiryDate.Year}" + $"is driven by:\n {drivers}";
        }
    }
}
