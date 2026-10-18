namespace EFT.UI;

public interface ITweenAnimation`1
{

	public void SetState(T state) { }

	public void Stop() { }

	public void TransitionToState(T state) { }

}

