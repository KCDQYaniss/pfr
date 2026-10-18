namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerFirearmHandsController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public UnderbarrelReloadCommandMessage command; //Field offset: 0x18

		public <>c__DisplayClass37_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public ReloadMultiBarrelWeaponCommandMessage command; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public Ammo ammoToUnload; //Field offset: 0x10
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x18
		public Ammo shellToUnload; //Field offset: 0x20
		public StartReloadSingleBarrelCommandMessage command; //Field offset: 0x28

		public <>c__DisplayClass41_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public ReloadExternalMagazineCommandMessage command; //Field offset: 0x10
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x18
		public Slot slot; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		public Action removeItem; //Field offset: 0x30

		public <>c__DisplayClass50_0() { }

		internal bool <SpecificExecute>b__0(Slot s) { }

		internal void <SpecificExecute>b__1(Task _) { }

		internal void <SpecificExecute>b__2(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public Ammo ammoToLoad; //Field offset: 0x18

		public <>c__DisplayClass53_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

		internal void <SpecificExecute>b__2(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public LoadAmmoToChamberCommandMessage command; //Field offset: 0x10
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass54_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public LoadAmmoToUnderbarrelWeaponCommandMessage command; //Field offset: 0x18

		public <>c__DisplayClass55_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public DischargeAmmoFromChamberCommandMessage command; //Field offset: 0x18

		public <>c__DisplayClass57_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public LoadAmmoToCamoraCommandMessage command; //Field offset: 0x10
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass58_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public DischargeAmmoFromCamoraCommandMessage command; //Field offset: 0x18

		public <>c__DisplayClass60_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x10
		public MalfunctionCommandMessage command; //Field offset: 0x18

		public <>c__DisplayClass61_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public RepairMalfunctionCommandMessage command; //Field offset: 0x10
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass62_0() { }

		internal void <SpecificExecute>b__0(Task _) { }

		internal void <SpecificExecute>b__1(Task _) { }

		internal void <SpecificExecute>b__2(Task _) { }

		internal void <SpecificExecute>b__3(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public InsertMagazineCommandMessage command; //Field offset: 0x10
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x18
		public Slot slot; //Field offset: 0x20
		public Item item; //Field offset: 0x28

		public <>c__DisplayClass72_0() { }

		internal bool <SpecificExecute>b__0(Slot s) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public PullOutMagCommandMessage command; //Field offset: 0x10
		public Action removeItem; //Field offset: 0x18

		public <>c__DisplayClass73_0() { }

		internal bool <SpecificExecute>b__0(Slot s) { }

		internal void <SpecificExecute>b__1(Task _) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public UnderbarrelRangeValueCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public UnderbarrelReloadCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ToggleUnderbarrelCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ReloadMultiBarrelWeaponCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public StartReloadSingleBarrelCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public SetChamberStateCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public SetExternalMagazineStateMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ExamineWeaponCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ChangeFireModeCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public MagAndChamberStateCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public DryShotFirearmCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ReloadExternalMagazineCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ReloadInternalMagWithOpenBoltMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public SetFinishReloadInternalMagWithOpenBoltMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public RechamberCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadAmmoToChamberCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public LoadAmmoToUnderbarrelWeaponCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public DischargeAmmoFromUnderbarrelWeaponCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public DischargeAmmoFromChamberCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadAmmoToCamoraCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public BoltActionReloadAfterFireCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public DischargeAmmoFromCamoraCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public MalfunctionCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RepairMalfunctionCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IdleStateSyncCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public TacticalModeToggleCommandMessage command; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ScopeModeToggleCommandMessage command; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ReloadInternalMagazineCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public ReloadCylinderMagazineCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public SyncCylinderMagazineCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x20
		public FoldCommandMessage command; //Field offset: 0x28
		private FoldableComponent <foldable>5__2; //Field offset: 0x30
		private bool <fold>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InsertMagazineCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PullOutMagCommandMessage command; //Field offset: 0x20
		public ObservedPlayerFirearmHandsController <>4__this; //Field offset: 0x28
		private bool <magazineWithBelt>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct SpectatorScopeZoomInterpolation
	{
		public string SightId; //Field offset: 0x0
		public float StartZoomValue; //Field offset: 0x8
		public float TargetZoomValue; //Field offset: 0xC
		public float Duration; //Field offset: 0x10
		public float Elapsed; //Field offset: 0x14

	}

	private readonly FirearmAnimationHandsController _specificHandsAnimationController; //Field offset: 0x28
	private readonly ObservedPlayerHandsController _handsController; //Field offset: 0x30
	private readonly Dictionary _currentLightComponentsOnWeapon; //Field offset: 0x38
	private readonly Dictionary _currentScopeComponentsOnWeapon; //Field offset: 0x40
	private readonly Dictionary _currentScopeZoomHandlersOnWeapon; //Field offset: 0x48
	private readonly Dictionary _spectatorScopeZoomInterpolations; //Field offset: 0x50
	private readonly List _spectatorScopeZoomInterpolationKeys; //Field offset: 0x58
	private TacticalComboVisualController[] _tacticalComboVisualControllers; //Field offset: 0x60
	private SightModVisualControllers[] _scopeVisualControllers; //Field offset: 0x68
	private Transform _weaponHierarchy; //Field offset: 0x70
	private Weapon _weapon; //Field offset: 0x78
	private WeaponPrefab _weaponPrefab; //Field offset: 0x80
	private Launcher _underbarrelWeapon; //Field offset: 0x88
	private WeaponPrefab _underbarrelPrefab; //Field offset: 0x90
	private BifacialTransform _underbarrelFireport; //Field offset: 0x98
	private Firearms _underbarrelFirearms; //Field offset: 0xA0
	private Firearms _firearms; //Field offset: 0xA8

	private ObservedPlayerFirearmHandsController(ObservedPlayerHandsController handsController, FirearmAnimationHandsController handsAnimationController) { }

	[CompilerGenerated]
	private void <SpecificExecute>b__56_0(Task _) { }

	[CompilerGenerated]
	private void <SpecificExecute>b__59_0(Task _) { }

	private void ApplySpectatorScopeZoom(string sightId, float scopeZoomValue) { }

	public static ObservedPlayerFirearmHandsController CreateInstance(GameObject gameObject, ObservedPlayerHandsController handsController) { }

	public virtual void Destroy() { }

	public void DisableLightsState() { }

	public virtual Task Execute(ICommandMessage command) { }

	public void ExecuteSpectator(SpectatorScopeZoomStatusCommandMessage command) { }

	private void Initialize(WeaponPrefab weaponPrefab, Weapon weapon) { }

	private void InitUnderbarrelWeapon() { }

	public void ManualUpdate() { }

	private void ScopeCalibration() { }

	private void SetFireModeForCylinderMagazine(EFireMode fireMode) { }

	private void SetFireModeForWeaponObject(EFireMode fireMode) { }

	private void SetSpectatorSelectedScope(SightComponent scopeComponent, int scopeIndexInsideSight) { }

	private void SetUnderBarrelDeviceActive(bool val) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__61))]
	private Task SpecificExecute(MalfunctionCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__59))]
	private Task SpecificExecute(BoltActionReloadAfterFireCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__62))]
	private Task SpecificExecute(RepairMalfunctionCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__58))]
	private Task SpecificExecute(LoadAmmoToCamoraCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__57))]
	private Task SpecificExecute(DischargeAmmoFromChamberCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__60))]
	private Task SpecificExecute(DischargeAmmoFromCamoraCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__63))]
	private Task SpecificExecute(IdleStateSyncCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__67))]
	private Task SpecificExecute(ReloadCylinderMagazineCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__65))]
	private Task SpecificExecute(ScopeModeToggleCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__66))]
	private Task SpecificExecute(ReloadInternalMagazineCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__56))]
	private Task SpecificExecute(DischargeAmmoFromUnderbarrelWeaponCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__68))]
	private Task SpecificExecute(RollCylinderCommandMessage command) { }

	private Task SpecificExecute(CylinderCamoraIndexAndHammerStateCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__70))]
	private Task SpecificExecute(SyncCylinderMagazineCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__71))]
	private Task SpecificExecute(FoldCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__72))]
	private Task SpecificExecute(InsertMagazineCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__73))]
	private Task SpecificExecute(PullOutMagCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__64))]
	private Task SpecificExecute(TacticalModeToggleCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__55))]
	private Task SpecificExecute(LoadAmmoToUnderbarrelWeaponCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__49))]
	private Task SpecificExecute(DryShotFirearmCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__53))]
	private Task SpecificExecute(RechamberCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__36))]
	private Task SpecificExecute(UnderbarrelRangeValueCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__37))]
	private Task SpecificExecute(UnderbarrelReloadCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__38))]
	private Task SpecificExecute(ToggleUnderbarrelCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__40))]
	private Task SpecificExecute(ReloadMultiBarrelWeaponCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__54))]
	private Task SpecificExecute(LoadAmmoToChamberCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__42))]
	private Task SpecificExecute(SetChamberStateCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__43))]
	private Task SpecificExecute(SetExternalMagazineStateMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__41))]
	private Task SpecificExecute(StartReloadSingleBarrelCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__45))]
	private Task SpecificExecute(ChangeFireModeCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__48))]
	private Task SpecificExecute(MagAndChamberStateCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__50))]
	private Task SpecificExecute(ReloadExternalMagazineCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__51))]
	private Task SpecificExecute(ReloadInternalMagWithOpenBoltMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__52))]
	private Task SpecificExecute(SetFinishReloadInternalMagWithOpenBoltMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__44))]
	private Task SpecificExecute(ExamineWeaponCommandMessage command) { }

	private void StartSpectatorScopeZoomInterpolation(string sightId, float startZoomValue, float targetZoomValue, float duration) { }

	private void UpdateAmmoInChamberVisual() { }

	private void UpdateBeams() { }

	private void UpdateScopes() { }

	private void UpdateScopesModeForSpectating() { }

	public void UpdateTacticalComboVisualControllers() { }

	public void UpdateWeaponScopesForSpectating() { }

}

