using System;
namespace DeliveryProtocol.Entities.Response
{
    public class BaseResponseModel
    {
        public bool IsSuccess { get; set; }
        public string[]? Errors { get; set; }
    }
}

