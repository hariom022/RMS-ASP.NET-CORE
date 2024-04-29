using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulating Consumption entry
    /// </summary>
    public interface IConsumptionEntryService
    {
        ConsumptionEntryResponse AddConsumptionEntry(ConsumptionEntryAddRequest? consumptionEntryAddRequest);
    }
}
