﻿global using Microsoft.Extensions.Logging;
global using Polly;
global using Polly.Retry;
global using RabbitMQ.Client;
global using RabbitMQ.Client.Events;
global using RabbitMQ.Client.Exceptions;
global using System;
global using System.IO;
global using System.Net.Sockets;
global using Autofac;
global using EventBus.Core;
global using EventBus.Core.Abstract;
global using EventBus.RabbitMq.Abstract;
global using EventBus.Core.Events;
global using System.Text;
global using System.Threading.Tasks;
global using System.Text.Json;