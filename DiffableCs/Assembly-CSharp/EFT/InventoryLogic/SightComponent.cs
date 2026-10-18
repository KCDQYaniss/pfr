namespace EFT.InventoryLogic;

public class SightComponent : ItemComponent
{
	public Vector3[][] OpticCalibrationPoints; //Field offset: 0x18
	private ISightComponentTemplate _template; //Field offset: 0x20
	[Diffable]
	public int[] ScopesCurrentCalibPointIndexes; //Field offset: 0x28
	[Diffable]
	public int[] ScopesSelectedModes; //Field offset: 0x30
	[Diffable]
	public int SelectedScope; //Field offset: 0x38
	[Diffable]
	public float ScopeZoomValue; //Field offset: 0x3C

	public IAdjustableOpticData AdjustableOpticData
	{
		 get { } //Length: 5
	}

	public string CustomAimPlane
	{
		 get { } //Length: 78
	}

	public float GetCurrentSensitivity
	{
		 get { } //Length: 200
	}

	public int ScopesCount
	{
		 get { } //Length: 75
	}

	public int SelectedScopeIndex
	{
		 get { } //Length: 4
		 set { } //Length: 157
	}

	public int SelectedScopeMode
	{
		 get { } //Length: 61
		 set { } //Length: 186
	}

	public SightComponent(Item item, ISightComponentTemplate template) { }

	public IAdjustableOpticData get_AdjustableOpticData() { }

	public string get_CustomAimPlane() { }

	public float get_GetCurrentSensitivity() { }

	public int get_ScopesCount() { }

	public int get_SelectedScopeIndex() { }

	public int get_SelectedScopeMode() { }

	public int GetCurrentOpticCalibrationDistance() { }

	public Vector3 GetCurrentOpticCalibrationPoint() { }

	private int GetCurrentOpticCalibrationPointIndex(int scopeIndex) { }

	public float GetCurrentOpticZoom() { }

	public float GetMaxOpticZoom() { }

	public float GetMinOpticZoom() { }

	public int[] GetScopeCalibrationDistances(int scopeIndex) { }

	public int GetScopeModesCount(int scopeIndex) { }

	public bool HasCurrentZoomGreaterThenOne() { }

	public bool HasOpticCalibrationPoints(int scopeIndex) { }

	public bool OpticCalibrationPointDown() { }

	public bool OpticCalibrationPointUp() { }

	public void set_SelectedScopeIndex(int value) { }

	public void set_SelectedScopeMode(int value) { }

	public void SetScopeCaliabrationPoints(int scopeIndex, Vector3[] points) { }

	public void SetScopeMode(int scopeIndex, int mode) { }

	public void SetSelectedOpticCalibrationPoint(int scope, int index) { }

}

