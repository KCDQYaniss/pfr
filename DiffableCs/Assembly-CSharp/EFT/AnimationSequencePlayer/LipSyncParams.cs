namespace EFT.AnimationSequencePlayer;

public sealed class LipSyncParams : SequenceKeyWithParams
{
	[CompilerGenerated]
	private string <Key>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <Volume>k__BackingField; //Field offset: 0x28

	[JsonProperty("lipSyncId")]
	public virtual string Key
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonProperty("volume")]
	public float Volume
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public LipSyncParams() { }

	[CompilerGenerated]
	public virtual string get_Key() { }

	[CompilerGenerated]
	public float get_Volume() { }

	[CompilerGenerated]
	public virtual void set_Key(string value) { }

	[CompilerGenerated]
	public void set_Volume(float value) { }

}

