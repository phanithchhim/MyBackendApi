using Microsoft.AspNetCore.Mvc;
using MyBackendApi.Models;
using MyBackendApi.Services.Interfaces;
using System.Collections.Generic;

namespace MyBackendApi.Controllers.Api.Mobile
{
    [Route("api/mobile/[controller]")]
    [ApiController]
    public class MobileShopsController : ControllerBase
    {
        private readonly IShopService _shopService;

        public MobileShopsController(IShopService shopService)
        {
            _shopService = shopService;
        }

        // GET: api/mobile/shops
        [HttpGet]
        public ActionResult<IEnumerable<Shop>> Get()
        {
            var shops = _shopService.GetAllShops();
            return Ok(shops);
        }

        // GET: api/mobile/shops/5
        [HttpGet("{id}")]
        public ActionResult<Shop> Get(int id)
        {
            var shop = _shopService.GetShopById(id);

            if (shop == null)
            {
                return NotFound();
            }

            return Ok(shop);
        }

        // POST: api/mobile/shops
        [HttpPost]
        public ActionResult<Shop> Post([FromBody] Shop shop)
        {
            _shopService.AddShop(shop);
            return CreatedAtAction(nameof(Get), new { id = shop.Id }, shop);
        }

        // PUT: api/mobile/shops/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Shop shop)
        {
            if (id != shop.Id)
            {
                return BadRequest();
            }

            _shopService.UpdateShop(shop);
            return NoContent();
        }

        // DELETE: api/mobile/shops/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingShop = _shopService.GetShopById(id);

            if (existingShop == null)
            {
                return NotFound();
            }

            _shopService.DeleteShop(id);
            return NoContent();
        }
    }
}
