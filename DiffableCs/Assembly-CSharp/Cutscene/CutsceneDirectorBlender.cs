namespace Cutscene;

public class CutsceneDirectorBlender : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_IsTimelinePlaying>b__3_0(BlendingDirector d) { }

	}

	[SerializeField]
	private List _blendingDirectors; //Field offset: 0x20
	[Header("Debug test loop blending")]
	[SerializeField]
	private bool _playAll; //Field offset: 0x28
	[CompilerGenerated]
	private BlendingDirector <Current>k__BackingField; //Field offset: 0x30
	private Dictionary _directorsByAsset; //Field offset: 0x38
	private Queue _queue; //Field offset: 0x40

	public BlendingDirector Current
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool IsTimelinePlaying
	{
		 get { } //Length: 455
	}

	public CutsceneDirectorBlender() { }

	[CompilerGenerated]
	private bool <Play>b__13_0(TimelineAsset t) { }

	[CompilerGenerated]
	public BlendingDirector get_Current() { }

	public bool get_IsTimelinePlaying() { }

	public void Play(TimelineAsset timeline, bool playImmediately = true, float transitionTime = 0.5) { }

	public void Play(List timelineSequence, bool playImmediately = true, float transitionTime = 0.5) { }

	[CompilerGenerated]
	public void set_Current(BlendingDirector value) { }

	public void Start() { }

	public void Update() { }

}

