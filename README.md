# Slave Matrix Decomp
This is an effort to decompile, optimize, and add modding support to "Slave Matrix" by "Auto Eden".

# Building
## Windows
open the solution file with visual studio and build it

## Linux
download the `dotnet` runtime, on arch it is provided by the `dotnet-sdk` package and run `run.sh`

# TODO
- replace System.Drawing with openGL
  - figure out how to render cubic beziers efficiently
- sort out the 900 BodyPart Classes
  - it seems like the compiler did *alot* of inlining so its probably best to abstract that out
  - can't rename classes because C# reflection is used to determine joint types
- look into C# Blazor, it should be possible to compile this to web assembly and run it in the browser
- split game loop into reasonable sections instead of a big state machine
