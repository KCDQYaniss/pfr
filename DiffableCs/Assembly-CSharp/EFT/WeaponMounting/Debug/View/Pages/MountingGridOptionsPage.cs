namespace EFT.WeaponMounting.Debug.View.Pages;

public class MountingGridOptionsPage : IMountingPage
{
	private readonly MountingPageViewer _pageViewer; //Field offset: 0x10
	private readonly IMountingPointDetectionSettings _mountingPointDetectionSettings; //Field offset: 0x18
	private string _edgeDetectionDistance; //Field offset: 0x20
	private string _maxHorizontalMountAngleDotDelta; //Field offset: 0x28
	private string _maxVerticalMountAngleDotDelta; //Field offset: 0x30
	private string _verticalGridMaxHeight; //Field offset: 0x38
	private string _verticalGridMinHeight; //Field offset: 0x40
	private string _verticalGridSize; //Field offset: 0x48
	private string _horizontalGridSize; //Field offset: 0x50
	private string _verticalGridStepsAmount; //Field offset: 0x58
	private string _horizontalGridStepsAmount; //Field offset: 0x60
	private string _secondCheckVerticalDistance; //Field offset: 0x68
	private string _secondCheckVerticalGridSize; //Field offset: 0x70
	private string _secondCheckVerticalGridSizeStepsAmount; //Field offset: 0x78
	private string _secondCheckVerticalGridOffset; //Field offset: 0x80
	private string _checkWallOffset; //Field offset: 0x88
	private string _checkHorizontalSecondaryOffset; //Field offset: 0x90
	private string _maxFramesForRaycast; //Field offset: 0x98
	private string _pointBaseOffset; //Field offset: 0xA0
	private bool _isSubmitButtonClick; //Field offset: 0xA8
	private bool _isBackButtonClick; //Field offset: 0xA9
	private bool _isInputBadData; //Field offset: 0xAA
	private bool _isSuccessUpdateData; //Field offset: 0xAB

	public MountingGridOptionsPage(MountingPageViewer pageViewer, IMountingPointDetectionSettings mountingPointDetectionSettings) { }

	private void CheckActions() { }

	private void DrawHorizontalSettingsTable() { }

	private void DrawVerticalSettingsTable() { }

	private GUIStyle GetBadDataStyle() { }

	private GUIStyle GetHeaderStyle() { }

	private GUIStyle GetInputFieldStyle() { }

	private GUIStyle GetParameterStyle() { }

	private GUIStyle GetSuccessDataStyle() { }

	private void SetInitialParameters() { }

	private void TryUpdateModel() { }

	public override void Update() { }

}

