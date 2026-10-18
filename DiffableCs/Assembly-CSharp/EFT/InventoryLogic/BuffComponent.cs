namespace EFT.InventoryLogic;

public sealed class BuffComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__38_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <UpdateModifiers>b__38_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public int value; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal float <UpdateModifiers>b__0() { }

		internal string <UpdateModifiers>b__1() { }

	}

	private const float DURABILITY_THRESHOLD = 0.5; //Field offset: 0x0
	private ERepairBuffType _buffType; //Field offset: 0x18
	private double _value; //Field offset: 0x20
	private double _thresholdDurability; //Field offset: 0x28
	private bool _isErrorIssues; //Field offset: 0x30
	[Diffable]
	[JsonProperty("rarity")]
	public EBuffRarity Rarity; //Field offset: 0x34
	[CompilerGenerated]
	private EItemAttributeId <BuffAttributeId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private double <WeaponSpread>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private double <DamageReduction>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private double <MalfunctionProtections>k__BackingField; //Field offset: 0x50

	public private EItemAttributeId BuffAttributeId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[Diffable]
	[JsonProperty("buffType")]
	public ERepairBuffType BuffType
	{
		 get { } //Length: 4
		 set { } //Length: 10
	}

	public private double DamageReduction
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public bool IsActive
	{
		 get { } //Length: 93
	}

	public private double MalfunctionProtections
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public virtual bool Serialized
	{
		 get { } //Length: 93
	}

	[Diffable]
	[JsonProperty("thresholdDurability")]
	public double ThresholdDurability
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	[Diffable]
	[JsonProperty("value")]
	public double Value
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public private double WeaponSpread
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BuffComponent(Item item) { }

	public void DisableComponent() { }

	[CompilerGenerated]
	public EItemAttributeId get_BuffAttributeId() { }

	public ERepairBuffType get_BuffType() { }

	[CompilerGenerated]
	public double get_DamageReduction() { }

	public bool get_IsActive() { }

	[CompilerGenerated]
	public double get_MalfunctionProtections() { }

	public virtual bool get_Serialized() { }

	public double get_ThresholdDurability() { }

	public double get_Value() { }

	[CompilerGenerated]
	public double get_WeaponSpread() { }

	private void ResetEnhancedAttribute() { }

	[CompilerGenerated]
	private void set_BuffAttributeId(EItemAttributeId value) { }

	public void set_BuffType(ERepairBuffType value) { }

	[CompilerGenerated]
	private void set_DamageReduction(double value) { }

	[CompilerGenerated]
	private void set_MalfunctionProtections(double value) { }

	public void set_ThresholdDurability(double value) { }

	public void set_Value(double value) { }

	[CompilerGenerated]
	private void set_WeaponSpread(double value) { }

	public void TryDisableComponent(float durability) { }

	private bool TryGetEnhancedAttributeId(EItemAttributeId buffAttributeId, out EItemAttributeId enhancedAttributeId) { }

	private void UpdateEnhancedAttribute(RepairBuffAttribute buff) { }

	private void UpdateModifiers() { }

}

