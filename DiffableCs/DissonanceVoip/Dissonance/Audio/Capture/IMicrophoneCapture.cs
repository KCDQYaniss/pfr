namespace Dissonance.Audio.Capture;

public interface IMicrophoneCapture
{

	[CanBeNull]
	public string Device
	{
		 get { } //Length: 0
	}

	public bool IsRecording
	{
		 get { } //Length: 0
	}

	public TimeSpan Latency
	{
		 get { } //Length: 0
	}

	public string get_Device() { }

	public bool get_IsRecording() { }

	public TimeSpan get_Latency() { }

	[CanBeNull]
	public WaveFormat StartCapture(string name) { }

	public void StopCapture() { }

	public void Subscribe(IMicrophoneSubscriber listener) { }

	public bool Unsubscribe(IMicrophoneSubscriber listener) { }

	public bool UpdateSubscribers() { }

}

