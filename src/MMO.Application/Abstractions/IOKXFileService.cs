using CQRS.Contract.Models.OKX;

namespace MMO.Application.Abstractions;

public interface IOKXFileService
{
    public string GetFilePath();
    public List<OKXExcelModel> Read(string filePath);
    public void Write(List<OKXExcelModel> orders, string filePath);
}