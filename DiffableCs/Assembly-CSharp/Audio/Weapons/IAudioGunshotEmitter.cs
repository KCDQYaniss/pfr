namespace Audio.Weapons;

public interface IAudioGunshotEmitter : IDisposable
{

	public bool HasPendingFades
	{
		 get { } //Length: 0
	}

	public double LastScheduledDspTime
	{
		 get { } //Length: 0
	}

	public void EnabledOcclusion(bool enabled) { }

	public void EnabledReverb(bool enabled) { }

	public bool get_HasPendingFades() { }

	public double get_LastScheduledDspTime() { }

	public void RegisterInOcclusionProcess(IObserverToPlayerBridge playerBridge) { }

	public void Reset() { }

	public void ScheduleShotSound(ShotPlaybackContext playbackContext) { }

	public void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public void Tick(double dspNow) { }

}

