namespace EFT.CameraControl;

public interface IScopeCameraData
{

	public bool CameraLodBiasController
	{
		 get { } //Length: 0
	}

	public float FarClipPlane
	{
		 get { } //Length: 0
	}

	public bool IsAdjustableOptic
	{
		 get { } //Length: 0
	}

	public float LodBiasFactor
	{
		 get { } //Length: 0
	}

	public float NearClipPlane
	{
		 get { } //Length: 0
	}

	public bool OpticCullingMask
	{
		 get { } //Length: 0
	}

	public float OpticCullingMaskScale
	{
		 get { } //Length: 0
	}

	public bool get_CameraLodBiasController() { }

	public float get_FarClipPlane() { }

	public bool get_IsAdjustableOptic() { }

	public float get_LodBiasFactor() { }

	public float get_NearClipPlane() { }

	public bool get_OpticCullingMask() { }

	public float get_OpticCullingMaskScale() { }

}

