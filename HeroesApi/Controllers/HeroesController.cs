using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using HeroesApi.Models;
using HeroesApi.Data;
namespace HeroesApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HeroesController : ControllerBase {
    [HttpGet]
    public ActionResult<List<Hero>> GetAll() {
        return Ok(HeroesStore.Heroes);
    }
    [HttpGet("{id}")]
    public ActionResult<Hero> GetById(int id) {
        var hero = HeroesStore.Heroes.FirstOrDefault(h => h.Id == id);
        if (hero is null) {
            return NotFound(new { message = $"Герой с id={id} не найден" });
        }
        return Ok(hero);
    }
    [HttpGet("demo")]
    public ActionResult GetDemo() {
        var hero = HeroesStore.Heroes.First();
        var defaultOptions = new JsonSerializerOptions {
            WriteIndented = true
        };
        var ourOption = new JsonSerializerOptions {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };
        return Ok(new {
            writeDefaultSetting = JsonSerializer.Deserialize<object>(
JsonSerializer.Serialize(hero, defaultOptions), defaultOptions),
            withOurSetting = JsonSerializer.Deserialize<object>(JsonSerializer.Serialize(hero, ourOption), ourOption),
            note = "Сравните имена полей и знвяение universe  в двух вариантах"
        });
    }

     [HttpGet("serialize")]
   public ActionResult GetSerialize() {
      var options = new JsonSerializerOptions {
         PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         WriteIndented = true,
         Converters = { new JsonStringEnumConverter() }
      };

      var hero = new Hero
      {
         Id = 99,
         Name = "Тестовый герой",
         RealName = "Студент",
         Universe = Universe.Marvel,
         PowerLevel = 50,
         Powers = new() { "программирование", "дебаггинг" },
         Weapon = new() { Name = "Клавиатура", IsRanged = false },
         InternalNotes = "Это поле не попадёт в JSON"
      };

      string serializedJson = JsonSerializer.Serialize(hero, options);
      var deserializedHero = JsonSerializer.Deserialize<Hero>(serializedJson, options);

      return Ok(new
      {
         serializedJson = serializedJson,
         deserializedObject = deserializedHero,
         internalNotesAfterDeserialize = deserializedHero?.InternalNotes
      });
   }
}
