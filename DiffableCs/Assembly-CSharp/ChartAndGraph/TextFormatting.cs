namespace ChartAndGraph;

public class TextFormatting : IInternalSettings
{
	[SerializeField]
	private string prefix; //Field offset: 0x10
	[SerializeField]
	private string suffix; //Field offset: 0x18
	[CompilerGenerated]
	private EventHandler OnDataUpdate; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler OnDataChanged; //Field offset: 0x28

	private override event EventHandler ChartAndGraph.IInternalSettings.InternalOnDataChanged
	{
		private add { } //Length: 235
		private remove { } //Length: 235
	}

	private override event EventHandler ChartAndGraph.IInternalSettings.InternalOnDataUpdate
	{
		private add { } //Length: 235
		private remove { } //Length: 235
	}

	private event EventHandler OnDataChanged
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	private event EventHandler OnDataUpdate
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public string Prefix
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public string Suffix
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public TextFormatting() { }

	[CompilerGenerated]
	private void add_OnDataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void add_OnDataUpdate(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.add_InternalOnDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.add_InternalOnDataUpdate(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.remove_InternalOnDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.remove_InternalOnDataUpdate(EventHandler value) { }

	public void Format(StringBuilder builder, string data, string category, string group) { }

	public string Format(string data, string category, string group) { }

	private static void FormatKeywords(StringBuilder builder, string category, string group) { }

	private static string FormatKeywords(string str, string category, string group) { }

	public string get_Prefix() { }

	public string get_Suffix() { }

	protected override void RaiseOnChanged() { }

	protected override void RaiseOnUpdate() { }

	[CompilerGenerated]
	private void remove_OnDataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void remove_OnDataUpdate(EventHandler value) { }

	public void set_Prefix(string value) { }

	public void set_Suffix(string value) { }

	private static string ValidString(string str) { }

}

