# SiriLazor
[![NuGet](https://img.shields.io/nuget/dt/SiriLazor?logo=nuget)](https://www.nuget.org/packages/SiriLazor)
![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/p6laris/SiriLazor)

[Sirwave.js](https://github.com/kopiro/siriwave) wrapper for blazor to generate siri-wave animations in both classic and IOS9+ Styles.

![alt text](https://github.com/p6laris/SiriLazor/blob/master/SiriLazor/SiriLazor_160x160.png?raw=true)

## Classical Style
Before IOS9 style

![Classical Wave](https://github.com/p6laris/SiriLazor/blob/master/SiriLazor/classicWave.gif)

## IOS9 Style
The IOS9 style

![Classical Wave](https://github.com/p6laris/SiriLazor/blob/master/SiriLazor/ios9Wave.gif)

## Installation
1. Install [SiriLazor](https://www.nuget.org/packages/SiriLazor) with dotnet cli in your Blazor app.

  ```sh
  dotnet add package SiriLazor 
  ```
  ```C#
  using SiriLazor.Component.Extention;

  // Inside your ConfigureServices method
  builder.Service.AddSiriLazor();
  ```
3.Add these two script tag in your root file **_Host.cshtml for Blazor Server Apps** or **index.html for Blazor WebAssembly Apps**:
  ```html
  <script src="_framework/blazor.webassembly.js"></script>
  <script src="_content/SiriLazor/siriWave.js" type="text/javascript"></script>
  <script src="_content/SiriLazor/siriLazorInterop.js" type="text/javascript"></script>
  ```
## Usage
After you installed SirLazor, then you can use the SiriLazor's components:

#### 1. Classic Style

  ```razor
  @using SiripLazor.UI;

  <ClassicWave SetDefaultOptions></ClassicWave>
   ```
#### 2. IOS9 Style

  ```razor
  @using SiripLazor.UI;

  <IOS9Wave SetDefaultOptions></IOS9Wave>
   ```
### Options
Both components have several options to be set
