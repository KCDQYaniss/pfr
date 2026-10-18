namespace EFT;

public class BaseSpeaker
{
	private sealed class SpeakerLogger : AbstractLogger
	{
		private static SpeakerLogger _instance; //Field offset: 0x0

		public static SpeakerLogger Instance
		{
			 get { } //Length: 311
		}

		private SpeakerLogger() { }

		public static SpeakerLogger get_Instance() { }

	}

	private const float BUFFER_TIME = 0.1; //Field offset: 0x0
	public readonly Dictionary PhrasesBanks; //Field offset: 0x10
	public bool OnDemandOnly; //Field offset: 0x18
	public float ReleaseTime; //Field offset: 0x1C
	public bool Speaking; //Field offset: 0x20
	public EPhraseTrigger QueuedEvent; //Field offset: 0x24
	public ETagStatus QueuedTags; //Field offset: 0x28
	public ETagStatus SideTag; //Field offset: 0x2C
	public ETagFilter QueuedTagFilter; //Field offset: 0x30
	public float QueuedDelay; //Field offset: 0x34
	[CompilerGenerated]
	private Action OnPhraseTold; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnRelease; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnPhraseInterrupted; //Field offset: 0x48
	public TaggedClip Clip; //Field offset: 0x50
	public BifacialTransform TrackTransform; //Field offset: 0x58
	private int _importance; //Field offset: 0x60
	private int _blockCounter; //Field offset: 0x64
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private string <PlayerVoice>k__BackingField; //Field offset: 0x70

	public event Action OnPhraseInterrupted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPhraseTold
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnRelease
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool Busy
	{
		 get { } //Length: 86
	}

	public private int Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int Importance
	{
		 get { } //Length: 4
	}

	public bool IsBlocked
	{
		 get { } //Length: 8
	}

	private static SpeakerLogger Logger
	{
		private get { } //Length: 311
	}

	public private string PlayerVoice
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float TimeLeft
	{
		 get { } //Length: 91
	}

	public BaseSpeaker() { }

	[CompilerGenerated]
	public void add_OnPhraseInterrupted(Action value) { }

	[CompilerGenerated]
	public void add_OnPhraseTold(Action value) { }

	[CompilerGenerated]
	public void add_OnRelease(Action value) { }

	public void Block() { }

	public bool get_Busy() { }

	[CompilerGenerated]
	public int get_Id() { }

	public int get_Importance() { }

	public bool get_IsBlocked() { }

	private static SpeakerLogger get_Logger() { }

	[CompilerGenerated]
	public string get_PlayerVoice() { }

	public float get_TimeLeft() { }

	public override void Init(EPlayerSide side, int id, string playerVoice, bool registerInSpeakerManager = true) { }

	public void ManualUpdate(float dt) { }

	public void OnDestroy() { }

	[CanBeNull]
	public TagBank Play(EPhraseTrigger trigger, ETagStatus tags, bool demand = false, Nullable importance = null, ETagFilter tagFilter = 0) { }

	public void PlayDirect(EPhraseTrigger trigger, int index) { }

	public void PlayDirectRandom(EPhraseTrigger trigger) { }

	public void PlayExternal(TagBank bank, EPhraseTrigger trigger, ETagStatus tags, Nullable importance = null, ETagFilter tagFilter = 0) { }

	public void Queue(EPhraseTrigger trigger, ETagStatus tags, float delay, bool demand, ETagFilter tagFilter = 0) { }

	[CompilerGenerated]
	public void remove_OnPhraseInterrupted(Action value) { }

	[CompilerGenerated]
	public void remove_OnPhraseTold(Action value) { }

	[CompilerGenerated]
	public void remove_OnRelease(Action value) { }

	public void ReplaceVoice(EPlayerSide side, string playerVoice) { }

	[CompilerGenerated]
	private void set_Id(int value) { }

	[CompilerGenerated]
	private void set_PlayerVoice(string value) { }

	public void Shut() { }

	[CanBeNull]
	public TaggedClip TryGetTaggedClip(EPhraseTrigger trigger, ETagStatus tags, ETagFilter tagFilter = 0) { }

	public void Unblock() { }

}

