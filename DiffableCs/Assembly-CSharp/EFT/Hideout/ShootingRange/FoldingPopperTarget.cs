namespace EFT.Hideout.ShootingRange;

public class FoldingPopperTarget : MonoBehaviour, IFoldingTarget
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public FoldingPopperTarget <>4__this; //Field offset: 0x10
		public float targetPercent; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <Fold>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public FoldingPopperTarget <>4__this; //Field offset: 0x10
		public float targetPercent; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <Unfold>b__0() { }

	}

	[Range(0, 1)]
	[SerializeField]
	private float _duration; //Field offset: 0x20
	[SerializeField]
	[Space]
	private Transform _target; //Field offset: 0x28
	[SerializeField]
	private AnimationCurve _targetUpEase; //Field offset: 0x30
	[SerializeField]
	private AnimationCurve _targetDownEase; //Field offset: 0x38
	[SerializeField]
	private Vector3 _targetUpRotation; //Field offset: 0x40
	[SerializeField]
	private Vector3 _targetDownRotation; //Field offset: 0x4C
	[SerializeField]
	[Space]
	private Transform _roller; //Field offset: 0x58
	[SerializeField]
	private AnimationCurve _rollerUpEase; //Field offset: 0x60
	[SerializeField]
	private AnimationCurve _rollerDownEase; //Field offset: 0x68
	[SerializeField]
	private Vector3 _rollerUpRotation; //Field offset: 0x70
	[SerializeField]
	private Vector3 _rollerDownRotation; //Field offset: 0x7C
	[SerializeField]
	[Space]
	private AudioSource[] _foldAudios; //Field offset: 0x88
	[SerializeField]
	private AudioSource _unfoldAudio; //Field offset: 0x90
	[SerializeField]
	private AudioSource _rockingAudio; //Field offset: 0x98
	private Quaternion _targetUpQuaternion; //Field offset: 0xA0
	private Quaternion _targetDownQuaternion; //Field offset: 0xB0
	private Quaternion _rollerUpQuaternion; //Field offset: 0xC0
	private Quaternion _rollerDownQuaternion; //Field offset: 0xD0
	private float _targetDefaultAngle; //Field offset: 0xE0
	private float _rollerDefaultAngle; //Field offset: 0xE4
	private FoldingTargetState _currentState; //Field offset: 0xE8
	private float _changeStateTime; //Field offset: 0xEC
	private AudioSource _currentAudio; //Field offset: 0xF0
	private Sequence _currentSequence; //Field offset: 0xF8

	public bool Folded
	{
		 get { } //Length: 11
	}

	public float StateTime
	{
		 get { } //Length: 83
	}

	public bool Unfolded
	{
		 get { } //Length: 11
	}

	public FoldingPopperTarget() { }

	private void Awake() { }

	public override Task Fold(bool mute, CancellationToken token) { }

	public bool get_Folded() { }

	public float get_StateTime() { }

	public bool get_Unfolded() { }

	private float GetDuration(float percent) { }

	private float GetPercentage(Quaternion leftRotation, Quaternion rightRotation, float defaultAngle) { }

	public void OnCompleteFold() { }

	public void OnCompleteUnfold() { }

	public void OnStartCommon() { }

	public void PlayAudio(AudioSource audioSource, float volume) { }

	public void PlayFoldAudio(float volume) { }

	public void PlayRockingAudio() { }

	public void PlayUnfoldAudio(float volume) { }

	public override Task Rocking(CancellationToken token) { }

	public override Task Unfold(bool mute, CancellationToken token) { }

}

