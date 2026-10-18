namespace EFT.Hideout.ShootingRange;

public class PopperTargetControl : InteractiveShootingRange
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <HandlePhasedTrainingStart>b__21_0(PhaseSetting v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public HideoutPlayerOwner owner; //Field offset: 0x10
		public PopperTargetControl <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <InteractionStates>b__0() { }

		internal void <InteractionStates>b__1() { }

	}

	[SerializeField]
	[Space]
	private RailTargets _railTargets; //Field offset: 0x50
	[SerializeField]
	private PopperTargets _popperTargets; //Field offset: 0x58
	[SerializeField]
	[Space]
	private SharedTargetControl _sharedTargetControl; //Field offset: 0x60
	[SerializeField]
	private Setting _popperTargetStandSettings; //Field offset: 0x68
	[SerializeField]
	private Setting _shootTrainingSettings; //Field offset: 0x70
	[SerializeField]
	[Space]
	private ShootingScoreInterface _shootingScoreInterface; //Field offset: 0x78
	[SerializeField]
	private AudioSource _clickAudio; //Field offset: 0x80
	private PopperTargetStandScenario _popperTargetStandScenario; //Field offset: 0x88
	private ShootTrainingScenario _shootTrainingScenario; //Field offset: 0x90
	private PopperTargetFoldScenario _popperTargetFoldScenario; //Field offset: 0x98
	private PopperTargetUnfoldScenario _popperTargetUnfoldScenario; //Field offset: 0xA0
	private AvailableInteractionState _prevAvailableInteractionState; //Field offset: 0xA8
	private bool _energized; //Field offset: 0xB0
	private bool _poppersFolded; //Field offset: 0xB1
	private int _bestScore; //Field offset: 0xB4

	public PopperTargetControl() { }

	public virtual void Disable() { }

	private void FoldPopperTarget() { }

	private void HandleFoldStart() { }

	private void HandlePhasedTrainingCancel() { }

	private void HandlePhasedTrainingComplete() { }

	private void HandlePhasedTrainingStart() { }

	private void HandleSharedStart() { }

	private void HandleSharedStartCancel() { }

	public virtual AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

	private void OnDestroy() { }

	private void Start() { }

	public void TurnOffEnergy() { }

	private void TurnOffPoppers() { }

	private void TurnOffTraining() { }

	public void TurnOnEnergy() { }

	private void TurnOnPoppers() { }

	private void TurnOnPoppersSilent() { }

	private void TurnOnTraining() { }

	private void UnfoldPopperTarget() { }

	private void Update() { }

	private void UpdateBestScore() { }

}

