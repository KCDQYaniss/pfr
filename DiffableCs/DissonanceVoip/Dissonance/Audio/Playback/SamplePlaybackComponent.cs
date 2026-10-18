namespace Dissonance.Audio.Playback;

public class SamplePlaybackComponent : MonoBehaviour
{
	private static readonly Log Log; //Field offset: 0x0
	private float[] _temp; //Field offset: 0x20
	[CanBeNull]
	private AudioFileWriter _diagnosticOutput; //Field offset: 0x28
	private SessionContext _lastPlayedSessionContext; //Field offset: 0x30
	private readonly ReaderWriterLockSlim _sessionLock; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable <Session>k__BackingField; //Field offset: 0x48
	private float _arv; //Field offset: 0x88

	public float ARV
	{
		 get { } //Length: 14
	}

	public bool HasActiveSession
	{
		 get { } //Length: 51
	}

	public private Nullable Session
	{
		[CompilerGenerated]
		 get { } //Length: 35
		[CompilerGenerated]
		private set { } //Length: 98
	}

	private static SamplePlaybackComponent() { }

	public SamplePlaybackComponent() { }

	private void ApplyReset() { }

	internal static bool Filter(SpeechSession session, float[] output, int channels, float[] temp, AudioFileWriter diagnosticOutput, out float arv) { }

	public float get_ARV() { }

	public bool get_HasActiveSession() { }

	[CompilerGenerated]
	public Nullable get_Session() { }

	public void OnAudioFilterRead(float[] data, int channels) { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void Play(SpeechSession session) { }

	[CompilerGenerated]
	private void set_Session(Nullable value) { }

	public void Start() { }

}

