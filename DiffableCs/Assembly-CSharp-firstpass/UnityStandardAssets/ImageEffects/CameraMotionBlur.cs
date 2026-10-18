namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class CameraMotionBlur : PostEffectsBase
{
	internal enum MotionBlurFilter
	{
		CameraMotion = 0,
		LocalBlur = 1,
		Reconstruction = 2,
		ReconstructionDX11 = 3,
		ReconstructionDisc = 4,
	}

	private static float MAX_RADIUS; //Field offset: 0x0
	public MotionBlurFilter filterType; //Field offset: 0x30
	public bool preview; //Field offset: 0x34
	public Vector3 previewScale; //Field offset: 0x38
	public float movementScale; //Field offset: 0x44
	public float rotationScale; //Field offset: 0x48
	public float maxVelocity; //Field offset: 0x4C
	public float minVelocity; //Field offset: 0x50
	public float velocityScale; //Field offset: 0x54
	public float softZDistance; //Field offset: 0x58
	public int velocityDownsample; //Field offset: 0x5C
	public LayerMask excludeLayers; //Field offset: 0x60
	private GameObject tmpCam; //Field offset: 0x68
	public Shader shader; //Field offset: 0x70
	public Shader dx11MotionBlurShader; //Field offset: 0x78
	public Shader replacementClear; //Field offset: 0x80
	private Material motionBlurMaterial; //Field offset: 0x88
	private Material dx11MotionBlurMaterial; //Field offset: 0x90
	public Texture2D noiseTexture; //Field offset: 0x98
	public float jitter; //Field offset: 0xA0
	public bool showVelocity; //Field offset: 0xA4
	public float showVelocityScale; //Field offset: 0xA8
	private Matrix4x4 currentViewProjMat; //Field offset: 0xAC
	private Matrix4x4 prevViewProjMat; //Field offset: 0xEC
	private int prevFrameCount; //Field offset: 0x12C
	private bool wasActive; //Field offset: 0x130
	private Vector3 prevFrameForward; //Field offset: 0x134
	private Vector3 prevFrameUp; //Field offset: 0x140
	private Vector3 prevFramePos; //Field offset: 0x14C
	private Camera _camera; //Field offset: 0x158

	private static CameraMotionBlur() { }

	public CameraMotionBlur() { }

	private void CalculateViewProjection() { }

	public virtual bool CheckResources() { }

	private static int divRoundUp(int x, int d) { }

	private Camera GetTmpCam() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Remember() { }

	private void Start() { }

	private void StartFrame() { }

}

