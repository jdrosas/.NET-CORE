using System.Runtime.CompilerServices;

namespace prj04_01.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            var client = new HttpClient();
            var httpMessage = await client.GetAsync("https://www.eltiempo.com/");
            await Task.Delay(10 * 1000);  //Forzar demora de 10 segundos

            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
