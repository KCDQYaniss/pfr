namespace EFT.CameraControl;

public class ScopeCameraData : MonoBehaviour, IScopeCameraData
{
	[Space]
	public float FieldOfView; //Field offset: 0x20
	[Space]
	public float NearClipPlane; //Field offset: 0x24
	public float FarClipPlane; //Field offset: 0x28
	[Space]
	public bool OpticCullingMask; //Field offset: 0x2C
	public float OpticCullingMaskScale; //Field offset: 0x30
	public bool CameraLodBiasController; //Field offset: 0x34
	public float LodBiasFactor; //Field offset: 0x38

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

	public ScopeCameraData() { }

	private override bool EFT.CameraControl.IScopeCameraData.get_CameraLodBiasController() { }

	private override float EFT.CameraControl.IScopeCameraData.get_FarClipPlane() { }

	private override bool EFT.CameraControl.IScopeCameraData.get_IsAdjustableOptic() { }

	private override float EFT.CameraControl.IScopeCameraData.get_LodBiasFactor() { }

	private override float EFT.CameraControl.IScopeCameraData.get_NearClipPlane() { }

	private override bool EFT.CameraControl.IScopeCameraData.get_OpticCullingMask() { }

	private override float EFT.CameraControl.IScopeCameraData.get_OpticCullingMaskScale() { }

}

