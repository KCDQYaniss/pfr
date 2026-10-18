namespace EFT.SeasonalRewards;

public interface ISeasonalReward
{

	public bool Claimed
	{
		 get { } //Length: 0
	}

	public ImageData Icon
	{
		 get { } //Length: 0
	}

	public MongoID Id
	{
		 get { } //Length: 0
	}

	public ImageData Image
	{
		 get { } //Length: 0
	}

	public RewardLocation Location
	{
		 get { } //Length: 0
	}

	public string NameLocalizationKey
	{
		 get { } //Length: 0
	}

	public PrestigeReward PrestigeReward
	{
		 get { } //Length: 0
	}

	public bool get_Claimed() { }

	public ImageData get_Icon() { }

	public MongoID get_Id() { }

	public ImageData get_Image() { }

	public RewardLocation get_Location() { }

	public string get_NameLocalizationKey() { }

	public PrestigeReward get_PrestigeReward() { }

}

