webapi-protobuf
===============

Experimenting with google protocol buffers and .Net Web Api

##Overview
Basic ASP.NET WebAPI2 project that uses protobuf-net and WebApiContrib.Formatting.ProtoBuf to support content type negotiation for google protobuffers.

##Performance over loopback
There is a simple .NET test client however I soon abandoned this in favour of [go boom](https://github.com/rakyll/boom) as it provided the benchmarking functionality I was looking for. The following results are samples from many test runs conducted on my local virtualised dev-box over loopback.
###JSON
<img href="./Boom-JSON.PNG" />
Notice the content size over the wire (2197 bytes) and requests per second (817).

###Protobuf
<img href="./Boom-Protobuf.PNG"/>
Protobuf content size is significantly smaller 788 bytes) with incresed requests per second (892).

##Performance over a busy network with latency
Todo