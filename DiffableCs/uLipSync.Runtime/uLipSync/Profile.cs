namespace uLipSync;

[CreateAssetMenu(menuName = "uLipSync/Profile")]
public class Profile : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetPhonemeNames>b__24_0(MfccData x) { }

	}

	[HideInInspector]
	public string jsonPath; //Field offset: 0x18
	[Tooltip("The number of MFCC")]
	public int mfccNum; //Field offset: 0x20
	[Tooltip("The number of MFCC data to calculate the average MFCC values")]
	public int mfccDataCount; //Field offset: 0x24
	[Tooltip("The number of Mel Filter Bank channels")]
	public int melFilterBankChannels; //Field offset: 0x28
	[Tooltip("Target sampling rate to apply downsampling")]
	public int targetSampleRate; //Field offset: 0x2C
	[Tooltip("Number of audio samples after downsampling is applied")]
	public int sampleCount; //Field offset: 0x30
	[Tooltip("Whether to perform standardization of each coefficient of MFCC")]
	public bool useStandardization; //Field offset: 0x34
	[Tooltip("The comparison method for MFCC")]
	public CompareMethod compareMethod; //Field offset: 0x38
	public List mfccs; //Field offset: 0x40
	private float[] _means; //Field offset: 0x48
	private float[] _stdDevs; //Field offset: 0x50

	public float[] means
	{
		 get { } //Length: 5
	}

	public float[] standardDeviation
	{
		 get { } //Length: 5
	}

	public Profile() { }

	public void AddMfcc(string name) { }

	public void CalcMinMax(out float min, out float max) { }

	public static Profile Create() { }

	public bool Export(string path) { }

	public float[] get_means() { }

	public float[] get_standardDeviation() { }

	public NativeArray GetAverages(int index) { }

	public string GetPhoneme(int index) { }

	public string[] GetPhonemeNames() { }

	public bool Import(string path) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void RemoveMfcc(int index) { }

	public void Save() { }

	private void UpdateMeans() { }

	public void UpdateMeansAndStandardization() { }

	public void UpdateMfcc(int index, NativeArray mfcc, bool calib) { }

	private void UpdateStandardizations() { }

}

