namespace CommonAssets.Scripts.Interactive.Sound;

public class LoopLampSoundController : BaseLampSoundController
{
	private readonly AudioSource _source; //Field offset: 0x28
	private BetterSource _sourceWrapper; //Field offset: 0x30
	private Action _unsubscribeOnDestroy; //Field offset: 0x38

	public virtual bool Enabled
	{
		 get { } //Length: 270
	}

	public virtual bool IsLoop
	{
		 get { } //Length: 90
	}

	public virtual bool IsPlaying
	{
		 get { } //Length: 267
	}

	public LoopLampSoundController(AudioSource source, GameObject lampGo, int rolloff) { }

	public virtual void ContinuePlay() { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	public virtual bool get_Enabled() { }

	public virtual bool get_IsLoop() { }

	public virtual bool get_IsPlaying() { }

	protected virtual void OnLoopPlay(AudioClip clip, float volume) { }

	private void OnSpatialSystemInit(SpatialAudioSystemInitializedEvent initializedEvent) { }

	private void RegisterInOcclusion() { }

	public virtual void Release() { }

	public virtual void SetPitch(int seed, float pitch) { }

	public virtual void Stop() { }

	private void Unsubscribe() { }

}

