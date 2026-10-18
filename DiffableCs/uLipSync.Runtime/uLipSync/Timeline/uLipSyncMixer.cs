namespace uLipSync.Timeline;

public class uLipSyncMixer : PlayableBehaviour
{
	[CompilerGenerated]
	private uLipSyncTrack <track>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TimelineClip[] <clips>k__BackingField; //Field offset: 0x18
	private uLipSyncTimelineEvent _target; //Field offset: 0x20
	private Dictionary _phonemeRatio; //Field offset: 0x28

	public TimelineClip[] clips
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public uLipSyncTrack track
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public uLipSyncMixer() { }

	[CompilerGenerated]
	public TimelineClip[] get_clips() { }

	[CompilerGenerated]
	public uLipSyncTrack get_track() { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[CompilerGenerated]
	public void set_clips(TimelineClip[] value) { }

	[CompilerGenerated]
	public void set_track(uLipSyncTrack value) { }

}

