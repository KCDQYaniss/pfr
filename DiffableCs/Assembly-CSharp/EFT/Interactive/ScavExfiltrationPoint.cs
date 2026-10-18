namespace EFT.Interactive;

public class ScavExfiltrationPoint : ExfiltrationPoint
{
	public List EligibleIds; //Field offset: 0xF8

	public ScavExfiltrationPoint() { }

	public virtual bool InfiltrationMatch(Player player) { }

}

