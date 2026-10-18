//Type is in global namespace

public class PlayerIconRequest
{
	public readonly InventoryEquipment equipment; //Field offset: 0x10
	public readonly BodyCustomization customization; //Field offset: 0x18
	public readonly BindableEvent onProgress; //Field offset: 0x20
	public readonly int hash; //Field offset: 0x28
	public float progress; //Field offset: 0x2C

	public PlayerIconRequest(InventoryEquipment equipment, BodyCustomization customization) { }

	private int GetHashSum() { }

	public void Progress(float newProgress) { }

}

