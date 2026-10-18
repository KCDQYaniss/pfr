namespace EFT;

internal sealed class FirearmHandsInputTranslator : IHandsInputTranslator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__12_1; //Field offset: 0x10
		public static Func <>9__13_0; //Field offset: 0x18
		public static Func <>9__13_1; //Field offset: 0x20
		public static Func <>9__14_0; //Field offset: 0x28
		public static Func <>9__14_1; //Field offset: 0x30
		public static Func <>9__15_0; //Field offset: 0x38
		public static Func <>9__15_1; //Field offset: 0x40
		public static Func <>9__21_1; //Field offset: 0x48
		public static Func <>9__21_2; //Field offset: 0x50
		public static Func <>9__24_1; //Field offset: 0x58
		public static Func <>9__24_2; //Field offset: 0x60
		public static Func <>9__25_1; //Field offset: 0x68
		public static Func <>9__25_2; //Field offset: 0x70
		public static Func <>9__26_4; //Field offset: 0x78
		public static Func <>9__26_5; //Field offset: 0x80
		public static Func <>9__27_1; //Field offset: 0x88
		public static Func <>9__28_2; //Field offset: 0x90
		public static Func <>9__28_3; //Field offset: 0x98
		public static Func <>9__28_4; //Field offset: 0xA0
		public static Predicate <>9__31_0; //Field offset: 0xA8
		public static Comparison <>9__31_1; //Field offset: 0xB0
		public static Func <>9__31_3; //Field offset: 0xB8
		public static Func <>9__31_4; //Field offset: 0xC0
		public static Func <>9__31_5; //Field offset: 0xC8

		private static <>c() { }

		public <>c() { }

		internal Item <GetAllSightStatesAfterCalibration>b__15_0(Slot x) { }

		internal string <GetAllSightStatesAfterCalibration>b__15_1(SightComponent x) { }

		internal Item <GetCurrentLightStates>b__13_0(Slot x) { }

		internal LightsState <GetCurrentLightStates>b__13_1(LightComponent x) { }

		internal Item <GetSightStateAfterChangeMagnification>b__14_0(Slot x) { }

		internal string <GetSightStateAfterChangeMagnification>b__14_1(SightComponent x) { }

		internal bool <LoadAmmoToChamber>b__26_4(GridItemAddress g) { }

		internal int <LoadAmmoToChamber>b__26_5(GridItemAddress g) { }

		internal bool <Reload>b__27_1(Ammo ammo) { }

		internal bool <ReloadBarrels>b__28_2(GridItemAddress g) { }

		internal int <ReloadBarrels>b__28_3(GridItemAddress g) { }

		internal bool <ReloadBarrels>b__28_4(GridItemAddress x) { }

		internal bool <ReloadExternalMagazine>b__31_0(Magazine mag) { }

		internal int <ReloadExternalMagazine>b__31_1(Magazine m1, Magazine m2) { }

		internal bool <ReloadExternalMagazine>b__31_3(GridItemAddress g) { }

		internal int <ReloadExternalMagazine>b__31_4(GridItemAddress g) { }

		internal bool <ReloadExternalMagazine>b__31_5(GridItemAddress x) { }

		internal bool <TranslateCommand>b__12_0(LightsState x) { }

		internal bool <TranslateCommand>b__12_1(LightsState x) { }

		internal bool <UnloadChamber>b__24_1(GridItemAddress g) { }

		internal int <UnloadChamber>b__24_2(GridItemAddress g) { }

		internal bool <UnloadLauncher>b__25_1(GridItemAddress g) { }

		internal int <UnloadLauncher>b__25_2(GridItemAddress g) { }

		internal bool <UnloadMag>b__21_1(GridItemAddress g) { }

		internal int <UnloadMag>b__21_2(GridItemAddress g) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Magazine currentMagazine; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal GridItemAddress <UnloadMag>b__0(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Item ammoInChamber; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal GridItemAddress <UnloadChamber>b__0(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Ammo ammo; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal GridItemAddress <UnloadLauncher>b__0(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public FirearmHandsInputTranslator <>4__this; //Field offset: 0x10
		public Magazine currentMagazine; //Field offset: 0x18
		public Weapon weapon; //Field offset: 0x20

		public <>c__DisplayClass26_0() { }

		internal GridItemAddress <LoadAmmoToChamber>b__3(Grid grid) { }

		internal void <LoadAmmoToChamber>b__6(IResult error) { }

		internal bool <LoadAmmoToChamber>g__RunLoadAmmoToChamberOperation|1(Weapon weapon1) { }

		internal void <LoadAmmoToChamber>g__TryGetAmmoForWeapon|0(List ammoList, Weapon weapon2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_1
	{
		public Weapon weapon2; //Field offset: 0x10

		public <>c__DisplayClass26_1() { }

		internal bool <LoadAmmoToChamber>b__2(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Launcher launcher; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <Reload>b__0(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public Slot chamber; //Field offset: 0x10
		public FirearmHandsInputTranslator <>4__this; //Field offset: 0x18
		public Ammo containedAmmo; //Field offset: 0x20

		public <>c__DisplayClass28_0() { }

		internal bool <ReloadBarrels>b__0(Ammo ammo) { }

		internal GridItemAddress <ReloadBarrels>b__1(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public FirearmHandsInputTranslator <>4__this; //Field offset: 0x10
		public CylinderMagazine currentMagazine; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal bool <ReloadRevolverDrum>b__0(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public Weapon weapon; //Field offset: 0x10
		public FirearmHandsInputTranslator <>4__this; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal bool <ReloadWithAmmo>b__0(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Magazine currentMagazine; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal GridItemAddress <ReloadExternalMagazine>b__2(Grid grid) { }

	}

	private static readonly List _preAllocatedMagazinesList; //Field offset: 0x0
	private static readonly List _preAllocatedAmmoList; //Field offset: 0x8
	private readonly IFirearmHandsController _controller; //Field offset: 0x10
	private bool _firearmTriggerPressed; //Field offset: 0x18
	private readonly InventoryController _inventoryController; //Field offset: 0x20
	private readonly Player _player; //Field offset: 0x28

	private bool InIdleStateForInvokeOperation
	{
		private get { } //Length: 130
	}

	private bool IsPressTacticalInteraction
	{
		private get { } //Length: 204
		private set { } //Length: 305
	}

	private static FirearmHandsInputTranslator() { }

	internal FirearmHandsInputTranslator(Player player, IFirearmHandsController controller) { }

	[CompilerGenerated]
	private void <ChangeWeaponMode>b__17_0() { }

	private void ChangeLeftStance() { }

	private void ChangeWeaponMode(ECommand command) { }

	private bool get_InIdleStateForInvokeOperation() { }

	private bool get_IsPressTacticalInteraction() { }

	private ScopeState[] GetAllSightStatesAfterCalibration(bool increase) { }

	private LightsState[] GetCurrentLightStates() { }

	private ScopeState[] GetSightStateAfterChangeMagnification() { }

	private bool LoadAmmoToChamber() { }

	private void OnFoo() { }

	private void QuickReload() { }

	private bool Rechamber() { }

	private void Reload() { }

	private void ReloadBarrels(Weapon weapon) { }

	private bool ReloadExternalMagazine(Weapon weapon, bool quickReload) { }

	private void ReloadRevolverDrum(Weapon weapon, bool quickReload = false) { }

	private bool ReloadWithAmmo(Weapon weapon) { }

	private bool RollCylinder() { }

	private void set_IsPressTacticalInteraction(bool value) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

	private bool UnloadChamber() { }

	private void UnloadLauncher() { }

	private bool UnloadMag() { }

}

