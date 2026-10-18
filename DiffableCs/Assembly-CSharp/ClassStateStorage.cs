//Type is in global namespace

public class ClassStateStorage
{
	private struct FieldDefault
	{
		public FieldInfo fieldInfo; //Field offset: 0x0
		public object defaultValue; //Field offset: 0x8

	}

	private List _fieldsDefaults; //Field offset: 0x10

	public ClassStateStorage() { }

	private bool IsTypesContains(Type[] types, Type type) { }

	public void RestoreState(object host) { }

	public void StoreState(object host, Type[] excludedBaseClasses = null) { }

}

