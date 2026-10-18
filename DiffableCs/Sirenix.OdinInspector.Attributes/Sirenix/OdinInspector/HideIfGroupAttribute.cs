namespace Sirenix.OdinInspector;

[Conditional("UNITY_EDITOR")]
public class HideIfGroupAttribute : PropertyGroupAttribute
{
	public object Value; //Field offset: 0x38

	public bool Animate
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string Condition
	{
		 get { } //Length: 20
		 set { } //Length: 82
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Condition member instead.", False)]
	public string MemberName
	{
		 get { } //Length: 20
		 set { } //Length: 82
	}

	public HideIfGroupAttribute(string path, bool animate = true) { }

	public HideIfGroupAttribute(string path, object value, bool animate = true) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	public bool get_Animate() { }

	public string get_Condition() { }

	public string get_MemberName() { }

	public void set_Animate(bool value) { }

	public void set_Condition(string value) { }

	public void set_MemberName(string value) { }

}

