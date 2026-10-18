namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class PreviewFieldAttribute : Attribute
{
	private ObjectFieldAlignment alignment; //Field offset: 0x10
	private bool alignmentHasValue; //Field offset: 0x14
	private string previewGetter; //Field offset: 0x18
	public float Height; //Field offset: 0x20
	public FilterMode FilterMode; //Field offset: 0x24
	[CompilerGenerated]
	private bool <PreviewGetterHasValue>k__BackingField; //Field offset: 0x28

	public ObjectFieldAlignment Alignment
	{
		 get { } //Length: 164
		 set { } //Length: 8
	}

	public bool AlignmentHasValue
	{
		 get { } //Length: 5
	}

	public string PreviewGetter
	{
		 get { } //Length: 5
		 set { } //Length: 92
	}

	public private bool PreviewGetterHasValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PreviewFieldAttribute() { }

	public PreviewFieldAttribute(float height) { }

	public PreviewFieldAttribute(string previewGetter, FilterMode filterMode = 1) { }

	public PreviewFieldAttribute(string previewGetter, float height, FilterMode filterMode = 1) { }

	public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment) { }

	public PreviewFieldAttribute(string previewGetter, ObjectFieldAlignment alignment, FilterMode filterMode = 1) { }

	public PreviewFieldAttribute(string previewGetter, float height, ObjectFieldAlignment alignment, FilterMode filterMode = 1) { }

	public PreviewFieldAttribute(ObjectFieldAlignment alignment) { }

	public ObjectFieldAlignment get_Alignment() { }

	public bool get_AlignmentHasValue() { }

	public string get_PreviewGetter() { }

	[CompilerGenerated]
	public bool get_PreviewGetterHasValue() { }

	public void set_Alignment(ObjectFieldAlignment value) { }

	public void set_PreviewGetter(string value) { }

	[CompilerGenerated]
	private void set_PreviewGetterHasValue(bool value) { }

}

