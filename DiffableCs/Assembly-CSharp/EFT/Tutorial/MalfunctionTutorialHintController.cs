namespace EFT.Tutorial;

public sealed class MalfunctionTutorialHintController : BaseTutorialHintController
{
	[CompilerGenerated]
	private struct <WaitForIdleOperationInTutorialWeapon>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MalfunctionTutorialHintController <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum ETutorState
	{
		WaitForTrigger = 0,
		InProgress = 1,
		Completed = 2,
	}

	private Weapon _malfTutorItem; //Field offset: 0x30
	private Weapon _currentPlayerWeapon; //Field offset: 0x38
	private readonly string _brokenWeaponId; //Field offset: 0x40
	private bool _weaponTutorCompleted; //Field offset: 0x48
	private FirearmController _tutorWeaponFirearmController; //Field offset: 0x50
	private ETutorState _malfTutorstate; //Field offset: 0x58

	public MalfunctionTutorialHintController(TutorialHintData hint, Player player, Action showHint, Action closeHint) { }

	private void ActiveWeaponHandler(AbstractHandsController prevController, AbstractHandsController newController) { }

	public virtual void Dispose() { }

	private void InventoryControllerOnActiveEventAdded(ItemEventArgs eventArgs) { }

	private void MalfNotificationHandler(Notification obj) { }

	private void StartMalfunctionTutorial() { }

	[AsyncStateMachine(typeof(<WaitForIdleOperationInTutorialWeapon>d__11))]
	private Task WaitForIdleOperationInTutorialWeapon() { }

}

