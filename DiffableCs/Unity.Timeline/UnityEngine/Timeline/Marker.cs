namespace UnityEngine.Timeline;

public abstract class Marker : ScriptableObject, IMarker
{
	[SerializeField]
	[TimeField(UseEditMode::ApplyEditMode (1))]
	[Tooltip("Time for the marker")]
	private double m_Time; //Field offset: 0x18
	[CompilerGenerated]
	private TrackAsset <parent>k__BackingField; //Field offset: 0x20

	public private override TrackAsset parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override double time
	{
		 get { } //Length: 6
		 set { } //Length: 145
	}

	protected Marker() { }

	[CompilerGenerated]
	public override TrackAsset get_parent() { }

	public override double get_time() { }

	public override void OnInitialize(TrackAsset aPent) { }

	[CompilerGenerated]
	private void set_parent(TrackAsset value) { }

	public override void set_time(double value) { }

	private override void UnityEngine.Timeline.IMarker.Initialize(TrackAsset parentTrack) { }

}

