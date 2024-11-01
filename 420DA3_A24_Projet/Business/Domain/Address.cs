using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;

    public class Address
    {

        public const string RESIDENTIAL = "Residential";
        public const string COMMERCIAL = "Commercial";
        private const int RECIPIENT_MAX_LENGTH = 100;
        private const int CIVIC_NUMBER_MAX_LENGTH = 10;
        private const int STREET_MAX_LENGTH = 100;
        public const int CITY_MAX_LENGTH = 50;
        private const int PROVINCE_MAX_LENGTH = 50;
        private const int COUNTRY_MAX_LENGTH = 50;
        private const int POSTAL_CODE_MAX_LENGTH = 10;


        private int id;
        private string addressType = null!;
        private string recipient = null!;
        private string civicNumber = null!;
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

        public string AddressType
        {
            get { return this.addressType; }
            set
            {
                if (!ValidAddressType(value))
                {
                    throw new ArgumentException($"Address type must be either {RESIDENTIAL} or {COMMERCIAL}");
                }
                this.addressType = value;
            }
        }

        public string Recipient
        {
            get { return this.recipient; }
            set
            {
                if (!ValidateRecipient(value))
                {
                    throw new ArgumentException($"Recipient must not be empty and must be {RECIPIENT_MAX_LENGTH} characters or less.");
                }
                this.recipient = value;
            }
        }

        public string CivicNumber
        {
            get { return this.civicNumber; }
            set
            {
                if (!ValidateCivicNumber(value))
                {
                    throw new ArgumentException($"Recipient must not be empty and must be {CIVIC_NUMBER_MAX_LENGTH} characters or less.");
                }
                this.civicNumber = value;
            }
        }

        public string Street
        {
            get { return this.street; }
            set
            {
                if (!ValidateStreet(value))
                {
                    throw new ArgumentException($"Recipient must not be empty and must be {STREET_MAX_LENGTH} characters or less.");
                }
                this.street = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set
            {
                if (!ValidateCity(value))
                {
                    throw new ArgumentException($"Recipient must not be empty and must be {CITY_MAX_LENGTH} characters or less.");
                }
                this.city = value;
            }
        }

    public string Province
    {
        get { return this.province; }
        set
        {
            if (!ValidateProvince(value))
            {
                throw new ArgumentException($"Recipient must not be empty and must be {PROVINCE_MAX_LENGTH} characters or less.");
            }
            this.province = value;
        }
    }

    public string Country
    {
        get { return this.country; }
        set
        {
            if (!ValidateCountry(value))
            {
                throw new ArgumentException($"Recipient must not be empty and must be {CITY_MAX_LENGTH} characters or less.");
            }
            this.country = value;
        }
    }

    public string PostalCode
    {
        get { return this.postalCode; }
        set
        {
            if (!ValidatePostalCode(value))
            {
                throw new ArgumentException($"Recipient must not be empty and must follow this format : A1A-1A1");
            }
            this.postalCode = value;
        }
    }

    public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;



        public Address(string addressType, string recipient, string civicNumber, string street, string city, string province, string country, string postalCode) 
        {
            this.addressType = addressType;
            this.recipient = recipient;
            this.civicNumber = civicNumber;
            this.street = street;
            this.city = city;
            this.province = province;
            this.country = country;
            this.postalCode = postalCode;
        }


        protected Address(int id, 
            string addressType, 
            string recipient, 
            string civicNumber, 
            string street, 
            string city, 
            string province, 
            string country, 
            string postalCode,
            DateTime dateCreated,
            DateTime? dateModified,
            DateTime? dateDeleted,
            byte[] rowVersion)
            : this (addressType, recipient, civicNumber, street, city, province, country, postalCode)
        {
            this.Id = id;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
        } 


        public static bool ValidateId(int id)
        {
            return id >= 0;
        }
        public static bool ValidAddressType(string addressType)
        {

            return addressType == RESIDENTIAL || addressType == COMMERCIAL;
        }
        public static bool ValidateRecipient(string recipient)
        {
            return recipient.Length <= RECIPIENT_MAX_LENGTH;
        }
        public static bool ValidateCivicNumber(string civicNumber)
        {
            return civicNumber.Length <= CIVIC_NUMBER_MAX_LENGTH && Regex.IsMatch(civicNumber, @"^[a-zA-Z0-9-\s]+$");
        }

        // validateStreet(string): bool

        public static bool ValidateStreet(string street)
        {
            return street.Length <= STREET_MAX_LENGTH;
        }

        public static bool ValidateCity(string city)
        {
            return city.Length <= CITY_MAX_LENGTH;
        }
        public static bool ValidateProvince(string province)
        {
            return province.Length <= PROVINCE_MAX_LENGTH;
        }

        public static bool ValidateCountry(string country)
        {
            return country.Length <= COUNTRY_MAX_LENGTH;
        }

    public static bool ValidatePostalCode(string postalCode)
        {
            // validation du code postal canadien 
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";

            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            return reg.IsMatch(postalCode);
        }

        
        // méthode à compléter
        public void FormatAddress(
        StringBuilder formattedAddress,
        string recipient,
        string civicNumber,
        string street,
        string city,
        string province,
        string postalCode,
        string country)
        {
        formattedAddress.Clear();
        formattedAddress.AppendLine($"{recipient}");
        formattedAddress.AppendLine($"{civicNumber} {street}");
        formattedAddress.AppendLine($"{city}, {province} {postalCode}");
        formattedAddress.Append($"{country}");
        }

}
