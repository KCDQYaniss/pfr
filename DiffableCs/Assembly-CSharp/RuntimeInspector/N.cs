namespace RuntimeInspector;

public class N
{
	public Texture2D tex; //Field offset: 0x10
	private bool reference; //Field offset: 0x18
	public string fieldName; //Field offset: 0x20
	public string typeName; //Field offset: 0x28
	public FieldInfo FieldInfo; //Field offset: 0x30
	public PropertyInfo PropertyInfo; //Field offset: 0x38
	public Type Type; //Field offset: 0x40
	public object parent; //Field offset: 0x48

	public N() { }

	public override void Click(ref bool selected) { }

	public bool Draw(bool selected) { }

	public object GetValue() { }

	public object GetValue(object obj) { }

	public override void Info() { }

	public void Init(MemberInfo memberInfo) { }

	public void SetValue(object obj) { }

	public override void Title(bool selected) { }

}

