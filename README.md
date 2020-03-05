# Extensions

<p align="center">
	<img alt="GitHub package.json version" src ="https://img.shields.io/github/package-json/v/Thundernerd/Unity3D-Extensions" />
	<a href="https://github.com/Thundernerd/Unity3D-Extensions/issues">
		<img alt="GitHub issues" src ="https://img.shields.io/github/issues/Thundernerd/Unity3D-Extensions" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-Extensions/pulls">
		<img alt="GitHub pull requests" src ="https://img.shields.io/github/issues-pr/Thundernerd/Unity3D-Extensions" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-Extensions/blob/master/LICENSE.md">
		<img alt="GitHub license" src ="https://img.shields.io/github/license/Thundernerd/Unity3D-Extensions" />
	</a>
	<img alt="GitHub last commit" src ="https://img.shields.io/github/last-commit/Thundernerd/Unity3D-Extensions" />
</p>

Extensions is a simple collection of extensions that I find useful when working with Unity and C#.

## Usage
The extensions that are currently implemented are for the following classes

* [Array](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/ArrayExtensions.cs)
* [GameObject](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/GameObjectExtensions.cs)
* [Linq](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/LinqExtensions.cs)
* [List](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/ListExtensions.cs)
* [Math](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/MathExtensions.cs)
* [Object (runtime)](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/ObjectExtensions.cs)
* [Object (editor)](https://github.com/Thundernerd/Unity3D-Extensions/Editor/ObjectExtensions.cs)
* [String](https://github.com/Thundernerd/Unity3D-Extensions/Runtime/StringExtensions.cs)

## Contributing
Pull requests are welcomed. Please feel free to fix any issues you find, or add new features.

## Installing
Installing Extensions into your Unity3D project is done through the [Package Manager](https://docs.unity3d.com/Manual/Packages.html).

You can either add the package manually to the [manifest.json](https://docs.unity3d.com/Manual/upm-dependencies.html) file:
```json
{
    "dependencies": {
        "net.tnrd.extensions": "https://github.com/Thundernerd/Unity3D-Extensions.git"
    }
}
```

Or add it through the UI by selecting the **+ button** in the top left of the Package Manager, selecting _Add package from git URL..._, and pasting https://github.com/Thundernerd/Unity3D-Extensions.git in the input field.
