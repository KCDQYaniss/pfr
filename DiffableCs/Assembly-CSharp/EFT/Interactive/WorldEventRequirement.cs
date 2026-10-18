namespace EFT.Interactive;

public sealed class WorldEventRequirement : ExfiltrationRequirement
{

	public WorldEventRequirement() { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

}

