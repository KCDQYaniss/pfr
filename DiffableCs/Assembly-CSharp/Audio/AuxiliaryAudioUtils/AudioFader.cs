namespace Audio.AuxiliaryAudioUtils;

public class AudioFader : IDisposable
{
	private float _fadeTime; //Field offset: 0x10
	private float _elapsedTime; //Field offset: 0x14
	[CompilerGenerated]
	private float <Volume>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <EndVolume>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float <StartVolume>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EAudioFadeType <FadeType>k__BackingField; //Field offset: 0x24

	public private float EndVolume
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public EAudioFadeType FadeType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsFading
	{
		 get { } //Length: 32
	}

	public bool IsFadingIn
	{
		 get { } //Length: 43
	}

	public bool IsFadingOut
	{
		 get { } //Length: 43
	}

	public bool IsFinished
	{
		 get { } //Length: 25
	}

	public bool IsSilent
	{
		 get { } //Length: 25
	}

	public private float StartVolume
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float Volume
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public AudioFader() { }

	private float CalculateVolume() { }

	public override void Dispose() { }

	public void FadeTo(float target, float duration) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public float get_EndVolume() { }

	[CompilerGenerated]
	public EAudioFadeType get_FadeType() { }

	public bool get_IsFading() { }

	public bool get_IsFadingIn() { }

	public bool get_IsFadingOut() { }

	public bool get_IsFinished() { }

	public bool get_IsSilent() { }

	[CompilerGenerated]
	public float get_StartVolume() { }

	[CompilerGenerated]
	public float get_Volume() { }

	public float GetRemainingFadeTime() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_EndVolume(float value) { }

	[CompilerGenerated]
	public void set_FadeType(EAudioFadeType value) { }

	[CompilerGenerated]
	private void set_StartVolume(float value) { }

	[CompilerGenerated]
	private void set_Volume(float value) { }

	public void Tick(float dt) { }

}

