//Type is in global namespace

public class VolumetricExplosionDemo : MonoBehaviour
{
	private VolumetricExplosion _volumetricExplosion; //Field offset: 0x20
	private VolumetricBounds _volumetricBounds; //Field offset: 0x28
	private List _pointCache; //Field offset: 0x30
	private Camera _mainCamera; //Field offset: 0x38
	[SerializeField]
	private float _radius; //Field offset: 0x40
	[SerializeField]
	private float _subdivisionN; //Field offset: 0x44
	[SerializeField]
	private float _rayLength; //Field offset: 0x48
	[SerializeField]
	private float _maxCastLength; //Field offset: 0x4C
	[SerializeField]
	private ParticleSystem _system; //Field offset: 0x50

	public VolumetricExplosionDemo() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void Start() { }

	private void Update() { }

}

