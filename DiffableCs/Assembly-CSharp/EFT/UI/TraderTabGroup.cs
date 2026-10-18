namespace EFT.UI;

public class TraderTabGroup : TabGroup
{
	internal static class LoyaltyLevelTabsConverter
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			private sealed class <<SelectTabs>g__FirstTabs|0>d : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
			{
				private int <>1__state; //Field offset: 0x10
				private Tab <>2__current; //Field offset: 0x18
				private int <>l__initialThreadId; //Field offset: 0x20
				public <>c__DisplayClass0_0 <>4__this; //Field offset: 0x28
				private int <i>5__2; //Field offset: 0x30

				private override Tab System.Collections.Generic.IEnumerator<Tab>.Current
				{
					[DebuggerHidden]
					private get { } //Length: 5
				}

				private override object System.Collections.IEnumerator.Current
				{
					[DebuggerHidden]
					private get { } //Length: 5
				}

				[DebuggerHidden]
				public <<SelectTabs>g__FirstTabs|0>d(int <>1__state) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.Generic.IEnumerable<Tab>.GetEnumerator() { }

				[DebuggerHidden]
				private override Tab System.Collections.Generic.IEnumerator<Tab>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Tab[] levelTabs; //Field offset: 0x10
			public int eliteLevelIndex; //Field offset: 0x18

			public <>c__DisplayClass0_0() { }

			[IteratorStateMachine(typeof(<<SelectTabs>g__FirstTabs|0>d))]
			internal IEnumerable <SelectTabs>g__FirstTabs|0() { }

		}


		public static Tab[] SelectTabs(Tab[] levelTabs, Tab allItemsTab, Tab eliteLevelTab, int eliteLevelIndex) { }

	}

	[CompilerGenerated]
	private int <SelectedLevel>k__BackingField; //Field offset: 0x38

	public private int SelectedLevel
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TraderTabGroup(Tab[] tabs, Tab initialTab, bool setAsLastSibling = true) { }

	[CompilerGenerated]
	public int get_SelectedLevel() { }

	protected virtual void SelectTabInternal(Tab tab, bool sendCallback = true) { }

	[CompilerGenerated]
	private void set_SelectedLevel(int value) { }

	public void Show(int level, bool sendCallback = true) { }

	public void UpdateInteractableTabs(int activeLevel) { }

}

