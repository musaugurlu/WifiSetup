# Wifi Setup Exe Program

Exe program that set up wifi on your computer. It looks useless but if you manage a network, you may move this little exe program to computers and set up a script to run it to setup wifi.
You may use powershell or script for this but either you need to move xml file to computer which is not good as the wifi password can be extracted from it or you need to hide xml file in a shared folder which cause error if the computer is not connected to internet at the time the script runs.
So, I found this way. If you like it, feel free to use or change it.

You need to build it with your wifi settings.

The wifi configuration is in `Resources\WifiConf.xml`. Change that file for your wifi settings. and build it.

Basically 3 things to change in Resources\WifiConf.xml file.

* `ProfileName` -> this could be anything you want. 
* `WLanName` -> This is SSID Name
* `P455w0rd` -> This is the wifi password, assuming you set up with WPA2PSK. if not, change the values in XML file accordingly


## Credit
* I have found the source code on stackoverflow.com but I don't remember the full address and autor but this doesn't fully belong to me.

## IDE
* made with Visual Studio 2015