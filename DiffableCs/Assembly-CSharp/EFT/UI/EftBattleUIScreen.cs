namespace EFT.UI;

public sealed class EftBattleUIScreen : BattleUIScreen
{
	internal abstract class EftBattleUIScreenController : EftScreenController, IBattleUIScreenController
	{
		[CompilerGenerated]
		private readonly GamePlayerOwner <Owner>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private InsuranceCompany <Insurance>k__BackingField; //Field offset: 0x60
		private Func _azimuthGetter; //Field offset: 0x68

		public override bool AllowHealthPanel
		{
			 get { } //Length: 3
		}

		public override bool AllowQuickPanel
		{
			 get { } //Length: 3
		}

		public override bool AllowStancePanel
		{
			 get { } //Length: 3
		}

		public override bool AmmoSelectorAvailable
		{
			 get { } //Length: 54
		}

		public override bool AzimuthActive
		{
			 get { } //Length: 9
		}

		protected virtual EStateSwitcher CameraBlur
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public override GesturesQuickPanel GesturesQuickPanel
		{
			 get { } //Length: 69
		}

		protected virtual EStateSwitcher IgnorePlayerInput
		{
			 get { } //Length: 6
		}

		public override InsuranceCompany Insurance
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public override GamePlayerOwner Owner
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		protected EftBattleUIScreenController(GamePlayerOwner owner) { }

		public override bool get_AllowHealthPanel() { }

		public override bool get_AllowQuickPanel() { }

		public override bool get_AllowStancePanel() { }

		public override bool get_AmmoSelectorAvailable() { }

		public override bool get_AzimuthActive() { }

		protected virtual EStateSwitcher get_CameraBlur() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public override GesturesQuickPanel get_GesturesQuickPanel() { }

		protected virtual EStateSwitcher get_IgnorePlayerInput() { }

		[CompilerGenerated]
		public override InsuranceCompany get_Insurance() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public override GamePlayerOwner get_Owner() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

		public override void HideAzimuthPanel() { }

		[CompilerGenerated]
		protected void set_Insurance(InsuranceCompany value) { }

		public override void ShowAmmoCountZeroingPanel(string message) { }

		public override void ShowAmmoDetails(int ammoCount, int maxAmmoCount, int mastering, string details, bool foldingMechanimWeapon) { }

		public override void ShowAzimuthPanel(Func valueGetter) { }

		public override void ShowFireMode(EFireMode fireMode) { }

		public override void ShowRaidTime() { }

		protected virtual bool ShowScreenAsPrevious() { }

		public abstract void SubscribeOnMalfunctions(Action func) { }

		public abstract void UnsubscribeFromMalfunctions(Action func) { }

	}

	internal sealed class HideoutBattleUIScreenController : EftBattleUIScreenController
	{
		private IBaseScreenController _hideoutScreenController; //Field offset: 0x70
		private readonly HideoutPlayerOwner _hideoutPlayerOwner; //Field offset: 0x78
		private bool _shootingRangeStatus; //Field offset: 0x80

		public virtual bool AllowHealthPanel
		{
			 get { } //Length: 3
		}

		public virtual bool AllowQuickPanel
		{
			 get { } //Length: 8
		}

		public virtual bool AllowStancePanel
		{
			 get { } //Length: 8
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 6
		}

		public HideoutBattleUIScreenController(HideoutPlayerOwner owner) { }

		protected virtual void CloseAction(bool moveForward) { }

		protected virtual Task CloseCurrentScreen(bool forced) { }

		public virtual bool get_AllowHealthPanel() { }

		public virtual bool get_AllowQuickPanel() { }

		public virtual bool get_AllowStancePanel() { }

		public virtual bool get_KeyScreen() { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		private void OnShootingRangeStatus(bool status) { }

		protected virtual void ShowAction(BattleUIScreen screen) { }

		public virtual void ShowScreen(EScreenState screenState) { }

		protected virtual bool ShowScreenAsPrevious() { }

		private void Subscribe() { }

		public virtual void SubscribeOnMalfunctions(Action func) { }

		private void UnSubscribe() { }

		public virtual void UnsubscribeFromMalfunctions(Action func) { }

		private void UpdatePointerVisibility() { }

	}

	internal sealed class RaidBattleUIScreenController : EftBattleUIScreenController
	{
		private GameDateTime _dateTime; //Field offset: 0x70
		private Location _location; //Field offset: 0x78
		private bool _firstShow; //Field offset: 0x80

		protected virtual EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 6
		}

		public RaidBattleUIScreenController(GamePlayerOwner owner, GameDateTime dateTime, Location location, InsuranceCompany insurance) { }

		protected virtual void CloseAction(bool moveForward) { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		protected virtual void ShowAction(BattleUIScreen screen) { }

		private void ShowPointer(bool value) { }

		private void ShowRaidStartInfo() { }

		public virtual void SubscribeOnMalfunctions(Action func) { }

		public virtual void UnsubscribeFromMalfunctions(Action func) { }

		private void UpdateQuestPointer(bool haveAnyQuestItem, Vector3 nearestQuestItem) { }

	}


	public EftBattleUIScreen() { }

}

