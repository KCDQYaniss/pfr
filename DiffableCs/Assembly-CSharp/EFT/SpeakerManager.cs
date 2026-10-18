namespace EFT;

public class SpeakerManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetSpeaker>b__0(BaseSpeaker s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <RemoveFromGroup>b__0(VirtualGroup g) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string groupId; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <AssignToGroup>b__0(VirtualGroup x) { }

	}

	private List Groups; //Field offset: 0x20
	[CompilerGenerated]
	private List <Speakers>k__BackingField; //Field offset: 0x28
	private Dictionary GroupBySpeaker; //Field offset: 0x30
	public BaseSpeaker ClientSpeaker; //Field offset: 0x38

	public private List Speakers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private SpeakerManager() { }

	public VirtualGroup AddNewGroup(string groupId) { }

	public void AddSpeaker(BaseSpeaker speaker) { }

	public void AssignToGroup(EPlayerSide side, Player player) { }

	private void Awake() { }

	public bool FreeToSpeak(EPhraseTrigger trigger, int id) { }

	[CompilerGenerated]
	public List get_Speakers() { }

	public ETagStatus GetGroupStatus(BaseSpeaker speaker) { }

	public BaseSpeaker GetSpeaker(int id) { }

	public void GroupEvent(int speakerId, EPhraseTrigger event, Vector3 position, ETagStatus tags, int probability = 50) { }

	public void ManualUpdate(float dt) { }

	private void OnDestroy() { }

	private void OnPhraseToldEveryone(EPhraseTrigger trigger, TaggedClip clip, TagBank bank, BaseSpeaker speaker) { }

	public void RemoveFromGroup(Player player) { }

	public void RemoveSpeaker(BaseSpeaker speaker) { }

	private bool SameGroup(int id1, int id2) { }

	[CompilerGenerated]
	private void set_Speakers(List value) { }

}

