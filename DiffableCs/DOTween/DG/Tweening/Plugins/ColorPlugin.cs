namespace DG.Tweening.Plugins;

public class ColorPlugin : ABSTweenPlugin
{

	public ColorPlugin() { }

	public virtual Color ConvertToStartValue(TweenerCore t, Color value) { }

	public virtual void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Color fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

