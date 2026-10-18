namespace EFT.UI.DragAndDrop;

public sealed class GridSortPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ButtonClickHandler>b__10_0() { }

	}

	[CompilerGenerated]
	private struct <SortAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GridSortPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string SORT_ACCEPT_CONFIRMATION = "UI/Inventory/SortAcceptConfirmation"; //Field offset: 0x0
	[SerializeField]
	private Button _button; //Field offset: 0x20
	[SerializeField]
	private GameObject _loaderPanel; //Field offset: 0x28
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x30
	private bool _inProgress; //Field offset: 0x38
	private InventoryController _controller; //Field offset: 0x40
	private CompoundItem _item; //Field offset: 0x48

	public GridSortPanel() { }

	private void Awake() { }

	private void ButtonClickHandler() { }

	private void ChangeProgress(bool inProgress) { }

	public void SetUnlockStatus(bool value) { }

	public void Show(InventoryController controller, CompoundItem item) { }

	private void Sort() { }

	[AsyncStateMachine(typeof(<SortAsync>d__12))]
	private Task SortAsync() { }

}

