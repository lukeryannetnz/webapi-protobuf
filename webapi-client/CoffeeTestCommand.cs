using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;
using Synoptic;
using WebApiContrib.Formatting;
using webapi_protobuf.contracts;

namespace webapi_client
{
    [Command(Name = "coffeetest", Description = "Tests the coffee resource of the web api.")]
    public class CoffeeTestCommand
    {
        [CommandAction]
        public void Json(int threads, int requests)
        {
            Test(threads, requests, DoJsonTest);
        }

        private void Test(int threads, int requests, Func<int, int, double> testFunc)
        {
            Console.WriteLine("Starting test with {0} threads for {1} requests", threads, requests);

            Task[] testTasks = new Task[threads];
            double[] latency = new double[threads];

            for (int i = 0; i < threads; i++)
            {
                int threadId = i;
                testTasks[i] = (Task.Run(() => latency[threadId] = testFunc(threadId, requests)));
            }

            Task.WaitAll(testTasks);

            Console.WriteLine("Average response time: {0}ms", latency.Average());
        }

        private double DoJsonTest(int threadId, int numberOfRequests)
        {
            var client = new RestClient("http://localhost:4472/api");
            var request = new RestRequest("coffees/", Method.GET);
            request.AddHeader("accept", "application/json");

            long[] times = new long[numberOfRequests];

            for (int i = 0; i < numberOfRequests; i++)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();

                var response = client.Get<List<Coffee>>(request);
            
                watch.Stop();
                Console.WriteLine("Thread {0}, {1} ms, {2} bytes, {3} status code", threadId, watch.ElapsedMilliseconds,
                    response.RawBytes.Length, response.StatusCode);
                if (i > 0)
                {
                    times[i] = watch.ElapsedMilliseconds;
                }
            }

            return times.Average();
        }
    }
}