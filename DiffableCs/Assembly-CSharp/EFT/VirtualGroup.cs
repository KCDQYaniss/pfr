namespace EFT;

public class VirtualGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public BaseSpeaker speaker; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <OnPhraseToldInGroup>b__0(Player member) { }

	}

	public string GroupId; //Field offset: 0x10
	public List Members; //Field offset: 0x18
	public List Blockers; //Field offset: 0x20
	public Action OnEvent; //Field offset: 0x28

	public VirtualGroup() { }

	public ETagStatus GetGroupStatus(BaseSpeaker speaker) { }

	public void OnPhraseToldInGroup(EPhraseTrigger event, TaggedClip clip, TagBank bankPlayed, BaseSpeaker speaker) { }

}

