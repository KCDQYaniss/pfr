namespace Audio.AutoPanner;

public class AudioSourcePanner : ISoundPanner
{
	private readonly AudioSource _source; //Field offset: 0x10
	[CompilerGenerated]
	private float <CurrentPan>k__BackingField; //Field offset: 0x18

	public private override float CurrentPan
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public AudioSourcePanner(AudioSource source) { }

	[CompilerGenerated]
	public override float get_CurrentPan() { }

	[CompilerGenerated]
	private void set_CurrentPan(float value) { }

	public override void SetPan(float value) { }

}

