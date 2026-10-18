namespace EFT;

public sealed class HeadLightsValidator
{
	[CompilerGenerated]
	private struct <>c__DisplayClass9_0
	{
		public HeadLightsValidator <>4__this; //Field offset: 0x0
		public Transform camTr; //Field offset: 0x8

	}

	private const int NORMAL_FOV = 50; //Field offset: 0x0
	private Vector3 _fovRotationDeltaPerUnit; //Field offset: 0x10
	private Vector3 _cameraPositionOffsetRight; //Field offset: 0x1C
	private Vector3 _cameraPositionOffsetLeft; //Field offset: 0x28
	private Vector3 _cameraRotationOffsetRight; //Field offset: 0x34
	private Vector3 _cameraRotationOffsetLeft; //Field offset: 0x40
	private bool _isPaused; //Field offset: 0x4C
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"position", "rotation", "isRight"})]
	private Dictionary _defaultPositions; //Field offset: 0x50

	public HeadLightsValidator() { }

	[CompilerGenerated]
	private void <AddLight>g__WriteTransform|9_0(Transform tr, ref <>c__DisplayClass9_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <RemoveLight>g__RemoveTransform|10_0(Transform tr) { }

	public void AddLight(Transform tactical, Transform camTr) { }

	private bool IsOnRight(Transform origin, Transform obj) { }

	public void RemoveLight(Transform tactical) { }

	public void SetCameraPositionOffset(Vector3 newOffset) { }

	public void SetCameraRotationOffset(Vector3 newOffset) { }

	public void SetFoVDelta(Vector3 delta) { }

	public void SetPause(bool pause) { }

	public void Update(Vector3 targetPos, Vector3 targetRot) { }

	public void ValidateAllLights(IEnumerable tactical, Transform camTr) { }

}

