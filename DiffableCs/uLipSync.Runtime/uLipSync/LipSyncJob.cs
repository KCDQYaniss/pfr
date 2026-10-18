namespace uLipSync;

[BurstCompile]
public struct LipSyncJob : IJob
{
	internal struct Info
	{
		public float volume; //Field offset: 0x0
		public int mainPhonemeIndex; //Field offset: 0x4

	}

	[ReadOnly]
	public NativeArray input; //Field offset: 0x0
	[ReadOnly]
	public int startIndex; //Field offset: 0x10
	[ReadOnly]
	public int outputSampleRate; //Field offset: 0x14
	[ReadOnly]
	public int targetSampleRate; //Field offset: 0x18
	[ReadOnly]
	public int melFilterBankChannels; //Field offset: 0x1C
	[ReadOnly]
	public CompareMethod compareMethod; //Field offset: 0x20
	[ReadOnly]
	public NativeArray means; //Field offset: 0x28
	[ReadOnly]
	public NativeArray standardDeviations; //Field offset: 0x38
	[ReadOnly]
	public NativeArray phonemes; //Field offset: 0x48
	public NativeArray mfcc; //Field offset: 0x58
	public NativeArray scores; //Field offset: 0x68
	public NativeArray info; //Field offset: 0x78

	private int cutoff
	{
		private get { } //Length: 9
	}

	private int range
	{
		private get { } //Length: 6
	}

	private float CalcCosineSimilarityScore(int index) { }

	private float CalcL1NormScore(int index) { }

	private float CalcL2NormScore(int index) { }

	private float CalcScore(int index) { }

	private void CalcScores() { }

	public override void Execute() { }

	private int get_cutoff() { }

	private int get_range() { }

	private int GetVowel() { }

}

