using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankService
{
    [DataContract]
    public class ServerUser
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Telephone { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public double Money { get; set; }

        [NotMapped]
        public OperationContext operationContext { get; set; }
    }
}

