# UPFloder

A service to bypass the restrictions of 1 to X Iranian servers...

# Install
#### Ubuntu:
```bash

sudo apt install gnupg ca-certificates

sudo apt-key adv –keyserver hkp://keyserver.ubuntu.com:80 –recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

echo deb https://download.mono-project.com/repo/ubuntu stable-focal main | sudo tee /etc/apt/sources.list.d/mono-official-stable.list

sudo apt update

sudo apt upgrade

sudo apt install mono-complete wget unzip

//On Server Side:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder-server.linux.x86_x64.zip

unzip upfloder-server.linux.x86_x64.zip

//On Client Side:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder.linux.x86_x64.zip

unzip upfloder.linux.x86_x64.zip
```

#### Centos:
```bash

sudo yum update

sudo yum upgrade

sudo yum install mono-complete wget unzip

//On Server Side:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder-server.linux.x86_x64.zip

unzip upfloder-server.linux.x86_x64.zip

//On Client Side:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder.linux.x86_x64.zip

unzip upfloder.linux.x86_x64.zip
```

#### Termux:
```bash

sudo pkg update

sudo pkg upgrade

sudo pkg install mono-complete wget unzip

//On Server Side:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder-server.linux.x86_x64.zip

unzip upfloder-server.linux.x86_x64.zip

//On Client Side:

wget https://github.com/MG-Token/upfloder/releases/download/V1.0.0.0/upfloder.linux.x86_x64.zip

unzip upfloder.linux.x86_x64.zip
```

#### Windows:
Download and install .NET Framework 4.8 and choose a [Releases](https://github.com/MG-Token/upfloder/releases)

# Using
#### Ubuntu/Centos/Termux:
```bash

//On Client Side:

mono upfloder your_server_ip port size thread&consize

//On Server Side:

mono upfloder-server port
```
#### Windows:
open a cmd and cd to path and use this command:
```bash
//On Client Side:

upfloder your_server_ip port size thread&consize

//On Server Side:

upfloder-server port
```
#### ARGS:
```bash

```
