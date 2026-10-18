namespace EFT.UI.Ragfair;

public class RequirementView : UIElement
{
	public const int MAX_QUANTITY = 100000000; //Field offset: 0x0
	private static readonly NumberFormatInfo _formatInfo; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnQuantityChange; //Field offset: 0x70
	[SerializeField]
	private Button _clearButton; //Field offset: 0x78
	[SerializeField]
	private ValidationInputField _inputField; //Field offset: 0x80
	[SerializeField]
	private ECurrencyType _currency; //Field offset: 0x88
	[CompilerGenerated]
	private HandbookNode <Node>k__BackingField; //Field offset: 0x90
	private int _quantity; //Field offset: 0x98

	public event Action OnQuantityChange
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public ECurrencyType CurrencyType
	{
		 get { } //Length: 7
	}

	private string Id
	{
		private get { } //Length: 253
	}

	public private HandbookNode Node
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HandoverRequirement Requirement
	{
		 get { } //Length: 140
	}

	private static RequirementView() { }

	public RequirementView() { }

	[CompilerGenerated]
	public void add_OnQuantityChange(Action value) { }

	private void AtInput(string input) { }

	private void Awake() { }

	public ECurrencyType get_CurrencyType() { }

	private string get_Id() { }

	[CompilerGenerated]
	public HandbookNode get_Node() { }

	public HandoverRequirement get_Requirement() { }

	[CompilerGenerated]
	public void remove_OnQuantityChange(Action value) { }

	public void ResetRequirementInformation() { }

	[CompilerGenerated]
	private void set_Node(HandbookNode value) { }

	public void SetValue(string value) { }

	public void Show(Handbook handbook) { }

}

