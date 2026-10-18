//Type is in global namespace

public class AsyncRaycastsBatchManager
{
	internal class BatchData
	{
		private readonly string _batchId; //Field offset: 0x10
		private readonly List _registeredContainers; //Field offset: 0x18
		private JobHandle _castHandle; //Field offset: 0x20
		private NativeArray _commands; //Field offset: 0x30
		private NativeArray _results; //Field offset: 0x40
		private bool _batchInProgress; //Field offset: 0x50

		public BatchData(string batchid) { }

		public void CheckCompleteBatch() { }

		public void Dispose() { }

		public void ExecuteBatch() { }

		public void RegisterContainer(RaycastJobContainer container) { }

		public void UnregisterContainer(RaycastJobContainer container) { }

	}

	internal class RaycastJobContainer
	{
		private BatchData _rootData; //Field offset: 0x10
		[CompilerGenerated]
		private RaycastCommand <Command>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private RaycastHit <Result>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private bool <Cocked>k__BackingField; //Field offset: 0x74
		[CompilerGenerated]
		private bool <ResultIsActual>k__BackingField; //Field offset: 0x75

		public private bool Cocked
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private RaycastCommand Command
		{
			[CompilerGenerated]
			 get { } //Length: 27
			[CompilerGenerated]
			private set { } //Length: 24
		}

		public private RaycastHit Result
		{
			[CompilerGenerated]
			 get { } //Length: 35
			[CompilerGenerated]
			private set { } //Length: 32
		}

		public private bool ResultIsActual
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public RaycastJobContainer(BatchData root) { }

		public void CheckCompleteBatch() { }

		public void Dispose() { }

		[CompilerGenerated]
		public bool get_Cocked() { }

		[CompilerGenerated]
		public RaycastCommand get_Command() { }

		[CompilerGenerated]
		public RaycastHit get_Result() { }

		[CompilerGenerated]
		public bool get_ResultIsActual() { }

		[CompilerGenerated]
		private void set_Cocked(bool value) { }

		[CompilerGenerated]
		private void set_Command(RaycastCommand value) { }

		[CompilerGenerated]
		private void set_Result(RaycastHit value) { }

		[CompilerGenerated]
		private void set_ResultIsActual(bool value) { }

		public void SetNewCommand(RaycastCommand newCommand) { }

		public void SetResult(RaycastHit result) { }

	}

	private static AsyncRaycastsBatchManager _instance; //Field offset: 0x0
	private readonly Dictionary _batchDataById; //Field offset: 0x10

	public static AsyncRaycastsBatchManager Instance
	{
		 get { } //Length: 383
	}

	public AsyncRaycastsBatchManager() { }

	public RaycastJobContainer CreateContainerForBatch(string batchId) { }

	public void ExecuteBatch(string batchId) { }

	public static AsyncRaycastsBatchManager get_Instance() { }

	public void ManuallyCompleteBatch(string batchId) { }

}

