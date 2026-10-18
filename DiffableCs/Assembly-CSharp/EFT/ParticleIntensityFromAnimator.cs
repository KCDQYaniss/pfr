namespace EFT;

public class ParticleIntensityFromAnimator : MonoBehaviour
{
	[SerializeField]
	private Animator _animator; //Field offset: 0x20
	[SerializeField]
	private ParticleSystem _targetParticle; //Field offset: 0x28
	[SerializeField]
	private string _animatorParam; //Field offset: 0x30
	[SerializeField]
	private Vector2 _minMaxParamValues; //Field offset: 0x38
	[SerializeField]
	private Vector2 _minMaxEmissionValue; //Field offset: 0x40
	private float _currentParamValue; //Field offset: 0x48
	private Vector2 _convertedminMaxParamValues; //Field offset: 0x4C
	private Vector2 _convertedminMaxEmissionValue; //Field offset: 0x54
	private float _paramDiff; //Field offset: 0x5C
	private float _emissionDif; //Field offset: 0x60

	public ParticleIntensityFromAnimator() { }

	private void Awake() { }

	private void Update() { }

}

