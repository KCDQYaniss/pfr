namespace RuntimeInspector;

public class DWindow
{
	internal struct FieldObject
	{
		public object Obj; //Field offset: 0x0
		public string Name; //Field offset: 0x8

		public FieldObject(object obj, string name) { }

		public bool Equals(FieldObject other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public static bool op_Equality(FieldObject a, FieldObject b) { }

		public static bool op_Inequality(FieldObject a, FieldObject b) { }

	}

	private LinkedList history; //Field offset: 0x10
	private Type type; //Field offset: 0x18
	private FieldObject selfObject; //Field offset: 0x20
	public N[] Refs; //Field offset: 0x30
	public int selected; //Field offset: 0x38
	private int newSelected; //Field offset: 0x3C
	public FieldObject newObject; //Field offset: 0x40

	public DWindow(object obj) { }

	private void AddHistory(FieldObject obj) { }

	public void DrawFields() { }

	public void DrawHistory() { }

	private static HashSet GetMembers(Type type) { }

	private void Init(FieldObject node) { }

	public void ReInit() { }

}

