namespace EFT.UI;

public sealed class SeasonRankReward : ISeasonalReward
{
	[CompilerGenerated]
	private readonly MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Claimed>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly bool <Locked>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	private readonly ImageData <Icon>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ImageData <Image>k__BackingField; //Field offset: 0x38
	private readonly SeasonRankRewardData _template; //Field offset: 0x40
	private Nullable _sides; //Field offset: 0x48

	public override bool Claimed
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override ImageData Icon
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public override MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public override ImageData Image
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override RewardLocation Location
	{
		 get { } //Length: 33
	}

	public bool Locked
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string NameLocalizationKey
	{
		 get { } //Length: 225
	}

	public override PrestigeReward PrestigeReward
	{
		 get { } //Length: 27
	}

	public EPlayerSide Sides
	{
		 get { } //Length: 177
	}

	public SeasonRankReward(SeasonRankRewardData template, bool claimed, bool locked) { }

	public SeasonRankReward Copy() { }

	[CompilerGenerated]
	public override bool get_Claimed() { }

	[CompilerGenerated]
	public override ImageData get_Icon() { }

	[CompilerGenerated]
	public override MongoID get_Id() { }

	[CompilerGenerated]
	public override ImageData get_Image() { }

	public override RewardLocation get_Location() { }

	[CompilerGenerated]
	public bool get_Locked() { }

	public override string get_NameLocalizationKey() { }

	public override PrestigeReward get_PrestigeReward() { }

	public EPlayerSide get_Sides() { }

}

