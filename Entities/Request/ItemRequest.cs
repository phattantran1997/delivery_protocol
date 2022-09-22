using System;
using System.ComponentModel.DataAnnotations;

namespace DeliveryProtocol.Entities.Request
{
    public class ItemRequest
    {
        [Required]
        public string storageInfo { get; set; } = string.Empty;
        [Required]
        public string jobno { get; set; } = string.Empty;
        [Required]
        public string itemno { get; set; } = string.Empty;
        [Required]
        public string handle { get; set; } = string.Empty;
        public string insulationarea { get; set; } = string.Empty;
        public string metalarea { get; set; } = string.Empty;
        public string widthDim { get; set; } = string.Empty;
        public string depthDim { get; set; } = string.Empty;
        public string lengthangle { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;

    }
}

