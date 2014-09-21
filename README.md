webapi-protobuf
===============

Experimenting with google protocol buffers and .Net Web Api

##Overview
Basic ASP.NET WebAPI2 service that returns a list of coffee drinks that uses [protobuf-net](https://github.com/mdavid/protobuf-net) and [WebApiContrib.Formatting.ProtoBuf](https://github.com/WebApiContrib/WebApiContrib.Formatting.ProtoBuf) to support content type negotiation for google protobuffers.

##Performance over loopback
There is a simple .NET test client however I soon abandoned this in favour of [go boom](https://github.com/rakyll/boom) as it provided the benchmarking functionality I was looking for. The following results are samples from many test runs conducted on my local virtualised dev-box over loopback.
###JSON
    PS C:\Users\Luke\GoCode\bin> .\boom.exe -n 10000 -c 50 -h Accept:application/json  -m GET http://webapiprotobuf/api/coff
    ees/
    10000 / 10000 Booooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo! 100.00 %

    Summary:
      Total:        12.2315 secs.
      Slowest:      0.2403 secs.
      Fastest:      0.0254 secs.
      Average:      0.0610 secs.
      Requests/sec: **817.5640**
      Total Data Received:  21970000 bytes.
      Response Size per Request:    **2197** bytes.

    Status code distribution:
      [200] 10000 responses

    Response time histogram:
      0.025 [1]     |
      0.047 [452]   |??
      0.068 [7697]  |????????????????????????????????????????
      0.090 [1415]  |???????
      0.111 [317]   |?
      0.133 [64]    |
      0.154 [5]     |
      0.176 [9]     |
      0.197 [0]     |
      0.219 [1]     |
      0.240 [39]    |

    Latency distribution:
      10% in 0.0488 secs.
      25% in 0.0517 secs.
      50% in 0.0576 secs.
      75% in 0.0645 secs.
      90% in 0.0771 secs.
      95% in 0.0858 secs.
      99% in 0.1143 secs.

Notice the content size over the wire (**2197 bytes**) and requests per second (**817**).

###Protobuf
    PS C:\Users\Luke\GoCode\bin> .\boom.exe -n 10000 -c 50 -h accept:application/x-protobuf  -m GET http://webapiprotobuf/ap
    i/coffees/
    10000 / 10000 Booooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo! 100.00 %

    Summary:
      Total:        11.2031 secs.
      Slowest:      0.3095 secs.
      Fastest:      0.0195 secs.
      Average:      0.0559 secs.
      Requests/sec: **892.6064**
      Total Data Received:  7880000 bytes.
      Response Size per Request:    788 bytes.

    Status code distribution:
      [200] 10000 responses

    Response time histogram:
      0.020 [10]    |
      0.049 [3011]  |??????????????????
      0.078 [6493]  |????????????????????????????????????????
      0.107 [346]   |??
      0.136 [50]    |
      0.165 [40]    |
      0.194 [0]     |
      0.223 [20]    |
      0.252 [0]     |
      0.281 [0]     |
      0.310 [30]    |

    Latency distribution:
      10% in 0.0440 secs.
      25% in 0.0478 secs.
      50% in 0.0527 secs.
      75% in 0.0596 secs.
      90% in 0.0703 secs.
      95% in 0.0772 secs.
      99% in 0.1347 secs.
Protobuf content size is significantly smaller (**788 bytes**) with incresed requests per second (**892**).

##Performance over a busy network with latency
Todo