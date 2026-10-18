namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class BoxGroupAttribute : PropertyGroupAttribute
{
	public bool ShowLabel; //Field offset: 0x38
	public bool CenterLabel; //Field offset: 0x39
	public string LabelText; //Field offset: 0x40

	public BoxGroupAttribute(string group, bool showLabel = true, bool centerLabel = false, float order = 0) { }

	public BoxGroupAttribute() { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

