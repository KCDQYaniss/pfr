namespace System.Threading;

[IsReadOnly]
public struct AsyncLocalValueChangedArgs`1
{
	[CompilerGenerated]
	private readonly T <PreviousValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly T <CurrentValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <ThreadContextChanged>k__BackingField; //Field offset: 0x0

	internal AsyncLocalValueChangedArgs`1(T previousValue, T currentValue, bool contextChanged) { }

}

