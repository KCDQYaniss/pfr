namespace EFT;

public sealed class ProfileVariable : BaseProfileVariable
{
	public readonly MongoID Id; //Field offset: 0x18
	private int _value; //Field offset: 0x30

	public ProfileVariable(MongoID id, int variableValue) { }

	public virtual int GetValue() { }

	public virtual void SetValue(int value) { }

}

