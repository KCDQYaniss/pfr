namespace Cutscene;

public class BaseCutsceneTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private Action OnPlayerCausesCutscene; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnCutsceneEnded; //Field offset: 0x28
	[ReadOnlyInInspector]
	[SerializeField]
	private int _cutsceneID; //Field offset: 0x30
	[ReadOnlyInInspector]
	[SerializeField]
	private Vector3 _startPosition; //Field offset: 0x34
	[ReadOnlyInInspector]
	[SerializeField]
	private Vector3 _startViewDirection; //Field offset: 0x40
	[ReadOnlyInInspector]
	[SerializeField]
	private float _startPlayerPosLevel; //Field offset: 0x4C
	[ReadOnlyInInspector]
	[SerializeField]
	private bool _needToProneAtStart; //Field offset: 0x50
	[ReadOnlyInInspector]
	[SerializeField]
	private Vector3 _cutsceneEndPlayerPosition; //Field offset: 0x54
	public CutsceneFakePlayerSteps fakePlayerSteps; //Field offset: 0x60
	[SerializeField]
	private TimelineAsset _timelineAsset; //Field offset: 0x68
	[SerializeField]
	private bool _callServerTeleportOnEnd; //Field offset: 0x70
	private Player _playerCausedCutscene; //Field offset: 0x78

	public event Action OnCutsceneEnded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPlayerCausesCutscene
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Vector3 CutsceneEndPlayerPosition
	{
		 get { } //Length: 19
	}

	public int CutsceneID
	{
		 get { } //Length: 4
	}

	public bool NeedToProneAtStart
	{
		 get { } //Length: 5
	}

	public float StartPlayerPosLevel
	{
		 get { } //Length: 6
	}

	public Vector3 StartPosition
	{
		 get { } //Length: 19
	}

	public Vector3 StartViewDirection
	{
		 get { } //Length: 19
	}

	public TimelineAsset TimeLineAsset
	{
		 get { } //Length: 5
	}

	public BaseCutsceneTrigger() { }

	[CompilerGenerated]
	public void add_OnCutsceneEnded(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerCausesCutscene(Action value) { }

	protected override void Awake() { }

	public void CallEndCutscene() { }

	public void CallStartCutscene(IPlayer player) { }

	public Vector3 get_CutsceneEndPlayerPosition() { }

	public int get_CutsceneID() { }

	public bool get_NeedToProneAtStart() { }

	public float get_StartPlayerPosLevel() { }

	public Vector3 get_StartPosition() { }

	public Vector3 get_StartViewDirection() { }

	public TimelineAsset get_TimeLineAsset() { }

	[CompilerGenerated]
	public void remove_OnCutsceneEnded(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerCausesCutscene(Action value) { }

}

