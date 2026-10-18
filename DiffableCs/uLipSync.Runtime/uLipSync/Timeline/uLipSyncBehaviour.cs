namespace uLipSync.Timeline;

public class uLipSyncBehaviour : PlayableBehaviour
{
	public uLipSyncClip asset; //Field offset: 0x10
	[CompilerGenerated]
	private BakedFrame <frame>k__BackingField; //Field offset: 0x18

	public private BakedFrame frame
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public uLipSyncBehaviour() { }

	[CompilerGenerated]
	public BakedFrame get_frame() { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[CompilerGenerated]
	private void set_frame(BakedFrame value) { }

}

