# Microservice.PoC.Steeltoe

## Steeltoe

[![N|Steeltoe](https://www.cnblogs.com/images/cnblogs_com/edisonchou/1260867/o_logo-banner.PNG)](http://steeltoe.io/)<br/>
Steeltoe is an open source project that enables .NET developers to implement industry standard best practices when building resilient microservices for the cloud. The Steeltoe client libraries enable .NET Core and .NET Framework apps to easily leverage Netflix Eureka, Hystrix, Spring Cloud Config Server, and Cloud Foundry services.<br/>
For more details, please read its [offical website](http://steeltoe.io/). <br/>
What's more, Pivotal provide a sample application on [Github](https://github.com/SteeltoeOSS/Samples/tree/master)

Steeltoe enable .NET/.NET Core to use the below components at this moment:
  - Service Discovery
  - Config Server
  - Circuit Breaker
  - Cloud Connectors

## About this sample

[![N|ASP.NET Core](https://www.cnblogs.com/images/cnblogs_com/edisonchou/1260867/o_aspnet-core-logo.PNG)](https://docs.microsoft.com/zh-cn/aspnet/core/getting-started/?view=aspnetcore-2.1&tabs=windows)<br/>
This sample is a microservice project developed by ASP.Net Core with Spring Cloud based on Steeltoe, it integrated with the below Spring Cloud components:
  - Eureka : [Java-EurekaServer](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/springcloud/eureka-service), [Chapter1-ServiceDiscovery](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/src/Chapter1-ServiceDiscovery)
  - Zuul : [Java-ZuulServer](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/springcloud/zuul-service), [Chapter1-ServiceDiscovery](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/src/Chapter1-ServiceDiscovery)
  - Hystrix : [Java-Dashboard](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/springcloud/hystrix-dashboard-service), [Chapter2-CircuitBreaker](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/src/Chapter2-CircuitBreaker)
  - Config Server : [Java-ConfigServer](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/springcloud/config-service), [Chapter3-ConfigServer](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/src/Chapter3-ConfigServer)
  - Distributed Tracing : [Java-ZipkinServer](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/springcloud/zipkin-service), [Chapter4-DistributedTracing](https://github.com/Manulife-Chengdu/Microservice.PoC.Steeltoe/tree/master/src/Chapter4-ServiceTracing)

## Some test captured screens

###Service Discovery :
![N|Eureka](https://img2018.cnblogs.com/blog/381412/201809/381412-20180920173123942-2143310225.png)<br/>
###API Gateway :<br/>
![N|Zuul](https://img2018.cnblogs.com/blog/381412/201809/381412-20180921163231618-437962436.gif)<br/>
###Circuit Breaker :<br/>
![N|Hystrix](https://img2018.cnblogs.com/blog/381412/201809/381412-20180922160952015-906146994.png)<br/>
![N|Dashboard](https://img2018.cnblogs.com/blog/381412/201809/381412-20180922170910285-1543840080.png)<br/>
###Config :<br/>
![N|Config](https://img2018.cnblogs.com/blog/381412/201809/381412-20180925002435834-1954906744.png)<br/>
###Distributed Tracing :<br/>
![N|Zipkin](https://img2018.cnblogs.com/blog/381412/201809/381412-20180930234524872-43266842.png)

## Installation

To use Steeltoe in .Net Core, we can use the below NuGet packages:<br/>
Service Discovery Client
```sh
PM> Install-Package Pivotal.Discovery.ClientCore
```
Circuit Breaker Core
```sh
PM> Install-Package Steeltoe.CircuitBreaker.HystrixCore
```
Hystrix Metrics
```sh
PM> Install-Package Steeltoe.CircuitBreaker.Hystrix.MetricsEventsCore
```
Config
```sh
PM> Install-Package Steeltoe.Extensions.Configuration.ConfigServerCore
```
Distributed Tracing
```sh
PM> Install-Package Steeltoe.Extensions.Logging.DynamicLogger 
PM> Install-Package Steeltoe.Management.ExporterCore　　　　 
PM> Install-Package Steeltoe.Management.TracingCore
```

## Rerference

  - [.NET Core微服务之基于Steeltoe使用Spring Cloud Eureka实现服务注册与发现](https://www.cnblogs.com/edisonchou/p/dotnet_core_microservice_integrate_with_springcloud_eureka.html)
  - [.NET Core微服务之基于Steeltoe集成Spring Cloud Zuul实现统一API网关](https://www.cnblogs.com/edisonchou/p/dotnet_core_microservice_integrate_with_springcloud_zuul.html)
  - [.NET Core微服务之基于Steeltoe集成Spring Cloud Hystrix实现熔断保护与可视化监控](https://www.cnblogs.com/edisonchou/p/dotnet_core_microservice_integrate_with_springcloud_hystrix.html)
  - [.NET Core微服务之基于Steeltoe使用Spring Cloud Config统一管理配置](https://www.cnblogs.com/edisonchou/p/dotnet_core_microservice_integrate_with_springcloud_config.html)
  - [.NET Core微服务之基于Steeltoe使用Zipkin实现分布式追踪](https://www.cnblogs.com/edisonchou/p/dotnet_core_microservice_integrate_with_zipkin.html)