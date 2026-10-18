namespace EFT;

public sealed class OtherPlayerProfile : IPlayerProfileDataContainer, IProfileDataContainer
{
	internal sealed class OtherPlayerInfo
	{
		[JsonProperty("Nickname")]
		public string Nickname; //Field offset: 0x10
		[JsonProperty("Side")]
		public EPlayerSide Side; //Field offset: 0x18
		[JsonProperty("Experience")]
		public int Experience; //Field offset: 0x1C
		[JsonProperty("PrestigeLevel")]
		public int PrestigeLevel; //Field offset: 0x20
		[JsonProperty("PrestigeGameMode")]
		public EGameMode PrestigeGameMode; //Field offset: 0x24
		[JsonProperty("leagueRank")]
		public Nullable SeasonRank; //Field offset: 0x28
		[JsonProperty("MemberCategory")]
		public EMemberCategory MemberCategory; //Field offset: 0x30
		[JsonProperty("SelectedMemberCategory")]
		public EMemberCategory SelectedMemberCategory; //Field offset: 0x34
		[JsonProperty("RegistrationDate")]
		public int RegistrationDate; //Field offset: 0x38

		public OtherPlayerInfo() { }

	}

	public readonly string AccountId; //Field offset: 0x10
	public readonly OtherPlayerInfo Info; //Field offset: 0x18
	public readonly SkillManager Skills; //Field offset: 0x20
	public readonly CountersCollection OverallCounters; //Field offset: 0x28
	public readonly Stash FavoriteItems; //Field offset: 0x30
	public readonly InventoryEquipment Equipment; //Field offset: 0x38
	public readonly BodyCustomization Customization; //Field offset: 0x40
	public readonly ItemController ItemController; //Field offset: 0x48
	public readonly IReadOnlyDictionary AchievementsData; //Field offset: 0x50
	public readonly ProfileStatsSeparator PmcStats; //Field offset: 0x58
	public readonly ProfileStatsSeparator ScavStats; //Field offset: 0x60
	public readonly HideoutData HideoutData; //Field offset: 0x68
	public readonly EndingInfo Ending; //Field offset: 0x70
	public readonly PerkManager Perks; //Field offset: 0x78
	public readonly IReadOnlyList BattlePassProgress; //Field offset: 0x80
	public readonly IReadOnlyList SeasonalRewardsProgress; //Field offset: 0x88
	private PlayerVisualRepresentation _playerVisualRepresentation; //Field offset: 0x90

	private override EndingInfo EFT.IPlayerProfileDataContainer.Ending
	{
		private get { } //Length: 5
	}

	private override EGameMode EFT.IPlayerProfileDataContainer.PrestigeGameMode
	{
		private get { } //Length: 26
	}

	public override string Nickname
	{
		 get { } //Length: 27
	}

	public PlayerVisualRepresentation PlayerVisualRepresentation
	{
		 get { } //Length: 546
	}

	public override int PrestigeLevel
	{
		 get { } //Length: 26
	}

	public override string ProfileId
	{
		 get { } //Length: 59
	}

	public int SeasonRank
	{
		 get { } //Length: 65
	}

	public override EPlayerSide Side
	{
		 get { } //Length: 26
	}

	public OtherPlayerProfile(OtherPlayerProfileDescriptor descriptor) { }

	private override EndingInfo EFT.IPlayerProfileDataContainer.get_Ending() { }

	private override EGameMode EFT.IPlayerProfileDataContainer.get_PrestigeGameMode() { }

	public override string get_Nickname() { }

	public PlayerVisualRepresentation get_PlayerVisualRepresentation() { }

	public override int get_PrestigeLevel() { }

	public override string get_ProfileId() { }

	public int get_SeasonRank() { }

	public override EPlayerSide get_Side() { }

}

