# Lectures on .NET core
This repo contains projects and solutions provided as examples to explain various key concepts in 
* .NET Core
* .NET Standard 
* ASP.NET Core MVC

## Topics for basic understanding of key concepts in .NET Core applications

- Ex_1_NetStandard - Shows compatibility issues with old .NET Framework and .NET Standard library type
- Ex_2_1_DependencyInjection - Registering a service in a IoC container provided natively
- Ex_2_2_DependencyInjectino - Registering a service with its defitinition in a IoC container provided natively.
- Ex_3_KestrelWebHost - Basic configuration of a WebHost using Kestrel as a HTTP server
- Ex_4_1_IConfiguration - Storing and retrieving configuration entries with the IConfiguration service
- Ex_4_2_ConfigurationIOption - Storing and retrieving configuration entries using a POCO class and IOptions pattern
- Ex_5_DependencyInjectionASPNETCore - Registering native and own services with their definitions in a IoC container provided natively.
- Ex_6_HostingEnvironment - Shows possibilities to use 3 types of default hosting environments including own ones.
- Ex_7_1_ConfiguringMiddleware - Configuring an in-line middleware using .Use, .UseWhen, .Map, .MapWhen, .Run methods and delegates.
- Ex_7_2_ClassMiddleware - Create a class for own middleware and an extension method for its calling in the request pipeline
- Ex_8_BundlingMinification - Implementing the bundler and minifier
- Ex_9_RazorDirectives - New files and directives in .NET Core
- Ex_10_DefaultTagHelpers - Native TagHelpers in ASP.NET Core
- Ex_11_CustomtagHelpers - Creating a custom TagHelper and an advanced TagHelper with selfclosing tag and enum attribute
- Ex_12_ViewComponents - Simple example of using separate business logic with ViewComponents
- Ex_13_ControllersAndApi - WebApi with Cotroller base class, return types, decorators
- Ex_14_EfCore_CodeFirst - Code first approach to create database entities and relations
- Ex_15_EfCore_DatabaseFirst - Scaffolding a database context, configuring application to production ready state
- Ex_16_IdentityFramework - using IdentityUser and IdentityRole with the IdentityFramework 2.0 provider with Cookie authentication and Role based authorization
- Ex_17_xunit - simple example of using XUnit to create unit tests and Moq to mock objects and defitnitions
- Ex_18_DockerApp - building a dockerized application and orchestrating the launch of multiple containers using docker-compose

## Advanced concepts and detailed explanation of topics new in .NET Core
- Ex_Ad_6_1_GenericHost - provides various configuration aspects for a non-HTTP host that is used with a HostedService pattern
- Ex_Ad_6_2_KestrelCustomization - provides implementation of storing secrets during development, configuration of a windows HTTP.sys server, implementation of a custom server / http listener hooked on a local folder

# GLHF ... :)
