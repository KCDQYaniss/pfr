namespace EFT.UI;

public class ServiceListItem : UIElement
{
	[SerializeField]
	private Image _serviceIcon; //Field offset: 0x70
	[SerializeField]
	private Image _serviceIconBackground; //Field offset: 0x78
	[SerializeField]
	private Image _serviceIconBorder; //Field offset: 0x80
	[SerializeField]
	private Button _serviceButton; //Field offset: 0x88
	[SerializeField]
	private Image _serviceBackgroud; //Field offset: 0x90
	[SerializeField]
	private Image _selectedArrow; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _serviceText; //Field offset: 0xA0
	[SerializeField]
	private ColorMap _backColors; //Field offset: 0xA8
	[SerializeField]
	private ColorMap _textColors; //Field offset: 0xB0
	private Action _onSelected; //Field offset: 0xB8
	[CompilerGenerated]
	private ServiceInfo <ServiceInfo>k__BackingField; //Field offset: 0xC0

	public private ServiceInfo ServiceInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ServiceListItem() { }

	[CompilerGenerated]
	private void <Awake>b__14_0() { }

	private void Awake() { }

	[CompilerGenerated]
	public ServiceInfo get_ServiceInfo() { }

	public void Init(Action onSelected, ServiceInfo serviceInfo) { }

	[CompilerGenerated]
	private void set_ServiceInfo(ServiceInfo value) { }

	public void UpdateView(bool selected) { }

}

