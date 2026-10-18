namespace Sirenix.OdinInspector;

[DefaultMember("Item")]
public class SelfValidationResult
{
	internal struct ContextMenuItem
	{
		public string Path; //Field offset: 0x0
		public bool On; //Field offset: 0x8
		public bool AddSeparatorBefore; //Field offset: 0x9
		public Action OnClick; //Field offset: 0x10

	}

	internal struct ResultItem
	{
		public string Message; //Field offset: 0x0
		public ResultType ResultType; //Field offset: 0x8
		public Nullable Fix; //Field offset: 0x10
		public ResultItemMetaData[] MetaData; //Field offset: 0x30
		public Func OnContextClick; //Field offset: 0x38
		public Action OnSceneGUI; //Field offset: 0x40
		public Object SelectionObject; //Field offset: 0x48
		public bool RichText; //Field offset: 0x50

	}

	internal struct ResultItemMetaData
	{
		public string Name; //Field offset: 0x0
		public object Value; //Field offset: 0x8
		public Attribute[] Attributes; //Field offset: 0x10

		public ResultItemMetaData(string name, object value, Attribute[] attributes) { }

	}

	internal enum ResultType
	{
		Error = 0,
		Warning = 1,
		Valid = 2,
	}

	private static ResultItem NoResultItem; //Field offset: 0x0
	private ResultItem[] items; //Field offset: 0x10
	private int itemsCount; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 4
	}

	public ResultItem Item
	{
		 get { } //Length: 49
	}

	public SelfValidationResult() { }

	public ResultItem Add(ValidatorSeverity severity, string message) { }

	public ResultItem Add(ResultItem item) { }

	public ResultItem AddError(string error) { }

	public ResultItem AddWarning(string warning) { }

	public int get_Count() { }

	public ResultItem get_Item(int index) { }

}

