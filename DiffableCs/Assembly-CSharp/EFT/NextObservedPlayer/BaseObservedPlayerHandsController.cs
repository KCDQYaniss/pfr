namespace EFT.NextObservedPlayer;

public abstract class BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private struct <Unspawn>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseObservedPlayerHandsController <>4__this; //Field offset: 0x20
		public float animationSpeed; //Field offset: 0x28
		public bool fastHide; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly TimeSpan _executeCommandTimeout; //Field offset: 0x10
	private BaseAnimationHandsController _handsAnimationController; //Field offset: 0x18
	private ObservedPlayerHandsController _handsController; //Field offset: 0x20

	public FirearmsAnimator FirearmsAnimator
	{
		 get { } //Length: 27
	}

	public BaseAnimationHandsController HandsAnimationController
	{
		 get { } //Length: 5
	}

	protected BaseObservedPlayerHandsController(BaseAnimationHandsController handsAnimationController) { }

	public Task ChangeMod() { }

	public static BaseObservedPlayerHandsController CreateInstance(EHandsControllerType controllerType, GameObject gameObject, IPlayer player, PlayerBones bones, ObservedPlayerHandsController handsController) { }

	public override void Destroy() { }

	public abstract Task Execute(ICommandMessage command) { }

	public void FastForward() { }

	public FirearmsAnimator get_FirearmsAnimator() { }

	public BaseAnimationHandsController get_HandsAnimationController() { }

	public void Setup(ObservedPlayerHandsController handsController, IAnimator playerAnimator, FirearmsAnimator weaponPrefabFirearmsAnimator, AnimationEventsEmitter weaponPrefabAnimationEventsEmitter, EHandsControllerType handsControllerType, Func needFastForward, Func isPlayerCulled) { }

	public override Task Spawn(float animationSpeed) { }

	[AsyncStateMachine(typeof(<Unspawn>d__11))]
	public override Task Unspawn(float animationSpeed, bool fastHide) { }

}

