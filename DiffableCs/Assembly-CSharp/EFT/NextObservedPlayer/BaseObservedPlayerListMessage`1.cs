namespace EFT.NextObservedPlayer;

public abstract class BaseObservedPlayerListMessage`1 : SortedList, ISerializableMessage
{

	protected BaseObservedPlayerListMessage`1(int capacity) { }

	public abstract T CreateInstanceValue() { }

	public override void Deserialize(NetworkReader reader) { }

	public int ReadCount(NetworkReader reader) { }

	public override void ReadFields(NetworkReader reader) { }

	public byte ReadIndex(NetworkReader reader) { }

	public override T ReadValue(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

	public void WriteCount(NetworkWriter writer) { }

	public void WriteCount(NetworkWriter writer, int value) { }

	public override void WriteFields(NetworkWriter writer) { }

	public void WriterIndex(NetworkWriter writer, byte value) { }

	public override void WriterValue(NetworkWriter writer, T value) { }

}

