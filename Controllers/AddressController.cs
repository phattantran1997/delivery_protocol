using System;
using DeliveryProtocol.Entities;
using DeliveryProtocol.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryProtocol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {

        public readonly IAddressService addressService;
        public AddressController(IAddressService addressService)
        {
            this.addressService = addressService;
        }


        [HttpGet("find/{address}")]
        public async Task<IEnumerable<Address>> FindAddress(string address) {
            var vm =  await addressService.FindAddress(address);
            return vm;

        }

    }
}

