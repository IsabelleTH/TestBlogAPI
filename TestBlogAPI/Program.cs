using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestBlogAPI.Models;

namespace TestBlogAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBlogPosts().Wait();
        }

        public static async Task GetBlogPosts()
        {
            //Define your baseUrl
            string baseUrl = "http://api.beta.lagenhetsbyte.se/api/Blog/GetBlogPosts?id=1281";
            //Have your using statements within a try/catch block
            try
            {
                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                    using (HttpResponseMessage response = await client.GetAsync(baseUrl))
                    {
                        //Then get the content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = response.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                                //Parse your data into an object 
                                var dataObj = JObject.Parse(data);
                                //Create a new instance of BlogPost
                                BlogPost blogItem = new BlogPost();

                                Console.WriteLine("Blog Post: " + dataObj);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("NO Data----------");
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }
        }
    }
}
