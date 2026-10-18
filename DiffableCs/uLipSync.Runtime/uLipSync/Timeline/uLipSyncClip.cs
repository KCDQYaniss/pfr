namespace uLipSync.Timeline;

public class uLipSyncClip : PlayableAsset, ITimelineClipAsset
{
	public BakedData bakedData; //Field offset: 0x18
	[Range(0, 1)]
	public float volume; //Field offset: 0x20
	[Range(-0.3, 0.3)]
	public float timeOffset; //Field offset: 0x24
	[CompilerGenerated]
	private uLipSyncBehaviour <behaviour>k__BackingField; //Field offset: 0x28

	public private uLipSyncBehaviour behaviour
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override ClipCaps clipCaps
	{
		 get { } //Length: 6
	}

	public virtual double duration
	{
		 get { } //Length: 311
	}

	public uLipSyncClip() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[CompilerGenerated]
	public uLipSyncBehaviour get_behaviour() { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	[CompilerGenerated]
	private void set_behaviour(uLipSyncBehaviour value) { }

}

