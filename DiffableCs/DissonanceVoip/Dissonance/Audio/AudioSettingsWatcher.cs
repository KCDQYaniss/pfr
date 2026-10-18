namespace Dissonance.Audio;

internal class AudioSettingsWatcher
{
	private static readonly AudioSettingsWatcher Singleton; //Field offset: 0x0
	private readonly object _lock; //Field offset: 0x10
	private bool _started; //Field offset: 0x18
	private AudioConfiguration _config; //Field offset: 0x1C

	public AudioConfiguration Configuration
	{
		 get { } //Length: 285
	}

	public static AudioSettingsWatcher Instance
	{
		 get { } //Length: 83
	}

	private static AudioSettingsWatcher() { }

	public AudioSettingsWatcher() { }

	public AudioConfiguration get_Configuration() { }

	public static AudioSettingsWatcher get_Instance() { }

	private void OnAudioConfigChanged(bool devicewaschanged) { }

	internal void Start() { }

}

