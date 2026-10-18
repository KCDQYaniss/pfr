namespace Sirenix.OdinInspector;

public sealed class RequiredListLengthAttribute : Attribute
{
	private PrefabKind prefabKind; //Field offset: 0x10
	private bool prefabKindIsSet; //Field offset: 0x14
	private int minLength; //Field offset: 0x18
	private int maxLength; //Field offset: 0x1C
	private bool minLengthIsSet; //Field offset: 0x20
	private bool maxLengthIsSet; //Field offset: 0x21
	public string MinLengthGetter; //Field offset: 0x28
	public string MaxLengthGetter; //Field offset: 0x30

	public int MaxLength
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool MaxLengthIsSet
	{
		 get { } //Length: 5
	}

	public int MinLength
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool MinLengthIsSet
	{
		 get { } //Length: 5
	}

	public PrefabKind PrefabKind
	{
		 get { } //Length: 164
		 set { } //Length: 8
	}

	public bool PrefabKindIsSet
	{
		 get { } //Length: 5
	}

	public RequiredListLengthAttribute() { }

	public RequiredListLengthAttribute(int fixedLength) { }

	public RequiredListLengthAttribute(int minLength, int maxLength) { }

	public RequiredListLengthAttribute(int minLength, string maxLengthGetter) { }

	public RequiredListLengthAttribute(string fixedLengthGetter) { }

	public RequiredListLengthAttribute(string minLengthGetter, string maxLengthGetter) { }

	public RequiredListLengthAttribute(string minLengthGetter, int maxLength) { }

	public int get_MaxLength() { }

	public bool get_MaxLengthIsSet() { }

	public int get_MinLength() { }

	public bool get_MinLengthIsSet() { }

	public PrefabKind get_PrefabKind() { }

	public bool get_PrefabKindIsSet() { }

	public void set_MaxLength(int value) { }

	public void set_MinLength(int value) { }

	public void set_PrefabKind(PrefabKind value) { }

}

