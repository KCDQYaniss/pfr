namespace ChatShared;

public sealed class UpdatableChatMember : IUpdatable
{
	internal class UpdatableChatMemberInfo
	{
		public string Nickname; //Field offset: 0x10
		public EChatMemberSide Side; //Field offset: 0x18
		public int Level; //Field offset: 0x1C
		public int PrestigeLevel; //Field offset: 0x20
		public EGameMode PrestigeGameMode; //Field offset: 0x24
		public EMemberCategory MemberCategory; //Field offset: 0x28
		public EMemberCategory SelectedMemberCategory; //Field offset: 0x2C
		public bool Ignored; //Field offset: 0x30
		public bool Banned; //Field offset: 0x31
		public bool SteamLinked; //Field offset: 0x32

		public bool IsTrader
		{
			 get { } //Length: 17
		}

		public UpdatableChatMemberInfo() { }

		public bool get_IsTrader() { }

	}

	private string _id; //Field offset: 0x10
	public string AccountId; //Field offset: 0x18
	private UpdatableChatMemberInfo _info; //Field offset: 0x20
	public BindableEvent OnIgnoreStatusChanged; //Field offset: 0x28
	public BindableEvent OnPlayerBanStatusChanged; //Field offset: 0x30
	public BindableEvent OnPinStatusChanged; //Field offset: 0x38
	[CompilerGenerated]
	private bool <Pinned>k__BackingField; //Field offset: 0x40

	public bool HasNickname
	{
		 get { } //Length: 47
	}

	public string Id
	{
		 get { } //Length: 5
	}

	public UpdatableChatMemberInfo Info
	{
		 get { } //Length: 5
	}

	public string LocalizedNickname
	{
		 get { } //Length: 257
	}

	public private bool Pinned
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public UpdatableChatMember(string id) { }

	public override bool Compare(UpdatableChatMember other) { }

	public static UpdatableChatMember FindOrCreate(string id, Func constructor) { }

	public bool get_HasNickname() { }

	public string get_Id() { }

	public UpdatableChatMemberInfo get_Info() { }

	public string get_LocalizedNickname() { }

	[CompilerGenerated]
	public bool get_Pinned() { }

	[CompilerGenerated]
	private void set_Pinned(bool value) { }

	public void SetBanStatus(bool status) { }

	public void SetCategory(EMemberCategory category) { }

	public void SetIgnoreStatus(bool status) { }

	public void SetNickname(string nickname) { }

	public void SetPinned(bool pinned) { }

	public override void UpdateFromAnotherItem(UpdatableChatMember other) { }

	public void UpdateFromChatMember(ChatRoomMember member) { }

	public void UpdateFromMerchant(Merchant merchant) { }

	public void UpdateFromTrader(TraderSettings traderSettings) { }

}

