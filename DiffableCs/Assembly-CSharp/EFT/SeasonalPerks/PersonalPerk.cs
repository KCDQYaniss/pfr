namespace EFT.SeasonalPerks;

public sealed class PersonalPerk : SeasonalPerk
{
	public readonly int Points; //Field offset: 0x38
	private readonly HashSet _conflictingPerks; //Field offset: 0x40

	public IEnumerable ConflictingPerks
	{
		 get { } //Length: 5
	}

	public virtual bool IsCommon
	{
		 get { } //Length: 3
	}

	public bool Positive
	{
		 get { } //Length: 8
	}

	public PersonalPerk(PersonalPerkData template, IEnumerable allPerks, SeasonalPerkEffectParametersData effectParameters) { }

	public IEnumerable get_ConflictingPerks() { }

	public virtual bool get_IsCommon() { }

	public bool get_Positive() { }

}

