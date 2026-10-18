//Type is in global namespace

public class DecisionProxy
{
	private class PreviousState
	{
		private BotLogicDecision _decision; //Field offset: 0x10
		private int _id; //Field offset: 0x14
		[CompilerGenerated]
		private int <Amount>k__BackingField; //Field offset: 0x18

		public private int Amount
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public PreviousState() { }

		[CompilerGenerated]
		public int get_Amount() { }

		[CompilerGenerated]
		private void set_Amount(int value) { }

		public void SetDecision(BotLogicDecision decision, int id) { }

	}

	private const float DECISION_LOG_ERROR_PERIOD = 10; //Field offset: 0x0
	private static bool _showMultipleDecisionLog; //Field offset: 0x0
	private readonly BotOwner _owner; //Field offset: 0x10
	private readonly PreviousState _prevState; //Field offset: 0x18
	private float _lastDecisionLogError; //Field offset: 0x20

	public DecisionProxy(BotOwner owner) { }

	public BotLogicDecision LogDecision(BotLogicDecision decision, ShortDecision shortDecision = 1, int id = -1, EDecisionMethod method = 999) { }

	private bool MayLogError() { }

	public static void ShowMultipleDecisionLog(bool state) { }

}

