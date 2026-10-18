namespace EFT.Interactive;

public abstract class BaseRestrictableZone : MonoBehaviour
{
	protected List allPlayersInZone; //Field offset: 0x20
	protected List allowedPlayers; //Field offset: 0x28
	protected List unallowedPlayers; //Field offset: 0x30

	protected BaseRestrictableZone() { }

	protected abstract void AddPlayer(Player player) { }

	public abstract bool IsAllowedPlayer(Player player) { }

	protected abstract void RemovePlayer(Player player) { }

}

