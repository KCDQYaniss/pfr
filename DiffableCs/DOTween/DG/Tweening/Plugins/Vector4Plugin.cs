namespace DG.Tweening.Plugins;

public class Vector4Plugin : ABSTweenPlugin
{

	public Vector4Plugin() { }

	public virtual Vector4 ConvertToStartValue(TweenerCore t, Vector4 value) { }

	public virtual void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Vector4 fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

