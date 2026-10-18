namespace EFT.UI;

public class RichTextMarkWrapper
{
	[CompilerGenerated]
	private struct <>c__DisplayClass7_0
	{
		public int matchCount; //Field offset: 0x0
		public int len; //Field offset: 0x4
		public int matchStartIndex; //Field offset: 0x8
		public int searchStartIndex; //Field offset: 0xC
		public string processString; //Field offset: 0x10
		public List nodes; //Field offset: 0x18
		public bool matchProcess; //Field offset: 0x20

	}

	private class MarkStringNode
	{
		public string Value; //Field offset: 0x10
		public bool HasMark; //Field offset: 0x18
		public List ChildNodes; //Field offset: 0x20

		public MarkStringNode() { }

		public void AppendTo(StringBuilder sb) { }

		public static MarkStringNode MarkNode(string value) { }

		public static MarkStringNode TextNode(string value) { }

	}

	private const string TEMPLATE = "<mark=#aaaaaaaa>{0}</mark>"; //Field offset: 0x0
	private readonly TMP_Text _label; //Field offset: 0x10
	private readonly string _originalString; //Field offset: 0x18

	public RichTextMarkWrapper(TMP_Text label) { }

	[CompilerGenerated]
	internal static bool <ToNodeList>g__TryEvaluateString|7_0(ref <>c__DisplayClass7_0 unnamed_param_0) { }

	private void SeparateNodeRecursive(MarkStringNode node, string mask) { }

	public void SetMask(IEnumerable filterMask) { }

	private List ToNodeList(string input, string mask) { }

}

