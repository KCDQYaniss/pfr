namespace EFT.Hideout;

public sealed class BitcoinProducer : PermanentProducer
{
	private int _interactionStatus; //Field offset: 0x140
	private float _gpuBoostRate; //Field offset: 0x144

	public virtual int InstalledSuppliesCount
	{
		 get { } //Length: 7
		 set { } //Length: 64
	}

	public BitcoinProducer() { }

	public virtual int get_InstalledSuppliesCount() { }

	protected virtual void InitDetails(AreaData data) { }

	protected virtual void InitInfo(AreaInfo areaInfo) { }

	public void InstallSupplies(bool installAll, Callback onComplete) { }

	public void RemoveSupply(Callback onComplete) { }

	protected virtual void set_InstalledSuppliesCount(int value) { }

}

