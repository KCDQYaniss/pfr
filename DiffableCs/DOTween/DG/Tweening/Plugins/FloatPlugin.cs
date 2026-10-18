namespace DG.Tweening.Plugins;

public class FloatPlugin : ABSTweenPlugin
{

	public FloatPlugin() { }

	public virtual float ConvertToStartValue(TweenerCore t, float value) { }

	public virtual void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, float fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

