namespace EFT;

public class ProfileInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__52_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetBan>b__52_0(ProfileBan x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public EBanType type; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal bool <RemoveBanSilently>b__0(ProfileBan x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public ProfileInfo <>4__this; //Field offset: 0x10
		public ProfileBan ban; //Field offset: 0x18

		public <>c__DisplayClass57_0() { }

		internal void <SubscribeOnBanExpired>b__0() { }

	}

	public string Nickname; //Field offset: 0x10
	public double SavageLockTime; //Field offset: 0x18
	public EGameMode SelectedPrestigeGameMode; //Field offset: 0x20
	public Dictionary PrestigeLevels; //Field offset: 0x28
	public string EntryPoint; //Field offset: 0x30
	public long NicknameChangeDate; //Field offset: 0x38
	public bool GroupInviteRestriction; //Field offset: 0x40
	public EMemberCategory SelectedMemberCategory; //Field offset: 0x44
	public readonly string MainProfileNickname; //Field offset: 0x48
	[CompilerGenerated]
	private EPlayerSide <Side>k__BackingField; //Field offset: 0x50
	public readonly int RegistrationDate; //Field offset: 0x54
	public string GroupId; //Field offset: 0x58
	public string TeamId; //Field offset: 0x60
	public readonly string GameVersion; //Field offset: 0x68
	public readonly EProfileType Type; //Field offset: 0x70
	public readonly bool HasCoopExtension; //Field offset: 0x74
	public readonly bool HasPveGame; //Field offset: 0x75
	public readonly bool LockedMoveCommands; //Field offset: 0x76
	public readonly bool IsStreamerModeAvailable; //Field offset: 0x77
	public readonly string OperatorAccountId; //Field offset: 0x78
	public readonly string[] CandidateAccountIds; //Field offset: 0x80
	private readonly List _bans; //Field offset: 0x88
	[CompilerGenerated]
	private ProfileSettings <Settings>k__BackingField; //Field offset: 0x90
	public readonly EMemberCategory MemberCategory; //Field offset: 0x98
	private int _experience; //Field offset: 0x9C
	[CompilerGenerated]
	private Action OnBanChanged; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnExperienceChanged; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnLevelChanged; //Field offset: 0xB0

	public event Action OnBanChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnExperienceChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnLevelChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public int Experience
	{
		 get { } //Length: 7
		 set { } //Length: 173
	}

	public int Level
	{
		 get { } //Length: 13
	}

	public int SelectedPrestigeLevel
	{
		 get { } //Length: 15
	}

	public ProfileSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public EPlayerSide Side
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ProfileInfo(ProfileInfoDescriptor descriptor) { }

	[CompilerGenerated]
	public void add_OnBanChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnExperienceChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnLevelChanged(Action value) { }

	public void AddBan(EBanType type, long dateTime) { }

	private void BanExpirationHandler(ProfileBan ban) { }

	public int get_Experience() { }

	public int get_Level() { }

	public int get_SelectedPrestigeLevel() { }

	[CompilerGenerated]
	public ProfileSettings get_Settings() { }

	[CompilerGenerated]
	public EPlayerSide get_Side() { }

	public ProfileBan GetBan(EBanType type) { }

	public static int GetExperience(int level) { }

	public static int GetLevel(int experience) { }

	public int GetPrestigeLevel(EGameMode gameMode) { }

	public static int GetPrestigeLevel(Dictionary levels, EGameMode gameMode) { }

	[CompilerGenerated]
	public void remove_OnBanChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnExperienceChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnLevelChanged(Action value) { }

	public void RemoveBan(EBanType type) { }

	private void RemoveBan(ProfileBan ban) { }

	private bool RemoveBanSilently(EBanType type) { }

	public void set_Experience(int value) { }

	[CompilerGenerated]
	protected void set_Settings(ProfileSettings value) { }

	[CompilerGenerated]
	protected void set_Side(EPlayerSide value) { }

	private void SubscribeOnBanExpired(ProfileBan ban) { }

}

