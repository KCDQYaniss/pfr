namespace Dissonance.Audio.Capture;

internal interface IPreprocessingPipeline : IDisposable, IMicrophoneSubscriber
{

	public float Amplitude
	{
		 get { } //Length: 0
	}

	public bool IsOutputMuted
	{
		 set { } //Length: 0
	}

	public WaveFormat OutputFormat
	{
		 get { } //Length: 0
	}

	public int OutputFrameSize
	{
		 get { } //Length: 0
	}

	public TimeSpan UpstreamLatency
	{
		 set { } //Length: 0
	}

	public float get_Amplitude() { }

	public WaveFormat get_OutputFormat() { }

	public int get_OutputFrameSize() { }

	public void set_IsOutputMuted(bool value) { }

	public void set_UpstreamLatency(TimeSpan value) { }

	public void Start() { }

	public void Subscribe(IMicrophoneSubscriber listener) { }

	public void Subscribe(IVoiceActivationListener listener) { }

	public bool Unsubscribe(IMicrophoneSubscriber listener) { }

	public bool Unsubscribe(IVoiceActivationListener listener) { }

}

