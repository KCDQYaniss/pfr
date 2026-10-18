namespace Dissonance.Audio;

internal struct Fader
{
	[CompilerGenerated]
	private float <Volume>k__BackingField; //Field offset: 0x0
	private float _fadeTime; //Field offset: 0x4
	[CompilerGenerated]
	private float <EndVolume>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private float <StartVolume>k__BackingField; //Field offset: 0xC
	private float _elapsedTime; //Field offset: 0x10

	public private float EndVolume
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float StartVolume
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float Volume
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private float CalculateVolume() { }

	public void FadeTo(float target, float duration) { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_EndVolume() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_StartVolume() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_Volume() { }

	[CompilerGenerated]
	private void set_EndVolume(float value) { }

	[CompilerGenerated]
	private void set_StartVolume(float value) { }

	[CompilerGenerated]
	private void set_Volume(float value) { }

	public void Update(float dt) { }

}

