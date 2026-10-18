namespace EFT.Visual;

public class LightFlicker : Flicker
{
	[SerializeField]
	private Light _light; //Field offset: 0x48

	public LightFlicker() { }

	protected virtual void Awake() { }

	public virtual void ManualUpdate() { }

}

