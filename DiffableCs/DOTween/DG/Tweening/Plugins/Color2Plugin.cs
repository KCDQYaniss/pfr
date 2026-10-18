namespace DG.Tweening.Plugins;

internal class Color2Plugin : ABSTweenPlugin
{

	public Color2Plugin() { }

	public virtual Color2 ConvertToStartValue(TweenerCore t, Color2 value) { }

	public virtual void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Color2 fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

