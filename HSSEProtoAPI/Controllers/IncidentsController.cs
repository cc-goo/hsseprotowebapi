using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSSEProtoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        // GET: api/Incidents
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Incidents/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Incidents
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Incidents/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/Incidents/severity
        [HttpGet("severity")]
        public IEnumerable<Model.Severity> GetSeverity(int id)
        {
            var severityList = new List<Model.Severity>();
            severityList.Add(new Model.Severity
            {
                id = "1",
                name = "High"
            });
            severityList.Add(new Model.Severity
            {
                id = "2",
                name = "Medium"
            });
            severityList.Add(new Model.Severity
            {
                id = "3",
                name = "Low"
            });

            return severityList;
        }

        // GET: api/Incidents/severity
        [HttpGet("location")]
        public IEnumerable<Model.Location> GetIncidentLocations(int id)
        {
            var locationList = new List<Model.Location>();
            locationList.Add(new Model.Location
            {
                id = "1",
                name = "Forecourt"
            });
            locationList.Add(new Model.Location
            {
                id = "2",
                name = "Backoffice"
            });
            locationList.Add(new Model.Location
            {
                id = "3",
                name = "Carwash"
            });
            locationList.Add(new Model.Location
            {
                id = "4",
                name = "Cafe"
            });

            return locationList;
        }
    }
}
