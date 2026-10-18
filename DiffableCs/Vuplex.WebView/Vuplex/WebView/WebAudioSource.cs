namespace Vuplex.WebView;

public class WebAudioSource : MonoBehaviour
{
	[CompilerGenerated]
	private AudioSource <AudioSource>k__BackingField; //Field offset: 0x20
	private bool _applicationPaused; //Field offset: 0x28
	private bool _audioSourceActiveAndEnabled; //Field offset: 0x29
	private int _browserChannelsCount; //Field offset: 0x2C
	private List[] _queuedAudio; //Field offset: 0x30
	private IWithAudioStream _webView; //Field offset: 0x38

	public private AudioSource AudioSource
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private void _clearAudioFramesQueue() { }

	public WebAudioSource() { }

	[CompilerGenerated]
	public AudioSource get_AudioSource() { }

	public void InitWithWebView(IWithAudioStream webView) { }

	private void OnApplicationPause(bool paused) { }

	private void OnAudioFilterRead(float[] unityData, int unityChannelsCount) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	[CompilerGenerated]
	private void set_AudioSource(AudioSource value) { }

	private void Update() { }

	private void WebView_AudioStreamPacketReceived(IWithAudioStream webView, float[][] audioBuffers, int framesCount, int channelsCount) { }

}

