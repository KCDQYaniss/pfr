namespace DG.Tweening.Plugins;

public class Vector3Plugin : ABSTweenPlugin
{

	public Vector3Plugin() { }

	public virtual Vector3 ConvertToStartValue(TweenerCore t, Vector3 value) { }

	public virtual void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Vector3 fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

