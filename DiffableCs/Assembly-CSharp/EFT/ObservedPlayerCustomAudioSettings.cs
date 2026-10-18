namespace EFT;

public class ObservedPlayerCustomAudioSettings : IPlayerCustomAudioSettings
{
	private readonly IPlayer _player; //Field offset: 0x10
	private readonly BetterAudio _betterAudio; //Field offset: 0x18
	private readonly SpatialAudioSystem _spatialSystem; //Field offset: 0x20
	private readonly WeaponPlaybackSettings _weaponSettings; //Field offset: 0x28

	public override EOcclusionTest OcclusionTest
	{
		 get { } //Length: 6
	}

	public ObservedPlayerCustomAudioSettings(BetterAudio betterAudio, SpatialAudioSystem spatialSystem, IPlayer player, WeaponPlaybackSettings weaponSettings) { }

	public override EOcclusionTest get_OcclusionTest() { }

	public override AudioMixerGroup GetGunshotGroup() { }

	public override Transform GetOcclusionTransform() { }

	public override AudioMixerGroup GetSpeechGroup(bool isMuffled = false) { }

}

