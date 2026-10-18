namespace EFT.CameraControl;

[RequireComponent(typeof(ScopeZoomHandler))]
public class ScopeSmoothCameraData : MonoBehaviour, IScopeCameraData, IAdjustableOpticData
{
	[CompilerGenerated]
	private ScopeZoomHandler <ScopeZoomHandler>k__BackingField; //Field offset: 0x20
	[Space]
	public Vector3 MinMaxFieldOfView; //Field offset: 0x28
	public AnimationCurve FieldOfViewCurve; //Field offset: 0x38
	public AnimationCurve ReticleBlendCurve; //Field offset: 0x40
	public float ZoomSensitivity; //Field offset: 0x48
	public float AdjustableOpticSensitivity; //Field offset: 0x4C
	[Space]
	public float NearClipPlane; //Field offset: 0x50
	public float FarClipPlane; //Field offset: 0x54
	[Space]
	public bool OpticCullingMask; //Field offset: 0x58
	public float OpticCullingMaskScale; //Field offset: 0x5C
	public bool CameraLodBiasController; //Field offset: 0x60
	public float LodBiasFactor; //Field offset: 0x64
	private bool _isAdjustableOptic; //Field offset: 0x68
	private Vector3 _minMaxFov; //Field offset: 0x6C
	private float _zoomSensitivity; //Field offset: 0x78
	private float _adjustableOpticSensitivity; //Field offset: 0x7C
	private float _adjustableOpticSensitivityMax; //Field offset: 0x80

	private override bool EFT.CameraControl.IScopeCameraData.CameraLodBiasController
	{
		private get { } //Length: 5
	}

	private override float EFT.CameraControl.IScopeCameraData.FarClipPlane
	{
		private get { } //Length: 6
	}

	private override bool EFT.CameraControl.IScopeCameraData.IsAdjustableOptic
	{
		private get { } //Length: 3
	}

	private override float EFT.CameraControl.IScopeCameraData.LodBiasFactor
	{
		private get { } //Length: 6
	}

	private override float EFT.CameraControl.IScopeCameraData.NearClipPlane
	{
		private get { } //Length: 6
	}

	private override bool EFT.CameraControl.IScopeCameraData.OpticCullingMask
	{
		private get { } //Length: 5
	}

	private override float EFT.CameraControl.IScopeCameraData.OpticCullingMaskScale
	{
		private get { } //Length: 6
	}

	private override float EFT.InventoryLogic.IAdjustableOpticData.AdjustableOpticSensitivity
	{
		private get { } //Length: 6
	}

	private override float EFT.InventoryLogic.IAdjustableOpticData.AdjustableOpticSensitivityMax
	{
		private get { } //Length: 9
	}

	private override bool EFT.InventoryLogic.IAdjustableOpticData.IsAdjustableOptic
	{
		private get { } //Length: 3
	}

	private override Vector3 EFT.InventoryLogic.IAdjustableOpticData.MinMaxFov
	{
		private get { } //Length: 19
	}

	private override float EFT.InventoryLogic.IAdjustableOpticData.ZoomSensitivity
	{
		private get { } //Length: 6
	}

	public ScopeZoomHandler ScopeZoomHandler
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ScopeSmoothCameraData() { }

	private override bool EFT.CameraControl.IScopeCameraData.get_CameraLodBiasController() { }

	private override float EFT.CameraControl.IScopeCameraData.get_FarClipPlane() { }

	private override bool EFT.CameraControl.IScopeCameraData.get_IsAdjustableOptic() { }

	private override float EFT.CameraControl.IScopeCameraData.get_LodBiasFactor() { }

	private override float EFT.CameraControl.IScopeCameraData.get_NearClipPlane() { }

	private override bool EFT.CameraControl.IScopeCameraData.get_OpticCullingMask() { }

	private override float EFT.CameraControl.IScopeCameraData.get_OpticCullingMaskScale() { }

	private override float EFT.InventoryLogic.IAdjustableOpticData.get_AdjustableOpticSensitivity() { }

	private override float EFT.InventoryLogic.IAdjustableOpticData.get_AdjustableOpticSensitivityMax() { }

	private override bool EFT.InventoryLogic.IAdjustableOpticData.get_IsAdjustableOptic() { }

	private override Vector3 EFT.InventoryLogic.IAdjustableOpticData.get_MinMaxFov() { }

	private override float EFT.InventoryLogic.IAdjustableOpticData.get_ZoomSensitivity() { }

	[CompilerGenerated]
	public ScopeZoomHandler get_ScopeZoomHandler() { }

	[CompilerGenerated]
	public void set_ScopeZoomHandler(ScopeZoomHandler value) { }

}

