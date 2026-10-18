namespace UnityEngine.Timeline;

[NotKeyable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__45 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PlayableBinding <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x38
		public AnimationPlayableAsset <>4__this; //Field offset: 0x40

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
		public <get_outputs>d__45(int <>1__state) { }

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

	private static class AnimationPlayableAssetUpgrade
	{

		public static void ConvertRotationToEuler(AnimationPlayableAsset asset) { }

	}

	internal enum LoopMode
	{
		UseSourceAsset = 0,
		On = 1,
		Off = 2,
	}

	private enum Versions
	{
		Initial = 0,
		RotationAsEuler = 1,
	}

	private static readonly int k_LatestVersion; //Field offset: 0x0
	[SerializeField]
	private AnimationClip m_Clip; //Field offset: 0x18
	[SerializeField]
	private Vector3 m_Position; //Field offset: 0x20
	[SerializeField]
	private Vector3 m_EulerAngles; //Field offset: 0x2C
	[SerializeField]
	private bool m_UseTrackMatchFields; //Field offset: 0x38
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; //Field offset: 0x3C
	[SerializeField]
	private bool m_RemoveStartOffset; //Field offset: 0x40
	[SerializeField]
	private bool m_ApplyFootIK; //Field offset: 0x41
	[SerializeField]
	private LoopMode m_Loop; //Field offset: 0x44
	[CompilerGenerated]
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; //Field offset: 0x48
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x4C
	[HideInInspector]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[SerializeField]
	private Quaternion m_Rotation; //Field offset: 0x50

	internal AppliedOffsetMode appliedOffsetMode
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public bool applyFootIK
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public AnimationClip clip
	{
		 get { } //Length: 5
		 set { } //Length: 332
	}

	public override ClipCaps clipCaps
	{
		 get { } //Length: 490
	}

	public virtual double duration
	{
		 get { } //Length: 173
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	internal bool hasRootTransforms
	{
		internal get { } //Length: 266
	}

	public LoopMode loop
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public MatchTargetFields matchTargetFields
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public virtual IEnumerable outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__45))]
		 get { } //Length: 175
	}

	public Vector3 position
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public bool removeStartOffset
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Quaternion rotation
	{
		 get { } //Length: 165
		 set { } //Length: 40
	}

	public bool useTrackMatchFields
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private static AnimationPlayableAsset() { }

	public AnimationPlayableAsset() { }

	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop) { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[CompilerGenerated]
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	public bool get_applyFootIK() { }

	public AnimationClip get_clip() { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	public Vector3 get_eulerAngles() { }

	internal bool get_hasRootTransforms() { }

	public LoopMode get_loop() { }

	public MatchTargetFields get_matchTargetFields() { }

	[IteratorStateMachine(typeof(<get_outputs>d__45))]
	public virtual IEnumerable get_outputs() { }

	public Vector3 get_position() { }

	public bool get_removeStartOffset() { }

	public Quaternion get_rotation() { }

	public bool get_useTrackMatchFields() { }

	internal static bool HasRootTransforms(AnimationClip clip) { }

	private void OnUpgradeFromVersion(int oldVersion) { }

	public void ResetOffsets() { }

	[CompilerGenerated]
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	public void set_applyFootIK(bool value) { }

	public void set_clip(AnimationClip value) { }

	public void set_eulerAngles(Vector3 value) { }

	public void set_loop(LoopMode value) { }

	public void set_matchTargetFields(MatchTargetFields value) { }

	public void set_position(Vector3 value) { }

	public void set_removeStartOffset(bool value) { }

	public void set_rotation(Quaternion value) { }

	public void set_useTrackMatchFields(bool value) { }

	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

