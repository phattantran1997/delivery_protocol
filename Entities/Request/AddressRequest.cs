using System;
using System.ComponentModel.DataAnnotations;
using DeliveryProtocol.Ultils;

namespace DeliveryProtocol.Entities.Request
{

    public class AddressRequest
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        public string AddressDetail { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public bool IsDefault { get; set; } = false;
    }
}

