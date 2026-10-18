namespace DG.Tweening.CustomPlugins;

public class PureQuaternionPlugin : ABSTweenPlugin
{
	private static PureQuaternionPlugin _plug; //Field offset: 0x0

	public PureQuaternionPlugin() { }

	public virtual Quaternion ConvertToStartValue(TweenerCore t, Quaternion value) { }

	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue) { }

	public static PureQuaternionPlugin Plug() { }

	public virtual void Reset(TweenerCore t) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, Quaternion fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

