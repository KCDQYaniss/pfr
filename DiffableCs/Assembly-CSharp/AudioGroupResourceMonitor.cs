//Type is in global namespace

public class AudioGroupResourceMonitor : IAudioGroupResourceMonitor
{
	[CompilerGenerated]
	private sealed class <MonitoringCoroutine>d__27 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioGroupResourceMonitor <>4__this; //Field offset: 0x20
		private WaitForSecondsRealtime <wait>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <MonitoringCoroutine>d__27(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct ResourceUsageThreshold
	{
		public readonly float low; //Field offset: 0x0
		public readonly float high; //Field offset: 0x4
		public readonly float critical; //Field offset: 0x8

		public ResourceUsageThreshold(float low, float high, float critical) { }

	}

	private static readonly ResourceUsageThreshold _defaultThresholdLevels; //Field offset: 0x0
	private readonly Dictionary _groupThresholds; //Field offset: 0x10
	private readonly Dictionary _groupStates; //Field offset: 0x18
	private readonly BetterAudio _betterAudio; //Field offset: 0x20
	private float _monitoringInterval; //Field offset: 0x28
	private bool _resourcesCritical; //Field offset: 0x2C
	private bool _monitoringRequested; //Field offset: 0x2D
	private Coroutine _monitoringCoroutine; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnLowResources; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnCriticalResources; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnGroupCriticalResources; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnResourcesRestored; //Field offset: 0x50

	public override event Action OnCriticalResources
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnGroupCriticalResources
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnLowResources
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnResourcesRestored
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	private static AudioGroupResourceMonitor() { }

	public AudioGroupResourceMonitor(BetterAudio betterAudio) { }

	[CompilerGenerated]
	public override void add_OnCriticalResources(Action value) { }

	[CompilerGenerated]
	public override void add_OnGroupCriticalResources(Action value) { }

	[CompilerGenerated]
	public override void add_OnLowResources(Action value) { }

	[CompilerGenerated]
	public override void add_OnResourcesRestored(Action value) { }

	private void CheckOverallCritical(float overallPercent, bool anyCritical) { }

	private float ComputeOverallPercent() { }

	private EGroupResourcesState GetGroupState(float groupUsagePercent, in ResourceUsageThreshold thresholds) { }

	public float GetPoolUsagePercent(AudioSourceGroupType groupType) { }

	[IteratorStateMachine(typeof(<MonitoringCoroutine>d__27))]
	private IEnumerator MonitoringCoroutine() { }

	private void ProcessGroupResource(AudioSourceGroupType groupType, in ResourceUsageThreshold thresholds, ref bool anyCritical) { }

	[CompilerGenerated]
	public override void remove_OnCriticalResources(Action value) { }

	[CompilerGenerated]
	public override void remove_OnGroupCriticalResources(Action value) { }

	[CompilerGenerated]
	public override void remove_OnLowResources(Action value) { }

	[CompilerGenerated]
	public override void remove_OnResourcesRestored(Action value) { }

	public override void SetMonitoringInterval(float interval) { }

	public override void SetResourceThreshold(AudioSourceGroupType groupType, float lowThreshold, float highThreshold, float criticalThreshold) { }

	public override void StartMonitoring(float interval = 0.5) { }

	public override void StopMonitoring() { }

}

