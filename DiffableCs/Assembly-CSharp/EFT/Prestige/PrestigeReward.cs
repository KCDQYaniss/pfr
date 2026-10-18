namespace EFT.Prestige;

public sealed class PrestigeReward : QuestReward
{
	[Flags]
	internal enum ERewardGameMode
	{
		EFT_PvP = 1,
		EFT_PvE = 2,
		Arena = 4,
		Season = 8,
	}

	[IsReadOnly]
	internal struct PrestigeRewardExtraData
	{
		[JsonProperty("image")]
		public readonly string IconUrl; //Field offset: 0x0
		[JsonProperty("bigImage")]
		public readonly string ImageUrl; //Field offset: 0x8
		[JsonProperty("isBigImage")]
		public readonly bool IsBigImage; //Field offset: 0x10

		[JsonConstructor]
		public PrestigeRewardExtraData(string iconUrl, string imageUrl, bool isBigImage) { }

	}

	[JsonIgnore]
	public readonly ERewardGameMode GameMode; //Field offset: 0x60
	[CompilerGenerated]
	private ImageData <Icon>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private ImageData <Image>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <IsBigImage>k__BackingField; //Field offset: 0x78
	private PrestigeRewardExtraData _extraDataValue; //Field offset: 0x80
	[JsonProperty("gameMode")]
	private readonly ERewardGameMode[] _gameModes; //Field offset: 0x98

	[JsonProperty("illustrationConfig")]
	private PrestigeRewardExtraData ExtraData
	{
		private get { } //Length: 27
		private set { } //Length: 547
	}

	[JsonIgnore]
	public private ImageData Icon
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public private ImageData Image
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public private bool IsBigImage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonConstructor]
	public PrestigeReward(ERewardType type, ERewardGameMode[] gameModes, PrestigeRewardExtraData extraData, string target, string traderId, int loyaltyLevel, float value, bool findInRaid, FlatItem[] items, bool unknown) { }

	private PrestigeRewardExtraData get_ExtraData() { }

	[CompilerGenerated]
	public ImageData get_Icon() { }

	[CompilerGenerated]
	public ImageData get_Image() { }

	[CompilerGenerated]
	public bool get_IsBigImage() { }

	public EPlayerSide GetRewardSide() { }

	private void set_ExtraData(PrestigeRewardExtraData value) { }

	[CompilerGenerated]
	private void set_Icon(ImageData value) { }

	[CompilerGenerated]
	private void set_Image(ImageData value) { }

	[CompilerGenerated]
	private void set_IsBigImage(bool value) { }

}

