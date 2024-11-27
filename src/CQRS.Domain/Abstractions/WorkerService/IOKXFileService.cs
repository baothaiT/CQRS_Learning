using CQRS.Domain.Models.OKX;

namespace CQRS.Domain.Abstractions.WorkerService;

public interface IOKXFileService
{
    public string GetFilePath();
    public List<OKXExcelModel> Read(string filePath);
    public void Write(List<OKXExcelModel> orders, string filePath);
}