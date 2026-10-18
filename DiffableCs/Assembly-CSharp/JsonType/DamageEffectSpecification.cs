namespace JsonType;

public sealed class DamageEffectSpecification : ISpecification
{
	[JsonProperty("delay")]
	public float Delay; //Field offset: 0x10
	[JsonProperty("duration")]
	public float Duration; //Field offset: 0x14
	[JsonProperty("fadeOut")]
	public float FadeOut; //Field offset: 0x18
	[JsonProperty("cost")]
	public int Cost; //Field offset: 0x1C
	[JsonProperty("healthPenaltyMin")]
	public int HealthPenaltyMin; //Field offset: 0x20
	[JsonProperty("healthPenaltyMax")]
	public int HealthPenaltyMax; //Field offset: 0x24

	public override float Value
	{
		 get { } //Length: 9
		 set { } //Length: 3
	}

	public DamageEffectSpecification() { }

	public override float get_Value() { }

	public override string GetFullStringValue(string displayName) { }

	public override string GetStringValue(string postfix = "") { }

	public override void set_Value(float value) { }

}

