# MTConnect.Client
MTConnect is a read-only protocol for facilitating the exchange of data between shop floor equipment and software applications.

It emits data represented in XML. The schemas for the entities represented by MTConnect are here: https://github.com/mtconnect/schema.

When I first encountered the standard, I got excited about how it is easy to surface data from the shop floor for immediate consumption. It is basically just making REST calls to an agent that provides the data from the equipment connected to it.

As I explored the standard further, as it is defined on http://www.mtconnect.org/, I noticed there are no Swagger (OpenAPI) specifications for the API. So I decided to put together one.

More reading on OpenAPI is here, https://www.openapis.org/. Once you have a specification of the API, it is easy to generate stub code for a service, and a client library for it.

## Story

As I started working on this project during a weekend, I encountered a few issues. 
