namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class HideReferenceObjectPickerAttribute : Attribute
{

	public HideReferenceObjectPickerAttribute() { }

}

