//Type is in global namespace

public class BotGiftData : BotData
{
	public const float DROP_GIFT_CLOSE = 3; //Field offset: 0x0
	public const float DROP_GIFT_DISTANCE = 5; //Field offset: 0x0
	private const float GIFT_PLAYER_DISTANCE = 25; //Field offset: 0x0
	private const float GIFT_PLAYER_LOSE_TARGET_DISTANCE = 35; //Field offset: 0x0
	private const float REPEAT_TRY_GIFT_PLAYER_TIME = 60; //Field offset: 0x0
	private Vector3 pointToDrop; //Field offset: 0x18
	private float _nextCheckTime; //Field offset: 0x24
	[CompilerGenerated]
	private GiftTarget <GiftTarget>k__BackingField; //Field offset: 0x28
	private Dictionary _gifterPlayers; //Field offset: 0x30
	private HashSet _betterGiftsIdPlayer; //Field offset: 0x38
	private EquipmentSlot[] slots; //Field offset: 0x40
	private readonly int _additionalGiftsLimit; //Field offset: 0x48
	private List _takenItems; //Field offset: 0x50

	public private GiftTarget GiftTarget
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotGiftData(BotOwner owner) { }

	public void AddPlayerForBetterGift(IPlayer player) { }

	public void CalcGiftsOnStart() { }

	public void Dispose() { }

	[CompilerGenerated]
	public GiftTarget get_GiftTarget() { }

	public GiftTarget GetGiftTarget(IPlayer player) { }

	public bool HaveUngiftedPlayerNear() { }

	public bool IsGood(IPlayer giftTargetPlayer) { }

	public bool IsItemTaken(Item itm) { }

	public bool IsPlayerOnDistance(IPlayer player, float dist) { }

	private void OnItemTaken(Item itm, IPlayer pl) { }

	[CompilerGenerated]
	private void set_GiftTarget(GiftTarget value) { }

	public void SetGiftTarget(GiftTarget giftTarget) { }

	public void UpdateGiftTarget() { }

}

