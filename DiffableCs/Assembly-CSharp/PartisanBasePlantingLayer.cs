//Type is in global namespace

public abstract class PartisanBasePlantingLayer : BaseLogicLayer
{
	private AvoidDangerLayer _avoidLayerToCheck; //Field offset: 0x90
	protected bool _haveNoGrenades; //Field offset: 0x98
	private float PERIOD_POSSIBLE_RUN; //Field offset: 0x9C
	private float SDIST_TO_RUN; //Field offset: 0xA0
	private float PERIOD_MINE_PLANT_TO_RUN; //Field offset: 0xA4
	protected float _lastStartRun; //Field offset: 0xA8
	protected bool _lastMoveStealth; //Field offset: 0xAC

	protected PartisanBasePlantingLayer(BotOwner bot, int priority, AvoidDangerLayer avoidDangerLayer) { }

	protected bool CanUseCauseAvoid() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoSomePointTactical() { }

	protected virtual AICoreActionEnd EndGoToCoverPointTactical() { }

	protected virtual AICoreActionEnd EndPlantMine() { }

	protected AICoreActionResult MoveStealthOrRun(string info, CustomNavigationPoint target) { }

	protected bool WannaRun() { }

}

