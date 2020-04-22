# XbfGenExtractor
Utility to extract type information from XbfGen.dll for usage in [XbfAnalyzer](https://github.com/misenhower/XbfAnalyzer).

## Usage
To extract types from a newer version of XbfGen.dll, add another call to `Extract` in the `Main` method. 
The necessary offsets and counts have to be determined manually, e.g. by loading the DLL into a debugger and using debug symbols from the Microsoft Symbol Server to locate them.

By default, the tool extracts type information from multiple versions of the DLL and merges the results to obtain a more complete output.
Alternatively, you may extract information from just the latest version of the DLL but you will find some of the type entries missing (probably because those types have only temporarily existed and were later removed from the framework).

The output of the tool can be pasted directly into https://github.com/misenhower/XbfAnalyzer/blob/master/XbfAnalyzer/Xbf/XbfFrameworkTypes.cs.