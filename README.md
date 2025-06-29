# sharp-snake
Snake written in C#

## Build in Mono
mcs ./src -recurse:'*.cs' -out:./bin/snake.exe

## Run in Mono
mono ./bin/snake.exe

## Dependencies
mono: `sudo apt install mono-devel mono-utils`
.NET: `sudo apt-get update &&   sudo apt-get install -y dotnet-sdk-8.0`
