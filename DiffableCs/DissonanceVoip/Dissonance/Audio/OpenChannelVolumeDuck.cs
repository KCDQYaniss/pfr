namespace Dissonance.Audio;

public class OpenChannelVolumeDuck : IVolumeProvider
{
	public const float FadeDurationSecondsDown = 0.3; //Field offset: 0x0
	public const float FadeDurationSecondsUp = 0.5; //Field offset: 0x0
	private readonly RoomChannels _rooms; //Field offset: 0x10
	private readonly PlayerChannels _players; //Field offset: 0x18
	private Fader _fader; //Field offset: 0x20

	public override float TargetVolume
	{
		 get { } //Length: 6
	}

	public OpenChannelVolumeDuck(RoomChannels rooms, PlayerChannels players) { }

	public override float get_TargetVolume() { }

	public void Update(bool isMuted, float dt) { }

}

