//Type is in global namespace

public class AILootPoint : IAICorePointLink
{
	[SerializeField]
	private Vector3 _pos; //Field offset: 0x10
	private AICorePoint _core; //Field offset: 0x20
	[SerializeField]
	private int _coreId; //Field offset: 0x28
	public LootableContainer LootableContainer; //Field offset: 0x30
	[SerializeField]
	private string _lootableContainerId; //Field offset: 0x38
	[SerializeField]
	private string _lootSpawnId; //Field offset: 0x40
	public LootPoint LootSpawn; //Field offset: 0x48
	[SerializeField]
	public Vector3 LookPoint; //Field offset: 0x50
	public int Id; //Field offset: 0x5C
	private float _lockedUntile; //Field offset: 0x60
	private bool _isLocked; //Field offset: 0x64
	private int _lockerId; //Field offset: 0x68
	public int ClusterId; //Field offset: 0x6C
	private Item _spawnedItem; //Field offset: 0x70

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 5
	}

	public string LootableContainerId
	{
		 get { } //Length: 5
	}

	public string LootSpawnId
	{
		 get { } //Length: 5
	}

	public override Vector3 Position
	{
		 get { } //Length: 19
	}

	public Item SpawnedItem
	{
		 get { } //Length: 36
	}

	public EAiLootPointType Type
	{
		 get { } //Length: 87
	}

	public AILootPoint(int id, Vector3 stayPoint, Vector3 lookPoint, LootableContainer lootable, AICorePoint core) { }

	public AILootPoint(int id, Vector3 stayPoint, Vector3 lookPoint, LootPoint lootable, AICorePoint core) { }

	public void DisposeSpawnedItem() { }

	public void DrawGizmos(int index) { }

	public override AICorePoint get_CorePointInGame() { }

	public string get_LootableContainerId() { }

	public string get_LootSpawnId() { }

	public override Vector3 get_Position() { }

	public Item get_SpawnedItem() { }

	public EAiLootPointType get_Type() { }

	public bool IsFree(int idBot) { }

	public void LockFor(int ownerId, float period) { }

	public void Restore(AICorePointHolder coresHolder) { }

	public void RestoreContainer(LootableContainer container) { }

	public void RestoreLoot(JsonLootItem item) { }

}

