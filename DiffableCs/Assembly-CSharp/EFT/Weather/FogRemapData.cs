namespace EFT.Weather;

[CreateAssetMenu]
public class FogRemapData : ScriptableObject
{
	[HideInInspector]
	[SerializeField]
	private int _hourCount; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private int _originalFogValueCount; //Field offset: 0x1C
	[HideInInspector]
	[SerializeField]
	private List _fogRemapRecords; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnChange; //Field offset: 0x28
	private List _lastUsedForInterpolateRecords; //Field offset: 0x30

	public event Action OnChange
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public int HourCount
	{
		 get { } //Length: 4
	}

	public List LastUsedForInterpolateRecords
	{
		 get { } //Length: 76
	}

	public int OriginalFogValueCount
	{
		 get { } //Length: 4
	}

	public FogRemapData() { }

	[CompilerGenerated]
	public void add_OnChange(Action value) { }

	public int AddHour(float value) { }

	public int AddOriginalFogValue(float value) { }

	private void FindLeftRightLists(float hour, out List left, out List right, out int leftHourIdx, out int rightHourIdx) { }

	private static bool FindLowHighRecords(float fog, List list, out FogRemapRecord low, out FogRemapRecord hi, out int lowFogIdx, out int hiFogIdx) { }

	public int get_HourCount() { }

	public List get_LastUsedForInterpolateRecords() { }

	public int get_OriginalFogValueCount() { }

	public float GetHour(int index) { }

	public float GetOriginalFogValue(int index) { }

	public FogRemapRecord GetRecord(int hourIndex, int originalForValueIndex) { }

	private FogRemapRecord InterpolateFogParameters(float fog, float hour, FogRemapRecord leftLow, FogRemapRecord leftHigh, FogRemapRecord rightLow, FogRemapRecord rightHigh) { }

	private static float InterpolateFourFloats(float fog, float hour, float lowFog, float highFog, float leftHour, float rightHour, float leftLow, float leftHigh, float rightLow, float rightHigh) { }

	public float RemapFogValue(float fog, float hour, out FogRemapRecord interpolatedParameters) { }

	[CompilerGenerated]
	public void remove_OnChange(Action value) { }

	public void RemoveHourAt(int index) { }

	public void RemoveOriginalFogValueAt(int index) { }

	public void SetHour(int index, float value) { }

	public void SetOriginalFogValue(int index, float value) { }

	public void SetRecord(int hourIndex, int originalForValueIndex, FogRemapRecord record) { }

}

