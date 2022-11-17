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
```
your_server_ip: is an ip adreass where upfloder-server is running or you can use dns servers like 1.1.1.1 or 8.8.8.8 (Default: 127.0.0.1)
port: is an a port number to connect with udp protcol where upfloder-server is runned or if you use dns adreass like 1.1.1.1 must set on port 53 (Default: 8090)
size: number of MB size must be transport if set on 0 its will upload unlimeted bytes...
thread&consize: number of thread or connection to use...
```
#### Example:

Client:

```bash
upfloder 127.0.0.1 8090 0 25
```
![c](https://user-images.githubusercontent.com/20111218/202410572-f4ed19da-22da-49d0-9d31-1216d96b9f00.jpg)

Server:

```bash
upfloder-server 8090
```
![s](https://user-images.githubusercontent.com/20111218/202410576-65b95b7a-9792-454e-98e3-bf6791d3d57a.jpg)

# Specifications

No buffer limit

No RAN-CPU usage

No data save 

Fast-High speed (UDP)

Using Random Byte array(0-255) and Random Buffer size (60000-65000 standrad udp buf size)

Undetectable

# Donate

USDT TRC20: ```TNjbCfcg2mMokxnbWFkNJJRS8KpFEBxx9X```



