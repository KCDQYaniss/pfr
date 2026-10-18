namespace EFT;

public interface IDrainHandler : IItemRelatedView
{

	public void OnDrain(DrainItemEventArgs args) { }

}

