namespace UnityEngine.Timeline;

[ExcludeFromPreset]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__27 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PlayableBinding <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x38
		public TimelineAsset <>4__this; //Field offset: 0x40
		private IEnumerator <>7__wrap1; //Field offset: 0x48
		private IEnumerator <>7__wrap2; //Field offset: 0x50

		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 19
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 83
		}

		[DebuggerHidden]
		public <get_outputs>d__27(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[DebuggerHidden]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum DurationMode
	{
		BasedOnClips = 0,
		FixedLength = 1,
	}

	internal class EditorSettings
	{
		internal static readonly double kMinFrameRate; //Field offset: 0x0
		internal static readonly double kMaxFrameRate; //Field offset: 0x8
		internal static readonly double kDefaultFrameRate; //Field offset: 0x10
		[FrameRateField]
		[HideInInspector]
		[SerializeField]
		private double m_Framerate; //Field offset: 0x10
		[HideInInspector]
		[SerializeField]
		private bool m_ScenePreview; //Field offset: 0x18

		[Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", False)]
		public float fps
		{
			 get { } //Length: 10
			 set { } //Length: 173
		}

		public double frameRate
		{
			 get { } //Length: 6
			 set { } //Length: 30
		}

		public bool scenePreview
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		private static EditorSettings() { }

		public EditorSettings() { }

		public float get_fps() { }

		public double get_frameRate() { }

		public bool get_scenePreview() { }

		public void set_fps(float value) { }

		public void set_frameRate(double value) { }

		public void set_scenePreview(bool value) { }

		public void SetStandardFrameRate(StandardFrameRates enumValue) { }

	}

	[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
	internal enum MediaType
	{
		Animation = 0,
		Audio = 1,
		Texture = 2,
		Video = 2,
		Script = 3,
		Hybrid = 4,
		Group = 5,
	}

	private static class TimelineAssetUpgrade
	{

	}

	private enum Versions
	{
		Initial = 0,
	}

	private const int k_LatestVersion = 0; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private List m_Tracks; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private double m_FixedDuration; //Field offset: 0x28
	[HideInInspector]
	private TrackAsset[] m_CacheOutputTracks; //Field offset: 0x30
	[HideInInspector]
	private List m_CacheRootTracks; //Field offset: 0x38
	[HideInInspector]
	private TrackAsset[] m_CacheFlattenedTracks; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private EditorSettings m_EditorSettings; //Field offset: 0x48
	[SerializeField]
	private DurationMode m_DurationMode; //Field offset: 0x50
	[HideInInspector]
	[SerializeField]
	private MarkerTrack m_MarkerTrack; //Field offset: 0x58

	public override ClipCaps clipCaps
	{
		 get { } //Length: 436
	}

	public virtual double duration
	{
		 get { } //Length: 153
	}

	public DurationMode durationMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public EditorSettings editorSettings
	{
		 get { } //Length: 5
	}

	public double fixedDuration
	{
		 get { } //Length: 274
		 set { } //Length: 145
	}

	internal TrackAsset[] flattenedTracks
	{
		internal get { } //Length: 520
	}

	public MarkerTrack markerTrack
	{
		 get { } //Length: 5
	}

	public virtual IEnumerable outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__27))]
		 get { } //Length: 175
	}

	public int outputTrackCount
	{
		 get { } //Length: 39
	}

	public int rootTrackCount
	{
		 get { } //Length: 75
	}

	internal List trackObjects
	{
		internal get { } //Length: 5
	}

	private void __internalAwake() { }

	public TimelineAsset() { }

	private static void AddSubTracksRecursive(TrackAsset track, ref List allTracks) { }

	internal void AddTrackInternal(TrackAsset track) { }

	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	private DiscreteTime CalculateItemsDuration() { }

	public void CreateMarkerTrack() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public T CreateTrack(TrackAsset parent, string trackName) { }

	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	public T CreateTrack(string trackName) { }

	public T CreateTrack() { }

	public bool DeleteClip(TimelineClip clip) { }

	private void DeleteRecordedAnimation(TrackAsset track) { }

	private void DeleteRecordedAnimation(TimelineClip clip) { }

	public bool DeleteTrack(TrackAsset track) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	public DurationMode get_durationMode() { }

	public EditorSettings get_editorSettings() { }

	public double get_fixedDuration() { }

	internal TrackAsset[] get_flattenedTracks() { }

	public MarkerTrack get_markerTrack() { }

	[IteratorStateMachine(typeof(<get_outputs>d__27))]
	public virtual IEnumerable get_outputs() { }

	public int get_outputTrackCount() { }

	public int get_rootTrackCount() { }

	internal List get_trackObjects() { }

	public TrackAsset GetOutputTrack(int index) { }

	public IEnumerable GetOutputTracks() { }

	public TrackAsset GetRootTrack(int index) { }

	public IEnumerable GetRootTracks() { }

	private static double GetValidFrameRate(double frameRate) { }

	internal void Invalidate() { }

	internal void MoveLastTrackBefore(TrackAsset asset) { }

	private void OnValidate() { }

	internal void RemoveTrack(TrackAsset track) { }

	public void set_durationMode(DurationMode value) { }

	public void set_fixedDuration(double value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	internal void UpdateFixedDurationWithItemsDuration() { }

	private void UpdateOutputTrackCache() { }

	private void UpdateRootTrackCache() { }

	private void UpgradeToLatestVersion() { }

}

