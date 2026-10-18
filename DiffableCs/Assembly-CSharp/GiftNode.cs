//Type is in global namespace

public class GiftNode : BaseNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <DropGift>b__10_0(Item x) { }

		internal bool <DropGift>b__10_1(Item x) { }

	}

	private const float DROP_ITEM_PERIOD = 5; //Field offset: 0x0
	private const float GESTURE_TO_DROPPED_ITEM_TIME = 2.4; //Field offset: 0x0
	private EquipmentSlot[] slots; //Field offset: 0x18
	private float _nextPossibleDropTime; //Field offset: 0x20
	private float _lastItemDropTime; //Field offset: 0x24
	private float _nodeEndTime; //Field offset: 0x28
	private Vector3 _droppedItemPosition; //Field offset: 0x2C

	public GiftNode(BotOwner bot) { }

	private void DropGift() { }

	private void EndGift() { }

	private void OnItemDrop(Item item) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

