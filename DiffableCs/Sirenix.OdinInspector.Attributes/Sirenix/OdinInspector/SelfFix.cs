namespace Sirenix.OdinInspector;

public struct SelfFix
{
	public string Title; //Field offset: 0x0
	public Delegate Action; //Field offset: 0x8
	public bool OfferInInspector; //Field offset: 0x10

	public SelfFix(string name, Action action, bool offerInInspector) { }

	public SelfFix(string name, Delegate action, bool offerInInspector) { }

	public static SelfFix Create(Action action, bool offerInInspector = true) { }

	public static SelfFix Create(string title, Action action, bool offerInInspector = true) { }

	public static SelfFix Create(Action action, bool offerInInspector = true) { }

	public static SelfFix Create(string title, Action action, bool offerInInspector = true) { }

}

