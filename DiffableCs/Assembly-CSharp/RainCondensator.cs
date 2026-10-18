//Type is in global namespace

[RequireComponent(typeof(Renderer))]
public class RainCondensator : MonoBehaviour
{
	private const float WeaponRippleTexScale = 8; //Field offset: 0x0
	private const float HandRippleTexScale = 0.25; //Field offset: 0x0
	private const string USERAIN = "USERAIN"; //Field offset: 0x0
	private const string SMAP = "SMap"; //Field offset: 0x0
	private static readonly int _rippleTexScale; //Field offset: 0x0
	private static readonly int _skinnedMeshMaterial; //Field offset: 0x4
	private static readonly int _localRain; //Field offset: 0x8
	private static readonly int _localRainAverage; //Field offset: 0xC
	private bool _isSkinnedMeshRenderer; //Field offset: 0x20
	private MaterialPropertyBlock _materialPropertyBlock; //Field offset: 0x28
	private List _materials; //Field offset: 0x30
	private Renderer _renderer; //Field offset: 0x38
	private Vector3 _rainDir; //Field offset: 0x40

	private static RainCondensator() { }

	public RainCondensator() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void UpdateValues() { }

}

