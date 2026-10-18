namespace JsonType;

public sealed class HealthEffectSpecification : ISpecification
{
	[JsonProperty("delay")]
	public float Delay; //Field offset: 0x10
	[JsonProperty("duration")]
	public float Duration; //Field offset: 0x14
	[CompilerGenerated]
	private float <Value>k__BackingField; //Field offset: 0x18

	[JsonProperty("value")]
	public override float Value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public HealthEffectSpecification() { }

	public HealthEffectSpecification CutPiece(float piece) { }

	[CompilerGenerated]
	public override float get_Value() { }

	public override string GetFullStringValue(string displayName) { }

	public override string GetStringValue(string postfix = "") { }

	[CompilerGenerated]
	public override void set_Value(float value) { }

}

