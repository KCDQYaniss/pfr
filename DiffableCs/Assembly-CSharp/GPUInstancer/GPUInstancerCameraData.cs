namespace GPUInstancer;

public class GPUInstancerCameraData
{
	public Camera mainCamera; //Field offset: 0x10
	public SSAA mainCameraSSAA; //Field offset: 0x18
	public GPUInstancerHiZOcclusionGenerator hiZOcclusionGenerator; //Field offset: 0x20
	public float[] mvpMatrixFloats; //Field offset: 0x28
	public float[] mvpMatrix2Floats; //Field offset: 0x30
	public Vector3 cameraPosition; //Field offset: 0x38
	public bool hasOcclusionGenerator; //Field offset: 0x44
	public float halfAngle; //Field offset: 0x48
	[CompilerGenerated]
	private readonly bool <IsOptic>k__BackingField; //Field offset: 0x4C
	private Quaternion previousRotation; //Field offset: 0x50
	[CompilerGenerated]
	private float <LastAngularFrustumOffset>k__BackingField; //Field offset: 0x60

	public bool IsOptic
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private float LastAngularFrustumOffset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public GPUInstancerCameraData(Camera mainCamera = null, bool _isOptic = false) { }

	public void CalculateAngularFrustumOffset(float frustumOffset) { }

	public void CalculateCameraData() { }

	public void CalculateHalfAngle() { }

	[CompilerGenerated]
	public bool get_IsOptic() { }

	[CompilerGenerated]
	public float get_LastAngularFrustumOffset() { }

	[CompilerGenerated]
	private void set_LastAngularFrustumOffset(float value) { }

	public void SetCamera(Camera mainCamera) { }

}

