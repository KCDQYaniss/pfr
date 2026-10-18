namespace EFT;

internal class PlayerInputTranslator : IPlayerInputTranslator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__17_11; //Field offset: 0x8
		public static Callback <>9__17_12; //Field offset: 0x10
		public static Callback <>9__17_13; //Field offset: 0x18
		public static Callback <>9__17_14; //Field offset: 0x20
		public static Callback <>9__17_15; //Field offset: 0x28
		public static Callback <>9__17_16; //Field offset: 0x30
		public static Callback <>9__17_17; //Field offset: 0x38
		public static Callback <>9__17_18; //Field offset: 0x40
		public static Callback <>9__17_19; //Field offset: 0x48
		public static Callback <>9__17_20; //Field offset: 0x50
		public static Callback <>9__17_21; //Field offset: 0x58
		public static Callback <>9__27_1; //Field offset: 0x60
		public static Callback <>9__27_2; //Field offset: 0x68
		public static Callback <>9__29_0; //Field offset: 0x70

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__17_11(Result result) { }

		internal void <.ctor>b__17_12(Result result) { }

		internal void <.ctor>b__17_13(Result result) { }

		internal void <.ctor>b__17_14(Result result) { }

		internal void <.ctor>b__17_15(Result result) { }

		internal void <.ctor>b__17_16(Result result) { }

		internal void <.ctor>b__17_17(Result result) { }

		internal void <.ctor>b__17_18(Result result) { }

		internal void <.ctor>b__17_19(Result result) { }

		internal void <.ctor>b__17_20(Result result) { }

		internal void <.ctor>b__17_21(Result result) { }

		internal void <SetRandomGrenadeInHands>b__27_1(Result result) { }

		internal void <SetRandomGrenadeInHands>b__27_2(Result result) { }

		internal void <TryQuickKnifeKick>b__29_0(Result result) { }

	}

	private const float DOUBLE_CLICK_TIME = 0.4; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnMakeBindAction; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnMumbleStatusChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnMumbleDropdownStatusChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnQuickMumble; //Field offset: 0x28
	private readonly Player _player; //Field offset: 0x30
	private readonly List _commandsEquipmentSlots; //Field offset: 0x38
	private float _lastClickTime; //Field offset: 0x40
	private int _lastIndexClick; //Field offset: 0x44
	private readonly List _preAllocatedGrenadesList; //Field offset: 0x48
	private Nullable _prevGrenadeId; //Field offset: 0x50

	public override event Action OnMakeBindAction
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnMumbleDropdownStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnMumbleStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnQuickMumble
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	internal PlayerInputTranslator(Player player) { }

	[CompilerGenerated]
	private void <.ctor>b__17_0() { }

	[CompilerGenerated]
	private void <.ctor>b__17_1() { }

	[CompilerGenerated]
	private void <.ctor>b__17_10() { }

	[CompilerGenerated]
	private void <.ctor>b__17_2() { }

	[CompilerGenerated]
	private void <.ctor>b__17_3() { }

	[CompilerGenerated]
	private void <.ctor>b__17_4() { }

	[CompilerGenerated]
	private void <.ctor>b__17_5() { }

	[CompilerGenerated]
	private void <.ctor>b__17_6() { }

	[CompilerGenerated]
	private void <.ctor>b__17_7() { }

	[CompilerGenerated]
	private void <.ctor>b__17_8() { }

	[CompilerGenerated]
	private void <.ctor>b__17_9() { }

	[CompilerGenerated]
	private bool <SetRandomGrenadeInHands>b__27_0(ThrowWeap x) { }

	[CompilerGenerated]
	public override void add_OnMakeBindAction(Action value) { }

	[CompilerGenerated]
	public override void add_OnMumbleDropdownStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnMumbleStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnQuickMumble(Action value) { }

	protected override void ChangePointOfView() { }

	private bool CurrentWeaponIsUsedInRemoveOperation() { }

	private void HandleCancelMedsOperation() { }

	private bool HandleDoubleClick(int selectedIndex) { }

	[CompilerGenerated]
	public override void remove_OnMakeBindAction(Action value) { }

	[CompilerGenerated]
	public override void remove_OnMumbleDropdownStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnMumbleStatusChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnQuickMumble(Action value) { }

	protected override void SetRandomGrenadeInHands() { }

	private void SetSlotItem(int index, bool fast = false) { }

	private void ToggleVoip() { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

	private void TryQuickKnifeKick() { }

	private void UseCompletableItem() { }

}

