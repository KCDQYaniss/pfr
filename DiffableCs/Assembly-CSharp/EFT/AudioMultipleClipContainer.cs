namespace EFT;

public class AudioMultipleClipContainer : IAudioClipContainer
{
	[SerializeField]
	private AudioClip[] _clips; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	private float _volume; //Field offset: 0x18
	[SerializeField]
	private int _maxDistance; //Field offset: 0x1C
	private ShuffledClipIndexState _shuffleState; //Field offset: 0x20

	public override bool IsValid
	{
		 get { } //Length: 22
	}

	public AudioMultipleClipContainer() { }

	private override AudioClip EFT.IAudioClipContainer.GetClip() { }

	public override bool get_IsValid() { }

	public AudioClip GetClip(bool shuffleWithoutRepeat = false) { }

	public override int GetMaxDistance() { }

	public override float GetVolume() { }

	public void ResetClipSelection() { }

}

