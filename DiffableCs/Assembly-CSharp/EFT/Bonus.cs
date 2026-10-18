namespace EFT;

public abstract class Bonus
{
	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private double <Value>k__BackingField; //Field offset: 0x28
	public readonly bool IsVisible; //Field offset: 0x30
	public readonly bool Passive; //Field offset: 0x31
	public readonly bool Production; //Field offset: 0x32
	public readonly string Icon; //Field offset: 0x38

	public abstract EBonusType BonusType
	{
		 get { } //Length: 0
	}

	public MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public override bool IsPositive
	{
		 get { } //Length: 16
	}

	public override string LocalizationKey
	{
		 get { } //Length: 182
	}

	public override double ResultValue
	{
		 get { } //Length: 6
	}

	public override Enum TargetType
	{
		 get { } //Length: 91
	}

	public double Value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected Bonus(BonusDescriptor descriptor) { }

	public override void Add(Bonus bonus) { }

	public abstract double CalculateValue(double input) { }

	public override Bonus Clone() { }

	public abstract EBonusType get_BonusType() { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	public override bool get_IsPositive() { }

	public override string get_LocalizationKey() { }

	public override double get_ResultValue() { }

	public override Enum get_TargetType() { }

	[CompilerGenerated]
	public double get_Value() { }

	public override string GetValueFormat(bool isFutureBonus = false) { }

	[CompilerGenerated]
	protected void set_Id(MongoID value) { }

	[CompilerGenerated]
	protected void set_Value(double value) { }

	public override BonusDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

