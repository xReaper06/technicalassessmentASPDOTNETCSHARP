using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using technicalassessment.Models;

namespace technicalassessment.Controllers
{
    public class StoreController : Controller
    {
        // GET: StoreController
        public async Task<ActionResult> Index()
        {
            // Get the current directory
            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine path safely
            string filePath = Path.Combine(currentDirectory, "includes", "products.json");

            // Read the file content asynchronously
            string json = await System.IO.File.ReadAllTextAsync(filePath);

            // Deserialize the JSON string into a list of Product objects
            var products = JsonConvert.DeserializeObject<List<ProductData>>(json);

            // Pass the list of products to the view
            return View(products);
        }
    }
}
