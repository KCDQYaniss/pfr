namespace FastAnimatorSystem;

public sealed class PlayableAnimatorCuller : IPlayableAnimatorCuller, IParameterValueChangedListener, IDisposable
{
	private const int BASE_LAYER_INDEX = 0; //Field offset: 0x0
	private static readonly int _isJumpingParameterHash; //Field offset: 0x0
	private static readonly int _tiltParameterHash; //Field offset: 0x4
	private static readonly int _levelParameterHash; //Field offset: 0x8
	private static readonly int _proneParameterHash; //Field offset: 0xC
	private static readonly int _sprintParameterHash; //Field offset: 0x10
	private static readonly int _deltaRotationParameterHash; //Field offset: 0x14
	private IPlayableAnimator _playableAnimator; //Field offset: 0x10
	private bool _prevIsVisible; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsImportantParameterChanged>k__BackingField; //Field offset: 0x19

	public override bool IsImportantParameterChanged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static PlayableAnimatorCuller() { }

	public PlayableAnimatorCuller(IPlayableAnimator playableAnimator) { }

	public override void Dispose() { }

	private override void FastAnimatorSystem.IParameterValueChangedListener.OnParameterValueChanged() { }

	[CompilerGenerated]
	public override bool get_IsImportantParameterChanged() { }

	private bool IsNowInProneState() { }

	public override bool ProcessAnimator(bool isVisible) { }

	[CompilerGenerated]
	public override void set_IsImportantParameterChanged(bool value) { }

	private void SubscribeToParameters() { }

	private void UnsubscribeFromParameters() { }

}

