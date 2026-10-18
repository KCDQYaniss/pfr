namespace FastAnimatorSystem;

public class AnimatorParameter : AnimatorValue
{
	public readonly bool IsControlledByAnimationCurve; //Field offset: 0x20
	public readonly string Name; //Field offset: 0x28
	public readonly int NameHash; //Field offset: 0x30
	public readonly bool DefaultBoolValue; //Field offset: 0x34
	public readonly float DefaultFloatValue; //Field offset: 0x38
	public readonly int DefaultIntValue; //Field offset: 0x3C
	private List _valueListeners; //Field offset: 0x40
	internal FastAnimatorController _parentAnimatorController; //Field offset: 0x48

	public AnimatorParameter(string name, EAnimatorValueType valueType, int nameHash, bool isControlledByAnimationCurve, float defaultFloatValue, int defaultIntValue, bool defaultBoolValue) { }

	public void AddValueListener(IParameterValueChangedListener valueListener) { }

	protected virtual void Dispose(bool disposing) { }

	public void RemoveValueListener(IParameterValueChangedListener valueListener) { }

	public virtual string ToString() { }

	protected virtual void ValueChanged() { }

}

