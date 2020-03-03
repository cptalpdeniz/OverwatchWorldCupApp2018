<p align="center">
  <img width="500" height="" src="https://raw.githubusercontent.com/cptalpdeniz/OverwatchWorldCupApp2018/master/Resources/IconFinal.png">
</p>

# Overwatch World Cup 2018 App

A cross-platform mobile App created using Xamarin.Forms for iOS and Android.

## About

A companion app for players and viewers to follow the 2018 Overwatch World Cup tournament. More information about the tournament can be found [here](https://liquipedia.net/overwatch/Overwatch_World_Cup/2018) on the Liquipedia page. This mobile application was created using Xamarin.Forms Framework, written in C# using .NET Standart 2.0, compable with iOS 10+ and Android 6.0. 

## Features

* Displaying live games and past games
* Live stream information from Twitch
* Live score and match information
* News regarding Overwatch World Cup (Teams, players, events, matches, etc.)
* Network Connection Checks
* Loading Screen
* List of Countries and brief information about them
* Information about Group stages (location, countries, scores, etc.)


## Build

You clone the entire repo and try to build it using Visual Studio. However, some of the services the app is using require some sort of key/Client ID. For security purposes these are removed from source code. For instance the `TwitchClass` class. As it can be seen on Line [31](https://github.com/cptalpdeniz/OverwatchWorldCupApp2018/blob/907464ab5f99eeb36546a9504877e2bef9309984/OWWC.MULTI/TwitchClass.cs#L31), the API requires `Client-ID` property to be passed.
 

1. Clone the repo to a local directory

```
git clone https://github.com/cptalpdeniz/OverwatchWorldCupApp2018.git
```

2. Open the `.sln` file using Visual Studio. This project was developed on Visual Studio 2017. Latest version is suggested.
3. Get the necessary keys OR make changes on the code and build it.

**Disclamer**
Since the tournament is over and most of the sources on the web are either moved, deleted or changed, I'm not expecting the build to be successful. 

## Current Status of This Project

This project is NOT finished. I would love to finish it however it was impossible to finish it in 2018 before the start of the tournament for couple of reasons:

1. **Lack of support from support and funding from Blizzard Entertainment.**
Even though I tried to contact Blizzard and Overwatch team multiple times using different channels, I didn't get any response. Therefore nonexisting  APIs made everything really hard as there was no way to get live match data or data in general (which is up-to-date and updated frequently) effectively and accurately. This made me take extraordinary measures, for instance extracting and manipulating DOM of some websites to get data regarding past matches.
2. **Timing issues caused by school and personal life meant that there was not enough time to fully developed the by myself in time for the start of the tournament.**
Working on a project this scale while also studying Computer Engineering was not easy and meant that I had to compromise some things. Moreover, I had very lot of personal issues that I had to dealt with which meant I had to spent less time working on the project. I had lot of things planned, Notification services, ability to follow certain countries, live Twitch stream inside the App, ... etc.
3. **The code is very UNOPTIMIZED.**
There are SO MANY things that can be improved in the code, performance , memory management, UI flow are name of few. I'm aware how unoptimized this code is and I'm also aware of the improvements that can be made. However, as said before, there's no reason to apply these fixes as of today as the tournament was organized 2 years ago.


## Deployment


## Built With

This project was built using the following NuGet packages and their respective version numbers.

| Package 		      		| Version       |
| --------------------------|:-------------:|
| Xamarin.Forms  			| 3.2.0.839982  |
| Newtonsoft.Json  			| 11.0.2        |
| HtmlAgilityPack 			| 1.8.7	        |
| Xam.Plugin.Connectivity   | 3.2.0	        |
| TwitchLib		 			| 2.1.5	        |

Software used:
* [Visual Studio](https://visualstudio.microsoft.com/) - Visual Studio 2017
* [Adobe Illustrator](https://www.adobe.com/products/illustrator.html) - Adobe Illustrator used for country flags and icons


## Versioning

As the app was still in development, versioning cannot be done at the moment.

## Authors

* **Alp Deniz Senyurt** - *Development* - [cptalpdeniz](https://github.com/cptalpdeniz)

## License

This project is licensed under the Apache License 2.0 - see the [LICENSE.md](https://github.com/cptalpdeniz/OverwatchWorldCupApp2018/blob/master/LICENSE) file for details.

**DISCLAIMER**
This app has NO commercial intention, was developed only as a companion app to people who want to follow the world cup. Necessary copyright notices

®2016 Blizzard Entertainment, Inc. All rights reserved. Overwatch is a trademark or registered trademark of Blizzard Entertainment, Inc. in the U.S. and/or other countries.

## Acknowledgments

* Yigit Ege Koc - For helping me when I feel like I'm stuck and pushing me to even start this project in the beginning
