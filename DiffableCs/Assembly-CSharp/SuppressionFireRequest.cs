//Type is in global namespace

public class SuppressionFireRequest : BotRequest
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public BotOwner requester; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <CanRequest>b__0(KeyValuePair x) { }

	}

	private const int BASE_SHOOTS = 15; //Field offset: 0x0
	private const int DIST_TO_OTHER_ENEMIES_SQRT = 2500; //Field offset: 0x0
	protected readonly SuppressionData _suppressionData; //Field offset: 0x70
	private bool _phraseSayed; //Field offset: 0x78
	private int _shootsDone; //Field offset: 0x7C
	private int _shoot2End; //Field offset: 0x80
	private bool _canShootLastTime; //Field offset: 0x84
	private float _nextShootTimeCheck; //Field offset: 0x88

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 3
	}

	public SuppressionFireRequest(Player requester, EnemyInfo info) { }

	public SuppressionFireRequest(Player requester, Vector3 point) { }

	public virtual void Activate() { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public bool CanShootNow() { }

	public virtual bool CanStartExecute(BotOwner executor) { }

	public virtual void Dispose() { }

	public virtual EBotRequestMode get_RequestMode() { }

	public ShootToPoint GetShootPos() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnTriggerPressed() { }

	public virtual void PlayerDestroy(Player player) { }

	public virtual void Take(BotOwner executor) { }

}

