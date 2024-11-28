using CQRS.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Contract.Share.Models;
using CQRS.Contract.Share.DTO;

namespace CQRS.Infrastructure.Services;

public class FileService: IFileService
{
    private readonly string _filePath;
    public FileService()
    {

    }

    public async Task<List<GetProxyDto>> ReadProxies(string filePath)
    {
        var proxyList = new List<GetProxyDto>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 4)
                    {
                        string ip = parts[0];
                        int port = Int32.Parse(parts[1]);
                        string username = parts[2];
                        string password = parts[3];

                        //GetProxyDto proxy = new GetProxyDto(ip, port, username, password);

                        GetProxyDto proxy = new GetProxyDto()
                        {
                            Ip = ip,
                            Port = port,
                            User = username,
                            Password = password
                        };

                        proxyList.Add(proxy);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }

        return proxyList;
    }


}
