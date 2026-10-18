//Type is in global namespace

public class LightKeeperEyeTargetFollower : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LookAtRotation>d__52 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LightKeeperEyeTargetFollower <>4__this; //Field offset: 0x20
		private bool <rotationStartedForLeftEye>5__2; //Field offset: 0x28
		private bool <rotationStartedForRightEye>5__3; //Field offset: 0x29

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LookAtRotation>d__52(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum EEditorToggleEye
	{
		Left = 0,
		Right = 1,
	}

	[SerializeField]
	private Transform _transformToLookAt; //Field offset: 0x20
	[SerializeField]
	private SkinnedMeshRenderer _headMesh; //Field offset: 0x28
	[SerializeField]
	private float _lerpToTargetRotationSpeed; //Field offset: 0x30
	[SerializeField]
	private float _angleDifForStartRotation; //Field offset: 0x34
	[SerializeField]
	private float _angleDifForStopRotation; //Field offset: 0x38
	[SerializeField]
	private bool _returnStartRotationOnEnd; //Field offset: 0x3C
	[SerializeField]
	private int angleToBlendShapeMultiplier; //Field offset: 0x40
	[SerializeField]
	private EEditorToggleEye _eyeToShow; //Field offset: 0x44
	[SerializeField]
	private Transform _leftEye; //Field offset: 0x48
	[SerializeField]
	private string _leBlendOnRight; //Field offset: 0x50
	[SerializeField]
	private string _leBlendOnLeft; //Field offset: 0x58
	[SerializeField]
	private string _leBlendOnUp; //Field offset: 0x60
	[SerializeField]
	private string _leBlendOnDown; //Field offset: 0x68
	[SerializeField]
	private Vector3 _leAdditionalRotation; //Field offset: 0x70
	[SerializeField]
	private Space _leAdditionalRotSpace; //Field offset: 0x7C
	private Vector3 _leftEyeForwardOnStart; //Field offset: 0x80
	private Quaternion _leftEyeRotationOnStart; //Field offset: 0x8C
	private Vector3 _realLookTargetDirForLeftEye; //Field offset: 0x9C
	private Vector3 _lerpedLookTargetDirForLeftEye; //Field offset: 0xA8
	private float _leUpBlendLastValue; //Field offset: 0xB4
	[SerializeField]
	private Transform _rightEye; //Field offset: 0xB8
	[SerializeField]
	private string _reBlendOnRight; //Field offset: 0xC0
	[SerializeField]
	private string _reBlendOnLeft; //Field offset: 0xC8
	[SerializeField]
	private string _reBlendOnUp; //Field offset: 0xD0
	[SerializeField]
	private string _reBlendOnDown; //Field offset: 0xD8
	[SerializeField]
	private Vector3 _reAdditionalRotation; //Field offset: 0xE0
	[SerializeField]
	private Space _reAdditionalRotSpace; //Field offset: 0xEC
	private Vector3 _rightEyeForwardOnStart; //Field offset: 0xF0
	private Quaternion _rightEyeRotationOnStart; //Field offset: 0xFC
	private Vector3 _realLookTargetDirForRightEye; //Field offset: 0x10C
	private Vector3 _lerpedLookTargetDirForRightEye; //Field offset: 0x118
	private float _reUpBlendLastValue; //Field offset: 0x124
	private Dictionary blendShapeNamesWithIDs; //Field offset: 0x128
	private Action _unsubscribeOnDestroy; //Field offset: 0x130
	private Coroutine _lookAtRotationCoroutine; //Field offset: 0x138
	private bool _blockUpBlendShapes; //Field offset: 0x140
	private Transform testT; //Field offset: 0x148

	private Vector3 LeftEyeCurrentForward
	{
		private get { } //Length: 91
	}

	public float LeftEyeUpBlendLastValue
	{
		 get { } //Length: 9
	}

	public string LefttEyeBlendOnUp
	{
		 get { } //Length: 5
	}

	public string RightEyeBlendOnUp
	{
		 get { } //Length: 8
	}

	private Vector3 RightEyeCurrentForward
	{
		private get { } //Length: 94
	}

	public float RightEyeUpBlendLastValue
	{
		 get { } //Length: 9
	}

	public LightKeeperEyeTargetFollower() { }

	[CompilerGenerated]
	private void <Awake>b__48_0(InteractWithKeeperZoneEvent interactEvent) { }

	private void Awake() { }

	private Vector3 get_LeftEyeCurrentForward() { }

	public float get_LeftEyeUpBlendLastValue() { }

	public string get_LefttEyeBlendOnUp() { }

	public string get_RightEyeBlendOnUp() { }

	private Vector3 get_RightEyeCurrentForward() { }

	public float get_RightEyeUpBlendLastValue() { }

	public float GetSignedAngle(float angle) { }

	[IteratorStateMachine(typeof(<LookAtRotation>d__52))]
	private IEnumerator LookAtRotation() { }

	private void OnDestroy() { }

	private void OnInteractWithKeeperZoneEvent(InteractWithKeeperZoneEvent invokedEvent) { }

	public void ToggleBlockBlendShapes(bool blockIt) { }

	public void ToggleWorking(bool enable) { }

	private void Update() { }

}

