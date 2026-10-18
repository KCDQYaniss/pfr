namespace Dissonance.Threading;

internal class DThread : IThread
{
	private readonly Thread _thread; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsStarted>k__BackingField; //Field offset: 0x18

	public private override bool IsStarted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DThread(Action action) { }

	[CompilerGenerated]
	public override bool get_IsStarted() { }

	public override void Join() { }

	[CompilerGenerated]
	private void set_IsStarted(bool value) { }

	public override void Start() { }

}

