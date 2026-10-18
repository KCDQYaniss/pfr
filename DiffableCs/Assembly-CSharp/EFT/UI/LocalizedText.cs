namespace EFT.UI;

[UsedImplicitly]
public sealed class LocalizedText : UIElement
{
	[SerializeField]
	private string localizationKey; //Field offset: 0x70
	[SerializeField]
	private List _labels; //Field offset: 0x78
	[SerializeField]
	private EStringCase _stringCase; //Field offset: 0x80
	private string _formatTemplate; //Field offset: 0x88
	private object[] _formatValues; //Field offset: 0x90
	private Action _localeUnsubscriber; //Field offset: 0x98
	[CompilerGenerated]
	private string <FormattedText>k__BackingField; //Field offset: 0xA0

	public private string FormattedText
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string LocalizationKey
	{
		 get { } //Length: 5
		 set { } //Length: 91
	}

	public LocalizedText() { }

	[CompilerGenerated]
	public string get_FormattedText() { }

	public string get_LocalizationKey() { }

	private void GetTextFromObject() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_FormattedText(string value) { }

	public void set_LocalizationKey(string value) { }

	public void SetFormatValues(object[] values) { }

	private void SetLabelText(string text) { }

	internal void UpdateLocale() { }

}

