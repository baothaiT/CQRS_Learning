using CQRS.Domain.Abstractions.Repository;
using Newtonsoft.Json;

namespace CQRS.Worker.Services.Interfaces;

public interface IOKXExcelSerivce
{
    public void ReadAndWriteNewExcel();
}