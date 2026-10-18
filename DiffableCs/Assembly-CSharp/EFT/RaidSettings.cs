namespace EFT;

public sealed class RaidSettings : IRaidSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public RaidSettings raidSettings; //Field offset: 0x10

		public <>c__DisplayClass50_0() { }

		internal bool <ApplyFromBackend>b__0(Location item) { }

	}

	[JsonIgnore]
	public Dictionary SelectedGameModes; //Field offset: 0x10
	[JsonProperty("keyId")]
	public string KeyId; //Field offset: 0x18
	[CompilerGenerated]
	private ESideType <Side>k__BackingField; //Field offset: 0x20
	[JsonProperty("onlinePveRaidStates")]
	private Dictionary _onlinePveRaidStates; //Field offset: 0x28
	[JsonProperty("location")]
	public string LocationId; //Field offset: 0x30
	[JsonProperty("transitionType")]
	public ELocationTransition transitionType; //Field offset: 0x38
	[JsonIgnore]
	public bool isInTransition; //Field offset: 0x3C
	[JsonProperty("timeVariant")]
	public EDateTime SelectedDateTime; //Field offset: 0x40
	[CompilerGenerated]
	private ERaidMode <RaidMode>k__BackingField; //Field offset: 0x44
	[JsonProperty("metabolismDisabled")]
	public bool MetabolismDisabled; //Field offset: 0x48
	[CompilerGenerated]
	private EPlayersSpawnPlace <PlayersSpawnPlace>k__BackingField; //Field offset: 0x4C
	[JsonProperty("timeAndWeatherSettings")]
	public TimeAndWeatherSettings TimeAndWeatherSettings; //Field offset: 0x50
	[JsonProperty("botSettings")]
	public BotControllerSettings BotSettings; //Field offset: 0x70
	[JsonProperty("wavesSettings")]
	public WavesSettings WavesSettings; //Field offset: 0x88
	[JsonProperty("timings")]
	public Dictionary Timings; //Field offset: 0x98
	[JsonIgnore]
	public bool IsPveOffline; //Field offset: 0xA0
	[JsonIgnore]
	private Location _selectedLocation; //Field offset: 0xA8
	private readonly LocationSettings _locationSettings; //Field offset: 0xB0

	public override bool CanShowGroupPreview
	{
		 get { } //Length: 17
	}

	[JsonIgnore]
	public bool IsPmc
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public bool IsScav
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public override bool Local
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public override int MaxGroupCount
	{
		 get { } //Length: 71
	}

	[JsonIgnore]
	public bool OnlinePveRaid
	{
		 get { } //Length: 65
		 set { } //Length: 269
	}

	[JsonProperty("playersSpawnPlace")]
	public override EPlayersSpawnPlace PlayersSpawnPlace
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonProperty("raidMode")]
	public override ERaidMode RaidMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override Location SelectedLocation
	{
		 get { } //Length: 8
		 set { } //Length: 202
	}

	[JsonProperty("side")]
	public override ESideType Side
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RaidSettings() { }

	public RaidSettings(ESideType side, EDateTime selectedDateTime, ERaidMode raidMode) { }

	public RaidSettings(ESideType side, EDateTime selectedDateTime, ERaidMode raidMode, TimeAndWeatherSettings timeAndWeatherSettings, LocationSettings locationSettings) { }

	public void Apply(RaidSettings raidSettings) { }

	public override void ApplyFromBackend(RaidSettings raidSettings) { }

	public void ClearTransit() { }

	public RaidSettings Clone() { }

	private override void EFT.IRaidSettings<EFT.RaidSettings>.Apply(RaidSettings raidSettings) { }

	private override RaidSettings EFT.IRaidSettings<EFT.RaidSettings>.Clone() { }

	public override bool get_CanShowGroupPreview() { }

	public bool get_IsPmc() { }

	public bool get_IsScav() { }

	public override bool get_Local() { }

	public override int get_MaxGroupCount() { }

	public bool get_OnlinePveRaid() { }

	[CompilerGenerated]
	public override EPlayersSpawnPlace get_PlayersSpawnPlace() { }

	[CompilerGenerated]
	public override ERaidMode get_RaidMode() { }

	public override Location get_SelectedLocation() { }

	[CompilerGenerated]
	public override ESideType get_Side() { }

	public override object GetCreateRaidGroupParams() { }

	private string GetLocationIdForPveBool(string originalLocationID, ESideType playerSide) { }

	private string GetLocationIdForPveBool(string originalLocationID) { }

	public override EMatchingStatus GetMatchingStatus(int groupCount, EMatchingType matchingType) { }

	private bool GetOnlinePveRaidState(string locationId) { }

	public override object GetUpdateStatusParams() { }

	public void MarkAsTransit() { }

	public bool NeedToGoOfflineInPve(ESideType playerSide, Location location) { }

	public bool NeedToGoOfflineInPve(ESideType playerSide) { }

	public bool NeedToGoOnlineInPve(ESideType playerSide) { }

	public bool NeedToGoOnlineInPve(ESideType playerSide, Location location) { }

	public void set_OnlinePveRaid(bool value) { }

	[CompilerGenerated]
	public override void set_PlayersSpawnPlace(EPlayersSpawnPlace value) { }

	[CompilerGenerated]
	public void set_RaidMode(ERaidMode value) { }

	public void set_SelectedLocation(Location value) { }

	[CompilerGenerated]
	public void set_Side(ESideType value) { }

	public bool ShouldTransitToLocalRaidInPve(ESideType playerSide, Location location) { }

	public void UpdateOnlinePveRaidStates() { }

}

