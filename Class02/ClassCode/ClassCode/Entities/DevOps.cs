using ClassCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode.Entities
{
    public class DevOps : Human, IDeveloper, IDevOps
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }
        public DevOps(string fullName, int age, long phone, bool AWSCertified, bool AzureCertified) : base(fullName, age, phone)
        {
            this.AWSCertified = AWSCertified;
            this.AzureCertified = AzureCertified;
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int>() { 200,202,204};
            if (okStatuses.Contains(status))
            {
                return true;
            }
            return false;
            
        }

        public void Code()
        {
            Console.WriteLine("The dev ops guy is coding, but not like dev one");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age} years) - AWS Certified: {(AWSCertified ? "Yes" : "NO")} Azure Certified: {(AzureCertified ? "Yes" : "NO")}";
        }
    }
}