namespace Audio.AmbientSubsystem;

public class AudioMixerParamsController : IDisposable
{
	private readonly IEnvironmentMixerParamsHandler[] _mixerParamsHandlers; //Field offset: 0x10
	private Action _unsubscribeOnDestroy; //Field offset: 0x18
	private EAudioRoomTypeMask _prevRoomType; //Field offset: 0x20

	public AudioMixerParamsController(IEnvironmentMixerParamsHandler[] paramsHandlers) { }

	private void ApplyInitialRoom() { }

	private void ApplyMixerParams(EAudioRoomTypeMask roomTypeMask) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	private void PlayerChangedRoomEventHandler(MyPlayerRoomChangedEvent changedEvent) { }

}

