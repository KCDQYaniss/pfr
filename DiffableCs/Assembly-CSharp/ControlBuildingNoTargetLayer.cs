//Type is in global namespace

public class ControlBuildingNoTargetLayer : ControlBuildingLayer
{
	public const float PERIOD_WAIT_LASTENEMY_SEC = 900; //Field offset: 0x0

	protected virtual int TargetEnvironmentId
	{
		 get { } //Length: 62
	}

	protected virtual Nullable TargetPosition
	{
		 get { } //Length: 69
	}

	public ControlBuildingNoTargetLayer(BotOwner bot, int priority) { }

	protected virtual int get_TargetEnvironmentId() { }

	protected virtual Nullable get_TargetPosition() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

