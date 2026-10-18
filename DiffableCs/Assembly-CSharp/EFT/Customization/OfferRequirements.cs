namespace EFT.Customization;

public class OfferRequirements
{
	public int loyaltyLevel; //Field offset: 0x10
	public int profileLevel; //Field offset: 0x14
	public int prestigeLevel; //Field offset: 0x18
	public float standing; //Field offset: 0x1C
	public SkillRequirements[] skillRequirements; //Field offset: 0x20
	public string[] questRequirements; //Field offset: 0x28
	public ItemRequirements[] itemRequirements; //Field offset: 0x30
	public string requiredTid; //Field offset: 0x38
	public string[] achievementRequirements; //Field offset: 0x40

	public OfferRequirements() { }

}

