namespace EFT.Hideout;

public abstract class AreaBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__49_0; //Field offset: 0x8
		public static Func <>9__49_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CalculateBonuses>b__49_0(Improvement improvement) { }

		internal Bonus[] <CalculateBonuses>b__49_1(Improvement improvement) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public Bonus oldBonus; //Field offset: 0x10

		public <>c__DisplayClass50_0() { }

		internal bool <ReplaceTrackedBonus>b__0(Bonus bonus) { }

	}

	public static bool CanShowReadyNotifications; //Field offset: 0x0
	protected BonusController BonusController; //Field offset: 0x10
	protected IEftSession Session; //Field offset: 0x18
	private SkillManager _skillManager; //Field offset: 0x20
	private List _bonuses; //Field offset: 0x28
	private HideoutArea _hideoutArea; //Field offset: 0x30
	private HideoutAreaNotification _areaNotification; //Field offset: 0x38
	private AreaDetailsGroup _detailsGroup; //Field offset: 0x40
	[CompilerGenerated]
	private InventoryController <InventoryController>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private AdditionalSlotsBonus <Slots>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private HideoutController <Controller>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private AreaData <Data>k__BackingField; //Field offset: 0x60

	public HideoutController Controller
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private AreaData Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public AreaDetailsGroup DetailsGroup
	{
		 get { } //Length: 343
	}

	public override bool HasError
	{
		 get { } //Length: 3
	}

	protected HideoutArea HideoutArea
	{
		 get { } //Length: 546
	}

	protected private InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override AdditionalSlotsBonus Slots
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected AreaBehaviour() { }

	[CompilerGenerated]
	private void <Init>b__38_0(bool silent) { }

	private void AreaStatusUpdatedHandler() { }

	public override void BehaviourUpdate() { }

	private void CalculateBonuses() { }

	public override void ConfigureBonusesCustom(ref RelatedBonuses relatedBonuses, ELevelType levelType) { }

	private void DisplayNotification(HideoutNotification notification, EHideoutNotificationType eventType) { }

	[CompilerGenerated]
	public HideoutController get_Controller() { }

	[CompilerGenerated]
	public AreaData get_Data() { }

	public AreaDetailsGroup get_DetailsGroup() { }

	public override bool get_HasError() { }

	protected HideoutArea get_HideoutArea() { }

	[CompilerGenerated]
	protected InventoryController get_InventoryController() { }

	[CompilerGenerated]
	public override AdditionalSlotsBonus get_Slots() { }

	private void ImprovementsUpdatedHandler() { }

	public override void Init(AreaData area, AreaInfo profileInfo, InventoryController inventoryController, IEftSession session) { }

	protected override void Init(AreaData data) { }

	protected override void LevelUpdatedHandler() { }

	private void LevelUpdatedSealedHandler() { }

	private void LightStatusChangedHandler(ELightStatus lightStatus) { }

	protected void NotificationClickHandler() { }

	public override void OnEnterLocation(Player player) { }

	public override void OnExitLocation() { }

	public void PlaySound(EAreaActivityType soundType) { }

	private void ProductionStateChangedHandler(bool active) { }

	public override void ReleaseSubscriptions() { }

	protected void ReplaceTrackedBonus(Bonus oldBonus, Bonus newBonus) { }

	[CompilerGenerated]
	public void set_Controller(HideoutController value) { }

	[CompilerGenerated]
	private void set_Data(AreaData value) { }

	[CompilerGenerated]
	private void set_InventoryController(InventoryController value) { }

	[CompilerGenerated]
	private void set_Slots(AdditionalSlotsBonus value) { }

	private void ShowAreaNotification(EHideoutNotificationType eventType) { }

	public void ShowNotification(EHideoutNotificationType eventType, Item item = null) { }

	private void SkillLevelChangedHandler(BaseSkill skill) { }

}

