using System.Runtime.Serialization;

namespace BankService
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public string TelephoneFrom { get; set; }

        [DataMember]
        public double Money { get; set; }
    }
}

