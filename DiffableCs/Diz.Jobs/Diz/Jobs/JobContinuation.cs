namespace Diz.Jobs;

internal struct JobContinuation
{
	public Action action; //Field offset: 0x0
	public JobYield jobYield; //Field offset: 0x8
	public string jobStageName; //Field offset: 0x10
	[CompilerGenerated]
	private bool <wasExecuted>k__BackingField; //Field offset: 0x18

	public private bool wasExecuted
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public JobContinuation(Action action, JobYield jobYield) { }

	public void Execute() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_wasExecuted() { }

	[CompilerGenerated]
	private void set_wasExecuted(bool value) { }

}

