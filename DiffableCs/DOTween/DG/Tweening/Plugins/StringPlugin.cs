namespace DG.Tweening.Plugins;

public class StringPlugin : ABSTweenPlugin
{
	private static readonly StringBuilder _Buffer; //Field offset: 0x0
	private static readonly List _OpenedTags; //Field offset: 0x8

	private static StringPlugin() { }

	public StringPlugin() { }

	private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) { }

	public virtual string ConvertToStartValue(TweenerCore t, string value) { }

	public virtual void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter getter, DOSetter setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	public virtual float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) { }

	public virtual void Reset(TweenerCore t) { }

	private char[] ScrambledCharsToUse(StringOptions options) { }

	public virtual void SetChangeValue(TweenerCore t) { }

	public virtual void SetFrom(TweenerCore t, bool isRelative) { }

	public virtual void SetFrom(TweenerCore t, string fromValue, bool setImmediately) { }

	public virtual void SetRelativeEndValue(TweenerCore t) { }

}

