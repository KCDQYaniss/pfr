namespace EFT.UI.Matchmaker;

public class MatchingProgress
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__IsUnskippableStageGroup; //Field offset: 0x0

	}

	[CompilerGenerated]
	private Action StatusUpdateEvent; //Field offset: 0x10
	[CompilerGenerated]
	private Action MatchingProgressChangedEvent; //Field offset: 0x18
	[CompilerGenerated]
	private EMatchingStage <CurrentStage>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EMatchingStageGroup <CurrentStageGroup>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Nullable <CurrentStageProgress>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable <EstimateTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsAbortAvailable>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <BlockAbortAbilityDurationSeconds>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <ShowAbortConfirmationPopup>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsMatchingAbortRequested>k__BackingField; //Field offset: 0x49
	[CompilerGenerated]
	private Nullable <LastMemorizedDelayedStage>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private Nullable <LastMemorizedDelayedStageProgress>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <CanProcessServerStages>k__BackingField; //Field offset: 0x5C

	public event Action MatchingProgressChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action StatusUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private int BlockAbortAbilityDurationSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool CanAbortMatching
	{
		 get { } //Length: 8
	}

	public private bool CanProcessServerStages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EMatchingStage CurrentStage
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EMatchingStageGroup CurrentStageGroup
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Nullable CurrentStageProgress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Nullable EstimateTime
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool IsAbortAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsMatchingAbortRequested
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Nullable LastMemorizedDelayedStage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Nullable LastMemorizedDelayedStageProgress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool ShowAbortConfirmationPopup
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private DateTime StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public MatchingProgress() { }

	[CompilerGenerated]
	private void <Update>b__56_0() { }

	[CompilerGenerated]
	public void add_MatchingProgressChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_StatusUpdateEvent(Action value) { }

	private bool CanProcessNextStage(EMatchingStage stage) { }

	public void Dispose() { }

	[CompilerGenerated]
	public int get_BlockAbortAbilityDurationSeconds() { }

	public bool get_CanAbortMatching() { }

	[CompilerGenerated]
	public bool get_CanProcessServerStages() { }

	[CompilerGenerated]
	public EMatchingStage get_CurrentStage() { }

	[CompilerGenerated]
	public EMatchingStageGroup get_CurrentStageGroup() { }

	[CompilerGenerated]
	public Nullable get_CurrentStageProgress() { }

	[CompilerGenerated]
	public Nullable get_EstimateTime() { }

	[CompilerGenerated]
	public bool get_IsAbortAvailable() { }

	[CompilerGenerated]
	public bool get_IsMatchingAbortRequested() { }

	[CompilerGenerated]
	public Nullable get_LastMemorizedDelayedStage() { }

	[CompilerGenerated]
	public Nullable get_LastMemorizedDelayedStageProgress() { }

	[CompilerGenerated]
	public bool get_ShowAbortConfirmationPopup() { }

	[CompilerGenerated]
	public DateTime get_StartTime() { }

	private void HandleStageUpdate(EMatchingStage stage, Nullable progress) { }

	public bool IsNextStageGroup(EMatchingStage stage, Nullable comparativeStage = null) { }

	public bool IsPreviousStageGroup(EMatchingStage stage, Nullable comparativeStage = null) { }

	private void MemorizeStage(EMatchingStage stage, Nullable progress) { }

	[CompilerGenerated]
	public void remove_MatchingProgressChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_StatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	private void set_BlockAbortAbilityDurationSeconds(int value) { }

	[CompilerGenerated]
	private void set_CanProcessServerStages(bool value) { }

	[CompilerGenerated]
	private void set_CurrentStage(EMatchingStage value) { }

	[CompilerGenerated]
	private void set_CurrentStageGroup(EMatchingStageGroup value) { }

	[CompilerGenerated]
	private void set_CurrentStageProgress(Nullable value) { }

	[CompilerGenerated]
	private void set_EstimateTime(Nullable value) { }

	[CompilerGenerated]
	private void set_IsAbortAvailable(bool value) { }

	[CompilerGenerated]
	private void set_IsMatchingAbortRequested(bool value) { }

	[CompilerGenerated]
	private void set_LastMemorizedDelayedStage(Nullable value) { }

	[CompilerGenerated]
	private void set_LastMemorizedDelayedStageProgress(Nullable value) { }

	[CompilerGenerated]
	private void set_ShowAbortConfirmationPopup(bool value) { }

	[CompilerGenerated]
	private void set_StartTime(DateTime value) { }

	public void SetAbortAvailability(bool abortAvailable, Nullable blockAbortAbilityDurationSeconds = null, Nullable showAbortConfirmationPopup = null) { }

	private void SetCurrentStage(EMatchingStage stage, Nullable progress, EMatchingStageGroup newStageGroup) { }

	public void SetEstimateTime(int estimateTime) { }

	public void SetIsMatchingAbortRequested(bool requested) { }

	public void SetStartTime(DateTime time) { }

	public void Update(EMatchingStage stage, Nullable progress) { }

}

