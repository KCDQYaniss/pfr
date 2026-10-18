namespace EFT.Interactive;

public abstract class Turnable : MonoBehaviour, IMapEditable
{
	internal enum EState
	{
		TurningOn = 0,
		TurningOff = 1,
		On = 2,
		Off = 3,
		Destroyed = 4,
		ConstantFlickering = 5,
		SmoothOff = 6,
	}

	public string Id; //Field offset: 0x20
	public int NetId; //Field offset: 0x28
	public EState LampState; //Field offset: 0x2C
	public BallisticCollider BallisticCollider; //Field offset: 0x30

	private override GameObject EFT.Interactive.IMapEditable.GameObject
	{
		private get { } //Length: 78
	}

	private override string EFT.Interactive.IMapEditable.IdEditable
	{
		private get { } //Length: 5
		private set { } //Length: 82
	}

	private override string EFT.Interactive.IMapEditable.TypeKey
	{
		private get { } //Length: 49
	}

	public bool IsDestroyed
	{
		 get { } //Length: 8
	}

	protected Turnable() { }

	[Obsolete("Will be removed with EFT.Interactive.MapEditableGeneratorId")]
	protected void CheckUniqueIdOnDuplicateEvent() { }

	private override GameObject EFT.Interactive.IMapEditable.get_GameObject() { }

	private override string EFT.Interactive.IMapEditable.get_IdEditable() { }

	private override string EFT.Interactive.IMapEditable.get_TypeKey() { }

	private override void EFT.Interactive.IMapEditable.set_IdEditable(string value) { }

	public bool get_IsDestroyed() { }

	private void OnHit(DamageInfo dInfo) { }

	public void RegisterForNetwork() { }

	public override void Switch(EState switchTo) { }

}

