using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Toz.Dotnet.Models;
using System.Threading;

namespace Toz.Dotnet.Core.Interfaces
{
    public interface INewsManagementService
    {
        Task<News> GetNews(string id, string token, CancellationToken cancelationToken = default(CancellationToken));
        Task<List<News>> GetAllNews(string token, CancellationToken cancelationToken = default(CancellationToken));
        Task<bool> UpdateNews(News news, string token, CancellationToken cancelationToken = default(CancellationToken));
        Task<bool> DeleteNews(News news, string token, CancellationToken cancelationToken = default(CancellationToken));
        Task<bool> CreateNews(News news, string token, CancellationToken cancelationToken = default(CancellationToken));
        byte[] ConvertPhotoToByteArray(Stream fileStream);
        string RequestUri { get; set; }
    }
}