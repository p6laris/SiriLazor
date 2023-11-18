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
Both components have several options to be set to customize the wave:

##### ClassicWave
| Parameter                      | Type                                      | Description                                     | Default  |
|-------------------------------|-------------------------------------------|-------------------------------------------------|----------|
| `Ratio`                       | `double?`                                 | Ratio of the display to use.                     | calculated |
| `Speed`                       | `double?`                                 | The speed of the animation.                      | 0.2|
| `Amplitude`                   | `double?`                                 | The amplitude of the complete wave-form.         | 1.0|
| `Frequency`                   | `double?`                                 | The frequency of the complete wave-form.         | 6.0|
| `Color`                       | `string?`                                 | The hex color of the wave.                       | #ffffff|
| `Cover`                       | `bool?`                                   | The canvas covers the entire width or height of the container  | false|
| `Width`                       | `double?`                                 | Sets the width parameter.                        | 600.0 |
| `Height`                      | `double?`                                 | Sets the height parameter.                       | 200.0 |
| `Autostart`                   | `bool?`                                   | Decide wether start the animation on boot     | false    |
| `PixelDepth`                  | `double?`                                 | Number of step (in pixels) used when drawed on canvas. | 0.2   |
| `LerpSpeed`                   | `double?`                                 | Lerp speed to interpolate properties.                 | 0.01      |
| `Definitions`                 | `IEnumerable<ClassicWaveCurveDefintion>?` | Override definition of the curves, check the [siriwave.js](https://github.com/kopiro/siriwave/).      | null    |
| `GlobalCompositeOperation`    | `string?`                                 | GlobalCompositeOperation of the canvas, controls wave overlap design.  | "lighter"      |

##### IOS9Wave

| Parameter                      | Type                                      | Description                                     | Default  |
|-------------------------------|-------------------------------------------|-------------------------------------------------|----------|
| `Ratio`                       | `double?`                                 | Ratio of the display to use.                     | calculated |
| `Speed`                       | `double?`                                 | The speed of the animation.                      | 0.2|
| `Amplitude`                   | `double?`                                 | The amplitude of the complete wave-form.         | 1.0|
| `Cover`                       | `bool?`                                   | The canvas covers the entire width or height of the container  | false|
| `Width`                       | `double?`                                 | Sets the width parameter.                        | 600.0 |
| `Height`                      | `double?`                                 | Sets the height parameter.                       | 200.0 |
| `Autostart`                   | `bool?`                                   | Decide wether start the animation on boot     | false    |
| `PixelDepth`                  | `double?`                                 | Number of step (in pixels) used when drawed on canvas. | 0.2   |
| `LerpSpeed`                   | `double?`                                 | Lerp speed to interpolate properties.                 | 0.01      |
| `iOS9Ranges`                  | `IOS9WaveRanges?`                         | Sets the iOS 9 wave ranges parameter, check the [siriwave.js](https://github.com/kopiro/siriwave/).            | null       |
| `Definitions`                 | `IEnumerable<IOS9WaveCurveDefintion>?` | Override definition of the curves, check the [siriwave.js](https://github.com/kopiro/siriwave/).      | null    |
| `GlobalCompositeOperation`    | `string?`                                 | GlobalCompositeOperation of the canvas, controls wave overlap design.  | "lighter"      |

For setting the GlobalCompositeOperation, you can use `GlobalCompositeOperation` static class.

##### Default Options
You can just use `SetDefaultOptions` parameter to set the options to default:

 ```razor
  @using SiripLazor.UI;

  <IOS9Wave SetDefaultOptions></IOS9Wave>
   ```
##### SiriObject
By refrencing both components you can access `SiriLazor` object, the object holds the index of the component so it can access it's animation.

 ```razor
  @using SiripLazor.UI;

  <ClassicWave SetDefaultOptions @ref="wave"></ClassicWave>

  @code{
    ClassicWave wave;

    async Task Stop() => await wave.Stop();
   }
   ```
##### Methods

- **Stop:**
  - *Description:* Stops the SiriWave animation.
  - *Usage:* `await Stop();`

- **Start:**
  - *Description:* Starts the SiriWave animation.
  - *Usage:* `await Start();`

- **SetSpeed(animated):**
  - *Description:* Sets the speed of the SiriWave animation to the specified value.
  - *Usage:* `await SetSpeed(double value);`

- **SetAmplitude(animated):**
  - *Description:* Sets the amplitude of the SiriWave to the specified value.
  - *Usage:* `await SetAmplitude(double value);`

- **DisposeAsync:**
  - *Description:* Disposes of the SiriWave, cleaning up associated resources.
  - *Usage:* `await DisposeAsync();`
 
## Example

:bookmark_tabs: See the full example [here](https://github.com/p6laris/SiriLazor/blob/master/SiriLazor.WASM/Components/Pages/Home.razor).

## License
[MIT](https://github.com/p6laris/SiriLazor/blob/master/LICENSE.txt)

