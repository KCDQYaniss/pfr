namespace EFT;

public class AudioSingleClipContainer : IAudioClipContainer
{
	[SerializeField]
	private AudioClip _clip; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	private float _volume; //Field offset: 0x18
	[SerializeField]
	private int _maxDistance; //Field offset: 0x1C

	public override bool IsValid
	{
		 get { } //Length: 203
	}

	public AudioSingleClipContainer() { }

	public override bool get_IsValid() { }

	public override AudioClip GetClip() { }

	public override int GetMaxDistance() { }

	public override float GetVolume() { }

}

