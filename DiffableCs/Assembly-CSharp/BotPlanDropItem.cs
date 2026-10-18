//Type is in global namespace

public class BotPlanDropItem : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Activate>b__10_0(AIPlaceInfo x) { }

	}

	private const float DROP_ITEM_PERIOD = 30; //Field offset: 0x0
	private const float FIND_ITEM_PERIOD = 30; //Field offset: 0x0
	private float _period; //Field offset: 0x18
	private float _periodGo; //Field offset: 0x1C
	private Vector3 _pointToDrop; //Field offset: 0x20
	[CanBeNull]
	private string _itemToDrop; //Field offset: 0x30
	private float _nextPossibleDropTime; //Field offset: 0x38
	private bool _havePlace; //Field offset: 0x3C
	private float _comeTime; //Field offset: 0x40

	public BotPlanDropItem(BotOwner owner) { }

	public void Activate() { }

	private void FindToDrop() { }

	public void ManualUpdate() { }

	private void TryDrop() { }

	public bool WantDropItem() { }

}

