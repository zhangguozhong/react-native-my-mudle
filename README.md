
# react-native-my-mudle

## Getting started

`$ npm install react-native-my-mudle --save`

### Mostly automatic installation

`$ react-native link react-native-my-mudle`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-my-mudle` and add `RNMyMudle.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNMyMudle.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNMyMudlePackage;` to the imports at the top of the file
  - Add `new RNMyMudlePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-my-mudle'
  	project(':react-native-my-mudle').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-my-mudle/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-my-mudle')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNMyMudle.sln` in `node_modules/react-native-my-mudle/windows/RNMyMudle.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using My.Mudle.RNMyMudle;` to the usings at the top of the file
  - Add `new RNMyMudlePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNMyMudle from 'react-native-my-mudle';

// TODO: What to do with the module?
RNMyMudle;
```
  