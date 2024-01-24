// See https://aka.ms/new-console-template for more information
using CharacterCreator;

Console.WriteLine("Hello, World!");


ICharacterBuilder builder = new CharacterBuilder();
Warrior warrior = builder.SetName("Sir Arthur")
                        .SetWeapon("Sword")
                        .SetArmor("Plate Mail")
                        .SetSkill("Shield Bash")
                        .Build();


// Displaying information about the Warrior
Console.WriteLine("Warrior Information:");
warrior.DisplayInfo();


Warrior warrior2 = builder.SetName("Sir Lancellot")
                        .SetWeapon("Spear")
                        .SetArmor("Light Plate")
                        .SetSkill("Eyes of Tiger")
                        .Build();


// Displaying information about the Warrior
Console.WriteLine("Warrior Information:");
warrior2.DisplayInfo();