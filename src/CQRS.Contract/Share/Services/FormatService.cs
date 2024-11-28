using System.Reflection;

namespace CQRS.Contract.Share.Services
{
    public static class FormatService
    {
        public static string FormatDatetimeToString(DateTime inputDateTime)
        {
            return inputDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}