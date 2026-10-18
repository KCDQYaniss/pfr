namespace Audio.AutoPanner;

public interface ISoundPanner
{

	public float CurrentPan
	{
		 get { } //Length: 0
	}

	public float get_CurrentPan() { }

	public void SetPan(float value) { }

}

