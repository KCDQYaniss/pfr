//Type is in global namespace

[CreateAssetMenu(fileName = "WeaponProfile", menuName = "Audio/Firefight/WeaponProfile", order = 1)]
public class WeaponProfile : ScriptableObject
{
	public FirearmAudioPreset AudioPreset; //Field offset: 0x18
	[Header("Burst size range (shots, inclusive)")]
	[Tooltip("Random number of shots per burst. Example (1, 7). Values are rounded to integers and clamped to at least 1.")]
	public Vector2 BurstSizeRange; //Field offset: 0x20
	[Tooltip("Pitch/volume jitter for natural variation.")]
	public Vector2 VolumeJitter; //Field offset: 0x28
	public Vector2 PitchJitter; //Field offset: 0x30
	[Header("Timing variation")]
	[Tooltip("Random single-shot start jitter in seconds (adds irregularity).")]
	public Vector2 SingleShotStartJitterSec; //Field offset: 0x38
	[Tooltip("Pause range between single shots (sec) for semi-auto/single-shot series.")]
	public Vector2 SingleShotGapRangeSec; //Field offset: 0x40
	[Tooltip("Pause range between bursts (sec) — applied when shotsCount > 1.")]
	public Vector2 BurstSequenceGapRangeSec; //Field offset: 0x48
	[Header("Mode mix (Auto vs Semi)")]
	[Range(0, 1)]
	[Tooltip("Probability of choosing automatic mode (Loop+Tail) when both are available. 0 = always semi-auto, 1 = always automatic.")]
	public float AutoFireBias; //Field offset: 0x50

	public WeaponProfile() { }

	private float ComputeRandomClampedValueInRange(Vector2 range) { }

	public void LoadData() { }

	public float SampleBurstSequenceGapSec() { }

	public int SampleBurstSize() { }

	public float SamplePitchMultiplier() { }

	public float SampleSingleShotGapSec() { }

	public float SampleSingleShotStartJitter() { }

	public float SampleVolumeMultiplier() { }

	public void UnloadData() { }

}

