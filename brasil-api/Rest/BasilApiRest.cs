using brasil_api.Dtos;
using brasil_api.Interfaces;
using brasil_api.Models;
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
            var response = new ResponseGeneric<AddressModel>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponde = await responseBrasilApi.Content.ReadAsStringAsync();
                var objectResponse = JsonSerializer.Deserialize<AddressModel>(contentResponde);

                

                if (!responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponde);
                }
                else
                {
                    response.StatusCodeHttp = responseBrasilApi.StatusCode;
                    response.ReturnData = objectResponse;

                }

                return response;
             
            }


        }

        public Task<ResponseGeneric<List<BankModel>>> GetAllBanks()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGeneric<BankModel>> GetBank(string bankCode)
        {
            throw new NotImplementedException();
        }
    }
}
