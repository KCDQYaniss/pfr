namespace EFT.Settings;

public class VirtualControlDescriptor
{
	public EGameKey SourceKey; //Field offset: 0x10
	public EGameKey TargetKey; //Field offset: 0x14
	[CompilerGenerated]
	private readonly Nullable <PressType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly InputSource[] <ExtraVariants>k__BackingField; //Field offset: 0x20
	public EPressType[] EnableForSourcePressType; //Field offset: 0x28
	[CompilerGenerated]
	private readonly bool <IgnorePool>k__BackingField; //Field offset: 0x30

	public InputSource[] ExtraVariants
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IgnorePool
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Nullable PressType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public VirtualControlDescriptor(EGameKey sourceKey, EGameKey targetKey, EPressType newPressType, EPressType[] enableForSourcePressType) { }

	public VirtualControlDescriptor(EGameKey sourceKey, EGameKey targetKey, EPressType newPressType, InputSource[] extraVariants) { }

	public VirtualControlDescriptor(EGameKey sourceKey, EGameKey targetKey, EPressType newPressType, bool ignorePool, InputSource[] extraVariants) { }

	public VirtualControlDescriptor(EGameKey sourceKey, EGameKey targetKey, InputSource[] extraVariants) { }

	[CompilerGenerated]
	public InputSource[] get_ExtraVariants() { }

	[CompilerGenerated]
	public bool get_IgnorePool() { }

	[CompilerGenerated]
	public Nullable get_PressType() { }

}

