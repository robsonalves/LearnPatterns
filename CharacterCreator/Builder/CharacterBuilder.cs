namespace CharacterCreator
{
    public class CharacterBuilder : ICharacterBuilder
{
    private Warrior warrior = new Warrior();

    public ICharacterBuilder SetName(string name)
    {
        warrior.Name = name;
        return this;
    }

    public ICharacterBuilder SetWeapon(string weapon)
    {
        warrior.Weapon = weapon;
        return this;
    }

    public ICharacterBuilder SetArmor(string armor)
    {
        warrior.Armor = armor;
        return this;
    }

    public ICharacterBuilder SetSkill(string skill)
    {
        warrior.Skill = skill;
        return this;
    }

    public Warrior Build()
    {
        return warrior;
    }
}
}