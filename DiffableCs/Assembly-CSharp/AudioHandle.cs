//Type is in global namespace

[IsReadOnly]
public struct AudioHandle
{
	private readonly BetterSource _source; //Field offset: 0x0
	private readonly uint _generation; //Field offset: 0x8

	public static AudioHandle Invalid
	{
		 get { } //Length: 34
	}

	public bool IsValid
	{
		 get { } //Length: 416
	}

	public BetterSource Source
	{
		 get { } //Length: 37
	}

	internal AudioHandle(BetterSource source) { }

	public bool FadeIn(float time, Action onDone = null) { }

	public bool FadeOut(float time, Action onDone = null) { }

	public static AudioHandle get_Invalid() { }

	public bool get_IsValid() { }

	public BetterSource get_Source() { }

	public void Release() { }

	public void SetBaseVolume(float volume) { }

	public void SetPitch(float pitch) { }

	public void StartTracking(Transform target, Vector3 positionOffset = null) { }

	public void Stop(float fadeOut = 0) { }

	public void StopTracking() { }

}

