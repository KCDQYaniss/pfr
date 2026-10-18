namespace Sirenix.OdinInspector;

[Extension]
public static class SelfValidationResultItemExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string path; //Field offset: 0x10
		public Action onClick; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal IEnumerable <WithContextClick>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string path; //Field offset: 0x10
		public bool on; //Field offset: 0x18
		public Action onClick; //Field offset: 0x20

		public <>c__DisplayClass7_0() { }

		internal IEnumerable <WithContextClick>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ContextMenuItem onContextClick; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal IEnumerable <WithContextClick>b__0() { }

	}


	[Extension]
	public static ResultItem EnableRichText(ref ResultItem item) { }

	[Extension]
	public static ResultItem SetSelectionObject(ref ResultItem item, Object uObj) { }

	[Extension]
	public static ResultItem WithButton(ref ResultItem resultItem, string name, Action onClick) { }

	[Extension]
	public static ResultItem WithContextClick(ref ResultItem item, Func onContextClick) { }

	[Extension]
	public static ResultItem WithContextClick(ref ResultItem item, string path, Action onClick) { }

	[Extension]
	public static ResultItem WithContextClick(ref ResultItem item, string path, bool on, Action onClick) { }

	[Extension]
	public static ResultItem WithContextClick(ref ResultItem item, ContextMenuItem onContextClick) { }

	[Extension]
	public static ResultItem WithFix(ref ResultItem item, string title, Action fix, bool offerInInspector = true) { }

	[Extension]
	public static ResultItem WithFix(ref ResultItem item, string title, Action fix, bool offerInInspector = true) { }

	[Extension]
	public static ResultItem WithFix(ref ResultItem item, Action fix, bool offerInInspector = true) { }

	[Extension]
	public static ResultItem WithFix(ref ResultItem item, Action fix, bool offerInInspector = true) { }

	[Extension]
	public static ResultItem WithFix(ref ResultItem item, SelfFix fix) { }

	[Extension]
	public static ResultItem WithMetaData(ref ResultItem resultItem, string name, object value, Attribute[] attributes) { }

	[Extension]
	public static ResultItem WithMetaData(ref ResultItem resultItem, object value, Attribute[] attributes) { }

	[Extension]
	public static ResultItem WithSceneGUI(ref ResultItem item, Action onSceneGUI) { }

}

