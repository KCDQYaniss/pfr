namespace EFT;

public class Player : MonoBehaviour, IPlayer, IAddHandler, IItemRelatedView, IRemoveHandler, ISetInHandsHandler, IPlatformTransportee, IDissonancePlayer
{
	[CompilerGenerated]
	private sealed class <<SwitchHeadLightsAnimation>g__DelayedInvocation|498_0>d : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <<SwitchHeadLightsAnimation>g__DelayedInvocation|498_0>d(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__187_0; //Field offset: 0x8
		public static Callback <>9__187_1; //Field offset: 0x10
		public static Func <>9__498_1; //Field offset: 0x18
		public static Func <>9__726_0; //Field offset: 0x20
		public static Func <>9__743_0; //Field offset: 0x28
		public static Func <>9__1083_0; //Field offset: 0x30
		public static Func <>9__1083_1; //Field offset: 0x38
		public static Func <>9__1083_2; //Field offset: 0x40
		public static Func <>9__1083_3; //Field offset: 0x48
		public static Action <>9__1083_7; //Field offset: 0x50
		public static Func <>9__1083_4; //Field offset: 0x58
		public static Func <>9__1115_0; //Field offset: 0x60
		public static Func <>9__1115_1; //Field offset: 0x68
		public static Func <>9__1115_2; //Field offset: 0x70
		public static Func <>9__1115_3; //Field offset: 0x78
		public static Func <>9__1280_0; //Field offset: 0x80
		public static Func <>9__1448_0; //Field offset: 0x88
		public static Func <>9__1470_0; //Field offset: 0x90
		public static Func <>9__1470_1; //Field offset: 0x98
		public static Func <>9__1470_2; //Field offset: 0xA0
		public static Callback <>9__1592_0; //Field offset: 0xA8
		public static Callback <>9__1595_0; //Field offset: 0xB0
		public static Callback <>9__1632_1; //Field offset: 0xB8
		public static Callback <>9__1642_0; //Field offset: 0xC0

		private static <>c() { }

		public <>c() { }

		internal float <.cctor>b__1663_0() { }

		internal Action <CreateSlotObservers>b__1083_0(NightVisionComponent nv, Action handler) { }

		internal Action <CreateSlotObservers>b__1083_1(ThermalVisionComponent tv, Action handler) { }

		internal Action <CreateSlotObservers>b__1083_2(FaceShieldComponent fs, Action handler) { }

		internal Action <CreateSlotObservers>b__1083_3(FaceShieldComponent fs, Action handler) { }

		internal Action <CreateSlotObservers>b__1083_4(FaceCoverMaskComponent _, Action _) { }

		internal void <CreateSlotObservers>b__1083_7() { }

		internal EDeafStrength <GetHeadphonesTemplateFromEquipment>b__1115_0(CompositeArmorComponent x) { }

		internal int <GetHeadphonesTemplateFromEquipment>b__1115_1(EDeafStrength d) { }

		internal EDeafStrength <GetHeadphonesTemplateFromEquipment>b__1115_2(CompositeArmorComponent x) { }

		internal int <GetHeadphonesTemplateFromEquipment>b__1115_3(EDeafStrength d) { }

		internal void <HideWeapon>b__1592_0(Result result) { }

		internal void <OperateStationaryWeapon>b__187_0(Result result) { }

		internal void <OperateStationaryWeapon>b__187_1(Result result) { }

		internal bool <RemoveSecretExitItemsInPocketsOnSessionEnd>b__1280_0(Item item) { }

		internal bool <RemoveSecretExitItemsOnSessionEnd>b__1470_0(Slot slot) { }

		internal IEnumerable <RemoveSecretExitItemsOnSessionEnd>b__1470_1(Slot slot) { }

		internal bool <RemoveSecretExitItemsOnSessionEnd>b__1470_2(Item item) { }

		internal bool <RemoveVolume>b__726_0(BetterPropagationVolume x) { }

		internal void <SetStationaryWeapon>b__1595_0(Result result) { }

		internal IEnumerable <SetupSoundsFromFaceShieldComponent>b__743_0(CompositeArmorComponent x) { }

		internal bool <StoreRenderer>b__1448_0(Renderer x) { }

		internal bool <SwitchHeadLightsAnimation>b__498_1(TacticalComboVisualController x) { }

		internal void <TryProceed>b__1632_1(Result _) { }

		internal void <TrySetInHands>b__1642_0(Result _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1078_0
	{
		public Player <>4__this; //Field offset: 0x10
		public EPointOfView pointOfView; //Field offset: 0x18

		public <>c__DisplayClass1078_0() { }

		internal void <Init>b__0(bool _) { }

		internal void <Init>b__1(EPlayerState prevState, EPlayerState nextState) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1083_0
	{
		public Action togglableSub; //Field offset: 0x10
		public Action hitSub; //Field offset: 0x18

		public <>c__DisplayClass1083_0() { }

		internal void <CreateSlotObservers>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1083_1
	{
		public Action togglableSub; //Field offset: 0x10
		public Action hitSub; //Field offset: 0x18

		public <>c__DisplayClass1083_1() { }

		internal void <CreateSlotObservers>b__6() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1104_0
	{
		public Player <>4__this; //Field offset: 0x10
		public IHealthEffect effect; //Field offset: 0x18

		public <>c__DisplayClass1104_0() { }

		internal void <OnHealthEffectAdded>b__0() { }

		internal void <OnHealthEffectAdded>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1119_0
	{
		public Slot[] headSlots; //Field offset: 0x10
		public Slot[] armorSlots; //Field offset: 0x18

		public <>c__DisplayClass1119_0() { }

		internal bool <OnItemAddedOrRemoved>b__0(ItemAddress loc) { }

		internal bool <OnItemAddedOrRemoved>b__1(ItemAddress loc) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1281_0
	{
		public MongoID questItemId; //Field offset: 0x10

		public <>c__DisplayClass1281_0() { }

		internal bool <RemoveQuestItemsOnSessionEnd>b__0(Item i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1281_1
	{
		public MongoID removeTemplateId; //Field offset: 0x10

		public <>c__DisplayClass1281_1() { }

		internal bool <RemoveQuestItemsOnSessionEnd>b__1(Item i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1338_0
	{
		public Player <>4__this; //Field offset: 0x10
		public float armorDamage; //Field offset: 0x18

		public <>c__DisplayClass1338_0() { }

		internal void <OnArmorDamaged>b__0() { }

		internal void <OnArmorDamaged>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1387_0
	{
		public EBodyPartColliderType colliderType; //Field offset: 0x10

		public <>c__DisplayClass1387_0() { }

		internal bool <KillMe>b__0(BodyPartCollider hitCollider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1402_0
	{
		public LootableContainer container; //Field offset: 0x10
		public Player <>4__this; //Field offset: 0x18

		public <>c__DisplayClass1402_0() { }

		internal void <TryInteractionCallback>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1415_0
	{
		public Player <>4__this; //Field offset: 0x10
		public bool onCorpse; //Field offset: 0x18

		public <>c__DisplayClass1415_0() { }

		internal void <InventoryControllerOnItemFound>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1417_0
	{
		public Player <>4__this; //Field offset: 0x10
		public int count; //Field offset: 0x18

		public <>c__DisplayClass1417_0() { }

		internal void <OnRaidLoadedAmmoHandler>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1418_0
	{
		public Player <>4__this; //Field offset: 0x10
		public int count; //Field offset: 0x18

		public <>c__DisplayClass1418_0() { }

		internal void <OnRaidUnloadedAmmoHandler>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1421_0
	{
		public Player <>4__this; //Field offset: 0x10
		public float diff; //Field offset: 0x18

		public <>c__DisplayClass1421_0() { }

		internal void <OnHealthHydrationChanged>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1422_0
	{
		public Player <>4__this; //Field offset: 0x10
		public float damage; //Field offset: 0x18

		public <>c__DisplayClass1422_0() { }

		internal void <OnHealthApplyDamage>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1426_0
	{
		public Player <>4__this; //Field offset: 0x10
		public float diff; //Field offset: 0x18

		public <>c__DisplayClass1426_0() { }

		internal void <OnHealthEnergyChanged>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1434_0
	{
		public float distance; //Field offset: 0x10
		public Player <>4__this; //Field offset: 0x18

		public <>c__DisplayClass1434_0() { }

		internal void <MovementContextOnStateChanged>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1434_1
	{
		public float distance; //Field offset: 0x10
		public Player <>4__this; //Field offset: 0x18

		public <>c__DisplayClass1434_1() { }

		internal void <MovementContextOnStateChanged>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1503_0
	{
		public VoiceBroadcastTrigger broadcastTrigger; //Field offset: 0x10

		public <>c__DisplayClass1503_0() { }

		internal void <AddVoiceBroadcastTrigger>b__0(int value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1585_0
	{
		public Player <>4__this; //Field offset: 0x10
		public AbstractHandsController controller; //Field offset: 0x18
		public Action callback; //Field offset: 0x20
		public TaskCompletionSource onControllerAppeared; //Field offset: 0x28

		public <>c__DisplayClass1585_0() { }

		internal void <SpawnController>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1609_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass1609_0() { }

		internal void <TrySetLastEquippedWeapon>b__0(Result result) { }

		internal void <TrySetLastEquippedWeapon>b__1(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1610_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Callback completeCallback; //Field offset: 0x18

		public <>c__DisplayClass1610_0() { }

		internal Item <SetFirstAvailableItem>b__0(EquipmentSlot x) { }

		internal bool <SetFirstAvailableItem>b__1(Item x) { }

		internal void <SetFirstAvailableItem>b__2(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1612_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass1612_0() { }

		internal void <SetInHands>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1622_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Weapon weapon; //Field offset: 0x18

		public <>c__DisplayClass1622_0() { }

		internal AIFirearmController <Proceed>b__0() { }

		internal FirearmController <Proceed>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1623_0
	{
		public Player <>4__this; //Field offset: 0x10
		public ThrowWeap throwWeap; //Field offset: 0x18

		public <>c__DisplayClass1623_0() { }

		internal GrenadeHandsController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1624_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Meds meds; //Field offset: 0x18
		public OneAndList bodyParts; //Field offset: 0x20
		public int animationVariant; //Field offset: 0x30

		public <>c__DisplayClass1624_0() { }

		internal MedsController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1625_0
	{
		public Player <>4__this; //Field offset: 0x10
		public FoodDrink foodDrink; //Field offset: 0x18
		public OneAndList bodyParts; //Field offset: 0x20
		public float amount; //Field offset: 0x30
		public int animationVariant; //Field offset: 0x34

		public <>c__DisplayClass1625_0() { }

		internal MedsController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1626_0
	{
		public Player <>4__this; //Field offset: 0x10
		public RecorderItem recorder; //Field offset: 0x18
		public RecorderHandler recorderHandler; //Field offset: 0x20

		public <>c__DisplayClass1626_0() { }

		internal RecorderHandsController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1627_0
	{
		public Player <>4__this; //Field offset: 0x10
		public KnifeComponent knife; //Field offset: 0x18

		public <>c__DisplayClass1627_0() { }

		internal KnifeController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1628_0`1
	{
		public Player <>4__this; //Field offset: 0x0
		public Item item; //Field offset: 0x0

		public <>c__DisplayClass1628_0`1() { }

		internal T <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1629_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18

		public <>c__DisplayClass1629_0() { }

		internal QuickUseItemController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1630_0
	{
		public Player <>4__this; //Field offset: 0x10
		public ThrowWeap throwWeap; //Field offset: 0x18

		public <>c__DisplayClass1630_0() { }

		internal QuickGrenadeThrowHandsController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1631_0
	{
		public Player <>4__this; //Field offset: 0x10
		public KnifeComponent knife; //Field offset: 0x18

		public <>c__DisplayClass1631_0() { }

		internal QuickKnifeKickController <Proceed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1632_0
	{
		public Callback completeCallback; //Field offset: 0x10
		public Player <>4__this; //Field offset: 0x18

		public <>c__DisplayClass1632_0() { }

		internal void <TryProceed>b__3(Result result) { }

		internal void <TryProceed>b__4(Result result) { }

		internal void <TryProceed>b__5(Result result) { }

		internal void <TryProceed>b__6(Result result) { }

		internal void <TryProceed>b__7(Result result) { }

		internal void <TryProceed>b__8(Result result) { }

		internal void <TryProceed>g__ErrorAction|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1632_1
	{
		public Weapon <weapon>5__2; //Field offset: 0x10
		public <>c__DisplayClass1632_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass1632_1() { }

		internal void <TryProceed>b__2(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1635_0
	{
		public Callback completeCallback; //Field offset: 0x10

		public <>c__DisplayClass1635_0() { }

		internal void <ProceedPortableRangeFinder>b__0(Result result) { }

		internal void <ProceedPortableRangeFinder>b__1(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1636_0
	{
		public Callback completeCallback; //Field offset: 0x10

		public <>c__DisplayClass1636_0() { }

		internal void <ProceedRadioTransmitter>b__0(Result result) { }

		internal void <ProceedRadioTransmitter>b__1(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1640_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass1640_0() { }

		internal void <TryRemoveFromHands>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1641_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass1641_0() { }

		internal void <SetControllerInsteadRemovedOne>b__0(Result result) { }

		internal void <SetControllerInsteadRemovedOne>b__1(Result result) { }

		internal void <SetControllerInsteadRemovedOne>b__2(Result result) { }

		internal void <SetControllerInsteadRemovedOne>b__3(Result result) { }

		internal Item <SetControllerInsteadRemovedOne>b__4(EquipmentSlot x) { }

		internal bool <SetControllerInsteadRemovedOne>b__5(Item x) { }

		internal void <SetControllerInsteadRemovedOne>b__6(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1642_0
	{
		public Player <>4__this; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass1642_0() { }

		internal void <TrySetInHands>b__1(Result result) { }

		internal void <TrySetInHands>b__2(IResult error) { }

		internal void <TrySetInHands>b__3(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass462_0
	{
		public Player <>4__this; //Field offset: 0x10
		public IWeapon weapon; //Field offset: 0x18

		public <>c__DisplayClass462_0() { }

		internal void <OnMakingShot>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <FakeCallbackCoroutine>d__1645 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <FakeCallbackCoroutine>d__1645(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Gear>d__790 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20
		public float volume; //Field offset: 0x28

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
		public <Gear>d__790(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <get_ConditionalControllers>d__1222 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IConditionalController <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Player <>4__this; //Field offset: 0x28

		private override IConditionalController System.Collections.Generic.IEnumerator<EFT.Quests.IConditionalController>.Current
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
		public <get_ConditionalControllers>d__1222(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.IConditionalController>.GetEnumerator() { }

		[DebuggerHidden]
		private override IConditionalController System.Collections.Generic.IEnumerator<EFT.Quests.IConditionalController>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <HitDelay>d__463 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

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
		public <HitDelay>d__463(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Idle>d__792 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20
		public EPlayerState state; //Field offset: 0x28

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
		public <Idle>d__792(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <InflictSelfDamage>d__1433 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <InflictSelfDamage>d__1433(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <Init>d__1078 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player <>4__this; //Field offset: 0x20
		public EPointOfView pointOfView; //Field offset: 0x28
		public bool async; //Field offset: 0x2C
		public int playerRaidId; //Field offset: 0x30
		public Profile profile; //Field offset: 0x38
		public bool aiControlled; //Field offset: 0x40
		public IStatisticsManager statisticsManager; //Field offset: 0x48
		public PlayerInventoryController inventoryController; //Field offset: 0x50
		private <>c__DisplayClass1078_0 <>8__1; //Field offset: 0x58
		public QuestController questController; //Field offset: 0x60
		public QuestLocationObjectsController questLocationObjectsController; //Field offset: 0x68
		public AchievementsController achievementsController; //Field offset: 0x70
		public PrestigeController prestigeController; //Field offset: 0x78
		public SeasonalRewardController seasonalRewardController; //Field offset: 0x80
		public BaseTraderDialogController dialogController; //Field offset: 0x88
		public ICustomizationFilter filter; //Field offset: 0x90
		public IHealthController healthController; //Field offset: 0x98
		public string layerName; //Field offset: 0xA0
		public Quaternion rotation; //Field offset: 0xA8
		public EVoipState voipState; //Field offset: 0xB8
		private object <>u__1; //Field offset: 0xC0
		private TaskAwaiter <>u__2; //Field offset: 0xC8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <LateFixedUpdateRoutine>d__1263 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <LateFixedUpdateRoutine>d__1263(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <ManageGameQuests>d__1429 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <OnDeadCoroutine>d__1366 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool needDropItem; //Field offset: 0x20
		public Player <>4__this; //Field offset: 0x28

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
		public <OnDeadCoroutine>d__1366(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <OnGameSessionEnd>d__1405 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player <>4__this; //Field offset: 0x20
		public ExitStatus exitStatus; //Field offset: 0x28
		public float pastTime; //Field offset: 0x2C
		public string locationId; //Field offset: 0x30
		public string exitName; //Field offset: 0x38
		private bool <inRaid>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <Run>d__793 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20
		public EPlayerState state; //Field offset: 0x28

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
		public <Run>d__793(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Sprint>d__791 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20
		public EPlayerState state; //Field offset: 0x28

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
		public <Sprint>d__791(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <StoreRenderer>d__1448 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <StoreRenderer>d__1448(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SupportAudioSourceCoroutine>d__752 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20

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
		public <SupportAudioSourceCoroutine>d__752(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <WaitWeaponInventory>d__1331 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player <>4__this; //Field offset: 0x20
		private bool <inInventoryWeaponState>5__2; //Field offset: 0x28

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
		public <WaitWeaponInventory>d__1331(int <>1__state) { }

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

	internal abstract class AbstractHandsController : MonoBehaviour, IHandsController, IEventsConsumer
	{
		[CompilerGenerated]
		private float <AimingSmoothSensitivity>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Action OnAimingChanged; //Field offset: 0x28
		[CompilerGenerated]
		private Transform <WeaponRoot>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private bool <Destroyed>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private AnimationEventsEmitter <AnimationEventsEmitter>k__BackingField; //Field offset: 0x40
		protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x48

		public event Action OnAimingChanged
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override float AimingSensitivity
		{
			 get { } //Length: 9
		}

		public override float AimingSmoothSensitivity
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public AnimationEventsEmitter AnimationEventsEmitter
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public override int AnimationVariant
		{
			 get { } //Length: 3
		}

		public abstract GameObject ControllerGameObject
		{
			 get { } //Length: 0
		}

		public override bool Destroyed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public abstract FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 0
		}

		public abstract TransformLinks HandsHierarchy
		{
			 get { } //Length: 0
		}

		public override bool IsAiming
		{
			 get { } //Length: 3
			 set { } //Length: 3
		}

		public override bool IsAimingButtonPressing
		{
			 get { } //Length: 3
			 set { } //Length: 3
		}

		public override Item Item
		{
			 get { } //Length: 20
		}

		public override string LoggerDistinctId
		{
			 get { } //Length: 49
		}

		public Transform WeaponRoot
		{
			[CompilerGenerated]
			 get { } //Length: 76
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected AbstractHandsController() { }

		[CompilerGenerated]
		public void add_OnAimingChanged(Action value) { }

		protected override void AimingChanged(bool newValue) { }

		public abstract void BallisticUpdate(float deltaTime) { }

		public override void BipodClose() { }

		public override void BipodOpen() { }

		public abstract void BlindFire(int b) { }

		public abstract bool CanExecute(IInventoryOperation operation) { }

		public override bool CanInteract() { }

		public abstract bool CanRemove() { }

		public override void Destroy() { }

		public abstract void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public abstract void EmitEvents() { }

		public abstract void Execute(IInventoryOperation operation, Callback callback) { }

		public override void FastForwardCurrentOutdatedState() { }

		public override void FastForwardCurrentState() { }

		public override float get_AimingSensitivity() { }

		[CompilerGenerated]
		public override float get_AimingSmoothSensitivity() { }

		[CompilerGenerated]
		public AnimationEventsEmitter get_AnimationEventsEmitter() { }

		public override int get_AnimationVariant() { }

		public abstract GameObject get_ControllerGameObject() { }

		[CompilerGenerated]
		public override bool get_Destroyed() { }

		public abstract FirearmsAnimator get_FirearmsAnimator() { }

		public abstract TransformLinks get_HandsHierarchy() { }

		public override bool get_IsAiming() { }

		public override bool get_IsAimingButtonPressing() { }

		public override Item get_Item() { }

		public override string get_LoggerDistinctId() { }

		[CompilerGenerated]
		public Transform get_WeaponRoot() { }

		public override float GetAnimatorFloatParam(int hash) { }

		protected abstract Item GetItem() { }

		private override void IEventsConsumer.AimReady() { }

		private override void IEventsConsumer.DropWeapon() { }

		private override void IEventsConsumer.IdleReady() { }

		private override void IEventsConsumer.OnAddAmmoInChamber() { }

		private override void IEventsConsumer.OnAddAmmoInMag() { }

		private override void IEventsConsumer.OnArm() { }

		private override void IEventsConsumer.OnComboPlanning() { }

		private override void IEventsConsumer.OnCook() { }

		private override void IEventsConsumer.OnCurrentAnimStateEnded() { }

		private override void IEventsConsumer.OnDeactivateObject(int objectID) { }

		private override void IEventsConsumer.OnDelAmmoChamber() { }

		private override void IEventsConsumer.OnDelAmmoFromMag() { }

		private override void IEventsConsumer.OnDisarm() { }

		private override void IEventsConsumer.OnFireEnd() { }

		private override void IEventsConsumer.OnFiringBullet() { }

		private override void IEventsConsumer.OnFoldOff() { }

		private override void IEventsConsumer.OnFoldOn() { }

		private override void IEventsConsumer.OnIdleStart() { }

		private override void IEventsConsumer.OnLauncherAppeared() { }

		private override void IEventsConsumer.OnLauncherDisappeared() { }

		private override void IEventsConsumer.OnMagHide() { }

		private override void IEventsConsumer.OnMagIn() { }

		private override void IEventsConsumer.OnMagOut() { }

		private override void IEventsConsumer.OnMagShow() { }

		private override void IEventsConsumer.OnMalfunctionOff() { }

		private override void IEventsConsumer.OnMessageName() { }

		private override void IEventsConsumer.OnModChanged() { }

		private override void IEventsConsumer.OnOffBoltCatch() { }

		private override void IEventsConsumer.OnOnBoltCatch() { }

		private override void IEventsConsumer.OnPutMagToRig() { }

		private override void IEventsConsumer.OnRemoveShell() { }

		private override void IEventsConsumer.OnReplaceSecondMag() { }

		private override void IEventsConsumer.OnSetActiveObject(int objectID) { }

		private override void IEventsConsumer.OnShellEject() { }

		private override void IEventsConsumer.OnShowAmmo(bool BoolParam) { }

		private override void IEventsConsumer.OnShowMag() { }

		private override void IEventsConsumer.OnSliderOut() { }

		private override void IEventsConsumer.OnSound(string StringParam) { }

		private override void IEventsConsumer.OnStartUtilityOperation() { }

		private override void IEventsConsumer.OnThirdAction(int IntParam) { }

		private override void IEventsConsumer.OnUseSecondMagForReload() { }

		private override void IEventsConsumer.OnWeapIn() { }

		private override void IEventsConsumer.OnWeapOut() { }

		private override void IEventsConsumer.OutUse() { }

		protected override void IEventsConsumerOnAddAmmoInChamber() { }

		protected override void IEventsConsumerOnAddAmmoInMag() { }

		protected override void IEventsConsumerOnArm() { }

		protected override void IEventsConsumerOnComboPlanning() { }

		protected override void IEventsConsumerOnCook() { }

		protected override void IEventsConsumerOnDelAmmoChamber() { }

		protected override void IEventsConsumerOnDelAmmoFromMag() { }

		protected override void IEventsConsumerOnDisarm() { }

		protected override void IEventsConsumerOnFireEnd() { }

		protected override void IEventsConsumerOnFiringBullet() { }

		protected override void IEventsConsumerOnFoldOff() { }

		protected override void IEventsConsumerOnFoldOn() { }

		protected override void IEventsConsumerOnIdleStart() { }

		protected override void IEventsConsumerOnLauncherAppeared() { }

		protected override void IEventsConsumerOnLauncherDisappeared() { }

		protected override void IEventsConsumerOnMagHide() { }

		protected override void IEventsConsumerOnMagIn() { }

		protected override void IEventsConsumerOnMagOut() { }

		protected override void IEventsConsumerOnMagShow() { }

		protected override void IEventsConsumerOnMalfunctionOff() { }

		protected override void IEventsConsumerOnMessageName() { }

		protected override void IEventsConsumerOnModChanged() { }

		protected override void IEventsConsumerOnOffBoltCatch() { }

		protected override void IEventsConsumerOnOnBoltCatch() { }

		protected override void IEventsConsumerOnOnUseProp(bool BoolParam) { }

		protected override void IEventsConsumerOnPutMagToRig() { }

		protected override void IEventsConsumerOnRemoveShell() { }

		protected override void IEventsConsumerOnReplaceSecondMag() { }

		protected override void IEventsConsumerOnShellEject() { }

		protected override void IEventsConsumerOnShowAmmo(bool BoolParam) { }

		protected override void IEventsConsumerOnShowMag() { }

		protected override void IEventsConsumerOnSound(string StringParam) { }

		protected override void IEventsConsumerOnSoundAtPoint(string StringParam) { }

		protected override void IEventsConsumerOnStartUtilityOperation() { }

		protected override void IEventsConsumerOnThirdAction(int IntParam) { }

		protected override void IEventsConsumerOnUseSecondMagForReload() { }

		protected override void IEventsConsumerOnWeapIn() { }

		protected override void IEventsConsumerOnWeapOut() { }

		protected override void IEventsOnBackpackDrop() { }

		protected override void IEventsOnBipodToggle() { }

		public override bool InCanNotBeInterruptedOperation() { }

		public override void Interact(bool isInteracting, int actionIndex) { }

		public override bool IsHandsProcessing() { }

		public override bool IsInInteraction() { }

		public override bool IsInInteractionStrictCheck() { }

		public override bool IsInventoryOpen() { }

		public override bool IsPlacingBeacon() { }

		public override void Loot(bool p) { }

		public override void ManualLateUpdate(float deltaTime) { }

		public abstract void ManualUpdate(float deltaTime) { }

		public override void OnAimReady() { }

		public override void OnBackpackDrop() { }

		public void OnBackpackDrop(IAnimatorEventParameter param) { }

		public void OnBipodToggle(IAnimatorEventParameter param) { }

		public override void OnDropWeapon() { }

		public override void OnGameSessionEnd() { }

		public override void OnIdleReady() { }

		protected override void OnOutUse() { }

		public override void OnPlayerDead() { }

		public override void OnSoundAtPoint(string StringParam) { }

		public override void OnUseProp(bool BoolParam) { }

		protected override void OnZombieFireBullet(IAnimatorEventParameter animatorEventParameter) { }

		protected override void OnZombieFireEnd(IAnimatorEventParameter animatorEventParameter) { }

		public override void Pickup(bool p) { }

		public override void ReloadTest() { }

		[CompilerGenerated]
		public void remove_OnAimingChanged(Action value) { }

		[CompilerGenerated]
		public override void set_AimingSmoothSensitivity(float value) { }

		[CompilerGenerated]
		protected void set_AnimationEventsEmitter(AnimationEventsEmitter value) { }

		[CompilerGenerated]
		protected void set_Destroyed(bool value) { }

		protected override void set_IsAiming(bool value) { }

		protected override void set_IsAimingButtonPressing(bool value) { }

		[CompilerGenerated]
		public void set_WeaponRoot(Transform value) { }

		public override void SetInventoryOpened(bool opened) { }

		public abstract void ShowGesture(EInteraction gesture) { }

		public abstract void Spawn(float animationSpeed, Action callback) { }

		public override bool SupportPickup() { }

		public override void SyncWeaponData(ItemDescriptor weaponDescriptor) { }

	}

	internal abstract class AbstractProcess
	{
		public enum Completion
		{
			Sync = 0,
			Async = 1,
		}

		public enum Confirmation
		{
			Unknown = 0,
			Succeed = 1,
			Failed = 2,
		}


		protected AbstractProcess() { }

		protected abstract void Abort() { }

		protected abstract void AbortAfterCompletion() { }

		protected abstract void Begin(string error = null) { }

		protected abstract void Complete() { }

		protected abstract void Complete(string error) { }

		protected abstract void CreateController() { }

		protected static void Execute(AbstractProcess process) { }

		protected abstract void Execute() { }

		protected abstract void ExecuteNext() { }

		protected abstract void Skip(string error) { }

		protected abstract void SkipToNext(string error) { }

		protected static bool TrySkip(AbstractProcess process) { }

		protected abstract bool TrySkip() { }

	}

	public abstract class BaseGrenadeHandsController : ItemHandsController
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal bool <.cctor>b__67_0(RaycastHit raycastHit) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0`1
		{
			public T controller; //Field offset: 0x0
			public Player player; //Field offset: 0x0

			public <>c__DisplayClass20_0`1() { }

			internal void <Setup>b__0() { }

			internal Transform <Setup>b__1(string x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			public BaseGrenadeHandsController <>4__this; //Field offset: 0x10
			public float animationSpeed; //Field offset: 0x18
			public Action callback; //Field offset: 0x20
			public bool fastDrop; //Field offset: 0x28

			public <>c__DisplayClass42_0() { }

			internal void <Drop>b__0(Result result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			public RemoveFromHandsOperation inventoryOperation; //Field offset: 0x10
			public Action callback; //Field offset: 0x18

			public <>c__DisplayClass43_0() { }

			internal void <ActualDrop>b__0() { }

		}

		[CompilerGenerated]
		private struct <CreateBaseControllerAsync>d__19`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public ThrowWeap item; //Field offset: 0x0
			public bool setQuickThrowParameters; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public const float MASS = 0.6; //Field offset: 0x0
		private const string DROP_TRANSFORM_NAME = "fireport"; //Field offset: 0x0
		private static readonly RaycastHit[] _hits; //Field offset: 0x0
		private static Func _isHitIgnoredTest; //Field offset: 0x8
		protected FirearmsAnimator _objectInHandsAnimator; //Field offset: 0xA8
		protected Transform _dropTransform; //Field offset: 0xB0
		protected Transform _grenadeTransform; //Field offset: 0xB8
		protected Transform[] ThrowingParts; //Field offset: 0xC0
		protected GrenadePrefab GrenadePrefab; //Field offset: 0xC8
		protected GrenadeEmission GrenadeEmission; //Field offset: 0xD0
		private GrenadeBuffsInfo _buffInfo; //Field offset: 0xD8
		protected bool _pinPulled; //Field offset: 0xE0

		protected IGrenadeOperation CurrentGrenadeOperation
		{
			 get { } //Length: 66
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public override ThrowWeap Item
		{
			 get { } //Length: 140
		}

		private static BaseGrenadeHandsController() { }

		protected BaseGrenadeHandsController() { }

		[CompilerGenerated]
		private void <ThrowGrenade>b__62_0() { }

		public override void ActualDrop(Result controller, float animationSpeed, Action callback, bool fastDrop) { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		public static bool CheckHandsToBodyObstacles(Player player, Vector3 point, out RaycastHit hit, out Vector3 correctedPoint) { }

		protected override void Cook() { }

		private Grenade CreateAndRegisterGrenade(Vector3 position, Quaternion rotation, Vector3 force, float prewarm = 0) { }

		internal static T CreateBaseController(Player player, ThrowWeap item, bool setQuickThrowParameters) { }

		[AsyncStateMachine(typeof(<CreateBaseControllerAsync>d__19`1))]
		internal static Task CreateBaseControllerAsync(Player player, ThrowWeap item, bool setQuickThrowParameters) { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		public Vector3 FindThrowPosition() { }

		protected IGrenadeOperation get_CurrentGrenadeOperation() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public override ThrowWeap get_Item() { }

		public virtual float GetAnimatorFloatParam(int hash) { }

		public float GetGrenadeAnimatorSpeed() { }

		protected bool GetPlantingKit(out PlantingKit plantingKit) { }

		protected virtual void IEventsConsumerOnAddAmmoInChamber() { }

		protected virtual void IEventsConsumerOnCook() { }

		protected virtual void IEventsConsumerOnDelAmmoChamber() { }

		protected virtual void IEventsConsumerOnFireEnd() { }

		protected virtual void IEventsConsumerOnFiringBullet() { }

		protected virtual void IEventsConsumerOnIdleStart() { }

		protected virtual void IEventsConsumerOnOnUseProp(bool boolParam) { }

		protected virtual void IEventsConsumerOnThirdAction(int intParam) { }

		protected virtual void IEventsConsumerOnWeapIn() { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		protected virtual void IEventsOnBackpackDrop() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual bool IsInInteraction() { }

		public virtual bool IsInInteractionStrictCheck() { }

		public virtual void Loot(bool p) { }

		private void OnBackpackDropEvent() { }

		protected void OnDrawCompleteAction() { }

		protected void OnDropFinishedAction() { }

		protected void OnDropGrenadeAction() { }

		protected void OnHideCompleteActionAction() { }

		private void OnIdleStartAction() { }

		public virtual void Pickup(bool p) { }

		private void PutGrenadeBack() { }

		private static void Setup(T controller, Player player, bool setQuickThrowParameters) { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

		protected void StartCountdown() { }

		public virtual bool SupportPickup() { }

		protected override void Throw(float timeSinceSafetyLevelRemoved, bool low = false) { }

		protected override void ThrowGrenade(float timeSinceSafetyLevelRemoved, Vector3 position, Quaternion rotation, Vector3 force, bool lowThrow) { }

		private void ThrowGrenadeInner(Nullable throwPosition, float timeSinceSafetyLevelRemoved, float lowHighThrow, Vector3 direction, float forcePower, bool lowThrow, bool withVelocity) { }

	}

	public abstract class BaseKnifeController : ItemHandsController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_0`1
		{
			public T controller; //Field offset: 0x0

			public <>c__DisplayClass34_0`1() { }

			internal PlayerBones <Setup>b__0() { }

			internal void <Setup>b__1() { }

			internal void <Setup>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			public BaseKnifeController <>4__this; //Field offset: 0x10
			public RemoveFromHandsOperation inventoryOperation; //Field offset: 0x18
			public Action callback; //Field offset: 0x20

			public <>c__DisplayClass46_0() { }

			internal void <Drop>b__0() { }

		}

		[CompilerGenerated]
		private struct <CreateBaseControllerAsync>d__33`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public KnifeComponent knife; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <DelayBetweenKnifeHits>d__12 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public BaseKnifeController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public const float LERP_DIRECTION_T = 0.9; //Field offset: 0x0
		public EKickType LastKickType; //Field offset: 0xA8
		private float _lagShotHackCooldownTime; //Field offset: 0xAC
		protected Vector3 GlobalSwingDirection; //Field offset: 0xB0
		protected Vector3 PreviousColliderPosition; //Field offset: 0xBC
		private Action _resetLayerWeight; //Field offset: 0xC8
		protected bool _minTimeBetweenHitsPassed; //Field offset: 0xD0
		protected int _minMSBetweenKnifeHits; //Field offset: 0xD4
		protected ObjectInHands _objectInHands; //Field offset: 0xD8
		protected FirearmsAnimator _firearmsAnimator; //Field offset: 0xE0
		protected Transform _knifeTransform; //Field offset: 0xE8
		protected KnifeCollider _knifeCollider; //Field offset: 0xF0
		private int _deflectLayer; //Field offset: 0xF8
		private int _knifeMask; //Field offset: 0xFC
		private int _knifeMaskSpirit; //Field offset: 0x100

		protected IBaseKnifeOperation CurrentKnifeOperation
		{
			 get { } //Length: 66
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public KnifeComponent Knife
		{
			 get { } //Length: 94
		}

		public virtual string LoggerDistinctId
		{
			 get { } //Length: 194
		}

		protected BaseKnifeController() { }

		[CompilerGenerated]
		private void <ProcessHit>b__63_0() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		internal static T CreateBaseController(Player player, KnifeComponent knife) { }

		[AsyncStateMachine(typeof(<CreateBaseControllerAsync>d__33`1))]
		internal static Task CreateBaseControllerAsync(Player player, KnifeComponent knife) { }

		[AsyncStateMachine(typeof(<DelayBetweenKnifeHits>d__12))]
		protected Task DelayBetweenKnifeHits() { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		protected IBaseKnifeOperation get_CurrentKnifeOperation() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public KnifeComponent get_Knife() { }

		public virtual string get_LoggerDistinctId() { }

		public virtual float GetAnimatorFloatParam(int hash) { }

		public Vector3 GetPlayerCastOrigin() { }

		public Vector3 GetPlayerOrientation() { }

		private void HideWeaponComplete() { }

		protected virtual void IEventsConsumerOnComboPlanning() { }

		protected virtual void IEventsConsumerOnFireEnd() { }

		protected virtual void IEventsConsumerOnFiringBullet() { }

		protected virtual void IEventsConsumerOnIdleStart() { }

		protected virtual void IEventsConsumerOnOnUseProp(bool boolParam) { }

		protected virtual void IEventsConsumerOnThirdAction(int intParam) { }

		protected virtual void IEventsConsumerOnWeapIn() { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		protected virtual void IEventsOnBackpackDrop() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual bool IsInInteraction() { }

		public virtual bool IsInInteractionStrictCheck() { }

		private bool KnifeCast(out RaycastHit hitInfo, int layerMask) { }

		public virtual void Loot(bool p) { }

		private void OnBackpackDropEvent() { }

		protected override void OnComboPlanning() { }

		private void OnFire() { }

		public override void OnFireEnd() { }

		protected virtual void OnZombieFireBullet(IAnimatorEventParameter animatorEventParameter) { }

		protected virtual void OnZombieFireEnd(IAnimatorEventParameter animatorEventParameter) { }

		public virtual void Pickup(bool p) { }

		protected override PlayerHitInfo ProcessHit(KnifeRaycastHit hit, BallisticCollider ballisticCollider) { }

		protected void ProcessOverlap(KnifeRaycastHit other) { }

		public void SetDeflected(bool deflected) { }

		public void SetMeleeSpeed(float speed) { }

		private static void Setup(T controller, Player player) { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual bool SupportPickup() { }

		private void WeaponAppeared() { }

	}

	public abstract class BaseKnifeOperation`1 : ObjectInHandsOperation, IBaseKnifeOperation
	{
		protected readonly TBaseKnifeController Controller; //Field offset: 0x0

		protected BaseKnifeOperation`1(TBaseKnifeController controller) { }

		public override void Execute(TInventoryOperation operation, Callback callback) { }

		public override void FastForward() { }

		public override void HideWeapon(Action onHidden, bool fastDrop) { }

		public override void HideWeaponComplete() { }

		public override void OnBackpackDrop() { }

		public override void OnFire() { }

		public override void OnFireEnd() { }

		public override void OnIdleStart() { }

		public override void WeaponAppeared() { }

	}

	internal class BetterValueBlender : ValueBlender
	{

		public virtual float Value
		{
			 get { } //Length: 388
			 set { } //Length: 90
		}

		public BetterValueBlender() { }

		public void ChangeValue(float value, float delay) { }

		public virtual float get_Value() { }

		public virtual void set_Value(float value) { }

	}

	public class ClientRecorderHandsController : RecorderHandsController
	{
		public UsableItemPacket UsableItemPacket; //Field offset: 0xE0

		public ClientRecorderHandsController() { }

		protected virtual void CompassStateHandler(bool isActive) { }

		internal static Task CreateAsync(ClientPlayer player, string itemId) { }

		public virtual void SetInventoryOpened(bool opened) { }

		public virtual void ShowGesture(EInteraction gesture) { }

	}

	internal static class Constants
	{
		public const float SPEED_MIN = 0; //Field offset: 0x0
		public const int STEP_RANGE_MAX = 1; //Field offset: 0x0
		public const int STEP_RANGE_MIN = -1; //Field offset: 0x0
		public const float TILT_RANGE_MAX = 5; //Field offset: 0x0
		public const float TILT_RANGE_MIN = -5; //Field offset: 0x0
		public const float POSE_THRESHOLD = 0.5; //Field offset: 0x0
		public const float POSE_RANGE_MAX = 1; //Field offset: 0x0
		public const float POSE_RANGE_MIN = 0; //Field offset: 0x0
		public const float SLOW_LEEN_SPEED = 0.1; //Field offset: 0x0
		public static readonly int FIRST_PERSON_ACTION; //Field offset: 0x0
		public const float SPEED_MAX_DELTA = 0.3; //Field offset: 0x0
		public const float MAX_SPRINTING_SPEED = 2; //Field offset: 0x0
		public const float SPEED_MAX = 0.7; //Field offset: 0x0
		public const float LEAN_SPEED = 5; //Field offset: 0x0
		public static readonly Vector2 STAND_POSE_ROTATION_PITCH_RANGE; //Field offset: 0x4
		public static readonly Vector2 PRONE_POSE_ROTATION_PITCH_RANGE; //Field offset: 0xC
		public static readonly Vector2 ROLL_POSE_ROTATION_PITCH_RANGE; //Field offset: 0x14
		public static readonly Vector2 FULL_YAW_RANGE; //Field offset: 0x1C

		private static Constants() { }

	}

	internal sealed class DamageDelegate : MulticastDelegate
	{

		public DamageDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(float damage, EBodyPart part, EDamageType type, float absorbed, MaterialType special, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(float damage, EBodyPart part, EDamageType type, float absorbed, MaterialType special) { }

	}

	internal sealed class DeltaTimeDelegate : MulticastDelegate
	{

		public DeltaTimeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke() { }

	}

	[Flags]
	internal enum EAnimatorMask
	{
		Thirdperson = 1,
		Arms = 2,
		Procedural = 4,
		FBBIK = 8,
		IK = 16,
	}

	internal enum EKickType
	{
		Slash = 0,
		Stab = 1,
	}

	internal enum EMouseSensitivityModifier
	{
		Armor = 0,
	}

	public class EmptyHandsController : ItemHandsController, IEmptyHandsController, IHandsController, ICompassController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0`1
		{
			public T controller; //Field offset: 0x0

			public <>c__DisplayClass30_0`1() { }

			internal void <Setup>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			public EmptyHandsController <>4__this; //Field offset: 0x10
			public Action callback; //Field offset: 0x18

			public <>c__DisplayClass42_0() { }

			internal void <Spawn>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_0
		{
			public Action callback; //Field offset: 0x10

			public <>c__DisplayClass44_0() { }

			internal void <Drop>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <AwaitingReadyForInteraction>d__45 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public EmptyHandsController <>4__this; //Field offset: 0x20
			public Action callback; //Field offset: 0x28

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
			public <AwaitingReadyForInteraction>d__45(int <>1__state) { }

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

		[CompilerGenerated]
		private struct <CreateControllerAsync>d__29`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal class DropBackpackOperation : EmptyHandsOperation
		{
			private Callback _callback; //Field offset: 0x38

			public DropBackpackOperation(EmptyHandsController controller) { }

			public virtual void OnBackpackDrop() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Item item, Callback callback) { }

		}

		internal abstract class EmptyHandsOperation : ObjectInHandsOperation
		{
			protected readonly Player Player; //Field offset: 0x28
			protected readonly EmptyHandsController Controller; //Field offset: 0x30

			protected EmptyHandsOperation(EmptyHandsController controller) { }

			public override bool CanExecute(IInventoryOperation operation) { }

			public override void ExamineWeapon() { }

			public override void Execute(IInventoryOperation operation, Callback callback) { }

			public override void FastForward() { }

			public override void HideWeapon(Action onHidden) { }

			public override void HideWeaponComplete() { }

			public override void OnBackpackDrop() { }

			public override void SetEmptyHandsCompassState(bool active) { }

			public override void SetInventoryOpened(bool opened) { }

			public void Start() { }

			public override void WeaponAppeared() { }

		}

		internal class Idling : EmptyHandsOperation
		{
			private const float IDLING_MAX_TIME = 300; //Field offset: 0x0
			private float _idlingTime; //Field offset: 0x38

			public Idling(EmptyHandsController controller) { }

			public virtual bool CanExecute(IInventoryOperation operation) { }

			public virtual void ExamineWeapon() { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			public virtual void HideWeapon(Action onHidden) { }

			public virtual void OnEnd() { }

			public virtual void Reset() { }

			public virtual void SetEmptyHandsCompassState(bool active) { }

			public void Start() { }

			public virtual void Update(float deltaTime) { }

		}

		private sealed class Remove : EmptyHandsOperation
		{
			private Action _onHiddenCallback; //Field offset: 0x38

			public Remove(EmptyHandsController controller) { }

			public virtual bool CanExecute(IInventoryOperation operation) { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden) { }

			public virtual void HideWeaponComplete() { }

			public virtual void Reset() { }

			public void Start(Action onHidden) { }

		}

		internal sealed class ServerDropBackpackOperation : DropBackpackOperation
		{
			private const float BACKPACK_DROP_EVENT_TIME = 0.01; //Field offset: 0x0
			private float _updateTime; //Field offset: 0x40
			private bool _backpackDropedEventFired; //Field offset: 0x44

			public ServerDropBackpackOperation(EmptyHandsController controller) { }

			public virtual void FastForward() { }

			public virtual void Start(Item item, Callback callback) { }

			public virtual void Update(float deltaTime) { }

		}

		internal sealed class SpawnOperation : EmptyHandsOperation
		{
			private Action _hideAction; //Field offset: 0x38
			private bool _hideAfterSpawn; //Field offset: 0x40
			private Action _onWeaponAppear; //Field offset: 0x48

			public SpawnOperation(EmptyHandsController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden) { }

			public virtual void Reset() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void Start(Action callback) { }

			public virtual void WeaponAppeared() { }

		}

		private ObjectInHands _emptyHandsObject; //Field offset: 0xA8
		private FirearmsAnimator _firearmsAnimator; //Field offset: 0xB0
		private bool _isInventoryOpened; //Field offset: 0xB8

		protected EmptyHandsOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		protected override bool IsReadyForInteraction
		{
			 get { } //Length: 3
		}

		public override EmptyHands Item
		{
			 get { } //Length: 140
		}

		public virtual string LoggerDistinctId
		{
			 get { } //Length: 194
		}

		public EmptyHandsController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__49_0() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__49_1() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__49_2() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__49_3() { }

		[IteratorStateMachine(typeof(<AwaitingReadyForInteraction>d__45))]
		private IEnumerator AwaitingReadyForInteraction(Action callback) { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanRemove() { }

		internal static T CreateController(Player player) { }

		[AsyncStateMachine(typeof(<CreateControllerAsync>d__29`1))]
		internal static Task CreateControllerAsync(Player player) { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public override void ExamineWeapon() { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		protected EmptyHandsOperation get_CurrentOperation() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		protected override bool get_IsReadyForInteraction() { }

		public override EmptyHands get_Item() { }

		public virtual string get_LoggerDistinctId() { }

		public virtual float GetAnimatorFloatParam(int hash) { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		private void HideWeaponComplete() { }

		protected virtual void IEventsConsumerOnOnUseProp(bool boolParam) { }

		protected virtual void IEventsConsumerOnThirdAction(int intParam) { }

		protected virtual void IEventsConsumerOnWeapIn() { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		protected virtual void IEventsOnBackpackDrop() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual bool IsInInteraction() { }

		public virtual bool IsInInteractionStrictCheck() { }

		public virtual bool IsInventoryOpen() { }

		public virtual void Loot(bool p) { }

		public virtual void ManualUpdate(float deltaTime) { }

		private void OnBackpackDropEvent() { }

		public virtual void Pickup(bool p) { }

		public virtual void SetCompassState(bool active) { }

		public virtual void SetInventoryOpened(bool opened) { }

		private static void Setup(T controller, Player player) { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

		public virtual bool SupportPickup() { }

		private void WeaponAppeared() { }

	}

	internal enum EOperationState
	{
		Ready = 0,
		Executing = 1,
		Finished = 2,
	}

	internal enum EProcessStatus
	{
		None = 0,
		Scheduled = 1,
		Internal = 2,
	}

	internal enum ESpeedLimit
	{
		BarbedWire = 0,
		HealthCondition = 1,
		Aiming = 2,
		Weight = 3,
		SurfaceNormal = 4,
		Swamp = 5,
		Shot = 6,
		Armor = 7,
		Fall = 8,
	}

	internal enum EUpdateMode
	{
		Auto = 0,
		Manual = 1,
		None = 2,
	}

	internal enum EVoipState
	{
		NotAvailable = 0,
		Available = 1,
		Off = 2,
		Banned = 3,
		MicrophoneFail = 4,
	}

	internal class FirearmController : ItemHandsController, IFirearmHandsController, IWeaponController, IHandsController, ICompassController, IFirearmAnimationDataRepresenter
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__171_0; //Field offset: 0x8
			public static Func <>9__173_0; //Field offset: 0x10
			public static Func <>9__173_1; //Field offset: 0x18
			public static Func <>9__173_2; //Field offset: 0x20
			public static Func <>9__173_3; //Field offset: 0x28
			public static Func <>9__175_0; //Field offset: 0x30
			public static Func <>9__175_1; //Field offset: 0x38
			public static Func <>9__175_2; //Field offset: 0x40
			public static Func <>9__314_0; //Field offset: 0x48
			public static Func <>9__314_1; //Field offset: 0x50
			public static Func <>9__314_2; //Field offset: 0x58
			public static Func <>9__315_0; //Field offset: 0x60
			public static Func <>9__315_1; //Field offset: 0x68
			public static Func <>9__315_2; //Field offset: 0x70
			public static Func <>9__316_0; //Field offset: 0x78
			public static Func <>9__327_0; //Field offset: 0x80

			private static <>c() { }

			public <>c() { }

			internal Item <GetAllLightMods>b__327_0(Slot slot) { }

			internal Item <GetCurrentLightStatus>b__314_0(Slot x) { }

			internal string <GetCurrentLightStatus>b__314_1(LightComponent x) { }

			internal LightComponent <GetCurrentLightStatus>b__314_2(LightComponent x) { }

			internal Item <GetCurrentScopesStatus>b__315_0(Slot x) { }

			internal string <GetCurrentScopesStatus>b__315_1(SightComponent x) { }

			internal SightComponent <GetCurrentScopesStatus>b__315_2(SightComponent x) { }

			internal bool <SetLightsState>b__316_0(KeyValuePair x) { }

			internal bool <SetMaxUniqueAnimationModId>b__175_0(Slot slot) { }

			internal Mod <SetMaxUniqueAnimationModId>b__175_1(Slot slot) { }

			internal int <SetMaxUniqueAnimationModId>b__175_2(Mod mod) { }

			internal bool <UpdateHipInaccuracy>b__171_0(TacticalCombo x) { }

			internal bool <WeaponModified>b__173_0(Slot slot) { }

			internal Bipod <WeaponModified>b__173_1(Slot x) { }

			internal bool <WeaponModified>b__173_2(Slot slot) { }

			internal TacticalCombo <WeaponModified>b__173_3(Slot x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__143`1
		{
			public static readonly <>c__143 <>9; //Field offset: 0x0
			public static Func <>9__143_2; //Field offset: 0x0
			public static Func <>9__143_3; //Field offset: 0x0
			public static Func <>9__143_9; //Field offset: 0x0
			public static Func <>9__143_10; //Field offset: 0x0

			private static <>c__143`1() { }

			public <>c__143`1() { }

			internal TacticalCombo <Setup>b__143_10(Slot x) { }

			internal bool <Setup>b__143_2(Slot slot) { }

			internal Bipod <Setup>b__143_3(Slot x) { }

			internal bool <Setup>b__143_9(Slot slot) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass143_0`1
		{
			public Player player; //Field offset: 0x0
			public T controller; //Field offset: 0x0

			public <>c__DisplayClass143_0`1() { }

			internal bool <Setup>b__0() { }

			internal bool <Setup>b__1() { }

			internal void <Setup>b__4() { }

			internal void <Setup>b__5() { }

			internal void <Setup>b__7() { }

			internal void <Setup>b__8() { }

			internal void <Setup>g__PatronIsVisibleHandler|6(bool visible) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass158_0
		{
			public FirearmController firearmController; //Field offset: 0x10
			public FirearmController <>4__this; //Field offset: 0x18
			public IWeaponModAudioController modAudioController; //Field offset: 0x20

			public <>c__DisplayClass158_0() { }

			internal void <SetupModAudioController>g__OnPlayerOnOnHandsControllerChanged|0(AbstractHandsController oldController, AbstractHandsController newController) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass264_0
		{
			public Action callback; //Field offset: 0x10
			public FirearmController <>4__this; //Field offset: 0x18

			public <>c__DisplayClass264_0() { }

			internal void <Spawn>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass265_0
		{
			public RemoveFromHandsOperation inventoryOperation; //Field offset: 0x10
			public Action callback; //Field offset: 0x18

			public <>c__DisplayClass265_0() { }

			internal void <Drop>b__0() { }

		}

		[CompilerGenerated]
		private struct <CreateControllerAsync>d__142`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public Weapon weapon; //Field offset: 0x0
			private T <result>5__2; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0
			private TaskAwaiter <>u__2; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private sealed class <PressingAimCoroutine>d__293 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public FirearmController <>4__this; //Field offset: 0x20
			public bool oneTriggering; //Field offset: 0x28

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
			public <PressingAimCoroutine>d__293(int <>1__state) { }

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

		[CompilerGenerated]
		private struct <Setup>d__143`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public T controller; //Field offset: 0x0
			public Weapon weapon; //Field offset: 0x0
			public bool async; //Field offset: 0x0
			private <>c__DisplayClass143_0 <>8__1; //Field offset: 0x0
			private WeaponPrefab <weaponPrefab>5__2; //Field offset: 0x0
			private object <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private sealed class AddModOperation : FirearmOperation
		{
			private Item _item; //Field offset: 0x50
			private Slot _slot; //Field offset: 0x58
			private Callback _callback; //Field offset: 0x60
			private bool _onModChanged; //Field offset: 0x68

			public AddModOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			private void CheckUnderbarrelMode(GameObject createdItem) { }

			public virtual void FastForward() { }

			public virtual void OnModChanged() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Start(Item item, Slot slot, Callback callback) { }

		}

		internal class AutomaticFireOperation : FireOperationBase
		{
			private const float FIRE_BULLET_TIMING = 0; //Field offset: 0x0
			private const float SHELL_EJECT_TIMING = 0.25; //Field offset: 0x0
			private const float BOLT_CATCH_TIMING = 0.75; //Field offset: 0x0
			private const float CHAMBER_OPERATION_TIMING = 0.75; //Field offset: 0x0
			private const float FIRE_END_TIMING = 0.99; //Field offset: 0x0
			protected const int SHOTS_IN_BURST = 3; //Field offset: 0x0
			protected int _shotsInRound; //Field offset: 0x60
			protected float _shotTime; //Field offset: 0x64
			protected float _cachedOverheatFirerate; //Field offset: 0x68
			protected float _updateTime; //Field offset: 0x6C
			protected SingleShotData _currentShotData; //Field offset: 0x70
			private bool _isAnimationStarted; //Field offset: 0xA0
			private int _burstShotsCount; //Field offset: 0xA4
			protected float _lastNormalizedEndTime; //Field offset: 0xA8

			public float ShotsTime
			{
				 get { } //Length: 6
			}

			public AutomaticFireOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			public float get_ShotsTime() { }

			public void InternalOnAddAmmoInChamber() { }

			protected override void InternalOnFireEndEvent() { }

			protected override void InternalOnFireEvent() { }

			public void InternalOnShellEjectEvent() { }

			public void InternalRemoveAmmoFromChamber() { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnFireEvent() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			public virtual void OnShellEjectEvent() { }

			protected void ProcessEvents(float normalizedStartFrameTime, float normalizedEndFrameTime) { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public override void Start() { }

			protected void SwitchToIdling() { }

			protected void SwitchToMalfunction() { }

			private void SwitchToPlannedState() { }

			public virtual void Update(float deltaTime) { }

		}

		internal abstract class BaseReloadOperation : FirearmOperation
		{
			protected bool _fastHide; //Field offset: 0x50
			protected Action _onHideAction; //Field offset: 0x58
			private Callback _onFinishCallback; //Field offset: 0x60
			[CompilerGenerated]
			private Slot <ChamberSlot0>k__BackingField; //Field offset: 0x68

			protected private Slot ChamberSlot0
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				private set { } //Length: 82
			}

			public virtual EOperationState State
			{
				 get { } //Length: 4
				 set { } //Length: 127
			}

			protected BaseReloadOperation(FirearmController controller) { }

			[CompilerGenerated]
			private void <Start>b__10_0() { }

			protected void FireOnFinishCallback() { }

			[CompilerGenerated]
			protected Slot get_ChamberSlot0() { }

			public virtual EOperationState get_State() { }

			protected virtual double GetMaxOperationDuration() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void Reset() { }

			[CompilerGenerated]
			private void set_ChamberSlot0(Slot value) { }

			protected virtual void set_State(EOperationState value) { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected void Start(Callback callback) { }

			protected void SyncInventoryParameter() { }

			protected void TacticalReload(bool isAiming) { }

		}

		internal class BoltActionFireOperation : FireOperation
		{

			public BoltActionFireOperation(FirearmController controller) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAimingDisabled() { }

			public virtual void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadCylinderMagazine(AmmoPack ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false) { }

			public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void Start() { }

		}

		internal sealed class ChamberForReloading
		{
			public readonly int ChamberIndex; //Field offset: 0x10
			public readonly IItemOperationResult OldAmmoResult; //Field offset: 0x18
			public readonly IItemOperationResult InsertResult; //Field offset: 0x20

			public ChamberForReloading(int chamberIndex, IItemOperationResult oldAmmoResult, IItemOperationResult insertResult) { }

			public bool CheckAction() { }

			public void RaiseEvents(ItemController controller, CommandStatus status) { }

			public void RollBack() { }

		}

		internal class DischargeAmmoFromCamoraOperation : FirearmOperation
		{
			private Ammo _ammo; //Field offset: 0x50
			private CylinderMagazine _cylinderMagazine; //Field offset: 0x58
			private ItemAddress _targetItemAdress; //Field offset: 0x60
			private Callback _callback; //Field offset: 0x68
			private bool _magAppeared; //Field offset: 0x70
			private bool _magPuttedToRig; //Field offset: 0x71
			private int _camoraIndex; //Field offset: 0x74

			public DischargeAmmoFromCamoraOperation(FirearmController controller) { }

			private void DischargeEnd() { }

			public virtual void FastForward() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			private void SetLoadOneForNextOperation() { }

			public override void Start(Ammo item, int camoraIndex, ItemAddress itemAddress, Callback callback) { }

		}

		internal class DischargeAmmoFromUnderbarrelWeapon : FirearmOperation
		{
			private Ammo _ammo; //Field offset: 0x50
			private ItemAddress _targetItemAdress; //Field offset: 0x58
			private Callback _callback; //Field offset: 0x60
			private bool _magAppeared; //Field offset: 0x68
			private bool _magPuttedToRig; //Field offset: 0x69
			private int _chamberIndex; //Field offset: 0x6C

			public DischargeAmmoFromUnderbarrelWeapon(FirearmController controller) { }

			private void DischargeEnd() { }

			public virtual void FastForward() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Ammo item, int camoraIndex, ItemAddress itemAddress, Callback callback) { }

		}

		internal class DischargeMultiBarrelWeaponOperation : DischargeOperation
		{

			public DischargeMultiBarrelWeaponOperation(FirearmController controller) { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void RemoveAmmoFromChamber() { }

		}

		internal class DischargeOperation : FirearmOperation
		{
			protected Callback _callback; //Field offset: 0x50
			protected bool _isAmmoUsed; //Field offset: 0x58
			protected bool _magPuttedToRig; //Field offset: 0x59
			protected int _chamberIndex; //Field offset: 0x5C
			private ItemAddress _destinationAddress; //Field offset: 0x60

			protected bool LoadOneAfterDischarge
			{
				 get { } //Length: 9
			}

			public DischargeOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			protected bool get_LoadOneAfterDischarge() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			private void SetLoadOneForNextOperation() { }

			internal override void Start(Ammo ammo, int chamberIndex, ItemAddress destinationAddress, Callback callback) { }

		}

		internal class DropBackpackOperation : FirearmOperation
		{
			private const float CLIENT_PROTECTION_BACKPACK_DROP_EVENT_TIME = 2.5; //Field offset: 0x0
			private Callback _callback; //Field offset: 0x50
			private bool _backpackDropped; //Field offset: 0x58
			protected float _updateTime; //Field offset: 0x5C
			protected bool _backpackDropedEventFired; //Field offset: 0x60

			protected override float BackpackDropEventTime
			{
				 get { } //Length: 9
			}

			public DropBackpackOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			public virtual void FastForward() { }

			protected override float get_BackpackDropEventTime() { }

			public virtual void OnBackpackDropEvent() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Item item, Callback callback) { }

			public virtual void Update(float deltaTime) { }

		}

		internal sealed class ExamineMalfunctionTypeOperation : MalfunctionOperation
		{
			private bool _malfOff; //Field offset: 0x68

			public ExamineMalfunctionTypeOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			public virtual void OnMalfunctionOffEvent() { }

			public virtual void Reset() { }

			public void Start() { }

		}

		internal abstract class FirearmOperation : ObjectInHandsOperation
		{
			protected readonly FirearmController Controller; //Field offset: 0x28
			protected Player Player; //Field offset: 0x30
			protected readonly FirearmsAnimator FirearmsAnimator; //Field offset: 0x38
			protected readonly Firearms Firearms; //Field offset: 0x40
			protected readonly Weapon Weapon; //Field offset: 0x48

			protected FirearmOperation(FirearmController controller) { }

			[CompilerGenerated]
			private void <RepairMisfire>b__10_0() { }

			public override void AddAmmoToMag() { }

			public override void BlindFire(int b) { }

			public void BlindFire_Internal(int b) { }

			public override bool CanChangeLightState(LightsState[] lightsStates) { }

			public override bool CanChangeScopeStates(ScopeState[] scopeStates) { }

			public override bool CanNotBeInterrupted() { }

			public override bool CanRemove() { }

			public override bool CanStartReload(bool checkWeaponMalfunctions = true) { }

			public override bool ChangeFireMode(EFireMode fireMode) { }

			public override bool CheckAmmo() { }

			public override bool CheckChamber() { }

			public override bool CheckFireMode() { }

			protected override void DisableAimingOnReload() { }

			public override void DropBackpackOperationInvoke(Item item, Callback callback) { }

			public override bool ExamineWeapon() { }

			public override void Execute(IInventoryOperation operation, Callback callback) { }

			public override void FastForward() { }

			public override void ForceSetUnderbarrelRangeIndex(int rangeIndex) { }

			public override void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public override void HideWeaponComplete() { }

			public override void Interact(bool isInteracting, int actionIndex) { }

			public override void LauncherAppeared() { }

			public override void LauncherDisappeared() { }

			public override void LauncherInventoryUnchamberFromMainWeapon(Ammo ammo, int camoraIndex, ItemAddress itemAddress, Callback callback) { }

			public override void LoadLauncherFromMainWeapon(Ammo ammo, int camoraIndex, ItemAddress itemAddress, Callback callback) { }

			public override void Loot(bool p) { }

			public override void OnAddAmmoInChamber() { }

			public override void OnAimingDisabled() { }

			public override void OnBackpackDropEvent() { }

			public override void OnBipodToggleEvent() { }

			public override void OnDropWeapon() { }

			public override void OnFireEndEvent() { }

			public override void OnFireEvent() { }

			public override void OnFold(bool b) { }

			public override void OnIdleStartEvent() { }

			public override void OnJumpOrFall() { }

			public override void OnMagAppeared() { }

			public override void OnMagInsertedToWeapon() { }

			public override void OnMagPulledOutFromWeapon() { }

			public override void OnMagPuttedToRig() { }

			public override void OnMalfunctionOffEvent() { }

			public override void OnModChanged() { }

			public override void OnOnOffBoltCatchEvent(bool isCaught) { }

			public override void OnRemoveShellEvent() { }

			public override void OnShellEjectEvent() { }

			public override void OnShowAmmo(bool value) { }

			public override void OnSprintFinished() { }

			public override void OnSprintStart() { }

			public override void OnUtilityOperationStartEvent() { }

			public override void Pickup(bool p) { }

			public override void PutMagToRig() { }

			public override void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

			public override void ReloadBarrels(AmmoPack ammoPack, ItemAddress placeToPutContainedAmmoMagazine, Callback finishCallback, Callback startCallback) { }

			public override void ReloadCylinderMagazine(AmmoPack ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false) { }

			public override void ReloadGrenadeLauncher(AmmoPack ammoPack, Callback callback) { }

			public override void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

			public override void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

			public override void RemoveAmmoFromChamber() { }

			protected void RepairMisfire() { }

			public override void ReplaceSecondMag() { }

			public override void RollCylinder(Callback callback, bool rollToZeroCamora) { }

			public override void SetAiming(bool isAiming) { }

			protected void SetChamberIndexForUnloadShell() { }

			public override void SetFirearmCompassState(bool active) { }

			public override void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void SetLightsState(LightsState[] lightsStates, bool force = false, bool animated = true) { }

			public void SetScopeMode(ScopeState[] scopeStates) { }

			public override void SetTriggerPressed(bool pressed) { }

			public override void ShowGesture(EInteraction gesture) { }

			public override void ShowIncompatibleNotification() { }

			public override void SprintStateChanged(bool value) { }

			public override bool ToggleBipod() { }

			public override bool ToggleLauncher(Action callback = null) { }

			public override void ToggleLeftStance() { }

			public override void UnderbarrelSightingRangeDown() { }

			public override void UnderbarrelSightingRangeUp() { }

			public virtual void Update(float deltaTime) { }

			public override void UseSecondMagForReload() { }

			public override void WeaponAppeared() { }

		}

		internal class FireCylinderMagOperation : FireOperation
		{
			private CylinderMagazine _cylinderMagazine; //Field offset: 0xA0
			private int _camoraIndex; //Field offset: 0xA8
			protected bool _dryFire; //Field offset: 0xAC

			public FireCylinderMagOperation(FirearmController controller) { }

			private void DryFire() { }

			public virtual void FastForward() { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnFireEndEvent() { }

			public virtual void OnFireEvent() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnShellEjectEvent() { }

			protected virtual void PrepareShot() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void Start() { }

			protected void SwitchToIdling() { }

			protected void SwitchToMalfunction() { }

			private void SwitchToPlannedState() { }

		}

		internal sealed class FireOnlyBarrelFireOperation : FireOperation
		{
			private readonly List _chambersForFire; //Field offset: 0xA0
			private readonly List _singleShotsData; //Field offset: 0xA8

			public FireOnlyBarrelFireOperation(FirearmController controller) { }

			private void DoubletShot() { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnFireEvent() { }

			protected virtual void PrepareShot() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			private void SingleShot(int chamberIndex) { }

		}

		internal class FireOperation : FireOperationBase
		{
			protected SingleShotData _singleShotData; //Field offset: 0x60
			protected bool _isShotFired; //Field offset: 0x90
			private float _singleFireCooldownTime; //Field offset: 0x94
			private bool _readyToExit; //Field offset: 0x98
			private bool _secondShotPlanned; //Field offset: 0x99
			private bool _canQueueSecondShot; //Field offset: 0x9A

			public FireOperation(FirearmController controller) { }

			private void ExitOperation() { }

			public virtual void FastForward() { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnFireEndEvent() { }

			public virtual void OnFireEvent() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnShellEjectEvent() { }

			protected override void PrepareShot() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public override void Start() { }

			protected override void StartFireAnimation() { }

			protected void SwitchToIdling() { }

			protected void SwitchToMalfunction() { }

			private void SwitchToPlannedState() { }

			public virtual void Update(float deltaTime) { }

		}

		internal class FireOperationBase : FirearmOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass11_0
			{
				public FireOperationBase <>4__this; //Field offset: 0x10
				public Magazine magazine; //Field offset: 0x18
				public ItemAddress itemAddress; //Field offset: 0x20
				public Callback finishCallback; //Field offset: 0x28
				public Callback startCallback; //Field offset: 0x30

				public <>c__DisplayClass11_0() { }

				internal void <ReloadMag>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass12_0
			{
				public FireOperationBase <>4__this; //Field offset: 0x10
				public AmmoPack ammoPack; //Field offset: 0x18
				public Callback finishCallback; //Field offset: 0x20
				public bool quickReload; //Field offset: 0x28
				public Callback startCallback; //Field offset: 0x30

				public <>c__DisplayClass12_0() { }

				internal void <ReloadCylinderMagazine>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass13_0
			{
				public FireOperationBase <>4__this; //Field offset: 0x10
				public AmmoPack ammoPack; //Field offset: 0x18
				public Callback finishCallback; //Field offset: 0x20
				public Callback startCallback; //Field offset: 0x28

				public <>c__DisplayClass13_0() { }

				internal void <ReloadWithAmmo>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass14_0
			{
				public FireOperationBase <>4__this; //Field offset: 0x10
				public Magazine magazine; //Field offset: 0x18
				public Callback finishCallback; //Field offset: 0x20
				public Callback startCallback; //Field offset: 0x28

				public <>c__DisplayClass14_0() { }

				internal void <QuickReloadMag>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass16_0
			{
				public FireOperationBase <>4__this; //Field offset: 0x10
				public Action onHidden; //Field offset: 0x18
				public bool fastDrop; //Field offset: 0x20
				public Item nextControllerItem; //Field offset: 0x28

				public <>c__DisplayClass16_0() { }

				internal void <HideWeapon>b__0() { }

			}

			internal struct SingleShotData
			{
				public Ammo AmmoToFire; //Field offset: 0x0
				[CanBeNull]
				public Ammo AmmoWillBeLoadedToChamber; //Field offset: 0x8
				public Ammo FedAmmo; //Field offset: 0x10
				public int AmmoCountInChamberBeforeShot; //Field offset: 0x18
				public int AmmoCountInChamberAfterShot; //Field offset: 0x1C
				public int AmmoCountInMagBeforeShot; //Field offset: 0x20
				public int AmmoCountInMagAfterShot; //Field offset: 0x24
				public bool IsAmmoCompatible; //Field offset: 0x28

			}

			protected bool _openInventory; //Field offset: 0x50
			protected Action _plannedAction; //Field offset: 0x58

			protected FireOperationBase(FirearmController controller) { }

			public virtual void BlindFire(int b) { }

			public virtual bool CanStartReload(bool checkWeaponMalfunctions = true) { }

			private void CheckMagazineCallback() { }

			private void GetAmmoForSingleShot(out Ammo ammoToFire, out Ammo ammoToChamber, out int ammoCountInMagBeforeShot) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			protected override void MakeMultiBarrelShot(List singleShotDatas, List chambersForFire) { }

			protected override void MakeShot(Ammo ammo, int chamberIndex = 0, bool multiBarrelShot = false) { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			protected SingleShotData ProcessInventoryOperationsForSingleShot(EMalfunctionState malfState) { }

			protected SingleShotData ProcessInventoryOperationsForSingleshotWithMalf(out EMalfunctionState malfState, out EMalfunctionSource malfSource) { }

			public virtual void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadCylinderMagazine(AmmoPack ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false) { }

			public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			protected void SpawnShell() { }

			protected override void UncheckOnShot() { }

		}

		internal class FlareGunFire : FireOperation
		{
			protected Ammo _ammoToFire; //Field offset: 0xA0

			public FlareGunFire(FirearmController controller) { }

			public virtual bool CanNotBeInterrupted() { }

			public virtual void OnFireEndEvent() { }

			public virtual void OnFireEvent() { }

			protected virtual void PrepareShot() { }

			public virtual void Reset() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void Start() { }

		}

		private sealed class FoldStockOperation : FirearmOperation
		{
			private Callback _foldCallback; //Field offset: 0x50
			private FoldOperation _operation; //Field offset: 0x58
			private bool _needToHide; //Field offset: 0x60
			private Action _hideAction; //Field offset: 0x68
			private bool _fastDrop; //Field offset: 0x70

			public FoldStockOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnFold(bool b) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Start(FoldOperation foldOperation, Callback callback) { }

			private void SwitchToIdle() { }

		}

		internal class Idling : FirearmOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass46_0
			{
				public Idling <>4__this; //Field offset: 0x10
				public Ammo ammo; //Field offset: 0x18
				public IOneItemOperation oneItemOperation; //Field offset: 0x20
				public Callback callback; //Field offset: 0x28
				public Action <>9__2; //Field offset: 0x30
				public Action <>9__3; //Field offset: 0x38

				public <>c__DisplayClass46_0() { }

				internal void <ExecuteUnderbarrelOperation>b__0() { }

				internal void <ExecuteUnderbarrelOperation>b__1() { }

				internal void <ExecuteUnderbarrelOperation>b__2() { }

				internal void <ExecuteUnderbarrelOperation>b__3() { }

			}

			private float _idlingTime; //Field offset: 0x50
			private bool _reloadFixed; //Field offset: 0x54
			private float _reloadFixTimer; //Field offset: 0x58
			private Action _startOperationCallback; //Field offset: 0x60
			private Action _idleStartEventCallback; //Field offset: 0x68
			private float _prevLeftHandLayerWeight; //Field offset: 0x70

			public Idling(FirearmController controller) { }

			[CompilerGenerated]
			private void <Execute>b__45_0() { }

			[CompilerGenerated]
			private void <Execute>b__45_1() { }

			[CompilerGenerated]
			private void <ExecuteCylinderMagOperations>b__47_0() { }

			[CompilerGenerated]
			private void <ExecuteCylinderMagOperations>b__47_1() { }

			public virtual void BlindFire(int b) { }

			public virtual bool CanRemove() { }

			public virtual bool CanStartReload(bool checkWeaponMalfunctions = true) { }

			public virtual bool ChangeFireMode(EFireMode fireMode) { }

			public virtual bool CheckAmmo() { }

			public virtual bool CheckChamber() { }

			public virtual bool CheckFireMode() { }

			public virtual void DropBackpackOperationInvoke(Item item, Callback callback) { }

			public virtual bool ExamineWeapon() { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			private void ExecuteCylinderMagOperations(IOneItemOperation oneItemOperation, Ammo ammo, Callback callback) { }

			private void ExecuteUnderbarrelOperation(IOneItemOperation oneItemOperation, Ammo ammo, Callback callback) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			private void InvokeCallback() { }

			private void InvokeOnIdleStartEventCallback() { }

			public virtual void OnAimingDisabled() { }

			public virtual void OnDropWeapon() { }

			public virtual void OnEnd() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnJumpOrFall() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			public virtual void OnSprintFinished() { }

			public virtual void OnSprintStart() { }

			protected override void ProcessAutoshot() { }

			private void ProcessLeftStanceResetAfterLeftHandInvoke() { }

			protected override void ProcessRemoveOneOffWeapon() { }

			public virtual void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadBarrels(AmmoPack ammoPack, ItemAddress placeToPutContainedAmmoMagazine, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadCylinderMagazine(AmmoPack ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false) { }

			public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

			public virtual void RollCylinder(Callback finishCallback, bool rollToZeroCamora) { }

			protected override void RunUtilityOperation(EUtilityType utilityType) { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetFirearmCompassState(bool active) { }

			private void SetFireModeForCylinderMagazine(EFireMode fireMode) { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			private void ShowFireMode() { }

			public virtual void ShowGesture(EInteraction gesture) { }

			public virtual void ShowIncompatibleNotification() { }

			public override void Start(Action callback = null) { }

			public virtual bool ToggleBipod() { }

			public virtual bool ToggleLauncher(Action callback) { }

			public virtual void ToggleLeftStance() { }

			public virtual void Update(float deltaTime) { }

		}

		internal class InsertMagOperation : FirearmOperation
		{
			private Callback _callback; //Field offset: 0x50
			private InsertMagResult _insertMagResult; //Field offset: 0x58
			private bool _addedAmmoInChamber; //Field offset: 0x60
			private bool _magAppeared; //Field offset: 0x61
			private bool _magInserted; //Field offset: 0x62

			public InsertMagOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnMagInsertedToWeapon() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(InsertMagResult insertMagResult, Callback callback) { }

			private void SwitchToIdlingState() { }

		}

		internal sealed class InsertMagResult
		{
			public readonly Weapon Weapon; //Field offset: 0x10
			public readonly Magazine Magazine; //Field offset: 0x18
			public readonly int MagazineAmmoCount; //Field offset: 0x20
			public readonly SlotItemAddress MagazineSlot; //Field offset: 0x28
			public readonly bool AmmoCompatible; //Field offset: 0x30
			[CanBeNull]
			private readonly RemoveResult _removeOldAmmoResult; //Field offset: 0x38
			[CanBeNull]
			private readonly IItemOperationResult _addNewAmmoResult; //Field offset: 0x40

			public bool HasNewAmmo
			{
				 get { } //Length: 9
			}

			public Ammo NewAmmo
			{
				 get { } //Length: 158
			}

			public InsertMagResult(Weapon weapon, Magazine magazine, bool ammoCompatible, RemoveResult removeOldAmmoResult, IItemOperationResult addNewAmmoResult) { }

			public bool CanExecute(ItemController itemController) { }

			public bool get_HasNewAmmo() { }

			public Ammo get_NewAmmo() { }

			public void RaiseEvents(ItemController controller, CommandStatus status) { }

			public void RollBack() { }

			public static Option Run(InventoryController inventoryController, Weapon weapon, int raidId) { }

		}

		internal class LauncherFire : FireOperation
		{
			private bool _inventoryOpened; //Field offset: 0xA0

			public LauncherFire(FirearmController controller) { }

			public virtual void OnFireEndEvent() { }

			public virtual void OnFireEvent() { }

			protected virtual void PrepareShot() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Start() { }

			protected void SwitchToIdling() { }

		}

		internal class LauncherIdling : FirearmOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass29_0
			{
				public LauncherIdling <>4__this; //Field offset: 0x10
				public Item item; //Field offset: 0x18
				public Callback callback; //Field offset: 0x20

				public <>c__DisplayClass29_0() { }

				internal void <DropBackpackOperationInvoke>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass30_0
			{
				public LauncherIdling <>4__this; //Field offset: 0x10
				public Action onHidden; //Field offset: 0x18
				public bool fastDrop; //Field offset: 0x20
				public Item nextControllerItem; //Field offset: 0x28

				public <>c__DisplayClass30_0() { }

				internal void <HideWeapon>b__0() { }

			}

			protected Launcher _launcher; //Field offset: 0x50
			private Action _callback; //Field offset: 0x58
			private bool _bonesChangedForLeftHand; //Field offset: 0x60

			public LauncherIdling(FirearmController controller) { }

			[CompilerGenerated]
			private void <ExecuteLauncherOperation>b__31_0() { }

			[CompilerGenerated]
			private void <ExecuteLauncherOperation>b__31_1() { }

			public virtual bool CanStartReload(bool checkWeaponMalfunctions = true) { }

			public virtual bool CheckChamber() { }

			public virtual void DropBackpackOperationInvoke(Item item, Callback callback) { }

			public virtual bool ExamineWeapon() { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			private void ExecuteLauncherOperation(IOneItemOperation oneItemOperation, Ammo ammo, Callback callback) { }

			protected void ForceHideOperation(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void ForceSetUnderbarrelRangeIndex(int rangeIndex) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void Interact(bool isInteracting, int actionIndex) { }

			public virtual void LauncherInventoryUnchamberFromMainWeapon(Ammo ammo, int camoraIndex, ItemAddress itemAddress, Callback callback) { }

			public virtual void LoadLauncherFromMainWeapon(Ammo ammo, int camoraIndex, ItemAddress itemAddress, Callback callback) { }

			public virtual void OnIdleStartEvent() { }

			public virtual void Pickup(bool pickup) { }

			public virtual void ReloadGrenadeLauncher(AmmoPack ammoPack, Callback callback) { }

			protected override void RunUtilityOperation(EUtilityType utilityType) { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			private void SetMainWeaponBoneForCorrectAnimation() { }

			protected override void SetSightingRange(float deltaTime) { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void ShowGesture(EInteraction gesture) { }

			private void ShowSightingRange() { }

			public virtual void SprintStateChanged(bool value) { }

			public void Start(Action callback = null) { }

			private void SwitchToIdle(Action callback) { }

			public virtual bool ToggleLauncher(Action callback) { }

			public virtual void ToggleLeftStance() { }

			public virtual void UnderbarrelSightingRangeDown() { }

			public virtual void UnderbarrelSightingRangeUp() { }

			public virtual void Update(float deltaTime) { }

		}

		internal class LauncherReload : FirearmOperation
		{
			private Callback _onReloadFinished; //Field offset: 0x50
			private AmmoPack _ammoPack; //Field offset: 0x58
			private bool _inventoryOpened; //Field offset: 0x60
			protected Ammo _ammo; //Field offset: 0x68
			protected bool _fastHide; //Field offset: 0x70
			protected Action _onHideAction; //Field offset: 0x78

			public LauncherReload(FirearmController controller) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnShellEjectEvent() { }

			private void Prepare() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(AmmoPack ammoPack, Callback callback) { }

		}

		internal class LauncherUtilityOperation : LauncherIdling
		{
			private const float MAX_UTILITY_TIME = 2.5; //Field offset: 0x0
			private float _utilityTime; //Field offset: 0x68
			private bool _inInventory; //Field offset: 0x6C
			private EUtilityType _utilityOperationType; //Field offset: 0x70
			private Launcher _launcher; //Field offset: 0x78

			public LauncherUtilityOperation(FirearmController firearmController) { }

			public virtual bool CanStartReload(bool checkWeaponMalfunctions = true) { }

			public virtual bool CheckAmmo() { }

			public virtual bool CheckChamber() { }

			public virtual bool CheckFireMode() { }

			public virtual bool ExamineWeapon() { }

			public virtual void FastForward() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnShellEjectEvent() { }

			public virtual void OnUtilityOperationStartEvent() { }

			public virtual void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadCylinderMagazine(AmmoPack ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false) { }

			public virtual void ReloadGrenadeLauncher(AmmoPack ammoPack, Callback callback) { }

			public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetSightingRange(float deltaTime) { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public void Start(EUtilityType utilityType, Launcher launcher) { }

			public virtual void Update(float deltaTime) { }

		}

		internal class LoadAmmoToUnderbarrelWeapon : FirearmOperation
		{
			private Ammo _ammo; //Field offset: 0x50
			private int _chamberIndex; //Field offset: 0x58
			private Callback _callback; //Field offset: 0x60

			public LoadAmmoToUnderbarrelWeapon(FirearmController controller) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			public virtual void OnRemoveShellEvent() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Ammo ammo, int chamberIndex, Callback callback) { }

		}

		internal class LoadCartridgeToCamora : FirearmOperation
		{
			private Ammo _ammo; //Field offset: 0x50
			protected int _camoraIndex; //Field offset: 0x58
			private CylinderMagazine _cylinderMagazine; //Field offset: 0x60
			private Callback _callback; //Field offset: 0x68

			public LoadCartridgeToCamora(FirearmController controller) { }

			public virtual void AddAmmoToMag() { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			public virtual void OnRemoveShellEvent() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Ammo ammo, int camoraIndex, Callback callback) { }

			protected override void SwitchToIdle() { }

		}

		internal class LoadCartridgeToChamber : FirearmOperation
		{
			private Ammo _ammo; //Field offset: 0x50
			private int _chamberIndex; //Field offset: 0x58
			private Callback _callback; //Field offset: 0x60

			public LoadCartridgeToChamber(FirearmController controller) { }

			[CompilerGenerated]
			private void <OnAddAmmoInChamber>b__8_0() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			public virtual void OnRemoveShellEvent() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Ammo ammo, int chamberIndex, Callback callback) { }

			protected override void SwitchToIdle() { }

		}

		internal abstract class MalfunctionOperation : FirearmOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass8_0
			{
				public MalfunctionOperation <>4__this; //Field offset: 0x10
				public Action onHidden; //Field offset: 0x18
				public bool fastDrop; //Field offset: 0x20
				public Item nextControllerItem; //Field offset: 0x28

				public <>c__DisplayClass8_0() { }

				internal void <HideWeapon>b__0() { }

			}

			protected Ammo _ammoToFire; //Field offset: 0x50
			protected Ammo _ammoWillBeLoadedToChamber; //Field offset: 0x58
			private Action _plannedAction; //Field offset: 0x60

			protected MalfunctionOperation(FirearmController controller) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public override void Start() { }

			protected void SwitchToIdle() { }

		}

		internal class OneOffGunFire : FireOperation
		{
			protected Ammo _ammoToFire; //Field offset: 0xA0

			public OneOffGunFire(FirearmController controller) { }

			public virtual bool CanNotBeInterrupted() { }

			public virtual void FastForward() { }

			public virtual void OnFireEndEvent() { }

			public virtual void OnFireEvent() { }

			protected virtual void PrepareShot() { }

			public virtual void Reset() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void Start() { }

			protected virtual void StartFireAnimation() { }

		}

		internal class PullOutMagOperation : FirearmOperation
		{
			private Slot _from; //Field offset: 0x50
			private Callback _callback; //Field offset: 0x58
			private bool _isMagPulledOut; //Field offset: 0x60
			private bool _isMagPutToRig; //Field offset: 0x61
			private bool _isShellDropped; //Field offset: 0x62
			private bool _isAmmoRemovedFromChamber; //Field offset: 0x63
			private bool _magazineWithBelt; //Field offset: 0x64

			public PullOutMagOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			public virtual void FastForward() { }

			public virtual void OnMagPulledOutFromWeapon() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCaught) { }

			public virtual void OnShellEjectEvent() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Magazine magazine, Slot from, Callback callback) { }

		}

		internal class RechamberOperation : FirearmOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass14_0
			{
				public RechamberOperation <>4__this; //Field offset: 0x10
				public Action onHidden; //Field offset: 0x18
				public bool fastDrop; //Field offset: 0x20
				public Item nextControllerItem; //Field offset: 0x28

				public <>c__DisplayClass14_0() { }

				internal void <HideWeapon>b__0() { }

			}

			protected Item _ammoFromChamber; //Field offset: 0x50
			protected Item _ammoFromMagToChamber; //Field offset: 0x58
			private Action _plannedAction; //Field offset: 0x60
			private Callback _callback; //Field offset: 0x68
			private bool _removedAmmoFromChamber; //Field offset: 0x70
			private bool _addedAmmoToChamber; //Field offset: 0x71
			private bool _shellEjected; //Field offset: 0x72

			public RechamberOperation(FirearmController controller) { }

			[CompilerGenerated]
			private void <Start>b__8_0() { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			public virtual void OnShellEjectEvent() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public override void Start(Ammo ammo, Callback callback) { }

			protected override void SwitchToIdle() { }

		}

		internal class ReloadCylinderMagOperation : ReloadInternalMagBase
		{
			protected bool _highLevelMasteringFullReload; //Field offset: 0x90
			protected CylinderMagazine _cylinderMagazine; //Field offset: 0x98
			protected List _freeCamorasIndexes; //Field offset: 0xA0
			protected List _camorasIndexesWithShells; //Field offset: 0xA8
			protected int _shellIndexForRemove; //Field offset: 0xB0
			protected bool _quickReload; //Field offset: 0xB4
			protected int _cachedMagazineCount; //Field offset: 0xB8
			protected bool _reloadEnded; //Field offset: 0xBC

			public ReloadCylinderMagOperation(FirearmController controller) { }

			[CompilerGenerated]
			private void <EndReload>b__26_0() { }

			private void AddAmmoInHighMasteringReload() { }

			public virtual void AddAmmoToMag() { }

			protected virtual bool CanReload() { }

			private void Commit() { }

			private static void CommitReloadWithAmmo(int ammoToLoadIntoMag, AmmoPack ammoPack, Player player, CylinderMagazine magazine, Weapon weapon, List camorasIndexesForLoadAmmo) { }

			protected void EndReload() { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			public virtual void OnRemoveShellEvent() { }

			public virtual void OnShellEjectEvent() { }

			private void Prepare() { }

			private void RemoveAllAmmo() { }

			private void RemoveAllShells() { }

			public virtual void RemoveAmmoFromChamber() { }

			private void RemoveExtraPatronsInHandsAfterMasteringReload() { }

			public virtual void Reset() { }

			protected override void SendReloadCommand() { }

			private void SetAllAmmoToHandsWithMasteringReload() { }

			private void SetCamoraIndexForLoadAmmo() { }

			protected void SetCamoraIndexForRemoveShell() { }

			protected void SetNextCamoraIndexForLoadAmmo() { }

			public override void Start(AmmoPack ammoPack, Callback callback, bool quickReload = false) { }

			protected override void SwitchToIdle() { }

		}

		internal class ReloadExternalMagOperation : BaseReloadOperation
		{
			protected Callback ReloadFinished; //Field offset: 0x70
			private bool _removeAmmoFromChamber; //Field offset: 0x78
			private bool _magPulledOutFromWeapon; //Field offset: 0x79
			private bool _magPuttedToRig; //Field offset: 0x7A
			private bool _magAppeared; //Field offset: 0x7B
			private bool _magInsertedToWeapon; //Field offset: 0x7C
			private bool _addAmmoInChamber; //Field offset: 0x7D
			private bool _setInventoryOpened; //Field offset: 0x7E
			private bool _boldCatchSettedToOff; //Field offset: 0x7F
			protected ReloadExternalMagResult ReloadExternalMagResult; //Field offset: 0x80

			public ReloadExternalMagOperation(FirearmController controller) { }

			protected override void DropMod(Item droppedMod, EWeaponModType modType) { }

			public virtual void FastForward() { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnMagInsertedToWeapon() { }

			public virtual void OnMagPulledOutFromWeapon() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			public virtual void OnShellEjectEvent() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(ReloadExternalMagResult reloadExternalMagResult, Callback callback) { }

			protected override void SwitchToIdlingState() { }

			private void SwitchToReloadWithNewMag() { }

			public virtual void UseSecondMagForReload() { }

		}

		internal sealed class ReloadExternalMagResult
		{
			public readonly ItemController ItemController; //Field offset: 0x10
			public readonly Weapon Weapon; //Field offset: 0x18
			public readonly bool AmmoCompatible; //Field offset: 0x20
			[CanBeNull]
			public readonly Magazine OldMagazine; //Field offset: 0x28
			public readonly Magazine NextMagazine; //Field offset: 0x30
			public readonly Slot MagazineSlot; //Field offset: 0x38
			public readonly bool QuickReload; //Field offset: 0x40
			public readonly bool IsKnownMalfunction; //Field offset: 0x41
			[CanBeNull]
			public readonly RemoveResult RemoveFromChamberResult; //Field offset: 0x48
			[CanBeNull]
			public readonly RemoveResult RemoveOldMagResult; //Field offset: 0x50
			[CanBeNull]
			public readonly MoveResult MoveOldMagResult; //Field offset: 0x58
			public readonly MoveResult InsertNextMagResult; //Field offset: 0x60
			[CanBeNull]
			public readonly IItemOperationResult PopNewAmmoResult; //Field offset: 0x68

			private ReloadExternalMagResult(ItemController itemController, RemoveResult removeFromChamberResult, RemoveResult removeOldMagResult, MoveResult moveOldMagResult, MoveResult insertNextMagResult, IItemOperationResult popNewAmmoResult, Weapon weapon, bool ammoCompatible, bool quickReload, bool isKnownMalfunction) { }

			public bool CanExecute(ItemController itemController) { }

			public void RaiseEvents(ItemController controller, CommandStatus status) { }

			public void RollBack() { }

			public static Option Run(ItemController itemController, Weapon weapon, Magazine nextMagazine, bool quickReload, bool isKnownMalfunction, ItemAddress vestTargetAddress) { }

		}

		internal class ReloadInternalMagBase : BaseReloadOperation
		{
			protected AmmoPack _ammoPack; //Field offset: 0x70
			protected Magazine _magazine; //Field offset: 0x78
			protected bool ReloadAborted; //Field offset: 0x80
			protected int AmmoToLoadIntoMag; //Field offset: 0x84
			private bool _canAbort; //Field offset: 0x88

			protected bool CanAbort
			{
				 get { } //Length: 8
				 set { } //Length: 7
			}

			public ReloadInternalMagBase(FirearmController controller) { }

			protected override bool CanReload() { }

			protected bool get_CanAbort() { }

			public virtual void Reset() { }

			protected void set_CanAbort(bool value) { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public override void Start(AmmoPack ammoPack, Callback callback) { }

		}

		internal class ReloadInternalMagOperation : ReloadInternalMagBase
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass12_0
			{
				public Player player; //Field offset: 0x10
				public Weapon weapon; //Field offset: 0x18
				public Action <>9__0; //Field offset: 0x20

				public <>c__DisplayClass12_0() { }

				internal void <CommitReloadWithAmmo>b__0() { }

			}

			private Ammo _ammoToChamber; //Field offset: 0x90
			private bool _addedAmmoToChamber; //Field offset: 0x98

			public ReloadInternalMagOperation(FirearmController controller) { }

			[CompilerGenerated]
			private void <AddAmmoToMag>b__9_0() { }

			[CompilerGenerated]
			private void <OnAddAmmoInChamber>b__7_0() { }

			public virtual void AddAmmoToMag() { }

			private void Commit() { }

			public static void CommitReloadWithAmmo(int ammoToLoadIntoMag, AmmoPack ammoPack, Player player, Magazine magazine, Weapon weapon) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			private void Prepare() { }

			public virtual void Reset() { }

			public virtual void Start(AmmoPack ammoPack, Callback callback) { }

			protected override void SwitchToIdle() { }

		}

		internal class ReloadInternalMagWithOpenBoltOperation : ReloadInternalMagBase
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass12_0
			{
				public Player player; //Field offset: 0x10
				public Weapon weapon; //Field offset: 0x18
				public Action <>9__0; //Field offset: 0x20

				public <>c__DisplayClass12_0() { }

				internal void <CommitReloadWithAmmo>b__0() { }

				internal void <CommitReloadWithAmmo>b__1() { }

			}

			private Item _ammoFromChamber; //Field offset: 0x90
			private bool _addedAmmoToChamber; //Field offset: 0x98
			private bool _removedAmmoFromChamber; //Field offset: 0x99

			public ReloadInternalMagWithOpenBoltOperation(FirearmController controller) { }

			[CompilerGenerated]
			private void <AddAmmoToMag>b__9_0() { }

			public virtual void AddAmmoToMag() { }

			public static void CommitReloadWithAmmo(int ammoToLoadIntoMag, AmmoPack ammoPack, Player player, Magazine magazine, Weapon weapon) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			public virtual void OnShowAmmo(bool value) { }

			private void Prepare() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void Start(AmmoPack ammoPack, Callback callback) { }

			protected override void SwitchToIdle() { }

		}

		internal class ReloadMultiBarrelOperation : BaseReloadOperation
		{
			private ReloadMultiBarrelResult _reloadMultiBarrelResult; //Field offset: 0x70
			private bool _addAmmoInChamber; //Field offset: 0x78
			private bool _isReloaded; //Field offset: 0x79
			private int _shellsInWeapon; //Field offset: 0x7C

			public ReloadMultiBarrelOperation(FirearmController controller) { }

			public virtual void AddAmmoToMag() { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnRemoveShellEvent() { }

			public virtual void OnShellEjectEvent() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			private void SetChamberIndexForLoadAmmo() { }

			public override void Start(ReloadMultiBarrelResult reloadMultiBarrelResult, Callback callback) { }

		}

		internal sealed class ReloadMultiBarrelResult
		{
			public readonly ItemController ItemController; //Field offset: 0x10
			public readonly AmmoPack AmmoPackToLoad; //Field offset: 0x18
			public readonly Weapon Weapon; //Field offset: 0x20
			public readonly ItemAddress PlaceToPutContainedAmmo; //Field offset: 0x28
			public readonly IReadOnlyCollection ChambersForReloading; //Field offset: 0x30
			public readonly int ChambersInWeaponTotal; //Field offset: 0x38
			public readonly bool DiscardOldAmmo; //Field offset: 0x3C

			private ReloadMultiBarrelResult(ItemController itemController, AmmoPack ammoPackToLoad, Weapon weapon, int chambersInWeaponTotal, ItemAddress placeToPutContainedAmmo, IReadOnlyCollection chambersForReloading, bool discardOldAmmo) { }

			public bool CanExecute(ItemController itemController) { }

			public void RaiseEvents(ItemController controller, CommandStatus status) { }

			public void RollBack() { }

			public static Option Run(IDatabaseIdGenerator idGenerator, ItemController itemController, Weapon weapon, AmmoPack ammoPack, ItemAddress placeToPutContainedAmmo) { }

		}

		internal class ReloadSingleBarrelOperation : BaseReloadOperation
		{
			protected ReloadSingleBarrelResult _reloadSingleBarrelResult; //Field offset: 0x70

			public ReloadSingleBarrelOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnMagAppeared() { }

			public virtual void OnRemoveShellEvent() { }

			public virtual void OnShellEjectEvent() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public override void Start(ReloadSingleBarrelResult reloadSingleBarrelResult, Callback callback) { }

		}

		internal sealed class ReloadSingleBarrelResult
		{
			[CanBeNull]
			public readonly IItemOperationResult OldAmmoResult; //Field offset: 0x10
			[NotNull]
			public readonly IItemOperationResult InsertNewAmmoResult; //Field offset: 0x18
			public readonly ItemAddress PlaceToPutContainedAmmoMagazine; //Field offset: 0x20
			private readonly Weapon _weapon; //Field offset: 0x28
			private readonly Ammo _ammoToLoad; //Field offset: 0x30
			[CompilerGenerated]
			private MongoID <AmmoToLoadTemplateId>k__BackingField; //Field offset: 0x38
			[CompilerGenerated]
			private Nullable <AmmoToUnloadTemplateId>k__BackingField; //Field offset: 0x50

			public private MongoID AmmoToLoadTemplateId
			{
				[CompilerGenerated]
				 get { } //Length: 21
				[CompilerGenerated]
				private set { } //Length: 98
			}

			public private Nullable AmmoToUnloadTemplateId
			{
				[CompilerGenerated]
				 get { } //Length: 19
				[CompilerGenerated]
				private set { } //Length: 82
			}

			public bool DiscardOldAmmoToInventory
			{
				 get { } //Length: 9
			}

			public bool HasOldAmmoInChamber
			{
				 get { } //Length: 9
			}

			private ReloadSingleBarrelResult(Ammo ammoToLoad, IItemOperationResult oldAmmoResult, IItemOperationResult insertNewAmmoResult, Weapon weapon, ItemAddress placeToPutContainedAmmoMagazine) { }

			public bool CanExecute(ItemController itemController) { }

			[CompilerGenerated]
			public MongoID get_AmmoToLoadTemplateId() { }

			[CompilerGenerated]
			public Nullable get_AmmoToUnloadTemplateId() { }

			public bool get_DiscardOldAmmoToInventory() { }

			public bool get_HasOldAmmoInChamber() { }

			public void RaiseEvents(ItemController controller, CommandStatus status) { }

			public void RollBack() { }

			public static Option Run(IDatabaseIdGenerator idGenerator, ItemController itemController, Weapon weapon, Ammo ammo, ItemAddress placeToPutContainedAmmoMagazine) { }

			[CompilerGenerated]
			private void set_AmmoToLoadTemplateId(MongoID value) { }

			[CompilerGenerated]
			private void set_AmmoToUnloadTemplateId(Nullable value) { }

		}

		internal sealed class Remove : FirearmOperation
		{
			private Action _onHiddenCallback; //Field offset: 0x50

			public Remove(FirearmController controller) { }

			public virtual void BlindFire(int b) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void HideWeaponComplete() { }

			public virtual void OnDropWeapon() { }

			public virtual void Reset() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void Start(Action onHidden, bool fastDrop = false, Item nextControllerItem = null) { }

		}

		internal sealed class RemoveModOperation : FirearmOperation
		{
			private Slot _slot; //Field offset: 0x50
			private Callback _callback; //Field offset: 0x58
			private bool _onModChanged; //Field offset: 0x60

			public RemoveModOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			private void CheckUnderbarrelMode() { }

			public virtual void FastForward() { }

			public virtual void OnModChanged() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Start(Item item, Slot slot, Callback callback) { }

		}

		internal sealed class RepairFeedResult
		{
			public readonly ItemController ItemController; //Field offset: 0x10
			public readonly Weapon Weapon; //Field offset: 0x18
			public readonly bool AmmoCompatible; //Field offset: 0x20
			public readonly IItemOperationResult PopNewAmmoResult; //Field offset: 0x28

			private RepairFeedResult(ItemController itemController, IItemOperationResult popNewAmmoResult, Weapon weapon, bool ammoCompatible) { }

			public bool CanExecute(ItemController itemController) { }

			public void RaiseEvents(ItemController controller, CommandStatus status) { }

			public void RollBack() { }

			public static Option Run(ItemController itemController, Weapon weapon) { }

		}

		internal class RepairMalfunction : MalfunctionOperation
		{
			private bool _doNotAddAmmoInChamber; //Field offset: 0x68
			private bool _shellEjected; //Field offset: 0x69
			private EMalfunctionState _malfStateBeforeRepair; //Field offset: 0x6C

			public RepairMalfunction(FirearmController controller) { }

			[CompilerGenerated]
			private void <Start>b__4_0() { }

			public virtual bool CheckChamber() { }

			public virtual void FastForward() { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnMalfunctionOffEvent() { }

			public virtual void OnOnOffBoltCatchEvent(bool isCatched) { }

			public virtual void OnShellEjectEvent() { }

			public virtual void RemoveAmmoFromChamber() { }

			public virtual void Reset() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void Start() { }

		}

		internal class RocketLauncherFire : FireOperation
		{
			private Rocket _ammoToFire; //Field offset: 0xA0

			public RocketLauncherFire(FirearmController controller) { }

			public virtual bool CanNotBeInterrupted() { }

			public virtual void OnFireEndEvent() { }

			public virtual void OnFireEvent() { }

			protected virtual void PrepareShot() { }

			public virtual void Reset() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public virtual void Start() { }

		}

		internal class RollCylinderOperation : FirearmOperation
		{
			protected CylinderMagazine _cylinderMagazine; //Field offset: 0x50
			private bool _magPuttedToRig; //Field offset: 0x58
			private Callback _finishCallback; //Field offset: 0x60
			private bool _rollToZeroCamora; //Field offset: 0x68

			public RollCylinderOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			public virtual void OnMagPuttedToRig() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			internal override void Start(Callback finishCallback, bool rollToZeroCamora) { }

		}

		internal sealed class ServerDropBackpackOperation : DropBackpackOperation
		{
			private const float BACKPACK_DROP_EVENT_TIME = 0.35; //Field offset: 0x0

			protected virtual float BackpackDropEventTime
			{
				 get { } //Length: 9
			}

			public ServerDropBackpackOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			protected virtual float get_BackpackDropEventTime() { }

		}

		internal class SpawnOperation : FirearmOperation
		{
			private Action _onWeaponAppear; //Field offset: 0x50
			private Action _onHideCallback; //Field offset: 0x58
			private bool _fastHide; //Field offset: 0x60
			private Ammo _ammoFromMagToChamber; //Field offset: 0x68
			private Magazine _currentMagazine; //Field offset: 0x70
			private bool _ammoCompatible; //Field offset: 0x78

			public SpawnOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			public virtual void FastForward() { }

			protected virtual double GetMaxOperationDuration() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnAddAmmoInChamber() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public override void Start(Action onWeaponAppear) { }

			public virtual void WeaponAppeared() { }

		}

		internal sealed class StartMalfunction : MalfunctionOperation
		{

			public StartMalfunction(FirearmController controller) { }

			public virtual void FastForward() { }

			public virtual void OnMalfunctionOffEvent() { }

			public virtual void OnShellEjectEvent() { }

			public virtual void Start() { }

		}

		private class ToggleBipodOperation : FirearmOperation
		{
			private Action _toggleCallback; //Field offset: 0x50
			private Action _hideAction; //Field offset: 0x58
			private bool _needToHide; //Field offset: 0x60
			private bool _fastDrop; //Field offset: 0x61

			public ToggleBipodOperation(FirearmController controller) { }

			public virtual bool CanChangeLightState(LightsState[] lightsStates) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void OnBipodToggleEvent() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Start(Action callback = null) { }

			private void SwitchToIdle() { }

		}

		internal class ToggleLauncherOperation : FirearmOperation
		{
			private Action _callback; //Field offset: 0x50
			private WeaponPrefab _launcherPrefab; //Field offset: 0x58
			private bool _isLauncherEnabled; //Field offset: 0x60
			private bool _fastHide; //Field offset: 0x61
			private Action _onHideAction; //Field offset: 0x68

			public ToggleLauncherOperation(FirearmController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop, Item nextControllerItem = null) { }

			public virtual void LauncherAppeared() { }

			public virtual void LauncherDisappeared() { }

			public virtual void OnEnd() { }

			public virtual void Reset() { }

			private void ResetBlindFire() { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			private void SetUnderBarrelDeviceActive(bool val) { }

			public void Start(bool isLauncherEnabled, Action callback = null) { }

		}

		internal class UnderbarrelContainer : IShellCollisionListener
		{
			[CompilerGenerated]
			private sealed class <SpawnShell>d__51 : IEnumerator, IEnumerator, IDisposable
			{
				private int <>1__state; //Field offset: 0x10
				private object <>2__current; //Field offset: 0x18
				public UnderbarrelContainer <>4__this; //Field offset: 0x20
				public Vector3 playerVelocity; //Field offset: 0x28
				private AmmoPoolObject <shell>5__2; //Field offset: 0x38

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
				public <SpawnShell>d__51(int <>1__state) { }

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

			public const string SHELLPORT_TRANSFORM_NAME = "shellport"; //Field offset: 0x0
			public const string PATRON_IN_WEAPON_TRANSFORM_NAME = "patron_in_weapon"; //Field offset: 0x0
			private Player _player; //Field offset: 0x10
			private FirearmController _controller; //Field offset: 0x18
			private WeaponPrefab _launcherWeaponPrefab; //Field offset: 0x20
			private Launcher _launcher; //Field offset: 0x28
			private bool _weaponSoundInitialized; //Field offset: 0x30
			private FirearmsEffects _firearmsEffects; //Field offset: 0x38
			private WeaponSoundPlayer _weaponSound; //Field offset: 0x40
			private Transform _shellPortTransform; //Field offset: 0x48
			private Vector3 _initialShellPortPosition; //Field offset: 0x50
			private Transform _patronInWeaponTransform; //Field offset: 0x60
			private AmmoPoolObject _ammoObjectInUnderbarrel; //Field offset: 0x68
			private AmmoPoolObject _shellObjectInUnderbarrel; //Field offset: 0x70
			private ShellExtractionData _shellExtractionData; //Field offset: 0x78
			private BifacialTransform _fireport; //Field offset: 0x80
			private WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0x88

			public FirearmsEffects FirearmsEffects
			{
				 get { } //Length: 5
			}

			public BifacialTransform Fireport
			{
				 get { } //Length: 8
			}

			public WeaponPrefab LauncherWeaponPrefab
			{
				 get { } //Length: 5
			}

			private static WeaponSounds SoundsPrefab
			{
				private get { } //Length: 61
			}

			public WeaponSoundPlayer WeaponSoundPlayer
			{
				 get { } //Length: 5
			}

			public UnderbarrelContainer() { }

			public void Clear() { }

			public bool DestroyPatronInWeapon() { }

			private void DestroyShellInWeapon() { }

			private void FindFireport() { }

			private void FindWeaponSoundPlayer() { }

			public FirearmsEffects get_FirearmsEffects() { }

			public BifacialTransform get_Fireport() { }

			public WeaponPrefab get_LauncherWeaponPrefab() { }

			private static WeaponSounds get_SoundsPrefab() { }

			public WeaponSoundPlayer get_WeaponSoundPlayer() { }

			public bool HasPatronInWeapon() { }

			public bool HasShellInWeapon() { }

			public void Init(Player player, FirearmController controller, Launcher launcher) { }

			public void Init(Player player, FirearmController controller, Launcher launcher, GameObject underbarrelPrefab) { }

			private void InitFirearmsEffects() { }

			private void InitShellsAndAmmo() { }

			private void InitTransformsForAmmo() { }

			public void InitWeaponSoundPlayer() { }

			public override void InvokeShellCollision(Vector3 position, ESurfaceSound material, ECaliber caliber) { }

			private bool IsPatronVisible() { }

			private bool IsShellVisible() { }

			public void MoveAmmoFromChamberToShellPort(bool ammoIsUsed, int chamberIndex = 0) { }

			public static void ParentAmmoOrShellToTransform(GameObject shell, Transform shellParent) { }

			private void PlayShellSound(Vector3 position, ESurfaceSound material, ECaliber caliber) { }

			public void RemoveShellInWeapon() { }

			public void SetPatronInShellPort(AmmoPoolObject ammoObject, int shellTransformIndex = 0) { }

			public void SetRoundIntoWeapon(Ammo ammo) { }

			private void Setup(Player player, FirearmController controller, Launcher launcher) { }

			private AmmoPoolObject SpawnExtractingCartridge(Vector3 playerVelocity, AmmoPoolObject shell) { }

			private static AmmoPoolObject SpawnItemObject(Item ammo) { }

			[IteratorStateMachine(typeof(<SpawnShell>d__51))]
			private IEnumerator SpawnShell(Vector3 playerVelocity, int shellPortIndex = 0) { }

			public void StartSpawnShell(Vector3 playerVelocity, int shellPortIndex = 0) { }

			private void UseGameObjectForShellExtraction(Vector3 force, Vector3 torque, AmmoPoolObject shell, Vector3 parentForce) { }

		}

		internal class UtilityOperation : Idling
		{
			internal enum EUtilityType
			{
				None = 0,
				ExamineWeapon = 1,
				CheckChamber = 2,
				CheckMagazine = 3,
				CheckFireMode = 4,
			}

			private const float MAX_UTILITY_TIME = 2.5; //Field offset: 0x0
			private float _utilityTime; //Field offset: 0x78
			private bool _inInventory; //Field offset: 0x7C
			private EUtilityType _utilityOperationType; //Field offset: 0x80

			public virtual EOperationState State
			{
				 get { } //Length: 4
				 set { } //Length: 127
			}

			public UtilityOperation(FirearmController controller) { }

			public virtual bool CanStartReload(bool checkWeaponMalfunctions = true) { }

			public virtual bool CheckAmmo() { }

			public virtual bool CheckChamber() { }

			public virtual bool CheckFireMode() { }

			public virtual bool ExamineWeapon() { }

			public virtual void FastForward() { }

			public virtual EOperationState get_State() { }

			public virtual void OnIdleStartEvent() { }

			public virtual void OnShellEjectEvent() { }

			public virtual void OnUtilityOperationStartEvent() { }

			public virtual void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadCylinderMagazine(AmmoPack ammoPack, Callback finishCallback, Callback startCallback, bool quickReload = false) { }

			public virtual void ReloadGrenadeLauncher(AmmoPack ammoPack, Callback callback) { }

			public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

			public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

			public virtual void Reset() { }

			protected virtual void set_State(EOperationState value) { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public virtual void SetTriggerPressed(bool pressed) { }

			public void Start(EUtilityType utilityType) { }

			public virtual void Update(float deltaTime) { }

		}

		public const int CALCULATOR_SEED = 0; //Field offset: 0x0
		public const float HANDS_IS_READY_TO_AIM_POSITION_LEFT_STANCE_VALUE = 0.8; //Field offset: 0x0
		private const float READY_TO_AIM_AUTHORITY = 0.1; //Field offset: 0x0
		protected static readonly List _preallocatedAmmoList; //Field offset: 0x0
		private const float FREE_FALL_TIME_FOR_EXIT_AIM = 0.5; //Field offset: 0x0
		private const float READY_TO_AIM_OVERLAP = 0.25; //Field offset: 0x0
		public const float OFFSET_FOR_OVERLAP_RAY_ON_LEFT_SHOULDER = 0.2; //Field offset: 0x0
		private const float DEFAULT_FAST_DROP_SPEED_MULTIPLIER = 1.5; //Field offset: 0x0
		private const string RELOAD_START_ERROR = "Cant StartReload"; //Field offset: 0x0
		public const float ADDITIONAL_LEFTSTANCE_OVERLAP_RAY_LENGTH = 0.2; //Field offset: 0x0
		private static readonly List _preallocatedShots; //Field offset: 0x8
		private static readonly RaycastHit[] _raycastHits; //Field offset: 0x10
		[CompilerGenerated]
		private Action OnShot; //Field offset: 0xA8
		[CompilerGenerated]
		private Action OnReadyToOperate; //Field offset: 0xB0
		[CompilerGenerated]
		private Action BreakLoop; //Field offset: 0xB8
		internal Func IsAIShootFromEyes; //Field offset: 0xC0
		internal Func IsNoOffsetShooting; //Field offset: 0xC8
		internal Firearms Firearms; //Field offset: 0xD0
		private WeaponPrefab _weaponPrefab; //Field offset: 0xD8
		private MalfunctionRandom _malfRandoms; //Field offset: 0xE0
		private bool _isInventoryOpened; //Field offset: 0xE8
		private bool _malfunction; //Field offset: 0xE9
		private float _overlap; //Field offset: 0xEC
		private float COI; //Field offset: 0xF0
		private float ShotgunDispersion; //Field offset: 0xF4
		internal FirearmsAnimator _firearmsAnimator; //Field offset: 0xF8
		protected float WeaponLn; //Field offset: 0x100
		protected bool AimingInterruptedByOverlap; //Field offset: 0x104
		protected bool _isAiming; //Field offset: 0x105
		private bool _inChangeAimingAnimationState; //Field offset: 0x106
		private bool _isFireBlockedInReload; //Field offset: 0x107
		protected float _aimingSens; //Field offset: 0x108
		protected IBallisticsCalculator BallisticsCalculator; //Field offset: 0x110
		private WeaponBuffsInfo _buffInfo; //Field offset: 0x118
		private bool _isTriggerPressed; //Field offset: 0x120
		private bool _manuallyUpdated; //Field offset: 0x121
		private bool _processShot; //Field offset: 0x122
		private int _playerLayer; //Field offset: 0x124
		private Deferred _deferredErgonomicWeight; //Field offset: 0x128
		private Deferred _deferredErgonomic; //Field offset: 0x130
		private Func _isOverlapHitIgnoredTest; //Field offset: 0x138
		public ContainerCollectionView CCV; //Field offset: 0x140
		public Transform GunBaseTransform; //Field offset: 0x148
		public BifacialTransform Fireport; //Field offset: 0x150
		public BifacialTransform[] MultiBarrelsFireports; //Field offset: 0x158
		public bool _blindfire; //Field offset: 0x160
		public int CurrentChamberIndex; //Field offset: 0x164
		public float HipInaccuracy; //Field offset: 0x168
		public TacticalCombo[] AimingDevices; //Field offset: 0x170
		public int AmmoInChamberOnSpawn; //Field offset: 0x178
		public bool autoFireOn; //Field offset: 0x17C
		public Bipod Bipod; //Field offset: 0x180
		private OneOffWeaponSettings _oneOffWeaponSettings; //Field offset: 0x188
		private bool _hasUniqueModForHands; //Field offset: 0x190
		private bool _bipodState; //Field offset: 0x191
		private float _lastShotRecoil; //Field offset: 0x194
		private WeaponSoundPlayer _weaponSoundPlayer; //Field offset: 0x198
		private int _underbarrelSightIndex; //Field offset: 0x1A0
		private UnderbarrelContainer _underbarrelContainer; //Field offset: 0x1A8
		public Launcher UnderbarrelWeapon; //Field offset: 0x1B0
		[CompilerGenerated]
		private bool <IsSilenced>k__BackingField; //Field offset: 0x1B8
		private bool _isPressingAim; //Field offset: 0x1B9
		private bool _isClickedAim; //Field offset: 0x1BA
		private Coroutine _pressingAimCoroutine; //Field offset: 0x1C0
		[CompilerGenerated]
		private bool <IsBirstOf2Start>k__BackingField; //Field offset: 0x1C8
		private bool _disableLeftStanceByOverlap; //Field offset: 0x1C9
		private bool _wasInInventoryLastFrame; //Field offset: 0x1CA
		private float _delayToChangeLeftStanceAfterActions; //Field offset: 0x1CC
		private float _normalizedTimeForChangeLeftStance; //Field offset: 0x1D0
		[CompilerGenerated]
		private Action OnRocketLaunchedEvent; //Field offset: 0x1D8
		private List _malfSourcesBuffer; //Field offset: 0x1E0
		private List _malfStatesBuffer; //Field offset: 0x1E8

		public event Action BreakLoop
		{
			[CompilerGenerated]
			 add { } //Length: 251
			[CompilerGenerated]
			 remove { } //Length: 251
		}

		public event Action OnReadyToOperate
		{
			[CompilerGenerated]
			 add { } //Length: 278
			[CompilerGenerated]
			 remove { } //Length: 278
		}

		public event Action OnRocketLaunchedEvent
		{
			[CompilerGenerated]
			 add { } //Length: 278
			[CompilerGenerated]
			 remove { } //Length: 278
		}

		public event Action OnShot
		{
			[CompilerGenerated]
			 add { } //Length: 251
			[CompilerGenerated]
			 remove { } //Length: 251
		}

		public virtual float AimingSensitivity
		{
			 get { } //Length: 95
		}

		public bool BipodState
		{
			 get { } //Length: 8
			 set { } //Length: 7
		}

		public bool Blindfire
		{
			 get { } //Length: 8
			 set { } //Length: 33
		}

		public WeaponBuffsInfo BuffInfo
		{
			 get { } //Length: 8
		}

		public bool CanSetBlindFire
		{
			 get { } //Length: 576
		}

		public override BifacialTransform CurrentFireport
		{
			 get { } //Length: 98
		}

		public int CurrentMasteringLevel
		{
			 get { } //Length: 374
		}

		protected FirearmOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public bool DisableLeftStanceByOverlap
		{
			 get { } //Length: 8
		}

		public override float ErgonomicWeight
		{
			 get { } //Length: 45
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public Vector3 FireportPosition
		{
			 get { } //Length: 144
		}

		public bool HasBipod
		{
			 get { } //Length: 12
		}

		public bool InventoryOpened
		{
			 get { } //Length: 8
			 set { } //Length: 76
		}

		public virtual bool IsAiming
		{
			 get { } //Length: 8
			 set { } //Length: 1140
		}

		public virtual bool IsAimingButtonPressing
		{
			 get { } //Length: 19
		}

		public bool IsBipodsOperation
		{
			 get { } //Length: 131
		}

		public bool IsBirstOf2Start
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public override bool IsOverlap
		{
			 get { } //Length: 18
		}

		public private bool IsSilenced
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 7
		}

		protected bool IsStationaryWeapon
		{
			 get { } //Length: 240
		}

		protected private override bool IsTriggerPressed
		{
			private get { } //Length: 8
			private set { } //Length: 82
		}

		public override Weapon Item
		{
			 get { } //Length: 140
		}

		public virtual string LoggerDistinctId
		{
			 get { } //Length: 194
		}

		public bool Malfunction
		{
			 get { } //Length: 8
			 set { } //Length: 82
		}

		public override bool MouseLookControl
		{
			 get { } //Length: 30
		}

		public float OverlapValue
		{
			 get { } //Length: 9
		}

		public override float TotalErgonomics
		{
			 get { } //Length: 45
		}

		public override Weapon Weapon
		{
			 get { } //Length: 7
		}

		public override Vector3 WeaponDirection
		{
			 get { } //Length: 315
		}

		public WeaponSoundPlayer WeaponSoundPlayer
		{
			 get { } //Length: 8
		}

		private static FirearmController() { }

		public FirearmController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_0() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_1() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_10() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_11() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_12() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_13() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_14() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_15() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_16() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_17() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_18() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_19() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_2() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_20() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_21() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_22() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_23() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_24() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_25() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_26() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_27() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_28() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_29() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_3() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_30() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_31() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_32() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_33() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_4() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_5() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_6() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_7() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_8() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__400_9() { }

		[CompilerGenerated]
		public void add_BreakLoop(Action value) { }

		[CompilerGenerated]
		public void add_OnReadyToOperate(Action value) { }

		[CompilerGenerated]
		public void add_OnRocketLaunchedEvent(Action value) { }

		[CompilerGenerated]
		public void add_OnShot(Action value) { }

		private void AddAmmoToMag() { }

		public override void AdjustShotVectors(ref Vector3 position, ref Vector3 direction) { }

		public bool AudioDelegate() { }

		public virtual void BlindFire(int b) { }

		public float CalculateAimingSoundVolume() { }

		private float CalculateBaseAimingVolume() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		private bool CanExecuteWithoutAnimation(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		public override bool CanPressTrigger() { }

		public virtual bool CanRemove() { }

		private bool CanShowFastWeaponSwitchAbilityNotification() { }

		public override bool CanStartReload(bool checkWeaponMalfunctions = true) { }

		public override void ChangeAimingMode() { }

		public override void ChangeAimingMode(int modeIndex) { }

		public override bool ChangeFireMode(EFireMode fireMode) { }

		public override void ChangeLeftStance() { }

		public override bool CheckAmmo() { }

		public override bool CheckChamber() { }

		public override bool CheckFireMode() { }

		public bool CheckForFastWeaponSwitch(Item nextControllerItem) { }

		private bool CheckVaulting() { }

		public void ClearModAudioController(Slot slot) { }

		private void ClearUnderbarrelFromWeaponInActiveHands() { }

		public override void ClickAim() { }

		internal static T CreateController(Player player, Weapon weapon) { }

		[AsyncStateMachine(typeof(<CreateControllerAsync>d__142`1))]
		internal static Task CreateControllerAsync(Player player, Weapon weapon) { }

		protected override void CreateFlareShot(Ammo flareItem, Vector3 shotPosition, Vector3 forward) { }

		protected override void CreateRocketShot(Ammo rocketItem, Vector3 shotPosition, Vector3 forward, Transform smokeport = null) { }

		private void DelAmmoFromMag() { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		protected private override void DryShot(int chamberIndex = 0, bool underbarrelShot = false) { }

		private float ErgonomicWeightFunc() { }

		private void EventsTableOnFold(bool b) { }

		public override bool ExamineWeapon() { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		public virtual float get_AimingSensitivity() { }

		public bool get_BipodState() { }

		public bool get_Blindfire() { }

		public WeaponBuffsInfo get_BuffInfo() { }

		public bool get_CanSetBlindFire() { }

		public override BifacialTransform get_CurrentFireport() { }

		public int get_CurrentMasteringLevel() { }

		protected FirearmOperation get_CurrentOperation() { }

		public bool get_DisableLeftStanceByOverlap() { }

		public override float get_ErgonomicWeight() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public Vector3 get_FireportPosition() { }

		public bool get_HasBipod() { }

		public bool get_InventoryOpened() { }

		public virtual bool get_IsAiming() { }

		public virtual bool get_IsAimingButtonPressing() { }

		public bool get_IsBipodsOperation() { }

		[CompilerGenerated]
		public bool get_IsBirstOf2Start() { }

		public override bool get_IsOverlap() { }

		[CompilerGenerated]
		public bool get_IsSilenced() { }

		protected bool get_IsStationaryWeapon() { }

		protected private override bool get_IsTriggerPressed() { }

		public override Weapon get_Item() { }

		public virtual string get_LoggerDistinctId() { }

		public bool get_Malfunction() { }

		public override bool get_MouseLookControl() { }

		public float get_OverlapValue() { }

		public override float get_TotalErgonomics() { }

		public override Weapon get_Weapon() { }

		public override Vector3 get_WeaponDirection() { }

		public WeaponSoundPlayer get_WeaponSoundPlayer() { }

		protected List GetAllLightMods() { }

		public virtual float GetAnimatorFloatParam(int hash) { }

		private float GetBarrelDeviation(Weapon weapon) { }

		public Dictionary GetCurrentLightStatus() { }

		public Dictionary GetCurrentScopesStatus() { }

		public void GetMalfunctionSources(List result, double durabilityMalfChance, float magMalfChance, float ammoMalfChance, float overheatMalfChance, bool hasAmmoInMag, bool isMagazineInserted) { }

		public EMalfunctionState GetMalfunctionState(Ammo ammoToFire, bool hasAmmoInMag, bool doesWeaponHaveBoltCatch, bool isMagazineInserted, float overheat, float fixSlideOverheat, out EMalfunctionSource malfunctionSource) { }

		public float GetNextMalfunctionRandom() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		public void GetSpecificMalfunctionVariants(List result, Ammo ammo, EMalfunctionSource malfunctionSource, float weaponDurability, bool hasAmmoInMag, bool isMagazineInserted, bool shouldCheckJam) { }

		public float GetTotalMalfunctionChance(Ammo ammoToFire, float overheat, out double durabilityMalfChance, out float magMalfChance, out float ammoMalfChance, out float overheatMalfChance, out float weaponDurability) { }

		public float GetWeaponDrawSpeedMultiplier(Weapon weapon, bool useFastDropAnimationSpeed) { }

		public float GetWeaponReloadAnimationSpeed() { }

		private bool HasPartOfWeapon(IInventoryOperation operation) { }

		public override bool HasScopeAimBone(SightComponent sightComp) { }

		private void HideWeaponComplete() { }

		protected virtual void IEventsConsumerOnAddAmmoInChamber() { }

		protected virtual void IEventsConsumerOnAddAmmoInMag() { }

		protected virtual void IEventsConsumerOnArm() { }

		protected virtual void IEventsConsumerOnDelAmmoChamber() { }

		protected virtual void IEventsConsumerOnDelAmmoFromMag() { }

		protected virtual void IEventsConsumerOnDisarm() { }

		protected virtual void IEventsConsumerOnFireEnd() { }

		protected virtual void IEventsConsumerOnFiringBullet() { }

		protected virtual void IEventsConsumerOnFoldOff() { }

		protected virtual void IEventsConsumerOnFoldOn() { }

		protected virtual void IEventsConsumerOnIdleStart() { }

		protected virtual void IEventsConsumerOnLauncherAppeared() { }

		protected virtual void IEventsConsumerOnLauncherDisappeared() { }

		protected virtual void IEventsConsumerOnMagHide() { }

		protected virtual void IEventsConsumerOnMagIn() { }

		protected virtual void IEventsConsumerOnMagOut() { }

		protected virtual void IEventsConsumerOnMagShow() { }

		protected virtual void IEventsConsumerOnMalfunctionOff() { }

		protected virtual void IEventsConsumerOnModChanged() { }

		protected virtual void IEventsConsumerOnOffBoltCatch() { }

		protected virtual void IEventsConsumerOnOnBoltCatch() { }

		protected virtual void IEventsConsumerOnOnUseProp(bool boolParam) { }

		protected virtual void IEventsConsumerOnPutMagToRig() { }

		protected virtual void IEventsConsumerOnRemoveShell() { }

		protected virtual void IEventsConsumerOnReplaceSecondMag() { }

		protected virtual void IEventsConsumerOnShellEject() { }

		protected virtual void IEventsConsumerOnShowAmmo(bool boolParam) { }

		protected virtual void IEventsConsumerOnStartUtilityOperation() { }

		protected virtual void IEventsConsumerOnThirdAction(int intParam) { }

		protected virtual void IEventsConsumerOnUseSecondMagForReload() { }

		protected virtual void IEventsConsumerOnWeapIn() { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		protected virtual void IEventsOnBackpackDrop() { }

		protected virtual void IEventsOnBipodToggle() { }

		public virtual bool InCanNotBeInterruptedOperation() { }

		protected override void InitBallisticCalculator() { }

		protected void InitiateFlare(Ammo flareItem, Vector3 shotPosition, Vector3 forward) { }

		protected void InitiateRocket(Rocket rocketItem, Vector3 shotPosition, Vector3 forward, Transform smokeport) { }

		private void InitiateShot(IWeapon weapon, Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, Vector3 fireportPosition, int chamberIndex, float overheat) { }

		public void InitModsAudioControllers(FirearmController firearmController) { }

		private void InitSoundPlayer() { }

		private void InitUnderbarrelSoundPlayer() { }

		private void InitUnderbarrelWeapon() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual bool IsHandsProcessing() { }

		private bool IsHandsReadyToAim() { }

		public virtual bool IsInInteraction() { }

		public virtual bool IsInInteractionStrictCheck() { }

		public override bool IsInLauncherMode() { }

		public bool IsInReloadOperation() { }

		public bool IsInRemoveOperation() { }

		public bool IsInSpawnOperation() { }

		public virtual bool IsInventoryOpen() { }

		private bool IsOverlapHitIgnored(RaycastHit overlapHit) { }

		private void LauncherAppeared() { }

		private void LauncherDisappeared() { }

		private void LauncherShot(Launcher launcher, Ammo ammo) { }

		private void LaunchFlareGunShot(Ammo flareItem) { }

		private void LaunchRocketShot(Rocket rocketItem) { }

		protected override void LightAndSoundShot(Vector3 point, Vector3 direction, AmmoTemplate ammoTemplate) { }

		private void LightAndSoundShotVisualEffect(Vector3 point, Vector3 direction) { }

		public virtual void Loot(bool p) { }

		public virtual void ManualLateUpdate(float deltaTime) { }

		public virtual void ManualUpdate(float deltaTime) { }

		private void ModChanged() { }

		private void OnAddAmmoInChamber() { }

		private void OnAimingDisabled() { }

		public virtual void OnAimReady() { }

		private void OnBackpackDropEvent() { }

		private void OnBipodToggleEvent() { }

		public void OnCurrentWeaponBeingMastered(Mastering m) { }

		private void OnDestroy() { }

		public virtual void OnDropWeapon() { }

		private void OnFireEndEvent() { }

		private void OnFireEvent() { }

		public virtual void OnIdleReady() { }

		private void OnIdleStartEvent() { }

		private void OnJumpOrFall() { }

		private void OnMagAppeared() { }

		private void OnMagDisappeared() { }

		private void OnMagInsertedToWeapon() { }

		private void OnMagPulledOutFromWeapon() { }

		private void OnMalfunctionOffEvent() { }

		private void OnOnOffBoltCatchEvent(bool isCatched) { }

		public virtual void OnPlayerDead() { }

		private void OnRemoveShellEvent() { }

		private void OnShellEjectEvent() { }

		private void OnShowAmmo(bool b) { }

		private void OnSkillLevelUp(BaseSkill obj) { }

		private void OnSprintFinished() { }

		private void OnSprintStart() { }

		public override void OpticCalibrationSwitchDown(ScopeState[] scopeStates) { }

		public override void OpticCalibrationSwitchUp(ScopeState[] scopeStates) { }

		private float OverlapLn(Vector3 origin, float ln, ref bool overlapsWithPlayer, Nullable weaponUp = null) { }

		private void PhysicalConditionChanged(EPhysicalCondition condition, EPhysicalCondition full) { }

		public virtual void Pickup(bool p) { }

		private void PlayAimingSound() { }

		private void PlayFireBulletSound(WeaponSoundPlayer weaponSoundPlayer, Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, bool multiShot) { }

		public override void PressingAim() { }

		[IteratorStateMachine(typeof(<PressingAimCoroutine>d__293))]
		private IEnumerator PressingAimCoroutine(bool oneTriggering) { }

		protected override void ProcessShotInPacket(IWeapon weapon, int chamberIndex, float overheat, Vector3 shotPosition, Vector3 shotDirection, Vector3 fireportPosition) { }

		private void PutMagToRig() { }

		public override void QuickReloadMag(Magazine magazine, Callback callback) { }

		public override void RecalculateErgonomic() { }

		protected override void RegisterShot(Item weapon, Shot shot) { }

		public override void ReloadBarrels(AmmoPack ammoPack, ItemAddress placeToPutContainedAmmoMagazine, Callback callback) { }

		public override void ReloadCylinderMagazine(AmmoPack ammoPack, Callback callback, bool quickReload = false) { }

		public override void ReloadGrenadeLauncher(AmmoPack foundItem, Callback callback) { }

		public override void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback callback) { }

		public override void ReloadMagNotFound() { }

		public override void ReloadWithAmmo(AmmoPack ammoPack, Callback callback) { }

		[CompilerGenerated]
		public void remove_BreakLoop(Action value) { }

		[CompilerGenerated]
		public void remove_OnReadyToOperate(Action value) { }

		[CompilerGenerated]
		public void remove_OnRocketLaunchedEvent(Action value) { }

		[CompilerGenerated]
		public void remove_OnShot(Action value) { }

		private void RemoveAmmoFromChamber() { }

		protected override void RemoveBallisticCalculator() { }

		private void ReplaceSecondMag() { }

		private void ResetAimingAnimationsFlags() { }

		private void ResetAllAnimationModsId() { }

		public override void RollCylinder(bool rollToZeroCamora) { }

		protected override void SendStartOneShotFire() { }

		public void set_BipodState(bool value) { }

		public void set_Blindfire(bool value) { }

		public void set_InventoryOpened(bool value) { }

		protected virtual void set_IsAiming(bool value) { }

		[CompilerGenerated]
		public void set_IsBirstOf2Start(bool value) { }

		[CompilerGenerated]
		private void set_IsSilenced(bool value) { }

		protected private override void set_IsTriggerPressed(bool value) { }

		public void set_Malfunction(bool value) { }

		public override void SetAim(int scopeIndex) { }

		public override void SetAim(bool value) { }

		private void SetAimingInAnimator(bool isAiming) { }

		public void SetAnimatorAndProceduralValues() { }

		private void SetAnimatorValues() { }

		private void SetArm(bool armed) { }

		public virtual void SetCompassState(bool active) { }

		public virtual void SetInventoryOpened(bool opened) { }

		public override bool SetLightsState(LightsState[] lightsStates, bool force = false, bool animated = true) { }

		public void SetMaxUniqueAnimationModId() { }

		private void SetModsParamsInAnimator(IEnumerable mods) { }

		public override void SetScopeMode(ScopeState[] scopeStates) { }

		public override void SetTriggerPressed(bool pressed) { }

		private void SetUnderbarrelModOnWeaponInActiveHands(Launcher underbarrelWeapon, GameObject _weaponPrefab) { }

		public void SetUnderbarrelWeapon() { }

		[AsyncStateMachine(typeof(<Setup>d__143`1))]
		private static Task Setup(T controller, Player player, Weapon weapon, bool async = true) { }

		public void SetupModAudioController(Transform modObjectTransform, FirearmController firearmController) { }

		private void SetUpOverlaping() { }

		public override void SetWeaponOverlapValue(float overlap) { }

		private void Shot(Weapon weapon, Ammo ammo, int chamberIndex, bool multiShot = false) { }

		protected override void ShotMisfired(Ammo ammo, EMalfunctionState malfunctionState, float overheat) { }

		public override bool ShouldForceQuickReload() { }

		public virtual void ShowGesture(EInteraction gesture) { }

		private void SmoothScopeStateChanged(ESmoothScopeState scopeState) { }

		protected override void SmoothScopeZoomValueChanged(SightComponent sightComponent, float scopeZoomValue) { }

		private void SmoothSensitivityChanged(float sensitivity) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

		private void SprintStateChangedEvent(bool value) { }

		private void StateChangedHandler(EPlayerState previousstate, EPlayerState nextstate) { }

		private void StopAimingCoroutine() { }

		public virtual bool SupportPickup() { }

		public virtual void SyncWeaponData(ItemDescriptor weaponDescriptor) { }

		public void SyncWithCharacterSkills() { }

		public override void ToggleAim() { }

		public override bool ToggleBipod() { }

		public override bool ToggleLauncher(Action callback = null) { }

		private float TotalErgonomicsFunc() { }

		public override void UnderbarrelSightingRangeDown() { }

		public override void UnderbarrelSightingRangeUp() { }

		public override void UnpressingAim() { }

		public void UpdateHipInaccuracy() { }

		private void UpdateIsWithSilencer() { }

		public void UpdateSensitivity() { }

		private void UseSecondMagForReload() { }

		public void ValidateCurrentScopeIndex() { }

		private void WeaponAppeared() { }

		public void WeaponModified() { }

		public override void WeaponOverlapping() { }

		public void WeaponOverlapView() { }

	}

	internal class Garbage
	{
		public Vector3 Shift; //Field offset: 0x10
		public Transform Transform; //Field offset: 0x20
		public CommonTransportee Transportee; //Field offset: 0x28

		public Garbage() { }

		public void Destroy() { }

		public void RemovePhysics() { }

		public void RestoreShift() { }

	}

	public class GrenadeHandsController : BaseGrenadeHandsController, IGrenadeController, IWeaponController, IHandsController, ICompassController
	{
		internal class DropBackpackOperation : GrenadeHandsOperation
		{
			internal enum ESourceState
			{
				IdleState = 0,
				PlantTripwireState = 1,
			}

			private Callback _callback; //Field offset: 0x30
			private ESourceState _sourceOperation; //Field offset: 0x38

			public DropBackpackOperation(GrenadeHandsController controller) { }

			public virtual void OnBackpackDrop() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Setup(ESourceState sourceState) { }

			public override void Start(Item item, Callback callback) { }

		}

		internal abstract class GrenadeHandsOperation : GrenadeOperation
		{

			protected GrenadeHandsOperation(GrenadeHandsController controller) { }

			public override bool CanChangeFireMode(EFireMode fireMode) { }

			public override void ChangeFireMode(EFireMode fireMode) { }

			public override void ExamineWeapon() { }

			public override void HandleAltFireInput() { }

			public override void HandleFireInput() { }

			public override void HighThrow() { }

			public override void LowThrow() { }

			public override void PlantTripwire() { }

			public override void PullRingForHighThrow() { }

			public override void PullRingForLowThrow() { }

			public override void SetGrenadeCompassState(bool active) { }

			public override void SetInventoryOpened(bool opened) { }

		}

		internal class HighThrowOperation : GrenadeHandsOperation
		{
			internal enum EThrowState
			{
				None = 0,
				Idling = 1,
				Throwing = 2,
				Threw = 3,
			}

			protected EThrowState _throwState; //Field offset: 0x30
			private Action _onControllerDestroy; //Field offset: 0x38

			public override bool WaitingHighThrow
			{
				 get { } //Length: 8
			}

			public HighThrowOperation(GrenadeHandsController controller) { }

			public virtual bool CanRemove() { }

			public virtual void FastForward() { }

			public override bool get_WaitingHighThrow() { }

			public virtual void HandleFireInput() { }

			public virtual void HideGrenade(Action onHidden, bool fastHide) { }

			public virtual void HighThrow() { }

			public virtual void OnDropFinishedAction() { }

			public virtual void OnDropGrenadeAction() { }

			public virtual void PutGrenadeBack() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected void SpawnGrenade(bool low = false) { }

			public void Start() { }

			protected override void StartThrowAnimation() { }

			protected void SwitchToIdle() { }

		}

		internal class Idling : GrenadeHandsOperation
		{
			private bool _idleAnimationComplete; //Field offset: 0x30

			public Idling(GrenadeHandsController controller) { }

			public virtual bool CanChangeFireMode(EFireMode fireMode) { }

			public virtual bool CanRemove() { }

			public virtual void ChangeFireMode(EFireMode fireMode) { }

			public virtual void ExamineWeapon() { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			public virtual void HandleAltFireInput() { }

			public virtual void HandleFireInput() { }

			public virtual void HideGrenade(Action onHidden, bool fastHide) { }

			public virtual void HighThrow() { }

			public virtual void LowThrow() { }

			public virtual void OnEnd() { }

			public virtual void OnIdleStartAction() { }

			public virtual void PullRingForHighThrow() { }

			public virtual void PullRingForLowThrow() { }

			public virtual void SetGrenadeCompassState(bool active) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public virtual void ShowGesture(EInteraction gesture) { }

			public void Start() { }

		}

		internal sealed class LowThrowOperation : HighThrowOperation
		{

			public virtual bool WaitingHighThrow
			{
				 get { } //Length: 3
			}

			public bool WaitingLowThrow
			{
				 get { } //Length: 8
			}

			public LowThrowOperation(GrenadeHandsController controller) { }

			public virtual bool get_WaitingHighThrow() { }

			public bool get_WaitingLowThrow() { }

			public virtual void HandleAltFireInput() { }

			public virtual void HighThrow() { }

			public virtual void LowThrow() { }

			public virtual void OnDropGrenadeAction() { }

			protected virtual void StartThrowAnimation() { }

		}

		internal sealed class PlantTripwireOperation : GrenadeHandsOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass13_0
			{
				public Player player; //Field offset: 0x10

				public <>c__DisplayClass13_0() { }

				internal void <OnDropFinishedAction>b__0(IResult result) { }

			}

			internal enum EPlantOperationState
			{
				None = 0,
				StateIn = 1,
				Idling = 2,
				Planting = 3,
				Planted = 4,
			}

			[CompilerGenerated]
			private EPlantOperationState <PlantOperationState>k__BackingField; //Field offset: 0x30
			private Action _onControllerDestroy; //Field offset: 0x38
			private PlantingKit _plantingKit; //Field offset: 0x40

			private EPlantOperationState PlantOperationState
			{
				[CompilerGenerated]
				private get { } //Length: 4
				[CompilerGenerated]
				private set { } //Length: 4
			}

			private ETripwirePlanState TripwirePlanningState
			{
				private get { } //Length: 53
			}

			public PlantTripwireOperation(GrenadeHandsController controller) { }

			public virtual bool CanChangeFireMode(EFireMode fireMode) { }

			public virtual bool CanRemove() { }

			public virtual void ChangeFireMode(EFireMode fireMode) { }

			public virtual void ExamineWeapon() { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			public virtual void FastForward() { }

			[CompilerGenerated]
			private EPlantOperationState get_PlantOperationState() { }

			private ETripwirePlanState get_TripwirePlanningState() { }

			public virtual void HandleAltFireInput() { }

			public virtual void HandleFireInput() { }

			public virtual void HideGrenade(Action onHidden, bool fastHide) { }

			public virtual void OnDropFinishedAction() { }

			public virtual void OnEnd() { }

			public virtual void OnIdleStartAction() { }

			public virtual void PlantTripwire() { }

			public virtual void PutGrenadeBack() { }

			public virtual void Reset() { }

			[CompilerGenerated]
			private void set_PlantOperationState(EPlantOperationState value) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public virtual void ShowGesture(EInteraction gesture) { }

			public void Start() { }

			private void SwitchToIdle() { }

		}

		internal class Remove : GrenadeHandsOperation
		{
			private Action _callback; //Field offset: 0x30

			public Remove(GrenadeHandsController controller) { }

			public virtual void FastForward() { }

			public virtual void HideGrenade(Action onHidden, bool fastHide) { }

			public virtual void OnHideCompleteActionAction() { }

			public virtual void Reset() { }

			public void Start(Action callback) { }

		}

		internal sealed class ServerDropBackpackOperation : DropBackpackOperation
		{
			private const float BACKPACK_DROP_EVENT_TIME = 0.25; //Field offset: 0x0
			private float _updateTime; //Field offset: 0x40
			private bool _backpackDropedEventFired; //Field offset: 0x44

			public ServerDropBackpackOperation(GrenadeHandsController controller) { }

			public virtual void FastForward() { }

			public virtual void Start(Item item, Callback callback) { }

			public virtual void Update(float deltaTime) { }

		}

		private class SpawnOperation : GrenadeHandsOperation
		{
			private Action _callback; //Field offset: 0x30
			private Action _onHideCallback; //Field offset: 0x38

			public SpawnOperation(GrenadeHandsController controller) { }

			public virtual void FastForward() { }

			public virtual void HideGrenade(Action onHidden, bool fastHide) { }

			public virtual void OnDrawCompleteAction() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void Start(Action callback) { }

		}

		private bool _isInventoryOpened; //Field offset: 0xE8
		private Callback _onUsedCallback; //Field offset: 0xF0
		[CompilerGenerated]
		private EFireMode <CurrentFireMode>k__BackingField; //Field offset: 0xF8

		public override EFireMode CurrentFireMode
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public GrenadeHandsOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public override ThrowWeap Item
		{
			 get { } //Length: 7
		}

		public override bool WaitingForHighThrow
		{
			 get { } //Length: 134
		}

		public override bool WaitingForLowThrow
		{
			 get { } //Length: 99
		}

		public GrenadeHandsController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_0() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_1() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_2() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_3() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_4() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_5() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__42_6() { }

		public override bool CanChangeFireMode(EFireMode fireMode) { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanRemove() { }

		public override bool CanThrow() { }

		public override void ChangeFireMode(EFireMode fireMode) { }

		internal static T CreateController(Player player, ThrowWeap item) { }

		internal static Task CreateControllerAsync(Player player, ThrowWeap item) { }

		protected override void DiscardThrow() { }

		public override void ExamineWeapon() { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		[CompilerGenerated]
		public override EFireMode get_CurrentFireMode() { }

		public GrenadeHandsOperation get_CurrentOperation() { }

		public override ThrowWeap get_Item() { }

		public override bool get_WaitingForHighThrow() { }

		public override bool get_WaitingForLowThrow() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		public override void HandleAltFireInput() { }

		public override void HandleFireInput() { }

		public override void HighThrow() { }

		public virtual bool IsInventoryOpen() { }

		public override void LowThrow() { }

		public override void PlantTripwire() { }

		public override void PullRingForHighThrow() { }

		public override void PullRingForLowThrow() { }

		[CompilerGenerated]
		protected void set_CurrentFireMode(EFireMode value) { }

		public virtual void SetCompassState(bool active) { }

		public void SetFireModeVisual(EFireMode fireMode) { }

		public virtual void SetInventoryOpened(bool opened) { }

		public override void SetOnUsedCallback(Callback callback) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	public abstract class GrenadeOperation`1 : ObjectInHandsOperation, IGrenadeOperation
	{
		protected readonly TBaseGrenadeController Controller; //Field offset: 0x0

		protected GrenadeOperation`1(TBaseGrenadeController controller) { }

		public override bool CanRemove() { }

		public override void Execute(IInventoryOperation operation, Callback callback) { }

		public override void FastForward() { }

		public override void HideGrenade(Action onHidden, bool fastHide) { }

		public override void OnBackpackDrop() { }

		public override void OnDrawCompleteAction() { }

		public override void OnDropFinishedAction() { }

		public override void OnDropGrenadeAction() { }

		public override void OnHideCompleteActionAction() { }

		public override void OnIdleStartAction() { }

		public override void PutGrenadeBack() { }

		public override void ShowGesture(EInteraction gesture) { }

		public override void StartCountdown() { }

	}

	internal sealed class GrenadeThrowResult : IOperationResult, IRollable
	{
		private readonly DiscardResult _discardResult; //Field offset: 0x10
		private readonly ThrowWeap _grenade; //Field offset: 0x18

		public GrenadeThrowResult(DiscardResult discardResult, ThrowWeap grenade) { }

		public override bool CanExecute(ItemController itemController) { }

		public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

		public override void RollBack() { }

	}

	public interface IBaseKnifeOperation
	{

		public void Execute(TInventoryOperation operation, Callback callback) { }

		public void FastForward() { }

		public void HideWeapon(Action onHidden, bool fastDrop) { }

		public void HideWeaponComplete() { }

		public void OnBackpackDrop() { }

		public void OnFire() { }

		public void OnFireEnd() { }

		public void OnIdleStart() { }

		public void WeaponAppeared() { }

	}

	public interface IBaseUsableItemOperation
	{

		public void ExamineWeapon() { }

		public void Execute(IInventoryOperation operation, Callback callback) { }

		public void FastForward() { }

		public void HideWeapon(Action onHidden, bool fastDrop) { }

		public void HideWeaponComplete() { }

		public void OnAimingDisabled() { }

		public void OnBackpackDrop() { }

		public void OnIdleStart() { }

		public void SetAiming(bool isAiming) { }

		public void SetInventoryOpened(bool opened) { }

		public void WeaponAppeared() { }

	}

	internal interface IGrenadeOperation
	{

		public bool CanRemove() { }

		public void Execute(IInventoryOperation operation, Callback callback) { }

		public void FastForward() { }

		public void HideGrenade(Action onHidden, bool fastHide) { }

		public void OnBackpackDrop() { }

		public void OnDrawCompleteAction() { }

		public void OnDropFinishedAction() { }

		public void OnDropGrenadeAction() { }

		public void OnHideCompleteActionAction() { }

		public void OnIdleStartAction() { }

		public void PutGrenadeBack() { }

		public void ShowGesture(EInteraction gesture) { }

		public void StartCountdown() { }

	}

	public abstract class InventoryOperation : IDisposable
	{
		internal enum EInternalState
		{
			Creating = 0,
			Executed = 1,
			Confirmed = 2,
			Disposed = 3,
		}

		[CompilerGenerated]
		private Player <Player>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private EInternalState <State>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private CommandStatus <Status>k__BackingField; //Field offset: 0x1C
		[CompilerGenerated]
		private Item <Item>k__BackingField; //Field offset: 0x20

		private bool Disposed
		{
			private get { } //Length: 8
		}

		internal Item Item
		{
			[CompilerGenerated]
			internal get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected private Player Player
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected private EInternalState State
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		protected CommandStatus Status
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		protected InventoryOperation(Player player, Item item) { }

		public void Confirm(bool succeed = true) { }

		public override void Dispose() { }

		public void Execute() { }

		protected virtual void Finalize() { }

		private bool get_Disposed() { }

		[CompilerGenerated]
		internal Item get_Item() { }

		[CompilerGenerated]
		protected Player get_Player() { }

		[CompilerGenerated]
		protected EInternalState get_State() { }

		[CompilerGenerated]
		protected CommandStatus get_Status() { }

		protected abstract void OnConfirm(bool succeed) { }

		protected abstract void OnExecute() { }

		[CompilerGenerated]
		private void set_Item(Item value) { }

		[CompilerGenerated]
		private void set_Player(Player value) { }

		[CompilerGenerated]
		private void set_State(EInternalState value) { }

		[CompilerGenerated]
		protected void set_Status(CommandStatus value) { }

	}

	private interface IQuickUsOperation
	{

		public void HideController(Action onHidden, bool fastHide) { }

		public void OnDrawCompleteAction() { }

		public void OnHideCompleteActionAction() { }

		public void OnUseAction() { }

	}

	internal sealed class ItemComponentNotFoundError : Error
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly Type _componentType; //Field offset: 0x18

		public ItemComponentNotFoundError(Item item, Type componentType) { }

		public virtual string ToString() { }

	}

	internal abstract class ItemHandsController : AbstractHandsController, IHandsController
	{
		[CompilerGenerated]
		private sealed class <>c__40`1
		{
			public static readonly <>c__40 <>9; //Field offset: 0x0
			public static ItemObjectFactoryDelegate <>9__40_0; //Field offset: 0x0

			private static <>c__40`1() { }

			public <>c__40`1() { }

			internal GameObject <CreateItemHandsController>b__40_0(Item item1, Player player1) { }

		}

		[CompilerGenerated]
		private sealed class <>c__43`1
		{
			public static readonly <>c__43 <>9; //Field offset: 0x0
			public static ItemObjectAsyncFactoryDelegate <>9__43_0; //Field offset: 0x0

			private static <>c__43`1() { }

			public <>c__43`1() { }

			internal Task <CreateItemHandsControllerAsync>b__43_0(Item item1, Player player1) { }

		}

		[CompilerGenerated]
		private struct <CreateItemHandsControllerAsync>d__41`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public ItemObjectAsyncFactoryDelegate itemObjectAsyncFactoryDelegate; //Field offset: 0x0
			public Item item; //Field offset: 0x0
			private T <controller>5__2; //Field offset: 0x0
			private T <>7__wrap2; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal class HandsControllerLogger : AbstractLogger
		{
			private readonly string _distinctId; //Field offset: 0x48

			public HandsControllerLogger(ItemHandsController controller) { }

			[Conditional("UNITY_EDITOR")]
			public void TraceMethodCall() { }

			[Conditional("UNITY_EDITOR")]
			public void TraceMethodCall(string argName, T argument1) { }

			public void TraceStateChange(ObjectInHandsOperation currentOperation, ObjectInHandsOperation nextOperation) { }

		}

		public sealed class ItemObjectAsyncFactoryDelegate : MulticastDelegate
		{

			public ItemObjectAsyncFactoryDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(Item item, Player player, AsyncCallback callback, object object) { }

			public override Task EndInvoke(IAsyncResult result) { }

			public override Task Invoke(Item item, Player player) { }

		}

		public sealed class ItemObjectFactoryDelegate : MulticastDelegate
		{

			public ItemObjectFactoryDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(Item item, Player player, AsyncCallback callback, object object) { }

			public override GameObject EndInvoke(IAsyncResult result) { }

			public override GameObject Invoke(Item item, Player player) { }

		}

		internal sealed class OperationFactoryDelegate : MulticastDelegate
		{

			public OperationFactoryDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			public override ObjectInHandsOperation EndInvoke(IAsyncResult result) { }

			public override ObjectInHandsOperation Invoke() { }

		}

		protected FirearmsAnimator _objectInHandsAnimator; //Field offset: 0x50
		private readonly Dictionary _internalOperations; //Field offset: 0x58
		protected GameObject _controllerObject; //Field offset: 0x60
		protected TransformLinks _handsHierarchy; //Field offset: 0x68
		private Item _item; //Field offset: 0x70
		private Dictionary _operationFactory; //Field offset: 0x78
		protected private Player _player; //Field offset: 0x80
		[CompilerGenerated]
		private readonly BindableState <CompassState>k__BackingField; //Field offset: 0x88
		protected BindableState RadioTransmitterState; //Field offset: 0x90
		protected HandsControllerLogger Logger; //Field offset: 0x98
		[CompilerGenerated]
		private ObjectInHandsOperation <CurrentHandsOperation>k__BackingField; //Field offset: 0xA0

		public virtual float AimingSensitivity
		{
			 get { } //Length: 52
		}

		public override BindableState CompassState
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public virtual GameObject ControllerGameObject
		{
			 get { } //Length: 5
		}

		public bool CurrentCompassState
		{
			 get { } //Length: 60
		}

		public private ObjectInHandsOperation CurrentHandsOperation
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public string CurrentHandsOperationName
		{
			 get { } //Length: 244
		}

		public bool CurrentRadioTransmitterState
		{
			 get { } //Length: 45
		}

		private override Item EFT.IHandsController.Item
		{
			private get { } //Length: 5
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 5
		}

		public virtual TransformLinks HandsHierarchy
		{
			 get { } //Length: 5
		}

		public bool SuitableForHandInput
		{
			 get { } //Length: 32
		}

		protected ItemHandsController() { }

		public void ApplyCompassPacket(CompassPacket packet) { }

		public virtual void BallisticUpdate(float deltaTime) { }

		public virtual void BlindFire(int b) { }

		protected override bool CanChangeCompassState(bool newState) { }

		protected private void ClearPreWarmOperationsDict() { }

		protected override void CompassStateHandler(bool isActive) { }

		internal static T CreateItemHandsController(Player player, Item item) { }

		internal static T CreateItemHandsController(Player player, Item item, ItemObjectFactoryDelegate itemObjectFactoryDelegate) { }

		[AsyncStateMachine(typeof(<CreateItemHandsControllerAsync>d__41`1))]
		internal static Task CreateItemHandsControllerAsync(Player player, Item item, ItemObjectAsyncFactoryDelegate itemObjectAsyncFactoryDelegate) { }

		internal static Task CreateItemHandsControllerAsync(Player player, Item item) { }

		public virtual void Destroy() { }

		private override Item EFT.IHandsController.get_Item() { }

		public virtual void EmitEvents() { }

		public virtual float get_AimingSensitivity() { }

		[CompilerGenerated]
		public override BindableState get_CompassState() { }

		public virtual GameObject get_ControllerGameObject() { }

		public bool get_CurrentCompassState() { }

		[CompilerGenerated]
		public ObjectInHandsOperation get_CurrentHandsOperation() { }

		public string get_CurrentHandsOperationName() { }

		public bool get_CurrentRadioTransmitterState() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public virtual TransformLinks get_HandsHierarchy() { }

		public bool get_SuitableForHandInput() { }

		protected virtual Item GetItem() { }

		protected abstract Dictionary GetOperationFactoryDelegates() { }

		protected private TCreateOperation InitiateOperation() { }

		public virtual bool IsPlacingBeacon() { }

		public virtual void ManualUpdate(float deltaTime) { }

		protected override void OnCanUsePropChanged(bool canUse) { }

		[CompilerGenerated]
		private void set_CurrentHandsOperation(ObjectInHandsOperation value) { }

		public override void SetCompassState(bool active) { }

		protected void SetPropVisibility(bool isVisible) { }

		private static void Setup(T controller, Player player, Item item) { }

		protected void SetupProp() { }

		private static void Subscribe(T controller, Player player) { }

		public override void ToggleCompassState() { }

		public virtual string ToString() { }

		public void TranslateAnimatorParameter(int actionIndex) { }

		private void Unsubscribe() { }

	}

	internal sealed class ItemParentIsWrongError : Error
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly ItemAddress _itemAddress; //Field offset: 0x18

		public ItemParentIsWrongError(Item item, ItemAddress itemAddress) { }

		public virtual string ToString() { }

	}

	public class KnifeController : BaseKnifeController, IKnifeController, IWeaponController, IHandsController, ICompassController
	{
		internal class DropBackpackOperation : KnifeOperation
		{
			private Callback _callback; //Field offset: 0x38

			public DropBackpackOperation(KnifeController controller) { }

			public virtual void OnBackpackDrop() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Item item, Callback callback) { }

		}

		internal class Idling : KnifeOperation
		{
			private const float IDLING_MAX_TIME = 300; //Field offset: 0x0
			private float _idlingTime; //Field offset: 0x38

			public Idling(KnifeController controller) { }

			public virtual bool CanRemove() { }

			public virtual void ExamineWeapon() { }

			public virtual void Execute(TInventoryOperation operation, Callback callback) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			public virtual bool MakeAlternativeKick() { }

			public virtual bool MakeKnifeKick() { }

			public virtual void OnEnd() { }

			public virtual void Reset() { }

			public virtual void SetInventoryOpened(bool opened) { }

			public virtual void SetKnifeCompassState(bool active) { }

			public void Start() { }

			public virtual void StopAlternativeKick() { }

			public virtual void StopKnifeKick() { }

			public virtual void Update(float deltaTime) { }

		}

		internal class Kick : KnifeOperation
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass14_0
			{
				public Kick <>4__this; //Field offset: 0x10
				public Action onHidden; //Field offset: 0x18
				public bool fastDrop; //Field offset: 0x20

				public <>c__DisplayClass14_0() { }

				internal void <HideWeapon>b__0() { }

			}

			private Action _plannedAction; //Field offset: 0x38
			private bool _brakeFlag; //Field offset: 0x40

			public Kick(KnifeController controller) { }

			public virtual void BrakeCombo() { }

			public virtual void ContinueCombo() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			public virtual void OnComboPlanning() { }

			public virtual void OnFire() { }

			public virtual void OnFireEnd() { }

			public virtual void OnIdleStart() { }

			public virtual void Reset() { }

			public void Start(EKickType eKickType) { }

			public virtual void StopAlternativeKick() { }

			public virtual void StopKnifeKick() { }

			private void SwitchToIdling() { }

			private void SwitchToPlannedState() { }

			public virtual void Update(float deltaTime) { }

		}

		internal abstract class KnifeOperation : BaseKnifeOperation
		{
			protected readonly Player Player; //Field offset: 0x30

			public KnifeOperation(KnifeController controller) { }

			public override void BrakeCombo() { }

			public override bool CanRemove() { }

			public override void ContinueCombo() { }

			public override void ExamineWeapon() { }

			public override bool MakeAlternativeKick() { }

			public override bool MakeKnifeKick() { }

			public override void OnComboPlanning() { }

			public override void SetInventoryOpened(bool opened) { }

			public override void SetKnifeCompassState(bool active) { }

			public override void StopAlternativeKick() { }

			public override void StopKnifeKick() { }

		}

		private class Remove : KnifeOperation
		{
			private Action _onHiddenCallback; //Field offset: 0x38

			public Remove(KnifeController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			public virtual void HideWeaponComplete() { }

			public virtual void Reset() { }

			public void Start(Action onHidden, bool fastDrop) { }

		}

		internal sealed class ServerDropBackpackOperation : DropBackpackOperation
		{
			private const float BACKPACK_DROP_EVENT_TIME = 0.25; //Field offset: 0x0
			private float _updateTime; //Field offset: 0x40
			private bool _backpackDropedEventFired; //Field offset: 0x44

			public ServerDropBackpackOperation(KnifeController controller) { }

			public virtual void FastForward() { }

			public virtual void Start(Item item, Callback callback) { }

			public virtual void Update(float deltaTime) { }

		}

		internal class SpawnOperation : KnifeOperation
		{
			private Action _hideAction; //Field offset: 0x38
			private Action _onWeaponAppear; //Field offset: 0x40
			private bool _fastDrop; //Field offset: 0x48

			public SpawnOperation(KnifeController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			public virtual void Reset() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void Start(Action callback) { }

			public virtual void WeaponAppeared() { }

		}

		protected bool _isInventoryOpened; //Field offset: 0x108
		[CompilerGenerated]
		private Action <ComboPlanning>k__BackingField; //Field offset: 0x110
		[CompilerGenerated]
		private Action <OnAttackEnd>k__BackingField; //Field offset: 0x118

		public override Action ComboPlanning
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected KnifeOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public override KnifeComponent Knife
		{
			 get { } //Length: 94
		}

		public override Action OnAttackEnd
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public KnifeController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__33_0() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__33_1() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__33_2() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__33_3() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__33_4() { }

		public override void BrakeCombo() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanRemove() { }

		public override void ContinueCombo() { }

		internal static T CreateController(Player player, KnifeComponent knife) { }

		internal static Task CreateControllerAsync(Player player, KnifeComponent knife) { }

		public override void ExamineWeapon() { }

		[CompilerGenerated]
		public override Action get_ComboPlanning() { }

		protected KnifeOperation get_CurrentOperation() { }

		public override KnifeComponent get_Knife() { }

		[CompilerGenerated]
		public override Action get_OnAttackEnd() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		public virtual bool IsInventoryOpen() { }

		public override bool MakeAlternativeKick() { }

		public override bool MakeKnifeKick() { }

		protected virtual void OnComboPlanning() { }

		public virtual void OnFireEnd() { }

		[CompilerGenerated]
		public override void set_ComboPlanning(Action value) { }

		[CompilerGenerated]
		public override void set_OnAttackEnd(Action value) { }

		public override void SetBotParameters() { }

		public virtual void SetCompassState(bool active) { }

		public virtual void SetInventoryOpened(bool opened) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	internal struct KnifeRaycastHit
	{
		public Collider collider; //Field offset: 0x0
		public Vector3 point; //Field offset: 0x8
		public Vector3 normal; //Field offset: 0x14

		public KnifeRaycastHit(RaycastHit hit) { }

	}

	internal enum LeanType
	{
		NormalLean = 0,
		SlowLean = 1,
	}

	public class MedsController : ItemHandsController, IMedsController, IQuickUseItem, IHandsController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0`1
		{
			public T controller; //Field offset: 0x0

			public <>c__DisplayClass36_0`1() { }

			internal void <Setup>b__0() { }

			internal void <Setup>b__2() { }

			internal void <Setup>g__OnOutUseLocal|1() { }

		}

		[CompilerGenerated]
		private struct <CreateControllerAsync>d__35`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public Item item; //Field offset: 0x0
			public int animationVariant; //Field offset: 0x0
			public OneAndList bodyParts; //Field offset: 0x0
			public float amount; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <DropWithDelay>d__44 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public MedsController <>4__this; //Field offset: 0x20
			public Action callback; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <RemoveWithDelay>d__25 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public MedsController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private sealed class MedsInHandsOperation : ObjectInHandsOperation
		{
			private readonly MedsController _controller; //Field offset: 0x28
			private Action _onHiddenCallback; //Field offset: 0x30
			private Callback _onUsedCallback; //Field offset: 0x38
			private Queue _bodyPartQueue; //Field offset: 0x40
			private float _amount; //Field offset: 0x48
			private int _roundRobin; //Field offset: 0x4C
			private bool _finished; //Field offset: 0x50

			public MedsInHandsOperation(MedsController controller) { }

			public void ClearQueue() { }

			public void FastForward() { }

			private void Finish() { }

			protected virtual double GetMaxOperationDuration() { }

			public Callback GetOnUsedCallback() { }

			private void GoNextBodyPart() { }

			private bool HaveToContinue() { }

			public void HideWeapon(Action onHiddenCallback) { }

			public void HideWeaponComplete() { }

			private bool NeedDequeue() { }

			private void OnEffectRemoved(IHealthEffect effect) { }

			private void OnOutUse() { }

			private void OnRemoveItem(RemoveItemEventArgs args) { }

			public void Remove() { }

			public virtual void Reset() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void SetOnUsedCallback(Callback callback) { }

			private void SetRandomVariant() { }

			public void Start(OneAndList bodyParts, float amount, Action callback) { }

		}

		private float _amount; //Field offset: 0xA8
		public int _animationVariant; //Field offset: 0xAC
		private OneAndList _bodyParts; //Field offset: 0xB0
		private FirearmsAnimator _firearmsAnimator; //Field offset: 0xC0
		[CompilerGenerated]
		private Action OnOutUseEvent; //Field offset: 0xC8
		[CompilerGenerated]
		private bool <FailedToApply>k__BackingField; //Field offset: 0xD0

		public event Action OnOutUseEvent
		{
			[CompilerGenerated]
			 add { } //Length: 251
			[CompilerGenerated]
			 remove { } //Length: 251
		}

		public virtual int AnimationVariant
		{
			 get { } //Length: 7
		}

		private MedsInHandsOperation CurrentOperation
		{
			private get { } //Length: 76
		}

		public private bool FailedToApply
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public virtual string LoggerDistinctId
		{
			 get { } //Length: 194
		}

		public MedsController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__49_0() { }

		[CompilerGenerated]
		public void add_OnOutUseEvent(Action value) { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		public virtual bool CanRemove() { }

		public override void ClearQueue() { }

		internal static T CreateController(Player player, Item item, OneAndList bodyParts, float amount, int animationVariant) { }

		[AsyncStateMachine(typeof(<CreateControllerAsync>d__35`1))]
		internal static Task CreateControllerAsync(Player player, Item item, OneAndList bodyParts, float amount, int animationVariant) { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop = false, Item nextControllerItem = null) { }

		[AsyncStateMachine(typeof(<DropWithDelay>d__44))]
		private Task DropWithDelay(Action callback) { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		public virtual int get_AnimationVariant() { }

		private MedsInHandsOperation get_CurrentOperation() { }

		[CompilerGenerated]
		public bool get_FailedToApply() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public virtual string get_LoggerDistinctId() { }

		public override Callback GetOnUsedCallback() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		protected virtual void IEventsConsumerOnThirdAction(int IntParam) { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual void Loot(bool p) { }

		public virtual void ManualUpdate(float deltaTime) { }

		protected virtual void OnOutUse() { }

		private static void OnOutUse(MedsController controller) { }

		public virtual void OnPlayerDead() { }

		public virtual void Pickup(bool p) { }

		public override void Remove() { }

		[CompilerGenerated]
		public void remove_OnOutUseEvent(Action value) { }

		[AsyncStateMachine(typeof(<RemoveWithDelay>d__25))]
		private Task RemoveWithDelay() { }

		[CompilerGenerated]
		private void set_FailedToApply(bool value) { }

		public override void SetOnUsedCallback(Callback callback) { }

		private static void SetRandomVariant(MedsController controller) { }

		private static void Setup(T controller, Player player, Item item, int animationVariant) { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	internal abstract class ObjectInHandsOperation
	{
		internal class HandsControllerOperationLogger : AbstractLogger
		{
			private AbstractHandsController _handsController; //Field offset: 0x48
			private readonly ObjectInHandsOperation _objectInHandsOperation; //Field offset: 0x50

			public HandsControllerOperationLogger(ObjectInHandsOperation objectInHandsOperation) { }

			public void OperationStart() { }

			public void SetHandsController(AbstractHandsController controller) { }

			[Conditional("UNITY_EDITOR")]
			public void TraceMethodCall() { }

			public void TraceProhibitedCall() { }

		}

		private readonly HandsControllerOperationLogger Logger; //Field offset: 0x10
		[CompilerGenerated]
		private EOperationState <State>k__BackingField; //Field offset: 0x18
		protected double _operationStartTime; //Field offset: 0x20

		public override EOperationState State
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		protected ObjectInHandsOperation(AbstractHandsController handsController) { }

		[CompilerGenerated]
		public override EOperationState get_State() { }

		protected override double GetMaxOperationDuration() { }

		public bool IsOutdate() { }

		[Conditional("UNITY_EDITOR")]
		protected void LogCall() { }

		public override void OnEnd() { }

		protected void ProhibitedCall() { }

		public override void Reset() { }

		[CompilerGenerated]
		protected override void set_State(EOperationState value) { }

		protected override void SetLeftStanceAnimOnStartOperation() { }

		protected void Start() { }

		public override void Update(float deltaTime) { }

		public void UpdateLoggerController(AbstractHandsController handsController) { }

	}

	private abstract class PlayerInventoryController : InventoryController, IAntiRMTItemController
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__46_3; //Field offset: 0x8
			public static Func <>9__48_1; //Field offset: 0x10
			public static Func <>9__48_2; //Field offset: 0x18
			public static Func <>9__48_3; //Field offset: 0x20
			public static Func <>9__64_0; //Field offset: 0x28

			private static <>c() { }

			public <>c() { }

			internal IEnumerable <GetAnimatedItem>b__64_0(IContainer x) { }

			internal string <GetItemsOverDiscardLimit>b__46_3(Item childItem) { }

			internal bool <LoadMultiBarrelWeapon>b__48_1(GridItemAddress g) { }

			internal int <LoadMultiBarrelWeapon>b__48_2(GridItemAddress g) { }

			internal bool <LoadMultiBarrelWeapon>b__48_3(GridItemAddress x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0
		{
			public PlayerInventoryController <>4__this; //Field offset: 0x10
			public IEnumerable destroyedItems; //Field offset: 0x18

			public <>c__DisplayClass38_0() { }

			internal void <SubtractFromDiscardLimits>g__Subtract|0(Item itemToSubtract) { }

			internal bool <SubtractFromDiscardLimits>g__WasAffected|1(Item localItem, out int preservedNumber) { }

			internal bool <SubtractFromDiscardLimits>g__WasNotDestroyed|2(Item localItem) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass40_0
		{
			public IEnumerable destroyedItems; //Field offset: 0x10
			public PlayerInventoryController <>4__this; //Field offset: 0x18

			public <>c__DisplayClass40_0() { }

			internal void <AddDiscardLimits>g__AddToLimits|0(Item itemToAdd) { }

			internal bool <AddDiscardLimits>g__WasNotDestroyed|1(Item localItem) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			private sealed class <<GetItemsOverDiscardLimit>g__GetItemsInStableOrder|0>d : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
			{
				private int <>1__state; //Field offset: 0x10
				private Item <>2__current; //Field offset: 0x18
				private int <>l__initialThreadId; //Field offset: 0x20
				private Item parentItem; //Field offset: 0x28
				public Item <>3__parentItem; //Field offset: 0x30
				public <>c__DisplayClass46_0 <>4__this; //Field offset: 0x38
				private IEnumerator <>7__wrap1; //Field offset: 0x40
				private IEnumerator <>7__wrap2; //Field offset: 0x48
				private IEnumerator <>7__wrap3; //Field offset: 0x50

				private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
				public <<GetItemsOverDiscardLimit>g__GetItemsInStableOrder|0>d(int <>1__state) { }

				private void <>m__Finally1() { }

				private void <>m__Finally2() { }

				private void <>m__Finally3() { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

				[DebuggerHidden]
				private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public PlayerInventoryController <>4__this; //Field offset: 0x10
			public bool ignoreRestrictions; //Field offset: 0x18

			public <>c__DisplayClass46_0() { }

			[IteratorStateMachine(typeof(<<GetItemsOverDiscardLimit>g__GetItemsInStableOrder|0>d))]
			internal IEnumerable <GetItemsOverDiscardLimit>g__GetItemsInStableOrder|0(Item parentItem) { }

			internal bool <GetItemsOverDiscardLimit>g__IsItemAllowed|2(ContainerCollection localItem) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass47_0
		{
			public Magazine magazine; //Field offset: 0x10
			public PlayerInventoryController <>4__this; //Field offset: 0x18
			public bool notify; //Field offset: 0x20
			public float speed; //Field offset: 0x24

			public <>c__DisplayClass47_0() { }

			internal void <InventoryCheckMagazine>b__0(IResult result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass48_0
		{
			public Ammo containedAmmo; //Field offset: 0x10
			public TaskCompletionSource taskSource; //Field offset: 0x18

			public <>c__DisplayClass48_0() { }

			internal GridItemAddress <LoadMultiBarrelWeapon>b__0(Grid grid) { }

			internal void <LoadMultiBarrelWeapon>b__4(IResult result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			public TaskCompletionSource taskSource; //Field offset: 0x10

			public <>c__DisplayClass49_0() { }

			internal void <LoadWeaponWithAmmo>b__0(IResult result) { }

			internal void <LoadWeaponWithAmmo>b__1(IResult result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass61_0
		{
			public Callback callback; //Field offset: 0x10

			public <>c__DisplayClass61_0() { }

			internal void <TrySetInHands>b__0(IResult result) { }

		}

		[CompilerGenerated]
		private sealed class <GetItemsOverDiscardLimit>d__46 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private ItemsCount <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x28
			public PlayerInventoryController <>4__this; //Field offset: 0x30
			private Item item; //Field offset: 0x38
			public Item <>3__item; //Field offset: 0x40
			private <>c__DisplayClass46_0 <>8__1; //Field offset: 0x48
			private IEnumerator <>7__wrap1; //Field offset: 0x50

			private override ItemsCount System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemsCount>.Current
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
			public <GetItemsOverDiscardLimit>d__46(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ItemsCount>.GetEnumerator() { }

			[DebuggerHidden]
			private override ItemsCount System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemsCount>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private struct <LoadMagazine>d__51 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public int loadCount; //Field offset: 0x20
			public PlayerInventoryController <>4__this; //Field offset: 0x28
			public Magazine magazine; //Field offset: 0x30
			public bool ignoreRestrictions; //Field offset: 0x38
			public Ammo sourceAmmo; //Field offset: 0x40
			private float <speed>5__2; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <LoadMultiBarrelWeapon>d__48 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PlayerInventoryController <>4__this; //Field offset: 0x20
			public Weapon weapon; //Field offset: 0x28
			public Ammo ammo; //Field offset: 0x30
			public int ammoCount; //Field offset: 0x38
			public bool playSound; //Field offset: 0x3C
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <LoadWeaponWithAmmo>d__49 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PlayerInventoryController <>4__this; //Field offset: 0x20
			public Weapon weapon; //Field offset: 0x28
			public Ammo ammo; //Field offset: 0x30
			public int ammoCount; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <UnloadMagazine>d__52 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PlayerInventoryController <>4__this; //Field offset: 0x20
			public Magazine magazine; //Field offset: 0x28
			private float <speed>5__2; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <WaitForProcess>d__53 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PlayerInventoryController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private sealed class CheckMagazineProcess
		{
			[CompilerGenerated]
			private sealed class <Co_Iteration>d__8 : IEnumerator, IEnumerator, IDisposable
			{
				private int <>1__state; //Field offset: 0x10
				private object <>2__current; //Field offset: 0x18
				public CheckMagazineProcess <>4__this; //Field offset: 0x20

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
				public <Co_Iteration>d__8(int <>1__state) { }

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

			private readonly Magazine _magazine; //Field offset: 0x10
			private readonly float _duration; //Field offset: 0x18
			private readonly Callback _callback; //Field offset: 0x20
			private bool _success; //Field offset: 0x28
			private Coroutine _process; //Field offset: 0x30

			public CheckMagazineProcess(Magazine magazine, float duration, Callback callback) { }

			[IteratorStateMachine(typeof(<Co_Iteration>d__8))]
			private IEnumerator Co_Iteration() { }

			public void Proceed() { }

			public void TryProceedForItem(Magazine magazine) { }

		}

		private sealed class LoadMagazineProcess : IMagazineLoadingProcess
		{
			[CompilerGenerated]
			private sealed class <>c__DisplayClass13_0
			{
				public TaskCompletionSource cancellationHandlerSource; //Field offset: 0x10

				public <>c__DisplayClass13_0() { }

				internal void <Start>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass18_0
			{
				public TaskCompletionSource executionSource; //Field offset: 0x10

				public <>c__DisplayClass18_0() { }

				internal void <LoadProcess>b__1(IResult res) { }

			}

			[CompilerGenerated]
			private struct <LoadProcess>d__18 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public LoadMagazineProcess <>4__this; //Field offset: 0x20
				private <>c__DisplayClass18_0 <>8__1; //Field offset: 0x28
				private Task <delay>5__2; //Field offset: 0x30
				private int <i>5__3; //Field offset: 0x38
				private TaskAwaiter <>u__1; //Field offset: 0x40
				private TaskAwaiter <>u__2; //Field offset: 0x48

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <Start>d__13 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public LoadMagazineProcess <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private readonly InventoryController _inventoryController; //Field offset: 0x10
			private readonly Magazine _magazine; //Field offset: 0x18
			private readonly Ammo _sourceAmmo; //Field offset: 0x20
			private readonly int _count; //Field offset: 0x28
			private readonly bool _elite; //Field offset: 0x2C
			private readonly float _loadOneAmmoSpeed; //Field offset: 0x30
			private readonly IItemOwner _magazineOwner; //Field offset: 0x38
			private readonly IItemOwner _sourceAmmoOwner; //Field offset: 0x40
			private CancellationTokenSource _process; //Field offset: 0x48
			private float _cooldown; //Field offset: 0x50

			private bool Cancelled
			{
				private get { } //Length: 27
			}

			public LoadMagazineProcess(InventoryController inventoryController, Magazine magazine, Ammo sourceAmmo, int count, bool elite, float loadOneAmmoSpeed) { }

			[CompilerGenerated]
			private Task <LoadProcess>g__CoolDown|18_0() { }

			private void Abort() { }

			private bool get_Cancelled() { }

			[AsyncStateMachine(typeof(<LoadProcess>d__18))]
			private Task LoadProcess() { }

			private void PlaySound() { }

			public override void Proceed(bool success = true) { }

			private void RaiseLoadEventArgs(CommandStatus status) { }

			private void RaiseRefreshItemsEvents(bool refreshIcon = false) { }

			[AsyncStateMachine(typeof(<Start>d__13))]
			public override Task Start() { }

			public override void TryProceedForItem(Item item) { }

		}

		private sealed class UnloadMagazineProcess : IMagazineLoadingProcess
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0
				public static Func <>9__12_0; //Field offset: 0x8

				private static <>c() { }

				public <>c() { }

				internal int <.ctor>b__12_0(Item item) { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass13_0
			{
				public TaskCompletionSource cancellationHandlerSource; //Field offset: 0x10

				public <>c__DisplayClass13_0() { }

				internal void <Start>b__0() { }

			}

			[CompilerGenerated]
			private sealed class <>c__DisplayClass18_0
			{
				public TaskCompletionSource executionSource; //Field offset: 0x10

				public <>c__DisplayClass18_0() { }

				internal void <UnloadProcess>b__1(IResult executeResult) { }

			}

			[CompilerGenerated]
			private struct <Start>d__13 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public UnloadMagazineProcess <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			[CompilerGenerated]
			private struct <UnloadProcess>d__18 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public UnloadMagazineProcess <>4__this; //Field offset: 0x20
				private <>c__DisplayClass18_0 <>8__1; //Field offset: 0x28
				private Task <delay>5__2; //Field offset: 0x30
				private ItemAddress <targetedAddress>5__3; //Field offset: 0x38
				private TaskAwaiter <>u__1; //Field offset: 0x40
				private TaskAwaiter <>u__2; //Field offset: 0x48

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			private readonly InventoryController _inventoryController; //Field offset: 0x10
			private readonly Magazine _magazine; //Field offset: 0x18
			private readonly bool _elite; //Field offset: 0x20
			private readonly float _loadOneAmmoSpeed; //Field offset: 0x24
			private readonly int _count; //Field offset: 0x28
			private float _cooldown; //Field offset: 0x2C
			private int _ammoLeft; //Field offset: 0x30
			private CancellationTokenSource _process; //Field offset: 0x38
			private Item _ammoInMag; //Field offset: 0x40
			private Item _targetAmmo; //Field offset: 0x48

			private bool Cancelled
			{
				private get { } //Length: 27
			}

			public UnloadMagazineProcess(InventoryController inventoryController, Magazine magazine, float loadOneAmmoSpeed, bool elite) { }

			[CompilerGenerated]
			private Task <UnloadProcess>g__CoolDown|18_0() { }

			private void Abort() { }

			private bool get_Cancelled() { }

			private void PlaySound() { }

			public override void Proceed(bool success) { }

			private void RaiseUnloadEventArgs(CommandStatus status) { }

			[AsyncStateMachine(typeof(<Start>d__13))]
			public override Task Start() { }

			public override void TryProceedForItem(Item item) { }

			[AsyncStateMachine(typeof(<UnloadProcess>d__18))]
			private Task UnloadProcess() { }

		}

		internal readonly Player Player; //Field offset: 0x170
		private IMagazineLoadingProcess _loadProcess; //Field offset: 0x178
		private CheckMagazineProcess _checkMagazineProcess; //Field offset: 0x180
		private bool _nextProcessLocked; //Field offset: 0x188
		private readonly Dictionary _discardLimitsCache; //Field offset: 0x190
		private readonly List _discardedItemsCache; //Field offset: 0x198
		[CompilerGenerated]
		private Dictionary <DiscardLimits>k__BackingField; //Field offset: 0x1A0
		[CompilerGenerated]
		private readonly Profile <Profile>k__BackingField; //Field offset: 0x1A8

		protected private Dictionary DiscardLimits
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected override bool HasDiscardLimits
		{
			 get { } //Length: 108
		}

		public virtual Item ItemInHands
		{
			 get { } //Length: 313
		}

		public virtual bool Locked
		{
			 get { } //Length: 36
			 set { } //Length: 151
		}

		protected virtual int MalfunctionOwnerRaidId
		{
			 get { } //Length: 32
		}

		public abstract IPlayerSearchController PlayerSearchController
		{
			 get { } //Length: 0
		}

		public Profile Profile
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public virtual ISearchController SearchController
		{
			 get { } //Length: 20
		}

		protected PlayerInventoryController(Player player, Profile profile, bool examined) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(Weapon weapon, Ammo ammo, int ammoCount, bool playSound) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__1(Weapon weapon, Ammo ammo, int ammoCount) { }

		[CompilerGenerated]
		private bool <GetAnimatedItem>b__64_1(Item x) { }

		[CompilerGenerated]
		internal static bool <GetItemsOverDiscardLimit>g__IsContainerAllowed|46_1(IContainer container) { }

		[CompilerGenerated]
		private bool <WaitForProcess>b__53_0() { }

		public override void AddDiscardLimits(Item rootItem, IEnumerable destroyedItems) { }

		internal virtual bool CanExecute(AbstractOperation operation) { }

		public virtual Option CheckItemAction(Item item, ItemAddress location) { }

		public virtual void CheckMagazineAmmoDepend(Magazine magazine, Action callback, bool useOperation, bool allowUncheck = false) { }

		internal abstract SearchContentOperation CreateSearchOperation(SearchableItem item) { }

		public virtual Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

		[CompilerGenerated]
		protected Dictionary get_DiscardLimits() { }

		protected override bool get_HasDiscardLimits() { }

		public virtual Item get_ItemInHands() { }

		public virtual bool get_Locked() { }

		protected virtual int get_MalfunctionOwnerRaidId() { }

		public abstract IPlayerSearchController get_PlayerSearchController() { }

		[CompilerGenerated]
		public Profile get_Profile() { }

		public virtual ISearchController get_SearchController() { }

		private Item GetAnimatedItem(Item item, ItemAddress from, ItemAddress to) { }

		[IteratorStateMachine(typeof(<GetItemsOverDiscardLimit>d__46))]
		public override IEnumerable GetItemsOverDiscardLimit(Item item) { }

		public override bool HasDiscardLimit(Item item, out int limit) { }

		private bool HasDiscardOverLimit(Item item, out ItemsCount overLimit) { }

		protected virtual void InProcess(ItemController executor, Item item, ItemAddress to, bool succeed, IInventoryOperation operation, Callback callback) { }

		public virtual void InventoryCheckMagazine(Magazine magazine, bool notify) { }

		private bool IsUndiscardable(Item item, bool ignoreRestrictions) { }

		[AsyncStateMachine(typeof(<LoadMagazine>d__51))]
		protected virtual Task LoadMagazine(Ammo sourceAmmo, Magazine magazine, int loadCount, bool ignoreRestrictions) { }

		[AsyncStateMachine(typeof(<LoadMultiBarrelWeapon>d__48))]
		public virtual Task LoadMultiBarrelWeapon(Weapon weapon, Ammo ammo, int ammoCount, bool playSound = true) { }

		[AsyncStateMachine(typeof(<LoadWeaponWithAmmo>d__49))]
		public virtual Task LoadWeaponWithAmmo(Weapon weapon, Ammo ammo, int ammoCount) { }

		protected override void LogDiscardLimitsChange(ItemTemplate template, int delta) { }

		protected virtual void OutProcess(ItemController executor, Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation, Callback callback) { }

		public virtual void PlantTripwire(ThrowWeap grenade, PlantingKit plantingKit, Vector3 fromPosition, Vector3 toPosition, Callback callback = null) { }

		public virtual void PlayTapeAudio(TapeItem tape, RecorderItem recorder) { }

		public override void ResetDiscardLimits() { }

		[CompilerGenerated]
		private void set_DiscardLimits(Dictionary value) { }

		public virtual void set_Locked(bool value) { }

		public void SetNextProcessLocked(bool status) { }

		public virtual void SetupItem(Item item, string zone, Vector3 position, Quaternion rotation, float setupTime, Callback callback = null) { }

		public virtual void StopProcesses() { }

		public virtual void StrictCheckMagazine(Magazine magazine, bool status, int skill = 0, bool notify = false, bool useOperation = true) { }

		public override void SubtractFromDiscardLimits(Item rootItem, IEnumerable destroyedItems) { }

		public virtual void ThrowItem(Item item, bool downDirection = false, Callback callback = null) { }

		protected virtual ToggleOperation ToggleItem(ToggleResult toggleResult) { }

		private void TryRemoveFromHands(Item item, ItemAddress from, ItemAddress to, IInventoryOperation abstractOperation, Callback callback) { }

		public virtual Task TryRunNetworkTransaction(OperationResult operationResult, Callback callback = null) { }

		private void TrySetInHands(Item item, ItemAddress to, IInventoryOperation operation, Callback callback) { }

		private void TryStopCheckProcess(Magazine magazine) { }

		private void TryStopLoadProcess(Item magazineOrAmmo) { }

		[AsyncStateMachine(typeof(<UnloadMagazine>d__52))]
		public virtual Task UnloadMagazine(Magazine magazine, bool equipmentBlocked) { }

		[AsyncStateMachine(typeof(<WaitForProcess>d__53))]
		private Task WaitForProcess() { }

	}

	internal class PlayerLogger : AbstractLogger
	{

		public PlayerLogger() { }

	}

	private abstract class PlayerOwnerInventoryController : PlayerInventoryController
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Callback <>9__17_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal void <StudyItem>b__17_0(IResult result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0`1
		{
			public Predicate predicate; //Field offset: 0x0
			public Predicate goDeeperPredicate; //Field offset: 0x0
			public PlayerOwnerInventoryController <>4__this; //Field offset: 0x0

			public <>c__DisplayClass1_0`1() { }

			internal bool <GetAcceptableItemsNonAlloc>g__CombinedGoDeeperPredicate|1(ContainerCollection container) { }

			internal bool <GetAcceptableItemsNonAlloc>g__CombinedPredicate|0(TItem item) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public TaskCompletionSource taskSource; //Field offset: 0x10
			public PlayerOwnerInventoryController <>4__this; //Field offset: 0x18

			public <>c__DisplayClass12_0() { }

			internal void <UseRecorder>b__1(Result result) { }

			internal void <UseRecorder>g__PressTapeHandler|0(TapeItem tapeInRecorder, bool result) { }

		}

		[CompilerGenerated]
		private struct <>c__DisplayClass14_0
		{
			public ECompletableType foundCompletableTypes; //Field offset: 0x0
			public CountersCollection counters; //Field offset: 0x8

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			private struct <<PlayTape>g__TryStudyItemAsync|0>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass16_0 <>4__this; //Field offset: 0x20
				private TaskAwaiter <>u__1; //Field offset: 0x28

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public Task previousTaskCompletion; //Field offset: 0x10
			public RecorderItem recorder; //Field offset: 0x18
			public PlayerOwnerInventoryController <>4__this; //Field offset: 0x20
			public TapeItem tape; //Field offset: 0x28

			public <>c__DisplayClass16_0() { }

			internal void <PlayTape>g__TryStudyItem|1() { }

			[AsyncStateMachine(typeof(<<PlayTape>g__TryStudyItemAsync|0>d))]
			internal Task <PlayTape>g__TryStudyItemAsync|0() { }

		}

		[CompilerGenerated]
		private struct <PlayStopRecorderAnimation>d__13 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PlayerOwnerInventoryController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <ProcessMalfunctionExamined>d__3 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public int delayInMilliseconds; //Field offset: 0x20
			public PlayerOwnerInventoryController <>4__this; //Field offset: 0x28
			public Weapon weapon; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <UseRecorder>d__12 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public PlayerOwnerInventoryController <>4__this; //Field offset: 0x20
			public TapeItem tape; //Field offset: 0x28
			public RecorderItem recorder; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		protected PlayerOwnerInventoryController(Player player, Profile profile, bool examined) { }

		[CompilerGenerated]
		internal static void <CollectCompletableItem>g__SetCompletableTypeToStats|14_0(ECompletableType completableType, ref <>c__DisplayClass14_0 unnamed_param_1) { }

		public virtual void CallMalfunctionRepaired(Weapon weapon) { }

		public virtual void CallUnknownMalfunctionStartRepair(Weapon weapon) { }

		public virtual bool CheckedMagazine(Magazine magazine) { }

		public virtual void CollectCompletableItem(CompletableItem completable) { }

		public virtual AbstractOperation ConvertOperationResultToOperation(IOperationResult operationResult) { }

		public virtual void ExamineMalfunction(Weapon weapon, bool clearRest = false) { }

		public virtual void ExamineMalfunctionType(Weapon weapon) { }

		public virtual void GetAcceptableItemsNonAlloc(EquipmentSlot[] equipmentSlots, IList preAllocatedList, Predicate predicate = null, Predicate goDeeperPredicate = null) { }

		private float GetGlowAlphaMultiplier() { }

		[AsyncStateMachine(typeof(<PlayStopRecorderAnimation>d__13))]
		public virtual Task PlayStopRecorderAnimation() { }

		public virtual void PlayTape(TapeItem tape, RecorderItem recorder = null) { }

		[AsyncStateMachine(typeof(<ProcessMalfunctionExamined>d__3))]
		private Task ProcessMalfunctionExamined(Weapon weapon, int delayInMilliseconds) { }

		public virtual void StopRecorderOperation(bool immediate, out Task completionTask) { }

		public virtual StudyItemBaseOperation StudyItem(CompletableItem item, RecorderItem recorder) { }

		private bool TryFindRecorderInSpecialSlots() { }

		public virtual Option TryThrowItem(Item item, Callback callback = null, bool silent = false) { }

		[AsyncStateMachine(typeof(<UseRecorder>d__12))]
		public virtual Task UseRecorder(RecorderItem recorder, TapeItem tape) { }

	}

	internal sealed class Process`2 : AbstractProcess
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Callback <>9__13_0; //Field offset: 0x0
			public static Callback <>9__13_1; //Field offset: 0x0
			public static Callback <>9__26_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <Proceed>b__13_0(IResult result) { }

			internal void <Proceed>b__13_1(Result result) { }

			internal void <RestoreHandsIfLost>b__26_0(Result result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			public Process <>4__this; //Field offset: 0x0
			public int playerId; //Field offset: 0x0
			public Action execute; //Field offset: 0x0

			public <>c__DisplayClass14_0() { }

			internal void <Execute>b__0() { }

			internal void <Execute>b__1() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			public Process <>4__this; //Field offset: 0x0
			public SetInHandsOperation setInHandsOperation; //Field offset: 0x0

			public <>c__DisplayClass15_0() { }

			internal void <CreateController>b__0() { }

		}

		private readonly Player _player; //Field offset: 0x0
		private readonly Func _controllerFactory; //Field offset: 0x0
		[CanBeNull]
		private readonly Item _item; //Field offset: 0x0
		private readonly Completion _completion; //Field offset: 0x0
		private Confirmation _confirmation; //Field offset: 0x0
		private bool _skippable; //Field offset: 0x0
		private bool _completed; //Field offset: 0x0
		private Callback _beginCallback; //Field offset: 0x0
		private Callback _completeCallback; //Field offset: 0x0
		private TController _controller; //Field offset: 0x0
		private bool _fastHide; //Field offset: 0x0
		private bool _spawned; //Field offset: 0x0

		internal Process`2(Player player, Func controllerFactory, Item item, bool fastHide = false, Completion completion = 0, Confirmation confirmation = 1, bool skippable = true) { }

		[CompilerGenerated]
		private void <Abort>b__23_0(Result callback) { }

		protected virtual void Abort() { }

		protected virtual void AbortAfterCompletion() { }

		protected virtual void Begin(string error = null) { }

		protected virtual void Complete() { }

		protected virtual void Complete(string error) { }

		internal void Confirm(bool succeed) { }

		protected virtual void CreateController() { }

		protected virtual void Execute() { }

		protected virtual void ExecuteNext() { }

		internal void Proceed(Callback beginCallback, Callback completeCallback, bool scheduled) { }

		private void RescheduleAfterAbort(AbstractProcess scheduledProcess) { }

		private void RestoreHandsIfLost() { }

		protected virtual void Skip(string error) { }

		protected virtual void SkipToNext(string error) { }

		protected virtual bool TrySkip() { }

	}

	public class QuickGrenadeThrowHandsController : BaseGrenadeHandsController, IQuickGrenadeThrowController, IQuickUseHandsController, IQuickUseHandsController, IHandsController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public Action callback; //Field offset: 0x10

			public <>c__DisplayClass5_0() { }

			internal void <Spawn>b__0() { }

		}

		internal class QuickGrenadeThrowOperation : GrenadeOperation
		{
			private Action _onControllerAppeared; //Field offset: 0x30
			private Action _onControllerDestroyed; //Field offset: 0x38
			private Callback _onUseCallback; //Field offset: 0x40
			private bool _throwFinished; //Field offset: 0x48
			private bool _grenadeCreated; //Field offset: 0x49
			private float _timeSinceSafetyLevelRemoved; //Field offset: 0x4C

			public QuickGrenadeThrowOperation(QuickGrenadeThrowHandsController controller) { }

			public virtual void FastForward() { }

			public virtual void HideGrenade(Action onHidden, bool fastHide = false) { }

			public virtual void OnDrawCompleteAction() { }

			public virtual void OnDropFinishedAction() { }

			public virtual void OnDropGrenadeAction() { }

			public virtual void Reset() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void SetOnUsedCallback(Callback callback) { }

			public void Start(Action callback) { }

			public virtual void StartCountdown() { }

			public virtual void Update(float deltaTime) { }

		}


		protected QuickGrenadeThrowOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public QuickGrenadeThrowHandsController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__8_0() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanRemove() { }

		internal static T CreateController(Player player, ThrowWeap item) { }

		internal static Task CreateControllerAsync(Player player, ThrowWeap item) { }

		protected QuickGrenadeThrowOperation get_CurrentOperation() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		public override void SetOnUsedCallback(Callback callback) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	public class QuickKnifeKickController : BaseKnifeController, IQuickKnifeKickController, IQuickUseHandsController, IQuickUseHandsController, IHandsController
	{
		internal class QuickKnifeKickOperation : BaseKnifeOperation
		{
			private Action _onControllerAppeared; //Field offset: 0x30
			private Action _onControllerDestroyed; //Field offset: 0x38
			private Callback _onUseCallback; //Field offset: 0x40
			private bool _kickFinished; //Field offset: 0x48

			public QuickKnifeKickOperation(QuickKnifeKickController controller) { }

			public virtual void HideWeapon(Action onHidden, bool fastHide) { }

			public virtual void OnFire() { }

			public virtual void OnFireEnd() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void SetOnUsedCallback(Callback callback) { }

			public void Start(Action callback) { }

			public virtual void Update(float deltaTime) { }

			public virtual void WeaponAppeared() { }

		}


		protected QuickKnifeKickOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public override Knife Item
		{
			 get { } //Length: 200
		}

		public QuickKnifeKickController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__10_0() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanRemove() { }

		internal static T CreateController(Player player, KnifeComponent knife) { }

		internal static Task CreateControllerAsync(Player player, KnifeComponent knife) { }

		protected QuickKnifeKickOperation get_CurrentOperation() { }

		public override Knife get_Item() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		public override void SetOnUsedCallback(Callback callback) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	internal class QuickUseItemController : ItemHandsController, IQuickUseItem, IHandsController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			public Action callback; //Field offset: 0x10

			public <>c__DisplayClass16_0() { }

			internal void <Spawn>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			public Action callback; //Field offset: 0x10

			public <>c__DisplayClass17_0() { }

			internal void <Drop>b__0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0`1
		{
			public T controller; //Field offset: 0x0

			public <>c__DisplayClass6_0`1() { }

			internal void <CreateController>b__0() { }

		}

		internal abstract class BaseQuickUseOperation : ObjectInHandsOperation, IQuickUsOperation
		{
			protected readonly QuickUseItemController Controller; //Field offset: 0x28

			protected BaseQuickUseOperation(QuickUseItemController controller) { }

			public override void HideController(Action onHidden, bool fastHide) { }

			public override void OnDrawCompleteAction() { }

			public override void OnHideCompleteActionAction() { }

			public override void OnUseAction() { }

		}

		internal class QuickUseOperation : BaseQuickUseOperation
		{
			private Action _onControllerAppeared; //Field offset: 0x30
			private Action _onControllerDestroyed; //Field offset: 0x38
			private Callback _onUseCallback; //Field offset: 0x40

			public QuickUseOperation(QuickUseItemController controller) { }

			public override void FastForward() { }

			public Callback GetOnUsedCallback() { }

			public virtual void OnDrawCompleteAction() { }

			public virtual void OnUseAction() { }

			public virtual void Reset() { }

			public void SetOnUsedCallback(Callback callback) { }

			public void Start(Action callback) { }

		}

		protected GameObject _usableItemGameObject; //Field offset: 0xA8
		protected FirearmsAnimator _objectInHandsAnimator; //Field offset: 0xB0

		protected QuickUseOperation CurrentOperation
		{
			 get { } //Length: 122
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public virtual string LoggerDistinctId
		{
			 get { } //Length: 194
		}

		public QuickUseItemController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__13_0() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		public virtual bool CanRemove() { }

		internal static T CreateController(Player player, Item item) { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		protected QuickUseOperation get_CurrentOperation() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public virtual string get_LoggerDistinctId() { }

		public override Callback GetOnUsedCallback() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		protected virtual void IEventsConsumerOnFiringBullet() { }

		protected virtual void IEventsConsumerOnThirdAction(int i) { }

		protected virtual void IEventsConsumerOnWeapIn() { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		private void OnDrawCompleteAction() { }

		private void OnHideCompleteActionAction() { }

		private void OnUseCompleteAction() { }

		private void RemoveItemFromHand() { }

		public override void SetOnUsedCallback(Callback callback) { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	public class RecorderHandsController : ItemHandsController, IRecorderController, IQuickUseItem, IHandsController
	{
		[CompilerGenerated]
		private struct <<IEventsConsumerOnMagOut>g__DelayedSwapTape|19_0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public RecorderHandsController <>4__this; //Field offset: 0x20
			private CancellationToken <token>5__2; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private sealed class <>c__16`1
		{
			public static readonly <>c__16 <>9; //Field offset: 0x0
			public static Func <>9__16_1; //Field offset: 0x0

			private static <>c__16`1() { }

			public <>c__16`1() { }

			internal bool <Setup>b__16_1(Renderer x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0`1
		{
			public T controller; //Field offset: 0x0

			public <>c__DisplayClass16_0`1() { }

			internal void <Setup>b__0() { }

		}

		[CompilerGenerated]
		private struct <CreateControllerAsync>d__15`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public Item item; //Field offset: 0x0
			public RecorderHandler recorderHandler; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private sealed class RecorderInHandsOperation : ObjectInHandsOperation
		{
			private readonly RecorderHandsController _controller; //Field offset: 0x28
			private Action _onHiddenCallback; //Field offset: 0x30
			public Callback _onUsedCallback; //Field offset: 0x38

			public RecorderInHandsOperation(RecorderHandsController controller) { }

			public void FastForward() { }

			public Callback GetOnUsedCallback() { }

			public void HideWeapon(Action onHiddenCallback) { }

			public void HideWeaponComplete() { }

			public void Remove() { }

			public virtual void Reset() { }

			public void SetOnUsedCallback(Callback callback) { }

			public void Start(Action callback) { }

		}

		private const int CHANGE_TAPE_DELAY = 300; //Field offset: 0x0
		private const string TAPE_BONE_NAME = "item_recorder_tape"; //Field offset: 0x0
		private FirearmsAnimator _firearmsAnimator; //Field offset: 0xA8
		private RecorderHandler _recorderHandler; //Field offset: 0xB0
		private RecorderItem _recorder; //Field offset: 0xB8
		private bool _playButtonPressed; //Field offset: 0xC0
		private GameObject _tapeObject; //Field offset: 0xC8
		private Transform _tapeRoot; //Field offset: 0xD0
		private CancellationTokenSource _cancellationTokenSource; //Field offset: 0xD8

		private RecorderInHandsOperation CurrentOperation
		{
			private get { } //Length: 76
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public RecorderHandsController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__13_0() { }

		[AsyncStateMachine(typeof(<<IEventsConsumerOnMagOut>g__DelayedSwapTape|19_0>d))]
		[CompilerGenerated]
		private Task <IEventsConsumerOnMagOut>g__DelayedSwapTape|19_0() { }

		protected virtual bool CanChangeCompassState(bool newState) { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		public virtual bool CanRemove() { }

		internal static T CreateController(Player player, Item item, RecorderHandler recorderHandler) { }

		[AsyncStateMachine(typeof(<CreateControllerAsync>d__15`1))]
		internal static Task CreateControllerAsync(Player player, Item item, RecorderHandler recorderHandler) { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		private RecorderInHandsOperation get_CurrentOperation() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public override Callback GetOnUsedCallback() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		protected virtual void IEventsConsumerOnFiringBullet() { }

		protected virtual void IEventsConsumerOnMagIn() { }

		protected virtual void IEventsConsumerOnMagOut() { }

		protected virtual void IEventsConsumerOnThirdAction(int IntParam) { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual void Loot(bool p) { }

		public virtual void Pickup(bool p) { }

		public override void Remove() { }

		public override void SetOnUsedCallback(Callback callback) { }

		private void SetTapeObject(Item tapeItem) { }

		private static void Setup(T controller, Player player, Item item, RecorderHandler recorderHandler) { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

	}

	private sealed class RemoveFromHandsOperation : InventoryOperation
	{

		public RemoveFromHandsOperation(Player player, Item item) { }

		protected virtual void OnConfirm(bool succeed) { }

		protected virtual void OnExecute() { }

	}

	public sealed class SetInHandsOperation : InventoryOperation
	{

		public SetInHandsOperation(Player player, Item item) { }

		protected virtual void OnConfirm(bool succeed) { }

		protected virtual void OnExecute() { }

	}

	internal sealed class SinglePlayerInventoryController : PlayerOwnerInventoryController
	{
		[CompilerGenerated]
		private struct <ExecuteAsync>d__5 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public SinglePlayerInventoryController <>4__this; //Field offset: 0x20
			public AbstractOperation operation; //Field offset: 0x28
			public Callback callback; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private readonly IPlayerSearchController <PlayerSearchController>k__BackingField; //Field offset: 0x1B0

		public virtual IPlayerSearchController PlayerSearchController
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		internal SinglePlayerInventoryController(Player player, Profile profile, bool isBot = false, bool examined = false) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0(AbstractOperation operation, Callback callback) { }

		internal virtual SearchContentOperation CreateSearchOperation(SearchableItem item) { }

		internal virtual void Execute(AbstractOperation operation, Callback callback) { }

		[AsyncStateMachine(typeof(<ExecuteAsync>d__5))]
		private Task ExecuteAsync(AbstractOperation operation, Callback callback) { }

		[CompilerGenerated]
		public virtual IPlayerSearchController get_PlayerSearchController() { }

		public virtual void GetTraderServicesDataFromServer(string traderId) { }

		public virtual bool HasCultistAmulet(out CultistAmulet amulet) { }

		public virtual void RemoveItem(Item item, Callback callback = null) { }

		public void TryExpendCultistAmuletChargeOrDestroy(bool destroy, bool onGameEnd) { }

	}

	internal class SlotObserver`1
	{
		public readonly BindableEvent Changed; //Field offset: 0x0
		[CanBeNull]
		protected T CurrentValue; //Field offset: 0x0
		private readonly Slot _slot; //Field offset: 0x0
		private readonly Func _subscriber; //Field offset: 0x0
		private Action _unsubscribe; //Field offset: 0x0

		[CanBeNull]
		public override T Component
		{
			 get { } //Length: 19
		}

		public SlotObserver`1(Slot slot, Func subscriber) { }

		public override void Dispose() { }

		public override T get_Component() { }

		public T GetItemComponent() { }

		private void OnSet() { }

		public void Set(T value) { }

		public void Update() { }

	}

	public class UsableItemController : ItemHandsController, IUsableItemController, IWeaponController, IHandsController, ICompassController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass51_0
		{
			public UsableItemController <>4__this; //Field offset: 0x10
			public RemoveFromHandsOperation inventoryOperation; //Field offset: 0x18
			public Action callback; //Field offset: 0x20

			public <>c__DisplayClass51_0() { }

			internal void <Drop>b__0() { }

		}

		[CompilerGenerated]
		private struct <CreateControllerAsync>d__23`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public Player player; //Field offset: 0x0
			public Item item; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public abstract class BaseUsableItemOperation : ObjectInHandsOperation, IBaseUsableItemOperation
		{
			protected readonly UsableItemController Controller; //Field offset: 0x28
			protected readonly Player Player; //Field offset: 0x30

			protected BaseUsableItemOperation(UsableItemController controller) { }

			public override bool CanRemove() { }

			public override void ExamineWeapon() { }

			public override void Execute(IInventoryOperation operation, Callback callback) { }

			public override void FastForward() { }

			public override void HideWeapon(Action onHidden, bool fastDrop) { }

			public override void HideWeaponComplete() { }

			public override void OnAimingDisabled() { }

			public override void OnBackpackDrop() { }

			public override void OnIdleStart() { }

			public override void SetAiming(bool isAiming) { }

			public override void SetCompassState(bool active) { }

			public override void SetInventoryOpened(bool opened) { }

			public override void WeaponAppeared() { }

		}

		public class DropBackpackOperation : BaseUsableItemOperation
		{
			private Callback _callback; //Field offset: 0x38

			public DropBackpackOperation(UsableItemController controller) { }

			protected virtual double GetMaxOperationDuration() { }

			protected override void InitiateIdlingOperation() { }

			public virtual void OnBackpackDrop() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public override void Start(Item item, Callback callback) { }

		}

		public class Idling : BaseUsableItemOperation
		{
			private const float IDLING_MAX_TIME = 300; //Field offset: 0x0
			private float _idlingTime; //Field offset: 0x38

			public Idling(UsableItemController controller) { }

			public virtual bool CanRemove() { }

			public virtual void ExamineWeapon() { }

			public virtual void Execute(IInventoryOperation operation, Callback callback) { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			protected override void InitiateDropBackpackOperation(IOneItemOperation oneItemOperation, Callback callback) { }

			public virtual void OnAimingDisabled() { }

			public virtual void OnEnd() { }

			public virtual void Reset() { }

			public virtual void SetAiming(bool isAiming) { }

			public virtual void SetCompassState(bool active) { }

			public virtual void SetInventoryOpened(bool opened) { }

			public void Start() { }

			public virtual void Update(float deltaTime) { }

		}

		public class Remove : BaseUsableItemOperation
		{
			protected Action _onHiddenCallback; //Field offset: 0x38

			public Remove(UsableItemController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			public virtual void HideWeaponComplete() { }

			public virtual void Reset() { }

			public override void Start(Action onHidden, bool fastDrop) { }

		}

		internal class ServerDropBackpackOperation : DropBackpackOperation
		{
			protected const float BACKPACK_DROP_EVENT_TIME = 0.25; //Field offset: 0x0
			protected float _updateTime; //Field offset: 0x40
			protected bool _backpackDropedEventFired; //Field offset: 0x44

			public ServerDropBackpackOperation(UsableItemController controller) { }

			public virtual void FastForward() { }

			public virtual void Start(Item item, Callback callback) { }

			public virtual void Update(float deltaTime) { }

		}

		public class SpawnOperation : BaseUsableItemOperation
		{
			protected Action _hideAction; //Field offset: 0x38
			protected Action _onWeaponAppear; //Field offset: 0x40
			protected bool _fastDrop; //Field offset: 0x48

			public SpawnOperation(UsableItemController controller) { }

			public virtual void FastForward() { }

			public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

			public virtual void Reset() { }

			protected override void SetIdlingOperation() { }

			protected virtual void SetLeftStanceAnimOnStartOperation() { }

			public void Start(Action callback) { }

			public virtual void WeaponAppeared() { }

		}

		private const float OVERLAP_LN_DISTANCE = 0.5; //Field offset: 0x0
		private static readonly RaycastHit[] _raycastHits; //Field offset: 0x0
		private int _playerLayer; //Field offset: 0xA8
		private bool _isInventoryOpened; //Field offset: 0xAC
		private bool _manuallyUpdated; //Field offset: 0xAD
		protected float _overlap; //Field offset: 0xB0
		protected ObjectInHands _objectInHands; //Field offset: 0xB8
		protected FirearmsAnimator _firearmsAnimator; //Field offset: 0xC0
		protected Func _isOverlapHitIgnoredTest; //Field offset: 0xC8
		protected bool AimingInterruptedByOverlap; //Field offset: 0xD0
		protected float UsableItemLn; //Field offset: 0xD4
		protected bool _isAiming; //Field offset: 0xD8

		protected IBaseUsableItemOperation CurrentOperation
		{
			 get { } //Length: 66
		}

		public virtual FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 8
		}

		public virtual bool IsAiming
		{
			 get { } //Length: 8
			 set { } //Length: 423
		}

		public virtual string LoggerDistinctId
		{
			 get { } //Length: 194
		}

		private static UsableItemController() { }

		public UsableItemController() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__71_0() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__71_1() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__71_2() { }

		[CompilerGenerated]
		private ObjectInHandsOperation <GetOperationFactoryDelegates>b__71_3() { }

		[CompilerGenerated]
		private void <InitializeController>b__26_0() { }

		public virtual bool CanExecute(IInventoryOperation operation) { }

		public virtual bool CanInteract() { }

		public virtual bool CanRemove() { }

		internal static T CreateController(Player player, Item item) { }

		[AsyncStateMachine(typeof(<CreateControllerAsync>d__23`1))]
		internal static Task CreateControllerAsync(Player player, Item item) { }

		public virtual void Destroy() { }

		public virtual void Drop(float animationSpeed, Action callback, bool fastDrop, Item nextControllerItem = null) { }

		public override bool ExamineWeapon() { }

		public virtual void Execute(IInventoryOperation operation, Callback callback) { }

		public virtual void FastForwardCurrentOutdatedState() { }

		public virtual void FastForwardCurrentState() { }

		protected IBaseUsableItemOperation get_CurrentOperation() { }

		public virtual FirearmsAnimator get_FirearmsAnimator() { }

		public virtual bool get_IsAiming() { }

		public virtual string get_LoggerDistinctId() { }

		protected virtual Dictionary GetOperationFactoryDelegates() { }

		private static WeaponPrefab GetWeaponPrefab(T controller) { }

		public override void Hide() { }

		private void HideWeaponComplete() { }

		protected virtual void IEventsConsumerOnIdleStart() { }

		protected virtual void IEventsConsumerOnOnUseProp(bool boolParam) { }

		protected virtual void IEventsConsumerOnThirdAction(int intParam) { }

		protected virtual void IEventsConsumerOnWeapIn() { }

		protected virtual void IEventsConsumerOnWeapOut() { }

		protected virtual void IEventsOnBackpackDrop() { }

		protected override void InitializeController(Player player, WeaponPrefab weaponPrefab) { }

		protected override void InitiateSpawnOperation(Action callback) { }

		public virtual void Interact(bool isInteracting, int actionIndex) { }

		public virtual bool IsInInteraction() { }

		public virtual bool IsInInteractionStrictCheck() { }

		public virtual bool IsInventoryOpen() { }

		protected bool IsOverlapHitIgnored(RaycastHit overlapHit) { }

		public virtual void Loot(bool p) { }

		public virtual void ManualLateUpdate(float deltaTime) { }

		public virtual void ManualUpdate(float deltaTime) { }

		private void OnAimingDisabled() { }

		private void OnBackpackDropEvent() { }

		private float OverlapLn(Vector3 origin, float ln, ref bool overlapsWithPlayer) { }

		public virtual void Pickup(bool p) { }

		protected virtual void set_IsAiming(bool value) { }

		public override void SetAim(bool value) { }

		public virtual void SetInventoryOpened(bool opened) { }

		private static void Setup(T controller, Player player) { }

		protected void SetUpOverlaping() { }

		public virtual void ShowGesture(EInteraction gesture) { }

		public virtual void Spawn(float animationSpeed, Action callback) { }

		private void SprintStateChangedEvent(bool obj) { }

		protected override void StateChangedHandler(EPlayerState previousstate, EPlayerState nextstate) { }

		public virtual bool SupportPickup() { }

		public override void ToggleAim() { }

		private void UsableItemOverlapping() { }

		private void WeaponAppeared() { }

	}

	internal class ValueBlender
	{
		protected float _target; //Field offset: 0x10
		protected float _startTime; //Field offset: 0x14
		protected float _startValue; //Field offset: 0x18
		public float Speed; //Field offset: 0x1C

		public override float Target
		{
			 get { } //Length: 6
			 set { } //Length: 151
		}

		public override float Value
		{
			 get { } //Length: 183
			 set { } //Length: 98
		}

		public ValueBlender(int defaultValue = 0) { }

		public override float get_Target() { }

		public override float get_Value() { }

		public override void set_Target(float value) { }

		public override void set_Value(float value) { }

	}

	internal class ValueBlenderDelay : ValueBlender
	{
		public float Delay; //Field offset: 0x20

		public virtual float Target
		{
			 get { } //Length: 6
			 set { } //Length: 156
		}

		public ValueBlenderDelay() { }

		public virtual float get_Target() { }

		public virtual void set_Target(float value) { }

	}

	internal sealed class WrongComponentStateError : Error
	{
		private readonly ItemComponent _component; //Field offset: 0x10
		private readonly bool _value; //Field offset: 0x18

		public WrongComponentStateError(ItemComponent component, bool value) { }

		public virtual string ToString() { }

	}

	private const int MAX_FACESHIELD_OPERATIONS_PER_FRAME = 3; //Field offset: 0x0
	private const float LOCAL_AI_GEAR_VOLUME = 1; //Field offset: 0x0
	private const float FP_GEAR_VOLUME = 0.85; //Field offset: 0x0
	private const float SURFACE_CHECK_RAYCAST_OFFSET = 0.5; //Field offset: 0x0
	private const float MAX_STEP_SOUND_SPEED_FACTOR = 1; //Field offset: 0x0
	private const float MIN_ALLOWED_MOVEMENT_SPEED = 0.01; //Field offset: 0x0
	private const float TIME_BETWEEN_PRONE_SWEEPS = 0.5; //Field offset: 0x0
	private const int CURVE_CACHE_CAPACITY = 32; //Field offset: 0x0
	private const float ClampDeltaHeight = 0.2; //Field offset: 0x0
	private const string COMPASS_RESOURCE_PATH = "assets/content/weapons/additional_hands/item_compass.bundle"; //Field offset: 0x0
	private const string PLANT_TRIPWIRE_TEMPLATE_PATH = "Prefabs/tripwire_planner"; //Field offset: 0x0
	private const int LOCAL_SCENE_IK_LIMBS_PER_PLAYER = 2; //Field offset: 0x0
	private const float FIRST_PERSON_STRAP_WEAPON_DEATH_HOLD_DURATION = 2; //Field offset: 0x0
	private const float FIRST_PERSON_DEATH_HOLD_LEFT_SHOULDER_SPLAY_DEGREES = 3; //Field offset: 0x0
	private static readonly Player[] _localSceneIkPlayers; //Field offset: 0x0
	private const int LOCAL_SCENE_IK_MAX_ENTRIES = 512; //Field offset: 0x0
	private const float CHECK_RANGE_BUFF = 1; //Field offset: 0x0
	private const float MIN_FALL_DAMAGE = 1; //Field offset: 0x0
	private const int LOCAL_SCENE_IK_MAX_PLAYERS = 256; //Field offset: 0x0
	private const float MIN_TIME_SINCE_LAST_LANDING = 0.5; //Field offset: 0x0
	private const float MIN_COMMON_DAMAGE = 4; //Field offset: 0x0
	public const string ARTA_MAN_NAME = "UI/Artillery/ArtaManName"; //Field offset: 0x0
	public const string ARTA_MAN_PROFILE_ID = "66f3fad50ec64d74847d049d"; //Field offset: 0x0
	public const string SNIPER_BLACK_DIV_KEY = "SniperBlackDivision"; //Field offset: 0x0
	private const EAnimatorMask FastAnimatorMask = 27; //Field offset: 0x0
	private const int INTERACTION_RAYCAST_INTERVAL = 3; //Field offset: 0x0
	public const EAnimatorMask EnabledAnimatorsSpiritDefault = 3; //Field offset: 0x0
	public const string LAYER_NAME_PLAYER = "Player"; //Field offset: 0x0
	private const float DEFAULT_FP_ROLLOFF = 70; //Field offset: 0x0
	private const int SPRINT_DAMAGE = 2; //Field offset: 0x0
	public const EAnimatorMask EnabledAnimatorsPlayerDefault = 31; //Field offset: 0x0
	private const int JUMP_DAMAGE = 3; //Field offset: 0x0
	private static readonly float[] _localSceneIkDistances; //Field offset: 0x8
	private static readonly Player[] _localSceneIkEntryPlayers; //Field offset: 0x10
	private static readonly int[] _localSceneIkEntryLimbIndices; //Field offset: 0x18
	private static readonly Transform[] _localSceneIkApplyBone1Transforms; //Field offset: 0x20
	private static readonly Transform[] _localSceneIkApplyBone2Transforms; //Field offset: 0x28
	private static readonly Transform[] _localSceneIkApplyBone3Transforms; //Field offset: 0x30
	private static readonly int[] _localSceneIkApplyEntryIndices; //Field offset: 0x38
	private static int _localSceneIkFrame; //Field offset: 0x40
	private static int _localSceneIkQueuedCount; //Field offset: 0x44
	private static Player _localSceneFovPlayer; //Field offset: 0x48
	private static int _localSceneIkExecutedCount; //Field offset: 0x50
	private static int _localSceneIkLateUpdateActiveCount; //Field offset: 0x54
	private static int _localSceneIkLateUpdateCompletedCount; //Field offset: 0x58
	private static int _localSceneIkRuntimeUsers; //Field offset: 0x5C
	private static bool _localSceneIkBatchExecuting; //Field offset: 0x60
	private static bool _localSceneFullBodyStagePending; //Field offset: 0x61
	private static bool _localSceneIkRuntimeInitialized; //Field offset: 0x62
	private static NativeArray _localSceneIkMarkerPositions; //Field offset: 0x68
	private static NativeArray _localSceneIkMarkerRotations; //Field offset: 0x78
	private static NativeArray _localSceneIkGripReferencePositions; //Field offset: 0x88
	private static NativeArray _localSceneIkTargetPositions; //Field offset: 0x98
	private static NativeArray _localSceneIkTargetRotations; //Field offset: 0xA8
	private static NativeArray _localSceneIkMarkerValid; //Field offset: 0xB8
	private static NativeArray _localSceneIkGripReferenceValid; //Field offset: 0xC8
	private static NativeArray _localSceneIkTargetValid; //Field offset: 0xD8
	private static NativeArray _localSceneIkLimbActive; //Field offset: 0xE8
	private static NativeArray _localSceneIkDistanceToCamera; //Field offset: 0xF8
	private static NativeArray _localSceneIkInteractionValid; //Field offset: 0x108
	private static NativeArray _localSceneIkInteractionTargetPosition; //Field offset: 0x118
	private static NativeArray _localSceneIkInteractionTargetRotation; //Field offset: 0x128
	private static NativeArray _localSceneIkInteractionBlend; //Field offset: 0x138
	private static NativeArray _localSceneIkResultPositions; //Field offset: 0x148
	private static NativeArray _localSceneIkResultRotations; //Field offset: 0x158
	private static NativeArray _localSceneIkResultGripWeights; //Field offset: 0x168
	private static NativeArray _localSceneIkShouldSetGripWeight; //Field offset: 0x178
	private static NativeArray _localSceneIkResultValid; //Field offset: 0x188
	private static NativeArray _localSceneIkUseParallelSolver; //Field offset: 0x198
	private static NativeArray _localSceneIkBone1Positions; //Field offset: 0x1A8
	private static NativeArray _localSceneIkBone2Positions; //Field offset: 0x1B8
	private static NativeArray _localSceneIkBone3Positions; //Field offset: 0x1C8
	private static NativeArray _localSceneIkBone1Rotations; //Field offset: 0x1D8
	private static NativeArray _localSceneIkBone2Rotations; //Field offset: 0x1E8
	private static NativeArray _localSceneIkBone3Rotations; //Field offset: 0x1F8
	private static NativeArray _localSceneIkBone1TargetToLocal; //Field offset: 0x208
	private static NativeArray _localSceneIkBone2TargetToLocal; //Field offset: 0x218
	private static NativeArray _localSceneIkBone1DefaultLocalBendNormals; //Field offset: 0x228
	private static NativeArray _localSceneIkBone2DefaultLocalBendNormals; //Field offset: 0x238
	private static NativeArray _localSceneIkBendNormals; //Field offset: 0x248
	private static NativeArray _localSceneIkMaintainRotationWeights; //Field offset: 0x258
	private static NativeArray _localSceneIkMaintainRotationReferences; //Field offset: 0x268
	private static NativeArray _localSceneIkPositionWeights; //Field offset: 0x278
	private static NativeArray _localSceneIkRotationWeights; //Field offset: 0x288
	private static NativeArray _localSceneIkDirectHierarchy; //Field offset: 0x298
	private static NativeArray _localSceneIkBone2ChildOfBone1; //Field offset: 0x2A8
	private static NativeArray _localSceneIkBone3ChildOfBone1; //Field offset: 0x2B8
	private static NativeArray _localSceneIkBone3ChildOfBone2; //Field offset: 0x2C8
	private static NativeArray _localSceneIkSolvedBone1Rotations; //Field offset: 0x2D8
	private static NativeArray _localSceneIkSolvedBone2Rotations; //Field offset: 0x2E8
	private static NativeArray _localSceneIkSolvedBone3Rotations; //Field offset: 0x2F8
	private static NativeArray _localSceneIkSolvedValid; //Field offset: 0x308
	private static NativeArray _localSceneIkApplyRotations1; //Field offset: 0x318
	private static NativeArray _localSceneIkApplyRotations2; //Field offset: 0x328
	private static NativeArray _localSceneIkApplyRotations3; //Field offset: 0x338
	private static TransformAccessArray _localSceneIkApplyTransforms1; //Field offset: 0x348
	private static TransformAccessArray _localSceneIkApplyTransforms2; //Field offset: 0x350
	private static TransformAccessArray _localSceneIkApplyTransforms3; //Field offset: 0x358
	[CompilerGenerated]
	private static Action OnPlayerDeadStatic; //Field offset: 0x360
	[CompilerGenerated]
	private static Action OnPlayerUnspawnStatic; //Field offset: 0x368
	private static readonly DeltaTimeDelegate _defaultDeltaTimeDelegate; //Field offset: 0x370
	protected static readonly string SessionExpCounterTagName; //Field offset: 0x378
	protected static readonly TimeSpan HearingDetectionTime; //Field offset: 0x380
	[CompilerGenerated]
	private Action OnSpeedChangedEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnSightChangedEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnTacticalInteractionChanged; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnSmoothSightChange; //Field offset: 0x38
	public ICharacterController _characterController; //Field offset: 0x40
	protected TriggerColliderSearcher _triggerColliderSearcher; //Field offset: 0x48
	private bool _doorKick; //Field offset: 0x50
	private WorldInteractiveObject _currentInteractor; //Field offset: 0x58
	[CompilerGenerated]
	private MovementContext <MovementContext>k__BackingField; //Field offset: 0x60
	private float _horizontal; //Field offset: 0x68
	private float _vertical; //Field offset: 0x6C
	private bool _resetLook; //Field offset: 0x70
	private bool _mouseLookControl; //Field offset: 0x71
	private bool _isResettingLook; //Field offset: 0x72
	private bool _setResetedLookNextFrame; //Field offset: 0x73
	private bool _isLooking; //Field offset: 0x74
	public Pedometer Pedometer; //Field offset: 0x78
	public Vector3 HeadRotation; //Field offset: 0x80
	protected float _mouseSensitivityModifier; //Field offset: 0x8C
	protected readonly Dictionary _mouseSensitivityModifiers; //Field offset: 0x90
	private Vector2 _rotationPitchLimit; //Field offset: 0x98
	private Vector2 _targetRotationPitch; //Field offset: 0xA0
	[CompilerGenerated]
	private Vector2 <InputDirection>k__BackingField; //Field offset: 0xA8
	public float TrunkRotationLimit; //Field offset: 0xB0
	public float PoseMemo; //Field offset: 0xB4
	private float _speedMemo; //Field offset: 0xB8
	private bool _lastSlowLean; //Field offset: 0xBC
	public LeanType CurrentLeanType; //Field offset: 0xC0
	private float _lastMovement; //Field offset: 0xC4
	private bool _cachedMouseLookControl; //Field offset: 0xC8
	private bool _isVaultingPressed; //Field offset: 0xC9
	private float _vaultingTiming; //Field offset: 0xCC
	protected float _prevHeight; //Field offset: 0xD0
	public float HeightSmoothTime; //Field offset: 0xD4
	private float _dampVelocity; //Field offset: 0xD8
	private float _currentSmoothSpeed; //Field offset: 0xDC
	private float _previousY; //Field offset: 0xE0
	[CompilerGenerated]
	private DamageDelegate OnDamageReceived; //Field offset: 0xE8
	public GripPose LeftHandInteractionTarget; //Field offset: 0xF0
	private float _ribcageScaleCompensated; //Field offset: 0xF8
	private float _shoulderVel; //Field offset: 0xFC
	private float _fbbikCooldown; //Field offset: 0x100
	private float _turnOffFbbikAt; //Field offset: 0x104
	private float _firstPersonRightHand; //Field offset: 0x108
	private float _firstPersonLeftHand; //Field offset: 0x10C
	private float _firstPersonLeftHandPatrol; //Field offset: 0x110
	private float _firstPersonRightHandDetach; //Field offset: 0x114
	private float _fpStrapWeaponDeathHoldRemaining; //Field offset: 0x118
	private bool _fpStrapWeaponDeathHoldParented; //Field offset: 0x11C
	private bool _fpDeathHoldApplyLeftShoulderSplay; //Field offset: 0x11D
	private float _camera3rd; //Field offset: 0x120
	private float _utilityLayerWeight; //Field offset: 0x124
	private float _leftStanceLayerWeight; //Field offset: 0x128
	private float _smoothLW; //Field offset: 0x12C
	private float _rawWeight; //Field offset: 0x130
	private float _rawDampVelocity; //Field offset: 0x134
	private float _interactionLayerWeight; //Field offset: 0x138
	public GrounderFBBIK Grounder; //Field offset: 0x140
	public HitReaction HitReaction; //Field offset: 0x148
	public float RibcageScaleCurrent; //Field offset: 0x150
	public float RibcageScaleCurrentTarget; //Field offset: 0x154
	public Transform[] _elbowBends; //Field offset: 0x158
	public HandPoser[] HandPosers; //Field offset: 0x160
	public Vector2 UtilityLayerRange; //Field offset: 0x168
	public float UtilityLayerLerpSpeed; //Field offset: 0x170
	private float _lsLayerLerpSpeed; //Field offset: 0x174
	public ValueBlender LMarkerRawBlender; //Field offset: 0x178
	public ValueBlender LayerWeight; //Field offset: 0x180
	public readonly BetterValueBlender ThirdIkWeight; //Field offset: 0x188
	public bool GripAutoAdjust; //Field offset: 0x190
	public bool CustomAnimationsAreProcessing; //Field offset: 0x191
	protected FullBodyBipedIK _fbbik; //Field offset: 0x198
	protected PlayerBody _playerBody; //Field offset: 0x1A0
	protected float ThirdPersonWeaponRootAuthority; //Field offset: 0x1A8
	private bool _stored; //Field offset: 0x1AC
	private bool _pointOfViewUndecided; //Field offset: 0x1AD
	private bool _hasAnimatorPropBones; //Field offset: 0x1AE
	private bool _hasProp; //Field offset: 0x1AF
	private bool _propActive; //Field offset: 0x1B0
	private bool _compassInstantiated; //Field offset: 0x1B1
	private bool _radioTransmitterInstantiated; //Field offset: 0x1B2
	private Vector3[] _ribcageChildPositions; //Field offset: 0x1B8
	private Vector3 _ikPosition; //Field offset: 0x1C0
	private Vector3 _lMarkerRawPosition; //Field offset: 0x1CC
	private Vector3 _lElbowRawPosition; //Field offset: 0x1D8
	private Vector3 _rElbowRawPosition; //Field offset: 0x1E4
	private Vector3 _propRawPosition; //Field offset: 0x1F0
	private Quaternion _lMarkerRawRotation; //Field offset: 0x1FC
	private Quaternion _propRawRotation; //Field offset: 0x20C
	private Quaternion _ikRotation; //Field offset: 0x21C
	private Quaternion[] _ribcageChildRotations; //Field offset: 0x230
	private readonly Transform[] _markers; //Field offset: 0x238
	private readonly Transform[] _gripReferences; //Field offset: 0x240
	private readonly Transform[] _ikTargets; //Field offset: 0x248
	private int _localSceneIkLateUpdateFrame; //Field offset: 0x250
	private bool _localSceneIkRuntimeRegistered; //Field offset: 0x254
	private int _localSceneIkQueuedFrame; //Field offset: 0x258
	private int _localSceneIkQueueIndex; //Field offset: 0x25C
	private readonly byte[] _localSceneIkCachedValid; //Field offset: 0x260
	private readonly IKSolverLimb[] _localSceneIkCachedLimbSolvers; //Field offset: 0x268
	private readonly Transform[] _localSceneIkCachedBone1Transforms; //Field offset: 0x270
	private readonly Transform[] _localSceneIkCachedBone2Transforms; //Field offset: 0x278
	private readonly Transform[] _localSceneIkCachedBone3Transforms; //Field offset: 0x280
	private readonly byte[] _localSceneIkCachedDirectHierarchy; //Field offset: 0x288
	private readonly byte[] _localSceneIkCachedBone2ChildOfBone1; //Field offset: 0x290
	private readonly byte[] _localSceneIkCachedBone3ChildOfBone1; //Field offset: 0x298
	private readonly byte[] _localSceneIkCachedBone3ChildOfBone2; //Field offset: 0x2A0
	private int _curveCacheFrame; //Field offset: 0x2A8
	private int _curveCacheCount; //Field offset: 0x2AC
	private readonly int[] _curveCacheHashes; //Field offset: 0x2B0
	private readonly float[] _curveCacheValues; //Field offset: 0x2B8
	private Transform _vestMarker; //Field offset: 0x2C0
	private Transform _shoulderEffector; //Field offset: 0x2C8
	private Transform _propBone; //Field offset: 0x2D0
	private TwistRelax[] _twistBones; //Field offset: 0x2D8
	private LimbIK[] _limbs; //Field offset: 0x2E0
	private GameObject _beaconDummy; //Field offset: 0x2E8
	private Action _createBeaconAction; //Field offset: 0x2F0
	private PreviewMaterialSetter _beaconMaterialSetter; //Field offset: 0x2F8
	private BeaconPlacer _beaconPlacer; //Field offset: 0x300
	private FirearmsEffects _thirdWeaponEffects; //Field offset: 0x308
	private FirearmsEffects _firstWeaponEffects; //Field offset: 0x310
	private CompassArrow _compassArrow; //Field offset: 0x318
	private CompassStorage _compassStorage; //Field offset: 0x320
	private RadioTransmitterView _radioTransmitterView; //Field offset: 0x328
	private Transform[] _animatorPropTransforms; //Field offset: 0x330
	private Transform[] _propTransforms; //Field offset: 0x338
	private bool _needUseHandBone; //Field offset: 0x340
	private readonly List _preAllocatedRenderersList; //Field offset: 0x348
	[CompilerGenerated]
	private bool <HasGamePlayerOwner>k__BackingField; //Field offset: 0x350
	[CompilerGenerated]
	private TripwireVisualPlacer <TripwirePlanner>k__BackingField; //Field offset: 0x358
	[CompilerGenerated]
	private bool <UsedSimplifiedSkeleton>k__BackingField; //Field offset: 0x360
	[CompilerGenerated]
	private readonly BindableEvent <PointOfViewChanged>k__BackingField; //Field offset: 0x368
	public readonly ValueBlender AuthorityBlender; //Field offset: 0x370
	public readonly ValueBlender GrounderBlender; //Field offset: 0x378
	private float _ergonomicsPenalty; //Field offset: 0x380
	private float _tearGasErgonomicsPenalty; //Field offset: 0x384
	private float _coughSprintLockUntil; //Field offset: 0x388
	private float _shotTime; //Field offset: 0x38C
	protected bool _isDeadAlready; //Field offset: 0x390
	private bool _isGrenadeOrKnife; //Field offset: 0x391
	private ObjectInHandsAnimator _handsAnimator; //Field offset: 0x398
	private GameObject _spawnedKey; //Field offset: 0x3A0
	private Action _cacheBonesDelegate; //Field offset: 0x3A8
	[CompilerGenerated]
	private GameObject <CameraContainer>k__BackingField; //Field offset: 0x3B0
	[CompilerGenerated]
	private Transform <CameraPosition>k__BackingField; //Field offset: 0x3B8
	[CompilerGenerated]
	private ProceduralWeaponAnimation <ProceduralWeaponAnimation>k__BackingField; //Field offset: 0x3C0
	[CompilerGenerated]
	private bool <AllowToPlantBeacon>k__BackingField; //Field offset: 0x3C8
	protected bool IsHeadLightsAnimationActive; //Field offset: 0x3C9
	[CompilerGenerated]
	private Action OnShowAmmoDetails; //Field offset: 0x3D0
	[CompilerGenerated]
	private Action BeingHitAction; //Field offset: 0x3D8
	[CompilerGenerated]
	private Action OnPropVisibility; //Field offset: 0x3E0
	[CompilerGenerated]
	private Action OnShowAmmoCountZeroingPanel; //Field offset: 0x3E8
	[CompilerGenerated]
	private Action OnShowFireMode; //Field offset: 0x3F0
	[CompilerGenerated]
	private Vector3 <BeaconPosition>k__BackingField; //Field offset: 0x3F8
	[CompilerGenerated]
	private Quaternion <BeaconRotation>k__BackingField; //Field offset: 0x404
	private bool _isInteractionPlayeingLastFrame; //Field offset: 0x414
	private Quaternion _currentHandsRotation; //Field offset: 0x418
	private Garbage _garbage; //Field offset: 0x428
	public ESurfaceSound CurrentSurface; //Field offset: 0x430
	[CompilerGenerated]
	private EnvironmentType <Environment>k__BackingField; //Field offset: 0x434
	public bool HeavyBreath; //Field offset: 0x438
	public bool Muffled; //Field offset: 0x439
	protected BetterSource NestedStepSoundSource; //Field offset: 0x440
	protected BetterSource _speechSource; //Field offset: 0x448
	private readonly SpeechInterruptFader _speechFade; //Field offset: 0x450
	protected bool OcclusionDirty; //Field offset: 0x458
	protected bool DistanceDirty; //Field offset: 0x459
	protected AudioClip FractureSound; //Field offset: 0x460
	public SoundElement PropIn; //Field offset: 0x468
	public SoundElement PropOut; //Field offset: 0x470
	protected bool PreviousFaceShield; //Field offset: 0x478
	protected bool PreviousNightVision; //Field offset: 0x479
	protected bool PreviousThermalVision; //Field offset: 0x47A
	protected readonly Vector3 SpeechLocalPosition; //Field offset: 0x47C
	protected AudioClip FaceshieldOn; //Field offset: 0x488
	protected AudioClip FaceshieldOff; //Field offset: 0x490
	protected AudioClip NightVisionOn; //Field offset: 0x498
	protected AudioClip SwitchHeadlights; //Field offset: 0x4A0
	protected AudioClip NightVisionOff; //Field offset: 0x4A8
	protected AudioClip ThermalVisionOn; //Field offset: 0x4B0
	protected AudioClip ThermalVisionOff; //Field offset: 0x4B8
	private AudioClip _tinnitus; //Field offset: 0x4C0
	private Dictionary _soundBySurface; //Field offset: 0x4C8
	private SurfaceSet _currentSet; //Field offset: 0x4D0
	private SoundBank _gearSoundBank; //Field offset: 0x4D8
	private SoundBank _gearMediumSoundBank; //Field offset: 0x4E0
	private SoundBank _gearFastSoundBank; //Field offset: 0x4E8
	private SoundBank _backpackDropBank; //Field offset: 0x4F0
	private Sounds _playerSounds; //Field offset: 0x4F8
	private Coroutine _idleCoroutine; //Field offset: 0x500
	private Coroutine _runCoroutine; //Field offset: 0x508
	private Coroutine _sprintCoroutine; //Field offset: 0x510
	private Coroutine _gearDelay; //Field offset: 0x518
	private Coroutine _outOfRangeSpeakingCoroutine; //Field offset: 0x520
	private Coroutine _currentSourceCoroutine; //Field offset: 0x528
	private EffectCoughLoop _coughLoop; //Field offset: 0x530
	private bool _playedAtLeastOneStep; //Field offset: 0x538
	private float _nextJumpAfter; //Field offset: 0x53C
	private BetterSource _searchSource; //Field offset: 0x540
	private float _searchCount; //Field offset: 0x548
	private AudioClip _lastClip; //Field offset: 0x550
	private readonly List _soundPropagationVolumes; //Field offset: 0x558
	private readonly List _volumesBuffer; //Field offset: 0x560
	private BetterPropagationVolume _mutuallyExclusive; //Field offset: 0x568
	private bool _exhaustionIsAudible; //Field offset: 0x570
	private Action _exhaustionAudibilityUnsub; //Field offset: 0x578
	private float _sprintSurfaceCheck; //Field offset: 0x580
	private float _runSurfaceCheck; //Field offset: 0x584
	private float _landSurfaceCheck; //Field offset: 0x588
	private float _proneSurfaceCheck; //Field offset: 0x58C
	private float _sign; //Field offset: 0x590
	private float _lastStepTime; //Field offset: 0x594
	private float _lastTimeTurnSound; //Field offset: 0x598
	private float maxLengthTurnSound; //Field offset: 0x59C
	private float _nextSurfaceCheck; //Field offset: 0x5A0
	private float _distance; //Field offset: 0x5A4
	private bool _enqueuedForRelease; //Field offset: 0x5A8
	private float _maxAllowedMovementSpeed; //Field offset: 0x5AC
	private BaseVaultingAudioController _vaultAudioController; //Field offset: 0x5B0
	private BaseVaultingAudioController _sprintVaultAudioController; //Field offset: 0x5B8
	private BaseVaultingAudioController _climbAudioController; //Field offset: 0x5C0
	private AudioSource _voipAudioSource; //Field offset: 0x5C8
	private IPlayerStepAudioController _specificStepAudioController; //Field offset: 0x5D0
	private Action _voipSourceBinding; //Field offset: 0x5D8
	private BetterSource _gearSource; //Field offset: 0x5E0
	private ISoundInteractionController _tripwireInteractionSoundController; //Field offset: 0x5E8
	private AudioSourcePrewarmer _sourcePrewarmer; //Field offset: 0x5F0
	private IDropBackPackEvents _dropBackPackEvents; //Field offset: 0x5F8
	private AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x600
	private readonly WaitForSeconds _gearWalkDelaySec; //Field offset: 0x608
	private int _animatorFootstepCurveHash; //Field offset: 0x610
	private readonly Dictionary _cachedMovementRolloff; //Field offset: 0x618
	private ClientAudioSettings _clientAudioSettings; //Field offset: 0x620
	private PlayerAudioSettings _playerAudioSettings; //Field offset: 0x628
	private BetterSource _interactionSource; //Field offset: 0x630
	private bool _useSimpleUnderRoofCheck; //Field offset: 0x638
	private readonly PlayerSelfInflictedDamageThresholdAudioChecker _damageThresholdAudioChecker; //Field offset: 0x640
	private AnimationCurve _landingVolumeCurve; //Field offset: 0x648
	private LayerMask _stepLayerMask; //Field offset: 0x650
	private float _prevCharacterSpeed; //Field offset: 0x654
	private IEffectAudioPlayer _frostbiteEffectsPlayer; //Field offset: 0x658
	[CompilerGenerated]
	private IPlayerCustomAudioSettings <CustomAudioSettings>k__BackingField; //Field offset: 0x660
	private Action _soundUnsubscribeOnDestroy; //Field offset: 0x668
	public PlayerOverlapManager POM; //Field offset: 0x670
	public readonly List TriggerZones; //Field offset: 0x678
	public BindableEvent OnExitTriggerVisited; //Field offset: 0x680
	public BindableState InteractingWithExfiltrationPoint; //Field offset: 0x688
	[CompilerGenerated]
	private GameWorld <GameWorld>k__BackingField; //Field offset: 0x690
	public bool QuickdrawWeaponFast; //Field offset: 0x698
	public bool FastSlotSelection; //Field offset: 0x699
	protected Func GetAimingSensitivity; //Field offset: 0x6A0
	public bool PreviousWeaponAimState; //Field offset: 0x6A8
	public float QuickdrawTime; //Field offset: 0x6AC
	protected Func GetSensitivity; //Field offset: 0x6B0
	public EDamageType LastDamageType; //Field offset: 0x6B8
	public EBodyPart LastDamagedBodyPart; //Field offset: 0x6BC
	public bool Destroyed; //Field offset: 0x6C0
	[CompilerGenerated]
	private bool <IsInBufferZone>k__BackingField; //Field offset: 0x6C1
	public bool CanManipulateWithHandsInBufferZone; //Field offset: 0x6C2
	[CompilerGenerated]
	private bool <PreventAutoWeaponDraw>k__BackingField; //Field offset: 0x6C3
	private bool _isInventoryOpened; //Field offset: 0x6C4
	private int _lastHitDebuffFrame; //Field offset: 0x6C8
	private float _accumulatedDebuffDamage; //Field offset: 0x6CC
	private int _negativeBuffsCount; //Field offset: 0x6D0
	private bool _sense; //Field offset: 0x6D4
	private bool _displaySense; //Field offset: 0x6D5
	private float _questItemSenseSqrDistance; //Field offset: 0x6D8
	private LootItem _lastNearestQuestLootItem; //Field offset: 0x6E0
	public IAnimator[] _animators; //Field offset: 0x6E8
	public IAnimator _underbarrelFastAnimator; //Field offset: 0x6F0
	public BaseSpeaker Speaker; //Field offset: 0x6F8
	[CompilerGenerated]
	private OnPlayerDead OnPlayerDead; //Field offset: 0x700
	public PlayerSpirit Spirit; //Field offset: 0x708
	[CompilerGenerated]
	private OnPlayerDeadOrUnspawn OnPlayerDeadOrUnspawn; //Field offset: 0x710
	[EnumBitMask(typeof(EAnimatorMask))]
	public EAnimatorMask EnabledAnimators; //Field offset: 0x718
	protected PlayerLogger Logger; //Field offset: 0x720
	protected Corpse Corpse; //Field offset: 0x728
	protected DamageInfo LastDamageInfo; //Field offset: 0x730
	protected EBodyPart LastBodyPart; //Field offset: 0x810
	protected float _corpseAppliedForce; //Field offset: 0x814
	protected Action _openAction; //Field offset: 0x818
	protected RecodableItemsHandler recodableItemsHandler; //Field offset: 0x820
	private float _countdownToSprintDamage; //Field offset: 0x828
	private float _lastHitTime; //Field offset: 0x82C
	private IHealthEffect Fatigue; //Field offset: 0x830
	protected IPlayer LastAggressor; //Field offset: 0x838
	private Renderer[] _renderers; //Field offset: 0x840
	private Camera _camera; //Field offset: 0x848
	private Coroutine _selfDamage; //Field offset: 0x850
	private readonly BindableState _itemInHands; //Field offset: 0x858
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x860
	private PrecalculatedFloatRandoms _heavyVestsDeflectRandoms; //Field offset: 0x868
	private Action _unsubscribeOnEndSession; //Field offset: 0x870
	protected IEnumerable _helmetLightControllers; //Field offset: 0x878
	private Animator _createdAnimator; //Field offset: 0x880
	private RuntimeAnimatorController _createdRuntimeAnimatorController; //Field offset: 0x888
	public PlayerAnimator PlayerAnimator; //Field offset: 0x890
	private IVaultingParameters _vaultingParameters; //Field offset: 0x898
	private IVaultingComponent _vaultingComponent; //Field offset: 0x8A0
	private IVaultingComponentDebug _vaultingComponentDebug; //Field offset: 0x8A8
	private IVaultingGameplayRestrictions _vaultingGameplayRestrictions; //Field offset: 0x8B0
	protected ILeftHandController _leftHandController; //Field offset: 0x8B8
	private IWeaponMountingComponent _weaponMountingComponent; //Field offset: 0x8C0
	[CompilerGenerated]
	private Action OnGlassesChanged; //Field offset: 0x8C8
	[CompilerGenerated]
	private Action OnBlindnessProtectionChanged; //Field offset: 0x8D0
	[CompilerGenerated]
	private Action OnSenseChanged; //Field offset: 0x8D8
	[CompilerGenerated]
	private Action OnNearestQuestLootPositionChanged; //Field offset: 0x8E0
	[CompilerGenerated]
	private Action PossibleInteractionsChanged; //Field offset: 0x8E8
	[CompilerGenerated]
	private Action PhraseSituation; //Field offset: 0x8F0
	[CompilerGenerated]
	private Action OnInventoryOpened; //Field offset: 0x8F8
	[CompilerGenerated]
	private Action OnStartInventoryOpen; //Field offset: 0x900
	[CompilerGenerated]
	private Action OnStartQuickdrawPistol; //Field offset: 0x908
	[CompilerGenerated]
	private GenericEventTranslator <EventTranslator>k__BackingField; //Field offset: 0x910
	[CompilerGenerated]
	private SlotObserver <FaceShieldObserver>k__BackingField; //Field offset: 0x918
	[CompilerGenerated]
	private SlotObserver <NightVisionObserver>k__BackingField; //Field offset: 0x920
	[CompilerGenerated]
	private string <Location>k__BackingField; //Field offset: 0x928
	[CompilerGenerated]
	private ISpawnPoint <SpawnPoint>k__BackingField; //Field offset: 0x930
	[CompilerGenerated]
	private float <RayLength>k__BackingField; //Field offset: 0x938
	[CompilerGenerated]
	private InteractableObject <InteractableObject>k__BackingField; //Field offset: 0x940
	[CompilerGenerated]
	private bool <InteractableObjectIsProxy>k__BackingField; //Field offset: 0x948
	[CompilerGenerated]
	private SlotObserver <ThermalVisionObserver>k__BackingField; //Field offset: 0x950
	[CompilerGenerated]
	private bool <IsAgressorInLighthouseTraderZone>k__BackingField; //Field offset: 0x958
	[CompilerGenerated]
	private Player <InteractablePlayer>k__BackingField; //Field offset: 0x960
	[CompilerGenerated]
	private PlaceItemTrigger <PlaceItemZone>k__BackingField; //Field offset: 0x968
	[CompilerGenerated]
	private ExfiltrationPoint <ExfiltrationPoint>k__BackingField; //Field offset: 0x970
	[CompilerGenerated]
	private SlotObserver <FaceCoverShieldObserver>k__BackingField; //Field offset: 0x978
	[CompilerGenerated]
	private SlotObserver <FaceCoverMaskObserver>k__BackingField; //Field offset: 0x980
	[CompilerGenerated]
	private bool <ExitTriggerZone>k__BackingField; //Field offset: 0x988
	[CompilerGenerated]
	private MalfunctionRandom <MalfRandoms>k__BackingField; //Field offset: 0x990
	[CompilerGenerated]
	private int <RaidId>k__BackingField; //Field offset: 0x998
	[CompilerGenerated]
	private LastFoundCompletableStorage <LastFoundCompletableStorage>k__BackingField; //Field offset: 0x9A0
	private float _currentBlindnessProtection; //Field offset: 0x9A8
	[CompilerGenerated]
	private string <VoipID>k__BackingField; //Field offset: 0x9B0
	[CompilerGenerated]
	private int <PlayerId>k__BackingField; //Field offset: 0x9B8
	[CompilerGenerated]
	private Profile <Profile>k__BackingField; //Field offset: 0x9C0
	[CompilerGenerated]
	private IStatisticsManager <StatisticsManager>k__BackingField; //Field offset: 0x9C8
	public Action OnStatisticsShot; //Field offset: 0x9D0
	public PhysicalBase Physical; //Field offset: 0x9D8
	[CompilerGenerated]
	private Action OnSpecialPlaceVisited; //Field offset: 0x9E0
	[SerializeField]
	private EUpdateQueue _updateQueue; //Field offset: 0x9E8
	[SerializeField]
	protected EUpdateQueue _armsUpdateQueue; //Field offset: 0x9EC
	[CompilerGenerated]
	private ECameraType <VisibleToCameraType>k__BackingField; //Field offset: 0x9F0
	[CompilerGenerated]
	private bool <IsVisibleToCamera>k__BackingField; //Field offset: 0x9F4
	[SerializeField]
	protected EUpdateMode _armsUpdateMode; //Field offset: 0x9F8
	[SerializeField]
	protected EUpdateMode _bodyUpdateMode; //Field offset: 0x9FC
	[CompilerGenerated]
	private IAIData <AIData>k__BackingField; //Field offset: 0xA00
	[CompilerGenerated]
	private PlayerLoyaltyData <Loyalty>k__BackingField; //Field offset: 0xA08
	[CompilerGenerated]
	private Action OnIPlayerDeadOrUnspawn; //Field offset: 0xA10
	[CompilerGenerated]
	private Dictionary <MainParts>k__BackingField; //Field offset: 0xA18
	protected IHealthController _healthController; //Field offset: 0xA20
	protected BodyPartCollider[] _hitColliders; //Field offset: 0xA28
	protected ArmorPlateCollider[] _armorPlateColliders; //Field offset: 0xA30
	protected PlayerInventoryController _inventoryController; //Field offset: 0xA38
	protected AbstractHandsController _handsController; //Field offset: 0xA40
	protected QuestController _questController; //Field offset: 0xA48
	protected QuestLocationObjectsController _questLocationObjectsController; //Field offset: 0xA50
	protected AchievementsController _achievementsController; //Field offset: 0xA58
	protected PrestigeController _prestigeController; //Field offset: 0xA60
	protected SeasonalRewardController _seasonalRewardController; //Field offset: 0xA68
	protected BaseTraderDialogController _dialogController; //Field offset: 0xA70
	[CompilerGenerated]
	private Action OnHandsControllerChanged; //Field offset: 0xA78
	private string _fullIdInfo; //Field offset: 0xA80
	private string _idInfo; //Field offset: 0xA88
	public Transform Tracking; //Field offset: 0xA90
	private float _awareness; //Field offset: 0xA98
	protected float _bodyTime; //Field offset: 0xA9C
	protected int _nFixedFrames; //Field offset: 0xAA0
	protected float _fixedTime; //Field offset: 0xAA4
	protected bool _armsupdated; //Field offset: 0xAA8
	protected float _armsTime; //Field offset: 0xAAC
	protected bool _bodyupdated; //Field offset: 0xAB0
	private DeltaTimeDelegate _deltaTimeDelegate; //Field offset: 0xAB8
	private WaitForFixedUpdate _waitForFixedUpdate; //Field offset: 0xAC0
	[CompilerGenerated]
	private Action UpdateEvent; //Field offset: 0xAC8
	[CompilerGenerated]
	private Action FixedUpdateEvent; //Field offset: 0xAD0
	protected float LastDeltaTime; //Field offset: 0xAD8
	protected Transform _playerLookRaycastTransform; //Field offset: 0xAE0
	private EDoorState _lastInteractionState; //Field offset: 0xAE8
	private GameObject _cachedInteractable; //Field offset: 0xAF0
	private RaycastHit _cachedInteractableHit; //Field offset: 0xAF8
	private int _cachedInteractableFrame; //Field offset: 0xB24
	[CompilerGenerated]
	private Vector3 <InteractionRayOriginOnStartOperation>k__BackingField; //Field offset: 0xB28
	[CompilerGenerated]
	private Vector3 <InteractionRayDirectionOnStartOperation>k__BackingField; //Field offset: 0xB34
	private bool _nextCastHasForceEvent; //Field offset: 0xB40
	private float _lastStateUpdateTime; //Field offset: 0xB44
	[CompilerGenerated]
	private PlayerBones <PlayerBones>k__BackingField; //Field offset: 0xB48
	private Coroutine _waitInventoryCoroutine; //Field offset: 0xB50
	protected readonly List _preAllocatedArmorComponents; //Field offset: 0xB58
	protected EquipmentPenaltyComponent _preAllocatedBackpackPenaltyComponent; //Field offset: 0xB60
	[CompilerGenerated]
	private Action OnEpInteraction; //Field offset: 0xB68
	[CompilerGenerated]
	private BotsGroup <BotsGroup>k__BackingField; //Field offset: 0xB70
	private bool _gameSessionEndWasCalled; //Field offset: 0xB78
	protected Action ExfilUnsubscribe; //Field offset: 0xB80
	protected List SessionEndUnsubscribe; //Field offset: 0xB88
	protected bool AggressorFound; //Field offset: 0xB90
	[CompilerGenerated]
	private bool <IsYourPlayer>k__BackingField; //Field offset: 0xB91
	[SerializeField]
	public float MyHandsToBodyAngle; //Field offset: 0xB94
	public byte MovementIteration; //Field offset: 0xB98
	public List FoundSecretExits; //Field offset: 0xBA0
	[CompilerGenerated]
	private IPlayerVoipController <VoipController>k__BackingField; //Field offset: 0xBA8
	[CompilerGenerated]
	private DissonanceComms <DissonanceComms>k__BackingField; //Field offset: 0xBB0
	[CompilerGenerated]
	private DateTime <HearingDateTime>k__BackingField; //Field offset: 0xBB8
	[CompilerGenerated]
	private EVoipState <VoipState>k__BackingField; //Field offset: 0xBC0
	private readonly CameraContainerRotator _cameraContainerRotator; //Field offset: 0xBC8
	private readonly BtrSideRotator _btrSideRotator; //Field offset: 0xBD0
	private readonly InvalidCustomRotator _invalidHandRotator; //Field offset: 0xBD8
	private ICustomRotator _customHandRotator; //Field offset: 0xBE0
	[CompilerGenerated]
	private bool <IgnoreCameraCollider>k__BackingField; //Field offset: 0xBE8
	[CompilerGenerated]
	private BTRSide <BtrInteractionSide>k__BackingField; //Field offset: 0xBF0
	[CompilerGenerated]
	private TripwireInteractionTrigger <TripwireInteractionTrigger>k__BackingField; //Field offset: 0xBF8
	[CompilerGenerated]
	private EventObjectInteractive <EventObjectInteractive>k__BackingField; //Field offset: 0xC00
	[CompilerGenerated]
	private Action OnBtrStateChanged; //Field offset: 0xC08
	[CompilerGenerated]
	private Action OnCloseTutorialHint; //Field offset: 0xC10
	[CompilerGenerated]
	private Action OnTutorialHintTriggered; //Field offset: 0xC18
	private EPlayerBtrState _btrState; //Field offset: 0xC20
	private EPlayerBtrState _lastBtrStateInteractionCheck; //Field offset: 0xC24
	private EBtrState _lastBtrStateCheck; //Field offset: 0xC28
	private bool _lastBtrCastResult; //Field offset: 0xC29
	private bool _lastTripwireCastResult; //Field offset: 0xC2A
	private bool _lastEventObjectCastResult; //Field offset: 0xC2B
	[CompilerGenerated]
	private Action OnPlayerTouchGasEvent; //Field offset: 0xC30
	private bool _isUsingLeftHand; //Field offset: 0xC38
	private EProcessStatus _processStatus; //Field offset: 0xC3C
	[CompilerGenerated]
	private AbstractProcess <ScheduledProcess>k__BackingField; //Field offset: 0xC40
	[CompilerGenerated]
	private Slot <ActiveSlot>k__BackingField; //Field offset: 0xC48
	[CompilerGenerated]
	private Action HandsChangingEvent; //Field offset: 0xC50
	[CompilerGenerated]
	private Action HandsChangedEvent; //Field offset: 0xC58
	private Item _lastEquippedWeaponOrKnifeItem; //Field offset: 0xC60
	private readonly EquipmentSlot[] _slotPriority; //Field offset: 0xC68
	protected Callback _removeFromHandsCallback; //Field offset: 0xC70
	private Callback _setInHandsCallback; //Field offset: 0xC78
	private float _lastFaceshieldOperationTime; //Field offset: 0xC80
	private int _faceshieldNumOperations; //Field offset: 0xC84

	public event Action BeingHitAction
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action FixedUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action HandsChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action HandsChangingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnBlindnessProtectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnBtrStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnCloseTutorialHint
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event DamageDelegate OnDamageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnEpInteraction
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnGlassesChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnHandsControllerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnInventoryOpened
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnIPlayerDeadOrUnspawn
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnNearestQuestLootPositionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event OnPlayerDead OnPlayerDead
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event OnPlayerDeadOrUnspawn OnPlayerDeadOrUnspawn
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public static event Action OnPlayerDeadStatic
	{
		[CompilerGenerated]
		 add { } //Length: 374
		[CompilerGenerated]
		 remove { } //Length: 374
	}

	public event Action OnPlayerTouchGasEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public static event Action OnPlayerUnspawnStatic
	{
		[CompilerGenerated]
		 add { } //Length: 374
		[CompilerGenerated]
		 remove { } //Length: 374
	}

	public event Action OnPropVisibility
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSenseChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnShowAmmoCountZeroingPanel
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnShowAmmoDetails
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnShowFireMode
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSightChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSmoothSightChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSpecialPlaceVisited
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSpeedChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStartInventoryOpen
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnStartQuickdrawPistol
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnTacticalInteractionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTutorialHintTriggered
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action PhraseSituation
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action PossibleInteractionsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action UpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override string AccountId
	{
		 get { } //Length: 30
	}

	internal AchievementsController AchievementsController
	{
		internal get { } //Length: 8
	}

	public ActiveHealthController ActiveHealthController
	{
		 get { } //Length: 122
	}

	public private Slot ActiveSlot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IAIData AIData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool AllowToPlantBeacon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private float AnimatorFootstepSign
	{
		private get { } //Length: 125
	}

	public IAnimator ArmsAnimatorCommon
	{
		 get { } //Length: 7
	}

	public override EUpdateMode ArmsUpdateMode
	{
		 get { } //Length: 7
	}

	public override EUpdateQueue ArmsUpdateQueue
	{
		 get { } //Length: 7
	}

	private EAudioCullingMode AudioCullingMode
	{
		private get { } //Length: 37
	}

	public override float Awareness
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public private Vector3 BeaconPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Quaternion BeaconRotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public float BlindnessDuration
	{
		 get { } //Length: 815
	}

	public IAnimator BodyAnimatorCommon
	{
		 get { } //Length: 239
	}

	public EUpdateMode BodyUpdateMode
	{
		 get { } //Length: 7
	}

	public BotsGroup BotsGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private float BotSoundCoefficient
	{
		private get { } //Length: 63
	}

	public BTRSide BtrInteractionSide
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override EPlayerBtrState BtrState
	{
		 get { } //Length: 7
		 set { } //Length: 946
	}

	public private GameObject CameraContainer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Transform CameraPosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool CanBeSnapped
	{
		 get { } //Length: 3
	}

	public float CarryingWeightAbsoluteModifier
	{
		 get { } //Length: 81
	}

	public float CarryingWeightRelativeModifier
	{
		 get { } //Length: 142
	}

	public override ICharacterController CharacterController
	{
		 get { } //Length: 195
	}

	public Func CompassValue
	{
		 get { } //Length: 295
	}

	internal IEnumerable ConditionalControllers
	{
		[IteratorStateMachine(typeof(<get_ConditionalControllers>d__1222))]
		internal get { } //Length: 175
	}

	public int CurrentAnimatorStateIndex
	{
		 get { } //Length: 74
	}

	public Quaternion CurrentHandsRotaion
	{
		 get { } //Length: 769
	}

	public int CurrentHour
	{
		 get { } //Length: 442
	}

	public MovementState CurrentManagedState
	{
		 get { } //Length: 159
	}

	public BaseMovementState CurrentState
	{
		 get { } //Length: 30
	}

	public EPlayerState CurrentStateName
	{
		 get { } //Length: 39
	}

	public private IPlayerCustomAudioSettings CustomAudioSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float DeltaTime
	{
		 get { } //Length: 40
	}

	internal BaseTraderDialogController DialogController
	{
		internal get { } //Length: 8
	}

	private override string Dissonance.IDissonancePlayer.PlayerId
	{
		private get { } //Length: 8
	}

	private override Vector3 Dissonance.IDissonancePlayer.Position
	{
		private get { } //Length: 162
	}

	private override Quaternion Dissonance.IDissonancePlayer.Rotation
	{
		private get { } //Length: 150
	}

	private override NetworkPlayerType Dissonance.IDissonancePlayer.Type
	{
		private get { } //Length: 106
	}

	protected private DissonanceComms DissonanceComms
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override float Distance
	{
		 get { } //Length: 236
	}

	public private EnvironmentType Environment
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected InventoryEquipment Equipment
	{
		 get { } //Length: 54
	}

	public float ErgonomicsPenalty
	{
		 get { } //Length: 9
	}

	public EventObjectInteractive EventObjectInteractive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private GenericEventTranslator EventTranslator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ExfiltrationPoint ExfiltrationPoint
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool ExitTriggerZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public SlotObserver FaceCoverMaskObserver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public SlotObserver FaceCoverShieldObserver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public SlotObserver FaceShieldObserver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BifacialTransform Fireport
	{
		 get { } //Length: 33
	}

	public bool FirstPersonPointOfView
	{
		 get { } //Length: 33
	}

	public ETagStatus Fraction
	{
		 get { } //Length: 79
	}

	public override string FullIdInfo
	{
		 get { } //Length: 7
	}

	public string FullIdInfoClean
	{
		 get { } //Length: 484
	}

	protected private GameWorld GameWorld
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Player GetPlayer
	{
		 get { } //Length: 4
	}

	public override string GroupId
	{
		 get { } //Length: 39
	}

	public ObjectInHandsAnimator HandsAnimator
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public override AbstractHandsController HandsController
	{
		 get { } //Length: 8
		 set { } //Length: 647
	}

	public bool HandsIsEmpty
	{
		 get { } //Length: 143
	}

	public Quaternion HandsRotation
	{
		 get { } //Length: 343
	}

	protected float HandsToBodyAngle
	{
		 get { } //Length: 31
	}

	public bool HasGamePlayerOwner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool HasGlasses
	{
		 get { } //Length: 31
	}

	public override IHealthController HealthController
	{
		 get { } //Length: 8
	}

	public ETagStatus HealthStatus
	{
		 get { } //Length: 436
	}

	protected DateTime HearingDateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IEnumerable HelmetLightControllers
	{
		 get { } //Length: 8
	}

	public override int Id
	{
		 get { } //Length: 7
	}

	public string IdInfo
	{
		 get { } //Length: 420
	}

	public private bool IgnoreCameraCollider
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public string Infiltration
	{
		 get { } //Length: 39
	}

	public Vector2 InputDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private InteractableObject InteractableObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool InteractableObjectIsProxy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Player InteractablePlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override Ray InteractionRay
	{
		 get { } //Length: 503
	}

	public private Vector3 InteractionRayDirectionOnStartOperation
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Vector3 InteractionRayOriginOnStartOperation
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	protected Inventory Inventory
	{
		 get { } //Length: 45
	}

	public override InventoryController InventoryController
	{
		 get { } //Length: 8
	}

	public bool IsAgressorInLighthouseTraderZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsAI
	{
		 get { } //Length: 89
	}

	public bool IsCoughSprintLocked
	{
		 get { } //Length: 89
	}

	public bool IsEnableVaulting
	{
		 get { } //Length: 73
	}

	public bool IsFirstPersonStrapWeaponDeathHoldActive
	{
		 get { } //Length: 18
	}

	public bool IsForwardInputDirection
	{
		 get { } //Length: 18
	}

	public override bool IsInBufferZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsInPronePose
	{
		 get { } //Length: 42
	}

	public bool IsInventoryOpened
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool IsLooking
	{
		 get { } //Length: 5
	}

	public bool IsResettingLook
	{
		 get { } //Length: 5
	}

	public bool IsSprintEnabled
	{
		 get { } //Length: 63
	}

	public override bool IsTracking
	{
		 get { } //Length: 11
	}

	public bool IsUnderRoof
	{
		 get { } //Length: 101
	}

	public bool IsVaultingPressed
	{
		 get { } //Length: 8
	}

	public override bool IsVisible
	{
		 get { } //Length: 69
		 set { } //Length: 3
	}

	public override bool IsVisibleToCamera
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsWeaponOrKnifeInHands
	{
		 get { } //Length: 238
	}

	public override bool IsYourPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public string KillerAccountId
	{
		 get { } //Length: 136
	}

	public string KillerId
	{
		 get { } //Length: 136
	}

	protected override float LandingThreshold
	{
		 get { } //Length: 9
	}

	public private Item LastEquippedWeaponOrKnifeItem
	{
		 get { } //Length: 8
		private set { } //Length: 252
	}

	public private LastFoundCompletableStorage LastFoundCompletableStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ILeftHandController LeftHandController
	{
		 get { } //Length: 8
	}

	public float LeftStanceCurrentCurveValue
	{
		 get { } //Length: 34
	}

	public override Vector3 LocalShotDirection
	{
		 get { } //Length: 50
	}

	public string Location
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Vector3 LookDirection
	{
		 get { } //Length: 47
	}

	public override PlayerLoyaltyData Loyalty
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override Dictionary MainParts
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MalfunctionRandom MalfRandoms
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected override float MINStepSoundSpeedFactor
	{
		 get { } //Length: 9
	}

	public Vector3 Motion
	{
		 get { } //Length: 47
	}

	public bool MouseLookControl
	{
		 get { } //Length: 5
	}

	public MovementContext MovementContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float MovementIdlingTime
	{
		 get { } //Length: 83
	}

	public BifacialTransform[] MultiBarrelFireports
	{
		 get { } //Length: 33
	}

	private int NegativeBuffsCount
	{
		private get { } //Length: 7
		private set { } //Length: 260
	}

	public SlotObserver NightVisionObserver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool OnHisWayToOperateStationaryWeapon
	{
		 get { } //Length: 3
	}

	public bool OnScreen
	{
		 get { } //Length: 32
	}

	public int OwnerId
	{
		 get { } //Length: 7
	}

	public EUpdateQueue PhysicalUpdateQueue
	{
		 get { } //Length: 3
	}

	public float Pitch
	{
		 get { } //Length: 41
	}

	public PlaceItemTrigger PlaceItemZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override PlayerBody PlayerBody
	{
		 get { } //Length: 8
	}

	public override PlayerBones PlayerBones
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private int PlayerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override EPointOfView PointOfView
	{
		 get { } //Length: 57
		 set { } //Length: 954
	}

	public BindableEvent PointOfViewChanged
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public EPlayerPose Pose
	{
		 get { } //Length: 91
	}

	public float PoseLevel
	{
		 get { } //Length: 31
	}

	public private override Vector3 Position
	{
		 get { } //Length: 74
		private set { } //Length: 68
	}

	internal PrestigeController PrestigeController
	{
		internal get { } //Length: 8
	}

	public bool PreventAutoWeaponDraw
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private ProceduralWeaponAnimation ProceduralWeaponAnimation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EProcessStatus ProcessStatus
	{
		 get { } //Length: 7
		private set { } //Length: 86
	}

	public private override Profile Profile
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override string ProfileId
	{
		 get { } //Length: 30
	}

	public override float ProtagonistHearing
	{
		 get { } //Length: 9
	}

	internal QuestController QuestController
	{
		internal get { } //Length: 8
	}

	public float QuestItemSenseSqrDistance
	{
		 get { } //Length: 9
	}

	internal QuestLocationObjectsController QuestLocationObjectsController
	{
		internal get { } //Length: 8
	}

	public override int RaidId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private float RayLength
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public RecodableItemsHandler RecodableItemsHandler
	{
		 get { } //Length: 8
	}

	public override PlayerRecorderController RecorderController
	{
		 get { } //Length: 33
	}

	public override Vector2 Rotation
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector2 RotationPitchLimit
	{
		 get { } //Length: 25
		 set { } //Length: 8
	}

	private AbstractProcess ScheduledProcess
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IPlayerSearchController SearchController
	{
		 get { } //Length: 45
	}

	internal SeasonalRewardController SeasonalRewardController
	{
		internal get { } //Length: 8
	}

	private bool Sense
	{
		private get { } //Length: 8
		private set { } //Length: 360
	}

	private EFTHardSettings Settings
	{
		private get { } //Length: 7
	}

	public override EPlayerSide Side
	{
		 get { } //Length: 38
	}

	public float SinceLastStep
	{
		 get { } //Length: 83
	}

	public SkillManager Skills
	{
		 get { } //Length: 21
	}

	public ISpawnPoint SpawnPoint
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected BetterSource SpeechSource
	{
		 get { } //Length: 234
		 set { } //Length: 82
	}

	public float Speed
	{
		 get { } //Length: 31
	}

	public override float SqrCameraDistance
	{
		 get { } //Length: 204
	}

	public override bool StateIsSuitableForHandInput
	{
		 get { } //Length: 240
	}

	public IStatisticsManager StatisticsManager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Quaternion TargetHandsRotation
	{
		 get { } //Length: 218
	}

	public override string TeamId
	{
		 get { } //Length: 39
	}

	public SlotObserver ThermalVisionObserver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[Obsolete("Use Player.Transform instead!", True)]
	public Transform transform
	{
		 get { } //Length: 78
	}

	public override BifacialTransform Transform
	{
		 get { } //Length: 33
	}

	public TripwireInteractionTrigger TripwireInteractionTrigger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private TripwireVisualPlacer TripwirePlanner
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string TryGetId
	{
		 get { } //Length: 183
	}

	public IAnimator UnderbarrelWeaponArmsAnimator
	{
		 get { } //Length: 8
	}

	public EUpdateQueue UpdateQueue
	{
		 get { } //Length: 7
	}

	public private bool UsedSimplifiedSkeleton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public IVaultingComponent VaultingComponent
	{
		 get { } //Length: 8
	}

	public IVaultingComponentDebug VaultingComponentDebug
	{
		 get { } //Length: 8
	}

	public IVaultingGameplayRestrictions VaultingGameplayRestrictions
	{
		 get { } //Length: 8
	}

	public IVaultingParameters VaultingParameters
	{
		 get { } //Length: 8
	}

	public override Vector3 Velocity
	{
		 get { } //Length: 141
	}

	public override ECameraType VisibleToCameraType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override AudioSource VoipAudioSource
	{
		 get { } //Length: 8
		 set { } //Length: 723
	}

	public IPlayerVoipController VoipController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private string VoipID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected EVoipState VoipState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public IWeaponMountingComponent WeaponMountingComponent
	{
		 get { } //Length: 8
	}

	public override BifacialTransform WeaponRoot
	{
		 get { } //Length: 33
	}

	public float Yaw
	{
		 get { } //Length: 41
	}

	private static Player() { }

	public Player() { }

	[CompilerGenerated]
	private void <BtrInteractionRaycast>g__Reset|1552_0() { }

	[CompilerGenerated]
	private void <ConnectSkillManager>b__1409_0(FlareShootZoneEvent invokedEvent) { }

	[CompilerGenerated]
	private void <EventObjectInteractionRaycast>g__Reset|1554_0() { }

	[CompilerGenerated]
	private void <HealthControllerOnEffectAddedEvent>b__1412_0() { }

	[CompilerGenerated]
	private void <HealthControllerOnEffectAddedEvent>b__1412_1() { }

	[CompilerGenerated]
	private void <InitHandsContainer>b__500_0(int i) { }

	[CompilerGenerated]
	private bool <InitVaultingComponent>b__1082_0() { }

	[CompilerGenerated]
	private bool <InitVaultingComponent>b__1082_1() { }

	[CompilerGenerated]
	private bool <InitVaultingComponent>b__1082_2() { }

	[CompilerGenerated]
	private void <MovementContextOnStateChanged>b__1434_0() { }

	[CompilerGenerated]
	private void <OnGameSessionEnd>b__1405_0() { }

	[CompilerGenerated]
	private void <OnGameSessionEnd>b__1405_1() { }

	[CompilerGenerated]
	private void <OnHealthEffectRemoved>b__1106_0() { }

	[CompilerGenerated]
	private void <OnMagazineCheckHandler>b__1419_0() { }

	[CompilerGenerated]
	private EmptyHandsController <Proceed>b__1621_0() { }

	[CompilerGenerated]
	private void <set_NegativeBuffsCount>b__1314_0() { }

	[CompilerGenerated]
	private void <set_NegativeBuffsCount>b__1314_1() { }

	[CompilerGenerated]
	private void <set_VoipAudioSource>b__685_0(bool enable) { }

	[CompilerGenerated]
	private void <SetEmptyHands>b__1591_0(Result result) { }

	[CompilerGenerated]
	private void <StatisticsManagerOnOnUniqueLoot>b__1420_0() { }

	[CompilerGenerated]
	private void <StopInteractionSound>g__ReleaseSource|758_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<SwitchHeadLightsAnimation>g__DelayedInvocation|498_0>d))]
	private IEnumerator <SwitchHeadLightsAnimation>g__DelayedInvocation|498_0() { }

	[CompilerGenerated]
	private void <TripwireInteractionRaycast>g__Reset|1553_0() { }

	[CompilerGenerated]
	public void add_BeingHitAction(Action value) { }

	[CompilerGenerated]
	public void add_FixedUpdateEvent(Action value) { }

	[CompilerGenerated]
	public void add_HandsChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_HandsChangingEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnBlindnessProtectionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnBtrStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnCloseTutorialHint(Action value) { }

	[CompilerGenerated]
	public void add_OnDamageReceived(DamageDelegate value) { }

	[CompilerGenerated]
	public void add_OnEpInteraction(Action value) { }

	[CompilerGenerated]
	public void add_OnGlassesChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnHandsControllerChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnInventoryOpened(Action value) { }

	[CompilerGenerated]
	public override void add_OnIPlayerDeadOrUnspawn(Action value) { }

	[CompilerGenerated]
	public void add_OnNearestQuestLootPositionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerDead(OnPlayerDead value) { }

	[CompilerGenerated]
	public void add_OnPlayerDeadOrUnspawn(OnPlayerDeadOrUnspawn value) { }

	[CompilerGenerated]
	public static void add_OnPlayerDeadStatic(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerTouchGasEvent(Action value) { }

	[CompilerGenerated]
	public static void add_OnPlayerUnspawnStatic(Action value) { }

	[CompilerGenerated]
	public void add_OnPropVisibility(Action value) { }

	[CompilerGenerated]
	public void add_OnSenseChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnShowAmmoCountZeroingPanel(Action value) { }

	[CompilerGenerated]
	public void add_OnShowAmmoDetails(Action value) { }

	[CompilerGenerated]
	public void add_OnShowFireMode(Action value) { }

	[CompilerGenerated]
	public void add_OnSightChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnSmoothSightChange(Action value) { }

	[CompilerGenerated]
	public void add_OnSpecialPlaceVisited(Action value) { }

	[CompilerGenerated]
	public void add_OnSpeedChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnStartInventoryOpen(Action value) { }

	[CompilerGenerated]
	public void add_OnStartQuickdrawPistol(Action value) { }

	[CompilerGenerated]
	public void add_OnTacticalInteractionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnTutorialHintTriggered(Action value) { }

	[CompilerGenerated]
	public void add_PhraseSituation(Action value) { }

	[CompilerGenerated]
	public void add_PossibleInteractionsChanged(Action value) { }

	[CompilerGenerated]
	public void add_UpdateEvent(Action value) { }

	public void AddAlly(IPlayer enemy) { }

	public override void AddDetailedHitInfo(EDamageType damageType, int d, int absorbed, int staminaLoss, EBodyPart part, MaterialType special) { }

	public bool AddDiscoveredSecretExit(SecretExfiltrationPoint secretExfiltrationPoint) { }

	public void AddMouseSensitivityModifier(EMouseSensitivityModifier type, float value) { }

	public override void AddStateSpeedLimit(float speedDelta, ESpeedLimit cause) { }

	public void AddTearGasErgonomicsPenalty(float delta) { }

	public void AddTriggerZone(TriggerWithId zone) { }

	private void AddVoiceBroadcastTrigger() { }

	public void AddVolume(BetterPropagationVolume volume) { }

	private void AdjustElbows(float curveWeight, float elbowLeftWeight, float elbowRightWeight) { }

	private void AdjustUtilityLayerWeight(float distance) { }

	public override void AfterMainTick() { }

	private void AggressorLoyalty(DamageInfo damageInfo, EBodyPart bodyPart, Player aggressor) { }

	private static void AlignFirstPersonWeaponToRightPalm(Transform weaponTransform, TransformLinks links, PlayerBones playerBones) { }

	protected override void ApplyCorpseImpulse() { }

	public override void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, float absorbed) { }

	public override void ApplyExplosionDamageToArmor(Dictionary armorDamage, DamageInfo damageInfo) { }

	private void ApplyFirstPersonDeathHoldLeftShoulderSplay() { }

	public override void ApplyHitDebuff(float damage, float staminaBurnRate, EBodyPart bodyPartType, EDamageType damageType) { }

	private static void ApplyLocalSceneIkPostBatch(int startQueueIndex, int endQueueIndex) { }

	public override ValueTuple ApplyLookLimit(EFTHardSettings hardSettings) { }

	private void ApplyQuickUseItem(Item item, Callback callback) { }

	public override PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

	private void ApplyUnderRoofStatus() { }

	private void ArmsLateUpdate(float deltaTime) { }

	public override void ArmsUpdate(float deltaTime) { }

	public void AttachDeadHandsItemToCorpseForSpectate() { }

	private void BackpackDropEventHandler(IAnimatorEventParameter animatorEventParameter) { }

	private static void BeginLocalSceneIkBatchFrame() { }

	private static void BeginLocalSceneIkLateUpdate(Player player) { }

	private RemoveFromHandsOperation BeginRemoveFromHands(Item item) { }

	private SetInHandsOperation BeginSetInHands(Item item) { }

	public void BindSlotViewChangedAction(EquipmentSlot slot, Action action) { }

	public override void Board(MovingPlatform platform) { }

	public override void BodyUpdate(float deltaTime, int loop = 1) { }

	internal override void BtrInteraction(BTRSide btr, byte placeId, EInteractionType interaction) { }

	private void BtrInteractionRaycast(GameObject interactive) { }

	private float CalculateMovementRolloff(EAudioMovementState movementState = 0, bool includeSpeedMult = false) { }

	private ValueTuple CalculateMovementSurface() { }

	private float CalculateMovementVolumeDefaultMultiplier(EAudioMovementState movementState) { }

	private Vector3 CalculatePosWithSpeechOffset() { }

	public void CalculateScaleValueByFov(float fov) { }

	private float CalculateSpeedMult() { }

	private float CalculateStepSoundSpeedRolloffMult() { }

	private float CalculateStepSoundVolumeSpeedFactor() { }

	private float CalculateWalkGearVolume(float speed) { }

	private static void Call(Result result, Callback callback) { }

	internal override void CancelDoorInteraction(WorldInteractiveObject door, InteractionResult interactionResult) { }

	protected bool CanPerformAnimatedOperation(Item item, AbstractOperation operation) { }

	private bool CanPlayLandingSound(float landingHeight) { }

	public void ChangePose(float poseDelta) { }

	public void ChangeSpeed(float speedDelta) { }

	public bool CheckArmorHitByDirection(BodyPartCollider bodyPart) { }

	private void CheckBlindnessProtection() { }

	private bool CheckIsHeard(in Vector3 voicePos, float sqrDistance) { }

	protected override bool CheckSurface(float range) { }

	public void ClearHands() { }

	public void ClearPlanting() { }

	public void CloseTutorialHint(string trigger = null) { }

	protected override void ComplexLateUpdate(EUpdateQueue queue, float deltaTime) { }

	public void ComplexUpdate(EUpdateQueue queue, float deltaTime) { }

	private void ConnectInventoryOperationEvents() { }

	protected override void ConnectSkillManager() { }

	private static TPlayer Create(GameWorld gameWorld, GameObject poolObject, int playerId, Vector3 position, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, bool isThirdPerson, bool useSimplifiedSkeleton = false) { }

	protected static TPlayer Create(GameWorld gameWorld, ResourceKey assetName, int playerId, Vector3 position, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, string prefix, bool isThirdPerson, bool useSimplifiedSkeleton = false) { }

	public GameObject CreateBeacon(Item item, Vector3 position) { }

	private void CreateBodyAnimator(bool aiControlled) { }

	public void CreateCompass() { }

	protected T CreateCorpse(Vector3 velocity) { }

	protected override Corpse CreateCorpse() { }

	private void CreateDefaultAnimator() { }

	private void CreateFastAnimator() { }

	protected void CreateGearSource() { }

	protected override void CreateMovementContext() { }

	protected override void CreateNestedSource() { }

	protected override PhysicalBase CreatePhysical() { }

	public TripwireVisualPlacer CreatePlantPlanner() { }

	protected override void CreateSlotObservers() { }

	protected override void CreateSpeechSource() { }

	private void CreateTripwireController() { }

	public void Crutch_FinalizeStationaryWeapState(StationaryWeaponPacket swPacket) { }

	public override void DebugSnapshotAllPlayers() { }

	public override void DebugSpawnAirdrop(bool spawnNearPlayer, Vector3 playerPosition) { }

	public void DefaultPlay(SoundBank bank, float volume = 1, EAudioMovementState movementState = 0) { }

	public void DestroyBeacon() { }

	protected void DestroyController() { }

	private void DestroyHandsController() { }

	private void DetectActiveSlot(Item item) { }

	public override void DevelopChangeHealthFactor(EHealthFactorType type, float value) { }

	public override void DevelopLockDoors() { }

	public override void DevelopResetDiscardLimits() { }

	public override void DevelopSetActiveLighthouseTraderZoneDebug(bool value) { }

	public override void DevelopSetEncodedRadioTransmitter(bool value) { }

	public override void DevelopUnlockDoors(bool openDoors) { }

	private void DisableVaulting() { }

	private void DisconnectInventoryOperationEvents() { }

	public override void Dispose() { }

	private void DisposeAudio() { }

	private static void DisposeLocalSceneIkBatchRuntime() { }

	private void DisposeVaultingAudioControllers() { }

	private override string Dissonance.IDissonancePlayer.get_PlayerId() { }

	private override Vector3 Dissonance.IDissonancePlayer.get_Position() { }

	private override Quaternion Dissonance.IDissonancePlayer.get_Rotation() { }

	private override NetworkPlayerType Dissonance.IDissonancePlayer.get_Type() { }

	public void DropBackpack() { }

	protected override void DropCurrentController(Action callback, bool fastDrop, Item nextControllerItem = null) { }

	public void DropItemDead(Item item, GameObject prefab) { }

	private void DropItemDeadInternal(Item item, GameObject prefab) { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private override void EFT.ISetInHandsHandler.OnSetInHands(SetInHandsEventArgs eventArgs) { }

	public void EnableSprint(bool enable) { }

	private void EnableVaulting() { }

	private static void EndLocalSceneIkLateUpdate(Player player) { }

	private static void EnqueueLocalSceneFovPlayer(Player player) { }

	private static void EnqueueLocalSceneIkPlayer(Player player, float distanceToCamera) { }

	private static void EnsureLocalSceneIkBatchRuntime() { }

	private void EnterMountedStateHandler(float timeToMount) { }

	internal override void EventObjectInteraction(EventObjectController controller, int objectId, EInteraction interaction) { }

	private void EventObjectInteractionRaycast(GameObject interactive) { }

	internal override void ExecuteInteraction(WorldInteractiveObject door, InteractionResult interactionResult) { }

	private static void ExecuteLocalSceneFovBatch() { }

	private static void ExecuteLocalSceneIkBatch() { }

	private static void ExecuteLocalSceneIkBatchInternal(int startQueueIndex, int endQueueIndex) { }

	public override void ExecuteShotSkill(Item weapon) { }

	public override void ExecuteSkill(Action action) { }

	public override void ExecuteSkill(Action action) { }

	private void ExitMountedStateHandler(float timeToUnmount) { }

	public void ExitTriggerStatusChanged(bool status) { }

	public override void ExternalInteraction() { }

	private void FaceCoverMaskStateUpdate() { }

	private void FaceCoverShieldStateUpdate() { }

	public override void FaceshieldMarkOperation(FaceShieldComponent armor, bool hasServerOrigin) { }

	private void FaceShieldStateUpdate() { }

	[IteratorStateMachine(typeof(<FakeCallbackCoroutine>d__1645))]
	public IEnumerator FakeCallbackCoroutine() { }

	public void FastForwardCurrentOperations() { }

	public void FastForwardOutdatedOperation() { }

	public void FastForwardToStationaryWeapon(Item item, Vector2 stationaryRotation, Quaternion playerRotation, Quaternion stationaryPlayerRotation) { }

	public void FBBIKUpdate(float distance) { }

	public override CultistAmulet FindCultistAmulet() { }

	public override Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	public override RadioTransmitterRecodableComponent FindRadioTransmitter() { }

	private void FixedUpdate() { }

	public override void FixedUpdateTick() { }

	public void ForceDrawWeapon() { }

	public void ForceInteractionsChanged() { }

	[IteratorStateMachine(typeof(<Gear>d__790))]
	private IEnumerator Gear(float volume = 1) { }

	public override string get_AccountId() { }

	internal AchievementsController get_AchievementsController() { }

	public ActiveHealthController get_ActiveHealthController() { }

	[CompilerGenerated]
	public Slot get_ActiveSlot() { }

	[CompilerGenerated]
	public override IAIData get_AIData() { }

	[CompilerGenerated]
	public bool get_AllowToPlantBeacon() { }

	private float get_AnimatorFootstepSign() { }

	public IAnimator get_ArmsAnimatorCommon() { }

	public override EUpdateMode get_ArmsUpdateMode() { }

	public override EUpdateQueue get_ArmsUpdateQueue() { }

	private EAudioCullingMode get_AudioCullingMode() { }

	public override float get_Awareness() { }

	[CompilerGenerated]
	public Vector3 get_BeaconPosition() { }

	[CompilerGenerated]
	public Quaternion get_BeaconRotation() { }

	public float get_BlindnessDuration() { }

	public IAnimator get_BodyAnimatorCommon() { }

	public EUpdateMode get_BodyUpdateMode() { }

	[CompilerGenerated]
	public BotsGroup get_BotsGroup() { }

	private float get_BotSoundCoefficient() { }

	[CompilerGenerated]
	public BTRSide get_BtrInteractionSide() { }

	public override EPlayerBtrState get_BtrState() { }

	[CompilerGenerated]
	public GameObject get_CameraContainer() { }

	[CompilerGenerated]
	public Transform get_CameraPosition() { }

	public override bool get_CanBeSnapped() { }

	public float get_CarryingWeightAbsoluteModifier() { }

	public float get_CarryingWeightRelativeModifier() { }

	public override ICharacterController get_CharacterController() { }

	public Func get_CompassValue() { }

	[IteratorStateMachine(typeof(<get_ConditionalControllers>d__1222))]
	internal IEnumerable get_ConditionalControllers() { }

	public int get_CurrentAnimatorStateIndex() { }

	public Quaternion get_CurrentHandsRotaion() { }

	public int get_CurrentHour() { }

	public MovementState get_CurrentManagedState() { }

	public BaseMovementState get_CurrentState() { }

	public EPlayerState get_CurrentStateName() { }

	[CompilerGenerated]
	public IPlayerCustomAudioSettings get_CustomAudioSettings() { }

	public float get_DeltaTime() { }

	internal BaseTraderDialogController get_DialogController() { }

	[CompilerGenerated]
	protected DissonanceComms get_DissonanceComms() { }

	protected override float get_Distance() { }

	[CompilerGenerated]
	public EnvironmentType get_Environment() { }

	protected InventoryEquipment get_Equipment() { }

	public float get_ErgonomicsPenalty() { }

	[CompilerGenerated]
	public EventObjectInteractive get_EventObjectInteractive() { }

	[CompilerGenerated]
	public GenericEventTranslator get_EventTranslator() { }

	[CompilerGenerated]
	public ExfiltrationPoint get_ExfiltrationPoint() { }

	[CompilerGenerated]
	public bool get_ExitTriggerZone() { }

	[CompilerGenerated]
	public SlotObserver get_FaceCoverMaskObserver() { }

	[CompilerGenerated]
	public SlotObserver get_FaceCoverShieldObserver() { }

	[CompilerGenerated]
	public SlotObserver get_FaceShieldObserver() { }

	public BifacialTransform get_Fireport() { }

	public bool get_FirstPersonPointOfView() { }

	public ETagStatus get_Fraction() { }

	public override string get_FullIdInfo() { }

	public string get_FullIdInfoClean() { }

	[CompilerGenerated]
	protected GameWorld get_GameWorld() { }

	public Player get_GetPlayer() { }

	public override string get_GroupId() { }

	public ObjectInHandsAnimator get_HandsAnimator() { }

	public override AbstractHandsController get_HandsController() { }

	public bool get_HandsIsEmpty() { }

	public Quaternion get_HandsRotation() { }

	protected float get_HandsToBodyAngle() { }

	[CompilerGenerated]
	public bool get_HasGamePlayerOwner() { }

	public bool get_HasGlasses() { }

	public override IHealthController get_HealthController() { }

	public ETagStatus get_HealthStatus() { }

	[CompilerGenerated]
	protected DateTime get_HearingDateTime() { }

	public IEnumerable get_HelmetLightControllers() { }

	public override int get_Id() { }

	public string get_IdInfo() { }

	[CompilerGenerated]
	public bool get_IgnoreCameraCollider() { }

	public string get_Infiltration() { }

	[CompilerGenerated]
	public Vector2 get_InputDirection() { }

	[CompilerGenerated]
	public InteractableObject get_InteractableObject() { }

	[CompilerGenerated]
	public bool get_InteractableObjectIsProxy() { }

	[CompilerGenerated]
	public Player get_InteractablePlayer() { }

	protected override Ray get_InteractionRay() { }

	[CompilerGenerated]
	public Vector3 get_InteractionRayDirectionOnStartOperation() { }

	[CompilerGenerated]
	public Vector3 get_InteractionRayOriginOnStartOperation() { }

	protected Inventory get_Inventory() { }

	public override InventoryController get_InventoryController() { }

	[CompilerGenerated]
	public bool get_IsAgressorInLighthouseTraderZone() { }

	public override bool get_IsAI() { }

	public bool get_IsCoughSprintLocked() { }

	public bool get_IsEnableVaulting() { }

	public bool get_IsFirstPersonStrapWeaponDeathHoldActive() { }

	public bool get_IsForwardInputDirection() { }

	[CompilerGenerated]
	public override bool get_IsInBufferZone() { }

	public bool get_IsInPronePose() { }

	public bool get_IsInventoryOpened() { }

	public bool get_IsLooking() { }

	public bool get_IsResettingLook() { }

	public bool get_IsSprintEnabled() { }

	public override bool get_IsTracking() { }

	public bool get_IsUnderRoof() { }

	public bool get_IsVaultingPressed() { }

	public override bool get_IsVisible() { }

	[CompilerGenerated]
	public override bool get_IsVisibleToCamera() { }

	public bool get_IsWeaponOrKnifeInHands() { }

	[CompilerGenerated]
	public override bool get_IsYourPlayer() { }

	public string get_KillerAccountId() { }

	public string get_KillerId() { }

	protected override float get_LandingThreshold() { }

	public Item get_LastEquippedWeaponOrKnifeItem() { }

	[CompilerGenerated]
	public LastFoundCompletableStorage get_LastFoundCompletableStorage() { }

	public ILeftHandController get_LeftHandController() { }

	public float get_LeftStanceCurrentCurveValue() { }

	public override Vector3 get_LocalShotDirection() { }

	[CompilerGenerated]
	public string get_Location() { }

	public override Vector3 get_LookDirection() { }

	[CompilerGenerated]
	public override PlayerLoyaltyData get_Loyalty() { }

	[CompilerGenerated]
	public override Dictionary get_MainParts() { }

	[CompilerGenerated]
	public MalfunctionRandom get_MalfRandoms() { }

	protected override float get_MINStepSoundSpeedFactor() { }

	public Vector3 get_Motion() { }

	public bool get_MouseLookControl() { }

	[CompilerGenerated]
	public MovementContext get_MovementContext() { }

	public float get_MovementIdlingTime() { }

	public BifacialTransform[] get_MultiBarrelFireports() { }

	private int get_NegativeBuffsCount() { }

	[CompilerGenerated]
	public SlotObserver get_NightVisionObserver() { }

	public override bool get_OnHisWayToOperateStationaryWeapon() { }

	public bool get_OnScreen() { }

	public int get_OwnerId() { }

	public EUpdateQueue get_PhysicalUpdateQueue() { }

	public float get_Pitch() { }

	[CompilerGenerated]
	public PlaceItemTrigger get_PlaceItemZone() { }

	public override PlayerBody get_PlayerBody() { }

	[CompilerGenerated]
	public override PlayerBones get_PlayerBones() { }

	[CompilerGenerated]
	public int get_PlayerId() { }

	public override EPointOfView get_PointOfView() { }

	[CompilerGenerated]
	public BindableEvent get_PointOfViewChanged() { }

	public EPlayerPose get_Pose() { }

	public float get_PoseLevel() { }

	public override Vector3 get_Position() { }

	internal PrestigeController get_PrestigeController() { }

	[CompilerGenerated]
	public bool get_PreventAutoWeaponDraw() { }

	[CompilerGenerated]
	public ProceduralWeaponAnimation get_ProceduralWeaponAnimation() { }

	public EProcessStatus get_ProcessStatus() { }

	[CompilerGenerated]
	public override Profile get_Profile() { }

	public override string get_ProfileId() { }

	public override float get_ProtagonistHearing() { }

	internal QuestController get_QuestController() { }

	public float get_QuestItemSenseSqrDistance() { }

	internal QuestLocationObjectsController get_QuestLocationObjectsController() { }

	[CompilerGenerated]
	public override int get_RaidId() { }

	[CompilerGenerated]
	public float get_RayLength() { }

	public RecodableItemsHandler get_RecodableItemsHandler() { }

	public override PlayerRecorderController get_RecorderController() { }

	public override Vector2 get_Rotation() { }

	public Vector2 get_RotationPitchLimit() { }

	[CompilerGenerated]
	private AbstractProcess get_ScheduledProcess() { }

	public override IPlayerSearchController get_SearchController() { }

	internal SeasonalRewardController get_SeasonalRewardController() { }

	private bool get_Sense() { }

	private EFTHardSettings get_Settings() { }

	public override EPlayerSide get_Side() { }

	public float get_SinceLastStep() { }

	public SkillManager get_Skills() { }

	[CompilerGenerated]
	public ISpawnPoint get_SpawnPoint() { }

	protected BetterSource get_SpeechSource() { }

	public float get_Speed() { }

	public override float get_SqrCameraDistance() { }

	public override bool get_StateIsSuitableForHandInput() { }

	[CompilerGenerated]
	public IStatisticsManager get_StatisticsManager() { }

	public Quaternion get_TargetHandsRotation() { }

	public override string get_TeamId() { }

	[CompilerGenerated]
	public SlotObserver get_ThermalVisionObserver() { }

	public Transform get_transform() { }

	public override BifacialTransform get_Transform() { }

	[CompilerGenerated]
	public TripwireInteractionTrigger get_TripwireInteractionTrigger() { }

	[CompilerGenerated]
	private TripwireVisualPlacer get_TripwirePlanner() { }

	public string get_TryGetId() { }

	public IAnimator get_UnderbarrelWeaponArmsAnimator() { }

	public EUpdateQueue get_UpdateQueue() { }

	[CompilerGenerated]
	public bool get_UsedSimplifiedSkeleton() { }

	public IVaultingComponent get_VaultingComponent() { }

	public IVaultingComponentDebug get_VaultingComponentDebug() { }

	public IVaultingGameplayRestrictions get_VaultingGameplayRestrictions() { }

	public IVaultingParameters get_VaultingParameters() { }

	public override Vector3 get_Velocity() { }

	[CompilerGenerated]
	public override ECameraType get_VisibleToCameraType() { }

	public override AudioSource get_VoipAudioSource() { }

	[CompilerGenerated]
	public IPlayerVoipController get_VoipController() { }

	[CompilerGenerated]
	public string get_VoipID() { }

	[CompilerGenerated]
	protected EVoipState get_VoipState() { }

	public IWeaponMountingComponent get_WeaponMountingComponent() { }

	public override BifacialTransform get_WeaponRoot() { }

	public float get_Yaw() { }

	public override IAnimator GetArmsAnimatorCommon() { }

	public RuntimeAnimatorController GetArmsAnimatorControllerCommon() { }

	private float GetAverageRotationSpeed() { }

	public float GetBlindnessProtection() { }

	public IAnimator GetBodyAnimatorCommon() { }

	private float GetCachedRolloff(EAudioMovementState movementState) { }

	public ICharacterController GetCharacterControllerCommon() { }

	public float GetCharacterSpeedMultiplier() { }

	private float GetCurveValue(int hash) { }

	protected HeadphonesApplyContext GetHeadphonesTemplateFromEquipment(InventoryEquipment equipment) { }

	public override void GetOff(MovingPlatform platform) { }

	public List GetPropagationVolume() { }

	public override void GetRadioTransmitterStatusFromServer() { }

	public float GetRotationMultiplier() { }

	private BetterSource GetSearchSource(AudioClip clip) { }

	public override int GetSessionExperienceForExitPrediction() { }

	public TriggerColliderSearcher GetTriggerColliderSearcher() { }

	public static ECameraType GetVisibleToCamera(IPlayer player) { }

	protected EWeaponAnimationType GetWeaponAnimationType(AbstractHandsController handsController) { }

	protected override void GroundedStateHandler(float fallHeight, float jumpHeight) { }

	public override void HandleFlareSuccessEvent(Vector3 position, AmmoTemplate ammoTemplate) { }

	private void HandleSeasonController() { }

	private bool HasBindedCompass() { }

	public bool HasBodyPartCollider(Collider collider) { }

	public bool HasFirearmInHands() { }

	public override bool HasMarkOfUnknown(out MarkOfUnknown markOfUnknown) { }

	internal bool HaveItemInSlot(EBoundItem slot) { }

	internal bool HaveItemInSlot(EquipmentSlot slot) { }

	public override void Heal(EBodyPart bodyPart, float value) { }

	private void HealthControllerOnBodyPartDestroyedEvent(EBodyPart arg1, EDamageType arg2) { }

	private void HealthControllerOnBodyPartRestoredEvent(EBodyPart arg1, ValueStruct arg2) { }

	private void HealthControllerOnEffectAddedEvent(IHealthEffect obj) { }

	private void HealthControllerOnEffectRemovedEvent(IHealthEffect obj) { }

	protected override void HealthControllerUpdate(float deltaTime) { }

	private void HealthEffectRemovedHandler(IHealthEffect healthEffect) { }

	private void HealthEffectStartedHandler(IHealthEffect healthEffect) { }

	public void HeightInterpolation(float timeDeltatime) { }

	public void HideWeapon() { }

	[IteratorStateMachine(typeof(<HitDelay>d__463))]
	public IEnumerator HitDelay(Action callback) { }

	[IteratorStateMachine(typeof(<Idle>d__792))]
	private IEnumerator Idle(EPlayerState state = 1) { }

	private void IkApply(float d) { }

	private void IkProcess(float distance2Camera) { }

	public void IkStoreRaw() { }

	public void IncreaseAwareness(float aware = 5) { }

	[IteratorStateMachine(typeof(<InflictSelfDamage>d__1433))]
	public IEnumerator InflictSelfDamage() { }

	[AsyncStateMachine(typeof(<Init>d__1078))]
	protected override Task Init(Quaternion rotation, string layerName, EPointOfView pointOfView, int playerRaidId, Profile profile, PlayerInventoryController inventoryController, IHealthController healthController, IStatisticsManager statisticsManager, QuestController questController, QuestLocationObjectsController questLocationObjectsController, AchievementsController achievementsController, PrestigeController prestigeController, BaseTraderDialogController dialogController, ICustomizationFilter filter, EVoipState voipState, bool aiControlled = false, bool async = true, SeasonalRewardController seasonalRewardController = null) { }

	protected override void InitAudioController() { }

	protected override void InitAudioSources() { }

	public void InitFirstTripwirePoint() { }

	private void InitGlobalsPlayerAudioSettings() { }

	private void InitHandsContainer() { }

	protected override void InitializeLeftHandController() { }

	public void InitializeRecodableItemHandlers() { }

	private void InitMovementController() { }

	private void InitSeasonStepLayerController(ESeasonStatus seasonStatus) { }

	public void InitVaultingAudioControllers(IVaultingParameters vaultingParams) { }

	protected override void InitVaultingComponent(bool aiControlled) { }

	private void InitVisuals(EPointOfView pointOfView) { }

	protected override void InitVoip(EVoipState voipState) { }

	private void InitWeaponMountingComponent(bool aiControlled) { }

	public override void Interact(IItemOwner loot, Callback callback) { }

	public override void InteractionRaycast() { }

	private void InvalidateLocalSceneIkSolverCache() { }

	private void InventoryControllerOnItemFound(Item item) { }

	private void InventoryControllerOnSearchEvent() { }

	public void InventoryOpenRaiseAction(bool opened) { }

	private bool IsAiUseSimpleSkeleton() { }

	private bool IsBankNull(SoundBank bank, EAudioMovementState movementState) { }

	private bool IsBleedingBlockedByLightArmor(EBodyPartColliderType colliderType) { }

	public ValueTuple IsHeard(in Vector3 voicePos, float sqrDistance) { }

	private bool IsItemCanBeEquipped(Item itemToCheck) { }

	public override bool IsNonTrainingPlayer() { }

	private bool IsOutOfProtagonistsRange(float spreadRange) { }

	private bool IsPrevStateClimb() { }

	public bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed) { }

	protected override bool IsVisibleByCullingObject(float cullingDistance) { }

	public void Jump() { }

	public override void KillAIs() { }

	public override void KillMe(EBodyPartColliderType colliderType, float damage) { }

	protected override void LandingAdjustments(float d) { }

	[IteratorStateMachine(typeof(<LateFixedUpdateRoutine>d__1263))]
	private IEnumerator LateFixedUpdateRoutine() { }

	protected override void LateUpdate() { }

	public void LockSprintForCough(float duration) { }

	public override void Look(float deltaLookY, float deltaLookX, bool withReturn = true) { }

	protected override void ManageAggressor(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType colliderType) { }

	[AsyncStateMachine(typeof(<ManageGameQuests>d__1429))]
	public Task ManageGameQuests() { }

	public override void ManualUpdate(float deltaTime, Nullable platformDeltaTime = null, int loop = 1) { }

	public override void MouseLook(bool forceApplyToOriginalRibcage = false) { }

	public override void Move(Vector2 direction) { }

	private void MovementContextOnOnStateChanged(EPlayerState previousState, EPlayerState nextState) { }

	private void MovementContextOnStateChanged(EPlayerState previousState, EPlayerState nextState) { }

	private void MovementUpdate(float deltaTime) { }

	public void NeedRepairMalfPhraseSituation(EMalfunctionState malfState, bool isKnown) { }

	public override void OnAnimatedInteraction(EInteraction interaction) { }

	private void OnArmorDamaged(float armorDamage, ArmorComponent armorComponent) { }

	protected override void OnArmorPointsChanged(ArmorComponent armor, bool children = false) { }

	private void OnAudioHealthApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void OnAudioHealthDied(EDamageType damageType) { }

	protected override void OnBeenKilledByAggressor(IPlayer aggressor, DamageInfo damageInfo, EBodyPart bodyPart, EDamageType lethalDamageType) { }

	public override void OnChangeRadioTransmitterState(bool isEncoded, RadioTransmitterStatus status, bool isAgressor) { }

	private void OnControllerColliderHit(ControllerColliderHit hit) { }

	protected override void OnDead(EDamageType damageType) { }

	[IteratorStateMachine(typeof(<OnDeadCoroutine>d__1366))]
	private IEnumerator OnDeadCoroutine(bool needDropItem) { }

	public override void OnDeserializeFromServer(byte channelId, IBitReaderStream reader) { }

	protected override void OnDestroy() { }

	protected override void OnFovUpdatedEvent(int fov) { }

	private void OnGameSessionBegin() { }

	[AsyncStateMachine(typeof(<OnGameSessionEnd>d__1405))]
	public override Task OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	private void OnGrounded(float fallHeight, float jumpHeight) { }

	private void OnHealthApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void OnHealthChanged(EBodyPart bodyPart, float diff, DamageInfo damageInfo) { }

	private void OnHealthControllerOnStimulatorBuffActivationEvent(IStimulatorBuff buff) { }

	public override void OnHealthEffectAdded(IHealthEffect effect) { }

	public override void OnHealthEffectRemoved(IHealthEffect effect) { }

	public override void OnHealthEffectVisualAdded(IHealthEffect effect) { }

	public override void OnHealthEffectVisualRemoved(IHealthEffect effect) { }

	private void OnHealthEnergyChanged(float diff) { }

	private void OnHealthHydrationChanged(float diff) { }

	private void OnHelmetViewChange(GameObject _) { }

	private void OnImmunityPreventedEvent(bool result) { }

	public override void OnInteractWithLightHouseTraderZone(LighthouseTraderZonePlayerData[] AllowedPlayers, LighthouseTraderZonePlayerData[] UnallowedPlayers) { }

	private void OnInventoryFullySearched() { }

	public override void OnInventoryInteraction(bool inventory, bool isOperation = false) { }

	protected override void OnItemAddedOrRemoved(Item item, ItemAddress location, bool added) { }

	private void OnItemUsedHandler(IHealthEffect healthEffect) { }

	public override void OnLighthouseTraderZoneDebugToolSwitch(bool active) { }

	private void OnMagazineCheckHandler() { }

	public void OnMakingShot(IWeapon weapon, Vector3 force) { }

	protected override void OnMasteringExperienceChanged(Mastering masterSkill) { }

	public override void OnMounting(EMountingCommand command) { }

	protected override void OnPhraseTold(EPhraseTrigger event, TaggedClip clip, TagBank bank, BaseSpeaker speaker) { }

	public void OnPlaceItemTriggerChanged(PlaceItemTrigger zone) { }

	protected override void OnPlayerVisualDied(EDamageType damageType) { }

	private void OnQuestFlareShotInZone(FlareShootZoneEvent flareEvent) { }

	public void OnRadiolocationZoneEnter() { }

	public void OnRadiolocationZoneExit() { }

	private void OnRaidLoadedAmmoHandler(int count) { }

	private void OnRaidUnloadedAmmoHandler(int count) { }

	private void OnSeasonControllerInit(ISeasonsController controller) { }

	protected override void OnSideEffectApplied(SideEffectComponent sideEffect) { }

	protected override void OnSkillExperienceChanged(BaseSkill skill) { }

	protected override void OnSkillLevelChanged(BaseSkill skill) { }

	protected void OnSpeakerRelease(bool force) { }

	private void OnSpeechInterrupted(BaseSpeaker speaker, bool hasReplacement) { }

	private void OnTakeOrRemoveCompass(Item item, Transform root, bool isTake) { }

	private void OnTemperatureChangedHandler(float tempCelsio) { }

	private void OnTraderServicePurchased(ETraderServiceType serviceType, string subServiceId) { }

	public override void OnVaulting() { }

	protected override void OnWeaponMastered(Mastering masterSkill) { }

	public override void OperateStationaryWeapon(StationaryWeapon stationaryWeapon, EStationaryCommand command) { }

	public override void PauseAllEffectsOnPlayer() { }

	protected void PlantItem(string itemId, string zoneId, bool successful) { }

	public override void PlantItemLocalOnly(Item item, string zone) { }

	internal override void PlantItemNetwork(string itemId, string zoneId, bool successful) { }

	private void PlayAtPoint(Vector3 pos, AudioClip clip, int rolloff) { }

	protected override void PlayDeathSound() { }

	public override Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	public void PlayerTouchedGas(Vector3 gasSourcePosition, IObserverToPlayerBridge aggressor) { }

	public void PlayFaceShieldSound() { }

	public void PlayFrostbiteEffect() { }

	private void PlayGearSound(SoundBank bank, float volume = 1) { }

	public void PlayGearSound(float volume = 1, bool fast = false) { }

	public void PlayInteractionSound(AudioClip clip, float volume = 1, bool loop = true, bool stereo = true) { }

	private void PlayLandingSound(SoundBank bank, float balance, float volume = 1) { }

	public void PlayNightVisionSound() { }

	private void PlayPhraseClip(TaggedClip clip) { }

	private void PlayPrewarmSound(BetterSource source) { }

	public void PlaySelfStereo(AudioClip clip, float volume = 1) { }

	public void PlaySoundBank(string soundBank) { }

	public void PlaySpeechFromTime(TaggedClip clip, float time) { }

	public void PlayStepSound() { }

	public void PlayStopRecorderSound() { }

	public void PlayTacticalSound() { }

	public void PlayThermalVisionSound() { }

	protected override void PlayToggleSound(ref bool previousState, bool isOn, AudioClip toggleOn, AudioClip toggleOff) { }

	public void PlayTripwireInteractionSound(float plantTime, bool hasMultiTool) { }

	private void PlayTurnSound(float speed = 55) { }

	public void PressSprint() { }

	internal override void Proceed(Item item, Callback callback, bool scheduled = true) { }

	protected override void Proceed(FoodDrink foodDrink, float amount, Callback callback, int animationVariant, bool scheduled = true) { }

	protected override void Proceed(Item item, Callback callback, bool scheduled = true) { }

	protected override void Proceed(KnifeComponent knife, Callback callback, bool scheduled = true) { }

	protected override void Proceed(Meds meds, OneAndList bodyParts, Callback callback, int animationVariant, bool scheduled = true) { }

	protected override void Proceed(ThrowWeap throwWeap, Callback callback, bool scheduled = true) { }

	protected override void Proceed(KnifeComponent knife, Callback callback, bool scheduled = true) { }

	protected override void Proceed(ThrowWeap throwWeap, Callback callback, bool scheduled = true) { }

	protected override void Proceed(Weapon weapon, Callback callback, bool scheduled = true) { }

	protected override void Proceed(bool withNetwork, Callback callback, bool scheduled = true) { }

	protected override void Proceed(RecorderItem recorder, Callback callback, bool scheduled = true) { }

	private void ProceedArmorDamaged(List damagedArmor) { }

	[CanBeNull]
	protected List ProceedDamageThroughArmor(ref DamageInfo damageInfo, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, bool damageInfoIsLocal = true) { }

	protected override void ProceedLocalAbsorbedDamage(ref DamageInfo damageInfo, float absorbedDamage) { }

	private void ProceedPortableRangeFinder(PortableRangeFinder item, Callback completeCallback, bool scheduled = true) { }

	private void ProceedRadioTransmitter(RadioTransmitter item, Callback completeCallback, bool scheduled = true) { }

	public void ProcessTriggeredPerkNotifications(List triggeredPerkIds) { }

	public Vector3 ProjectLocalPosition(Vector3 position) { }

	public void PropUpdate() { }

	public void RaiseChangeSpeedEvent() { }

	private void RaiseHandsChanged(IHandsController controller) { }

	internal void RaiseHandsChanging() { }

	public void RaiseSightChangedEvent(SightComponent sightComp) { }

	public void RaiseSmoothSightChangeEvent(SightComponent sightComp, ESmoothScopeState state) { }

	public void RaiseTacticalInteractionChangedEvent(bool isPress) { }

	public void ReactOnCustomExplosionShake(ExplosionShakeEffectEvent shakeEvent) { }

	public void ReactOnExplosionShakeFromTimeline(TimelineExplosionShakeEffectEvent shakeEvent) { }

	public void ReactOnGlobalImpulseExplosionShake(ExplosionGlobalImpulseShakeEffectEvent impulseShakeEvent) { }

	public void ReactOnGlobalLinearExplosionShake(ExplosionGlobalLinearShakeEffectEvent linearShakeEvent) { }

	protected void RecalculateEquipmentParams() { }

	private void RecalculateMouseSensitivityModifier() { }

	protected void ReceiveDamage(float damage, EBodyPart part, EDamageType type, float absorbed, MaterialType special) { }

	private void RefreshLocalSceneIkSolverCacheEntry(int limbIndex, IKSolverLimb limbSolver) { }

	private void ReleaseFirstPersonStrapWeaponDeathHoldParent() { }

	private void ReleaseGearSource() { }

	public void ReleaseHand() { }

	private void ReleaseNestedSource(bool forced = false) { }

	private void ReleaseSearchSource() { }

	private void ReleaseSpeechSource() { }

	[CompilerGenerated]
	public void remove_BeingHitAction(Action value) { }

	[CompilerGenerated]
	public void remove_FixedUpdateEvent(Action value) { }

	[CompilerGenerated]
	public void remove_HandsChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_HandsChangingEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnBlindnessProtectionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnBtrStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnCloseTutorialHint(Action value) { }

	[CompilerGenerated]
	public void remove_OnDamageReceived(DamageDelegate value) { }

	[CompilerGenerated]
	public void remove_OnEpInteraction(Action value) { }

	[CompilerGenerated]
	public void remove_OnGlassesChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnHandsControllerChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnInventoryOpened(Action value) { }

	[CompilerGenerated]
	public override void remove_OnIPlayerDeadOrUnspawn(Action value) { }

	[CompilerGenerated]
	public void remove_OnNearestQuestLootPositionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerDead(OnPlayerDead value) { }

	[CompilerGenerated]
	public void remove_OnPlayerDeadOrUnspawn(OnPlayerDeadOrUnspawn value) { }

	[CompilerGenerated]
	public static void remove_OnPlayerDeadStatic(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerTouchGasEvent(Action value) { }

	[CompilerGenerated]
	public static void remove_OnPlayerUnspawnStatic(Action value) { }

	[CompilerGenerated]
	public void remove_OnPropVisibility(Action value) { }

	[CompilerGenerated]
	public void remove_OnSenseChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnShowAmmoCountZeroingPanel(Action value) { }

	[CompilerGenerated]
	public void remove_OnShowAmmoDetails(Action value) { }

	[CompilerGenerated]
	public void remove_OnShowFireMode(Action value) { }

	[CompilerGenerated]
	public void remove_OnSightChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnSmoothSightChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpecialPlaceVisited(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpeedChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartInventoryOpen(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartQuickdrawPistol(Action value) { }

	[CompilerGenerated]
	public void remove_OnTacticalInteractionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnTutorialHintTriggered(Action value) { }

	[CompilerGenerated]
	public void remove_PhraseSituation(Action value) { }

	[CompilerGenerated]
	public void remove_PossibleInteractionsChanged(Action value) { }

	[CompilerGenerated]
	public void remove_UpdateEvent(Action value) { }

	public void RemoveAttachment(RigidbodySpawner spawner) { }

	public override void RemoveLeftHandItem(float speed = 1) { }

	public void RemoveMouseSensitivityModifier(EMouseSensitivityModifier type) { }

	private void RemoveQuestItemsOnSessionEnd() { }

	private void RemoveSecretExitItemsInPocketsOnSessionEnd() { }

	private void RemoveSecretExitItemsOnSessionEnd() { }

	public override void RemoveStateSpeedLimit(ESpeedLimit cause) { }

	public void RemoveTriggerZone(TriggerWithId zone) { }

	public void RemoveVolume(BetterPropagationVolume volume) { }

	public void ResetFrostbiteEffectCounter() { }

	public override void ResetGestureInHands() { }

	private void ResetHeightInterpolation() { }

	public void ResetInteractionRaycast(IKillable object) { }

	public void ResetLookDirection(bool instant = false) { }

	protected void RestoreIKPos() { }

	internal void RestorePose() { }

	public void RestoreRibcageScale() { }

	internal void RestoreSpeed() { }

	public void ReturnFromStep(int direction) { }

	public void RevealWeapon() { }

	public override void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	[IteratorStateMachine(typeof(<Run>d__793))]
	private IEnumerator Run(EPlayerState state = 4) { }

	private bool SameDir(float dir) { }

	public void SaveInteractionRayInfo() { }

	public override void Say(EPhraseTrigger phrase, bool demand = false, float delay = 0, ETagStatus mask = 0, int probability = 100, bool aggressive = false, ETagFilter tagFilter = 0) { }

	public void SearchForInteractions() { }

	public override void SendHandsInteractionStateChanged(bool value, int animationId) { }

	protected override void SendHeadlightsPacket(bool isSilent) { }

	protected override void SendTripwireInteractionSoundState(EInteractionStatus interactionStatus, bool isSuccess, bool hasMultiTool) { }

	protected override void SendUnderRoofStatus(bool isUnderRoof) { }

	protected override void SendVoiceMuffledState(bool isMuffled) { }

	protected override void SendWeaponLightPacket() { }

	[CompilerGenerated]
	private void set_ActiveSlot(Slot value) { }

	[CompilerGenerated]
	protected void set_AIData(IAIData value) { }

	[CompilerGenerated]
	public void set_AllowToPlantBeacon(bool value) { }

	public override void set_Awareness(float value) { }

	[CompilerGenerated]
	private void set_BeaconPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_BeaconRotation(Quaternion value) { }

	[CompilerGenerated]
	public void set_BotsGroup(BotsGroup value) { }

	[CompilerGenerated]
	public void set_BtrInteractionSide(BTRSide value) { }

	public override void set_BtrState(EPlayerBtrState value) { }

	[CompilerGenerated]
	private void set_CameraContainer(GameObject value) { }

	[CompilerGenerated]
	private void set_CameraPosition(Transform value) { }

	[CompilerGenerated]
	private void set_CustomAudioSettings(IPlayerCustomAudioSettings value) { }

	[CompilerGenerated]
	private void set_DissonanceComms(DissonanceComms value) { }

	[CompilerGenerated]
	private void set_Environment(EnvironmentType value) { }

	[CompilerGenerated]
	public void set_EventObjectInteractive(EventObjectInteractive value) { }

	[CompilerGenerated]
	private void set_EventTranslator(GenericEventTranslator value) { }

	[CompilerGenerated]
	private void set_ExfiltrationPoint(ExfiltrationPoint value) { }

	[CompilerGenerated]
	private void set_ExitTriggerZone(bool value) { }

	[CompilerGenerated]
	protected void set_FaceCoverMaskObserver(SlotObserver value) { }

	[CompilerGenerated]
	protected void set_FaceCoverShieldObserver(SlotObserver value) { }

	[CompilerGenerated]
	protected void set_FaceShieldObserver(SlotObserver value) { }

	[CompilerGenerated]
	private void set_GameWorld(GameWorld value) { }

	public void set_HandsAnimator(ObjectInHandsAnimator value) { }

	protected override void set_HandsController(AbstractHandsController value) { }

	[CompilerGenerated]
	public void set_HasGamePlayerOwner(bool value) { }

	[CompilerGenerated]
	protected void set_HearingDateTime(DateTime value) { }

	[CompilerGenerated]
	private void set_IgnoreCameraCollider(bool value) { }

	[CompilerGenerated]
	public void set_InputDirection(Vector2 value) { }

	[CompilerGenerated]
	private void set_InteractableObject(InteractableObject value) { }

	[CompilerGenerated]
	private void set_InteractableObjectIsProxy(bool value) { }

	[CompilerGenerated]
	private void set_InteractablePlayer(Player value) { }

	[CompilerGenerated]
	private void set_InteractionRayDirectionOnStartOperation(Vector3 value) { }

	[CompilerGenerated]
	private void set_InteractionRayOriginOnStartOperation(Vector3 value) { }

	[CompilerGenerated]
	public void set_IsAgressorInLighthouseTraderZone(bool value) { }

	[CompilerGenerated]
	public override void set_IsInBufferZone(bool value) { }

	public void set_IsInventoryOpened(bool value) { }

	public override void set_IsVisible(bool value) { }

	[CompilerGenerated]
	public void set_IsVisibleToCamera(bool value) { }

	[CompilerGenerated]
	protected void set_IsYourPlayer(bool value) { }

	private void set_LastEquippedWeaponOrKnifeItem(Item value) { }

	[CompilerGenerated]
	private void set_LastFoundCompletableStorage(LastFoundCompletableStorage value) { }

	[CompilerGenerated]
	public void set_Location(string value) { }

	[CompilerGenerated]
	protected void set_Loyalty(PlayerLoyaltyData value) { }

	[CompilerGenerated]
	private void set_MainParts(Dictionary value) { }

	[CompilerGenerated]
	protected void set_MalfRandoms(MalfunctionRandom value) { }

	[CompilerGenerated]
	protected void set_MovementContext(MovementContext value) { }

	private void set_NegativeBuffsCount(int value) { }

	[CompilerGenerated]
	protected void set_NightVisionObserver(SlotObserver value) { }

	[CompilerGenerated]
	public void set_PlaceItemZone(PlaceItemTrigger value) { }

	[CompilerGenerated]
	public void set_PlayerBones(PlayerBones value) { }

	[CompilerGenerated]
	private void set_PlayerId(int value) { }

	public override void set_PointOfView(EPointOfView value) { }

	private void set_Position(Vector3 value) { }

	[CompilerGenerated]
	public void set_PreventAutoWeaponDraw(bool value) { }

	[CompilerGenerated]
	private void set_ProceduralWeaponAnimation(ProceduralWeaponAnimation value) { }

	private void set_ProcessStatus(EProcessStatus value) { }

	[CompilerGenerated]
	private void set_Profile(Profile value) { }

	[CompilerGenerated]
	protected void set_RaidId(int value) { }

	[CompilerGenerated]
	private void set_RayLength(float value) { }

	protected void set_Rotation(Vector2 value) { }

	public void set_RotationPitchLimit(Vector2 value) { }

	[CompilerGenerated]
	private void set_ScheduledProcess(AbstractProcess value) { }

	private void set_Sense(bool value) { }

	[CompilerGenerated]
	public void set_SpawnPoint(ISpawnPoint value) { }

	protected void set_SpeechSource(BetterSource value) { }

	[CompilerGenerated]
	protected void set_StatisticsManager(IStatisticsManager value) { }

	[CompilerGenerated]
	protected void set_ThermalVisionObserver(SlotObserver value) { }

	[CompilerGenerated]
	public void set_TripwireInteractionTrigger(TripwireInteractionTrigger value) { }

	[CompilerGenerated]
	private void set_TripwirePlanner(TripwireVisualPlacer value) { }

	[CompilerGenerated]
	private void set_UsedSimplifiedSkeleton(bool value) { }

	[CompilerGenerated]
	public void set_VisibleToCameraType(ECameraType value) { }

	public override void set_VoipAudioSource(AudioSource value) { }

	[CompilerGenerated]
	protected void set_VoipController(IPlayerVoipController value) { }

	[CompilerGenerated]
	private void set_VoipID(string value) { }

	[CompilerGenerated]
	protected void set_VoipState(EVoipState value) { }

	public override void SetAlertedFloat(float alertedFloat) { }

	public override void SetAnimatorLayerWeight(int layer, int weight) { }

	public override void SetArmsAnimatorCommon(IAnimator animator) { }

	public override void SetAudioProtagonist() { }

	public void SetCallbackForInteraction(Action cb) { }

	public override void SetCompassState(bool value) { }

	public void SetCompensationScale(bool force = false) { }

	protected override void SetControllerInsteadRemovedOne(Item removingItem, Callback callback) { }

	private void SetCustomSettings() { }

	public void SetDeltaTimeDelegate(DeltaTimeDelegate deltaTimeDelegate) { }

	public void SetDogtagInfo(DeathPacket deathPacket) { }

	public void SetEmptyHands(Callback callback) { }

	public void SetEnvironment(int playerRaidId, EnvironmentType environmentType) { }

	public override void SetEventState(EEventState value) { }

	public override void SetExfiltrationPoint(ExfiltrationPoint point, bool entered) { }

	public void SetFirstAvailableItem(Callback completeCallback) { }

	public void SetFrostbiteEffectTicksPerPlay(int count) { }

	public void SetGroup(BotsGroup newBotsGroup) { }

	public void SetInHands(Meds meds, OneAndList bodyParts, int animationVariant, Callback callback) { }

	private void SetInHands(bool enable) { }

	public void SetInHands(Item item, Callback callback) { }

	public void SetInHands(Weapon weapon, Callback callback) { }

	public void SetInHands(ThrowWeap throwWeap, Callback callback) { }

	public void SetInHands(KnifeComponent knife, Callback callback) { }

	public void SetInHands(RecorderItem recorderItem, Callback callback) { }

	public void SetInHands(FoodDrink foodDrink, float amount, int animationVariant, Callback callback) { }

	public void SetInHands(Meds meds, EBodyPart bodyPart, int animationVariant, Callback callback) { }

	public void SetInHandsForQuickUse(ThrowWeap throwWeap, Callback callback) { }

	public void SetInHandsForQuickUse(KnifeComponent knife, Callback callback) { }

	public void SetInHandsForQuickUse(Item quickUseItem, Callback callback) { }

	public void SetInHandsUsableItem(Item item, Callback callback) { }

	public override void SetInteractInHands(EInteraction interaction) { }

	public override void SetInventoryOpened(bool opened) { }

	public void SetItemInHands(Item item, Callback callback) { }

	public override void SetLauncherState(bool value) { }

	private void SetLeftHandItem(Item item) { }

	public void SetOwnerToAIData(BotOwner bot) { }

	public void SetPropVisibility(bool isVisible) { }

	public void SetQuickSlotItem(EBoundItem quickSlot, Callback callback) { }

	public void SetRadioTransmitterView(RadioTransmitterView rtView) { }

	private void SetRolloff(BetterSource source, float rolloff) { }

	public override bool SetShotStatus(BodyPartCollider bodypart, Shot shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

	public void SetSlotItem(EquipmentSlot equipmentSlot, Callback callback) { }

	public void SetStationaryWeapon(Weapon weapon) { }

	private void SetupAnimatorController(bool aiControlled) { }

	private void SetupBodyPartCollider(BodyPartCollider bodyPartCollider, bool includeChild) { }

	protected override void SetupHitColliders() { }

	private void SetupSoundsFromFaceShieldComponent(FaceShieldComponent fs, EquipmentSlot equipmentSlot) { }

	public override void ShotReactions(DamageInfo shot, EBodyPart bodyPart) { }

	private static bool ShouldQueueLocalSceneFovPlayer(Player player) { }

	private static bool ShouldSay(Player talker, EPhraseTrigger phTrigger) { }

	protected override bool ShouldVocalizeDeath(EBodyPart bodyPart) { }

	public void ShowAmmoCountZeroingPanel(string message) { }

	internal override void ShowGesture(EInteraction gesture) { }

	public override void ShowHelloNotification(string sender) { }

	public override void ShowStringNotification(string message) { }

	public override void Sleep(bool value) { }

	public void SlowLean(float dir) { }

	public override void SpawnAI(int count) { }

	protected override Task SpawnController(AbstractHandsController controller, Action callback = null) { }

	public void SpawnInHands(Item item, string parentBone) { }

	public void SpecialPlaceVisited(string id, int experience) { }

	[IteratorStateMachine(typeof(<Sprint>d__791))]
	private IEnumerator Sprint(EPlayerState state = 5) { }

	protected override void StartInflictSelfDamageCoroutine() { }

	internal override void StartInteraction(WorldInteractiveObject interactiveObject, InteractionResult interactionResult, Action callback, bool enterDoorState = true) { }

	private void StateChangedHandler(EPlayerState previousState, EPlayerState nextstate) { }

	private void StatisticsManagerOnOnUniqueLoot() { }

	public void StopBlindFire() { }

	private void StopFirstPersonStrapWeaponDeathHold() { }

	public void StopHoldingBreath() { }

	public void StopInteractionSound(float fadeTime = 0) { }

	public void StopTripwireInteractionSound(bool isSuccess, bool hasMultiTool) { }

	[IteratorStateMachine(typeof(<StoreRenderer>d__1448))]
	private IEnumerator StoreRenderer() { }

	internal void Straighten(float fromDir) { }

	private void SubscribeBackpackDropEvents() { }

	public void SubscribeVisualEvents() { }

	[IteratorStateMachine(typeof(<SupportAudioSourceCoroutine>d__752))]
	public IEnumerator SupportAudioSourceCoroutine() { }

	public void SwitchHeadLights(bool togglesActive, bool changesState) { }

	public void SwitchHeadLightsAnimation() { }

	public void SwitchRenderer(bool switch) { }

	private OneAndList TargetBodyParts(Item item) { }

	public override void Teleport(Vector3 position, bool onServerToo = false) { }

	private OperationResult ThrowGrenade(ThrowWeap grenade, bool lowThrow, bool simulate) { }

	public void ToggleBlindFire(float blindFireValue) { }

	public void ToggleDisableSprint() { }

	internal void ToggleGoggles() { }

	public void ToggleHoldingBreath() { }

	internal void ToggleLean(float dir) { }

	public override void ToggleLeftHand(Item item) { }

	internal void ToggleMinSpeed() { }

	public void ToggleMuteSpeechSource(bool muteSpeech) { }

	internal void TogglePose() { }

	public override void ToggleProne() { }

	public void ToggleSprint() { }

	public void ToggleStep(int direction) { }

	private void ToggleVaulting() { }

	public static Option ToItemAddress(ItemAddressDescriptor descriptor) { }

	protected void TrackPlayerPosition() { }

	protected override void TraderStandingHandler(TraderInfo traderInfo) { }

	internal override void TransitInteraction(TransitController controller, int transitPointId, string keyId, EDateTime time) { }

	protected override void TriggerPhraseCommand(EPhraseTrigger phrase, int netPhraseId) { }

	public void TriggerTutorialHint(TutorialHintData data) { }

	public override void TriggerZombieLost() { }

	internal override void TripwireInteraction(TripwireSynchronizableObject tripwire) { }

	private void TripwireInteractionRaycast(GameObject interactive) { }

	public bool TryFindGlasses(out Visors glasses) { }

	public bool TryGetArmorResistData(BodyPartCollider bodyPart, float penetrationPower, out ArmorResistanceData armorResistanceData) { }

	private bool TryGetCachedLocalSceneIkSolverData(int limbIndex, out IKSolverLimb limbSolver, out Transform bone1, out Transform bone2, out Transform bone3) { }

	private static bool TryGetFirstPersonDeathHoldLeftUpperArmTransform(PlayerBones playerBones, out Transform leftUpperArm) { }

	[CanBeNull]
	public TItem TryGetItemInHands() { }

	public override void TryInteractionCallback(LootableContainer container) { }

	public void TryMountWeapon() { }

	protected void TryProceed(Item item, Callback completeCallback, bool scheduled = true) { }

	protected void TryRemoveFromHands(Item item, IInventoryOperation abstractOperation, Callback callback) { }

	public void TrySaveLastItemInHands() { }

	protected void TrySetInHands(Item item, ItemAddress to, IInventoryOperation operation, Callback originalCallback) { }

	public void TrySetLastEquippedWeapon(bool equipFirstAvaliableOnFail = true, Callback callback = null) { }

	private void TryStartContusion(float time) { }

	public void TryStartFirstPersonStrapWeaponDeathHold() { }

	public override void UnpauseAllEffectsOnPlayer() { }

	public void UnsubscribeVisualEvents() { }

	public override void UpdateArmsCondition() { }

	public void UpdateBonesOnWeaponChange(TransformLinks links) { }

	protected override void UpdateBreathStatus() { }

	private void UpdateCompassController(GameObject obj) { }

	public void UpdateConditionsAfterBodyPartStateChanged(EBodyPart bodyPart) { }

	private void UpdateExhaustionAudibility() { }

	public void UpdateFirstPersonGrip(EGripType type = 0, TransformLinks transforms = null) { }

	private void UpdateFirstPersonStrapWeaponDeathHold() { }

	protected override bool UpdateGrenadeAnimatorDuePoV() { }

	protected void UpdateInteractionCache() { }

	public override void UpdateInteractionCast() { }

	public void UpdateLauncherBones(bool launcherEnable, WeaponPrefab weaponPrefab) { }

	public override void UpdateMuffledState() { }

	protected override void UpdatePhones() { }

	protected void UpdatePhonesReally() { }

	private void UpdateSourcePriority(BetterSource source) { }

	public override void UpdateSpeedLimit(float speedDelta, ESpeedLimit cause, float duration) { }

	public override void UpdateSpeedLimit(float speedDelta, ESpeedLimit cause) { }

	protected override void UpdateSpeedLimitByHealth() { }

	private void UpdateStepSourceRolloff(EAudioMovementState movementState = 0, bool includeSpeedMult = false) { }

	private void UpdateSurfaceData(bool hit, ESurfaceSound surfaceSound) { }

	public override void UpdateTick() { }

	protected override void UpdateTriggerColliderSearcher(float deltaTime, bool isCloseToCamera = true) { }

	public void Vaulting(bool vaulting) { }

	public void VisualPass() { }

	[IteratorStateMachine(typeof(<WaitWeaponInventory>d__1331))]
	private IEnumerator WaitWeaponInventory() { }

}

