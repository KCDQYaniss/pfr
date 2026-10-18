namespace EFT.UI;

public sealed class TraderDialogScreen : BaseDialogScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__10_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public IHealthController healthController; //Field offset: 0x10
		public bool closed; //Field offset: 0x18
		public TraderDialogScreenController controller; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <SubscribeCloseDialogOnRaidDamageOrDeath>b__0() { }

		internal void <SubscribeCloseDialogOnRaidDamageOrDeath>g__OnDamageTaken|2(EBodyPart _, float damage, DamageInfo info) { }

		internal void <SubscribeCloseDialogOnRaidDamageOrDeath>g__OnDied|1(EDamageType _) { }

		internal void <SubscribeCloseDialogOnRaidDamageOrDeath>g__UnsubscribeAndClose|4() { }

	}

	internal sealed class TraderDialogScreenController : EftDialogScreenController
	{
		public readonly Profile Profile; //Field offset: 0x60
		public readonly string TraderId; //Field offset: 0x68
		public readonly QuestController QuestController; //Field offset: 0x70
		public readonly InventoryController InventoryController; //Field offset: 0x78
		public readonly ITraderAnimationController AnimationController; //Field offset: 0x80
		public readonly Nullable DialogId; //Field offset: 0x88
		public readonly bool RaidInteractiveDialog; //Field offset: 0xA8

		protected virtual EStateSwitcher IgnorePlayerInput
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public TraderDialogScreenController(Profile profile, string traderId, QuestController questController, InventoryController inventoryController, ITraderAnimationController animationController, BaseTraderDialogController dialogController, Nullable dialogId = null, bool raidInteractiveDialog = false) { }

		protected virtual EStateSwitcher get_IgnorePlayerInput() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

	}

	[SerializeField]
	private TraderDialogWindow _dialogWindow; //Field offset: 0xB8
	private Profile _profile; //Field offset: 0xC0
	private MongoID _traderId; //Field offset: 0xC8
	private QuestController _questController; //Field offset: 0xE0
	private InventoryController _inventoryController; //Field offset: 0xE8
	private ITraderAnimationController _animationController; //Field offset: 0xF0
	private Nullable _dialogId; //Field offset: 0xF8

	protected virtual bool CanSkipAnimation
	{
		 get { } //Length: 257
	}

	public TraderDialogScreen() { }

	[CompilerGenerated]
	private void <InitDialog>b__11_0() { }

	[CompilerGenerated]
	internal static bool <SubscribeCloseDialogOnRaidDamageOrDeath>g__CheckDamageTypeForClosure|12_3(DamageInfo info) { }

	private void ActionFinishedHandler(DialogAction action) { }

	public virtual void Close() { }

	protected virtual bool get_CanSkipAnimation() { }

	private void HandlePurchaseService(DialogAction action) { }

	private void HandleQuitAction() { }

	private void InitDialog() { }

	public virtual void Show(TraderDialogScreenController controller) { }

	private void SubscribeCloseDialogOnRaidDamageOrDeath(TraderDialogScreenController controller) { }

}

