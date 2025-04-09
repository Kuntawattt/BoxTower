using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkUIManager : MonoBehaviour
{
    public Button hostButton;
    public Button clientButton;
    public Button serverButton;
    public Button ExitButton; // ปุ่มออกจากเกม
    public GameObject title;
    public GameObject playMode;
    public GameObject Spawner;
    public GameObject Ground;

    void Start()
    {
        hostButton.onClick.AddListener(StartHost);
        clientButton.onClick.AddListener(StartClient);
        serverButton.onClick.AddListener(StartServer);
        ExitButton.onClick.AddListener(ExitGame); // เพิ่ม Listener สำหรับปุ่ม Exit
    }

    void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        playModeStart();
        HideText();
        HideButtons();
    }

    void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        playModeStart();
        HideText();
        HideButtons();
    }

    void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        playModeStart();
        HideText();
        HideButtons();
    }

    void HideButtons()
    {
        hostButton.gameObject.SetActive(false);
        clientButton.gameObject.SetActive(false);
        serverButton.gameObject.SetActive(false);
        ExitButton.gameObject.SetActive(false); // ซ่อนปุ่ม Exit ด้วย
    }

    void HideText()
    {
        title.gameObject.SetActive(false);
    }

    void playModeStart()
    {
        playMode.gameObject.SetActive(true);
        Spawner.gameObject.SetActive(true);
        Ground.gameObject.SetActive(true);
    }

    void ExitGame()
    {
        // ปิดเครือข่ายถ้ามีการทำงานอยู่
        if (NetworkManager.Singleton != null)
        {
            NetworkManager.Singleton.Shutdown();
            Debug.Log("Network shut down.");
        }

        // ออกจากเกม
        Debug.Log("Exiting game...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // หยุด Play Mode ใน Unity Editor
#else
        Application.Quit(); // ปิดแอปพลิเคชันใน Build จริง
#endif
    }
}
