namespace EFT.InputSystem;

public interface IInputTree
{

	public void Add(InputNode node) { }

	public void AddWithLowPriority(InputNode node) { }

	public bool Contains(InputNode node) { }

	public void Remove(InputNode node) { }

}

