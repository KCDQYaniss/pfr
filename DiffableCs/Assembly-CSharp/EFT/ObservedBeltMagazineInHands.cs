namespace EFT;

public class ObservedBeltMagazineInHands : BeltMagazineInHandsVisual
{
	private int _observedAmmoCountInMagOnStart; //Field offset: 0x60

	protected virtual int MagazineCount
	{
		 get { } //Length: 29
	}

	public ObservedBeltMagazineInHands() { }

	protected virtual int get_MagazineCount() { }

	protected virtual int GetBulletPositionForSpawnInBelt() { }

	protected virtual void InitializeVisualOnStart() { }

}

