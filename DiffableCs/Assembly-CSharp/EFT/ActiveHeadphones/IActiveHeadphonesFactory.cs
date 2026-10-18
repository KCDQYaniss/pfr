namespace EFT.ActiveHeadphones;

public interface IActiveHeadphonesFactory
{

	public IActiveHeadphones CreateHeadphones(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

}

