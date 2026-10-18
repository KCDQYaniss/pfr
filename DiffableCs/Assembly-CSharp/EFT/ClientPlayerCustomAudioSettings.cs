namespace EFT;

public class ClientPlayerCustomAudioSettings : IPlayerCustomAudioSettings
{
	private readonly BetterAudio _betterAudio; //Field offset: 0x10
	private readonly IPlayer _player; //Field offset: 0x18

	public override EOcclusionTest OcclusionTest
	{
		 get { } //Length: 3
	}

	public ClientPlayerCustomAudioSettings(BetterAudio betterAudio, IPlayer player) { }

	public override EOcclusionTest get_OcclusionTest() { }

	public override AudioMixerGroup GetGunshotGroup() { }

	public override Transform GetOcclusionTransform() { }

	public override AudioMixerGroup GetSpeechGroup(bool isMuffled = false) { }

}

