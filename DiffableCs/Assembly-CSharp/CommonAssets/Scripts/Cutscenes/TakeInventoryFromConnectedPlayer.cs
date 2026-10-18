namespace CommonAssets.Scripts.Cutscenes;

public class TakeInventoryFromConnectedPlayer : MonoBehaviour
{
	[SerializeField]
	private List containers; //Field offset: 0x20
	private readonly IEnumerable _slotsToIgnoreFirstPart; //Field offset: 0x28

	public TakeInventoryFromConnectedPlayer() { }

	private PrivateLootableContainer GetRandomFreeContainer() { }

	private void Start() { }

	public bool TryTakeAwayInventory(Profile profile, int playerId) { }

}

