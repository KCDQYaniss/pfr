namespace DG.Tweening.Plugins;

public class PathPlugin : ABSTweenPlugin
{
	public const float MinLookAhead = 0.0001; //Field offset: 0x0

	public PathPlugin() { }

	public virtual Path ConvertToStartValue(TweenerCore t, Vector3 value) { }

	public virtual void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public static ABSTweenPlugin Get() { }

	public virtual float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Path fromValue, bool setImmediately) { }

	public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

