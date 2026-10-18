namespace EFT.Hideout;

public sealed class BodyPartBuffRequirement : Requirement
{
	[JsonProperty("EffectName")]
	private string _effectName; //Field offset: 0x38
	[JsonProperty("BodyPart")]
	private string _bodyPart; //Field offset: 0x40
	[JsonProperty("Excluded")]
	private bool _excluded; //Field offset: 0x48
	private OfflineHealthController _healthController; //Field offset: 0x50

	[JsonIgnore]
	private EBodyPart BodyPart
	{
		private get { } //Length: 358
	}

	public virtual bool Fulfilled
	{
		 get { } //Length: 34
	}

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public BodyPartBuffRequirement() { }

	[CompilerGenerated]
	private bool <HasEffect>b__10_0(IHealthEffect effect) { }

	private EBodyPart get_BodyPart() { }

	public virtual bool get_Fulfilled() { }

	public virtual ERequirementType get_Type() { }

	private bool HasEffect() { }

	public void Test(OfflineHealthController healthController) { }

}

