namespace CharacterCreator
{
    public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetWeapon(string weapon);
    ICharacterBuilder SetArmor(string armor);
    ICharacterBuilder SetSkill(string skill);
    Warrior Build();
}
}