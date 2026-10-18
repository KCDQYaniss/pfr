//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Light))]
public class MuzzleParticleLight : MonoBehaviour
{
	private const float LIGHT_EPSILON = 0.01; //Field offset: 0x0
	private float _targetIntensity; //Field offset: 0x20
	private float _velocity; //Field offset: 0x24
	[SerializeField]
	private Light _light; //Field offset: 0x28
	[SerializeField]
	private ParticleSystem _particleSystem; //Field offset: 0x30
	[SerializeField]
	private Vector2 _minMaxIntensity; //Field offset: 0x38
	[SerializeField]
	private float _time; //Field offset: 0x40

	public MuzzleParticleLight() { }

	private void LateUpdate() { }

}

