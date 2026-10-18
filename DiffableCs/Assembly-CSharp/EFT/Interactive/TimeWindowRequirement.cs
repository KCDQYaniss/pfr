namespace EFT.Interactive;

public sealed class TimeWindowRequirement : TransitRequirement
{
	public int FromHour; //Field offset: 0x18
	public int ToHour; //Field offset: 0x1C

	public TimeWindowRequirement() { }

	public static bool CheckGameTime(int fromHour, int toHour) { }

	public virtual string GetLocalizedTip() { }

	public virtual bool Met(Player player) { }

}

