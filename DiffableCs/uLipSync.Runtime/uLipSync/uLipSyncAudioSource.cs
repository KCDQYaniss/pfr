namespace uLipSync;

[RequireComponent(typeof(AudioSource))]
public class uLipSyncAudioSource : MonoBehaviour
{
	[CompilerGenerated]
	private AudioFilterReadEvent <onAudioFilterRead>k__BackingField; //Field offset: 0x20

	public private AudioFilterReadEvent onAudioFilterRead
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public uLipSyncAudioSource() { }

	[CompilerGenerated]
	public AudioFilterReadEvent get_onAudioFilterRead() { }

	private void OnAudioFilterRead(float[] input, int channels) { }

	[CompilerGenerated]
	private void set_onAudioFilterRead(AudioFilterReadEvent value) { }

}

