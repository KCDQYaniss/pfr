namespace DG.Tweening.Plugins;

public class LongPlugin : ABSTweenPlugin
{

	public LongPlugin() { }

	public virtual long ConvertToStartValue(TweenerCore t, long value) { }

	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, long fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

