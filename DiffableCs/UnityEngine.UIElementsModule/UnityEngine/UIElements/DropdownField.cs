namespace UnityEngine.UIElements;

public class DropdownField : PopupField
{
	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlIntAttributeDescription m_Index; //Field offset: 0x80
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}


	public DropdownField() { }

	public DropdownField(string label) { }

}

