namespace EFT.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(RawImage))]
public sealed class CameraImage : MonoBehaviour
{
	private struct LevelRenderSettings
	{
		public Color AmbientEquatorColor; //Field offset: 0x0
		public Color AmbientGroundColor; //Field offset: 0x10
		public float AmbientIntensity; //Field offset: 0x20
		public Color AmbientLight; //Field offset: 0x24
		public AmbientMode AmbientMode; //Field offset: 0x34
		public Color AmbientSkyColor; //Field offset: 0x38
		public bool Fog; //Field offset: 0x48

		public static void Reset() { }

		public void Restore() { }

		public static LevelRenderSettings Store() { }

	}

	public Camera targetCamera; //Field offset: 0x20
	private RenderTexture _renderTexture; //Field offset: 0x28
	public int TextureDepth; //Field offset: 0x30
	public RenderTextureFormat TextureFormat; //Field offset: 0x34
	public RenderTextureReadWrite RenderTextureReadWrite; //Field offset: 0x38
	public int Antialiasing; //Field offset: 0x3C
	private int _width; //Field offset: 0x40
	private int _height; //Field offset: 0x44
	private RawImage _rawImage; //Field offset: 0x48
	private LevelRenderSettings _prevSettings; //Field offset: 0x50

	public CameraImage() { }

	private void Awake() { }

	public void CleanUp() { }

	private void ForceInterfaceRenderSettings() { }

	public void InitCamera(Camera cam) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RecreateTexture() { }

	private void RestoreRenderSettings(Camera cam) { }

	public void SetRawImageColor(Color32 color) { }

	private void SetupPreCull(Camera cam) { }

	private void SetupRenderSettings(Camera cam) { }

	private void Update() { }

}

