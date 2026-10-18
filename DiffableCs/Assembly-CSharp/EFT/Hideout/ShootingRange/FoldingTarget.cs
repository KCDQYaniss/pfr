namespace EFT.Hideout.ShootingRange;

public class FoldingTarget : MonoBehaviour, IFoldingTarget
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public FoldingTarget <>4__this; //Field offset: 0x10
		public float percent; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <Fold>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public FoldingTarget <>4__this; //Field offset: 0x10
		public float percent; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <Unfold>b__0() { }

	}

	[Range(0, 1)]
	[SerializeField]
	private float _duration; //Field offset: 0x20
	[SerializeField]
	[Space]
	private Transform _target; //Field offset: 0x28
	[SerializeField]
	private Vector3 _targetUpRotation; //Field offset: 0x30
	[SerializeField]
	private Vector3 _targetDownRotation; //Field offset: 0x3C
	[SerializeField]
	[Space]
	private AudioSource _foldAudio; //Field offset: 0x48
	[SerializeField]
	private AudioSource _unfoldAudio; //Field offset: 0x50
	private Quaternion _targetUpQuaternion; //Field offset: 0x58
	private Quaternion _targetDownQuaternion; //Field offset: 0x68
	private float _targetDefaultAngle; //Field offset: 0x78
	private FoldingTargetState _currentState; //Field offset: 0x7C
	private AudioSource _currentAudio; //Field offset: 0x80
	private Sequence _currentSequence; //Field offset: 0x88

	public bool Folded
	{
		 get { } //Length: 8
	}

	public bool Unfolded
	{
		 get { } //Length: 8
	}

	public FoldingTarget() { }

	private void Awake() { }

	public override Task Fold(bool mute, CancellationToken token) { }

	public bool get_Folded() { }

	public bool get_Unfolded() { }

	private float GetDuration(float percent) { }

	private float GetPercentage(Quaternion leftRotation, Quaternion rightRotation) { }

	public void OnCompleteFold() { }

	public void OnCompleteUnfold() { }

	public void OnStartCommon() { }

	public void PlayAudio(AudioSource audioSource, float volume) { }

	public void PlayFoldAudio(float volume) { }

	public void PlayUnfoldAudio(float volume) { }

	public override Task Rocking(CancellationToken token) { }

	public override Task Unfold(bool mute, CancellationToken token) { }

}

