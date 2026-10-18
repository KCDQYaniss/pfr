namespace EFT;

public sealed class BTRGlobalSettings
{
	public string[] LocationsWithBTR; //Field offset: 0x10
	public int BasePriceTaxi; //Field offset: 0x18
	public int AddPriceTaxi; //Field offset: 0x1C
	public int CleanUpPrice; //Field offset: 0x20
	public int DeliveryPrice; //Field offset: 0x24
	public float ModDeliveryCost; //Field offset: 0x28
	public float BearPriceMod; //Field offset: 0x2C
	public float UsecPriceMod; //Field offset: 0x30
	public float ScavPriceMod; //Field offset: 0x34
	public float CoefficientDiscountCharisma; //Field offset: 0x38
	public int TaxiMinPrice; //Field offset: 0x3C
	public int DeliveryMinPrice; //Field offset: 0x40
	public int BotCoverMinPrice; //Field offset: 0x44
	public Dictionary MapsConfigs; //Field offset: 0x48

	public BTRGlobalSettings() { }

}

