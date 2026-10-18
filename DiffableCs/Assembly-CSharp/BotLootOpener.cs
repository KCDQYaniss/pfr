//Type is in global namespace

public class BotLootOpener : BotData
{
	public const float DIR_SIDE_MAX_SQRT = 4; //Field offset: 0x0
	private const float CHECK_RUN_DIST = 27.039997; //Field offset: 0x0
	private const float MAX_DIST = 49; //Field offset: 0x0
	private const float OPEN_DIST = 16; //Field offset: 0x0
	private LootableContainer _curLoot; //Field offset: 0x18
	private float _nextPosibleDoorOpenTime; //Field offset: 0x20
	private float _traversingEnd; //Field offset: 0x24
	private float _deltaTime; //Field offset: 0x28
	private float _searchCloseDoorTime; //Field offset: 0x2C
	private bool _traversingLink; //Field offset: 0x30

	public BotLootOpener(BotOwner owner) { }

	public void Interact(LootableContainer door, EInteractionType Etype) { }

}

