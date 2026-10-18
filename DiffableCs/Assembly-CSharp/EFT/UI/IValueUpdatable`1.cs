namespace EFT.UI;

public interface IValueUpdatable`1
{

	public void Bind(Action valueChanged) { }

	public T CurrentValue() { }

	public void UpdateValue(T value, bool sendCallback = true, Nullable min = null, Nullable max = null) { }

}

