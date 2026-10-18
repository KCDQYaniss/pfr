//Type is in global namespace

[RequireComponent(typeof(Light))]
public class ShadowMapExtractor : MonoBehaviour
{
	private static readonly int _shadowMapId; //Field offset: 0x0
	private RenderTexture _renderTexture; //Field offset: 0x20
	private CommandBuffer _cmd; //Field offset: 0x28
	private Light _light; //Field offset: 0x30

	private static ShadowMapExtractor() { }

	public ShadowMapExtractor() { }

	private void Dispose() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

