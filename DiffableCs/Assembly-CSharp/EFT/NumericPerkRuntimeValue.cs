namespace EFT;

public sealed class NumericPerkRuntimeValue : PerkRuntimeValue
{
	public readonly float DefaultValue; //Field offset: 0x18
	public float Value; //Field offset: 0x1C

	public virtual EPerkRuntimeValueKind Kind
	{
		 get { } //Length: 3
	}

	public NumericPerkRuntimeValue(EPerkRuntimeStatId id, float defaultValue) { }

	public void Add(float value) { }

	public virtual EPerkRuntimeValueKind get_Kind() { }

	public void Multiply(float multiplier) { }

	public virtual void Reset() { }

}

