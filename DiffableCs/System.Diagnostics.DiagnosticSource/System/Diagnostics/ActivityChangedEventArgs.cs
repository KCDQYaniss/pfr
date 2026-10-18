namespace System.Diagnostics;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
public struct ActivityChangedEventArgs
{
	[CompilerGenerated]
	private readonly Activity <Previous>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Activity <Current>k__BackingField; //Field offset: 0x8

	public Activity Current
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Activity Previous
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	internal ActivityChangedEventArgs(Activity previous, Activity current) { }

	[CompilerGenerated]
	public void set_Current(Activity value) { }

	[CompilerGenerated]
	public void set_Previous(Activity value) { }

}

