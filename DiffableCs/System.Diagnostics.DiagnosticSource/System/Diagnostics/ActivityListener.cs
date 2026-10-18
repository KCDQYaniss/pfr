namespace System.Diagnostics;

[Nullable(0)]
[NullableContext(2)]
public sealed class ActivityListener : IDisposable
{
	[CompilerGenerated]
	private Action <ActivityStopped>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Func <ShouldListenTo>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action ActivityStopped
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Func ShouldListenTo
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override void Dispose() { }

	[CompilerGenerated]
	public Action get_ActivityStopped() { }

	[CompilerGenerated]
	public Func get_ShouldListenTo() { }

}

