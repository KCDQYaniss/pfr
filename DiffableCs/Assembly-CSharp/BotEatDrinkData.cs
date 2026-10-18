//Type is in global namespace

public class BotEatDrinkData : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Action callback; //Field offset: 0x10
		public BotEatDrinkData <>4__this; //Field offset: 0x18
		public Callback <>9__1; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <Apply>b__0(Result hands) { }

		internal void <Apply>b__1(Result applyResult) { }

	}

	private const float SAFE_PERIOD = 30; //Field offset: 0x0
	private const float START_TIME_OFFSET = 90; //Field offset: 0x0
	private Action _callback; //Field offset: 0x18
	private readonly List _itemsToUse; //Field offset: 0x20
	private float _nextPossibleUseTime; //Field offset: 0x28
	private float _safeTime; //Field offset: 0x2C
	private bool _errorPrint; //Field offset: 0x30
	private bool _using; //Field offset: 0x31
	private bool _haveItems; //Field offset: 0x32
	private FoodDrink _foodToUse; //Field offset: 0x38
	private IPlayer _lookTo; //Field offset: 0x40
	private bool _shallStart; //Field offset: 0x48

	public bool Using
	{
		 get { } //Length: 5
		 set { } //Length: 28
	}

	public BotEatDrinkData(BotOwner owner) { }

	public void Activate() { }

	public void Apply(Nullable varianAnim = null, Action callback = null) { }

	public void Dispose() { }

	public bool get_Using() { }

	public bool HaveActions() { }

	public bool HaveEat() { }

	public void ManualUpdate() { }

	private void RefreshItems() { }

	public void set_Using(bool value) { }

	public void StartDo(BotsPairData closest) { }

	private void UpdatePeriod() { }

}

