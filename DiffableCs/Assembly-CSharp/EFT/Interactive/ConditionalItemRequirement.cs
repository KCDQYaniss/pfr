namespace EFT.Interactive;

public sealed class ConditionalItemRequirement : TransitRequirement
{
	public string IdA; //Field offset: 0x18
	public string IdB; //Field offset: 0x20

	public ConditionalItemRequirement() { }

	public virtual string GetLocalizedTip() { }

	public virtual bool Met(Player player) { }

}

