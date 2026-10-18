//Type is in global namespace

public class AIPlaceInfoTagillaAmbush : AIPlaceInfo
{
	internal enum EPointSearchType
	{
		Random = 1,
		Nearest = 2,
	}

	[SerializeField]
	private readonly List _ambushPoints; //Field offset: 0x88
	[SerializeField]
	private readonly EPointSearchType _pointSearchType; //Field offset: 0x90
	[SerializeField]
	private readonly float _maxAmbushDistance; //Field offset: 0x94

	public AIPlaceInfoTagillaAmbush() { }

	private void DoAmbush(BotOwner ambushOwner, bool state) { }

	private void DoTagillaAmbush(Player player, bool state) { }

	private Transform GetAmbushPoint(BotOwner owner) { }

	private void OnDrawGizmos() { }

	protected virtual void OnEnterPlace(Player player) { }

	protected virtual void OnLeavePlace(Player player) { }

}

