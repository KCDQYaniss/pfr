//Type is in global namespace

public class Timer
{
	public float _startTime; //Field offset: 0x10
	private float _pauseTime; //Field offset: 0x14

	public bool IsPaused
	{
		 get { } //Length: 15
	}

	public bool IsStarted
	{
		 get { } //Length: 15
	}

	public float Time
	{
		 get { } //Length: 119
	}

	public Timer(bool instantStart = false) { }

	public bool get_IsPaused() { }

	public bool get_IsStarted() { }

	public float get_Time() { }

	public void SetPause(bool pause) { }

	public void Start(float startTime = 0) { }

	public void Stop() { }

}

