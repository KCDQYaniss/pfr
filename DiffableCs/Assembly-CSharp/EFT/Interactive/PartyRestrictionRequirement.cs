namespace EFT.Interactive;

public sealed class PartyRestrictionRequirement : TransitRequirement
{
	public bool AllowParties; //Field offset: 0x18

	public PartyRestrictionRequirement() { }

	public virtual bool Met(Player player) { }

}

