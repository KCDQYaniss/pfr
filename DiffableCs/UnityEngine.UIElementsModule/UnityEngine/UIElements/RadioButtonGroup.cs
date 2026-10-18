namespace UnityEngine.UIElements;

public class RadioButtonGroup : BaseField, IGroupBox
{
	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : BaseFieldTraits
	{
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string containerUssClassName; //Field offset: 0x8
	private List m_RadioButtons; //Field offset: 0x440
	private EventCallback m_RadioButtonValueChangedCallback; //Field offset: 0x448
	private VisualElement m_RadioButtonContainer; //Field offset: 0x450

	public IEnumerable choices
	{
		 set { } //Length: 1653
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 18
	}

	private static RadioButtonGroup() { }

	public RadioButtonGroup() { }

	public RadioButtonGroup(string label, List radioButtonChoices = null) { }

	public virtual VisualElement get_contentContainer() { }

	private void RadioButtonValueChangedCallback(ChangeEvent evt) { }

	public void set_choices(IEnumerable value) { }

	public virtual void SetValueWithoutNotify(int newValue) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	private void UpdateRadioButtons() { }

}

