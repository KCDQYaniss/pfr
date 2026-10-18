namespace CommonAssets.Scripts.Interactive.Sound;

public class BaseLampSoundController : ILampSoundController, IDisposable
{
	private const int MAX_LOOP_SOURCE_ROLLOFF = 20; //Field offset: 0x0
	protected readonly GameObject LampGo; //Field offset: 0x10
	protected readonly int Rolloff; //Field offset: 0x18
	protected readonly Vector3 LocalPositionOffset; //Field offset: 0x1C

	public override bool Enabled
	{
		 get { } //Length: 3
	}

	public override bool IsLoop
	{
		 get { } //Length: 3
	}

	public override bool IsPlaying
	{
		 get { } //Length: 3
	}

	public BaseLampSoundController(GameObject lampGo, int rolloff) { }

	public override void ContinuePlay() { }

	public override void Dispose() { }

	public override bool get_Enabled() { }

	public override bool get_IsLoop() { }

	public override bool get_IsPlaying() { }

	protected override void OnLoopPlay(AudioClip clip, float volume) { }

	public override void Play(AudioClip clip, float volume, bool loop = false) { }

	private void PlayAtPoint(AudioClip clip, Vector3 position, float volume) { }

	public override void Release() { }

	public override void SetPitch(int seed, float pitch) { }

	public override void Stop() { }

}

