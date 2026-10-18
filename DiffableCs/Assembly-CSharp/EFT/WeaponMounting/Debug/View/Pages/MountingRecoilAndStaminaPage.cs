namespace EFT.WeaponMounting.Debug.View.Pages;

public sealed class MountingRecoilAndStaminaPage : IMountingPage
{
	private readonly MountingPageViewer _pageViewer; //Field offset: 0x10
	private readonly Player _player; //Field offset: 0x18
	private string _mountingRecoilMultiplierVertical; //Field offset: 0x20
	private string _mountingRecoilMultiplierHorizontal; //Field offset: 0x28
	private string _mountingReturnSpeedHandMultiplier; //Field offset: 0x30
	private string _mountingCameraSnapMultiplier; //Field offset: 0x38
	private string _mountingStaminaMultiplierVertical; //Field offset: 0x40
	private string _mountingStaminaMultiplierHorizontal; //Field offset: 0x48
	private string _mountingVerticalOutOfBreathShakeMultiplier; //Field offset: 0x50
	private string _mountingHorizontalOutOfBreathShakeMultiplier; //Field offset: 0x58
	private string _bipodRecoilMultiplier; //Field offset: 0x60
	private string _bipodReturnSpeedHandMultiplier; //Field offset: 0x68
	private string _bipodCameraSnapMultiplier; //Field offset: 0x70
	private string _bipodStaminaMultiplier; //Field offset: 0x78
	private string _bipodOutOfBreathShakeMultiplier; //Field offset: 0x80
	private string _bipodMotionMultiplier; //Field offset: 0x88
	private bool _isSubmitButtonClick; //Field offset: 0x90
	private bool _isBackButtonClick; //Field offset: 0x91
	private bool _showMounting; //Field offset: 0x92
	private bool _showBipod; //Field offset: 0x93
	private bool _hasBipod; //Field offset: 0x94
	private bool _isInputBadData; //Field offset: 0x95
	private bool _isSuccessUpdateData; //Field offset: 0x96

	public MountingRecoilAndStaminaPage(MountingPageViewer viewer, Player player) { }

	private void CheckActions() { }

	private GUIStyle GetBadDataStyle() { }

	private GUIStyle GetHeaderStyle() { }

	private GUIStyle GetInputFieldStyle() { }

	private GUIStyle GetParameterStyle() { }

	private GUIStyle GetSuccessDataStyle() { }

	private void SetInitialParameters(AbstractHandsController _, AbstractHandsController newHands) { }

	private void TryUpdateModel() { }

	public override void Update() { }

	private void UpdateBipod() { }

	private void UpdateMounting() { }

}

