using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using technicalassessment.Models;

namespace technicalassessment.Controllers
{
    public class MyOrderController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine path safely
            string filePath = Path.Combine(currentDirectory, "includes", "orders.json");

            // Read the file content asynchronously
            string json = await System.IO.File.ReadAllTextAsync(filePath);

            // Deserialize the JSON string into a list of Orders objects
            var orders = JsonConvert.DeserializeObject<List<Orders>>(json);

            // Pass the list of Orders to the view
            return View(orders);
        }
    }
}
