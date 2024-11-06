using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class ActivitiesController : ControllerBase
{
    private static List<Event> Events = new List<Event>
    {
        new Event { Name = "Legoland", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Legoland in Billund", Country = "Denmark" },
        new Event { Name = "Tivoli", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Tivoli in Copenhagen", Country = "Denmark" },
        new Event { Name = "Kongelige teater", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Kongelig theater in Copenhagen", Country = "Denmark" },
        new Event { Name = "Jellingestenen", ImageUrl = "Aarhus.jpg", Description = "Experience Jellingestenen in Sydjylland", Country = "Denmark" },
        new Event { Name = "Europa-Park", ImageUrl = "/images/Rust1.jpg", Description = "Experience Europa-Park and its exciting roller coasters", Country = "Germany" },
        new Event { Name = "Nationalpark Harz", ImageUrl = "/images/Goslar.jpg", Description = "Experience a beautiful and peaceful park in North Germany", Country = "Germany" },
        new Event { Name = "Eiffel Tower", ImageUrl = "/images/Paris.jpg", Description = "Experience the amazing view of the Eiffel Tower.", Country = "France" },
        new Event { Name = "Wine Tour", ImageUrl = "/images/Bordeaux.jpg", Description = "Experience a tasteful wine tour in Bordeaux", Country = "France" },
        new Event { Name = "Colosseum", ImageUrl = "/images/Rom.jpg", Description = "Experience the Colosseum in Rome", Country = "Italy" },
        new Event { Name = "Gondola Ride", ImageUrl = "/images/Venedig.jpg", Description = "Experience a romantic Gondola Ride in Venedig", Country = "Italy" },
        new Event { Name = "Sagrada Familia", ImageUrl = "/images/Barcelona.jpg", Description = "Experience the iconic Basilica designed by the architect Antoni Gaudi", Country = "Spain" },
        new Event { Name = "Alhambra", ImageUrl = "/images/Granada.jpg", Description = "Experience the historic palace in Granada", Country = "Spain" },
        new Event { Name = "Big Ben", ImageUrl = "/images/London.jpg", Description = "Experience the massive clock tower Big Ben in London", Country = "UK" },
        new Event { Name = "Stonehenge", ImageUrl = "/images/Salisbury.jpg", Description = "Experience the prehistoric monument Stonehenge in Salisbury", Country = "UK" },
        new Event { Name = "Statue of Liberty", ImageUrl = "/images/NewYorkCity.jpg", Description = "Experience the Statur of Liberty in New York City", Country = "USA" },
        new Event { Name = "Grand Canyon", ImageUrl = "/images/Arizona.jpg", Description = "Experience the impressive Grand Canyon", Country = "USA" },
        new Event { Name = "Niagara Falls", ImageUrl = "/images/Ontario.jpg", Description = "Experience the massive waterfall Niagara Falls in Ontario", Country = "Canada" },
        new Event { Name = "Banff National Park", ImageUrl = "/images/Alberta.jpg", Description = "Experince Canada's oldest national park Banff", Country = "Canada" },
        new Event { Name = "Sydney Opera House", ImageUrl = "/images/Sydney.jpg", Description = "Experience the iconic Opera House designed by Jørn Utzon", Country = "Australia" },
        new Event { Name = "Great Barrier Reef", ImageUrl = "/images/Cairns.jpg", Description = "Experience the worlds biggest coral reef system in Cairns", Country = "Australia" },
        new Event { Name = "Fushimi Inari-taisha", ImageUrl = "/images/Kyoto.jpg", Description = "Experience one of Japan's most famous shinto-shrines", Country = "Japan" },
        new Event { Name = "Mount Fuji", ImageUrl = "/images/Fujinomiya.jpg", Description = "Experience Japan's biggest mountain", Country = "Japan" },
        new Event { Name = "Cristo Redentor", ImageUrl = "/images/RioDeJaneiro.jpg", Description = "Experience Cristo Redentor, one of the world's most iconic statues", Country = "Brazil" },
        new Event { Name = "Iguazu-waterfalls", ImageUrl = "/images/FozDoIguaco.jpg", Description = "Experience the Iguazu-waterfalls, one of the world's biggest waterfalls", Country = "Brazil" },
        new Event { Name = "Great Wall of China", ImageUrl = "/images/Beijing.jpg", Description = "Experience the Great Wall of China in Beijing", Country = "China" },
        new Event { Name = "The Terracotta Army", ImageUrl = "/images/Xian.jpg", Description = "Experience The Terracotta Army which is over 2000 years old", Country = "China" },
        new Event { Name = "The Taj Mahal", ImageUrl = "/images/Agra.jpg", Description = "Experience The Taj Mahal, one of the seven wonders of the world", Country = "India" },
        new Event { Name = "The Kerala Backwaters", ImageUrl = "/images/Alappuzha.jpg", Description = "Experience The Kerala Backwaters, which is a network of lakes, canals and lagoons", Country = "India" },
        new Event { Name = "Saint Basil's Cathedral", ImageUrl = "/images/Moscow.jpg", Description = "Experience the iconic symbol of Russia, Saint Basil's Cathedral", Country = "Russia" },
        new Event { Name = "Hotel Saint Petersburg", ImageUrl = "/images/SaintPeterburg.jpg", Description = "Experience one of the largest and oldest museums in the world", Country = "Russia" },
        new Event { Name = "Table Mountain", ImageUrl = "/images/CapeTown.jpg", Description = "Experience an iconic flat-topped mountain overlooking Cape Town", Country = "South Africa" },
        new Event { Name = "Kruger National Park", ImageUrl = "/images/Nelspruit.jpg", Description = "Experience one of Africa's largest game reserves", Country = "South Africa" },
        new Event { Name = "The Pyramids of Giza", ImageUrl = "/images/Giza.jpg", Description = "Experience The Great Pyramids of Giza", Country = "Egypt" },
        new Event { Name = "The Valley of The Kings", ImageUrl = "/images/Luxor.jpg", Description = "Experience The Valley of The Kings where many Pharaohs of the New Kingsdom were buried", Country = "Egypt" },
        new Event { Name = "Perito Moreno Glacier", ImageUrl = "/images/ElCalafate.jpg", Description = "Experience one of the few advancing glaciers in the world", Country = "Argentina" },
        new Event { Name = "Iguazu Falls", ImageUrl = "/images/IguazuFalls.jpg", Description = "Experience one of the World's most stunning natural wonders", Country = "Argentina" },
        new Event { Name = "Chicken Itza", ImageUrl = "/images/Tinum.jpg", Description = "Experience the UNESCO World Heritage", Country = "Mexico" },
        new Event { Name = "Cenote Ik Kil", ImageUrl = "/images/Tinum1.jpg", Description = "Experience a natural sinkhole renowned for its stunning beauty", Country = "Mexico" },
        new Event { Name = "Hot Air Balloon Ride", ImageUrl = "/images/Goreme.jpg", Description = "Experience a Hot Air Balloon Ride in Cappadocia", Country = "Turkey" },
        new Event { Name = "The Hagia Sophia", ImageUrl = "/images/Istanbul.jpg", Description = "Experience The Hagia Sophia, served as a mosque and museum over the centuries", Country = "Turkey" },
        new Event { Name = "Acropolis", ImageUrl = "/images/Athen.jpg", Description = "Experience the world famous archaeological site Acropolis", Country = "Greece" },
        new Event { Name = "Oia", ImageUrl = "/images/Santorini.jpg", Description = "Experience pictureque village on the island Santorini", Country = "Greece" },
        new Event { Name = "The Belem Tower", ImageUrl = "/images/Lisbon.jpg", Description = "Experience a symbol of Portugal's Age of Discoveries", Country = "Portugal" },
        new Event { Name = "Livraria Lello", ImageUrl = "/images/Porto.jpg", Description = "Experience Livraria Lello, one of the world's most beautiful bookstores", Country = "Portugal" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Event>> Get()
    {
        return Ok(Events);
    }

    [HttpGet("byCountry/{country}")]
    public ActionResult<IEnumerable<Event>> GetByCountry(string country)
    {
        var eventsInCountry = Events.Where(h => h.Country.Equals(country, System.StringComparison.OrdinalIgnoreCase)).ToList();
        if (!eventsInCountry.Any())
        {
            return NotFound();
        }
        return Ok(eventsInCountry);
    }
}
