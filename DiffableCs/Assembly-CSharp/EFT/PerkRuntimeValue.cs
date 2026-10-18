namespace EFT;

public abstract class PerkRuntimeValue
{
	[CompilerGenerated]
	private readonly EPerkRuntimeStatId <Id>k__BackingField; //Field offset: 0x10

	public EPerkRuntimeStatId Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public abstract EPerkRuntimeValueKind Kind
	{
		 get { } //Length: 0
	}

	protected PerkRuntimeValue(EPerkRuntimeStatId id) { }

	[CompilerGenerated]
	public EPerkRuntimeStatId get_Id() { }

	public abstract EPerkRuntimeValueKind get_Kind() { }

	public abstract void Reset() { }

}

