namespace UnityEngine.Timeline;

[NotKeyable]
public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
{
	[CompilerGenerated]
	private sealed class <GetControlableScripts>d__39 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MonoBehaviour <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private GameObject root; //Field offset: 0x28
		public GameObject <>3__root; //Field offset: 0x30
		private MonoBehaviour[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40

		private override MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetControlableScripts>d__39(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator() { }

		[DebuggerHidden]
		private override MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int k_MaxRandInt = 10000; //Field offset: 0x0
	private static readonly List k_EmptyDirectorsList; //Field offset: 0x0
	private static readonly List k_EmptyParticlesList; //Field offset: 0x8
	private static readonly HashSet s_SubEmitterCollector; //Field offset: 0x10
	private static HashSet s_ProcessedDirectors; //Field offset: 0x18
	private static HashSet s_CreatedPrefabs; //Field offset: 0x20
	[SerializeField]
	public ExposedReference sourceGameObject; //Field offset: 0x18
	[SerializeField]
	public GameObject prefabGameObject; //Field offset: 0x28
	[SerializeField]
	public bool updateParticle; //Field offset: 0x30
	[SerializeField]
	public uint particleRandomSeed; //Field offset: 0x34
	[SerializeField]
	public bool updateDirector; //Field offset: 0x38
	[SerializeField]
	public bool updateITimeControl; //Field offset: 0x39
	[SerializeField]
	public bool searchHierarchy; //Field offset: 0x3A
	[SerializeField]
	public bool active; //Field offset: 0x3B
	[SerializeField]
	public PostPlaybackState postPlayback; //Field offset: 0x3C
	private PlayableAsset m_ControlDirectorAsset; //Field offset: 0x40
	private double m_Duration; //Field offset: 0x48
	private bool m_SupportLoop; //Field offset: 0x50
	[CompilerGenerated]
	private bool <controllingDirectors>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private bool <controllingParticles>k__BackingField; //Field offset: 0x52

	public override ClipCaps clipCaps
	{
		 get { } //Length: 14
	}

	internal bool controllingDirectors
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal bool controllingParticles
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual double duration
	{
		 get { } //Length: 6
	}

	private static ControlPlayableAsset() { }

	public ControlPlayableAsset() { }

	private static void CacheSubEmitters(ParticleSystem ps, HashSet subEmitters) { }

	private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) { }

	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List playables) { }

	private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List outplayables) { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	public override ClipCaps get_clipCaps() { }

	[CompilerGenerated]
	internal bool get_controllingDirectors() { }

	[CompilerGenerated]
	internal bool get_controllingParticles() { }

	public virtual double get_duration() { }

	internal IList GetComponent(GameObject gameObject) { }

	[IteratorStateMachine(typeof(<GetControlableScripts>d__39))]
	internal static IEnumerable GetControlableScripts(GameObject root) { }

	private IList GetControllableParticleSystems(GameObject go) { }

	private static void GetControllableParticleSystems(Transform t, ICollection roots, HashSet subEmitters) { }

	public void OnEnable() { }

	internal static void PreviewActivation(IPropertyCollector driver, IEnumerable objects) { }

	internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable directors) { }

	internal static void PreviewParticles(IPropertyCollector driver, IEnumerable particles) { }

	internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable scripts) { }

	private static void SearchHierarchyAndConnectControlableScripts(IEnumerable controlableScripts, PlayableGraph graph, List outplayables) { }

	private void SearchHierarchyAndConnectDirector(IEnumerable directors, PlayableGraph graph, List outplayables, bool disableSelfReferences) { }

	private void SearchHierarchyAndConnectParticleSystem(IEnumerable particleSystems, PlayableGraph graph, List outplayables) { }

	[CompilerGenerated]
	private void set_controllingDirectors(bool value) { }

	[CompilerGenerated]
	private void set_controllingParticles(bool value) { }

	internal void UpdateDurationAndLoopFlag(IList directors, IList particleSystems) { }

}

