namespace EFT.Hair;

[ExecuteInEditMode]
[RequireComponent(typeof(Renderer))]
public sealed class HairLights : MonoBehaviour
{
	private static readonly int _hairLightCount; //Field offset: 0x0
	private static readonly int _hairLightColor; //Field offset: 0x4
	private static readonly int _hairLightDirection; //Field offset: 0x8
	private Vector4[] _colors; //Field offset: 0x20
	private Vector4[] _directions; //Field offset: 0x28
	private MaterialPropertyBlock _propertyBlock; //Field offset: 0x30
	private Renderer _renderer; //Field offset: 0x38
	[Delayed]
	[SerializeField]
	private List _lights; //Field offset: 0x40

	private static HairLights() { }

	public HairLights() { }

	private void Awake() { }

	private void OnValidate() { }

	private void Update() { }

}

