using System;
using DeliveryProtocol.Entities.Request;

namespace DeliveryProtocol.Entities
{
    public class Address : BaseEntity
    {
       
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string AddressDetail { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public bool IsDefault { get; set; } = false;
        public long planningTime{ get; set; } = 0;
        public Address(AddressRequest request)
        {
            Name = request.Name;
            Phone = request.Phone;
            Email = request.Email;
            CompanyName = request.CompanyName;
            AddressDetail = request.AddressDetail;
            PostalCode = request.PostalCode;
            City = request.City;
            State = request.State;
            Country = request.Country;
            Notes = request.Notes;
            IsDefault = request.IsDefault;
        }

        public Address()
        {
        }
    }
}

