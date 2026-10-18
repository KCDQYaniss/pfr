namespace EFT.Interactive;

public sealed class TimerRequirement : ExfiltrationRequirement
{

	public TimerRequirement() { }

	public virtual string GetLocalizedTip(string profileId) { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

}

