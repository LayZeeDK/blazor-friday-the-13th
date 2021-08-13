using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<CompanyData> CompanyAsync(string coId)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Company/{_apiKey}/{coId}";
                return await Utils.DownloadObjectAsync<CompanyData>(url, _http);
            }
            catch (Exception ex)
            {
                return new CompanyData() { ErrorMessage = ex.Message };
            }
        }
    }
}
