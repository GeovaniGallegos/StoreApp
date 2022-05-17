using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.ServicesInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {

        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            this._storeService = storeService;
        }

        // GET: api/<StoreController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _storeService.GetAllStores());
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok(await _storeService.GetStoreById(id));
        }

        // POST api/<StoreController>
        [HttpPost]
        public ActionResult Post([FromBody] Store store)
        {
            _storeService.AddStore(store);
            return Ok(store);
        }

        // PUT api/<StoreController>/5
        [HttpPut]
        public ActionResult Put([FromBody] Store store)
        {
            _storeService.UpdateStore(store);
            return Ok(store);
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _storeService.DeleteStore(id);
            return Ok();
        }
    }
}
