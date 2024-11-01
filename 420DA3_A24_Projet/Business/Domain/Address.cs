using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;

    public class Address
    {
        //backing fields
        private int id;
        private string addressType = null!;
        private string recipient = null!;
        private string street = null!;
        private string city = null!;
        private string province = null!;
        private string country = null!;
        private string postalCode = null!;


        public int Id
        {
            get { return this.id; }
            set
            {
                if (!ValidateId(value))
                {
                    throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
                }
                this.id = value;
            }
        }

        

    public string AddressType { get; set; }
    public string Recipient { get; set; }
    public string CivicNumber { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    public static bool ValidateId(int id)
    {
        return id >= 0;
    }
}
