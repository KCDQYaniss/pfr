namespace EFT.SeasonalPerks;

public abstract class SeasonalPerk`1 : ISeasonalPerk
{
	[CompilerGenerated]
	private readonly TTemplate <Template>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly MongoID <Id>k__BackingField; //Field offset: 0x0
	private readonly List _effects; //Field offset: 0x0

	public override string DescriptionLocalizationKey
	{
		 get { } //Length: 225
	}

	public override IEnumerable Effects
	{
		 get { } //Length: 76
	}

	private override SeasonalPerkData EFT.SeasonalPerks.ISeasonalPerk.Template
	{
		private get { } //Length: 5
	}

	public override MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public abstract bool IsCommon
	{
		 get { } //Length: 0
	}

	public override string NameLocalizationKey
	{
		 get { } //Length: 225
	}

	public TTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected SeasonalPerk`1(TTemplate template, SeasonalPerkEffectParametersData effectParameters) { }

	private override SeasonalPerkData EFT.SeasonalPerks.ISeasonalPerk.get_Template() { }

	public override string get_DescriptionLocalizationKey() { }

	public override IEnumerable get_Effects() { }

	[CompilerGenerated]
	public override MongoID get_Id() { }

	public abstract bool get_IsCommon() { }

	public override string get_NameLocalizationKey() { }

	[CompilerGenerated]
	public TTemplate get_Template() { }

}

