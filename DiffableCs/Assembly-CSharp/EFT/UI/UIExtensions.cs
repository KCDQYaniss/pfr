namespace EFT.UI;

[Extension]
public static class UIExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public DialogWindowContext messageContext; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <TryShowDestroyItemsDialog>g__AddHandler|1(AddItemEventArgs args) { }

		internal void <TryShowDestroyItemsDialog>g__CloseMessage|3() { }

		internal void <TryShowDestroyItemsDialog>g__RefreshHandler|2(RefreshItemEventArgs args) { }

		internal void <TryShowDestroyItemsDialog>g__RemoveHandler|0(RemoveItemEventArgs args) { }

	}

	[CompilerGenerated]
	private struct <TryShowDestroyItemsDialog>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IOperationResult operationResult; //Field offset: 0x20
		private <>c__DisplayClass3_0 <>8__1; //Field offset: 0x28
		private IItemOwner <fromController>5__2; //Field offset: 0x30
		private IItemOwner <toController>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Extension]
	public static Vector3 ClampMousePositionToScreenRect(Vector3 mousePosition) { }

	[Extension]
	public static bool GetIsScrollActive(ScrollRect scroll) { }

	[Extension]
	public static void KeepChildInScrollViewPort(ScrollRect scrollRect, RectTransform child, EMoveDirection moveDirection = 0, Vector2 margin = null) { }

	[AsyncStateMachine(typeof(<TryShowDestroyItemsDialog>d__3))]
	[Extension]
	public static Task TryShowDestroyItemsDialog(IOperationResult operationResult) { }

	[Extension]
	public static Task TryShowDestroyItemsDialog(Error operationError) { }

}

