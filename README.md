# GenericLoggingHelper
Support both log4net and NLog in your libraries with this generic layer.

Nuget: https://packages.nuget.org/packages/GenericLoggingHelper/

I like to write utility libraries that can be used in other projects.  However when writing these low-level projects you can't assume that a particular logging library will be inlcuded, and it's kind of a jerk-move to include a logging library dependency in your nuget package.  So I created this project.  It's a thin layer that can sit on top of log4net or NLog.  

This is not a DLL, just some code you include in your project.

* If log4net DLL is present, it will use log4net. 
* If NLog DLL is present, it will use NLog.
* If neither is present, and it's a debug build, it will log to console, but that's easy to change.
* If neither DLL is present, (and it's not debug build) it will not log anything (but that's easy to change if you want console logging, etc.)
* If your favorite logging library isn't log4net or NLog, then please feel free to include it in the LogManager and send me a pull request.


