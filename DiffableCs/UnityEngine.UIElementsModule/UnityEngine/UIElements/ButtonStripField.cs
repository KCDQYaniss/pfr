namespace UnityEngine.UIElements;

internal class ButtonStripField : BaseField
{
	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	private List m_Buttons; //Field offset: 0x440

	public ButtonStripField() { }

	private void RefreshButtonsState() { }

	public virtual void SetValueWithoutNotify(int newValue) { }

}

