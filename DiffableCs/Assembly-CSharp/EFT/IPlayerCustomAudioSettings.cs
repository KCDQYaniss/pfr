namespace EFT;

public interface IPlayerCustomAudioSettings
{

	public EOcclusionTest OcclusionTest
	{
		 get { } //Length: 0
	}

	public EOcclusionTest get_OcclusionTest() { }

	public AudioMixerGroup GetGunshotGroup() { }

	public Transform GetOcclusionTransform() { }

	public AudioMixerGroup GetSpeechGroup(bool isMuffled = false) { }

}

