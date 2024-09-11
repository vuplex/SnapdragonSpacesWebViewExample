using UnityEngine;
using UnityEngine.XR;
using Vuplex.WebView;

/// <summary>
/// Provides a simple example of using 3D WebView's scripting APIs.
/// </summary>
/// <remarks>
/// Links: <br/>
/// - CanvasWebViewPrefab docs: https://developer.vuplex.com/webview/CanvasWebViewPrefab <br/>
/// - How clicking works: https://support.vuplex.com/articles/clicking <br/>
/// - Other examples: https://developer.vuplex.com/webview/overview#examples <br/>
/// </remarks>
public class SnapdragonSpacesWebViewExample : MonoBehaviour {

    CanvasWebViewPrefab canvasWebViewPrefab;

    void Awake() {

        // Use a desktop User-Agent to request the desktop versions of websites.
        // https://developer.vuplex.com/webview/Web#SetUserAgent
        Web.SetUserAgent(false);

        // Increase this setting to reduce aliasing.
        // https://support.vuplex.com/articles/how-to-fix-aliasing-on-Android
        XRSettings.eyeTextureResolutionScale = 2;
    }

    async void Start() {

        // Get a reference to the CanvasWebViewPrefab.
        // https://support.vuplex.com/articles/how-to-reference-a-webview
        canvasWebViewPrefab = GameObject.Find("CanvasWebViewPrefab").GetComponent<CanvasWebViewPrefab>();

        // Wait for the prefab to initialize because its WebView property is null until then.
        // https://developer.vuplex.com/webview/WebViewPrefab#WaitUntilInitialized
        await canvasWebViewPrefab.WaitUntilInitialized();

        // After the prefab has initialized, you can use the IWebView APIs via its WebView property.
        // https://developer.vuplex.com/webview/IWebView
        canvasWebViewPrefab.WebView.UrlChanged += (sender, eventArgs) => {
            Debug.Log("[SnapdragonSpacesWebViewExample] URL changed: " + eventArgs.Url);
        };
    }
}
