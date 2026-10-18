namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseCompositeField`3 : BaseField
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public FieldDescription desc; //Field offset: 0x0
		public TField field; //Field offset: 0x0
		public BaseCompositeField <>4__this; //Field offset: 0x0

		public <>c__DisplayClass24_0() { }

		internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

		internal void <.ctor>b__1(ChangeEvent e) { }

	}

	public struct FieldDescription
	{
		internal sealed class WriteDelegate : MulticastDelegate
		{

			public WriteDelegate(object object, IntPtr method) { }

			public override void Invoke(ref TValueType val, TFieldValue fieldValue) { }

		}

		internal readonly string name; //Field offset: 0x0
		internal readonly string ussName; //Field offset: 0x0
		internal readonly Func read; //Field offset: 0x0
		internal readonly WriteDelegate write; //Field offset: 0x0

		public FieldDescription(string name, string ussName, Func read, WriteDelegate write) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string spacerUssClassName; //Field offset: 0x0
	public static readonly string multilineVariantUssClassName; //Field offset: 0x0
	public static readonly string fieldGroupUssClassName; //Field offset: 0x0
	public static readonly string fieldUssClassName; //Field offset: 0x0
	public static readonly string firstFieldVariantUssClassName; //Field offset: 0x0
	public static readonly string twoLinesVariantUssClassName; //Field offset: 0x0
	private List m_Fields; //Field offset: 0x0
	private bool m_ShouldUpdateDisplay; //Field offset: 0x0
	private bool m_ForceUpdateDisplay; //Field offset: 0x0
	private int m_PropertyIndex; //Field offset: 0x0

	private static BaseCompositeField`3() { }

	protected BaseCompositeField`3(string label, int fieldsByLine) { }

	internal abstract FieldDescription[] DescribeFields() { }

	private VisualElement GetSpacer() { }

	internal virtual void OnViewDataReady() { }

	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	private void UpdateDisplay() { }

	protected virtual void UpdateMixedValueContent() { }

}

