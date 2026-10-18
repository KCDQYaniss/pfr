namespace Audio.AmbientSubsystem.PathMoverStrategy;

public class PathMovementRandomStrategy : PathMovementStrategyBase
{

	public virtual EMovementStrategy MovementStrategy
	{
		 get { } //Length: 3
	}

	public PathMovementRandomStrategy(MonoBehaviour behaviour, IPositionTranslator posTranslator, Vector3[] points, float[] segmentLengths, float totalLength) { }

	public virtual EMovementStrategy get_MovementStrategy() { }

	protected virtual void OnExecute(Action onDone = null) { }

	protected virtual void ResetParameters(bool resetPosition = false) { }

}

