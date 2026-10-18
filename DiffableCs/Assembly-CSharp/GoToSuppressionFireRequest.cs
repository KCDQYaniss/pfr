//Type is in global namespace

public class GoToSuppressionFireRequest : MoveNode
{
	private float _nextUpdTimer; //Field offset: 0x28
	private readonly Aiming _aiming; //Field offset: 0x30

	private SuppressionFireRequest Request
	{
		private get { } //Length: 145
	}

	public GoToSuppressionFireRequest(BotOwner bot) { }

	[CompilerGenerated]
	private void <RestartFind>b__7_0(CustomNavigationPoint point) { }

	[CompilerGenerated]
	private void <RestartFind>b__7_1() { }

	private SuppressionFireRequest get_Request() { }

	private void InPoint() { }

	private void RestartFind() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

