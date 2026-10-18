namespace EFT.AnimationSequencePlayer;

public sealed class AnimationParams : SequenceKeyWithParams
{
	[CompilerGenerated]
	private string <Key>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <AnimSpeed>k__BackingField; //Field offset: 0x28

	[JsonProperty("speed")]
	public float AnimSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("animationId")]
	public virtual string Key
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public AnimationParams() { }

	[CompilerGenerated]
	public float get_AnimSpeed() { }

	[CompilerGenerated]
	public virtual string get_Key() { }

	[CompilerGenerated]
	public void set_AnimSpeed(float value) { }

	[CompilerGenerated]
	public virtual void set_Key(string value) { }

}

