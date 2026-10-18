namespace EFT;

public class EftGamePlayerOwner : CommonPlayerOwner
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public EftGamePlayerOwner <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <ShowInventoryScreenLoot>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public RaidInventoryScreenController inventoryScreenController; //Field offset: 0x10
		public IHealthController healthController; //Field offset: 0x18
		public EftGamePlayerOwner <>4__this; //Field offset: 0x20
		public Action exitAction; //Field offset: 0x28

		public <>c__DisplayClass9_0() { }

		internal void <ShowInventoryScreen>g__InventoryScreenExitAction|1() { }

		internal void <ShowInventoryScreen>g__OnPlayerDiedEvent|0(EDamageType obj) { }

	}

	[CompilerGenerated]
	private sealed class <CloseBattleUi>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <CloseBattleUi>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public EftGamePlayerOwner() { }

	[CompilerGenerated]
	private void <Init>b__2_0() { }

	[CompilerGenerated]
	private void <Init>b__2_1() { }

	[CompilerGenerated]
	private void <Init>b__2_2() { }

	[CompilerGenerated]
	private void <Init>g__DiedDelegate|2_4(EDamageType damage) { }

	[CompilerGenerated]
	private void <Init>g__ScreeDelegate|2_3(EEftScreenType screenType) { }

	[CompilerGenerated]
	private void <ShowBattleUIScreen>b__10_0() { }

	[CompilerGenerated]
	private void <ShowBattleUIScreen>b__10_1() { }

	[CompilerGenerated]
	private void <TranslateInventoryScreenInput>b__4_0() { }

	[IteratorStateMachine(typeof(<CloseBattleUi>d__7))]
	protected virtual IEnumerator CloseBattleUi() { }

	public virtual void CloseInventoryIfOpen() { }

	public static TPlayerOwner Create(Player player, IInputTree inputTree, InsuranceCompany insurance, IEftSession session, GameUI gameUI, GameDateTime gameDateTime, Location location) { }

	public static EftGamePlayerOwner Create(Player player, IInputTree inputTree, InsuranceCompany insurance, IEftSession session, GameUI gameUI, GameDateTime gameDateTime, Location location) { }

	protected virtual void Init() { }

	protected virtual void InitBattleUIScreen() { }

	protected virtual void MumbleStatusChangedHandler(bool active) { }

	protected virtual void ShowBattleUIScreen() { }

	protected override void ShowInventoryScreen(Action exitAction, IHealthController healthController, InventoryController controller, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab tab, bool showAsGridContent = false) { }

	public virtual void ShowInventoryScreenLoot(CompoundItem loot, Action callback, bool isFakeContainer = false) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual bool TranslateExitScreenInput(ECommand command) { }

	protected virtual bool TranslateInventoryScreenInput(ECommand command) { }

}

