namespace CharacterCreator
{
    public class Warrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public string Armor { get; set; }
        public string Skill { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Weapon: {Weapon}, Armor: {Armor}, Skill: {Skill}");
        }
    }
}