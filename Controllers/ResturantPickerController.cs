using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC_5EightToTen___Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC_5EightToTen___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResturantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _resturantPickerServices;

        public ResturantPickerController(RestaurantPickerServices resturantPickerServices)
        {
            _resturantPickerServices = resturantPickerServices;
        }

        [HttpGet]
        [Route("ChooseFood Asian, Mexican, Fast Food")]
        public string RestaurantPicker(string ChooseFood)
        {
            return _resturantPickerServices.PickRestaurant(ChooseFood);
        }

    }
}