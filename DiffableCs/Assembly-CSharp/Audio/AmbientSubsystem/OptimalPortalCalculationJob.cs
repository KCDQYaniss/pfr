namespace Audio.AmbientSubsystem;

[BurstCompile]
internal struct OptimalPortalCalculationJob : IJob
{
	private const float SCORE_DELTA = 0.05; //Field offset: 0x0
	[ReadOnly]
	public NativeArray calculatedPortalData; //Field offset: 0x0
	[WriteOnly]
	public NativeArray optimalCalculatedPortalData; //Field offset: 0x10

	public override void Execute() { }

	private static bool IsScoresApproximately(float scoreToCompare, float optimalScore) { }

}

