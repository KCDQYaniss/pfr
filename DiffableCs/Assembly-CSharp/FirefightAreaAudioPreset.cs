//Type is in global namespace

[CreateAssetMenu(fileName = "FirefightAreaAudioPreset", menuName = "Audio/Firefight/FirefightAreaAudioPreset", order = 0)]
public class FirefightAreaAudioPreset : ScriptableObject
{
	[Header("Firefight weapon profiles pool")]
	public WeaponProfile[] WeaponProfiles; //Field offset: 0x18
	[Header("Density envelope")]
	public AnimationCurve DensityCurve; //Field offset: 0x20
	public float DensityPeriodSec; //Field offset: 0x28
	[Range(0, 1)]
	public float BaseDensity; //Field offset: 0x2C
	[Header("Generation parameters")]
	public float GrenadeEventsPerShooterPerMinuteAtMaxDensity; //Field offset: 0x30
	[Header("Scheduling")]
	[Tooltip("Initial cooldown range at controller start, sec")]
	public Vector2 InitialCooldownRangeSec; //Field offset: 0x34
	[Tooltip("Base cooldown at zero density, sec")]
	public float BaseCooldownAtZeroDensitySec; //Field offset: 0x3C
	[Tooltip("Base cooldown at max density, sec")]
	public float BaseCooldownAtMaxDensitySec; //Field offset: 0x40
	[Tooltip("Extra cooldown jitter range added to base cooldown, sec")]
	public Vector2 CooldownJitterRangeSec; //Field offset: 0x44
	[Tooltip("Cooldown when no weapon profile is available, sec")]
	public float NoProfileRetryCooldownSec; //Field offset: 0x4C
	[Tooltip("Backoff cooldown at zero density when area is saturated (active sequences reached limit), sec")]
	public float BackoffAtZeroDensitySec; //Field offset: 0x50
	[Tooltip("Backoff cooldown at max density when area is saturated (active sequences reached limit), sec")]
	public float BackoffAtMaxDensitySec; //Field offset: 0x54
	[Header("Call-and-Response (optional)")]
	public bool EnableCallAndResponse; //Field offset: 0x58
	[Range(0, 1)]
	[Tooltip("Probability to react with a response burst (0..1)")]
	public float ResponseProbability; //Field offset: 0x5C
	[Tooltip("Response delay range, sec")]
	public Vector2 ResponseDelayRange; //Field offset: 0x60
	[Tooltip("Response burst length range (in shots)")]
	public Vector2Int ResponseShotsRange; //Field offset: 0x68
	[Tooltip("Minimum interval between cluster responses (random within range), sec")]
	public Vector2 ResponseCooldownRange; //Field offset: 0x70

	public FirefightAreaAudioPreset() { }

	public float EvaluateBackoffCooldownSec(float density) { }

	public float EvaluateBaseCooldownSec(float density) { }

	public float EvaluateDensity(double timeSec, float localMultiplier) { }

	public void LoadPresetData() { }

	public bool TryGetRandomWeaponProfile(out WeaponProfile profile) { }

	public void UnloadPresetData() { }

}

