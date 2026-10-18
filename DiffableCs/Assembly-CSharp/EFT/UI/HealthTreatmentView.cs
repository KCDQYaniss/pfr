namespace EFT.UI;

public abstract class HealthTreatmentView : UIElement
{
	private const string TREATMENT_NAME_LOC_PREFIX = "UI/HealthTreatmentName_"; //Field offset: 0x0
	private const string TREATMENT_ACTION_LOC_PREFIX = "UI/HealthTreatmentAction_"; //Field offset: 0x0
	[SerializeField]
	private UpdatableToggle _checkbox; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _treatmentNameField; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _treatmentActionNameField; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _costField; //Field offset: 0x88
	[SerializeField]
	private Image _highlight; //Field offset: 0x90
	public BindableEvent OnSelect; //Field offset: 0x98
	private IHealthObserver _treatment; //Field offset: 0xA0
	private bool _active; //Field offset: 0xA8
	[CompilerGenerated]
	private float <CostTotal>k__BackingField; //Field offset: 0xAC

	protected bool Active
	{
		 get { } //Length: 8
		 set { } //Length: 178
	}

	protected float CostTotal
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	private string TreatmentName
	{
		private get { } //Length: 81
	}

	protected HealthTreatmentView() { }

	protected bool get_Active() { }

	[CompilerGenerated]
	protected float get_CostTotal() { }

	private string get_TreatmentName() { }

	protected void set_Active(bool value) { }

	[CompilerGenerated]
	protected void set_CostTotal(float value) { }

	public void SetSelected(bool selected) { }

	protected void Show(IHealthObserver treatment) { }

	protected void UpdateCost() { }

}

