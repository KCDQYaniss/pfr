namespace EFT;

public class InteractionContextHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__8_10; //Field offset: 0x8
		public static Callback <>9__8_9; //Field offset: 0x10
		public static Action <>9__14_10; //Field offset: 0x18
		public static Func <>9__14_0; //Field offset: 0x20
		public static Action <>9__14_13; //Field offset: 0x28
		public static Func <>9__18_0; //Field offset: 0x30
		public static Func <>9__18_1; //Field offset: 0x38
		public static Func <>9__19_0; //Field offset: 0x40
		public static Func <>9__19_1; //Field offset: 0x48
		public static Action <>9__29_0; //Field offset: 0x50
		public static Action <>9__30_1; //Field offset: 0x58
		public static Action <>9__30_4; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal <>f__AnonymousType94 <GetAvailableActions>b__18_0(KeycardComponent keycard) { }

		internal <>f__AnonymousType95 <GetAvailableActions>b__18_1(<>f__AnonymousType94 <>h__TransparentIdentifier0) { }

		internal <>f__AnonymousType94 <GetAvailableActions>b__19_0(KeycardComponent keycard) { }

		internal <>f__AnonymousType95 <GetAvailableActions>b__19_1(<>f__AnonymousType94 <>h__TransparentIdentifier0) { }

		internal void <GetAvailableActions>b__29_0() { }

		internal void <GetAvailableActions>b__30_1() { }

		internal void <GetAvailableActions>b__30_4() { }

		internal void <GetAvailableActions>b__8_10(Result arg2) { }

		internal void <GetAvailableActions>b__8_9(Result arg) { }

		internal bool <GetAvailableInteractionState>b__14_0(Slot slot) { }

		internal void <GetAvailableInteractionState>b__14_10() { }

		internal void <GetAvailableInteractionState>b__14_13() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public WorldInteractiveObject worldInteractiveObject; //Field offset: 0x18
		public KeyComponent key; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <TryAddUnlock>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_1
	{
		public Option unlockResult; //Field offset: 0x10
		public <>c__DisplayClass11_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass11_1() { }

		internal void <TryAddUnlock>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public List actions; //Field offset: 0x10
		public bool examined; //Field offset: 0x18
		public string lootItemName; //Field offset: 0x20
		public GamePlayerOwner owner; //Field offset: 0x28
		public Item rootItem; //Field offset: 0x30
		public IPlayer lootItemLastOwner; //Field offset: 0x38
		public InventoryController controller; //Field offset: 0x40
		public ItemController lootItemOwner; //Field offset: 0x48
		public CompoundItem compoundItem; //Field offset: 0x50
		public Callback <>9__7; //Field offset: 0x58
		public Action <>9__6; //Field offset: 0x60
		public Callback <>9__9; //Field offset: 0x68
		public Callback <>9__12; //Field offset: 0x70

		public <>c__DisplayClass14_0() { }

		internal void <GetAvailableInteractionState>b__11() { }

		internal void <GetAvailableInteractionState>b__12(IResult result) { }

		internal void <GetAvailableInteractionState>b__5() { }

		internal void <GetAvailableInteractionState>b__6() { }

		internal void <GetAvailableInteractionState>b__7(IResult result) { }

		internal void <GetAvailableInteractionState>b__8() { }

		internal void <GetAvailableInteractionState>b__9(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public OperationResult pickUpResult; //Field offset: 0x10
		public <>c__DisplayClass14_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass14_1() { }

		internal void <GetAvailableInteractionState>g__AddPickupAction|1(string actionName, Action afterPickAction) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_2
	{
		public Action afterPickAction; //Field offset: 0x10
		public <>c__DisplayClass14_1 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass14_2() { }

		internal void <GetAvailableInteractionState>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_3
	{
		public TapeItem tape; //Field offset: 0x10
		public NoteItem note; //Field offset: 0x18
		public <>c__DisplayClass14_1 CS$<>8__locals3; //Field offset: 0x20

		public <>c__DisplayClass14_3() { }

		internal void <GetAvailableInteractionState>b__3() { }

		internal void <GetAvailableInteractionState>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public IItemOperationResult possibleAction; //Field offset: 0x10
		public Item rootItem; //Field offset: 0x18
		public IPlayer lootItemLastOwner; //Field offset: 0x20
		public Player owner; //Field offset: 0x28
		public Action completeAction; //Field offset: 0x30

		public <>c__DisplayClass15_0() { }

		internal void <PickupAction>b__0() { }

		internal void <PickupAction>g__Callback|1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public Switch interactiveSwitch; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <GetAvailableActions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_1
	{
		public KeyComponent key; //Field offset: 0x10
		public <>c__DisplayClass16_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass16_1() { }

		internal void <GetAvailableActions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public BufferGateSwitcher interactiveSwitch; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <GetAvailableActions>b__0() { }

		internal void <GetAvailableActions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public CardReader reader; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal InteractionAction <GetAvailableActions>b__2(<>f__AnonymousType95 <>h__TransparentIdentifier1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_1
	{
		public <>f__AnonymousType95 <>h__TransparentIdentifier1; //Field offset: 0x10
		public <>c__DisplayClass18_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass18_1() { }

		internal void <GetAvailableActions>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_2
	{
		public Option unlockResult; //Field offset: 0x10
		public <>c__DisplayClass18_1 CS$<>8__locals2; //Field offset: 0x20

		public <>c__DisplayClass18_2() { }

		internal void <GetAvailableActions>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public KeycardDoor door; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal InteractionAction <GetAvailableActions>b__2(<>f__AnonymousType95 <>h__TransparentIdentifier1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public <>f__AnonymousType95 <>h__TransparentIdentifier1; //Field offset: 0x10
		public <>c__DisplayClass19_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass19_1() { }

		internal void <GetAvailableActions>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_2
	{
		public Option unlockResult; //Field offset: 0x10
		public <>c__DisplayClass19_1 CS$<>8__locals2; //Field offset: 0x20

		public <>c__DisplayClass19_2() { }

		internal void <GetAvailableActions>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public Door door; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <GetAvailableActions>b__0() { }

		internal void <GetAvailableActions>b__2() { }

		internal void <GetAvailableActions>b__3() { }

		internal void <GetAvailableActions>b__5() { }

		internal void <GetAvailableActions>b__6() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_1
	{
		public Option result; //Field offset: 0x10
		public <>c__DisplayClass20_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass20_1() { }

		internal void <GetAvailableActions>b__1(bool successful) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_2
	{
		public Option result; //Field offset: 0x10
		public <>c__DisplayClass20_0 CS$<>8__locals2; //Field offset: 0x20

		public <>c__DisplayClass20_2() { }

		internal void <GetAvailableActions>b__4(bool successful) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public Trunk door; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <GetAvailableActions>b__0() { }

		internal void <GetAvailableActions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public LootableContainer container; //Field offset: 0x18
		public Action <>9__2; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal void <GetAvailableActions>b__0() { }

		internal void <GetAvailableActions>b__2() { }

		internal void <GetAvailableActions>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public float initialDistance; //Field offset: 0x10
		public <>c__DisplayClass22_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass22_1() { }

		internal void <GetAvailableActions>b__1(Action callback) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public StationaryWeapon stationaryWeapon; //Field offset: 0x10
		public GamePlayerOwner owner; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <GetAvailableActions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public AreaData hideoutArea; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal void <GetAvailableActions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public float plantTime; //Field offset: 0x18
		public TripwireSynchronizableObject tripwire; //Field offset: 0x20
		public bool hasMultiTool; //Field offset: 0x28
		public Action <>9__2; //Field offset: 0x30

		public <>c__DisplayClass3_0() { }

		internal void <GetAvailableActions>b__1() { }

		internal void <GetAvailableActions>b__2(bool successful) { }

		internal void <GetAvailableActions>g__HandleStateChanged|0(ETripwireState state) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public HideoutPlayerOwner owner; //Field offset: 0x10
		public HideoutArea hideoutArea; //Field offset: 0x18
		public AvailableInteractionState interactionState; //Field offset: 0x20

		public <>c__DisplayClass30_0() { }

		internal void <GetAvailableActions>b__0() { }

		internal void <GetAvailableActions>b__2() { }

		internal void <GetAvailableActions>b__3() { }

		internal void <GetAvailableActions>b__6() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_1
	{
		public IQteAreaBehaviour qteBehaviour; //Field offset: 0x10
		public <>c__DisplayClass30_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass30_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_2
	{
		public QteHandleData qteData; //Field offset: 0x10
		public <>c__DisplayClass30_1 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass30_2() { }

		internal void <GetAvailableActions>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public LootableContainer lootableContainer; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass32_0() { }

		internal void <OnContainerOpen>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public Door door; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal void <GetAvailableKeeperDoorActions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public BTRSide btr; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <GetAvailableActions>b__0() { }

		internal void <GetAvailableActions>b__1() { }

		internal void <GetAvailableActions>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_1
	{
		public ClientPlayer clientPlayer; //Field offset: 0x10

		public <>c__DisplayClass4_1() { }

		internal void <GetAvailableActions>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_2
	{
		public LocalPlayer localPlayer; //Field offset: 0x10

		public <>c__DisplayClass4_2() { }

		internal void <GetAvailableActions>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public PasscodeTerminal terminal; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <GetAvailableActions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public InteractableNoteHint noteHint; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <GetAvailableActions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public GamePlayerOwner owner; //Field offset: 0x10
		public ConditionLeaveItemAtLocation resultLeaveItem; //Field offset: 0x18
		public Item resultItem; //Field offset: 0x20
		public PlaceItemTrigger itemTrigger; //Field offset: 0x28
		public Callback <>9__3; //Field offset: 0x30
		public Action <>9__2; //Field offset: 0x38

		public <>c__DisplayClass8_0() { }

		internal void <GetAvailableActions>b__2(bool successful) { }

		internal void <GetAvailableActions>b__3(IResult discardResult) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_1
	{
		public ConditionZone conditionZone; //Field offset: 0x10
		public <>c__DisplayClass8_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass8_1() { }

		internal bool <GetAvailableActions>g__ItemMatchPredicate|0(Item nextItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_2
	{
		public bool isMultitool; //Field offset: 0x10
		public <>c__DisplayClass8_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass8_2() { }

		internal void <GetAvailableActions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_3
	{
		public ConditionPlaceBeacon resultBeacon; //Field offset: 0x10
		public <>c__DisplayClass8_0 CS$<>8__locals3; //Field offset: 0x18
		public Callback <>9__7; //Field offset: 0x20

		public <>c__DisplayClass8_3() { }

		internal void <GetAvailableActions>b__4() { }

		internal void <GetAvailableActions>b__7(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_4
	{
		public Item itemInHands; //Field offset: 0x10
		public <>c__DisplayClass8_3 CS$<>8__locals4; //Field offset: 0x18
		public Callback <>9__11; //Field offset: 0x20

		public <>c__DisplayClass8_4() { }

		internal void <GetAvailableActions>b__11(Result result1) { }

		internal void <GetAvailableActions>b__6(Result result) { }

		internal void <GetAvailableActions>g__BeaconPlaced|5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_5
	{
		public bool isInEquipment; //Field offset: 0x10
		public <>c__DisplayClass8_4 CS$<>8__locals5; //Field offset: 0x18

		public <>c__DisplayClass8_5() { }

		internal void <GetAvailableActions>b__8(Result arg1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Player player; //Field offset: 0x10
		public GamePlayerOwner owner; //Field offset: 0x18
		public string shortName; //Field offset: 0x20
		public TransferItemRequirement transferReq; //Field offset: 0x28

		public <>c__DisplayClass9_0() { }

		internal void <GetAvailableActions>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public SecretExitTransferItemRequirement secretItemReq; //Field offset: 0x10
		public Item secretItemFound; //Field offset: 0x18
		public <>c__DisplayClass9_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass9_1() { }

		internal void <GetAvailableActions>b__0() { }

	}

	private const string TOOLKIT_ID = "590c2e1186f77425357b6124"; //Field offset: 0x0

	public InteractionContextHelper() { }

	private static bool CanInteractWithArea(HideoutArea hideoutArea, bool isGuestArea) { }

	private static IResult CanUnlockBySkill(GamePlayerOwner owner, WorldInteractiveObject worldInteractiveObject) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, RaidDialogEntryPoint entry) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(HideoutPlayerOwner owner, HideoutArea hideoutArea) { }

	[CanBeNull]
	public static AvailableInteractionState GetAvailableActions(AreaData hideoutArea, InventoryController inventoryController) { }

	private static AvailableInteractionState GetAvailableActions(HideoutPlayerOwner owner, HideoutDialogEntryPoint dialogEntryPoint) { }

	private static AvailableInteractionState GetAvailableActions(HideoutPlayerOwner owner, InteractiveRecorder recorder) { }

	private static AvailableInteractionState GetAvailableActions(HideoutPlayerOwner owner, InteractiveShootingRange targetControl) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(Appliance appliance) { }

	private static AvailableInteractionState GetAvailableActions(NoPowerTip noPowerTip) { }

	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, StationaryWeapon stationaryWeapon) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, LootableContainer container) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, Trunk door) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, Door door) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, CardReader reader, bool isProxy) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, KeycardDoor door, bool isProxy) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, Switch interactiveSwitch) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, EventObjectInteractive eventObjectInteractive) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, TripwireInteractionTrigger tripwireInteraction) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, BTRSide btr) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, PasscodeTerminal terminal) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, BufferGateSwitcher interactiveSwitch) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, PlaceItemTrigger itemTrigger) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, InteractableNoteHint noteHint) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, WorldInteractiveObject worldInteractiveObject) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, LootItem lootItem) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, ExfiltrationPoint exfiltrationPoint) { }

	[CanBeNull]
	public static AvailableInteractionState GetAvailableActions(GamePlayerOwner owner, IInteractive interactive) { }

	[CanBeNull]
	public static AvailableInteractionState GetAvailableHideoutActions(HideoutPlayerOwner owner, IInteractive interactive) { }

	private static AvailableInteractionState GetAvailableInteractionState(GamePlayerOwner owner, Item rootItem, ItemController lootItemOwner, string lootItemId, string lootItemName, IPlayer lootItemLastOwner) { }

	[CanBeNull]
	private static AvailableInteractionState GetAvailableKeeperDoorActions(GamePlayerOwner owner, Door door) { }

	private static void OnContainerOpen(GamePlayerOwner owner, Action callback, LootableContainer lootableContainer, float initialDistance) { }

	private static void PickupAction(Player owner, IItemOperationResult possibleAction, Item rootItem, IPlayer lootItemLastOwner, Action completeAction = null) { }

	public static void ShowTriggeredPerkNotification(string perkNameLocalizationKey) { }

	private static IResult TryAddUnlock(GamePlayerOwner owner, WorldInteractiveObject worldInteractiveObject, List actions) { }

	[CanBeNull]
	private static AvailableInteractionState TryGetSpecificInteractionState(GamePlayerOwner owner, InteractableObject interactableObject) { }

	public static void TryShowTriggeredPerkNotification(GamePlayerOwner owner, UnlockResult unlockResult) { }

}

