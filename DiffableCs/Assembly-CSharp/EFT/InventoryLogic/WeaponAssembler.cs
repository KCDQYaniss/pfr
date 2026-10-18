namespace EFT.InventoryLogic;

public static class WeaponAssembler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__3_1; //Field offset: 0x10
		public static Func <>9__5_0; //Field offset: 0x18
		public static Func <>9__5_1; //Field offset: 0x20
		public static Func <>9__5_2; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal ModWithSlot <AssembleAsync>b__5_0(Mod mod, Slot slot) { }

		internal bool <AssembleAsync>b__5_1(Mod item) { }

		internal Mod <AssembleAsync>b__5_2(Mod mod, Slot _) { }

		internal Item <CheckIfAlreadyBuilt>b__3_0(Slot x) { }

		internal MongoID <CheckIfAlreadyBuilt>b__3_1(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Weapon itemBody; //Field offset: 0x10
		public Weapon buildWeapon; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20
		public IEnumerable playerItems; //Field offset: 0x28

		public <>c__DisplayClass4_0() { }

		internal Option <Assemble>b__0() { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass5_0
	{
		public List modsToInstall; //Field offset: 0x0
		public List playerMods; //Field offset: 0x8
		public List modsWithSlots; //Field offset: 0x10
		public Grid sortingTableGrid; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20
		public List moveOperations; //Field offset: 0x28

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public Mod item; //Field offset: 0x10

		public <>c__DisplayClass5_1() { }

		internal bool <AssembleAsync>b__4(ModWithSlot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_2
	{
		public ModWithSlot slot; //Field offset: 0x10

		public <>c__DisplayClass5_2() { }

		internal bool <AssembleAsync>b__5(Mod playerItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_3
	{
		public Mod innerMod; //Field offset: 0x10

		public <>c__DisplayClass5_3() { }

		internal bool <AssembleAsync>b__7(ModWithSlot x) { }

	}

	[CompilerGenerated]
	private struct <Assemble>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Weapon itemBody; //Field offset: 0x20
		public Weapon buildWeapon; //Field offset: 0x28
		public InventoryController inventoryController; //Field offset: 0x30
		public IEnumerable playerItems; //Field offset: 0x38
		private <>c__DisplayClass4_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private IEnumerator <>7__wrap1; //Field offset: 0x50
		private MoveResult <moveOption>5__3; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <AssembleOperationsList>d__7 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private OperationResult <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		private Item item; //Field offset: 0x30
		public Item <>3__item; //Field offset: 0x38
		private List modsWithSlots; //Field offset: 0x40
		public List <>3__modsWithSlots; //Field offset: 0x48
		private ItemController itemController; //Field offset: 0x50
		public ItemController <>3__itemController; //Field offset: 0x58
		private Weapon <weapon>5__2; //Field offset: 0x60
		private List <original>5__3; //Field offset: 0x68
		private List <moved>5__4; //Field offset: 0x70
		private int <i>5__5; //Field offset: 0x78
		private Enumerator <>7__wrap5; //Field offset: 0x80
		private Mod <currentMod>5__7; //Field offset: 0x98
		private string <currentSlot>5__8; //Field offset: 0xA0
		private IEnumerator <>7__wrap8; //Field offset: 0xA8
		private OperationResult <operationResult>5__10; //Field offset: 0xB0

		private override OperationResult System.Collections.Generic.IEnumerator<Diz.LanguageExtensions.OperationResult<EFT.InventoryLogic.MoveResult>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <AssembleOperationsList>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<Diz.LanguageExtensions.OperationResult<EFT.InventoryLogic.MoveResult>>.GetEnumerator() { }

		[DebuggerHidden]
		private override OperationResult System.Collections.Generic.IEnumerator<Diz.LanguageExtensions.OperationResult<EFT.InventoryLogic.MoveResult>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class AbortException : Exception
	{
		public readonly Error Error; //Field offset: 0x90

		public AbortException(Error error) { }

	}

	private sealed class ModWithSlot
	{
		public readonly Mod Mod; //Field offset: 0x10
		public readonly string SlotId; //Field offset: 0x18

		public ModWithSlot(Mod mod, string slotId) { }

		public virtual string ToString() { }

	}


	[CompilerGenerated]
	internal static void <AssembleAsync>g__ProcessItemForSlot|5_6(Mod processingItem, ModWithSlot processingSlot, ref <>c__DisplayClass5_0 unnamed_param_2) { }

	[CompilerGenerated]
	internal static void <AssembleAsync>g__TryAddOperation|5_3(OperationResult moveResult, ref <>c__DisplayClass5_0 unnamed_param_1) { }

	[AsyncStateMachine(typeof(<Assemble>d__4))]
	public static Task Assemble(Weapon itemBody, Weapon buildWeapon, InventoryController inventoryController, IEnumerable playerItems) { }

	private static Option AssembleAsync(Weapon itemBody, Weapon buildWeapon, InventoryController inventoryController, IEnumerable playerItems, bool simulate = true) { }

	[IteratorStateMachine(typeof(<AssembleOperationsList>d__7))]
	private static IEnumerable AssembleOperationsList(Item item, List modsWithSlots, ItemController itemController) { }

	private static bool CheckError(Error error) { }

	public static bool CheckIfAlreadyBuilt(IEnumerable installedMods, Weapon assemblingWeapon) { }

	private static List ConvertSlotsLayerByLayer(Stack slots, Func selector) { }

	public static List GetInstalledMods(Weapon weapon) { }

}

