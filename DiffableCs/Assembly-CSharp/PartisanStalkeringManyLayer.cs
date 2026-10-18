//Type is in global namespace

public class PartisanStalkeringManyLayer : BaseLogicLayer
{
	public const int MORE_ENEMIES_THAN = 1; //Field offset: 0x0
	private const int HOLD_PERIOD = 61; //Field offset: 0x0
	private BossFinder _boss; //Field offset: 0x90
	private float _smoothTime; //Field offset: 0x98
	private CustomNavigationPoint _lastChoose; //Field offset: 0xA0
	private float _lastTimeChoose; //Field offset: 0xA8
	private bool _isMinesPlanted; //Field offset: 0xAC
	private bool _changeGoANdMoveStealth; //Field offset: 0xAD

	public PartisanStalkeringManyLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <RefreshNewPoint>b__14_0(GroupPoint x) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndMoveStealthy() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnMinesCacheCompleted() { }

	private void OnMinesStartCache() { }

	private void RefreshNewPoint() { }

	public virtual bool ShallUseNow() { }

}

