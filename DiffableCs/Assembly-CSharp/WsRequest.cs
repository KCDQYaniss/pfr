//Type is in global namespace

public sealed class WsRequest : IDisposable
{
	[CompilerGenerated]
	private struct <SerializeWireDataAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsRequest <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum WsRequestStatus
	{
		NonInitialized = 0,
		InProgress = 1,
		FinishiedWithResponse = 2,
		FinishedWithException = 3,
	}

	private WsRequestJson _requestJson; //Field offset: 0x10
	private string _requestId; //Field offset: 0x18
	private bool _isPipelineActive; //Field offset: 0x20
	public int _timeoutSeconds; //Field offset: 0x24
	public DateTime _creationTime; //Field offset: 0x28
	[CompilerGenerated]
	private WsRequestStatus <Status>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private WsResponseJson <ResultResponse>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Exception <ResultException>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <ReceivingConfirmed>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private byte[] <RequestWireData>k__BackingField; //Field offset: 0x50

	public bool IsFinished
	{
		 get { } //Length: 17
	}

	public bool IsPipelineActive
	{
		 get { } //Length: 5
	}

	public private bool ReceivingConfirmed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string RequestId
	{
		 get { } //Length: 5
	}

	public private byte[] RequestWireData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Exception ResultException
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private WsResponseJson ResultResponse
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private WsRequestStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public WsRequest() { }

	[CompilerGenerated]
	private byte[] <SerializeWireDataAsync>b__37_0() { }

	public void BeginPipeline() { }

	public bool CheckTimedOut() { }

	public void ConfirmReceiveFromServer() { }

	public override void Dispose() { }

	public void EndPipeline() { }

	public void FinishWithException(Exception exc) { }

	public void FinishWithResponse(WsResponseJson responseJson) { }

	public void FinishWithTimeout() { }

	public bool get_IsFinished() { }

	public bool get_IsPipelineActive() { }

	[CompilerGenerated]
	public bool get_ReceivingConfirmed() { }

	public string get_RequestId() { }

	[CompilerGenerated]
	public byte[] get_RequestWireData() { }

	[CompilerGenerated]
	public Exception get_ResultException() { }

	[CompilerGenerated]
	public WsResponseJson get_ResultResponse() { }

	[CompilerGenerated]
	public WsRequestStatus get_Status() { }

	public void Initialize(WsRequestJson json, int timeoutSec) { }

	private void ResetForReuse() { }

	[AsyncStateMachine(typeof(<SerializeWireDataAsync>d__37))]
	public Task SerializeWireDataAsync() { }

	[CompilerGenerated]
	private void set_ReceivingConfirmed(bool value) { }

	[CompilerGenerated]
	private void set_RequestWireData(byte[] value) { }

	[CompilerGenerated]
	private void set_ResultException(Exception value) { }

	[CompilerGenerated]
	private void set_ResultResponse(WsResponseJson value) { }

	[CompilerGenerated]
	private void set_Status(WsRequestStatus value) { }

}

