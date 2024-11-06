using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
private static List<Hotel> Hotel = new List<Hotel>
{
    new Hotel { Name = "Hotel Copenhagen", ImageUrl = "images/Copenhagen.jpg", Description = "A modern hotel in the heart of Copenhagen.", Country = "Denmark" },
    new Hotel { Name = "Hotel Aarhus", ImageUrl = "Aarhus.jpg", Description = "A cozy hotel in Aarhus.", Country = "Denmark" },
    new Hotel { Name = "Hotel Berlin", ImageUrl = "https://via.placeholder.com/150", Description = "An upscale hotel near Brandenburg Gate.", Country = "Germany" },
    new Hotel { Name = "Hotel Munich", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Munich.", Country = "Germany" },
    new Hotel { Name = "Hotel Paris", ImageUrl = "https://via.placeholder.com/150", Description = "A romantic hotel with views of the Eiffel Tower.", Country = "France" },
    new Hotel { Name = "Hotel Lyon", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Lyon.", Country = "France" },
    new Hotel { Name = "Hotel Rome", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in the city center.", Country = "Italy" },
    new Hotel { Name = "Hotel Milan", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Milan.", Country = "Italy" },
    new Hotel { Name = "Hotel Barcelona", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel near the beach.", Country = "Spain" },
    new Hotel { Name = "Hotel Madrid", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in Madrid.", Country = "Spain" },
    new Hotel { Name = "Hotel London", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in the capital.", Country = "UK" },
    new Hotel { Name = "Hotel Manchester", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Manchester.", Country = "UK" },
    new Hotel { Name = "Hotel New York", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the city.", Country = "USA" },
    new Hotel { Name = "Hotel Los Angeles", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in Los Angeles.", Country = "USA" },
    new Hotel { Name = "Hotel Toronto", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the heart of the city.", Country = "Canada" },
    new Hotel { Name = "Hotel Vancouver", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Vancouver.", Country = "Canada" },
    new Hotel { Name = "Hotel Sydney", ImageUrl = "https://via.placeholder.com/150", Description = "A luxury hotel with views of the harbor.", Country = "Australia" },
    new Hotel { Name = "Hotel Melbourne", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Melbourne.", Country = "Australia" },
    new Hotel { Name = "Hotel Tokyo", ImageUrl = "https://via.placeholder.com/150", Description = "A high-tech hotel in the city.", Country = "Japan" },
    new Hotel { Name = "Hotel Kyoto", ImageUrl = "https://via.placeholder.com/150", Description = "A traditional hotel in Kyoto.", Country = "Japan" },
    new Hotel { Name = "Hotel Rio de Janeiro", ImageUrl = "https://via.placeholder.com/150", Description = "A beachfront hotel in Brazil.", Country = "Brazil" },
    new Hotel { Name = "Hotel Sao Paulo", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Sao Paulo.", Country = "Brazil" },
    new Hotel { Name = "Hotel Beijing", ImageUrl = "https://via.placeholder.com/150", Description = "A historical hotel in China.", Country = "China" },
    new Hotel { Name = "Hotel Shanghai", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in Shanghai.", Country = "China" },
    new Hotel { Name = "Hotel Mumbai", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in India.", Country = "India" },
    new Hotel { Name = "Hotel Delhi", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Delhi.", Country = "India" },
    new Hotel { Name = "Hotel Moscow", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the capital.", Country = "Russia" },
    new Hotel { Name = "Hotel Saint Petersburg", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Saint Petersburg.", Country = "Russia" },
    new Hotel { Name = "Hotel Cape Town", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning views.", Country = "South Africa" },
    new Hotel { Name = "Hotel Johannesburg", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Johannesburg.", Country = "South Africa" },
    new Hotel { Name = "Hotel Cairo", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel near the pyramids.", Country = "Egypt" },
    new Hotel { Name = "Hotel Alexandria", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Alexandria.", Country = "Egypt" },
    new Hotel { Name = "Hotel Buenos Aires", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel in Argentina.", Country = "Argentina" },
    new Hotel { Name = "Hotel Cordoba", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Cordoba.", Country = "Argentina" },
    new Hotel { Name = "Hotel Mexico City", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the capital.", Country = "Mexico" },
    new Hotel { Name = "Hotel Cancun", ImageUrl = "https://via.placeholder.com/150", Description = "A beachfront hotel in Cancun.", Country = "Mexico" },
    new Hotel { Name = "Hotel Istanbul", ImageUrl = "https://via.placeholder.com/150", Description = "A historic hotel in the city.", Country = "Turkey" },
    new Hotel { Name = "Hotel Ankara", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Ankara.", Country = "Turkey" },
    new Hotel { Name = "Hotel Athens", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning views of the Acropolis.", Country = "Greece" },
    new Hotel { Name = "Hotel Thessaloniki", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Thessaloniki.", Country = "Greece" },
    new Hotel { Name = "Hotel Lisbon", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Portugal.", Country = "Portugal" },
    new Hotel { Name = "Hotel Porto", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Porto.", Country = "Portugal" }
};

    [HttpGet]
    public ActionResult<IEnumerable<Hotel>> Get()
    {
        return Ok(Hotel);
    }

    [HttpGet("byCountry/{country}")]
    public ActionResult<IEnumerable<Hotel>> GetByCountry(string country)
    {
        var hotelsInCountry = Hotel.Where(h => h.Country.Equals(country, System.StringComparison.OrdinalIgnoreCase)).ToList();
        if (!hotelsInCountry.Any())
        {
            return NotFound();
        }
        return Ok(hotelsInCountry);
    }
}


