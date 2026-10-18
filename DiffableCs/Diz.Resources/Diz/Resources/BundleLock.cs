namespace Diz.Resources;

public sealed class BundleLock : IBundleLock
{
	[CompilerGenerated]
	private int <MaxConcurrentOperations>k__BackingField; //Field offset: 0x10
	private int _counter; //Field offset: 0x14

	public override bool IsLocked
	{
		 get { } //Length: 15
	}

	public int MaxConcurrentOperations
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BundleLock(int maxConcurrentOperations) { }

	public override bool get_IsLocked() { }

	[CompilerGenerated]
	public int get_MaxConcurrentOperations() { }

	public override void Lock() { }

	[CompilerGenerated]
	public void set_MaxConcurrentOperations(int value) { }

	public override void Unlock() { }

}

