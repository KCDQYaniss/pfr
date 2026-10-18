namespace EFT;

public class SoundBank : ScriptableObject
{
	public float CustomLength; //Field offset: 0x18
	public float BaseVolume; //Field offset: 0x1C
	public float BasePitch; //Field offset: 0x20
	public float DeltaVolume; //Field offset: 0x24
	public float DeltaPitch; //Field offset: 0x28
	public float Rolloff; //Field offset: 0x2C
	public bool IgnoreOcclusion; //Field offset: 0x30
	public bool Physical; //Field offset: 0x31
	public bool HasEnvironment; //Field offset: 0x32
	private int _maxClipsCount; //Field offset: 0x34
	private int _loadRefs; //Field offset: 0x38
	public AudioSourceGroupType SourceType; //Field offset: 0x3C
	public bool AllowLimitedPlay; //Field offset: 0x40
	public bool LimitIfVisible; //Field offset: 0x41
	public Vector2 LimitRadius; //Field offset: 0x44
	[Range(0, 1)]
	public float LimitPercentOfClip; //Field offset: 0x4C
	[SerializeField]
	private float _clipLiength; //Field offset: 0x50
	public EnvironmentVariety[] Environments; //Field offset: 0x58
	public DistanceBlendOptions BlendOptions; //Field offset: 0x60
	private Nullable _hasDistanceBlend; //Field offset: 0x68
	private ShuffledClipIndexState _shuffleState; //Field offset: 0x70

	public float[] BlendValues
	{
		 get { } //Length: 27
	}

	public float ClipLength
	{
		 get { } //Length: 25
		 set { } //Length: 6
	}

	public bool HasDistanceBlend
	{
		 get { } //Length: 294
	}

	public int MaxClipsCount
	{
		 get { } //Length: 165
	}

	public float RandomPitch
	{
		 get { } //Length: 53
	}

	public float RandomVolume
	{
		 get { } //Length: 160
	}

	public SoundBank() { }

	internal void Balance(BetterSource source, float d) { }

	private int CalculateMaxClipsCount() { }

	private int FindRange(AudioClip audioClip) { }

	public float[] get_BlendValues() { }

	public float get_ClipLength() { }

	public bool get_HasDistanceBlend() { }

	public int get_MaxClipsCount() { }

	public float get_RandomPitch() { }

	public float get_RandomVolume() { }

	public int GetRandomClipIndex(int ln) { }

	public void LoadAudioData() { }

	public float PickClips(float distance, ref AudioClip clip1, ref AudioClip clip2, ref float proportions, EnvironmentType pos = 0) { }

	public float PickClips(out AudioClip clip1, out AudioClip clip2, out float proportions, float distance, EnvironmentType pos = 0) { }

	public void PickClipsByDistance(ref AudioClip clip1, ref AudioClip clip2, ref float proportions, int environment, float distance) { }

	public AudioClip PickSingleClip(int environment) { }

	public void Play(BetterSource source, EnvironmentType pos = 0, float distance = 0, float volume = 1, float blendParameter = 0, bool forceStereo = false, bool oneShot = true) { }

	public float PlayOn(BetterSource source, EnvironmentType pos = 0, float distance = 0, float volume = 1, bool forceStereo = false, bool oneShot = true) { }

	public float PlayOnScheduled(BetterSource source, double time, EnvironmentType pos = 0, float distance = 0, float volume = 1) { }

	public float PlayWithConstantRolloffDistance(BetterSource source, EnvironmentType pos = 0, float distance = 0, float volume = 1, float blendParameter = 0, bool forceStereo = false) { }

	public float PlayWithCustomRolloffDistance(BetterSource source, EnvironmentType pos = 0, float distance = 0, float volume = 1, float blendParameter = 0, bool forceStereo = false, float customRolloff = 120) { }

	private void SelectRandomClip(DistanceVarity clips, ref AudioClip clip) { }

	public void set_ClipLength(float value) { }

	public void UnloadAudioData() { }

}

