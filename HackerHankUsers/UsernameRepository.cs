using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HackerHankUsers
{
	public class UsernameRepository
	{
        public List<string> getUsernames(int threshold)
        {
            var lista = this.obterUsernames(threshold);

            var names = lista.Select(x => x.username).ToList();

            var nomesOrdenados = names.OrderBy(x => x).ToList();

            return nomesOrdenados;
        }

        public List<UsernameResponse> obterUsernames(int threshold)
        {
            using (var webClient = new WebClient())
            {
                string api = string.Format("https://jsonmock.hackerrank.com/api/article_users/search?page={0}", threshold);
                var response = webClient.DownloadString(api);

                JObject result = JObject.Parse(response);

                var users = result.SelectToken("data");

                var usersResponse = users.ToObject(typeof(List<UsernameResponse>));

                var k = (List<UsernameResponse>)usersResponse;

                return k;
            }
        }


    }
}
