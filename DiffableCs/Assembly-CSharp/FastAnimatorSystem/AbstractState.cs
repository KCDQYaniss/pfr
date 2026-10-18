namespace FastAnimatorSystem;

public abstract class AbstractState : IDisposable
{
	public readonly int Hash; //Field offset: 0x10
	public readonly string Name; //Field offset: 0x18
	public float AnimatorSpeed; //Field offset: 0x20
	internal FastStateBehavior[] _behaviors; //Field offset: 0x28

	public int BehaviorsCount
	{
		 get { } //Length: 26
	}

	protected AbstractState(string name, int hash) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public int get_BehaviorsCount() { }

	public FastStateBehavior GetBehavior(int index) { }

	public T GetBehavior() { }

	public override void ResetCache() { }

	public virtual string ToString() { }

}

