using business_logic.DTOs;

namespace business_logic.Interfaces;

public interface ISaveService
{
    Task<SaveDto> Get(int id);
    void Add(CreateSaveModel saveModel);
    Task Remove(int id);
}