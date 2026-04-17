using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore {
    public static List<Hero> Heroes { get; } = new() {
        new Hero {
    Id = 1,
    Name = "SuperMan",
    RealName = "Clark Kent",
    Universe = Universe.Dc,
    powerLevel = 95,
    Powers = new() { "Heat Vision", "Super Strength", "Flight", "Freeze Breath" },
    Weapon = new() { Name = "Fortress of Solitude Crystals", IsRanged = false },
    InternalNotes = "Kryptonian, weak to magic and kryptonite"
},
new Hero {
    Id = 2,
    Name = "Doctor Strange",
    RealName = "Stephen Strange",
    Universe = Universe.Marvel,
    powerLevel = 98,
    Powers = new() { "Time Manipulation", "Dimensional Travel", "Mystic Bolts", "Levitation" },
    Weapon = new() { Name = "Eye of Agamotto", IsRanged = true },
    InternalNotes = "Sorcerer Supreme, protects reality"
},
new Hero {
    Id = 3,
    Name = "Iron Man",
    RealName = "Tony Stark",
    Universe = Universe.Marvel,
    powerLevel = 88,
    Powers = new() { "Repulsor Blasts", "Flight", "Super Intelligence", "Missiles" },
    Weapon = new() { Name = "Mark LXXXV Nano Armor", IsRanged = true },
    InternalNotes = "Genius billionaire, nanotech suit"
},
new Hero {
    Id = 4,
    Name = "Black Panther",
    RealName = "T'Challa",
    Universe = Universe.Marvel,
    powerLevel = 92,
    Powers = new() { "Vibranium Claws", "Enhanced Senses", "Super Agility", "Energy Absorption" },
    Weapon = new() { Name = "Vibranium Suit + Kinetic Blasts", IsRanged = true },
    InternalNotes = "King of Wakanda, heart-shaped herb enhanced"
},
new Hero {
    Id = 5,
    Name = "Wonder Woman",
    RealName = "Diana Prince",
    Universe = Universe.Dc,
    powerLevel = 97,
    Powers = new() { "Super Strength", "Lasso of Truth", "Flight", "Combat Mastery" },
    Weapon = new() { Name = "Godkiller Sword + Lasso", IsRanged = false },
    InternalNotes = "Amazon princess, demigod daughter of Zeus"
},
new Hero {
    Id = 6,
    Name = "Spider-Man",
    RealName = "Peter Parker",
    Universe = Universe.Marvel,
    powerLevel = 82,
    Powers = new() { "Wall-Crawling", "Spider-Sense", "Web Shooters", "Super Reflexes" },
    Weapon = new() { Name = "Web-Shooters (Tony Stark Upgrade)", IsRanged = true },
    InternalNotes = "Friendly neighborhood hero, great responsibility"
},
new Hero {
    Id = 7,
    Name = "Batman",
    RealName = "Bruce Wayne",
    Universe = Universe.Dc,
    powerLevel = 75,
    Powers = new() { "Genius Intellect", "Martial Arts", "Stealth", "Gadgets" },
    Weapon = new() { Name = "Batarangs + Batmobile", IsRanged = true },
    InternalNotes = "No superpowers, but prep time is OP"
},
    };
}