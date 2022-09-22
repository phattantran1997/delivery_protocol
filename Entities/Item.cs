using System;
using System.ComponentModel.DataAnnotations;
using DeliveryProtocol.Entities.Request;

namespace DeliveryProtocol.Entities
{
    public class Item : BaseEntity
    {
        [Required]
        public string? OrderId { get; set; }
        public string storageInfo { get; set; } = string.Empty;
        public string jobno { get; set; } = string.Empty;
        public string itemno { get; set; } = string.Empty;
        public string handle { get; set; } = string.Empty;
        public string insulationarea { get; set; } = string.Empty;
        public string metalarea { get; set; } = string.Empty;
        public string widthDim { get; set; } = string.Empty;
        public string depthDim { get; set; } = string.Empty;
        public string lengthangle { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;

        public Item(ItemRequest itemRequest)
        {
            this.storageInfo = itemRequest.storageInfo;
            this.jobno = itemRequest.jobno;
            this.itemno = itemRequest.itemno;
            this.handle = itemRequest.handle;
            this.insulationarea =itemRequest.insulationarea;
            this.metalarea = itemRequest.metalarea;
            this.widthDim = itemRequest.widthDim;
            this.depthDim = itemRequest.depthDim;
            this.lengthangle = itemRequest.lengthangle;
            this.description = itemRequest.description;
        }
    }
}

