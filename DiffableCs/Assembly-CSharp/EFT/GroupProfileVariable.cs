namespace EFT;

public sealed class GroupProfileVariable : BaseProfileVariable
{
	public readonly MongoID Id; //Field offset: 0x18
	public readonly IReadOnlyList VariableIds; //Field offset: 0x30
	private readonly ProfileVariablesStorage _storage; //Field offset: 0x38
	private int _currentValue; //Field offset: 0x40

	[JsonConstructor]
	private GroupProfileVariable(MongoID id, IReadOnlyList variableIds) { }

	public GroupProfileVariable(MongoID id, IReadOnlyList variableIds, ProfileVariablesStorage storage) { }

	private int CalculateValue() { }

	public virtual int GetValue() { }

	public virtual void SetValue(int value) { }

	private void VariableChangedHandler(MongoID id, int value) { }

}

