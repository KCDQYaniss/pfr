namespace EFT;

[GenerateBinarySerialization]
public class ProfileInfoDescriptor
{
	[JsonProperty("Nickname")]
	public string Nickname; //Field offset: 0x10
	[JsonProperty("MainProfileNickname")]
	public string MainProfileNickname; //Field offset: 0x18
	[JsonProperty("Side")]
	public EPlayerSide Side; //Field offset: 0x20
	[JsonProperty("SelectedPrestigeGameMode")]
	public EGameMode SelectedPrestigeGameMode; //Field offset: 0x24
	[JsonProperty("PrestigeLevels")]
	public Dictionary PrestigeLevels; //Field offset: 0x28
	[JsonProperty("RegistrationDate")]
	public int RegistrationDate; //Field offset: 0x30
	[JsonProperty("SavageLockTime")]
	public double SavageLockTime; //Field offset: 0x38
	[JsonProperty("GroupId")]
	public string GroupId; //Field offset: 0x40
	[JsonProperty("TeamId")]
	public string TeamId; //Field offset: 0x48
	[JsonProperty("EntryPoint")]
	public string EntryPoint; //Field offset: 0x50
	[JsonProperty("NicknameChangeDate")]
	public long NicknameChangeDate; //Field offset: 0x58
	[JsonProperty("GameVersion")]
	public string GameVersion; //Field offset: 0x60
	[JsonProperty("Type")]
	public EProfileType Type; //Field offset: 0x68
	[JsonProperty("HasCoopExtension")]
	public bool HasCoopExtension; //Field offset: 0x6C
	[JsonProperty("HasPveGame")]
	public bool HasPveGame; //Field offset: 0x6D
	[JsonProperty("IsStreamerModeAvailable")]
	public bool IsStreamerModeAvailable; //Field offset: 0x6E
	[JsonProperty("SquadInviteRestriction")]
	public bool GroupInviteRestriction; //Field offset: 0x6F
	[JsonProperty("Bans")]
	public List Bans; //Field offset: 0x70
	[JsonProperty("Settings")]
	public ProfileSettings Settings; //Field offset: 0x78
	[JsonProperty("MemberCategory")]
	public EMemberCategory MemberCategory; //Field offset: 0x80
	[JsonProperty("SelectedMemberCategory")]
	public EMemberCategory SelectedMemberCategory; //Field offset: 0x84
	[JsonProperty("Experience")]
	public int Experience; //Field offset: 0x88
	[JsonProperty("Level")]
	public int Level; //Field offset: 0x8C
	[JsonProperty("lockedMoveCommands")]
	public bool LockedMoveCommands; //Field offset: 0x90
	[IgnoreBinarySerialization]
	[JsonIgnore]
	public string OperatorAccountId; //Field offset: 0x98
	[IgnoreBinarySerialization]
	[JsonIgnore]
	public string[] CandidateAccountIds; //Field offset: 0xA0

	public ProfileInfoDescriptor() { }

	public ProfileInfoDescriptor(ProfileInfo profileInfo) { }

}

