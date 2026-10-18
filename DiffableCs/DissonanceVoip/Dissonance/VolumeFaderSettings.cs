namespace Dissonance;

public class VolumeFaderSettings
{
	[SerializeField]
	private float _volume; //Field offset: 0x10
	[SerializeField]
	private long _fadeInTicks; //Field offset: 0x18
	[SerializeField]
	private long _fadeOutTicks; //Field offset: 0x20

	public TimeSpan FadeIn
	{
		 get { } //Length: 5
		 set { } //Length: 85
	}

	public TimeSpan FadeOut
	{
		 get { } //Length: 5
		 set { } //Length: 85
	}

	public float Volume
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public VolumeFaderSettings() { }

	public TimeSpan get_FadeIn() { }

	public TimeSpan get_FadeOut() { }

	public float get_Volume() { }

	public void set_FadeIn(TimeSpan value) { }

	public void set_FadeOut(TimeSpan value) { }

	public void set_Volume(float value) { }

}

