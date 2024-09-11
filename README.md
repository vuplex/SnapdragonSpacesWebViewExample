# Snapdragon Spaces WebView Example

This Unity project demonstrates how to view and interact with web content in VR using [Vuplex 3D WebView](https://developer.vuplex.com/webview/overview) and the [Snapdragon Spaces SDK](https://spaces.qualcomm.com/developer/). This project was tested using the Levovo ThinkReality headset, although it could potentially be modified to support other headsets. The project includes the Snapdragon Spaces SDK, so the only additional thing you must import is [3D WebView for Android](https://store.vuplex.com/webview/android).

Note: 3D WebView's native Android plugins can't run in the editor, so a [mock webview](https://support.vuplex.com/articles/mock-webview) implementation is used by default while running in the editor unless [3D WebView for Windows and macOS](https://store.vuplex.com/webview/windows-mac) is also installed.

## Steps taken to create this project

1. Created a new project with Unity 2022.3.42 using the default 3D project template.
2. Imported the following packages:
    - com.qualcomm.snapdragon.spaces@0.23.0 + the package's optional Samples
    - com.qualcomm.qcht.unity.interactions@4.1.7 + the package's optional Samples
3. Made a copy of the "XR Interaction Toolkit Sample" scene from the Snapdragon Spaces SDK's samples.
4. Imported [3D WebView for Android](https://store.vuplex.com/webview/android).
5. Made the following modifications to the "XR Interaction Toolkit Sample" scene copy:
    - Renamed the scene to SnapdragonSpacesWebViewExample.
    - Added a [CanvasWebViewPrefab](https://developer.vuplex.com/webview/CanvasWebViewPrefab) and [CanvasKeyboard](https://developer.vuplex.com/webview/CanvasKeyboard) to the scene's Canvas.
    - Set the Canvas's event camera to the scene's AR Camera.
    - Removed unneeded objects from the scene.
    - Added the SnapdragonSpacesWebViewExample.cs script to demonstrate using 3D WebView's scripting APIs.
