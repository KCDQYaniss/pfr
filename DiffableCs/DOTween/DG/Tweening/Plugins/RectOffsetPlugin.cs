namespace DG.Tweening.Plugins;

public class RectOffsetPlugin : ABSTweenPlugin
{
	private static RectOffset _r; //Field offset: 0x0

	private static RectOffsetPlugin() { }

	public RectOffsetPlugin() { }

	public virtual RectOffset ConvertToStartValue(TweenerCore t, RectOffset value) { }

	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, RectOffset fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

