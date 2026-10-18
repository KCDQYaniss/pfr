namespace DG.Tweening.Plugins.Core;

public abstract class ABSTweenPlugin`3 : ITweenPlugin
{

	protected ABSTweenPlugin`3() { }

	public abstract T2 ConvertToStartValue(TweenerCore t, T1 value) { }

	public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue) { }

	public abstract void Reset(TweenerCore t) { }

	public abstract void SetChangeValue(TweenerCore t) { }

	public abstract void SetFrom(TweenerCore t, bool isRelative) { }

	public abstract void SetFrom(TweenerCore t, T2 fromValue, bool setImmediately) { }

	public abstract void SetRelativeEndValue(TweenerCore t) { }

}

