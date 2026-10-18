namespace EFT.UI.DragAndDrop;

public sealed class AssembleBuildItemView : StaticGridItemView
{

	public virtual ItemRotation ItemRotation
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public AssembleBuildItemView() { }

	public virtual ItemRotation get_ItemRotation() { }

	protected virtual string GetErrorText() { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	protected virtual void set_ItemRotation(ItemRotation value) { }

	protected virtual void SetItemValue(EItemValueFormat format, bool display, string color, object arg1, object arg2 = null, string color2 = null) { }

	public void Show(Item item, ItemRotation rotation, ItemController inventoryController, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	public virtual void UpdateInfo() { }

	protected virtual void UpdateScale() { }

}

