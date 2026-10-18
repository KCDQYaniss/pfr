namespace EFT.Interactive;

public class SharedExfiltrationPoint : ScavExfiltrationPoint
{
	public bool IsMandatoryForScavs; //Field offset: 0x100

	public SharedExfiltrationPoint() { }

	public virtual bool InfiltrationMatch(Player player) { }

}

