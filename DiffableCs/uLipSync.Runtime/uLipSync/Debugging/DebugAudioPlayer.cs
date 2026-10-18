namespace uLipSync.Debugging;

public class DebugAudioPlayer : MonoBehaviour
{
	public string directory; //Field offset: 0x20
	private bool _isNewClipSet; //Field offset: 0x28
	private AudioClip _newClip; //Field offset: 0x30

	public AudioClip newClip
	{
		 get { } //Length: 76
		 set { } //Length: 92
	}

	public DebugAudioPlayer() { }

	public AudioClip get_newClip() { }

	public void set_newClip(AudioClip value) { }

	private void Update() { }

}

