namespace AnimationSystem.RootMotionTable;

[CreateAssetMenu]
public class RootMotionBlendTable : ScriptableObject, IBlendParametersKeeper
{
	internal struct ParameterRelatedCurve
	{
		public AnimationCurve curve; //Field offset: 0x0
		public int parameterHash; //Field offset: 0x8

	}

	internal class ParameterSettings
	{
		public string ParamName; //Field offset: 0x10
		public float MinValue; //Field offset: 0x18
		public float MaxValue; //Field offset: 0x1C
		public float StepDensity; //Field offset: 0x20
		private int _cachedTotalSteps; //Field offset: 0x24

		public float Range
		{
			 get { } //Length: 18
		}

		public int TotalSteps
		{
			 get { } //Length: 47
		}

		public ParameterSettings() { }

		public float get_Range() { }

		public int get_TotalSteps() { }

		public void GetStep(out int indexA, out int indexB, out float t, float value) { }

		public float GetValue(int step) { }

	}

	public TextAsset GeneratedData; //Field offset: 0x18
	public string AnimatorPath; //Field offset: 0x20
	public string ClipsKeeperPath; //Field offset: 0x28
	public string RootBoneName; //Field offset: 0x30
	public List Parameters; //Field offset: 0x38
	public List StoreRotationStatesWhitelist; //Field offset: 0x40
	public List UsingCurvesForDPClipNames; //Field offset: 0x48
	public Dictionary _loadedNodes; //Field offset: 0x50

	public RootMotionBlendTable() { }

	public override ParameterSettings GetParameter(int paramHash) { }

	public ParameterSettings GetParameter(string paramName) { }

	public bool IsValidClipForCurvesDP(string clipName) { }

	public bool IsValidStateToStoreRotation(string stateName) { }

	public void LoadNodes() { }

}

