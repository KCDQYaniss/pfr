namespace EFT.Hideout;

public sealed class ResourceConsumer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__52_0; //Field offset: 0x8
		public static Func <>9__52_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <SetItems>b__52_0(SupplyItem supply) { }

		internal float <SetItems>b__52_1(BarterItem item) { }

	}

	[CompilerGenerated]
	private Action OnItemResourceEnded; //Field offset: 0x10
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action BeforeResourceItemsChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Action AfterResourceItemsChanged; //Field offset: 0x28
	private bool _isOn; //Field offset: 0x30
	private bool _isWorking; //Field offset: 0x31
	private float _consumption; //Field offset: 0x34
	private float _consumptionReduction; //Field offset: 0x38
	[CompilerGenerated]
	private double <TotalResourceCount>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private double <TotalResourceCountLeft>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private BarterItem[] <UsingItems>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private SupplyItem[] <SupplyItems>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly ConsumptionTimer <Timer>k__BackingField; //Field offset: 0x60

	public event Action AfterResourceItemsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action BeforeResourceItemsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnItemResourceEnded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool CanWork
	{
		 get { } //Length: 99
	}

	public float Consumption
	{
		 get { } //Length: 6
		 set { } //Length: 115
	}

	public float ConsumptionReduction
	{
		 get { } //Length: 6
		 set { } //Length: 115
	}

	public bool IsOn
	{
		 get { } //Length: 5
		 set { } //Length: 169
	}

	public private bool IsWorking
	{
		 get { } //Length: 5
		private set { } //Length: 61
	}

	public float ResultConsumption
	{
		 get { } //Length: 19
	}

	public private SupplyItem[] SupplyItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ConsumptionTimer Timer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private double TotalResourceCount
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private double TotalResourceCountLeft
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private BarterItem[] UsingItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ResourceConsumer() { }

	[CompilerGenerated]
	public void add_AfterResourceItemsChanged(Action value) { }

	[CompilerGenerated]
	public void add_BeforeResourceItemsChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnItemResourceEnded(Action value) { }

	[CompilerGenerated]
	public void add_StateChanged(Action value) { }

	public bool get_CanWork() { }

	public float get_Consumption() { }

	public float get_ConsumptionReduction() { }

	public bool get_IsOn() { }

	public bool get_IsWorking() { }

	public float get_ResultConsumption() { }

	[CompilerGenerated]
	public SupplyItem[] get_SupplyItems() { }

	[CompilerGenerated]
	public ConsumptionTimer get_Timer() { }

	[CompilerGenerated]
	public double get_TotalResourceCount() { }

	[CompilerGenerated]
	public double get_TotalResourceCountLeft() { }

	[CompilerGenerated]
	public BarterItem[] get_UsingItems() { }

	private void PrepareTimer() { }

	[CompilerGenerated]
	public void remove_AfterResourceItemsChanged(Action value) { }

	[CompilerGenerated]
	public void remove_BeforeResourceItemsChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemResourceEnded(Action value) { }

	[CompilerGenerated]
	public void remove_StateChanged(Action value) { }

	public void set_Consumption(float value) { }

	public void set_ConsumptionReduction(float value) { }

	public void set_IsOn(bool value) { }

	private void set_IsWorking(bool value) { }

	[CompilerGenerated]
	private void set_SupplyItems(SupplyItem[] value) { }

	[CompilerGenerated]
	private void set_TotalResourceCount(double value) { }

	[CompilerGenerated]
	private void set_TotalResourceCountLeft(double value) { }

	[CompilerGenerated]
	private void set_UsingItems(BarterItem[] value) { }

	public void SetItems(BarterItem[] installedSupplies) { }

	public void UpdateSlotsData(AdditionalSlotsBonus slots) { }

	public bool Work(float deltaTime) { }

}

