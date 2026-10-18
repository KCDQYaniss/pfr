namespace Audio.SpatialSystem;

public interface ISpatialized
{

	public float DirectivityIntensity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool EnableSpatialization
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float HrtfIntensity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float get_DirectivityIntensity() { }

	public bool get_EnableSpatialization() { }

	public float get_HrtfIntensity() { }

	public void set_DirectivityIntensity(float value) { }

	public void set_EnableSpatialization(bool value) { }

	public void set_HrtfIntensity(float value) { }

}

