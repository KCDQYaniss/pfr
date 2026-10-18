namespace EFT;

internal abstract class World : MonoBehaviour
{
	protected const int ID_MAX_VALUE = 2700; //Field offset: 0x0
	public const int SERIALIZATION_BUFFER_SIZE = 59392; //Field offset: 0x0
	protected readonly int[] COUNT_BIT_RANGES; //Field offset: 0x20
	private Dictionary _interactables; //Field offset: 0x28
	protected WorldInteractiveObject[] _interactableObjectsForNetSync; //Field offset: 0x30
	private Dictionary _interactiveObjectsDictionary; //Field offset: 0x38
	protected GameWorldPacket _packet; //Field offset: 0x40

	public IReadOnlyDictionary Interactables
	{
		 get { } //Length: 5
	}

	protected World() { }

	public override void AddLampChangeStatePacket(int netId, EState state) { }

	protected static T Create(GameWorld gameWorld, IDictionary interactables) { }

	public WorldInteractiveObject FindDoor(string doorId) { }

	public IReadOnlyDictionary get_Interactables() { }

	protected override void OnDestroy() { }

	public override void OnExfiltrationPointUpdate(ExfiltrationPoint point) { }

	private void RegisterNetworkInteractionObjects(IDictionary interactables = null) { }

	public void RegisterWorldInteractionObject(WorldInteractiveObject worldInteractiveObject) { }

	public override void SubscribeToBorderZones(BorderZone[] zones) { }

	public IEnumerable WorldInteractiveObjects() { }

}

