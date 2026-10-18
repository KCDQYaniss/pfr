namespace EFT;

public sealed class BoolPerkRuntimeValue : PerkRuntimeValue
{
	public readonly bool DefaultValue; //Field offset: 0x18
	public bool Value; //Field offset: 0x19

	public virtual EPerkRuntimeValueKind Kind
	{
		 get { } //Length: 3
	}

	public BoolPerkRuntimeValue(EPerkRuntimeStatId id, bool defaultValue) { }

	public virtual EPerkRuntimeValueKind get_Kind() { }

	public virtual void Reset() { }

	public void Set(bool value) { }

}

