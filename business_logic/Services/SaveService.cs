using AutoMapper;
using business_logic.DTOs;
using business_logic.Entities;
using business_logic.Interfaces;
using business_logic.Specifications;
using System.Net;

namespace business_logic.Services;

public class SaveService : ISaveService
{
    public readonly IMapper mapper;
    public readonly IRepository<Save> saveR;
    public SaveService(IMapper mapper,
                       IRepository<Save> saveR)
    {
        this.mapper = mapper;
        this.saveR = saveR;
    }
    public void Add(CreateSaveModel saveModel)
    {
        saveR.Insert(mapper.Map<Save>(saveModel));
        saveR.Save();
    }

    public async Task<SaveDto> Get(int id)
    {
        return mapper.Map<SaveDto>(await saveR.GetListBySpec(new SaveSpecs.ById(id)));
    }

    public async Task Remove(int id)
    {
        if (id < 0) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.BadRequest);

        var video = saveR.GetById(id);

        if (video == null) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);

        saveR.Delete(video);
        saveR.Save();
    }
}