namespace EFT.AnimationSequencePlayer;

[JsonObject(MemberSerialization::OptIn (1))]
public abstract class SequenceParams
{
	[CompilerGenerated]
	private float <Start>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <End>k__BackingField; //Field offset: 0x14

	[JsonProperty("end")]
	public float End
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("start")]
	public float Start
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected SequenceParams() { }

	[CompilerGenerated]
	public float get_End() { }

	[CompilerGenerated]
	public float get_Start() { }

	[CompilerGenerated]
	public void set_End(float value) { }

	[CompilerGenerated]
	public void set_Start(float value) { }

}

