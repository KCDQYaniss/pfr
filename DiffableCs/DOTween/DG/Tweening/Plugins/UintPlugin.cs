namespace DG.Tweening.Plugins;

public class UintPlugin : ABSTweenPlugin
{

	public UintPlugin() { }

	public virtual uint ConvertToStartValue(TweenerCore t, uint value) { }

	public virtual void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, uint fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

