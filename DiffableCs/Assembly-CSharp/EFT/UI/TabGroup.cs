namespace EFT.UI;

public class TabGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		private struct <<SelectionChangedHandler>g__ChangeSelectionAsync|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass11_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TabGroup <>4__this; //Field offset: 0x10
		public Tab tab; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		[AsyncStateMachine(typeof(<<SelectionChangedHandler>g__ChangeSelectionAsync|0>d))]
		internal Task <SelectionChangedHandler>g__ChangeSelectionAsync|0() { }

	}

	protected readonly Tab[] _tabs; //Field offset: 0x10
	private readonly bool _setAsLastSibling; //Field offset: 0x18
	private Tab _initialTab; //Field offset: 0x20
	private Tab _selectedTab; //Field offset: 0x28
	private bool _isChangingSelection; //Field offset: 0x30

	public Tab SelectedTab
	{
		 get { } //Length: 5
	}

	public int SelectedTabIndex
	{
		 get { } //Length: 67
	}

	public TabGroup(Tab[] tabs, Tab initialTab, bool setAsLastSibling = true) { }

	public void Close() { }

	public Tab get_SelectedTab() { }

	public int get_SelectedTabIndex() { }

	public override void Reset() { }

	private void SelectionChangedHandler(Tab tab, bool isSelected) { }

	public void SelectTab(Tab tab) { }

	protected override void SelectTabInternal(Tab tab, bool sendCallback = true) { }

	public void Show(Tab tab, bool sendCallback = true) { }

	public Task TryHide() { }

}

