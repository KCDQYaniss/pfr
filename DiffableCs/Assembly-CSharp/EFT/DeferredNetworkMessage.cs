namespace EFT;

public class DeferredNetworkMessage
{
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x10
	public List messages; //Field offset: 0x18

	public private bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DeferredNetworkMessage() { }

	public void Add(ArraySegment message) { }

	public void Finish(Action handler) { }

	[CompilerGenerated]
	public bool get_Enabled() { }

	[CompilerGenerated]
	private void set_Enabled(bool value) { }

}

