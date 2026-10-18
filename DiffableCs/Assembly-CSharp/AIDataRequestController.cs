//Type is in global namespace

public class AIDataRequestController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public BotRequestType type; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <CanAddByCount>b__0(BotRequest x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public BotRequest exeptThis; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <DisposeAll>b__0(BotRequest x) { }

	}

	private readonly List _currentRequests; //Field offset: 0x10
	private float _nextCheckRequestsToEnd; //Field offset: 0x18
	private readonly AIData _aiData; //Field offset: 0x20
	[CompilerGenerated]
	private BotRequest <ActivatedRequest>k__BackingField; //Field offset: 0x28

	public private BotRequest ActivatedRequest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int RequestsCount
	{
		 get { } //Length: 65
	}

	public AIDataRequestController(AIData aiData) { }

	public bool CanAddByCount(BotRequestType type) { }

	public void CheckOnEndByRequester() { }

	public void Dispose(BotRequest request) { }

	public void Dispose() { }

	public void DisposeAll(BotRequest exeptThis = null) { }

	[CompilerGenerated]
	public BotRequest get_ActivatedRequest() { }

	public int get_RequestsCount() { }

	public void MyRequestTaken(BotRequest request) { }

	[CompilerGenerated]
	private void set_ActivatedRequest(BotRequest value) { }

	public bool TryAdd(BotRequest request, BotGroupRequestController groupRequestController) { }

}

