namespace EFT.NextObservedPlayer;

public class ObservedPlayerUsableItemController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private struct <Execute>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ICommandMessage command; //Field offset: 0x20
		public ObservedPlayerUsableItemController <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IObservedUsableItem _item; //Field offset: 0x28

	public OpticSight OpticSight
	{
		 get { } //Length: 113
	}

	private ObservedPlayerUsableItemController(BaseAnimationHandsController handsAnimationController, Item item, GameObject prefab) { }

	public static ObservedPlayerUsableItemController CreateInstance(GameObject gameObject, Item item, GameObject prefab) { }

	public virtual void Destroy() { }

	[AsyncStateMachine(typeof(<Execute>d__9))]
	public virtual Task Execute(ICommandMessage command) { }

	public OpticSight get_OpticSight() { }

	private static IObservedUsableItem GetObservedUsableItem(Item item) { }

	public void SetRangeFinderAiming(bool isAiming, bool firstPersonPointOfView) { }

	private void SpecificExecute(RadioTransmitterStatusCommandMessage command) { }

	public void UpdateRangeFinderForSpectating(bool isAiming, bool firstPersonPointOfView) { }

}

