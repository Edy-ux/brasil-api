using brasil_api.Dtos;
using brasil_api.Interfaces;
using brasil_api.Models;
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace brasil_api.Rest
{
    public class BasilApiRest : IBrasilApi
    {
        public async Task<ResponseGeneric<AddressModel>> GetAddressByZipCode(string code)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{code}" );
           

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objectResponse = JsonSerializer.Deserialize<AddressModel>(contentResponse);

                

                if (!responseBrasilApi.IsSuccessStatusCode)
                {
                    return new ResponseGeneric<AddressModel>()
                    {
                        StatusCodeHttp = responseBrasilApi.StatusCode,
                        ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse)
                    };

                }
                else
                {
                    return new ResponseGeneric<AddressModel>()
                    {
                        StatusCodeHttp = responseBrasilApi.StatusCode,
                        ReturnData = objectResponse
                    };

                }
  
      
            }


        }

        public async Task<ResponseGeneric<List<BankModel>>> GetAllBanks()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
            var response = new ResponseGeneric<List<BankModel>>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var banksResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var arrayResponse = JsonSerializer.Deserialize<List<BankModel>>(banksResponse);

                List<BankModel> banks = new();

                try
                {
                    
                    response.StatusCodeHttp = responseBrasilApi.StatusCode;
                    response.ReturnData = arrayResponse;
                }
                catch (Exception ex)
                {
                   
                    response.StatusCodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(banksResponse);
                }
                return response;
                
            }
           
            
        }

        public Task<ResponseGeneric<BankModel>> GetBank(string bankCode)
        {
            throw new NotImplementedException();
        }

        
    }
}
