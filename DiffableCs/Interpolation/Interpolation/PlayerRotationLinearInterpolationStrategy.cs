namespace Interpolation;

public sealed class PlayerRotationLinearInterpolationStrategy : IInterpolationStrategy
{

	public PlayerRotationLinearInterpolationStrategy() { }

	public Vector2 Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in Vector2 startValue, in Vector2 endValue, float relativeTime) { }

	private override Vector2 Interpolation.IInterpolationStrategy<UnityEngine.Vector2>.Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in Vector2 startValue, in Vector2 endValue, float relativeTime) { }

}

