namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		public CameraCallback(object object, IntPtr method) { }

		public override void Invoke(Camera cam) { }

	}

	internal enum GateFitMode
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0,
	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	public const float kMinAperture = 0.7; //Field offset: 0x0
	public const float kMaxAperture = 32; //Field offset: 0x0
	public const int kMinBladeCount = 3; //Field offset: 0x0
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x8
	public static CameraCallback onPostRender; //Field offset: 0x10

	public RenderingPath actualRenderingPath
	{
		[NativeName("CalculateRenderingPath")]
		 get { } //Length: 78
	}

	public static int allCamerasCount
	{
		 get { } //Length: 69
	}

	public bool allowDynamicResolution
	{
		 get { } //Length: 78
	}

	public bool allowHDR
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool allowMSAA
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float aspect
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Color backgroundColor
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public Matrix4x4 cameraToWorldMatrix
	{
		 get { } //Length: 114
	}

	public CameraType cameraType
	{
		 get { } //Length: 78
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int cullingMask
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public static Camera current
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		 get { } //Length: 69
	}

	public float depth
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public DepthTextureMode depthTextureMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int eventMask
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float focalLength
	{
		 set { } //Length: 94
	}

	public float focusDistance
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture
	{
		 set { } //Length: 93
	}

	public GateFitMode gateFit
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public float[] layerCullDistances
	{
		 get { } //Length: 78
		 set { } //Length: 183
	}

	public Vector2 lensShift
	{
		 get { } //Length: 95
		 set { } //Length: 88
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 69
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		 get { } //Length: 114
		 set { } //Length: 93
	}

	public bool orthographic
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float orthographicSize
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public Matrix4x4 previousViewProjectionMatrix
	{
		 get { } //Length: 114
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 114
		 set { } //Length: 93
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public RenderingPath renderingPath
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public Scene scene
	{
		[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
		 set { } //Length: 86
	}

	public Vector2 sensorSize
	{
		 get { } //Length: 95
		 set { } //Length: 88
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		 get { } //Length: 78
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		 get { } //Length: 78
	}

	public int targetDisplay
	{
		 get { } //Length: 78
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		 set { } //Length: 93
	}

	public bool useOcclusionCulling
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool usePhysicalProperties
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Vector3 velocity
	{
		 get { } //Length: 104
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 114
		 set { } //Length: 93
	}

	public Camera() { }

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("AddCommandBuffer")]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunction("CameraScripting::CalculateViewportRayVectors", HasExplicitThis = True)]
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	public void CopyFrom(Camera other) { }

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	[NativeName("FieldOfViewToFocalLength_Safe")]
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	[NativeName("CalculateRenderingPath")]
	public RenderingPath get_actualRenderingPath() { }

	public static int get_allCamerasCount() { }

	public bool get_allowDynamicResolution() { }

	public bool get_allowHDR() { }

	public bool get_allowMSAA() { }

	public float get_aspect() { }

	public Color get_backgroundColor() { }

	private void get_backgroundColor_Injected(out Color ret) { }

	public Matrix4x4 get_cameraToWorldMatrix() { }

	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public CameraType get_cameraType() { }

	public CameraClearFlags get_clearFlags() { }

	public int get_cullingMask() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	public static Camera get_current() { }

	public float get_depth() { }

	public DepthTextureMode get_depthTextureMode() { }

	public int get_eventMask() { }

	public float get_farClipPlane() { }

	public float get_fieldOfView() { }

	public float get_focusDistance() { }

	public GateFitMode get_gateFit() { }

	public float[] get_layerCullDistances() { }

	public Vector2 get_lensShift() { }

	private void get_lensShift_Injected(out Vector2 ret) { }

	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	public float get_nearClipPlane() { }

	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	public bool get_orthographic() { }

	public float get_orthographicSize() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	public int get_pixelHeight() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	public int get_pixelWidth() { }

	public Matrix4x4 get_previousViewProjectionMatrix() { }

	private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	public Matrix4x4 get_projectionMatrix() { }

	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public RenderingPath get_renderingPath() { }

	public Vector2 get_sensorSize() { }

	private void get_sensorSize_Injected(out Vector2 ret) { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	public bool get_stereoEnabled() { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public bool get_useOcclusionCulling() { }

	public bool get_usePhysicalProperties() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	[FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = True)]
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	public float GetGateFittedFieldOfView() { }

	public Vector2 GetGateFittedLensShift() { }

	private void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	[FreeFunction("CameraScripting::GetLayerCullDistances", HasExplicitThis = True)]
	private float[] GetLayerCullDistances() { }

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	private void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[NativeName("HorizontalToVerticalFieldOfView_Safe")]
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void RemoveCommandBuffers(CameraEvent evt) { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	public void Render() { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	[FreeFunction("CameraScripting::RenderToCubemap", HasExplicitThis = True)]
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	public void RenderWithShader(Shader shader, string replacementTag) { }

	public void ResetProjectionMatrix() { }

	public void ResetStereoProjectionMatrices() { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_allowHDR(bool value) { }

	public void set_allowMSAA(bool value) { }

	public void set_aspect(float value) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	public void set_cullingMask(int value) { }

	public void set_depth(float value) { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	public void set_eventMask(int value) { }

	public void set_farClipPlane(float value) { }

	public void set_fieldOfView(float value) { }

	public void set_focalLength(float value) { }

	public void set_focusDistance(float value) { }

	public void set_forceIntoRenderTexture(bool value) { }

	public void set_gateFit(GateFitMode value) { }

	public void set_layerCullDistances(float[] value) { }

	public void set_lensShift(Vector2 value) { }

	private void set_lensShift_Injected(ref Vector2 value) { }

	public void set_nearClipPlane(float value) { }

	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_orthographic(bool value) { }

	public void set_orthographicSize(float value) { }

	public void set_pixelRect(Rect value) { }

	private void set_pixelRect_Injected(ref Rect value) { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_rect(Rect value) { }

	private void set_rect_Injected(ref Rect value) { }

	public void set_renderingPath(RenderingPath value) { }

	[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
	public void set_scene(Scene value) { }

	private void set_scene_Injected(ref Scene value) { }

	public void set_sensorSize(Vector2 value) { }

	private void set_sensorSize_Injected(ref Vector2 value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	public void set_useOcclusionCulling(bool value) { }

	public void set_usePhysicalProperties(bool value) { }

	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = True)]
	private void SetLayerCullDistances(float[] d) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	public Ray ViewportPointToRay(Vector3 pos) { }

	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	private void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

