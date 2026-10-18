namespace EFT.ActiveHeadphones;

public class ActiveHeadphonesFactory : IActiveHeadphonesFactory
{

	public ActiveHeadphonesFactory() { }

	public override IActiveHeadphones CreateHeadphones(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

}

