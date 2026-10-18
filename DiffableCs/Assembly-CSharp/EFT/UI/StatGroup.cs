namespace EFT.UI;

public class StatGroup
{
	public string titleKey; //Field offset: 0x10
	public List variables; //Field offset: 0x18

	public StatGroup(string titleKey) { }

	public void AddVariable(StatVariable variable) { }

}

