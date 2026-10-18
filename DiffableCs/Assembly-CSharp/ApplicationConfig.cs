//Type is in global namespace

public class ApplicationConfig
{
	internal class CharacterControllerSettings
	{
		public Mode ObservedPlayerMode; //Field offset: 0x10
		public Mode ClientPlayerMode; //Field offset: 0x18
		public Mode BotPlayerMode; //Field offset: 0x20

		public CharacterControllerSettings() { }

	}

	internal class LogConfig
	{
		public bool DisableAllLogs; //Field offset: 0x10
		public float UpdateMetricsInterval; //Field offset: 0x14
		public Config FrameMeasurerLoggerConfig; //Field offset: 0x18
		public int FramesCountForAvgForTimeMeasurers; //Field offset: 0x20
		public int FramesCountForAvgForIncrementMeasurers; //Field offset: 0x24

		public LogConfig() { }

	}

	internal class NetworkConfig
	{
		public int FrameDiffForCorruptedTrigger; //Field offset: 0x10

		public NetworkConfig() { }

	}

	internal class PhysicsSettings
	{
		public bool OverrideMBPSettings; //Field offset: 0x10
		public Bounds OverrideMBPBounds; //Field offset: 0x14
		public int OverrideMBPSubdivisions; //Field offset: 0x2C
		public bool ManualUpdate; //Field offset: 0x30
		public Settings CullingForLoot; //Field offset: 0x34
		public Settings CullingForGrenade; //Field offset: 0x3C

		public PhysicsSettings() { }

	}

	internal class PoolsSettings
	{
		public int AmmoPoolSize; //Field offset: 0x10
		public int WeaponsPoolSize; //Field offset: 0x14
		public int MagsPoolSize; //Field offset: 0x18
		public int ItemsPoolSize; //Field offset: 0x1C
		public int PlayersPoolSize; //Field offset: 0x20
		public Dictionary AutoMaintainMinPoolSize; //Field offset: 0x28
		public int FreeFrameTimeWindow; //Field offset: 0x30
		public int AvgTimeBufferSize; //Field offset: 0x34
		public float MaxAvgFrameLoad; //Field offset: 0x38
		public bool ContinuationProfilerEnabled; //Field offset: 0x3C

		public PoolsSettings() { }

	}

	internal class ProfilingSettings
	{
		public bool EnableInGameSpikeAnalyzer; //Field offset: 0x10
		public EPauseReason PauseReason; //Field offset: 0x11
		public DetectType DetectType; //Field offset: 0x14
		public float TriggerTime; //Field offset: 0x18
		public int FramesCountPerFile; //Field offset: 0x1C
		public string WorkingDirectory; //Field offset: 0x20
		public ProfilerArea[] ProfilingAreas; //Field offset: 0x28

		public ProfilingSettings() { }

	}

	public string BackendUrl; //Field offset: 0x10
	public string MatchingVersion; //Field offset: 0x18
	public string BuildVersion; //Field offset: 0x20
	public ERaidMode RaidMode; //Field offset: 0x28
	public PoolsSettings Pools; //Field offset: 0x30
	public int TargetFrameRate; //Field offset: 0x38
	public bool ResetSettings; //Field offset: 0x3C
	public bool UseSpiritPlayer; //Field offset: 0x3D
	public bool UseSpiritFastAnimator; //Field offset: 0x3E
	public bool UseBodyFastAnimator; //Field offset: 0x3F
	public bool UseHandsFastAnimator; //Field offset: 0x40
	public bool DevelopMode; //Field offset: 0x41
	public float FixedFrameRate; //Field offset: 0x44
	public int QualitySettingsAsyncUploadTimeSlice; //Field offset: 0x48
	public int QualitySettingsAsyncUploadBufferSize; //Field offset: 0x4C
	public bool LogWhenShaderIsCompiled; //Field offset: 0x50
	public bool ShowSpiritImage; //Field offset: 0x51
	public bool UseSpiritHack; //Field offset: 0x52
	public ProfilingSettings Profiling; //Field offset: 0x58
	public float MaximumDeltaTime; //Field offset: 0x60
	public int SingleFixedUpdatesMeasurerCountForAVG; //Field offset: 0x64
	public CharacterControllerSettings CharacterController; //Field offset: 0x68
	public PhysicsSettings Physics; //Field offset: 0x70
	public NetworkConfig Network; //Field offset: 0x78
	public float CorpseSyncThreshold; //Field offset: 0x80
	public float DelayToOpenContainer; //Field offset: 0x84
	public bool NoLootForLocalGame; //Field offset: 0x88
	public int IconSaverScaleFactor; //Field offset: 0x8C
	public float LoadForceModeMultiplier; //Field offset: 0x90
	public LogConfig Log; //Field offset: 0x98

	public ApplicationConfig() { }

	public bool PatchConfig(string json) { }

}

