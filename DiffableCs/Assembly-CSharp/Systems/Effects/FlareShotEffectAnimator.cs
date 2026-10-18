namespace Systems.Effects;

public sealed class FlareShotEffectAnimator : MonoBehaviour
{
	private static readonly int _intensityId; //Field offset: 0x0
	[SerializeField]
	private AnimationCurve _fadeCurve; //Field offset: 0x20
	[SerializeField]
	private ParticleSystem _flareParticleSystem; //Field offset: 0x28
	[SerializeField]
	private ParticleSystem _smokeParticleSystem; //Field offset: 0x30
	[SerializeField]
	private CullingLightObject _cullingLightObject; //Field offset: 0x38
	[SerializeField]
	private float _lightIntensity; //Field offset: 0x40
	private float _localTime; //Field offset: 0x44
	private Material _flareParticleMaterial; //Field offset: 0x48
	[CompilerGenerated]
	private float <Frequency>k__BackingField; //Field offset: 0x50

	public float Frequency
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float LightIntensity
	{
		 set { } //Length: 6
	}

	private static FlareShotEffectAnimator() { }

	public FlareShotEffectAnimator() { }

	[CompilerGenerated]
	public float get_Frequency() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void set_Frequency(float value) { }

	public void set_LightIntensity(float value) { }

	private void Update() { }

}

