log4net Provider for Neuron ESB SDK
===================================
Please see LICENSE.md for license information.

This repository contains the source code for a sample logging provider
that can be used with the Neuron ESB 3.5 and later SDKs to output
logging information at runtime using the [log4net](http://logging.apache.org/log4net).

Background
----------
Prior to Neuron ESB 3.1, Neuron used two facilities for outputting
diagnostic information and events at runtime: writing directly to the
Windows Event Log, and using the classes in the System.Diagnostics
namespace to write to trace files. We heard from customers that they
were looking for other logging features to integrate with what the
customers were using, with log4net being the most common. In Neuron ESB
3.1, we introduced log4net into the Neuron ESB SDK and programs not
only to meet our customer requests, but to use the configurability and
extensibility of log4net's logging features.

After receiving feedback from customers, we extended the logging
facility in Neuron ESB 3.5 to provide a pluggable provider-based model
for logging. This would allow customers to be able to integrate the
logging platform of their choice into the Neuron ESB SDK in order to
allow the Neuron ESB SDK components to output to the same locations or
logging services that customers are using for their software.

Note that this pluggable model is only for use with customer solutions
that are linking against the Neuron ESB SDK. The Neuron ESB
applications such as the ESB Windows service will continue to use
log4net for our logging output.

Software Requirements
---------------------
To build the log4net provider assembly, you will need:

* [Visual Studio 2013](http://www.visualstudio.com)

Building the Software
---------------------
From the command line, you can use MSBuild to build the project:

    > msbuild.exe log4net-provider.sln

You can also use Visual Studio to build the project. Open the
**log4net-provider.sln** solution and build from within the Visual
Studio IDE.

Using the log4net Provider
--------------------------
In order to use the log4net provider in custom Neuron ESB applications,
you need to register the provider at runtime. The logging provider must
be registered with the **Neuron.Esb.Logging.LogManager** class:

```csharp
Neuron.Esb.Logging.LogManager.SetLogprovider(new Log4netProvider());
```
