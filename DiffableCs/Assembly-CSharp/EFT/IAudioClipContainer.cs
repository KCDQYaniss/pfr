namespace EFT;

public interface IAudioClipContainer
{

	public bool IsValid
	{
		 get { } //Length: 0
	}

	public bool get_IsValid() { }

	public AudioClip GetClip() { }

	public int GetMaxDistance() { }

	public float GetVolume() { }

}

