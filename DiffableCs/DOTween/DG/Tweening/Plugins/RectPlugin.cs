namespace DG.Tweening.Plugins;

public class RectPlugin : ABSTweenPlugin
{

	public RectPlugin() { }

	public virtual Rect ConvertToStartValue(TweenerCore t, Rect value) { }

	public virtual void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Rect fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

