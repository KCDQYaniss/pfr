//Type is in global namespace

public class AITaskManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public AISimpleTaskData tskData; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal void <UpdateSimpleTasks>b__0() { }

	}

	private class AIRegularTaskGroup
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			public AIRegularTaskData data; //Field offset: 0x10
			public float delta; //Field offset: 0x18

			public <>c__DisplayClass11_0() { }

			internal void <UpdateGroup>b__0() { }

		}

		internal class AIRegularTaskData
		{
			public int Id; //Field offset: 0x10
			public IAITaskUpdatable Updatable; //Field offset: 0x18
			public float LastUpdateTime; //Field offset: 0x20
			public bool RemoveRequested; //Field offset: 0x24

			public AIRegularTaskData() { }

		}

		public readonly float DefaultUpdatePeriod; //Field offset: 0x10
		public readonly int AverageTaskCount; //Field offset: 0x14
		public readonly float MaxUpdatePeriod; //Field offset: 0x18
		public readonly List Datas; //Field offset: 0x20
		public readonly Dictionary DataById; //Field offset: 0x28
		private int _idsCounter; //Field offset: 0x30
		private int _lastHandledIndex; //Field offset: 0x34

		public AIRegularTaskGroup(float defaultUpdPeriod, int avgTaskCount, float maxUpdPeriod) { }

		public int AddNewTask(IAITaskUpdatable updatable) { }

		public void Dispose() { }

		public void RemoveTask(int id) { }

		public void UpdateGroup(EAITaskGroupType groupType) { }

	}

	internal class AISimpleTaskData
	{
		public int Id; //Field offset: 0x10
		public Action Task; //Field offset: 0x18
		public float Delay; //Field offset: 0x20
		public float StartTime; //Field offset: 0x24
		public bool IsCancelRequested; //Field offset: 0x28
		public BotOwner Bot; //Field offset: 0x30

		public AISimpleTaskData() { }

		public void Dispose() { }

		public void Init(int id, Action task, float delay, float startTime, BotOwner bot) { }

	}

	private static readonly Stopwatch _taskMeasureSw; //Field offset: 0x0
	private readonly List _simpleTasks; //Field offset: 0x10
	private readonly Dictionary _simpleTaskById; //Field offset: 0x18
	private int _simpleTasksIdCounter; //Field offset: 0x20
	private readonly Dictionary _regularTasks; //Field offset: 0x28
	private readonly Dictionary _disposeInfoPerUpdatable; //Field offset: 0x30
	private readonly Queue _simpleTaskDataPool; //Field offset: 0x38

	private static AITaskManager() { }

	public AITaskManager() { }

	public void CancelDelayedTask(int taskId) { }

	public void Dispose() { }

	private static string GetRegularTaskName(AIRegularTaskData data) { }

	private static string GetSimpleTaskName(AISimpleTaskData tskData) { }

	private static void MeasureTaskStep(string stepName, Action action) { }

	private AISimpleTaskData PopSimpleData(Action task, float delay, BotOwner bot) { }

	private void PushSimpleData(AISimpleTaskData data) { }

	public int RegisterDelayedTask(float delay, Action task) { }

	public int RegisterDelayedTask(BotOwner bot, float delay, Action task) { }

	public void RegisterRegularTask(EAITaskGroupType group, IAITaskUpdatable task) { }

	public void UnregisterRegularTask(IAITaskUpdatable regularTask) { }

	public void Update() { }

	private void UpdateRegularTasks() { }

	private void UpdateSimpleTasks() { }

}

