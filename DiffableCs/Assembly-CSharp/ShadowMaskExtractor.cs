//Type is in global namespace

[RequireComponent(typeof(Light))]
public sealed class ShadowMaskExtractor : MonoBehaviour
{
	private CommandBuffer _commandBuffer; //Field offset: 0x20
	private readonly int _shadowMaskId; //Field offset: 0x28
	private readonly int _globalLightDir; //Field offset: 0x2C
	private readonly int _globalLightIntensity; //Field offset: 0x30
	private Light _light; //Field offset: 0x38

	public ShadowMaskExtractor() { }

	private void Awake() { }

	private static bool IsCorrect(Camera currentCamera) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPreCullCallback(Camera currentCamera) { }

	private void PreCull(Camera currentCamera) { }

	private void Update() { }

}

