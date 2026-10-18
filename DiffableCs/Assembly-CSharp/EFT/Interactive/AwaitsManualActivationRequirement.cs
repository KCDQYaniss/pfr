namespace EFT.Interactive;

public class AwaitsManualActivationRequirement : ExfiltrationRequirement
{

	public AwaitsManualActivationRequirement() { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

}

