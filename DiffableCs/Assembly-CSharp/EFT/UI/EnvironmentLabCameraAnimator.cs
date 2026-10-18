namespace EFT.UI;

public sealed class EnvironmentLabCameraAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CalculateFollowRotation>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EnvironmentLabCameraAnimator <>4__this; //Field offset: 0x20
		private Vector2 <screenCenterPosition>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct RangeFloat
	{
		public float MinValue; //Field offset: 0x0
		public float MaxValue; //Field offset: 0x4

		public RangeFloat(float minValue, float maxValue) { }

		public float GetRandomValue() { }

	}

	[SerializeField]
	private Camera _camera; //Field offset: 0x20
	[SerializeField]
	private Transform _horizontalJoint; //Field offset: 0x28
	[SerializeField]
	private Transform _verticalJoint; //Field offset: 0x30
	[SerializeField]
	private Transform _lens; //Field offset: 0x38
	[SerializeField]
	private Vector3 _steadyVerticalPosition; //Field offset: 0x40
	[SerializeField]
	private float _autoDegreesPerSecond; //Field offset: 0x4C
	[SerializeField]
	private RangeFloat _autoRotationRate; //Field offset: 0x50
	[SerializeField]
	private Vector3 _leftHorizontalPosition; //Field offset: 0x58
	[SerializeField]
	private Vector3 _rightHorizontalPosition; //Field offset: 0x64
	[SerializeField]
	private float _followDegreesPerSecond; //Field offset: 0x70
	[SerializeField]
	private float _followDelay; //Field offset: 0x74
	[SerializeField]
	private Vector3 _horizontalFollowDelta; //Field offset: 0x78
	[SerializeField]
	private Vector3 _verticalFollowDelta; //Field offset: 0x84
	[SerializeField]
	private float _lensSpeed; //Field offset: 0x90
	[SerializeField]
	private Vector3 _lensClosePosition; //Field offset: 0x94
	[SerializeField]
	private Vector3 _lensFarPosition; //Field offset: 0xA0
	[SerializeField]
	private float _blinkInterval; //Field offset: 0xAC
	[SerializeField]
	private GameObject _redLight; //Field offset: 0xB0
	private Stopwatch _autoMoveTimer; //Field offset: 0xB8
	private float _nextIterationTime; //Field offset: 0xC0
	private Vector3 _steadyHorizontalPosition; //Field offset: 0xC4
	private Vector3 _currentHorizontalFollowDelta; //Field offset: 0xD0
	private Vector3 _currentVerticalFollowDelta; //Field offset: 0xDC
	private Vector3 _lensTargetPosition; //Field offset: 0xE8
	private bool _autoRotation; //Field offset: 0xF4

	public EnvironmentLabCameraAnimator() { }

	private void CalculateAutoRotation() { }

	[AsyncStateMachine(typeof(<CalculateFollowRotation>d__31))]
	private Task CalculateFollowRotation() { }

	private void DoBlink() { }

	private void DoRotate() { }

	public void OnEnable() { }

	public void Update() { }

}

