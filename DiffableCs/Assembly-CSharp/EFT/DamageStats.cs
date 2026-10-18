namespace EFT;

public sealed class DamageStats
{
	internal enum EDamageResult
	{
		None = 0,
		Regular = 1,
		Lethal = 2,
	}

	[CompilerGenerated]
	private float <Amount>k__BackingField; //Field offset: 0x10
	public readonly EDamageType Type; //Field offset: 0x14
	public readonly string SourceId; //Field offset: 0x18
	public readonly Nullable OverDamageFrom; //Field offset: 0x20
	public readonly bool Blunt; //Field offset: 0x28
	[CompilerGenerated]
	private float <ImpactsCount>k__BackingField; //Field offset: 0x2C

	public private float Amount
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float ImpactsCount
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public DamageStats(DamageStatsDescriptor descriptor) { }

	public DamageStats(EDamageType type, float amount, Nullable overDamageFrom, bool blunt = false, string sourceId = null) { }

	public void Add(DamageStats damage) { }

	public DamageStats Clone() { }

	[CompilerGenerated]
	public float get_Amount() { }

	[CompilerGenerated]
	public float get_ImpactsCount() { }

	public bool IsEqual(DamageStats damageStats, bool compareShots = false) { }

	public void Remove(float amount) { }

	[CompilerGenerated]
	private void set_Amount(float value) { }

	[CompilerGenerated]
	private void set_ImpactsCount(float value) { }

	public virtual string ToString() { }

}

