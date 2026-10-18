namespace EFT.SeasonalPerks;

public interface ISeasonalPerk
{

	public string DescriptionLocalizationKey
	{
		 get { } //Length: 0
	}

	public IEnumerable Effects
	{
		 get { } //Length: 0
	}

	public MongoID Id
	{
		 get { } //Length: 0
	}

	public bool IsCommon
	{
		 get { } //Length: 0
	}

	public string NameLocalizationKey
	{
		 get { } //Length: 0
	}

	public SeasonalPerkData Template
	{
		 get { } //Length: 0
	}

	public string get_DescriptionLocalizationKey() { }

	public IEnumerable get_Effects() { }

	public MongoID get_Id() { }

	public bool get_IsCommon() { }

	public string get_NameLocalizationKey() { }

	public SeasonalPerkData get_Template() { }

}

