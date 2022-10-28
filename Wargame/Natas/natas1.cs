using System.Net.Http;
using System.Text;

HttpClient client = new HttpClient();
client.BaseAddress = new Uri("http://natas1.natas.labs.overthewire.org");
string credential = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes("natas1:???????????????????????????????????????"));

HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "/index.html");
request.Headers.Add("Authorization", "Basic " + credential);

HttpResponseMessage httpResponse = await client.SendAsync(request);
httpResponse.EnsureSuccessStatusCode();
String body = await httpResponse.Content.ReadAsStringAsync();
Console.WriteLine(body) ;
