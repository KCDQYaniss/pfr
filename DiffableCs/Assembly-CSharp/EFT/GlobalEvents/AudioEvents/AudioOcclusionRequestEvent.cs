namespace EFT.GlobalEvents.AudioEvents;

public class AudioOcclusionRequestEvent : BaseEvent
{
	[CompilerGenerated]
	private string <ID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector3 <PlayingPosition>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private BetterSource <Source>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private EOcclusionTest <OcclusionTest>k__BackingField; //Field offset: 0x38

	public private string ID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EOcclusionTest OcclusionTest
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3 PlayingPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private BetterSource Source
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public AudioOcclusionRequestEvent() { }

	[CompilerGenerated]
	public string get_ID() { }

	[CompilerGenerated]
	public EOcclusionTest get_OcclusionTest() { }

	[CompilerGenerated]
	public Vector3 get_PlayingPosition() { }

	[CompilerGenerated]
	public BetterSource get_Source() { }

	public void Invoke(string id, Vector3 originalPosition, BetterSource source, EOcclusionTest occlusionTest) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_ID(string value) { }

	[CompilerGenerated]
	private void set_OcclusionTest(EOcclusionTest value) { }

	[CompilerGenerated]
	private void set_PlayingPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_Source(BetterSource value) { }

}

